// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class MutableTypeMap : AbstractTypeParameterMap
    {
        internal MutableTypeMap()
        : base(f_10126_712_775_C(f_10126_712_775()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10126, 666, 798);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10126, 666, 798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10126, 666, 798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10126, 666, 798);
            }
        }

        internal void Add(TypeParameterSymbol key, TypeWithAnnotations value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10126, 810, 944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10126, 904, 933);

                f_10126_904_932(this.Mapping, key, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10126, 810, 944);

                int
                f_10126_904_932(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10126, 904, 932);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10126, 810, 944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10126, 810, 944);
            }
        }

        static MutableTypeMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10126, 586, 951);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10126, 586, 951);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10126, 586, 951);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10126, 586, 951);

        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10126_712_775()
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10126, 712, 775);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10126_712_775_C(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10126, 666, 798);
            return return_v;
        }

    }
}
