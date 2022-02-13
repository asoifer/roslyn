// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class WrappedPropertySymbol : PropertySymbol
    {
        protected readonly PropertySymbol _underlyingProperty;

        public WrappedPropertySymbol(PropertySymbol underlyingProperty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10388, 1002, 1205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 970, 989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 1090, 1139);

                f_10388_1090_1138((object)underlyingProperty != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 1153, 1194);

                _underlyingProperty = underlyingProperty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10388, 1002, 1205);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 1002, 1205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 1002, 1205);
            }
        }

        public PropertySymbol UnderlyingProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 1282, 1360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 1318, 1345);

                    return _underlyingProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 1282, 1360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 1217, 1371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 1217, 1371);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 1449, 1505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 1455, 1503);

                    return f_10388_1462_1502(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 1449, 1505);

                    bool
                    f_10388_1462_1502(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 1462, 1502);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 1383, 1516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 1383, 1516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 1584, 1670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 1620, 1655);

                    return f_10388_1627_1654(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 1584, 1670);

                    Microsoft.CodeAnalysis.RefKind
                    f_10388_1627_1654(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 1627, 1654);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 1528, 1681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 1528, 1681);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsIndexer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 1748, 1836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 1784, 1821);

                    return f_10388_1791_1820(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 1748, 1836);

                    bool
                    f_10388_1791_1820(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsIndexer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 1791, 1820);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 1693, 1847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 1693, 1847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Microsoft.Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 1951, 2047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 1987, 2032);

                    return f_10388_1994_2031(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 1951, 2047);

                    Microsoft.Cci.CallingConvention
                    f_10388_1994_2031(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 1994, 2031);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 1859, 2058);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 1859, 2058);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 2122, 2205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 2158, 2190);

                    return f_10388_2165_2189(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 2122, 2205);

                    string
                    f_10388_2165_2189(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 2165, 2189);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 2070, 2216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 2070, 2216);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 2290, 2383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 2326, 2368);

                    return f_10388_2333_2367(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 2290, 2383);

                    bool
                    f_10388_2333_2367(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 2333, 2367);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 2228, 2394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 2228, 2394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 2406, 2730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 2612, 2719);

                return f_10388_2619_2718(_underlyingProperty, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 2406, 2730);

                string
                f_10388_2619_2718(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10388, 2619, 2718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 2406, 2730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 2406, 2730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 2817, 2905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 2853, 2890);

                    return f_10388_2860_2889(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 2817, 2905);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10388_2860_2889(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 2860, 2889);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 2742, 2916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 2742, 2916);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 3026, 3130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 3062, 3115);

                    return f_10388_3069_3114(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 3026, 3130);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10388_3069_3114(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 3069, 3114);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 2928, 3141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 2928, 3141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 3229, 3329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 3265, 3314);

                    return f_10388_3272_3313(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 3229, 3329);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10388_3272_3313(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 3272, 3313);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 3153, 3340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 3153, 3340);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 3406, 3493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 3442, 3478);

                    return f_10388_3449_3477(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 3406, 3493);

                    bool
                    f_10388_3449_3477(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 3449, 3477);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 3352, 3504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 3352, 3504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 3571, 3659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 3607, 3644);

                    return f_10388_3614_3643(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 3571, 3659);

                    bool
                    f_10388_3614_3643(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 3614, 3643);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 3516, 3670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 3516, 3670);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 3738, 3827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 3774, 3812);

                    return f_10388_3781_3811(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 3738, 3827);

                    bool
                    f_10388_3781_3811(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 3781, 3811);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 3682, 3838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 3682, 3838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 3906, 3995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 3942, 3980);

                    return f_10388_3949_3979(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 3906, 3995);

                    bool
                    f_10388_3949_3979(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 3949, 3979);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 3850, 4006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 3850, 4006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 4072, 4159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 4108, 4144);

                    return f_10388_4115_4143(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 4072, 4159);

                    bool
                    f_10388_4115_4143(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 4115, 4143);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 4018, 4170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 4018, 4170);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 4236, 4323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 4272, 4308);

                    return f_10388_4279_4307(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 4236, 4323);

                    bool
                    f_10388_4279_4307(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 4279, 4307);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 4182, 4334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 4182, 4334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 4432, 4532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 4468, 4517);

                    return f_10388_4475_4516(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 4432, 4532);

                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10388_4475_4516(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 4475, 4516);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 4346, 4543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 4346, 4543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 4615, 4706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 4651, 4691);

                    return f_10388_4658_4690(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 4615, 4706);

                    string
                    f_10388_4658_4690(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 4658, 4690);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 4555, 4717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 4555, 4717);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10388, 4798, 4898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10388, 4834, 4883);

                    return f_10388_4841_4882(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10388, 4798, 4898);

                    bool
                    f_10388_4841_4882(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10388, 4841, 4882);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10388, 4729, 4909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 4729, 4909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WrappedPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10388, 766, 4916);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10388, 766, 4916);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10388, 766, 4916);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10388, 766, 4916);

        int
        f_10388_1090_1138(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10388, 1090, 1138);
            return 0;
        }

    }
}
