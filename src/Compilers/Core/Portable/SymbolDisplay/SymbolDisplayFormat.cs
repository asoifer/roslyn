// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    public class SymbolDisplayFormat
    {
        public static SymbolDisplayFormat CSharpErrorMessageFormat { get; }

        public static SymbolDisplayFormat CSharpShortErrorMessageFormat { get; }

        public static SymbolDisplayFormat VisualBasicErrorMessageFormat { get; }

        public static SymbolDisplayFormat VisualBasicShortErrorMessageFormat { get; }

        public static SymbolDisplayFormat FullyQualifiedFormat { get; }

        public static SymbolDisplayFormat MinimallyQualifiedFormat { get; }

        internal static readonly SymbolDisplayFormat TestFormat;

        internal static readonly SymbolDisplayFormat TestFormatWithConstraints;

        internal static readonly SymbolDisplayFormat QualifiedNameOnlyFormat;

        internal static readonly SymbolDisplayFormat QualifiedNameArityFormat;

        internal static readonly SymbolDisplayFormat ShortFormat;

        internal static readonly SymbolDisplayFormat ILVisualizationFormat;

        internal static readonly SymbolDisplayFormat ExplicitInterfaceImplementationFormat;

        public SymbolDisplayGlobalNamespaceStyle GlobalNamespaceStyle { get; }

        public SymbolDisplayTypeQualificationStyle TypeQualificationStyle { get; }

        public SymbolDisplayGenericsOptions GenericsOptions { get; }

        public SymbolDisplayMemberOptions MemberOptions { get; }

        public SymbolDisplayParameterOptions ParameterOptions { get; }

        public SymbolDisplayDelegateStyle DelegateStyle { get; }

        public SymbolDisplayExtensionMethodStyle ExtensionMethodStyle { get; }

        public SymbolDisplayPropertyStyle PropertyStyle { get; }

        public SymbolDisplayLocalOptions LocalOptions { get; }

        public SymbolDisplayKindOptions KindOptions { get; }

        public SymbolDisplayMiscellaneousOptions MiscellaneousOptions { get; }

        internal SymbolDisplayCompilerInternalOptions CompilerInternalOptions { get; }

        public SymbolDisplayFormat(
                    SymbolDisplayGlobalNamespaceStyle globalNamespaceStyle = default(SymbolDisplayGlobalNamespaceStyle),
                    SymbolDisplayTypeQualificationStyle typeQualificationStyle = default(SymbolDisplayTypeQualificationStyle),
                    SymbolDisplayGenericsOptions genericsOptions = default(SymbolDisplayGenericsOptions),
                    SymbolDisplayMemberOptions memberOptions = default(SymbolDisplayMemberOptions),
                    SymbolDisplayDelegateStyle delegateStyle = default(SymbolDisplayDelegateStyle),
                    SymbolDisplayExtensionMethodStyle extensionMethodStyle = default(SymbolDisplayExtensionMethodStyle),
                    SymbolDisplayParameterOptions parameterOptions = default(SymbolDisplayParameterOptions),
                    SymbolDisplayPropertyStyle propertyStyle = default(SymbolDisplayPropertyStyle),
                    SymbolDisplayLocalOptions localOptions = default(SymbolDisplayLocalOptions),
                    SymbolDisplayKindOptions kindOptions = default(SymbolDisplayKindOptions),
                    SymbolDisplayMiscellaneousOptions miscellaneousOptions = default(SymbolDisplayMiscellaneousOptions))
        : this(
                        compilerInternalOptions: f_575_22994_23026_C(default), globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(575, 21809, 23433);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(575, 21809, 23433);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 21809, 23433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 21809, 23433);
            }
        }

        internal SymbolDisplayFormat(
                    SymbolDisplayCompilerInternalOptions compilerInternalOptions,
                    SymbolDisplayGlobalNamespaceStyle globalNamespaceStyle = default(SymbolDisplayGlobalNamespaceStyle),
                    SymbolDisplayTypeQualificationStyle typeQualificationStyle = default(SymbolDisplayTypeQualificationStyle),
                    SymbolDisplayGenericsOptions genericsOptions = default(SymbolDisplayGenericsOptions),
                    SymbolDisplayMemberOptions memberOptions = default(SymbolDisplayMemberOptions),
                    SymbolDisplayParameterOptions parameterOptions = default(SymbolDisplayParameterOptions),
                    SymbolDisplayDelegateStyle delegateStyle = default(SymbolDisplayDelegateStyle),
                    SymbolDisplayExtensionMethodStyle extensionMethodStyle = default(SymbolDisplayExtensionMethodStyle),
                    SymbolDisplayPropertyStyle propertyStyle = default(SymbolDisplayPropertyStyle),
                    SymbolDisplayLocalOptions localOptions = default(SymbolDisplayLocalOptions),
                    SymbolDisplayKindOptions kindOptions = default(SymbolDisplayKindOptions),
                    SymbolDisplayMiscellaneousOptions miscellaneousOptions = default(SymbolDisplayMiscellaneousOptions))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(575, 23583, 25500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 17294, 17364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 17538, 17612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 17779, 17839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 17981, 18037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 18199, 18261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 18403, 18459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 18579, 18649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 18873, 18929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 19047, 19101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 19248, 19300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 19435, 19505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 19625, 19703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 24831, 24880);

                this.GlobalNamespaceStyle = globalNamespaceStyle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 24894, 24947);

                this.TypeQualificationStyle = typeQualificationStyle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 24961, 25000);

                this.GenericsOptions = genericsOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25014, 25049);

                this.MemberOptions = memberOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25063, 25104);

                this.ParameterOptions = parameterOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25118, 25153);

                this.DelegateStyle = delegateStyle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25167, 25216);

                this.ExtensionMethodStyle = extensionMethodStyle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25230, 25265);

                this.PropertyStyle = propertyStyle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25279, 25312);

                this.LocalOptions = localOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25326, 25357);

                this.KindOptions = kindOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25371, 25420);

                this.MiscellaneousOptions = miscellaneousOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 25434, 25489);

                this.CompilerInternalOptions = compilerInternalOptions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(575, 23583, 25500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 23583, 25500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 23583, 25500);
            }
        }

        public SymbolDisplayFormat WithMiscellaneousOptions(SymbolDisplayMiscellaneousOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 25979, 26623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 26098, 26612);

                return f_575_26105_26611(f_575_26147_26175(this), f_575_26194_26219(this), f_575_26238_26265(this), f_575_26284_26304(this), f_575_26323_26341(this), f_575_26360_26381(this), f_575_26400_26418(this), f_575_26437_26462(this), f_575_26481_26499(this), f_575_26518_26535(this), f_575_26554_26570(this), options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 25979, 26623);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_575_26147_26175(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26147, 26175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_575_26194_26219(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26194, 26219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_26238_26265(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26238, 26265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_26284_26304(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26284, 26304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_26323_26341(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26323, 26341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_26360_26381(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26360, 26381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_26400_26418(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26400, 26418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_26437_26462(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26437, 26462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_26481_26499(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26481, 26499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_26518_26535(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26518, 26535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_26554_26570(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 26554, 26570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_26105_26611(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 26105, 26611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 25979, 26623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 25979, 26623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat AddMiscellaneousOptions(SymbolDisplayMiscellaneousOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 27134, 27337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 27252, 27326);

                return f_575_27259_27325(this, f_575_27289_27314(this) | options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 27134, 27337);

                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_27289_27314(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 27289, 27314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_27259_27325(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options)
                {
                    var return_v = this_param.WithMiscellaneousOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 27259, 27325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 27134, 27337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 27134, 27337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat RemoveMiscellaneousOptions(SymbolDisplayMiscellaneousOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 27852, 28059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 27973, 28048);

                return f_575_27980_28047(this, f_575_28010_28035(this) & ~options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 27852, 28059);

                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_28010_28035(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28010, 28035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_27980_28047(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options)
                {
                    var return_v = this_param.WithMiscellaneousOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 27980, 28047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 27852, 28059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 27852, 28059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat WithGenericsOptions(SymbolDisplayGenericsOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 28520, 29145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 28629, 29134);

                return f_575_28636_29133(f_575_28678_28706(this), f_575_28725_28750(this), f_575_28769_28796(this), options, f_575_28841_28859(this), f_575_28878_28899(this), f_575_28918_28936(this), f_575_28955_28980(this), f_575_28999_29017(this), f_575_29036_29053(this), f_575_29072_29088(this), f_575_29107_29132(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 28520, 29145);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_575_28678_28706(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28678, 28706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_575_28725_28750(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28725, 28750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_28769_28796(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28769, 28796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_28841_28859(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28841, 28859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_28878_28899(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28878, 28899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_28918_28936(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28918, 28936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_28955_28980(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28955, 28980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_28999_29017(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 28999, 29017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_29036_29053(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 29036, 29053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_29072_29088(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 29072, 29088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_29107_29132(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 29107, 29132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_28636_29133(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 28636, 29133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 28520, 29145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 28520, 29145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat AddGenericsOptions(SymbolDisplayGenericsOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 29640, 29823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 29748, 29812);

                return f_575_29755_29811(this, f_575_29780_29800(this) | options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 29640, 29823);

                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_29780_29800(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 29780, 29800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_29755_29811(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                options)
                {
                    var return_v = this_param.WithGenericsOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 29755, 29811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 29640, 29823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 29640, 29823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat RemoveGenericsOptions(SymbolDisplayGenericsOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 30416, 30603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 30527, 30592);

                return f_575_30534_30591(this, f_575_30559_30579(this) & ~options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 30416, 30603);

                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_30559_30579(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 30559, 30579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_30534_30591(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                options)
                {
                    var return_v = this_param.WithGenericsOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 30534, 30591);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 30416, 30603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 30416, 30603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat WithMemberOptions(SymbolDisplayMemberOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 31052, 31675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 31157, 31664);

                return f_575_31164_31663(f_575_31206_31234(this), f_575_31253_31278(this), f_575_31297_31324(this), f_575_31343_31363(this), options, f_575_31408_31429(this), f_575_31448_31466(this), f_575_31485_31510(this), f_575_31529_31547(this), f_575_31566_31583(this), f_575_31602_31618(this), f_575_31637_31662(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 31052, 31675);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_575_31206_31234(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31206, 31234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_575_31253_31278(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31253, 31278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_31297_31324(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31297, 31324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_31343_31363(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31343, 31363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_31408_31429(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31408, 31429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_31448_31466(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31448, 31466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_31485_31510(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31485, 31510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_31529_31547(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31529, 31547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_31566_31583(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31566, 31583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_31602_31618(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31602, 31618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_31637_31662(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 31637, 31662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_31164_31663(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 31164, 31663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 31052, 31675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 31052, 31675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat AddMemberOptions(SymbolDisplayMemberOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 32186, 32361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 32290, 32350);

                return f_575_32297_32349(this, f_575_32320_32338(this) | options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 32186, 32361);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_32320_32338(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 32320, 32338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_32297_32349(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options)
                {
                    var return_v = this_param.WithMemberOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 32297, 32349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 32186, 32361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 32186, 32361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat RemoveMemberOptions(SymbolDisplayMemberOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 32942, 33121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 33049, 33110);

                return f_575_33056_33109(this, f_575_33079_33097(this) & ~options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 32942, 33121);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_33079_33097(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 33079, 33097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_33056_33109(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options)
                {
                    var return_v = this_param.WithMemberOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 33056, 33109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 32942, 33121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 32942, 33121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat WithKindOptions(SymbolDisplayKindOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 33641, 34262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 33742, 34251);

                return f_575_33749_34250(f_575_33791_33819(this), f_575_33838_33863(this), f_575_33882_33909(this), f_575_33928_33948(this), f_575_33967_33985(this), f_575_34004_34025(this), f_575_34044_34062(this), f_575_34081_34106(this), f_575_34125_34143(this), f_575_34162_34179(this), options, f_575_34224_34249(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 33641, 34262);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_575_33791_33819(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 33791, 33819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_575_33838_33863(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 33838, 33863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_33882_33909(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 33882, 33909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_33928_33948(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 33928, 33948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_33967_33985(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 33967, 33985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_34004_34025(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 34004, 34025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_34044_34062(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 34044, 34062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_34081_34106(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 34081, 34106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_34125_34143(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 34125, 34143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_34162_34179(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 34162, 34179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_34224_34249(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 34224, 34249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_33749_34250(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 33749, 34250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 33641, 34262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 33641, 34262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat AddKindOptions(SymbolDisplayKindOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 34801, 34968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 34901, 34957);

                return f_575_34908_34956(this, f_575_34929_34945(this) | options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 34801, 34968);

                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_34929_34945(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 34929, 34945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_34908_34956(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                options)
                {
                    var return_v = this_param.WithKindOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 34908, 34956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 34801, 34968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 34801, 34968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat RemoveKindOptions(SymbolDisplayKindOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 35531, 35702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 35634, 35691);

                return f_575_35641_35690(this, f_575_35662_35678(this) & ~options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 35531, 35702);

                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_35662_35678(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 35662, 35678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_35641_35690(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                options)
                {
                    var return_v = this_param.WithKindOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 35641, 35690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 35531, 35702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 35531, 35702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat WithParameterOptions(SymbolDisplayParameterOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 36162, 36788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 36273, 36777);

                return f_575_36280_36776(f_575_36322_36350(this), f_575_36369_36394(this), f_575_36413_36440(this), f_575_36459_36479(this), f_575_36498_36516(this), options, f_575_36561_36579(this), f_575_36598_36623(this), f_575_36642_36660(this), f_575_36679_36696(this), f_575_36715_36731(this), f_575_36750_36775(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 36162, 36788);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_575_36322_36350(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36322, 36350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_575_36369_36394(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36369, 36394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_36413_36440(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36413, 36440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_36459_36479(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36459, 36479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_36498_36516(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36498, 36516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_36561_36579(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36561, 36579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_36598_36623(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36598, 36623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_36642_36660(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36642, 36660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_36679_36696(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36679, 36696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_36715_36731(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36715, 36731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_36750_36775(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 36750, 36775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_36280_36776(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 36280, 36776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 36162, 36788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 36162, 36788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat AddParameterOptions(SymbolDisplayParameterOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 37309, 37496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 37419, 37485);

                return f_575_37426_37484(this, f_575_37452_37473(this) | options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 37309, 37496);

                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_37452_37473(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 37452, 37473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_37426_37484(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options)
                {
                    var return_v = this_param.WithParameterOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 37426, 37484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 37309, 37496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 37309, 37496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat RemoveParameterOptions(SymbolDisplayParameterOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 38076, 38267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 38189, 38256);

                return f_575_38196_38255(this, f_575_38222_38243(this) & ~options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 38076, 38267);

                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_38222_38243(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 38222, 38243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_38196_38255(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options)
                {
                    var return_v = this_param.WithParameterOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 38196, 38255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 38076, 38267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 38076, 38267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat WithGlobalNamespaceStyle(SymbolDisplayGlobalNamespaceStyle style)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 38747, 39373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 38864, 39362);

                return f_575_38871_39361(f_575_38913_38941(this), style, f_575_38984_39011(this), f_575_39030_39050(this), f_575_39069_39087(this), f_575_39106_39127(this), f_575_39146_39164(this), f_575_39183_39208(this), f_575_39227_39245(this), f_575_39264_39281(this), f_575_39300_39316(this), f_575_39335_39360(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 38747, 39373);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_575_38913_38941(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 38913, 38941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_38984_39011(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 38984, 39011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_39030_39050(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39030, 39050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_39069_39087(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39069, 39087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_39106_39127(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39106, 39127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_39146_39164(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39146, 39164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_39183_39208(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39183, 39208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_39227_39245(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39227, 39245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_39264_39281(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39264, 39281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_39300_39316(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39300, 39316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_39335_39360(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 39335, 39360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_38871_39361(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 38871, 39361);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 38747, 39373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 38747, 39373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat WithLocalOptions(SymbolDisplayLocalOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 39856, 40478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 39959, 40467);

                return f_575_39966_40466(f_575_40008_40036(this), f_575_40055_40080(this), f_575_40099_40126(this), f_575_40145_40165(this), f_575_40184_40202(this), f_575_40221_40242(this), f_575_40261_40279(this), f_575_40298_40323(this), f_575_40342_40360(this), options, f_575_40405_40421(this), f_575_40440_40465(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 39856, 40478);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_575_40008_40036(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40008, 40036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_575_40055_40080(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40055, 40080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_40099_40126(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40099, 40126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_40145_40165(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40145, 40165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_40184_40202(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40184, 40202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_40221_40242(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40221, 40242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_40261_40279(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40261, 40279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_40298_40323(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40298, 40323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_40342_40360(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40342, 40360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_40405_40421(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40405, 40421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_40440_40465(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 40440, 40465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_39966_40466(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 39966, 40466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 39856, 40478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 39856, 40478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat AddLocalOptions(SymbolDisplayLocalOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 41008, 41179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 41110, 41168);

                return f_575_41117_41167(this, f_575_41139_41156(this) | options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 41008, 41179);

                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_41139_41156(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 41139, 41156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_41117_41167(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options)
                {
                    var return_v = this_param.WithLocalOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 41117, 41167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 41008, 41179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 41008, 41179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolDisplayFormat RemoveLocalOptions(SymbolDisplayLocalOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 41768, 41943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 41873, 41932);

                return f_575_41880_41931(this, f_575_41902_41919(this) & ~options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 41768, 41943);

                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_41902_41919(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 41902, 41919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_41880_41931(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options)
                {
                    var return_v = this_param.WithLocalOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 41880, 41931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 41768, 41943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 41768, 41943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SymbolDisplayFormat WithCompilerInternalOptions(SymbolDisplayCompilerInternalOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(575, 42138, 42773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 42265, 42762);

                return f_575_42272_42761(options, f_575_42340_42365(this), f_575_42384_42411(this), f_575_42430_42450(this), f_575_42469_42487(this), f_575_42506_42527(this), f_575_42546_42564(this), f_575_42583_42608(this), f_575_42627_42645(this), f_575_42664_42681(this), f_575_42700_42716(this), f_575_42735_42760(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(575, 42138, 42773);

                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_575_42340_42365(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42340, 42365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_575_42384_42411(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42384, 42411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_575_42430_42450(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42430, 42450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_575_42469_42487(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42469, 42487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_575_42506_42527(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42506, 42527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_575_42546_42564(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42546, 42564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                f_575_42583_42608(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ExtensionMethodStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42583, 42608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_575_42627_42645(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42627, 42645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_575_42664_42681(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42664, 42681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_575_42700_42716(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42700, 42716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_575_42735_42760(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 42735, 42760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_575_42272_42761(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
                extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                miscellaneousOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 42272, 42761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(575, 42138, 42773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 42138, 42773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolDisplayFormat()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(575, 402, 42780);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 575, 2120);
            CSharpErrorMessageFormat = f_575_658_2119(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, propertyStyle: SymbolDisplayPropertyStyle.NameOnly, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, memberOptions:
                                SymbolDisplayMemberOptions.IncludeParameters |
                                SymbolDisplayMemberOptions.IncludeContainingType |
                                SymbolDisplayMemberOptions.IncludeExplicitInterface, parameterOptions:
                                SymbolDisplayParameterOptions.IncludeParamsRefOut |
                                SymbolDisplayParameterOptions.IncludeType, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                                SymbolDisplayMiscellaneousOptions.UseAsterisksInMultiDimensionalArrays |
                                SymbolDisplayMiscellaneousOptions.UseErrorTypeSymbolName |
                                SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 2262, 3799);
            CSharpShortErrorMessageFormat = f_575_2350_3798(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypes, propertyStyle: SymbolDisplayPropertyStyle.NameOnly, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, memberOptions:
                                SymbolDisplayMemberOptions.IncludeParameters |
                                SymbolDisplayMemberOptions.IncludeContainingType |
                                SymbolDisplayMemberOptions.IncludeExplicitInterface, parameterOptions:
                                SymbolDisplayParameterOptions.IncludeParamsRefOut |
                                SymbolDisplayParameterOptions.IncludeType, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                                SymbolDisplayMiscellaneousOptions.UseAsterisksInMultiDimensionalArrays |
                                SymbolDisplayMiscellaneousOptions.UseErrorTypeSymbolName |
                                SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 3945, 5886);
            VisualBasicErrorMessageFormat = f_575_4033_5885(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, propertyStyle: SymbolDisplayPropertyStyle.ShowReadWriteDescriptor, genericsOptions:
                                SymbolDisplayGenericsOptions.IncludeTypeParameters |
                                SymbolDisplayGenericsOptions.IncludeTypeConstraints |
                                SymbolDisplayGenericsOptions.IncludeVariance, memberOptions:
                                SymbolDisplayMemberOptions.IncludeParameters |
                                SymbolDisplayMemberOptions.IncludeAccessibility |
                                SymbolDisplayMemberOptions.IncludeType |
                                SymbolDisplayMemberOptions.IncludeRef |
                                SymbolDisplayMemberOptions.IncludeModifiers, kindOptions:
                                SymbolDisplayKindOptions.IncludeMemberKeyword, parameterOptions:
                                SymbolDisplayParameterOptions.IncludeParamsRefOut |
                                SymbolDisplayParameterOptions.IncludeExtensionThis |
                                SymbolDisplayParameterOptions.IncludeType |
                                SymbolDisplayParameterOptions.IncludeName |
                                SymbolDisplayParameterOptions.IncludeOptionalBrackets |
                                SymbolDisplayParameterOptions.IncludeDefaultValue, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                                SymbolDisplayMiscellaneousOptions.UseAsterisksInMultiDimensionalArrays |
                                SymbolDisplayMiscellaneousOptions.UseErrorTypeSymbolName); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 6038, 7971);
            VisualBasicShortErrorMessageFormat = f_575_6131_7970(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypes, propertyStyle: SymbolDisplayPropertyStyle.ShowReadWriteDescriptor, genericsOptions:
                                SymbolDisplayGenericsOptions.IncludeTypeParameters |
                                SymbolDisplayGenericsOptions.IncludeTypeConstraints |
                                SymbolDisplayGenericsOptions.IncludeVariance, memberOptions:
                                SymbolDisplayMemberOptions.IncludeParameters |
                                SymbolDisplayMemberOptions.IncludeAccessibility |
                                SymbolDisplayMemberOptions.IncludeType |
                                SymbolDisplayMemberOptions.IncludeRef |
                                SymbolDisplayMemberOptions.IncludeModifiers, kindOptions:
                                SymbolDisplayKindOptions.IncludeMemberKeyword, parameterOptions:
                                SymbolDisplayParameterOptions.IncludeParamsRefOut |
                                SymbolDisplayParameterOptions.IncludeExtensionThis |
                                SymbolDisplayParameterOptions.IncludeType |
                                SymbolDisplayParameterOptions.IncludeName |
                                SymbolDisplayParameterOptions.IncludeOptionalBrackets |
                                SymbolDisplayParameterOptions.IncludeDefaultValue, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                                SymbolDisplayMiscellaneousOptions.UseAsterisksInMultiDimensionalArrays |
                                SymbolDisplayMiscellaneousOptions.UseErrorTypeSymbolName); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 8146, 8726);
            FullyQualifiedFormat = f_575_8225_8725(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 8894, 10229);
            MinimallyQualifiedFormat = f_575_8977_10228(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Omitted, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, memberOptions:
                                SymbolDisplayMemberOptions.IncludeParameters |
                                SymbolDisplayMemberOptions.IncludeType |
                                SymbolDisplayMemberOptions.IncludeRef |
                                SymbolDisplayMemberOptions.IncludeContainingType, kindOptions:
                                SymbolDisplayKindOptions.IncludeMemberKeyword, parameterOptions:
                                SymbolDisplayParameterOptions.IncludeName |
                                SymbolDisplayParameterOptions.IncludeType |
                                SymbolDisplayParameterOptions.IncludeParamsRefOut |
                                SymbolDisplayParameterOptions.IncludeDefaultValue, localOptions: SymbolDisplayLocalOptions.IncludeType, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                                SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 10408, 12545);
            TestFormat = f_575_10434_12545(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, propertyStyle: SymbolDisplayPropertyStyle.ShowReadWriteDescriptor, localOptions: SymbolDisplayLocalOptions.IncludeType, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters | SymbolDisplayGenericsOptions.IncludeVariance, memberOptions:
                                SymbolDisplayMemberOptions.IncludeParameters |
                                SymbolDisplayMemberOptions.IncludeContainingType |
                                SymbolDisplayMemberOptions.IncludeType |
                                SymbolDisplayMemberOptions.IncludeRef |
                                SymbolDisplayMemberOptions.IncludeExplicitInterface, kindOptions:
                                SymbolDisplayKindOptions.IncludeMemberKeyword, parameterOptions:
                                SymbolDisplayParameterOptions.IncludeOptionalBrackets |
                                SymbolDisplayParameterOptions.IncludeDefaultValue |
                                SymbolDisplayParameterOptions.IncludeParamsRefOut |
                                SymbolDisplayParameterOptions.IncludeExtensionThis |
                                SymbolDisplayParameterOptions.IncludeType |
                                SymbolDisplayParameterOptions.IncludeName, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseErrorTypeSymbolName |
                                SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier, compilerInternalOptions:
                                SymbolDisplayCompilerInternalOptions.IncludeScriptType |
                                SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames |
                                SymbolDisplayCompilerInternalOptions.FlagMissingMetadataTypes |
                                SymbolDisplayCompilerInternalOptions.IncludeCustomModifiers); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 12725, 13223);
            TestFormatWithConstraints = f_575_12753_13223(f_575_12753_13058(f_575_12753_12865(TestFormat, f_575_12784_12810(TestFormat) | SymbolDisplayGenericsOptions.IncludeTypeConstraints), SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier), SymbolDisplayCompilerInternalOptions.None); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 13419, 13678);
            QualifiedNameOnlyFormat = f_575_13458_13678(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Omitted, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 13895, 14312);
            QualifiedNameArityFormat = f_575_13935_14312(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Omitted, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, compilerInternalOptions: SymbolDisplayCompilerInternalOptions.UseArityForGenericTypes | SymbolDisplayCompilerInternalOptions.UseValueTuple); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 14472, 15138);
            ShortFormat = f_575_14499_15138(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameOnly, propertyStyle: SymbolDisplayPropertyStyle.NameOnly, parameterOptions: SymbolDisplayParameterOptions.IncludeName, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                                SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 15316, 16322);
            ILVisualizationFormat = f_575_15353_16322(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Omitted, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, memberOptions: SymbolDisplayMemberOptions.IncludeContainingType | SymbolDisplayMemberOptions.IncludeParameters | SymbolDisplayMemberOptions.IncludeType | SymbolDisplayMemberOptions.IncludeRef, kindOptions: SymbolDisplayKindOptions.IncludeMemberKeyword, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, parameterOptions: SymbolDisplayParameterOptions.IncludeParamsRefOut | SymbolDisplayParameterOptions.IncludeType, miscellaneousOptions: SymbolDisplayMiscellaneousOptions.UseSpecialTypes, compilerInternalOptions: SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames | SymbolDisplayCompilerInternalOptions.UseValueTuple); DynAbs.Tracing.TraceSender.TraceSimpleStatement(575, 16594, 17171);
            ExplicitInterfaceImplementationFormat = f_575_16647_17171(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, miscellaneousOptions: SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers, compilerInternalOptions: SymbolDisplayCompilerInternalOptions.ReverseArrayRankSpecifiers); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(575, 402, 42780);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(575, 402, 42780);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(575, 402, 42780);

        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_658_2119(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, propertyStyle: propertyStyle, genericsOptions: genericsOptions, memberOptions: memberOptions, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 658, 2119);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_2350_3798(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, propertyStyle: propertyStyle, genericsOptions: genericsOptions, memberOptions: memberOptions, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 2350, 3798);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_4033_5885(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
        kindOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, propertyStyle: propertyStyle, genericsOptions: genericsOptions, memberOptions: memberOptions, kindOptions: kindOptions, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 4033, 5885);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_6131_7970(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
        kindOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, propertyStyle: propertyStyle, genericsOptions: genericsOptions, memberOptions: memberOptions, kindOptions: kindOptions, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 6131, 7970);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_8225_8725(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, genericsOptions: genericsOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 8225, 8725);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_8977_10228(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
        kindOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
        localOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, genericsOptions: genericsOptions, memberOptions: memberOptions, kindOptions: kindOptions, parameterOptions: parameterOptions, localOptions: localOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 8977, 10228);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_10434_12545(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
        localOptions, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
        kindOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        compilerInternalOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, propertyStyle: propertyStyle, localOptions: localOptions, genericsOptions: genericsOptions, memberOptions: memberOptions, kindOptions: kindOptions, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions, compilerInternalOptions: compilerInternalOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 10434, 12545);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        f_575_12784_12810(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.GenericsOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(575, 12784, 12810);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_12753_12865(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        options)
        {
            var return_v = this_param.WithGenericsOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 12753, 12865);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_12753_13058(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        options)
        {
            var return_v = this_param.AddMiscellaneousOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 12753, 13058);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_12753_13223(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        options)
        {
            var return_v = this_param.WithCompilerInternalOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 12753, 13223);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_13458_13678(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 13458, 13678);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_13935_14312(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        compilerInternalOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, compilerInternalOptions: compilerInternalOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 13935, 14312);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_14499_15138(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, propertyStyle: propertyStyle, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 14499, 15138);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_15353_16322(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
        kindOptions, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        compilerInternalOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, memberOptions: memberOptions, kindOptions: kindOptions, genericsOptions: genericsOptions, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions, compilerInternalOptions: compilerInternalOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 15353, 16322);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_575_16647_17171(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        compilerInternalOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, genericsOptions: genericsOptions, miscellaneousOptions: miscellaneousOptions, compilerInternalOptions: compilerInternalOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(575, 16647, 17171);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        f_575_22994_23026_C(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(575, 21809, 23433);
            return return_v;
        }

    }
}
