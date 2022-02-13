// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class FieldSymbolWithAttributesAndModifiers : FieldSymbol, IAttributeTargetSymbol
    {
        private CustomAttributesBag<CSharpAttributeData> _lazyCustomAttributesBag;

        protected SymbolCompletionState state;

        internal abstract Location ErrorLocation { get; }

        protected abstract DeclarationModifiers Modifiers { get; }

        protected abstract SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList { get; }

        protected abstract IAttributeTargetSymbol AttributeOwner { get; }

        IAttributeTargetSymbol IAttributeTargetSymbol.AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 1339, 1361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 1342, 1361);
                    return f_10221_1342_1361(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 1339, 1361);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 1339, 1361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 1339, 1361);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.DefaultAttributeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 1453, 1479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 1456, 1479);
                    return AttributeLocation.Field; DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 1453, 1479);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 1453, 1479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 1453, 1479);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.AllowedAttributeLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 1572, 1598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 1575, 1598);
                    return AttributeLocation.Field; DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 1572, 1598);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 1572, 1598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 1572, 1598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 1687, 1713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 1690, 1713);
                return state.HasComplete(part); DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 1687, 1713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 1687, 1713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 1687, 1713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 1776, 1825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 1779, 1825);
                    return (f_10221_1780_1789() & DeclarationModifiers.Static) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 1776, 1825);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 1776, 1825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 1776, 1825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 1890, 1941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 1893, 1941);
                    return (f_10221_1894_1903() & DeclarationModifiers.ReadOnly) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 1890, 1941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 1890, 1941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 1890, 1941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 2026, 2076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 2029, 2076);
                    return f_10221_2029_2076(f_10221_2066_2075()); DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 2026, 2076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 2026, 2076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 2026, 2076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 2138, 2186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 2141, 2186);
                    return (f_10221_2142_2151() & DeclarationModifiers.Const) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 2138, 2186);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 2138, 2186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 2138, 2186);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVolatile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 2251, 2302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 2254, 2302);
                    return (f_10221_2255_2264() & DeclarationModifiers.Volatile) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 2251, 2302);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 2251, 2302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 2251, 2302);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsFixedSizeBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 2374, 2422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 2377, 2422);
                    return (f_10221_2378_2387() & DeclarationModifiers.Fixed) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 2374, 2422);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 2374, 2422);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 2374, 2422);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 2944, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 2947, 2981);
                return f_10221_2947_2981(f_10221_2947_2970(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 2944, 2981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 2944, 2981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 2944, 2981);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            f_10221_2947_2970(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
            this_param)
            {
                var return_v = this_param.GetAttributesBag();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 2947, 2970);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            f_10221_2947_2981(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            this_param)
            {
                var return_v = this_param.Attributes;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 2947, 2981);
                return return_v;
            }

        }

        private CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 3329, 3969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3421, 3456);

                var
                bag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3470, 3561) || true) && (bag != null && (DynAbs.Tracing.TraceSender.Expression_True(10221, 3474, 3501) && f_10221_3489_3501(bag)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 3470, 3561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3535, 3546);

                    return bag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 3470, 3561);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3577, 3848) || true) && (f_10221_3581_3691(this, f_10221_3607_3660(f_10221_3624_3659(this)), ref _lazyCustomAttributesBag))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 3577, 3848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3725, 3791);

                    var
                    completed = state.NotePartComplete(CompletionPart.Attributes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3809, 3833);

                    f_10221_3809_3832(completed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 3577, 3848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3864, 3912);

                f_10221_3864_3911(f_10221_3877_3910(_lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 3926, 3958);

                return _lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 3329, 3969);

                bool
                f_10221_3489_3501(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 3489, 3501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10221_3624_3659(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 3624, 3659);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10221_3607_3660(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 3607, 3660);
                    return return_v;
                }


                bool
                f_10221_3581_3691(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributesBag)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 3581, 3691);
                    return return_v;
                }


                int
                f_10221_3809_3832(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 3809, 3832);
                    return 0;
                }


                bool
                f_10221_3877_3910(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 3877, 3910);
                    return return_v;
                }


                int
                f_10221_3864_3911(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 3864, 3911);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 3329, 3969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 3329, 3969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected FieldWellKnownAttributeData GetDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 4258, 4693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 4355, 4400);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 4414, 4586) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10221, 4418, 4497) || f_10221_4443_4497_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 4414, 4586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 4531, 4571);

                    attributesBag = f_10221_4547_4570(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 4414, 4586);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 4602, 4682);

                return (FieldWellKnownAttributeData)f_10221_4638_4681(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 4258, 4693);

                bool
                f_10221_4443_4497_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 4443, 4497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10221_4547_4570(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 4547, 4570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10221_4638_4681(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 4638, 4681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 4258, 4693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 4258, 4693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpAttributeData EarlyDecodeWellKnownAttribute(ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 4705, 5518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 4942, 4977);

                CSharpAttributeData
                boundAttribute
                = default(CSharpAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 4991, 5026);

                ObsoleteAttributeData
                obsoleteData
                = default(ObsoleteAttributeData);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 5042, 5434) || true) && (f_10221_5046_5153(ref arguments, out boundAttribute, out obsoleteData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 5042, 5434);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 5187, 5377) || true) && (obsoleteData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 5187, 5377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 5253, 5358);

                        arguments.GetOrCreateData<CommonFieldEarlyWellKnownAttributeData>().ObsoleteAttributeData = obsoleteData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 5187, 5377);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 5397, 5419);

                    return boundAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 5042, 5434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 5450, 5507);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EarlyDecodeWellKnownAttribute(ref arguments), 10221, 5457, 5506);

                var temp = base.EarlyDecodeWellKnownAttribute(ref arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 5457, 5506);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 4705, 5518);

                bool
                f_10221_5046_5153(ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, out Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attributeData, out Microsoft.CodeAnalysis.ObsoleteAttributeData
                obsoleteData)
                {
                    var return_v = EarlyDecodeDeprecatedOrExperimentalOrObsoleteAttribute(ref arguments, out attributeData, out obsoleteData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 5046, 5153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 4705, 5518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 4705, 5518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 5891, 6668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 5927, 6002);

                    var
                    containingSourceType = (SourceMemberContainerTypeSymbol)f_10221_5987_6001()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6020, 6141) || true) && (f_10221_6024_6068_M(!containingSourceType.AnyMemberHasAttributes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 6020, 6141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6110, 6122);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 6020, 6141);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6161, 6216);

                    var
                    lazyCustomAttributesBag = _lazyCustomAttributesBag
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6234, 6590) || true) && (lazyCustomAttributesBag != null && (DynAbs.Tracing.TraceSender.Expression_True(10221, 6238, 6341) && f_10221_6273_6341(lazyCustomAttributesBag)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 6234, 6590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6383, 6493);

                        var
                        data = (CommonFieldEarlyWellKnownAttributeData)f_10221_6434_6492(lazyCustomAttributesBag)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6515, 6571);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10221, 6522, 6534) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10221, 6537, 6563)) || DynAbs.Tracing.TraceSender.Conditional_F3(10221, 6566, 6570))) ? f_10221_6537_6563(data) : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 6234, 6590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6610, 6653);

                    return ObsoleteAttributeData.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 5891, 6668);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10221_5987_6001()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 5987, 6001);
                        return return_v;
                    }


                    bool
                    f_10221_6024_6068_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 6024, 6068);
                        return return_v;
                    }


                    bool
                    f_10221_6273_6341(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.IsEarlyDecodedWellKnownAttributeDataComputed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 6273, 6341);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                    f_10221_6434_6492(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 6434, 6492);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10221_6537_6563(Microsoft.CodeAnalysis.CommonFieldEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 6537, 6563);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 5798, 6679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 5798, 6679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 6691, 11236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6869, 6928);

                f_10221_6869_6927((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6944, 6980);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 6994, 7029);

                f_10221_6994_7028(f_10221_7007_7027_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7043, 7104);

                f_10221_7043_7103(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7120, 11225) || true) && (f_10221_7124_7200(attribute, this, AttributeDescription.SpecialNameAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7120, 11225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7234, 7322);

                    arguments.GetOrCreateData<FieldWellKnownAttributeData>().HasSpecialNameAttribute = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7120, 11225);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7120, 11225);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7356, 11225) || true) && (f_10221_7360_7438(attribute, this, AttributeDescription.NonSerializedAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7356, 11225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7472, 7562);

                        arguments.GetOrCreateData<FieldWellKnownAttributeData>().HasNonSerializedAttribute = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7356, 11225);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7356, 11225);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7596, 11225) || true) && (f_10221_7600_7676(attribute, this, AttributeDescription.FieldOffsetAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7596, 11225);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7710, 9065) || true) && (f_10221_7714_7727(this) || (DynAbs.Tracing.TraceSender.Expression_False(10221, 7714, 7743) || f_10221_7731_7743(this)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7710, 9065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 7884, 8044);

                                f_10221_7884_8043(                    // CS0637: The FieldOffset attribute is not allowed on static or const fields
                                                    arguments.Diagnostics, ErrorCode.ERR_StructOffsetOnBadField, f_10221_7948_7990(f_10221_7948_7981(arguments.AttributeSyntaxOpt)), f_10221_7992_8042(arguments.AttributeSyntaxOpt));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7710, 9065);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7710, 9065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 8126, 8222);

                                int
                                offset = f_10221_8139_8175(attribute)[0].DecodeValue<int>(SpecialType.System_Int32)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 8244, 8740) || true) && (offset < 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 8244, 8740);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 8389, 8502);

                                    CSharpSyntaxNode
                                    attributeArgumentSyntax = f_10221_8432_8501(attribute, 0, arguments.AttributeSyntaxOpt)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 8528, 8680);

                                    f_10221_8528_8679(arguments.Diagnostics, ErrorCode.ERR_InvalidAttributeArgument, f_10221_8594_8626(attributeArgumentSyntax), f_10221_8628_8678(arguments.AttributeSyntaxOpt));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 8706, 8717);

                                    offset = 0;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 8244, 8740);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 8966, 9046);

                                f_10221_8966_9045(
                                                    // Set field offset even if the attribute specifies an invalid value, so that
                                                    // post-validation knows that the attribute is applied and reports better errors.
                                                    arguments.GetOrCreateData<FieldWellKnownAttributeData>(), offset);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7710, 9065);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7596, 11225);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 7596, 11225);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 9099, 11225) || true) && (f_10221_9103_9177(attribute, this, AttributeDescription.MarshalAsAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 9099, 11225);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 9211, 9395);

                                f_10221_9211_9394(ref arguments, AttributeTargets.Field, MessageProvider.Instance);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 9099, 11225);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 9099, 11225);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 9429, 11225) || true) && (f_10221_9433_9794(this, arguments, ReservedAttributes.DynamicAttribute | ReservedAttributes.IsReadOnlyAttribute | ReservedAttributes.IsUnmanagedAttribute | ReservedAttributes.IsByRefLikeAttribute | ReservedAttributes.TupleElementNamesAttribute | ReservedAttributes.NullableAttribute | ReservedAttributes.NativeIntegerAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 9429, 11225);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 9429, 11225);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 9429, 11225);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 9844, 11225) || true) && (f_10221_9848_9929(attribute, this, AttributeDescription.DateTimeConstantAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 9844, 11225);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 9963, 10046);

                                        f_10221_9963_10045(this, f_10221_9990_10029(attribute), ref arguments);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 9844, 11225);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 9844, 11225);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10080, 11225) || true) && (f_10221_10084_10164(attribute, this, AttributeDescription.DecimalConstantAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10080, 11225);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10198, 10280);

                                            f_10221_10198_10279(this, f_10221_10225_10263(attribute), ref arguments);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10080, 11225);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10080, 11225);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10314, 11225) || true) && (f_10221_10318_10392(attribute, this, AttributeDescription.AllowNullAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10314, 11225);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10426, 10512);

                                                arguments.GetOrCreateData<FieldWellKnownAttributeData>().HasAllowNullAttribute = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10314, 11225);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10314, 11225);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10546, 11225) || true) && (f_10221_10550_10627(attribute, this, AttributeDescription.DisallowNullAttribute))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10546, 11225);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10661, 10750);

                                                    arguments.GetOrCreateData<FieldWellKnownAttributeData>().HasDisallowNullAttribute = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10546, 11225);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10546, 11225);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10784, 11225) || true) && (f_10221_10788_10862(attribute, this, AttributeDescription.MaybeNullAttribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10784, 11225);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 10896, 10982);

                                                        arguments.GetOrCreateData<FieldWellKnownAttributeData>().HasMaybeNullAttribute = true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10784, 11225);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 10784, 11225);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11016, 11225) || true) && (f_10221_11020_11092(attribute, this, AttributeDescription.NotNullAttribute))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 11016, 11225);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11126, 11210);

                                                            arguments.GetOrCreateData<FieldWellKnownAttributeData>().HasNotNullAttribute = true;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 11016, 11225);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10784, 11225);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10546, 11225);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10314, 11225);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 10080, 11225);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 9844, 11225);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 9429, 11225);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 9099, 11225);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7596, 11225);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7356, 11225);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 7120, 11225);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 6691, 11236);

                int
                f_10221_6869_6927(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 6869, 6927);
                    return 0;
                }


                bool
                f_10221_7007_7027_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 7007, 7027);
                    return return_v;
                }


                int
                f_10221_6994_7028(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 6994, 7028);
                    return 0;
                }


                int
                f_10221_7043_7103(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 7043, 7103);
                    return 0;
                }


                bool
                f_10221_7124_7200(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 7124, 7200);
                    return return_v;
                }


                bool
                f_10221_7360_7438(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 7360, 7438);
                    return return_v;
                }


                bool
                f_10221_7600_7676(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 7600, 7676);
                    return return_v;
                }


                bool
                f_10221_7714_7727(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 7714, 7727);
                    return return_v;
                }


                bool
                f_10221_7731_7743(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 7731, 7743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10221_7948_7981(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 7948, 7981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10221_7948_7990(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 7948, 7990);
                    return return_v;
                }


                string
                f_10221_7992_8042(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 7992, 8042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10221_7884_8043(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 7884, 8043);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10221_8139_8175(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 8139, 8175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10221_8432_8501(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 8432, 8501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10221_8594_8626(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 8594, 8626);
                    return return_v;
                }


                string
                f_10221_8628_8678(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 8628, 8678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10221_8528_8679(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 8528, 8679);
                    return return_v;
                }


                int
                f_10221_8966_9045(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param, int
                offset)
                {
                    this_param.SetFieldOffset(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 8966, 9045);
                    return 0;
                }


                bool
                f_10221_9103_9177(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 9103, 9177);
                    return return_v;
                }


                int
                f_10221_9211_9394(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, System.AttributeTargets
                target, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    MarshalAsAttributeDecoder<FieldWellKnownAttributeData, AttributeSyntax, CSharpAttributeData, AttributeLocation>.Decode(ref arguments, target, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 9211, 9394);
                    return 0;
                }


                bool
                f_10221_9433_9794(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 9433, 9794);
                    return return_v;
                }


                bool
                f_10221_9848_9929(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 9848, 9929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10221_9990_10029(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.DecodeDateTimeConstantValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 9990, 10029);
                    return return_v;
                }


                int
                f_10221_9963_10045(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param, Microsoft.CodeAnalysis.ConstantValue
                attrValue, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.VerifyConstantValueMatches(attrValue, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 9963, 10045);
                    return 0;
                }


                bool
                f_10221_10084_10164(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 10084, 10164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10221_10225_10263(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.DecodeDecimalConstantValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 10225, 10263);
                    return return_v;
                }


                int
                f_10221_10198_10279(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param, Microsoft.CodeAnalysis.ConstantValue
                attrValue, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.VerifyConstantValueMatches(attrValue, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 10198, 10279);
                    return 0;
                }


                bool
                f_10221_10318_10392(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 10318, 10392);
                    return return_v;
                }


                bool
                f_10221_10550_10627(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 10550, 10627);
                    return return_v;
                }


                bool
                f_10221_10788_10862(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 10788, 10862);
                    return return_v;
                }


                bool
                f_10221_11020_11092(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 11020, 11092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 6691, 11236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 6691, 11236);
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 11325, 11392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11328, 11392);
                    return f_10221_11328_11392(f_10221_11357_11391(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 11325, 11392);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 11325, 11392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 11325, 11392);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static FlowAnalysisAnnotations DecodeFlowAnalysisAttributes(FieldWellKnownAttributeData attributeData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10221, 11405, 12135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11540, 11587);

                var
                annotations = FlowAnalysisAnnotations.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11601, 12091) || true) && (attributeData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 11601, 12091);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11660, 11750) || true) && (f_10221_11664_11699(attributeData))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 11660, 11750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11701, 11750);

                        annotations |= FlowAnalysisAnnotations.AllowNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 11660, 11750);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11768, 11864) || true) && (f_10221_11772_11810(attributeData))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 11768, 11864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11812, 11864);

                        annotations |= FlowAnalysisAnnotations.DisallowNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 11768, 11864);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11882, 11972) || true) && (f_10221_11886_11921(attributeData))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 11882, 11972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11923, 11972);

                        annotations |= FlowAnalysisAnnotations.MaybeNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 11882, 11972);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 11990, 12076) || true) && (f_10221_11994_12027(attributeData))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 11990, 12076);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12029, 12076);

                        annotations |= FlowAnalysisAnnotations.NotNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 11990, 12076);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 11601, 12091);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12105, 12124);

                return annotations;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10221, 11405, 12135);

                bool
                f_10221_11664_11699(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasAllowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 11664, 11699);
                    return return_v;
                }


                bool
                f_10221_11772_11810(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasDisallowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 11772, 11810);
                    return return_v;
                }


                bool
                f_10221_11886_11921(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasMaybeNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 11886, 11921);
                    return return_v;
                }


                bool
                f_10221_11994_12027(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasNotNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 11994, 12027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 11405, 12135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 11405, 12135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VerifyConstantValueMatches(ConstantValue attrValue, ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 12428, 14469);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12623, 14458) || true) && (f_10221_12627_12643_M(!attrValue.IsBad))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 12623, 14458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12677, 12745);

                    var
                    data = arguments.GetOrCreateData<FieldWellKnownAttributeData>()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12763, 12788);

                    ConstantValue
                    constValue
                    = default(ConstantValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12808, 14443) || true) && (f_10221_12812_12824(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 12808, 14443);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12866, 13629) || true) && (f_10221_12870_12891(f_10221_12870_12879(this)) == SpecialType.System_Decimal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 12866, 13629);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 12971, 13079);

                            constValue = f_10221_12984_13078(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 13107, 13389) || true) && ((object)constValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10221, 13111, 13158) && f_10221_13141_13158_M(!constValue.IsBad)) && (DynAbs.Tracing.TraceSender.Expression_True(10221, 13111, 13185) && constValue != attrValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 13107, 13389);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 13243, 13362);

                                f_10221_13243_13361(arguments.Diagnostics, ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, f_10221_13323_13360(arguments.AttributeSyntaxOpt));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 13107, 13389);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 12866, 13629);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 12866, 13629);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 13487, 13606);

                            f_10221_13487_13605(arguments.Diagnostics, ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, f_10221_13567_13604(arguments.AttributeSyntaxOpt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 12866, 13629);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 13653, 13809) || true) && (f_10221_13657_13672(data) == f_10221_13676_13708())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 13653, 13809);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 13758, 13786);

                            data.ConstValue = attrValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 13653, 13809);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 12808, 14443);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 12808, 14443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 13891, 13920);

                        constValue = f_10221_13904_13919(data);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 13944, 14424) || true) && (constValue != f_10221_13962_13994())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 13944, 14424);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 14044, 14275) || true) && (constValue != attrValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 14044, 14275);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 14129, 14248);

                                f_10221_14129_14247(arguments.Diagnostics, ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, f_10221_14209_14246(arguments.AttributeSyntaxOpt));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 14044, 14275);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 13944, 14424);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 13944, 14424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 14373, 14401);

                            data.ConstValue = attrValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 13944, 14424);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 12808, 14443);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 12623, 14458);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 12428, 14469);

                bool
                f_10221_12627_12643_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 12627, 12643);
                    return return_v;
                }


                bool
                f_10221_12812_12824(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 12812, 12824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10221_12870_12879(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 12870, 12879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10221_12870_12891(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 12870, 12891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10221_12984_13078(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 12984, 13078);
                    return return_v;
                }


                bool
                f_10221_13141_13158_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 13141, 13158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10221_13323_13360(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 13323, 13360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10221_13243_13361(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 13243, 13361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10221_13567_13604(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 13567, 13604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10221_13487_13605(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 13487, 13605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10221_13657_13672(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.ConstValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 13657, 13672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10221_13676_13708()
                {
                    var return_v = CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 13676, 13708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10221_13904_13919(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.ConstValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 13904, 13919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10221_13962_13994()
                {
                    var return_v = CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 13962, 13994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10221_14209_14246(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 14209, 14246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10221_14129_14247(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 14129, 14247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 12428, 14469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 12428, 14469);
            }
        }

        internal override void PostDecodeWellKnownAttributes(ImmutableArray<CSharpAttributeData> boundAttributes, ImmutableArray<AttributeSyntax> allAttributeSyntaxNodes, DiagnosticBag diagnostics, AttributeLocation symbolPart, WellKnownAttributeData decodedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 14481, 16540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 14761, 14802);

                f_10221_14761_14801(f_10221_14774_14800_M(!boundAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 14816, 14865);

                f_10221_14816_14864(f_10221_14829_14863_M(!allAttributeSyntaxNodes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 14879, 14950);

                f_10221_14879_14949(boundAttributes.Length == allAttributeSyntaxNodes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 14964, 15011);

                f_10221_14964_15010(_lazyCustomAttributesBag != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15025, 15104);

                f_10221_15025_15103(f_10221_15038_15102(_lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15118, 15169);

                f_10221_15118_15168(symbolPart == AttributeLocation.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15185, 15237);

                var
                data = (FieldWellKnownAttributeData)decodedData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15251, 15304);

                int?
                fieldOffset = (DynAbs.Tracing.TraceSender.Conditional_F1(10221, 15270, 15282) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10221, 15285, 15296)) || DynAbs.Tracing.TraceSender.Conditional_F3(10221, 15299, 15303))) ? f_10221_15285_15296(data) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15320, 16398) || true) && (f_10221_15324_15344(fieldOffset))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 15320, 16398);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15378, 15919) || true) && (f_10221_15382_15401(this).Layout.Kind != LayoutKind.Explicit)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 15378, 15919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15478, 15514);

                        f_10221_15478_15513(boundAttributes.Any());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15691, 15781);

                        int
                        i = boundAttributes.IndexOfAttribute(this, AttributeDescription.FieldOffsetAttribute)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15803, 15900);

                        f_10221_15803_15899(diagnostics, ErrorCode.ERR_StructOffsetOnBadStruct, f_10221_15858_15898(f_10221_15858_15889(allAttributeSyntaxNodes[i])));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 15378, 15919);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 15320, 16398);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 15320, 16398);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 15953, 16398) || true) && (f_10221_15957_15971_M(!this.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10221, 15957, 15988) && f_10221_15975_15988_M(!this.IsConst)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 15953, 16398);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 16022, 16383) || true) && (f_10221_16026_16045(this).Layout.Kind == LayoutKind.Explicit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 16022, 16383);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 16272, 16364);

                            f_10221_16272_16363(                    // error CS0625: '<field>': instance field types marked with StructLayout(LayoutKind.Explicit) must have a FieldOffset attribute
                                                diagnostics, ErrorCode.ERR_MissingStructOffset, f_10221_16323_16341(this), f_10221_16343_16362(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 16022, 16383);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 15953, 16398);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 15320, 16398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 16414, 16529);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.PostDecodeWellKnownAttributes(boundAttributes, allAttributeSyntaxNodes, diagnostics, symbolPart, decodedData), 10221, 16414, 16528);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 14481, 16540);

                bool
                f_10221_14774_14800_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 14774, 14800);
                    return return_v;
                }


                int
                f_10221_14761_14801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 14761, 14801);
                    return 0;
                }


                bool
                f_10221_14829_14863_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 14829, 14863);
                    return return_v;
                }


                int
                f_10221_14816_14864(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 14816, 14864);
                    return 0;
                }


                int
                f_10221_14879_14949(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 14879, 14949);
                    return 0;
                }


                int
                f_10221_14964_15010(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 14964, 15010);
                    return 0;
                }


                bool
                f_10221_15038_15102(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsDecodedWellKnownAttributeDataComputed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15038, 15102);
                    return return_v;
                }


                int
                f_10221_15025_15103(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 15025, 15103);
                    return 0;
                }


                int
                f_10221_15118_15168(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 15118, 15168);
                    return 0;
                }


                int?
                f_10221_15285_15296(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15285, 15296);
                    return return_v;
                }


                bool
                f_10221_15324_15344(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15324, 15344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10221_15382_15401(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15382, 15401);
                    return return_v;
                }


                int
                f_10221_15478_15513(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 15478, 15513);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10221_15858_15889(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15858, 15889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10221_15858_15898(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15858, 15898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10221_15803_15899(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 15803, 15899);
                    return return_v;
                }


                bool
                f_10221_15957_15971_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15957, 15971);
                    return return_v;
                }


                bool
                f_10221_15975_15988_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 15975, 15988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10221_16026_16045(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 16026, 16045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10221_16323_16341(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 16323, 16341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                f_10221_16343_16362(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.AttributeOwner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 16343, 16362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10221_16272_16363(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 16272, 16363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 14481, 16540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 14481, 16540);
            }
        }

        internal sealed override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 16621, 16911);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 16657, 16760) || true) && (f_10221_16661_16687(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 16657, 16760);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 16729, 16741);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 16657, 16760);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 16780, 16826);

                    var
                    data = f_10221_16791_16825(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 16844, 16896);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10221, 16851, 16895) && f_10221_16867_16895(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 16621, 16911);

                    bool
                    f_10221_16661_16687(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 16661, 16687);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    f_10221_16791_16825(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 16791, 16825);
                        return return_v;
                    }


                    bool
                    f_10221_16867_16895(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasSpecialNameAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 16867, 16895);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 16552, 16922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 16552, 16922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsNotSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 17004, 17173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17040, 17086);

                    var
                    data = f_10221_17051_17085(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17104, 17158);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10221, 17111, 17157) && f_10221_17127_17157(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 17004, 17173);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    f_10221_17051_17085(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 17051, 17085);
                        return return_v;
                    }


                    bool
                    f_10221_17127_17157(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasNonSerializedAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 17127, 17157);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 16934, 17184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 16934, 17184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 17301, 17473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17337, 17383);

                    var
                    data = f_10221_17348_17382(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17401, 17458);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10221, 17408, 17420) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10221, 17423, 17450)) || DynAbs.Tracing.TraceSender.Conditional_F3(10221, 17453, 17457))) ? f_10221_17423_17450(data) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 17301, 17473);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    f_10221_17348_17382(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 17348, 17382);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10221_17423_17450(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 17423, 17450);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 17196, 17484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 17196, 17484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override int? TypeLayoutOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 17567, 17723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17603, 17649);

                    var
                    data = f_10221_17614_17648(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17667, 17708);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10221, 17674, 17686) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10221, 17689, 17700)) || DynAbs.Tracing.TraceSender.Conditional_F3(10221, 17703, 17707))) ? f_10221_17689_17700(data) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 17567, 17723);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    f_10221_17614_17648(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 17614, 17648);
                        return return_v;
                    }


                    int?
                    f_10221_17689_17700(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.Offset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 17689, 17700);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 17496, 17734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 17496, 17734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10221, 17746, 19007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17904, 17965);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10221, 17904, 17964);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 17904, 17964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 17981, 18025);

                var
                compilation = f_10221_17999_18024(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18039, 18075);

                var
                type = f_10221_18050_18074(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18091, 18312) || true) && (f_10221_18095_18122(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 18091, 18312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18156, 18297);

                    f_10221_18156_18296(ref attributes, f_10221_18217_18295(compilation, type.Type, type.CustomModifiers.Length));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 18091, 18312);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18328, 18519) || true) && (f_10221_18332_18365(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 18328, 18519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18399, 18504);

                    f_10221_18399_18503(ref attributes, f_10221_18439_18502(moduleBuilder, this, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 18328, 18519);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18535, 18733) || true) && (f_10221_18539_18569(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 18535, 18733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18603, 18718);

                    f_10221_18603_18717(ref attributes, f_10221_18664_18716(compilation, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 18535, 18733);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18749, 18996) || true) && (f_10221_18753_18799(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10221, 18749, 18996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 18833, 18981);

                    f_10221_18833_18980(ref attributes, f_10221_18873_18979(moduleBuilder, this, f_10221_18932_18972(f_10221_18932_18946()), type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10221, 18749, 18996);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10221, 17746, 19007);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10221_17999_18024(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 17999, 18024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10221_18050_18074(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 18050, 18074);
                    return return_v;
                }


                bool
                f_10221_18095_18122(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18095, 18122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10221_18217_18295(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, int
                customModifiersCount)
                {
                    var return_v = this_param.SynthesizeDynamicAttribute(type, customModifiersCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18217, 18295);
                    return return_v;
                }


                int
                f_10221_18156_18296(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18156, 18296);
                    return 0;
                }


                bool
                f_10221_18332_18365(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18332, 18365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10221_18439_18502(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18439, 18502);
                    return return_v;
                }


                int
                f_10221_18399_18503(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18399, 18503);
                    return 0;
                }


                bool
                f_10221_18539_18569(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18539, 18569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10221_18664_18716(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18664, 18716);
                    return return_v;
                }


                int
                f_10221_18603_18717(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18603, 18717);
                    return 0;
                }


                bool
                f_10221_18753_18799(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18753, 18799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10221_18932_18946()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 18932, 18946);
                    return return_v;
                }


                byte?
                f_10221_18932_18972(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18932, 18972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10221_18873_18979(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18873, 18979);
                    return return_v;
                }


                int
                f_10221_18833_18980(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 18833, 18980);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10221, 17746, 19007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 17746, 19007);
            }
        }

        public FieldSymbolWithAttributesAndModifiers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10221, 583, 19014);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10221, 748, 772);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10221, 583, 19014);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 583, 19014);
        }


        static FieldSymbolWithAttributesAndModifiers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10221, 583, 19014);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10221, 583, 19014);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10221, 583, 19014);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10221, 583, 19014);

        Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
        f_10221_1342_1361(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
        this_param)
        {
            var return_v = this_param.AttributeOwner;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 1342, 1361);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10221_1780_1789()
        {
            var return_v = Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 1780, 1789);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10221_1894_1903()
        {
            var return_v = Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 1894, 1903);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10221_2066_2075()
        {
            var return_v = Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 2066, 2075);
            return return_v;
        }


        Microsoft.CodeAnalysis.Accessibility
        f_10221_2029_2076(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers)
        {
            var return_v = ModifierUtils.EffectiveAccessibility(modifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 2029, 2076);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10221_2142_2151()
        {
            var return_v = Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 2142, 2151);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10221_2255_2264()
        {
            var return_v = Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 2255, 2264);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10221_2378_2387()
        {
            var return_v = Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10221, 2378, 2387);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
        f_10221_11357_11391(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolWithAttributesAndModifiers
        this_param)
        {
            var return_v = this_param.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 11357, 11391);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10221_11328_11392(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
        attributeData)
        {
            var return_v = DecodeFlowAnalysisAttributes(attributeData);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10221, 11328, 11392);
            return return_v;
        }

    }
}
