// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class MetadataTypeOf : Cci.IMetadataExpression
    {
        private readonly Cci.ITypeReference _typeToGet;

        private readonly Cci.ITypeReference _systemType;

        public MetadataTypeOf(Cci.ITypeReference typeToGet, Cci.ITypeReference systemType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(75, 555, 735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(75, 474, 484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(75, 531, 542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(75, 662, 685);

                _typeToGet = typeToGet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(75, 699, 724);

                _systemType = systemType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(75, 555, 735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(75, 555, 735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(75, 555, 735);
            }
        }

        public Cci.ITypeReference TypeToGet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(75, 930, 999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(75, 966, 984);

                    return _typeToGet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(75, 930, 999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(75, 870, 1010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(75, 870, 1010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void Cci.IMetadataExpression.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(75, 1022, 1144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(75, 1113, 1133);

                f_75_1113_1132(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(75, 1022, 1144);

                int
                f_75_1113_1132(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.MetadataTypeOf
                typeOf)
                {
                    this_param.Visit(typeOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(75, 1113, 1132);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(75, 1022, 1144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(75, 1022, 1144);
            }
        }

        Cci.ITypeReference Cci.IMetadataExpression.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(75, 1228, 1255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(75, 1234, 1253);

                    return _systemType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(75, 1228, 1255);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(75, 1156, 1266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(75, 1156, 1266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MetadataTypeOf()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(75, 359, 1273);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(75, 359, 1273);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(75, 359, 1273);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(75, 359, 1273);
    }
}
