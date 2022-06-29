// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Roslyn.Utilities;
using System.Threading;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal class DiagnosticInfo : IFormattable, IObjectWritable
    {
        private readonly CommonMessageProvider _messageProvider;

        private readonly int _errorCode;

        private readonly DiagnosticSeverity _defaultSeverity;

        private readonly DiagnosticSeverity _effectiveSeverity;

        private readonly object[] _arguments;

        private static ImmutableDictionary<int, DiagnosticDescriptor> s_errorCodeToDescriptorMap;

        private static readonly ImmutableArray<string> s_compilerErrorCustomTags;

        private static readonly ImmutableArray<string> s_compilerNonErrorCustomTags;

        static DiagnosticInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(185, 2019, 2162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1422, 1503);
                s_errorCodeToDescriptorMap = ImmutableDictionary<int, DiagnosticDescriptor>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1668, 1827);
                s_compilerErrorCustomTags = f_185_1696_1827(WellKnownDiagnosticTags.Compiler, WellKnownDiagnosticTags.Telemetry, WellKnownDiagnosticTags.NotConfigurable); DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1885, 2006);
                s_compilerNonErrorCustomTags = f_185_1916_2006(WellKnownDiagnosticTags.Compiler, WellKnownDiagnosticTags.Telemetry); DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2067, 2151);

                f_185_2067_2150(typeof(DiagnosticInfo), r => new DiagnosticInfo(r));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(185, 2019, 2162);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 2019, 2162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 2019, 2162);
            }
        }

        internal DiagnosticInfo(CommonMessageProvider messageProvider, int errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(185, 2223, 2581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1114, 1130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1162, 1172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1219, 1235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1282, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1337, 1347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2325, 2360);

                _messageProvider = messageProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2374, 2397);

                _errorCode = errorCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2411, 2469);

                _defaultSeverity = f_185_2430_2468(messageProvider, errorCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2483, 2521);

                _effectiveSeverity = _defaultSeverity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2535, 2570);

                _arguments = f_185_2548_2569();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(185, 2223, 2581);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 2223, 2581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 2223, 2581);
            }
        }

        internal DiagnosticInfo(CommonMessageProvider messageProvider, int errorCode, params object[] arguments)
        : this(f_185_2767_2782_C(messageProvider), errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(185, 2642, 2906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2819, 2856);

                f_185_2819_2855(arguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 2872, 2895);

                _arguments = arguments;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(185, 2642, 2906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 2642, 2906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 2642, 2906);
            }
        }

        protected DiagnosticInfo(DiagnosticInfo original, DiagnosticSeverity overriddenSeverity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(185, 2918, 3294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1114, 1130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1162, 1172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1219, 1235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1282, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1337, 1347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3031, 3075);

                _messageProvider = f_185_3050_3074(original);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3089, 3122);

                _errorCode = original._errorCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3136, 3180);

                _defaultSeverity = f_185_3155_3179(original);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3194, 3227);

                _arguments = original._arguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3243, 3283);

                _effectiveSeverity = overriddenSeverity;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(185, 2918, 3294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 2918, 3294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 2918, 3294);
            }
        }

        internal static DiagnosticDescriptor GetDescriptor(int errorCode, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(185, 3306, 3595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3435, 3496);

                var
                defaultSeverity = f_185_3457_3495(messageProvider, errorCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3510, 3584);

                return f_185_3517_3583(errorCode, defaultSeverity, messageProvider);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(185, 3306, 3595);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_185_3457_3495(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetSeverity(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 3457, 3495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_185_3517_3583(int
                errorCode, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = GetOrCreateDescriptor(errorCode, defaultSeverity, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 3517, 3583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 3306, 3595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 3306, 3595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DiagnosticDescriptor GetOrCreateDescriptor(int errorCode, DiagnosticSeverity defaultSeverity, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(185, 3607, 3936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 3779, 3925);

                return f_185_3786_3924(ref s_errorCodeToDescriptorMap, errorCode, code => CreateDescriptor(code, defaultSeverity, messageProvider));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(185, 3607, 3936);

                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_185_3786_3924(ref System.Collections.Immutable.ImmutableDictionary<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>
                location, int
                key, System.Func<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>
                valueFactory)
                {
                    var return_v = ImmutableInterlocked.GetOrAdd(ref location, key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 3786, 3924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 3607, 3936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 3607, 3936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DiagnosticDescriptor CreateDescriptor(int errorCode, DiagnosticSeverity defaultSeverity, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(185, 3948, 4807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4115, 4169);

                var
                id = f_185_4124_4168(messageProvider, errorCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4183, 4231);

                var
                title = f_185_4195_4230(messageProvider, errorCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4245, 4305);

                var
                description = f_185_4263_4304(messageProvider, errorCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4319, 4383);

                var
                messageFormat = f_185_4339_4382(messageProvider, errorCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4397, 4451);

                var
                helpLink = f_185_4412_4450(messageProvider, errorCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4465, 4519);

                var
                category = f_185_4480_4518(messageProvider, errorCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4533, 4581);

                var
                customTags = f_185_4550_4580(defaultSeverity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4595, 4796);

                return f_185_4602_4795(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: true, description: description, helpLinkUri: helpLink, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(185, 3948, 4807);

                string
                f_185_4124_4168(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4124, 4168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_185_4195_4230(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetTitle(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4195, 4230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_185_4263_4304(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetDescription(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4263, 4304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_185_4339_4382(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetMessageFormat(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4339, 4382);
                    return return_v;
                }


                string
                f_185_4412_4450(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetHelpLink(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4412, 4450);
                    return return_v;
                }


                string
                f_185_4480_4518(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetCategory(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4480, 4518);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_185_4550_4580(Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity)
                {
                    var return_v = GetCustomTags(defaultSeverity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4550, 4580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_185_4602_4795(string
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
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, description: description, helpLinkUri: helpLinkUri, customTags: customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4602, 4795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 3948, 4807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 3948, 4807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        internal static void AssertMessageSerializable(object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(185, 4819, 5586);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4937, 5575);
                    foreach (var arg in f_185_4957_4961_I(args))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 4937, 5575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 4995, 5027);

                        f_185_4995_5026(arg != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5047, 5140) || true) && (arg is IFormattable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 5047, 5140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5112, 5121);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(185, 5047, 5140);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5160, 5185);

                        var
                        type = f_185_5171_5184(arg)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5203, 5335) || true) && (type == typeof(string) || (DynAbs.Tracing.TraceSender.Expression_False(185, 5207, 5265) || type == typeof(AssemblyIdentity)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 5203, 5335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5307, 5316);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(185, 5203, 5335);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5355, 5385);

                        var
                        info = f_185_5366_5384(type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5403, 5493) || true) && (f_185_5407_5423(info))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 5403, 5493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5465, 5474);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(185, 5403, 5493);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5513, 5560);

                        throw f_185_5519_5559(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(185, 4937, 5575);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(185, 1, 639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(185, 1, 639);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(185, 4819, 5586);

                int
                f_185_4995_5026(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4995, 5026);
                    return 0;
                }


                System.Type
                f_185_5171_5184(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 5171, 5184);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_185_5366_5384(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 5366, 5384);
                    return return_v;
                }


                bool
                f_185_5407_5423(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 5407, 5423);
                    return return_v;
                }


                System.Exception
                f_185_5519_5559(System.Type
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 5519, 5559);
                    return return_v;
                }


                object[]
                f_185_4957_4961_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 4957, 4961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 4819, 5586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 4819, 5586);
            }
        }

        internal DiagnosticInfo(CommonMessageProvider messageProvider, bool isWarningAsError, int errorCode, params object[] arguments)
        : this(f_185_5795_5810_C(messageProvider), errorCode, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(185, 5647, 6082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5858, 5940);

                f_185_5858_5939(!isWarningAsError || (DynAbs.Tracing.TraceSender.Expression_False(185, 5871, 5938) || _defaultSeverity == DiagnosticSeverity.Warning));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 5956, 6071) || true) && (isWarningAsError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 5956, 6071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6010, 6056);

                    _effectiveSeverity = DiagnosticSeverity.Error;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 5956, 6071);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(185, 5647, 6082);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 5647, 6082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 5647, 6082);
            }
        }

        internal virtual DiagnosticInfo GetInstanceWithSeverity(DiagnosticSeverity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 6173, 6335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6282, 6324);

                return f_185_6289_6323(this, severity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 6173, 6335);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_185_6289_6323(Microsoft.CodeAnalysis.DiagnosticInfo
                original, Microsoft.CodeAnalysis.DiagnosticSeverity
                overriddenSeverity)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(original, overriddenSeverity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 6289, 6323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 6173, 6335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 6173, 6335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IObjectWritable.ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 6428, 6436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6431, 6436);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(185, 6428, 6436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 6428, 6436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 6428, 6436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void IObjectWritable.WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 6449, 6555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6523, 6544);

                f_185_6523_6543(this, writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 6449, 6555);

                int
                f_185_6523_6543(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Roslyn.Utilities.ObjectWriter
                writer)
                {
                    this_param.WriteTo(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 6523, 6543);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 6449, 6555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 6449, 6555);
            }
        }

        protected virtual void WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 6567, 7149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6643, 6679);

                f_185_6643_6678(writer, _messageProvider);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6693, 6730);

                f_185_6693_6729(writer, _errorCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6744, 6787);

                f_185_6744_6786(writer, _effectiveSeverity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6801, 6842);

                f_185_6801_6841(writer, _defaultSeverity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6858, 6888);

                int
                count = f_185_6870_6887(_arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6902, 6934);

                f_185_6902_6933(writer, count);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6950, 7138) || true) && (count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 6950, 7138);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 6997, 7123);
                        foreach (var arg in f_185_7017_7027_I(_arguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 6997, 7123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7069, 7104);

                            f_185_7069_7103(writer, f_185_7088_7102(arg));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(185, 6997, 7123);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(185, 1, 127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(185, 1, 127);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 6950, 7138);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 6567, 7149);

                int
                f_185_6643_6678(Roslyn.Utilities.ObjectWriter
                this_param, Microsoft.CodeAnalysis.CommonMessageProvider
                value)
                {
                    this_param.WriteValue((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 6643, 6678);
                    return 0;
                }


                int
                f_185_6693_6729(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 6693, 6729);
                    return 0;
                }


                int
                f_185_6744_6786(Roslyn.Utilities.ObjectWriter
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                value)
                {
                    this_param.WriteInt32((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 6744, 6786);
                    return 0;
                }


                int
                f_185_6801_6841(Roslyn.Utilities.ObjectWriter
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                value)
                {
                    this_param.WriteInt32((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 6801, 6841);
                    return 0;
                }


                int
                f_185_6870_6887(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 6870, 6887);
                    return return_v;
                }


                int
                f_185_6902_6933(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 6902, 6933);
                    return 0;
                }


                string?
                f_185_7088_7102(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7088, 7102);
                    return return_v;
                }


                int
                f_185_7069_7103(Roslyn.Utilities.ObjectWriter
                this_param, string?
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7069, 7103);
                    return 0;
                }


                object[]
                f_185_7017_7027_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7017, 7027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 6567, 7149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 6567, 7149);
            }
        }

        protected DiagnosticInfo(ObjectReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(185, 7161, 7907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1114, 1130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1162, 1172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1219, 1235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1282, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 1337, 1347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7231, 7292);

                _messageProvider = (CommonMessageProvider)f_185_7273_7291(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7306, 7344);

                _errorCode = (int)f_185_7324_7343(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7358, 7418);

                _effectiveSeverity = (DiagnosticSeverity)f_185_7399_7417(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7432, 7490);

                _defaultSeverity = (DiagnosticSeverity)f_185_7471_7489(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7506, 7543);

                var
                count = (int)f_185_7523_7542(reader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7557, 7896) || true) && (count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 7557, 7896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7604, 7635);

                    _arguments = new string[count];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7662, 7667);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7653, 7780) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7680, 7683)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(185, 7653, 7780))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 7653, 7780);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7725, 7761);

                            _arguments[i] = f_185_7741_7760(reader);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(185, 1, 128);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(185, 1, 128);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 7557, 7896);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 7557, 7896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 7846, 7881);

                    _arguments = f_185_7859_7880();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 7557, 7896);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(185, 7161, 7907);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 7161, 7907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 7161, 7907);
            }
        }

        public int Code
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 8050, 8076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 8056, 8074);

                    return _errorCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 8050, 8076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 8032, 8078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 8032, 8078);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual DiagnosticDescriptor Descriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 8161, 8289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 8197, 8274);

                    return f_185_8204_8273(_errorCode, _defaultSeverity, _messageProvider);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 8161, 8289);

                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_185_8204_8273(int
                    errorCode, Microsoft.CodeAnalysis.DiagnosticSeverity
                    defaultSeverity, Microsoft.CodeAnalysis.CommonMessageProvider
                    messageProvider)
                    {
                        var return_v = GetOrCreateDescriptor(errorCode, defaultSeverity, messageProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 8204, 8273);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 8090, 8300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 8090, 8300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DiagnosticSeverity Severity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 8729, 8806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 8765, 8791);

                    return _effectiveSeverity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 8729, 8806);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 8670, 8817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 8670, 8817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DiagnosticSeverity DefaultSeverity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 9141, 9216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 9177, 9201);

                    return _defaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 9141, 9216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 9075, 9227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 9075, 9227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int WarningLevel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 9504, 9791);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 9540, 9704) || true) && (_effectiveSeverity != _defaultSeverity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 9540, 9704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 9624, 9685);

                        return f_185_9631_9684(_effectiveSeverity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(185, 9540, 9704);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 9724, 9776);

                    return f_185_9731_9775(_messageProvider, _errorCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 9504, 9791);

                    int
                    f_185_9631_9684(Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity)
                    {
                        var return_v = Diagnostic.GetDefaultWarningLevel(severity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 9631, 9684);
                        return return_v;
                    }


                    int
                    f_185_9731_9775(Microsoft.CodeAnalysis.CommonMessageProvider
                    this_param, int
                    code)
                    {
                        var return_v = this_param.GetWarningLevel(code);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 9731, 9775);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 9456, 9802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 9456, 9802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsWarningAsError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 10210, 10385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 10246, 10370);

                    return f_185_10253_10273(this) == DiagnosticSeverity.Warning && (DynAbs.Tracing.TraceSender.Expression_True(185, 10253, 10369) && f_185_10328_10341(this) == DiagnosticSeverity.Error);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 10210, 10385);

                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_185_10253_10273(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 10253, 10273);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_185_10328_10341(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 10328, 10341);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 10157, 10396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 10157, 10396);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Category
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 10660, 10759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 10696, 10744);

                    return f_185_10703_10743(_messageProvider, _errorCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 10660, 10759);

                    string
                    f_185_10703_10743(Microsoft.CodeAnalysis.CommonMessageProvider
                    this_param, int
                    code)
                    {
                        var return_v = this_param.GetCategory(code);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 10703, 10743);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 10613, 10770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 10613, 10770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<string> CustomTags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 10849, 10939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 10885, 10924);

                    return f_185_10892_10923(_defaultSeverity);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 10849, 10939);

                    System.Collections.Immutable.ImmutableArray<string>
                    f_185_10892_10923(Microsoft.CodeAnalysis.DiagnosticSeverity
                    defaultSeverity)
                    {
                        var return_v = GetCustomTags(defaultSeverity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 10892, 10923);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 10782, 10950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 10782, 10950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static ImmutableArray<string> GetCustomTags(DiagnosticSeverity defaultSeverity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(185, 10962, 11229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 11074, 11218);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(185, 11081, 11124) || ((defaultSeverity == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(185, 11144, 11169)) || DynAbs.Tracing.TraceSender.Conditional_F3(185, 11189, 11217))) ? s_compilerErrorCustomTags : s_compilerNonErrorCustomTags;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(185, 10962, 11229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 10962, 11229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 10962, 11229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsNotConfigurable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 11241, 11421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 11358, 11410);

                return _defaultSeverity == DiagnosticSeverity.Error;
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 11241, 11421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 11241, 11421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 11241, 11421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual IReadOnlyList<Location> AdditionalLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 11789, 11900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 11825, 11885);

                    return f_185_11832_11884();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 11789, 11900);

                    System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                    f_185_11832_11884()
                    {
                        var return_v = SpecializedCollections.EmptyReadOnlyList<Location>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 11832, 11884);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 11706, 11911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 11706, 11911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual string MessageIdentifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 12192, 12297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 12228, 12282);

                    return f_185_12235_12281(_messageProvider, _errorCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 12192, 12297);

                    string
                    f_185_12235_12281(Microsoft.CodeAnalysis.CommonMessageProvider
                    this_param, int
                    errorCode)
                    {
                        var return_v = this_param.GetIdForErrorCode(errorCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 12235, 12281);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 12128, 12308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 12128, 12308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual string GetMessage(IFormatProvider? formatProvider = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 12431, 13002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 12583, 12672);

                string
                message = f_185_12600_12671(_messageProvider, _errorCode, formatProvider as CultureInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 12686, 12788) || true) && (f_185_12690_12719(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 12686, 12788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 12753, 12773);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 12686, 12788);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 12804, 12894) || true) && (f_185_12808_12825(_arguments) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 12804, 12894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 12864, 12879);

                    return message;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 12804, 12894);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 12910, 12991);

                return f_185_12917_12990(formatProvider, message, f_185_12956_12989(this, formatProvider));
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 12431, 13002);

                string
                f_185_12600_12671(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, System.IFormatProvider?
                language)
                {
                    var return_v = this_param.LoadMessage(code, (System.Globalization.CultureInfo?)language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 12600, 12671);
                    return return_v;
                }


                bool
                f_185_12690_12719(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 12690, 12719);
                    return return_v;
                }


                int
                f_185_12808_12825(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 12808, 12825);
                    return return_v;
                }


                object[]
                f_185_12956_12989(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.GetArgumentsToUse(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 12956, 12989);
                    return return_v;
                }


                string
                f_185_12917_12990(System.IFormatProvider?
                provider, string
                format, params object[]
                args)
                {
                    var return_v = String.Format(provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 12917, 12990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 12431, 13002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 12431, 13002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected object[] GetArgumentsToUse(IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 13014, 14323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13108, 13140);

                object[]?
                argumentsToUse = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13163, 13168);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13154, 14260) || true) && (i < f_185_13174_13191(_arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13193, 13196)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(185, 13154, 14260))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 13154, 14260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13230, 13277);

                        var
                        embedded = _arguments[i] as DiagnosticInfo
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13295, 13549) || true) && (embedded != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 13295, 13549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13357, 13421);

                            argumentsToUse = f_185_13374_13420(this, argumentsToUse);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13443, 13499);

                            argumentsToUse[i] = f_185_13463_13498(embedded, formatProvider);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13521, 13530);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(185, 13295, 13549);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13706, 13744);

                        var
                        symbol = _arguments[i] as ISymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13762, 13977) || true) && (symbol == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 13762, 13977);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13822, 13866);

                            var
                            temp = _arguments[i] as ISymbolInternal
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13888, 13958) || true) && (temp != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 13888, 13958);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 13931, 13958);

                                symbol = f_185_13940_13957(temp);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(185, 13888, 13958);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(185, 13762, 13977);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14013, 14245) || true) && (symbol != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 14013, 14245);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14073, 14137);

                            argumentsToUse = f_185_14090_14136(this, argumentsToUse);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14159, 14226);

                            argumentsToUse[i] = f_185_14179_14225(_messageProvider, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(185, 14013, 14245);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(185, 1, 1107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(185, 1, 1107);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14276, 14312);

                return argumentsToUse ?? (DynAbs.Tracing.TraceSender.Expression_Null<object[]?>(185, 14283, 14311) ?? _arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 13014, 14323);

                int
                f_185_13174_13191(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 13174, 13191);
                    return return_v;
                }


                object[]
                f_185_13374_13420(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, object[]?
                argumentsToUse)
                {
                    var return_v = this_param.InitializeArgumentListIfNeeded(argumentsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 13374, 13420);
                    return return_v;
                }


                string
                f_185_13463_13498(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.GetMessage(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 13463, 13498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_185_13940_13957(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 13940, 13957);
                    return return_v;
                }


                object[]
                f_185_14090_14136(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, object[]?
                argumentsToUse)
                {
                    var return_v = this_param.InitializeArgumentListIfNeeded(argumentsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 14090, 14136);
                    return return_v;
                }


                string
                f_185_14179_14225(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.GetErrorDisplayString(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 14179, 14225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 13014, 14323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 13014, 14323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object[] InitializeArgumentListIfNeeded(object[]? argumentsToUse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 14335, 14714);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14433, 14530) || true) && (argumentsToUse != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 14433, 14530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14493, 14515);

                    return argumentsToUse;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 14433, 14530);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14546, 14595);

                var
                newArguments = new object[f_185_14576_14593(_arguments)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14609, 14667);

                f_185_14609_14666(_arguments, newArguments, f_185_14646_14665(newArguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14683, 14703);

                return newArguments;
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 14335, 14714);

                int
                f_185_14576_14593(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 14576, 14593);
                    return return_v;
                }


                int
                f_185_14646_14665(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 14646, 14665);
                    return return_v;
                }


                int
                f_185_14609_14666(object[]
                sourceArray, object[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 14609, 14666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 14335, 14714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 14335, 14714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object[] Arguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 14778, 14804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14784, 14802);

                    return _arguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 14778, 14804);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 14726, 14815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 14726, 14815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CommonMessageProvider MessageProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 14898, 14930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 14904, 14928);

                    return _messageProvider;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(185, 14898, 14930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 14827, 14941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 14827, 14941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string? ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 14986, 15078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15045, 15067);

                return f_185_15052_15066(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 14986, 15078);

                string
                f_185_15052_15066(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.ToString(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 15052, 15066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 14986, 15078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 14986, 15078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToString(IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 15090, 15240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15170, 15229);

                return f_185_15177_15228(((IFormattable)this), null, formatProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 15090, 15240);

                string
                f_185_15177_15228(System.IFormattable
                this_param, string?
                format, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.ToString(format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 15177, 15228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 15090, 15240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 15090, 15240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 15252, 15609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15354, 15598);

                return f_185_15361_15597(formatProvider, "{0}: {1}", f_185_15420_15546(_messageProvider, f_185_15454_15476(this), f_185_15478_15491(this), f_185_15493_15514(this), formatProvider as CultureInfo), f_185_15565_15596(this, formatProvider));
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 15252, 15609);

                string
                f_185_15454_15476(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.MessageIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 15454, 15476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_185_15478_15491(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 15478, 15491);
                    return return_v;
                }


                bool
                f_185_15493_15514(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.IsWarningAsError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 15493, 15514);
                    return return_v;
                }


                string
                f_185_15420_15546(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, string
                id, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity, bool
                isWarningAsError, System.IFormatProvider?
                culture)
                {
                    var return_v = this_param.GetMessagePrefix(id, severity, isWarningAsError, (System.Globalization.CultureInfo?)culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 15420, 15546);
                    return return_v;
                }


                string
                f_185_15565_15596(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.GetMessage(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 15565, 15596);
                    return return_v;
                }


                string
                f_185_15361_15597(System.IFormatProvider?
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = String.Format(provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 15361, 15597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 15252, 15609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 15252, 15609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 15621, 15909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15686, 15712);

                int
                hashCode = _errorCode
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15735, 15740);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15726, 15866) || true) && (i < f_185_15746_15763(_arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15765, 15768)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(185, 15726, 15866))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 15726, 15866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15802, 15851);

                        hashCode = f_185_15813_15850(_arguments[i], hashCode);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(185, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(185, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15882, 15898);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 15621, 15909);

                int
                f_185_15746_15763(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 15746, 15763);
                    return return_v;
                }


                int
                f_185_15813_15850(object
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 15813, 15850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 15621, 15909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 15621, 15909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 15921, 16753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 15993, 16039);

                DiagnosticInfo?
                other = obj as DiagnosticInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16055, 16075);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16091, 16712) || true) && (other != null && (DynAbs.Tracing.TraceSender.Expression_True(185, 16095, 16159) && other._errorCode == _errorCode) && (DynAbs.Tracing.TraceSender.Expression_True(185, 16095, 16213) && f_185_16180_16195(other) == f_185_16199_16213(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 16091, 16712);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16247, 16697) || true) && (f_185_16251_16268(_arguments) == f_185_16272_16295(other._arguments))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 16247, 16697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16337, 16351);

                        result = true;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16382, 16387);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16373, 16678) || true) && (i < f_185_16393_16410(_arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16412, 16415)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(185, 16373, 16678))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 16373, 16678);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16465, 16655) || true) && (!f_185_16470_16519(_arguments[i], other._arguments[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 16465, 16655);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16577, 16592);

                                    result = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(185, 16622, 16628);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 16465, 16655);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(185, 1, 306);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(185, 1, 306);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(185, 16247, 16697);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(185, 16091, 16712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16728, 16742);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 15921, 16753);

                System.Type
                f_185_16180_16195(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 16180, 16195);
                    return return_v;
                }


                System.Type
                f_185_16199_16213(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 16199, 16213);
                    return return_v;
                }


                int
                f_185_16251_16268(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 16251, 16268);
                    return return_v;
                }


                int
                f_185_16272_16295(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 16272, 16295);
                    return return_v;
                }


                int
                f_185_16393_16410(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 16393, 16410);
                    return return_v;
                }


                bool
                f_185_16470_16519(object
                objA, object
                objB)
                {
                    var return_v = object.Equals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 16470, 16519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 15921, 16753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 15921, 16753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string? GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 16765, 17293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 16966, 17282);

                switch (f_185_16974_16978())
                {

                    case InternalErrorCode.Unknown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 16966, 17282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 17065, 17100);

                        return "Unresolved DiagnosticInfo";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(185, 16966, 17282);

                    case InternalErrorCode.Void:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 16966, 17282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 17170, 17199);

                        return "Void DiagnosticInfo";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(185, 16966, 17282);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(185, 16966, 17282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 17249, 17267);

                        return f_185_17256_17266(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(185, 16966, 17282);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 16765, 17293);

                int
                f_185_16974_16978()
                {
                    var return_v = Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 16974, 16978);
                    return return_v;
                }


                string?
                f_185_17256_17266(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 17256, 17266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 16765, 17293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 16765, 17293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual DiagnosticInfo GetResolvedInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(185, 17489, 17693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(185, 17645, 17682);

                throw f_185_17651_17681();
                DynAbs.Tracing.TraceSender.TraceExitMethod(185, 17489, 17693);

                System.Exception
                f_185_17651_17681()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 17651, 17681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(185, 17489, 17693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(185, 17489, 17693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(185, 944, 17700);

        static System.Collections.Immutable.ImmutableArray<string>
        f_185_1696_1827(string
        item1, string
        item2, string
        item3)
        {
            var return_v = ImmutableArray.Create(item1, item2, item3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 1696, 1827);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_185_1916_2006(string
        item1, string
        item2)
        {
            var return_v = ImmutableArray.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 1916, 2006);
            return return_v;
        }


        static int
        f_185_2067_2150(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 2067, 2150);
            return 0;
        }


        static Microsoft.CodeAnalysis.DiagnosticSeverity
        f_185_2430_2468(Microsoft.CodeAnalysis.CommonMessageProvider
        this_param, int
        code)
        {
            var return_v = this_param.GetSeverity(code);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 2430, 2468);
            return return_v;
        }


        static object[]
        f_185_2548_2569()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 2548, 2569);
            return return_v;
        }


        static int
        f_185_2819_2855(object[]
        args)
        {
            AssertMessageSerializable(args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 2819, 2855);
            return 0;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_185_2767_2782_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(185, 2642, 2906);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_185_3050_3074(Microsoft.CodeAnalysis.DiagnosticInfo
        this_param)
        {
            var return_v = this_param.MessageProvider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 3050, 3074);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticSeverity
        f_185_3155_3179(Microsoft.CodeAnalysis.DiagnosticInfo
        this_param)
        {
            var return_v = this_param.DefaultSeverity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(185, 3155, 3179);
            return return_v;
        }


        static int
        f_185_5858_5939(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 5858, 5939);
            return 0;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_185_5795_5810_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(185, 5647, 6082);
            return return_v;
        }


        static object
        f_185_7273_7291(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadValue();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7273, 7291);
            return return_v;
        }


        static uint
        f_185_7324_7343(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadUInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7324, 7343);
            return return_v;
        }


        static int
        f_185_7399_7417(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7399, 7417);
            return return_v;
        }


        static int
        f_185_7471_7489(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7471, 7489);
            return return_v;
        }


        static uint
        f_185_7523_7542(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadUInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7523, 7542);
            return return_v;
        }


        static string
        f_185_7741_7760(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7741, 7760);
            return return_v;
        }


        static object[]
        f_185_7859_7880()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(185, 7859, 7880);
            return return_v;
        }

    }
}
