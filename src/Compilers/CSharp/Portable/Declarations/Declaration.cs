// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class Declaration
    {
        protected readonly string name;

        protected Declaration(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10390, 2468, 2555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10390, 2451, 2455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10390, 2527, 2544);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10390, 2468, 2555);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10390, 2468, 2555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10390, 2468, 2555);
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10390, 2610, 2678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10390, 2646, 2663);

                    return this.name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10390, 2610, 2678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10390, 2567, 2689);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10390, 2567, 2689);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Declaration> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10390, 2769, 2852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10390, 2805, 2837);

                    return f_10390_2812_2836(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10390, 2769, 2852);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                    f_10390_2812_2836(Microsoft.CodeAnalysis.CSharp.Declaration
                    this_param)
                    {
                        var return_v = this_param.GetDeclarationChildren();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10390, 2812, 2836);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10390, 2701, 2863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10390, 2701, 2863);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract DeclarationKind Kind { get; }

        protected abstract ImmutableArray<Declaration> GetDeclarationChildren();

        static Declaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10390, 2373, 3009);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10390, 2373, 3009);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10390, 2373, 3009);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10390, 2373, 3009);
    }
}
