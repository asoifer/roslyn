// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedEnumValueFieldSymbol : SynthesizedFieldSymbolBase
    {
        public SynthesizedEnumValueFieldSymbol(SourceNamedTypeSymbol containingEnum)
        : base(f_10674_681_695_C(containingEnum), WellKnownMemberNames.EnumBackingFieldName, isPublic: true, isReadOnly: false, isStatic: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10674, 584, 813);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10674, 584, 813);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10674, 584, 813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10674, 584, 813);
            }
        }

        internal override bool SuppressDynamicAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10674, 897, 917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10674, 903, 915);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10674, 897, 917);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10674, 825, 928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10674, 825, 928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10674, 940, 1160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10674, 1055, 1149);

                return TypeWithAnnotations.Create(f_10674_1089_1147(((SourceNamedTypeSymbol)f_10674_1113_1127())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10674, 940, 1160);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10674_1113_1127()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10674, 1113, 1127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10674_1089_1147(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10674, 1089, 1147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10674, 940, 1160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10674, 940, 1160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10674, 1172, 1375);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10674, 1172, 1375);
                // no attributes should be emitted
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10674, 1172, 1375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10674, 1172, 1375);
            }
        }

        static SynthesizedEnumValueFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10674, 485, 1382);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10674, 485, 1382);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10674, 485, 1382);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10674, 485, 1382);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10674_681_695_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10674, 584, 813);
            return return_v;
        }

    }
}
