// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class WrappedEventSymbol : EventSymbol
    {
        protected readonly EventSymbol _underlyingEvent;

        public WrappedEventSymbol(EventSymbol underlyingEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10383, 986, 1177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 957, 973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 1065, 1117);

                f_10383_1065_1116((object)underlyingEvent != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 1131, 1166);

                _underlyingEvent = underlyingEvent;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10383, 986, 1177);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 986, 1177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 986, 1177);
            }
        }

        public EventSymbol UnderlyingEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 1248, 1323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 1284, 1308);

                    return _underlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 1248, 1323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 1189, 1334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 1189, 1334);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 1412, 1508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 1448, 1493);

                    return f_10383_1455_1492(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 1412, 1508);

                    bool
                    f_10383_1455_1492(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 1455, 1492);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 1346, 1519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 1346, 1519);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 1593, 1683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 1629, 1668);

                    return f_10383_1636_1667(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 1593, 1683);

                    bool
                    f_10383_1636_1667(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 1636, 1667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 1531, 1694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 1531, 1694);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 1758, 1838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 1794, 1823);

                    return f_10383_1801_1822(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 1758, 1838);

                    string
                    f_10383_1801_1822(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 1801, 1822);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 1706, 1849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 1706, 1849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 1861, 2183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 2068, 2172);

                return f_10383_2075_2171(_underlyingEvent, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 1861, 2183);

                string
                f_10383_2075_2171(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10383, 2075, 2171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 1861, 2183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 1861, 2183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 2270, 2355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 2306, 2340);

                    return f_10383_2313_2339(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 2270, 2355);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10383_2313_2339(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 2313, 2339);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 2195, 2366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 2195, 2366);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 2476, 2577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 2512, 2562);

                    return f_10383_2519_2561(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 2476, 2577);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10383_2519_2561(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 2519, 2561);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 2378, 2588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 2378, 2588);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 2676, 2773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 2712, 2758);

                    return f_10383_2719_2757(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 2676, 2773);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10383_2719_2757(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 2719, 2757);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 2600, 2784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 2600, 2784);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 2850, 2934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 2886, 2919);

                    return f_10383_2893_2918(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 2850, 2934);

                    bool
                    f_10383_2893_2918(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 2893, 2918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 2796, 2945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 2796, 2945);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 3012, 3097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 3048, 3082);

                    return f_10383_3055_3081(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 3012, 3097);

                    bool
                    f_10383_3055_3081(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 3055, 3081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 2957, 3108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 2957, 3108);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 3176, 3262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 3212, 3247);

                    return f_10383_3219_3246(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 3176, 3262);

                    bool
                    f_10383_3219_3246(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 3219, 3246);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 3120, 3273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 3120, 3273);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 3341, 3427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 3377, 3412);

                    return f_10383_3384_3411(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 3341, 3427);

                    bool
                    f_10383_3384_3411(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 3384, 3411);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 3285, 3438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 3285, 3438);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 3504, 3588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 3540, 3573);

                    return f_10383_3547_3572(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 3504, 3588);

                    bool
                    f_10383_3547_3572(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 3547, 3572);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 3450, 3599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 3450, 3599);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 3665, 3749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 3701, 3734);

                    return f_10383_3708_3733(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 3665, 3749);

                    bool
                    f_10383_3708_3733(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 3708, 3733);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 3611, 3760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 3611, 3760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 3859, 3956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 3895, 3941);

                    return f_10383_3902_3940(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 3859, 3956);

                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10383_3902_3940(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 3902, 3940);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 3772, 3967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 3772, 3967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsWindowsRuntimeEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 4046, 4143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 4082, 4128);

                    return f_10383_4089_4127(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 4046, 4143);

                    bool
                    f_10383_4089_4127(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsWindowsRuntimeEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 4089, 4127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 3979, 4154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 3979, 4154);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10383, 4235, 4332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10383, 4271, 4317);

                    return f_10383_4278_4316(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10383, 4235, 4332);

                    bool
                    f_10383_4278_4316(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10383, 4278, 4316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10383, 4166, 4343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 4166, 4343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WrappedEventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10383, 765, 4350);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10383, 765, 4350);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10383, 765, 4350);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10383, 765, 4350);

        int
        f_10383_1065_1116(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10383, 1065, 1116);
            return 0;
        }

    }
}
