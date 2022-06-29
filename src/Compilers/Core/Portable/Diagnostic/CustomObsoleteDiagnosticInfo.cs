// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    internal sealed class CustomObsoleteDiagnosticInfo : DiagnosticInfo
    {
        private DiagnosticDescriptor? _descriptor;

        internal ObsoleteAttributeData Data { get; }

        internal CustomObsoleteDiagnosticInfo(CommonMessageProvider messageProvider, int errorCode, ObsoleteAttributeData data, params object[] arguments)
        : base(f_179_779_794_C(messageProvider), errorCode, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(179, 612, 865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 534, 545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 556, 600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 842, 854);

                Data = data;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(179, 612, 865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(179, 612, 865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(179, 612, 865);
            }
        }

        private CustomObsoleteDiagnosticInfo(CustomObsoleteDiagnosticInfo baseInfo, DiagnosticSeverity effectiveSeverity)
        : base(f_179_1011_1019_C(baseInfo), effectiveSeverity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(179, 877, 1096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 534, 545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 556, 600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1064, 1085);

                Data = f_179_1071_1084(baseInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(179, 877, 1096);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(179, 877, 1096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(179, 877, 1096);
            }
        }

        public override string MessageIdentifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(179, 1173, 1419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1209, 1236);

                    var
                    id = f_179_1218_1222().DiagnosticId
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1254, 1354) || true) && (!f_179_1259_1283(id))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(179, 1254, 1354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1325, 1335);

                        return id;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(179, 1254, 1354);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1374, 1404);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.MessageIdentifier, 179, 1381, 1403);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(179, 1173, 1419);

                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_179_1218_1222()
                    {
                        var return_v = Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 1218, 1222);
                        return return_v;
                    }


                    bool
                    f_179_1259_1283(string?
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 1259, 1283);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(179, 1108, 1430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(179, 1108, 1430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DiagnosticDescriptor Descriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(179, 1514, 1759);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1550, 1705) || true) && (_descriptor == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(179, 1550, 1705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1615, 1686);

                        f_179_1615_1685(ref _descriptor, f_179_1660_1678(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(179, 1550, 1705);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1725, 1744);

                    return _descriptor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(179, 1514, 1759);

                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_179_1660_1678(Microsoft.CodeAnalysis.CustomObsoleteDiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.CreateDescriptor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 1660, 1678);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticDescriptor?
                    f_179_1615_1685(ref Microsoft.CodeAnalysis.DiagnosticDescriptor?
                    location1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    value, Microsoft.CodeAnalysis.DiagnosticDescriptor?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 1615, 1685);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(179, 1442, 1770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(179, 1442, 1770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo GetInstanceWithSeverity(DiagnosticSeverity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(179, 1782, 1959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 1892, 1948);

                return f_179_1899_1947(this, severity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(179, 1782, 1959);

                Microsoft.CodeAnalysis.CustomObsoleteDiagnosticInfo
                f_179_1899_1947(Microsoft.CodeAnalysis.CustomObsoleteDiagnosticInfo
                baseInfo, Microsoft.CodeAnalysis.DiagnosticSeverity
                effectiveSeverity)
                {
                    var return_v = new Microsoft.CodeAnalysis.CustomObsoleteDiagnosticInfo(baseInfo, effectiveSeverity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 1899, 1947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(179, 1782, 1959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(179, 1782, 1959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DiagnosticDescriptor CreateDescriptor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(179, 1971, 4024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2043, 2080);

                var
                baseDescriptor = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Descriptor, 179, 2064, 2079)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2094, 2131);

                var
                diagnosticId = f_179_2113_2117().DiagnosticId
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2145, 2176);

                var
                urlFormat = f_179_2161_2165().UrlFormat
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2190, 2306) || true) && (diagnosticId is null && (DynAbs.Tracing.TraceSender.Expression_True(179, 2194, 2235) && urlFormat is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(179, 2190, 2306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2269, 2291);

                    return baseDescriptor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(179, 2190, 2306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2322, 2349);

                var
                id = f_179_2331_2348()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2363, 2408);

                var
                helpLinkUri = f_179_2381_2407(baseDescriptor)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2424, 2768) || true) && (urlFormat is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(179, 2424, 2768);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2525, 2568);

                        helpLinkUri = f_179_2539_2567(urlFormat, id);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(179, 2605, 2753);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(179, 2605, 2753);
                        // if string.Format fails we just want to use the default (non-user specified) URI.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(179, 2424, 2768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2784, 2818);

                ImmutableArray<string>
                customTags
                = default(ImmutableArray<string>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2832, 3499) || true) && (diagnosticId is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(179, 2832, 3499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 2890, 2948);

                    customTags = f_179_2903_2947(f_179_2903_2928(baseDescriptor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(179, 2832, 3499);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(179, 2832, 3499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3014, 3031);

                    var
                    capacity = 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3049, 3201) || true) && (f_179_3053_3078(baseDescriptor) is ICollection<string> { Count: int count })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(179, 3049, 3201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3164, 3182);

                        capacity += count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(179, 3049, 3201);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3219, 3280);

                    var
                    tagsBuilder = f_179_3237_3279(capacity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3298, 3346);

                    f_179_3298_3345(tagsBuilder, f_179_3319_3344(baseDescriptor));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3364, 3420);

                    f_179_3364_3419(tagsBuilder, WellKnownDiagnosticTags.CustomObsolete);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3438, 3484);

                    customTags = f_179_3451_3483(tagsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(179, 2832, 3499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(179, 3515, 4013);

                return f_179_3522_4012(id: id, title: f_179_3597_3617(baseDescriptor), messageFormat: f_179_3651_3679(baseDescriptor), category: f_179_3708_3731(baseDescriptor), defaultSeverity: f_179_3767_3797(baseDescriptor), isEnabledByDefault: f_179_3836_3869(baseDescriptor), description: f_179_3901_3927(baseDescriptor), helpLinkUri: helpLinkUri, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(179, 1971, 4024);

                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_179_2113_2117()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 2113, 2117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_179_2161_2165()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 2161, 2165);
                    return return_v;
                }


                string
                f_179_2331_2348()
                {
                    var return_v = MessageIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 2331, 2348);
                    return return_v;
                }


                string
                f_179_2381_2407(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 2381, 2407);
                    return return_v;
                }


                string
                f_179_2539_2567(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 2539, 2567);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_179_2903_2928(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 2903, 2928);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_179_2903_2947(System.Collections.Generic.IEnumerable<string>
                items)
                {
                    var return_v = items.ToImmutableArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 2903, 2947);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_179_3053_3078(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3053, 3078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_179_3237_3279(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 3237, 3279);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_179_3319_3344(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3319, 3344);
                    return return_v;
                }


                int
                f_179_3298_3345(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 3298, 3345);
                    return 0;
                }


                int
                f_179_3364_3419(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 3364, 3419);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_179_3451_3483(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 3451, 3483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_179_3597_3617(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3597, 3617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_179_3651_3679(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.MessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3651, 3679);
                    return return_v;
                }


                string
                f_179_3708_3731(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3708, 3731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_179_3767_3797(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3767, 3797);
                    return return_v;
                }


                bool
                f_179_3836_3869(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3836, 3869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_179_3901_3927(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 3901, 3927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_179_3522_4012(string
                id, Microsoft.CodeAnalysis.LocalizableString
                title, Microsoft.CodeAnalysis.LocalizableString
                messageFormat, string
                category, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity, bool
                isEnabledByDefault, Microsoft.CodeAnalysis.LocalizableString
                description, string
                helpLinkUri, System.Collections.Immutable.ImmutableArray<string>
                customTags)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id: id, title: title, messageFormat: messageFormat, category: category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, description: description, helpLinkUri: helpLinkUri, customTags: customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(179, 3522, 4012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(179, 1971, 4024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(179, 1971, 4024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomObsoleteDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(179, 420, 4031);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(179, 420, 4031);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(179, 420, 4031);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(179, 420, 4031);

        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_179_779_794_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(179, 612, 865);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ObsoleteAttributeData
        f_179_1071_1084(Microsoft.CodeAnalysis.CustomObsoleteDiagnosticInfo
        this_param)
        {
            var return_v = this_param.Data;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(179, 1071, 1084);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticInfo
        f_179_1011_1019_C(Microsoft.CodeAnalysis.DiagnosticInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(179, 877, 1096);
            return return_v;
        }

    }
}
