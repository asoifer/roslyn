// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class GeneratedLabelSymbol : LabelSymbol
    {
        private readonly string _name;

        public GeneratedLabelSymbol(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10661, 545, 645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 527, 532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 610, 634);

                _name = f_10661_618_633(name);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10661, 545, 645);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10661, 545, 645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10661, 545, 645);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10661, 709, 773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 745, 758);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10661, 709, 773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10661, 657, 784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10661, 657, 784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static int s_sequence;

        private static string LabelName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10661, 859, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 939, 1001);

                int
                seq = f_10661_949_1000(ref s_sequence, 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 1015, 1062);

                return "<" + name + "-" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((seq & 0xffff)).ToString(), 10661, 1041, 1055) + ">";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10661, 859, 1114);

                int
                f_10661_949_1000(ref int
                location1, int
                value)
                {
                    var return_v = System.Threading.Interlocked.Add(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10661, 949, 1000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10661, 859, 1114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10661, 859, 1114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10661, 1224, 1320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 1260, 1305);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10661, 1224, 1320);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10661, 1126, 1331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10661, 1126, 1331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10661, 1409, 1429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 1415, 1427);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10661, 1409, 1429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10661, 1343, 1440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10661, 1343, 1440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static GeneratedLabelSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10661, 430, 1447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10661, 826, 840);
            s_sequence = 1; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10661, 430, 1447);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10661, 430, 1447);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10661, 430, 1447);

        string
        f_10661_618_633(string
        name)
        {
            var return_v = LabelName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10661, 618, 633);
            return return_v;
        }

    }
}
