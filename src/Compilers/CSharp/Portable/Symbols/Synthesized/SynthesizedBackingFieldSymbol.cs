// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedBackingFieldSymbol : FieldSymbolWithAttributesAndModifiers
    {
        private readonly SourcePropertySymbolBase _property;

        private readonly string _name;

        internal bool HasInitializer { get; }

        protected override DeclarationModifiers Modifiers { get; }

        public SynthesizedBackingFieldSymbol(
                    SourcePropertySymbolBase property,
                    string name,
                    bool isReadOnly,
                    bool isStatic,
                    bool hasInitializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10665, 973, 1603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 796, 805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 840, 845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 856, 893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 903, 961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1201, 1243);

                f_10665_1201_1242(!f_10665_1215_1241(name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1259, 1272);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1288, 1509);

                Modifiers = DeclarationModifiers.Private |
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10665, 1349, 1359) || ((isReadOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10665, 1362, 1391)) || DynAbs.Tracing.TraceSender.Conditional_F3(10665, 1394, 1419))) ? DeclarationModifiers.ReadOnly : DeclarationModifiers.None) |
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10665, 1441, 1449) || ((isStatic && DynAbs.Tracing.TraceSender.Conditional_F2(10665, 1452, 1479)) || DynAbs.Tracing.TraceSender.Conditional_F3(10665, 1482, 1507))) ? DeclarationModifiers.Static : DeclarationModifiers.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1525, 1546);

                _property = property;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1560, 1592);

                HasInitializer = hasInitializer;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10665, 973, 1603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 973, 1603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 973, 1603);
            }
        }

        protected override IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 1685, 1713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1688, 1713);
                    return f_10665_1688_1713(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 1685, 1713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 1685, 1713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 1685, 1713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Location ErrorLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 1780, 1801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1783, 1801);
                    return f_10665_1783_1801(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 1780, 1801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 1780, 1801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 1780, 1801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 1909, 1952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 1912, 1952);
                    return f_10665_1912_1952(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 1909, 1952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 1909, 1952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 1909, 1952);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 2018, 2030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2021, 2030);
                    return _property; DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 2018, 2030);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 2018, 2030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 2018, 2030);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 2107, 2129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2110, 2129);
                    return f_10665_2110_2129(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 2107, 2129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 2107, 2129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 2107, 2129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 2246, 2278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2249, 2278);
                return f_10665_2249_2278(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 2246, 2278);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 2246, 2278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 2246, 2278);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10665_2249_2278(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
            this_param)
            {
                var return_v = this_param.TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 2249, 2278);
                return return_v;
            }

        }

        internal override bool HasPointerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 2342, 2369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2345, 2369);
                    return f_10665_2345_2369(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 2342, 2369);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 2342, 2369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 2342, 2369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 2382, 3301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2567, 2626);

                f_10665_2567_2625((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2642, 2678);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2692, 2727);

                f_10665_2692_2726(f_10665_2705_2725_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2741, 2802);

                f_10665_2741_2801(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 2818, 3290) || true) && (f_10665_2822_2898(attribute, this, AttributeDescription.FixedBufferAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10665, 2818, 3290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 3045, 3164);

                    f_10665_3045_3163(                // error CS8362: Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute on property
                                    arguments.Diagnostics, ErrorCode.ERR_DoNotUseFixedBufferAttrOnProperty, f_10665_3120_3162(f_10665_3120_3153(arguments.AttributeSyntaxOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10665, 2818, 3290);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10665, 2818, 3290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 3230, 3275);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DecodeWellKnownAttribute(ref arguments), 10665, 3230, 3274);
                    base.DecodeWellKnownAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 3230, 3274);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10665, 2818, 3290);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 2382, 3301);

                int
                f_10665_2567_2625(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 2567, 2625);
                    return 0;
                }


                bool
                f_10665_2705_2725_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 2705, 2725);
                    return return_v;
                }


                int
                f_10665_2692_2726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 2692, 2726);
                    return 0;
                }


                int
                f_10665_2741_2801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 2741, 2801);
                    return 0;
                }


                bool
                f_10665_2822_2898(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 2822, 2898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10665_3120_3153(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 3120, 3153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10665_3120_3162(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 3120, 3162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10665_3045_3163(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 3045, 3163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 2382, 3301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 2382, 3301);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 3313, 4347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 3471, 3532);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10665, 3471, 3531);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 3471, 3531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 3548, 3592);

                var
                compilation = f_10665_3566_3591(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 3709, 3778);

                f_10665_3709_3777(!(f_10665_3724_3743(this) is SimpleProgramNamedTypeSymbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 3792, 4044) || true) && (f_10665_3796_3837_M(!f_10665_3797_3816(this).IsImplicitlyDeclared))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10665, 3792, 4044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 3871, 4029);

                    f_10665_3871_4028(ref attributes, f_10665_3911_4027(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10665, 3792, 4044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 4239, 4336);

                f_10665_4239_4335(ref attributes, f_10665_4279_4334(compilation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 3313, 4347);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10665_3566_3591(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 3566, 3591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10665_3724_3743(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 3724, 3743);
                    return return_v;
                }


                int
                f_10665_3709_3777(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 3709, 3777);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10665_3797_3816(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 3797, 3816);
                    return return_v;
                }


                bool
                f_10665_3796_3837_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 3796, 3837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10665_3911_4027(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 3911, 4027);
                    return return_v;
                }


                int
                f_10665_3871_4028(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 3871, 4028);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10665_4279_4334(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SynthesizeDebuggerBrowsableNeverAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 4279, 4334);
                    return return_v;
                }


                int
                f_10665_4239_4335(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 4239, 4335);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 3313, 4347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 3313, 4347);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 4400, 4408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 4403, 4408);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 4400, 4408);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 4400, 4408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 4400, 4408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(ConstantFieldsInProgress inProgress, bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 4559, 4566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 4562, 4566);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 4559, 4566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 4559, 4566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 4559, 4566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 4632, 4661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 4635, 4661);
                    return f_10665_4635_4661(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 4632, 4661);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 4632, 4661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 4632, 4661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 4734, 4761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 4737, 4761);
                    return f_10665_4737_4761(_property); DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 4734, 4761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 4734, 4761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 4734, 4761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 4861, 4901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 4864, 4901);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 4861, 4901);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 4861, 4901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 4861, 4901);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 4972, 4980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 4975, 4980);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 4972, 4980);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 4972, 4980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 4972, 4980);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 5048, 5055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5051, 5055);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 5048, 5055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 5048, 5055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 5048, 5055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void PostDecodeWellKnownAttributes(ImmutableArray<CSharpAttributeData> boundAttributes, ImmutableArray<AttributeSyntax> allAttributeSyntaxNodes, DiagnosticBag diagnostics, AttributeLocation symbolPart, WellKnownAttributeData decodedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 5068, 5662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5348, 5463);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.PostDecodeWellKnownAttributes(boundAttributes, allAttributeSyntaxNodes, diagnostics, symbolPart, decodedData), 10665, 5348, 5462);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5479, 5651) || true) && (f_10665_5483_5515_M(!allAttributeSyntaxNodes.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10665, 5483, 5558) && f_10665_5519_5558(_property)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10665, 5479, 5651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5592, 5636);

                    f_10665_5592_5635(this, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10665, 5479, 5651);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 5068, 5662);

                bool
                f_10665_5483_5515_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 5483, 5515);
                    return return_v;
                }


                bool
                f_10665_5519_5558(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsAutoPropertyWithGetAccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 5519, 5558);
                    return return_v;
                }


                int
                f_10665_5592_5635(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckForFieldTargetedAttribute(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 5592, 5635);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 5068, 5662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 5068, 5662);
            }
        }

        private void CheckForFieldTargetedAttribute(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10665, 5674, 6582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5769, 5833);

                var
                languageVersion = f_10665_5791_5832(f_10665_5791_5816(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5847, 5955) || true) && (f_10665_5851_5899(languageVersion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10665, 5847, 5955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5933, 5940);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10665, 5847, 5955);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 5971, 6571);
                    foreach (var attribute in f_10665_5997_6027_I(f_10665_5997_6027()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10665, 5971, 6571);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 6061, 6556) || true) && (f_10665_6065_6105_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10665_6065_6081(attribute), 10665, 6065, 6105).GetAttributeLocation()) == AttributeLocation.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10665, 6061, 6556);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10665, 6174, 6537);

                            f_10665_6174_6536(diagnostics, f_10665_6216_6483(ErrorCode.WRN_AttributesOnBackingFieldsNotAvailable, f_10665_6319_6352(languageVersion), f_10665_6383_6482(f_10665_6417_6481(MessageID.IDS_FeatureAttributesOnBackingFields))), f_10665_6510_6535(f_10665_6510_6526(attribute)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10665, 6061, 6556);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10665, 5971, 6571);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10665, 1, 601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10665, 1, 601);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10665, 5674, 6582);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10665_5791_5816(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 5791, 5816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10665_5791_5832(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 5791, 5832);
                    return return_v;
                }


                bool
                f_10665_5851_5899(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                self)
                {
                    var return_v = self.AllowAttributesOnBackingFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 5851, 5899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10665_5997_6027()
                {
                    var return_v = AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 5997, 6027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax?
                f_10665_6065_6081(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 6065, 6081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation?
                f_10665_6065_6105_I(Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 6065, 6105);
                    return return_v;
                }


                string
                f_10665_6319_6352(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 6319, 6352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10665_6417_6481(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 6417, 6481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10665_6383_6482(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 6383, 6482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10665_6216_6483(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 6216, 6483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax
                f_10665_6510_6526(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 6510, 6526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10665_6510_6535(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 6510, 6535);
                    return return_v;
                }


                int
                f_10665_6174_6536(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 6174, 6536);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10665_5997_6027_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 5997, 6027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10665, 5674, 6582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 5674, 6582);
            }
        }

        static SynthesizedBackingFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10665, 646, 6589);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10665, 646, 6589);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10665, 646, 6589);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10665, 646, 6589);

        bool
        f_10665_1215_1241(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 1215, 1241);
            return return_v;
        }


        int
        f_10665_1201_1242(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10665, 1201, 1242);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
        f_10665_1688_1713(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.AttributesOwner;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 1688, 1713);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10665_1783_1801(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 1783, 1801);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10665_1912_1952(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.AttributeDeclarationSyntaxList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 1912, 1952);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10665_2110_2129(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 2110, 2129);
            return return_v;
        }


        bool
        f_10665_2345_2369(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.HasPointerType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 2345, 2369);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10665_4635_4661(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 4635, 4661);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10665_4737_4761(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10665, 4737, 4761);
            return return_v;
        }

    }
}
