// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ImplicitNamedTypeSymbol : SourceMemberContainerTypeSymbol
    {
        internal ImplicitNamedTypeSymbol(NamespaceOrTypeSymbol containingSymbol, MergedTypeDeclaration declaration, DiagnosticBag diagnostics)
        : base(f_10230_816_832_C(containingSymbol), declaration, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10230, 661, 1208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 884, 1096);

                f_10230_884_1095(f_10230_897_913(declaration) == DeclarationKind.ImplicitClass || (DynAbs.Tracing.TraceSender.Expression_False(10230, 897, 1022) || f_10230_976_992(declaration) == DeclarationKind.Submission) || (DynAbs.Tracing.TraceSender.Expression_False(10230, 897, 1094) || f_10230_1052_1068(declaration) == DeclarationKind.Script));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 1112, 1170);

                state.NotePartComplete(CompletionPart.EnumUnderlyingType);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10230, 661, 1208);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 661, 1208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 661, 1208);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 1310, 1349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 1313, 1349);
                throw f_10230_1319_1349(); DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 1310, 1349);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 1310, 1349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 1310, 1349);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10230_1319_1349()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 1319, 1349);
                return return_v;
            }

        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 1362, 1578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 1454, 1504);

                state.NotePartComplete(CompletionPart.Attributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 1518, 1567);

                return ImmutableArray<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 1362, 1578);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 1362, 1578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 1362, 1578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 1590, 1717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 1675, 1706);

                return AttributeUsageInfo.Null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 1590, 1717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 1590, 1717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 1590, 1717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Location GetCorrespondingBaseListLocation(NamedTypeSymbol @base)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 1729, 2045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 2006, 2034);

                return NoLocation.Singleton;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 1729, 2045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 1729, 2045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 1729, 2045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 2338, 2454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 2341, 2454);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10230, 2341, 2354) || ((f_10230_2341_2354() && DynAbs.Tracing.TraceSender.Conditional_F2(10230, 2357, 2361)) || DynAbs.Tracing.TraceSender.Conditional_F3(10230, 2364, 2454))) ? null : f_10230_2364_2454(f_10230_2364_2389(this), Microsoft.CodeAnalysis.SpecialType.System_Object); DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 2338, 2454);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 2338, 2454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 2338, 2454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void CheckBase(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 2467, 2960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 2704, 2806);

                var
                info = f_10230_2715_2805(f_10230_2715_2782(f_10230_2715_2740(this), SpecialType.System_Object))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 2820, 2949) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10230, 2820, 2949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 2870, 2934);

                    f_10230_2870_2933(info, diagnostics, f_10230_2920_2929()[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10230, 2820, 2949);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 2467, 2960);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10230_2715_2740(Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 2715, 2740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10230_2715_2782(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10230, 2715, 2782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10230_2715_2805(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10230, 2715, 2805);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10230_2920_2929()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 2920, 2929);
                    return return_v;
                }


                bool
                f_10230_2870_2933(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10230, 2870, 2933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 2467, 2960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 2467, 2960);
            }
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 2972, 3138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 3091, 3127);

                return f_10230_3098_3126();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 2972, 3138);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10230_3098_3126()
                {
                    var return_v = BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 3098, 3126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 2972, 3138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 2972, 3138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 3150, 3352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 3296, 3341);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 3150, 3352);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 3150, 3352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 3150, 3352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 3364, 3557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 3501, 3546);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 3364, 3557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 3364, 3557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 3364, 3557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void CheckInterfaces(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 3569, 3677);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 3569, 3677);
                // nop
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 3569, 3677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 3569, 3677);
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 3780, 3837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 3786, 3835);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 3780, 3837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 3689, 3848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 3689, 3848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 3987, 4044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 3993, 4042);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 3987, 4044);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 3860, 4055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 3860, 4055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4135, 4218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4141, 4216);

                    return f_10230_4148_4179_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10230_4148_4162(), 10230, 4148, 4179)?.AreLocalsZeroed) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10230, 4148, 4215) ?? f_10230_4183_4215(f_10230_4183_4199()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4135, 4218);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10230_4148_4162()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 4148, 4162);
                        return return_v;
                    }


                    bool?
                    f_10230_4148_4179_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 4148, 4179);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10230_4183_4199()
                    {
                        var return_v = ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 4183, 4199);
                        return return_v;
                    }


                    bool
                    f_10230_4183_4215(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 4183, 4215);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4067, 4229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4067, 4229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4300, 4321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4306, 4319);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4300, 4321);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4241, 4332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4241, 4332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4419, 4439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4425, 4437);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4419, 4439);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4344, 4450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4344, 4450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4524, 4545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4530, 4543);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4524, 4545);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4462, 4556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4462, 4556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ShouldAddWinRTMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4637, 4658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4643, 4656);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4637, 4658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4568, 4669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4568, 4669);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4758, 4779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4764, 4777);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4758, 4779);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4681, 4790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4681, 4790);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4869, 4890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4875, 4888);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4869, 4890);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4802, 4901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4802, 4901);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 4980, 5015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 4986, 5013);

                    return default(TypeLayout);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 4980, 5015);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 4913, 5026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 4913, 5026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasStructLayoutAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5101, 5122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 5107, 5120);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5101, 5122);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5038, 5133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5038, 5133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet MarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5214, 5255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 5220, 5253);

                    return f_10230_5227_5252();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5214, 5255);

                    System.Runtime.InteropServices.CharSet
                    f_10230_5227_5252()
                    {
                        var return_v = DefaultMarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 5227, 5252);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5145, 5266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5145, 5266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5355, 5376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 5361, 5374);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5355, 5376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5278, 5387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5278, 5387);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5399, 5566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 5518, 5555);

                throw f_10230_5524_5554();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5399, 5566);

                System.Exception
                f_10230_5524_5554()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 5524, 5554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5399, 5566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5399, 5566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5578, 5721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 5674, 5710);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5578, 5721);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5578, 5721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5578, 5721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5819, 5839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 5825, 5837);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5819, 5839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5733, 5850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5733, 5850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasCodeAnalysisEmbeddedAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5918, 5926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 5921, 5926);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5918, 5926);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5918, 5926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5918, 5926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 5998, 6037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 6001, 6037);
                throw f_10230_6007_6037(); DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 5998, 6037);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 5998, 6037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 5998, 6037);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10230_6007_6037()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 6007, 6037);
                return return_v;
            }

        }

        internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10230, 6119, 6126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10230, 6122, 6126);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10230, 6119, 6126);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10230, 6119, 6126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 6119, 6126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ImplicitNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10230, 565, 6134);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10230, 565, 6134);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10230, 565, 6134);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10230, 565, 6134);

        Microsoft.CodeAnalysis.CSharp.DeclarationKind
        f_10230_897_913(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 897, 913);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationKind
        f_10230_976_992(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 976, 992);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationKind
        f_10230_1052_1068(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 1052, 1068);
            return return_v;
        }


        int
        f_10230_884_1095(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10230, 884, 1095);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        f_10230_816_832_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10230, 661, 1208);
            return return_v;
        }


        bool
        f_10230_2341_2354()
        {
            var return_v = IsScriptClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 2341, 2354);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10230_2364_2389(Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10230, 2364, 2389);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10230_2364_2454(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SpecialType
        specialType)
        {
            var return_v = this_param.GetSpecialType(specialType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10230, 2364, 2454);
            return return_v;
        }

    }
}
