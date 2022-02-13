// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class SourceAssemblySymbol
    {
        internal IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder, bool emittingRefAssembly, bool emittingAssemblyAttributesInNetModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10207, 507, 1766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 700, 727);

                f_10207_700_726(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 743, 814);

                ImmutableArray<CSharpAttributeData>
                userDefined = f_10207_793_813(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 828, 886);

                ArrayBuilder<SynthesizedAttributeData>
                synthesized = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 900, 962);

                f_10207_900_961(this, moduleBuilder, ref synthesized);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 978, 1385) || true) && (emittingRefAssembly && (DynAbs.Tracing.TraceSender.Expression_True(10207, 982, 1035) && f_10207_1005_1035_M(!HasReferenceAssemblyAttribute)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10207, 978, 1385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 1069, 1276);

                    var
                    referenceAssemblyAttribute = f_10207_1102_1275(f_10207_1102_1127(this), WellKnownMember.System_Runtime_CompilerServices_ReferenceAssemblyAttribute__ctor, isOptionalUse: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 1294, 1370);

                    f_10207_1294_1369(ref synthesized, referenceAssemblyAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10207, 978, 1385);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10207, 1597, 1755);

                return f_10207_1604_1754(this, userDefined, synthesized, isReturnType: false, emittingAssemblyAttributesInNetModule: emittingAssemblyAttributesInNetModule);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10207, 507, 1766);

                int
                f_10207_700_726(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10207, 700, 726);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10207_793_813(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10207, 793, 813);
                    return return_v;
                }


                int
                f_10207_900_961(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>?
                attributes)
                {
                    this_param.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10207, 900, 961);
                    return 0;
                }


                bool
                f_10207_1005_1035_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10207, 1005, 1035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10207_1102_1127(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10207, 1102, 1127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10207_1102_1275(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, bool
                isOptionalUse)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, isOptionalUse: isOptionalUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10207, 1102, 1275);
                    return return_v;
                }


                int
                f_10207_1294_1369(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    Symbol.AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10207, 1294, 1369);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10207_1604_1754(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                userDefined, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                synthesized, bool
                isReturnType, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(userDefined, synthesized, isReturnType: isReturnType, emittingAssemblyAttributesInNetModule: emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10207, 1604, 1754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10207, 507, 1766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10207, 507, 1766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10207, 447, 1773);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20004, 20050);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10207, 447, 1773);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10207, 447, 1773);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10207, 447, 1773);
    }
}
