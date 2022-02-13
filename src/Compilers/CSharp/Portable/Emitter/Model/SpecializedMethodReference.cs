// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal class SpecializedMethodReference : MethodReference, Cci.ISpecializedMethodReference
    {
        public SpecializedMethodReference(MethodSymbol underlyingMethod)
        : base(f_10211_765_781_C(underlyingMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10211, 680, 804);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10211, 680, 804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10211, 680, 804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10211, 680, 804);
            }
        }

        public override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10211, 816, 963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10211, 899, 952);

                f_10211_899_951(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10211, 816, 963);

                int
                f_10211_899_951(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ISpecializedMethodReference
                methodReference)
                {
                    this_param.Visit((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10211, 899, 951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10211, 816, 963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10211, 816, 963);
            }
        }

        Cci.IMethodReference Cci.ISpecializedMethodReference.UnspecializedVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10211, 1073, 1183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10211, 1109, 1168);

                    return f_10211_1116_1167(f_10211_1116_1151(UnderlyingMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10211, 1073, 1183);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10211_1116_1151(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10211, 1116, 1151);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10211_1116_1167(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10211, 1116, 1167);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10211, 975, 1194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10211, 975, 1194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Cci.ISpecializedMethodReference AsSpecializedMethodReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10211, 1307, 1370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10211, 1343, 1355);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10211, 1307, 1370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10211, 1206, 1381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10211, 1206, 1381);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SpecializedMethodReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10211, 571, 1388);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10211, 571, 1388);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10211, 571, 1388);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10211, 571, 1388);

        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10211_765_781_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10211, 680, 804);
            return return_v;
        }

    }
}
