// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class CSharpSymbolChanges : SymbolChanges
    {
        public CSharpSymbolChanges(DefinitionMap definitionMap, IEnumerable<SemanticEdit> edits, Func<ISymbol, bool> isAddedSymbol)
        : base(f_10939_627_640_C(definitionMap), edits, isAddedSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10939, 483, 676);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10939, 483, 676);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10939, 483, 676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10939, 483, 676);
            }
        }

        protected override ISymbolInternal GetISymbolInternalOrNull(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10939, 688, 904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10939, 811, 893);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10939, 818, 861) || (((symbol is Symbols.PublicModel.Symbol temp) && DynAbs.Tracing.TraceSender.Conditional_F2(10939, 864, 885)) 
                    || DynAbs.Tracing.TraceSender.Conditional_F3(10939, 888, 892))) ? f_10939_864_885((Symbols.PublicModel.Symbol)symbol) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10939, 688, 904);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10939_864_885(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param)
                {
                    var return_v = this_param.UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10939, 864, 885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10939, 688, 904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10939, 688, 904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpSymbolChanges()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10939, 409, 911);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10939, 409, 911);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10939, 409, 911);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10939, 409, 911);

        static Microsoft.CodeAnalysis.Emit.DefinitionMap
        f_10939_627_640_C(Microsoft.CodeAnalysis.Emit.DefinitionMap
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10939, 483, 676);
            return return_v;
        }

    }
}
