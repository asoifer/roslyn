// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class MetadataNamedArgument : Cci.IMetadataNamedArgument
    {
        private readonly ISymbolInternal _entity;

        private readonly Cci.ITypeReference _type;

        private readonly Cci.IMetadataExpression _value;

        public MetadataNamedArgument(ISymbolInternal entity, Cci.ITypeReference type, Cci.IMetadataExpression value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(74, 800, 1111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 670, 677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 724, 729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 781, 787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1027, 1044);

                _entity = entity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1058, 1071);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1085, 1100);

                _value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(74, 800, 1111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(74, 800, 1111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(74, 800, 1111);
            }
        }

        string Cci.IMetadataNamedArgument.ArgumentName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(74, 1311, 1326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1314, 1326);
                    return f_74_1314_1326(_entity); DynAbs.Tracing.TraceSender.TraceExitMethod(74, 1311, 1326);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(74, 1311, 1326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(74, 1311, 1326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMetadataExpression Cci.IMetadataNamedArgument.ArgumentValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(74, 1491, 1500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1494, 1500);
                    return _value; DynAbs.Tracing.TraceSender.TraceExitMethod(74, 1491, 1500);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(74, 1491, 1500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(74, 1491, 1500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMetadataNamedArgument.IsField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(74, 1671, 1706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1674, 1706);
                    return f_74_1674_1686(_entity) == SymbolKind.Field; DynAbs.Tracing.TraceSender.TraceExitMethod(74, 1671, 1706);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(74, 1671, 1706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(74, 1671, 1706);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void Cci.IMetadataExpression.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(74, 1719, 1841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1810, 1830);

                f_74_1810_1829(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(74, 1719, 1841);

                int
                f_74_1810_1829(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.MetadataNamedArgument
                namedArgument)
                {
                    this_param.Visit((Microsoft.Cci.IMetadataNamedArgument)namedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(74, 1810, 1829);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(74, 1719, 1841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(74, 1719, 1841);
            }
        }

        Cci.ITypeReference Cci.IMetadataExpression.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(74, 1901, 1909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(74, 1904, 1909);
                    return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(74, 1901, 1909);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(74, 1901, 1909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(74, 1901, 1909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MetadataNamedArgument()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(74, 548, 1917);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(74, 548, 1917);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(74, 548, 1917);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(74, 548, 1917);

        string
        f_74_1314_1326(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(74, 1314, 1326);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_74_1674_1686(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(74, 1674, 1686);
            return return_v;
        }

    }
}
