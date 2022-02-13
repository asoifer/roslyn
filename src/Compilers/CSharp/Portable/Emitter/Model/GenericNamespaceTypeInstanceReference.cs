// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class GenericNamespaceTypeInstanceReference : GenericTypeInstanceReference
    {
        public GenericNamespaceTypeInstanceReference(NamedTypeSymbol underlyingNamedType)
        : base(f_10190_776_795_C(underlyingNamedType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10190, 674, 818);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10190, 674, 818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10190, 674, 818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10190, 674, 818);
            }
        }

        public override Microsoft.Cci.IGenericTypeInstanceReference AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10190, 945, 965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10190, 951, 963);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10190, 945, 965);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10190, 830, 976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10190, 830, 976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Microsoft.Cci.INamespaceTypeReference AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10190, 1091, 1111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10190, 1097, 1109);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10190, 1091, 1111);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10190, 988, 1122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10190, 988, 1122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Microsoft.Cci.INestedTypeReference AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10190, 1231, 1251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10190, 1237, 1249);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10190, 1231, 1251);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10190, 1134, 1262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10190, 1134, 1262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Microsoft.Cci.ISpecializedNestedTypeReference AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10190, 1393, 1413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10190, 1399, 1411);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10190, 1393, 1413);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10190, 1274, 1424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10190, 1274, 1424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static GenericNamespaceTypeInstanceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10190, 567, 1431);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10190, 567, 1431);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10190, 567, 1431);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10190, 567, 1431);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10190_776_795_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10190, 674, 818);
            return return_v;
        }

    }
}
