// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceEventFieldSymbol : SourceMemberFieldSymbolFromDeclarator
    {
        private readonly SourceEventSymbol _associatedEvent;

        internal SourceEventFieldSymbol(SourceEventSymbol associatedEvent, VariableDeclaratorSyntax declaratorSyntax, DiagnosticBag discardedDiagnostics)
        : base(f_10249_1092_1122_C(associatedEvent.containingType), declaratorSyntax, (f_10249_1183_1208(associatedEvent) & (~DeclarationModifiers.AccessibilityMask)) | DeclarationModifiers.Private, modifierErrors: true, diagnostics: discardedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10249, 926, 1453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 897, 913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 1407, 1442);

                _associatedEvent = associatedEvent;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10249, 926, 1453);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10249, 926, 1453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10249, 926, 1453);
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10249, 1531, 1594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 1567, 1579);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10249, 1531, 1594);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10249, 1465, 1605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10249, 1465, 1605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10249, 1698, 1773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 1734, 1758);

                    return _associatedEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10249, 1698, 1773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10249, 1617, 1784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10249, 1617, 1784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10249, 1860, 1935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 1896, 1920);

                    return _associatedEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10249, 1860, 1935);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10249, 1796, 1946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10249, 1796, 1946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10249, 1958, 2713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 2116, 2177);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10249, 2116, 2176);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10249, 2116, 2176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 2193, 2237);

                var
                compilation = f_10249_2211_2236(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 2251, 2409);

                f_10249_2251_2408(ref attributes, f_10249_2291_2407(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10249, 2605, 2702);

                f_10249_2605_2701(ref attributes, f_10249_2645_2700(compilation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10249, 1958, 2713);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10249_2211_2236(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10249, 2211, 2236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10249_2291_2407(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10249, 2291, 2407);
                    return return_v;
                }


                int
                f_10249_2251_2408(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10249, 2251, 2408);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10249_2645_2700(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SynthesizeDebuggerBrowsableNeverAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10249, 2645, 2700);
                    return return_v;
                }


                int
                f_10249_2605_2701(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10249, 2605, 2701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10249, 1958, 2713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10249, 1958, 2713);
            }
        }

        static SourceEventFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10249, 761, 2720);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10249, 761, 2720);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10249, 761, 2720);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10249, 761, 2720);

        static Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10249_1183_1208(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param)
        {
            var return_v = this_param.Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10249, 1183, 1208);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10249_1092_1122_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10249, 926, 1453);
            return return_v;
        }

    }
}
