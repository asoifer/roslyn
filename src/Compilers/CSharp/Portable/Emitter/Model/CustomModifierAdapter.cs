// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Emit;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class CSharpCustomModifier : Cci.ICustomModifier
    {
        bool Cci.ICustomModifier.IsOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10184, 535, 566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10184, 541, 564);

                    return f_10184_548_563(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10184, 535, 566);

                    bool
                    f_10184_548_563(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                    this_param)
                    {
                        var return_v = this_param.IsOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10184, 548, 563);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10184, 475, 577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10184, 475, 577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ICustomModifier.GetModifier(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10184, 589, 830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10184, 685, 819);

                return f_10184_692_818(((PEModuleBuilder)context.Module), f_10184_736_755(this), (CSharpSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10184, 589, 830);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10184_736_755(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                this_param)
                {
                    var return_v = this_param.ModifierSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10184, 736, 755);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10184_692_818(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10184, 692, 818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10184, 589, 830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10184, 589, 830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpCustomModifier()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10184, 393, 837);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10184, 393, 837);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10184, 393, 837);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10184, 393, 837);
    }
}
