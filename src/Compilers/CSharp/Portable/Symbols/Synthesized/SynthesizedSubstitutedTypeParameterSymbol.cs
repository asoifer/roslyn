// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedSubstitutedTypeParameterSymbol : SubstitutedTypeParameterSymbol
    {
        public SynthesizedSubstitutedTypeParameterSymbol(Symbol owner, TypeMap map, TypeParameterSymbol substitutedFrom, int ordinal)
        : base(f_10693_771_776_C(owner), map, substitutedFrom, ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10693, 625, 830);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10693, 625, 830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10693, 625, 830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10693, 625, 830);
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10693, 908, 928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10693, 914, 926);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10693, 908, 928);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10693, 842, 939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10693, 842, 939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10693, 951, 1373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10693, 1109, 1170);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10693, 1109, 1169);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10693, 1109, 1169);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10693, 1186, 1362) || true) && (f_10693_1190_1221(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10693, 1186, 1362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10693, 1255, 1347);

                    f_10693_1255_1346(ref attributes, f_10693_1295_1345(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10693, 1186, 1362);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10693, 951, 1373);

                bool
                f_10693_1190_1221(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSubstitutedTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10693, 1190, 1221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10693_1295_1345(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSubstitutedTypeParameterSymbol
                symbol)
                {
                    var return_v = this_param.SynthesizeIsUnmanagedAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10693, 1295, 1345);
                    return return_v;
                }


                int
                f_10693_1255_1346(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10693, 1255, 1346);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10693, 951, 1373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10693, 951, 1373);
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10693, 1385, 1740);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10693, 1477, 1664) || true) && (f_10693_1481_1497() is SynthesizedMethodBaseSymbol { InheritsBaseMethodAttributes: true })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10693, 1477, 1664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10693, 1601, 1649);

                    return f_10693_1608_1648(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10693, 1477, 1664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10693, 1680, 1729);

                return ImmutableArray<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10693, 1385, 1740);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10693_1481_1497()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10693, 1481, 1497);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10693_1608_1648(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10693, 1608, 1648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10693, 1385, 1740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10693, 1385, 1740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedSubstitutedTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10693, 512, 1747);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10693, 512, 1747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10693, 512, 1747);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10693, 512, 1747);

        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10693_771_776_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10693, 625, 830);
            return return_v;
        }

    }
}
