// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public sealed partial class CrefParameterSyntax
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SyntaxToken RefOrOutKeyword
        {        /// <summary>
                 /// Pre C# 7.2 back-compat overload, which simply calls the replacement property <see cref="RefKindKeyword"/>.
                 /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10750, 616, 638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10750, 619, 638);
                    return f_10750_619_638(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10750, 616, 638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10750, 616, 638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10750, 616, 638);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CrefParameterSyntax WithRefOrOutKeyword(SyntaxToken refOrOutKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10750, 808, 1021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10750, 963, 1010);

                return f_10750_970_1009(this, refOrOutKeyword, f_10750_999_1008(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10750, 808, 1021);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10750_999_1008(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10750, 999, 1008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax
                f_10750_970_1009(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                refKindKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = this_param.Update(refKindKeyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10750, 970, 1009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10750, 808, 1021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10750, 808, 1021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CrefParameterSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10750, 295, 1028);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10750, 295, 1028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10750, 295, 1028);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10750, 295, 1028);

        Microsoft.CodeAnalysis.SyntaxToken
        f_10750_619_638(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax
        this_param)
        {
            var return_v = this_param.RefKindKeyword;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10750, 619, 638);
            return return_v;
        }

    }
}
