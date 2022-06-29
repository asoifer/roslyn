// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class MetadataCreateArray : Cci.IMetadataExpression
    {
        public Cci.IArrayTypeReference ArrayType { get; }

        public Cci.ITypeReference ElementType { get; }

        public ImmutableArray<Cci.IMetadataExpression> Elements { get; }

        public MetadataCreateArray(Cci.IArrayTypeReference arrayType, Cci.ITypeReference elementType, ImmutableArray<Cci.IMetadataExpression> initializers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(73, 826, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(73, 635, 684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(73, 694, 740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(73, 998, 1020);

                ArrayType = arrayType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(73, 1034, 1060);

                ElementType = elementType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(73, 1074, 1098);

                Elements = initializers;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(73, 826, 1109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(73, 826, 1109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(73, 826, 1109);
            }
        }

        Cci.ITypeReference Cci.IMetadataExpression.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(73, 1169, 1181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(73, 1172, 1181);
                    return f_73_1172_1181(); DynAbs.Tracing.TraceSender.TraceExitMethod(73, 1169, 1181);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(73, 1169, 1181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(73, 1169, 1181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void Cci.IMetadataExpression.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(73, 1259, 1281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(73, 1262, 1281);
                f_73_1262_1281(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(73, 1259, 1281);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(73, 1259, 1281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(73, 1259, 1281);
            }

            int
            f_73_1262_1281(Microsoft.Cci.MetadataVisitor
            this_param, Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray
            createArray)
            {
                this_param.Visit(createArray);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(73, 1262, 1281);
                return 0;
            }

        }

        static MetadataCreateArray()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(73, 551, 1289);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(73, 551, 1289);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(73, 551, 1289);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(73, 551, 1289);

        Microsoft.Cci.IArrayTypeReference
        f_73_1172_1181()
        {
            var return_v = ArrayType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(73, 1172, 1181);
            return return_v;
        }

    }
}
