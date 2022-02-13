// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using Xunit;
using Roslyn.Test.Utilities;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public sealed class DiagnosticDescription
    {
        public static readonly DiagnosticDescription[] None;

        public static readonly DiagnosticDescription[] Any;

        private readonly object _code;

        private readonly bool _isWarningAsError;

        private readonly bool _isSuppressed;

        private readonly string _squiggledText;

        private readonly object[] _arguments;

        private readonly LinePosition? _startPosition;

        private readonly bool _argumentOrderDoesNotMatter;

        private readonly Type _errorCodeType;

        private readonly bool _ignoreArgumentsWhenComparing;

        private readonly DiagnosticSeverity? _defaultSeverityOpt;

        private readonly DiagnosticSeverity? _effectiveSeverityOpt;

        private readonly Func<SyntaxNode, bool> _syntaxPredicate;

        private bool _showPredicate;

        private readonly Location _location;

        private IEnumerable<string> _argumentsAsStrings;

        private IEnumerable<string> GetArgumentsAsStrings()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 1971, 2761);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 2047, 2709) || true) && (_argumentsAsStrings == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 2047, 2709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 2321, 2694);

                    _argumentsAsStrings = f_25003_2343_2693(_arguments, o =>
                                    {
                                        if (o is DiagnosticInfo embedded)
                                        {
                                            return embedded.GetMessage(EnsureEnglishUICulture.PreferredOrNull);
                                        }

                                        return string.Format(EnsureEnglishUICulture.PreferredOrNull, "{0}", o);
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 2047, 2709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 2723, 2750);

                return _argumentsAsStrings;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 1971, 2761);

                System.Collections.Generic.IEnumerable<string>
                f_25003_2343_2693(object[]
                source, System.Func<object, string>
                selector)
                {
                    var return_v = source.Select<object, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 2343, 2693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 1971, 2761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 1971, 2761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticDescription(
                    object code,
                    bool isWarningAsError,
                    string squiggledText,
                    object[] arguments,
                    LinePosition? startLocation,
                    Func<SyntaxNode, bool> syntaxNodePredicate,
                    bool argumentOrderDoesNotMatter,
                    Type errorCodeType = null,
                    DiagnosticSeverity? defaultSeverityOpt = null,
                    DiagnosticSeverity? effectiveSeverityOpt = null,
                    bool isSuppressed = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25003, 2773, 3850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 912, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 950, 967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1000, 1013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1048, 1062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1099, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1151, 1165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1276, 1303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1336, 1350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1383, 1412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1460, 1479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1527, 1548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1673, 1689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1713, 1727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1891, 1900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1941, 1960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3304, 3317);

                _code = code;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3331, 3368);

                _isWarningAsError = isWarningAsError;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3382, 3413);

                _squiggledText = squiggledText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3427, 3450);

                _arguments = arguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3464, 3495);

                _startPosition = startLocation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3509, 3548);

                _syntaxPredicate = syntaxNodePredicate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3562, 3619);

                _argumentOrderDoesNotMatter = argumentOrderDoesNotMatter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3633, 3682);

                _errorCodeType = errorCodeType ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type?>(25003, 3650, 3681) ?? f_25003_3667_3681(code));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3696, 3737);

                _defaultSeverityOpt = defaultSeverityOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3751, 3796);

                _effectiveSeverityOpt = effectiveSeverityOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 3810, 3839);

                _isSuppressed = isSuppressed;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25003, 2773, 3850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 2773, 3850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 2773, 3850);
            }
        }

        public DiagnosticDescription(
                    object code,
                    string squiggledText,
                    object[] arguments,
                    LinePosition? startLocation,
                    Func<SyntaxNode, bool> syntaxNodePredicate,
                    bool argumentOrderDoesNotMatter,
                    Type errorCodeType = null,
                    DiagnosticSeverity? defaultSeverityOpt = null,
                    DiagnosticSeverity? effectiveSeverityOpt = null,
                    bool isSuppressed = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25003, 3862, 4892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 912, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 950, 967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1000, 1013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1048, 1062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1099, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1151, 1165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1276, 1303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1336, 1350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1383, 1412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1460, 1479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1527, 1548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1673, 1689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1713, 1727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1891, 1900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1941, 1960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4357, 4370);

                _code = code;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4384, 4410);

                _isWarningAsError = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4424, 4455);

                _squiggledText = squiggledText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4469, 4492);

                _arguments = arguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4506, 4537);

                _startPosition = startLocation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4551, 4590);

                _syntaxPredicate = syntaxNodePredicate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4604, 4661);

                _argumentOrderDoesNotMatter = argumentOrderDoesNotMatter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4675, 4724);

                _errorCodeType = errorCodeType ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type?>(25003, 4692, 4723) ?? f_25003_4709_4723(code));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4738, 4779);

                _defaultSeverityOpt = defaultSeverityOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4793, 4838);

                _effectiveSeverityOpt = effectiveSeverityOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 4852, 4881);

                _isSuppressed = isSuppressed;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25003, 3862, 4892);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 3862, 4892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 3862, 4892);
            }
        }

        public DiagnosticDescription(Diagnostic d, bool errorCodeOnly, bool includeDefaultSeverity = false, bool includeEffectiveSeverity = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25003, 4904, 7352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 912, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 950, 967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1000, 1013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1048, 1062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1099, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1151, 1165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1276, 1303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1336, 1350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1383, 1412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1460, 1479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1527, 1548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1673, 1689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1713, 1727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1891, 1900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 1941, 1960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5067, 5082);

                _code = f_25003_5075_5081(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5096, 5135);

                _isWarningAsError = f_25003_5116_5134(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5149, 5180);

                _isSuppressed = f_25003_5165_5179(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5194, 5217);

                _location = f_25003_5206_5216(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5231, 5324);

                _defaultSeverityOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(25003, 5253, 5275) || ((includeDefaultSeverity && DynAbs.Tracing.TraceSender.Conditional_F2(25003, 5278, 5295)) || DynAbs.Tracing.TraceSender.Conditional_F3(25003, 5298, 5323))) ? f_25003_5278_5295(d) : (DiagnosticSeverity?)null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5338, 5428);

                _effectiveSeverityOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(25003, 5362, 5386) || ((includeEffectiveSeverity && DynAbs.Tracing.TraceSender.Conditional_F2(25003, 5389, 5399)) || DynAbs.Tracing.TraceSender.Conditional_F3(25003, 5402, 5427))) ? f_25003_5389_5399(d) : (DiagnosticSeverity?)null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5444, 5476);

                DiagnosticWithInfo
                dinfo = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5490, 6130) || true) && (f_25003_5494_5500(d) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(25003, 5494, 5581) || f_25003_5509_5581(f_25003_5509_5532(f_25003_5509_5521(d)), WellKnownDiagnosticTags.CustomObsolete)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 5490, 6130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5615, 5628);

                    _code = f_25003_5623_5627(d);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5646, 5678);

                    _errorCodeType = typeof(string);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 5490, 6130);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 5490, 6130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5744, 5776);

                    dinfo = d as DiagnosticWithInfo;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5794, 6115) || true) && (dinfo == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 5794, 6115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5853, 5868);

                        _code = f_25003_5861_5867(d);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 5890, 5919);

                        _errorCodeType = typeof(int);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 5794, 6115);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 5794, 6115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6001, 6059);

                        _errorCodeType = f_25003_6018_6058(f_25003_6018_6044(f_25003_6018_6028(dinfo)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6081, 6096);

                        _code = f_25003_6089_6095(d);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 5794, 6115);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 5490, 6130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6146, 6192);

                _ignoreArgumentsWhenComparing = errorCodeOnly;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6208, 7260) || true) && (!_ignoreArgumentsWhenComparing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 6208, 7260);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6276, 6580) || true) && (f_25003_6280_6300(_location))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 6276, 6580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6482, 6561);

                        _squiggledText = f_25003_6499_6560(f_25003_6499_6529(f_25003_6499_6519(_location)), f_25003_6539_6559(_location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 6276, 6580);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6600, 7098) || true) && (dinfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 6600, 7098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6659, 6693);

                        _arguments = f_25003_6672_6692(f_25003_6672_6682(dinfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 6600, 7098);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 6600, 7098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6775, 6798);

                        var
                        args = f_25003_6786_6797(d)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6820, 7079) || true) && (args == null || (DynAbs.Tracing.TraceSender.Expression_False(25003, 6824, 6855) || f_25003_6840_6850(args) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 6820, 7079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 6905, 6923);

                            _arguments = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 6820, 7079);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 6820, 7079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 7021, 7056);

                            _arguments = f_25003_7034_7055(f_25003_7034_7045(d));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 6820, 7079);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 6600, 7098);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 7118, 7245) || true) && (_arguments != null && (DynAbs.Tracing.TraceSender.Expression_True(25003, 7122, 7166) && f_25003_7144_7161(_arguments) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 7118, 7245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 7208, 7226);

                        _arguments = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 7118, 7245);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 6208, 7260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 7276, 7341);

                _startPosition = f_25003_7293_7322(_location).StartLinePosition;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25003, 4904, 7352);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 4904, 7352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 4904, 7352);
            }
        }

        public DiagnosticDescription WithArguments(params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 7364, 7671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 7458, 7660);

                return f_25003_7465_7659(_code, _isWarningAsError, _squiggledText, arguments, _startPosition, _syntaxPredicate, false, _errorCodeType, _defaultSeverityOpt, _effectiveSeverityOpt, _isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 7364, 7671);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_7465_7659(object
                code, bool
                isWarningAsError, string
                squiggledText, object[]
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, Microsoft.CodeAnalysis.DiagnosticSeverity?
                defaultSeverityOpt, Microsoft.CodeAnalysis.DiagnosticSeverity?
                effectiveSeverityOpt, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, defaultSeverityOpt, effectiveSeverityOpt, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 7465, 7659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 7364, 7671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 7364, 7671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticDescription WithArgumentsAnyOrder(params string[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 7683, 7997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 7785, 7986);

                return f_25003_7792_7985(_code, _isWarningAsError, _squiggledText, arguments, _startPosition, _syntaxPredicate, true, _errorCodeType, _defaultSeverityOpt, _effectiveSeverityOpt, _isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 7683, 7997);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_7792_7985(object
                code, bool
                isWarningAsError, string
                squiggledText, string[]
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, Microsoft.CodeAnalysis.DiagnosticSeverity?
                defaultSeverityOpt, Microsoft.CodeAnalysis.DiagnosticSeverity?
                effectiveSeverityOpt, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, (object[])arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, defaultSeverityOpt, effectiveSeverityOpt, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 7792, 7985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 7683, 7997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 7683, 7997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticDescription WithWarningAsError(bool isWarningAsError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 8009, 8316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 8104, 8305);

                return f_25003_8111_8304(_code, isWarningAsError, _squiggledText, _arguments, _startPosition, _syntaxPredicate, true, _errorCodeType, _defaultSeverityOpt, _effectiveSeverityOpt, _isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 8009, 8316);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_8111_8304(object
                code, bool
                isWarningAsError, string
                squiggledText, object[]
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, Microsoft.CodeAnalysis.DiagnosticSeverity?
                defaultSeverityOpt, Microsoft.CodeAnalysis.DiagnosticSeverity?
                effectiveSeverityOpt, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, defaultSeverityOpt, effectiveSeverityOpt, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 8111, 8304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 8009, 8316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 8009, 8316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticDescription WithDefaultSeverity(DiagnosticSeverity defaultSeverity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 8328, 8646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 8437, 8635);

                return f_25003_8444_8634(_code, _isWarningAsError, _squiggledText, _arguments, _startPosition, _syntaxPredicate, true, _errorCodeType, defaultSeverity, _effectiveSeverityOpt, _isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 8328, 8646);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_8444_8634(object
                code, bool
                isWarningAsError, string
                squiggledText, object[]
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverityOpt, Microsoft.CodeAnalysis.DiagnosticSeverity?
                effectiveSeverityOpt, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, (Microsoft.CodeAnalysis.DiagnosticSeverity?)defaultSeverityOpt, effectiveSeverityOpt, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 8444, 8634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 8328, 8646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 8328, 8646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticDescription WithEffectiveSeverity(DiagnosticSeverity effectiveSeverity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 8658, 8980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 8771, 8969);

                return f_25003_8778_8968(_code, _isWarningAsError, _squiggledText, _arguments, _startPosition, _syntaxPredicate, true, _errorCodeType, _defaultSeverityOpt, effectiveSeverity, _isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 8658, 8980);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_8778_8968(object
                code, bool
                isWarningAsError, string
                squiggledText, object[]
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, Microsoft.CodeAnalysis.DiagnosticSeverity?
                defaultSeverityOpt, Microsoft.CodeAnalysis.DiagnosticSeverity
                effectiveSeverityOpt, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, defaultSeverityOpt, (Microsoft.CodeAnalysis.DiagnosticSeverity?)effectiveSeverityOpt, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 8778, 8968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 8658, 8980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 8658, 8980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticDescription WithLocation(int line, int column)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 9139, 9487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 9227, 9476);

                return f_25003_9234_9475(_code, _isWarningAsError, _squiggledText, _arguments, f_25003_9314_9352(line - 1, column - 1), _syntaxPredicate, _argumentOrderDoesNotMatter, _errorCodeType, _defaultSeverityOpt, _effectiveSeverityOpt, _isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 9139, 9487);

                Microsoft.CodeAnalysis.Text.LinePosition
                f_25003_9314_9352(int
                line, int
                character)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(line, character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 9314, 9352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_9234_9475(object
                code, bool
                isWarningAsError, string
                squiggledText, object[]
                arguments, Microsoft.CodeAnalysis.Text.LinePosition
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, Microsoft.CodeAnalysis.DiagnosticSeverity?
                defaultSeverityOpt, Microsoft.CodeAnalysis.DiagnosticSeverity?
                effectiveSeverityOpt, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, arguments, (Microsoft.CodeAnalysis.Text.LinePosition?)startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, defaultSeverityOpt, effectiveSeverityOpt, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 9234, 9475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 9139, 9487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 9139, 9487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticDescription WhereSyntax(Func<SyntaxNode, bool> syntaxPredicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 9843, 10183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 9948, 10172);

                return f_25003_9955_10171(_code, _isWarningAsError, _squiggledText, _arguments, _startPosition, syntaxPredicate, _argumentOrderDoesNotMatter, _errorCodeType, _defaultSeverityOpt, _effectiveSeverityOpt, _isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 9843, 10183);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_9955_10171(object
                code, bool
                isWarningAsError, string
                squiggledText, object[]
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, Microsoft.CodeAnalysis.DiagnosticSeverity?
                defaultSeverityOpt, Microsoft.CodeAnalysis.DiagnosticSeverity?
                effectiveSeverityOpt, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, defaultSeverityOpt, effectiveSeverityOpt, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 9955, 10171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 9843, 10183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 9843, 10183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object Code
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 10214, 10222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10217, 10222);
                    return _code; DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 10214, 10222);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 10214, 10222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 10214, 10222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 10257, 10282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10260, 10282);
                    return _startPosition != null; DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 10257, 10282);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 10257, 10282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 10257, 10282);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 10322, 10342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10325, 10342);
                    return _isWarningAsError; DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 10322, 10342);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 10322, 10342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 10322, 10342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSuppressed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 10378, 10394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10381, 10394);
                    return _isSuppressed; DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 10378, 10394);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 10378, 10394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 10378, 10394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DiagnosticSeverity? DefaultSeverity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 10448, 10470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10451, 10470);
                    return _defaultSeverityOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 10448, 10470);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 10448, 10470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 10448, 10470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DiagnosticSeverity? EffectiveSeverity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 10526, 10550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10529, 10550);
                    return _effectiveSeverityOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 10526, 10550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 10526, 10550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 10526, 10550);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 10563, 13732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10627, 10664);

                var
                d = obj as DiagnosticDescription
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10680, 10725) || true) && (d == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 10680, 10725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10712, 10725);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 10680, 10725);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10741, 10799) || true) && (!f_25003_10746_10767(_code, d._code))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 10741, 10799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10786, 10799);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 10741, 10799);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10815, 10891) || true) && (_isWarningAsError != d._isWarningAsError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 10815, 10891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10878, 10891);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 10815, 10891);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10907, 10975) || true) && (_isSuppressed != d._isSuppressed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 10907, 10975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10962, 10975);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 10907, 10975);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 10991, 11148) || true) && (!_ignoreArgumentsWhenComparing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 10991, 11148);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11059, 11133) || true) && (_squiggledText != d._squiggledText)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11059, 11133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11120, 11133);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11059, 11133);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 10991, 11148);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11164, 11464) || true) && (_startPosition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11164, 11464);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11224, 11449) || true) && (d._startPosition != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11224, 11449);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11294, 11430) || true) && (_startPosition.Value != d._startPosition.Value)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11294, 11430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11394, 11407);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11294, 11430);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11224, 11449);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11164, 11464);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11480, 11903) || true) && (_syntaxPredicate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11480, 11903);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11542, 11601) || true) && (d._location == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11542, 11601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11588, 11601);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11542, 11601);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11621, 11845) || true) && (!f_25003_11626_11727(this, f_25003_11643_11719(f_25003_11643_11675(f_25003_11643_11665(d._location)), _location.SourceSpan.Start, true).Parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11621, 11845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11769, 11791);

                        _showPredicate = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11813, 11826);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11621, 11845);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11865, 11888);

                    _showPredicate = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11480, 11903);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11917, 12344) || true) && (d._syntaxPredicate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11917, 12344);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 11981, 12038) || true) && (_location == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 11981, 12038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12025, 12038);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11981, 12038);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12058, 12284) || true) && (!f_25003_12063_12164(d, f_25003_12082_12156(f_25003_12082_12112(f_25003_12082_12102(_location)), _location.SourceSpan.Start, true).Parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 12058, 12284);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12206, 12230);

                        d._showPredicate = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12252, 12265);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 12058, 12284);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12304, 12329);

                    d._showPredicate = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 11917, 12344);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12436, 12535) || true) && (_ignoreArgumentsWhenComparing || (DynAbs.Tracing.TraceSender.Expression_False(25003, 12440, 12504) || d._ignoreArgumentsWhenComparing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 12436, 12535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12523, 12535);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 12436, 12535);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12651, 13498) || true) && (_arguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 12651, 13498);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12707, 12767) || true) && (d._arguments != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 12707, 12767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12754, 12767);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 12707, 12767);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 12651, 13498);
                }

                else // _arguments != null

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 12651, 13498);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12855, 12915) || true) && (d._arguments == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 12855, 12915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12902, 12915);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 12855, 12915);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 12994, 13030);

                    var
                    args1 = f_25003_13006_13029(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13048, 13086);

                    var
                    args2 = f_25003_13060_13085(d)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13104, 13483) || true) && (_argumentOrderDoesNotMatter || (DynAbs.Tracing.TraceSender.Expression_False(25003, 13108, 13168) || d._argumentOrderDoesNotMatter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 13104, 13483);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13210, 13311) || true) && (f_25003_13214_13227(args1) != f_25003_13231_13244(args2) || (DynAbs.Tracing.TraceSender.Expression_False(25003, 13214, 13271) || !f_25003_13249_13271(args1, args2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 13210, 13311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13298, 13311);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 13210, 13311);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 13104, 13483);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 13104, 13483);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13393, 13464) || true) && (!f_25003_13398_13424(args1, args2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 13393, 13464);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13451, 13464);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 13393, 13464);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 13104, 13483);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 12651, 13498);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13514, 13693) || true) && (_defaultSeverityOpt != d._defaultSeverityOpt || (DynAbs.Tracing.TraceSender.Expression_False(25003, 13518, 13631) || _effectiveSeverityOpt != d._effectiveSeverityOpt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 13514, 13693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13665, 13678);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 13514, 13693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13709, 13721);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 10563, 13732);

                bool
                f_25003_10746_10767(object
                this_param, object
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 10746, 10767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_25003_11643_11665(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 11643, 11665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25003_11643_11675(Microsoft.CodeAnalysis.SyntaxTree?
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 11643, 11675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_25003_11643_11719(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 11643, 11719);
                    return return_v;
                }


                bool
                f_25003_11626_11727(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                arg)
                {
                    var return_v = this_param._syntaxPredicate(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 11626, 11727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_25003_12082_12102(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 12082, 12102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25003_12082_12112(Microsoft.CodeAnalysis.SyntaxTree?
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 12082, 12112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_25003_12082_12156(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 12082, 12156);
                    return return_v;
                }


                bool
                f_25003_12063_12164(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                arg)
                {
                    var return_v = this_param._syntaxPredicate(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 12063, 12164);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25003_13006_13029(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param)
                {
                    var return_v = this_param.GetArgumentsAsStrings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13006, 13029);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25003_13060_13085(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param)
                {
                    var return_v = this_param.GetArgumentsAsStrings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13060, 13085);
                    return return_v;
                }


                int
                f_25003_13214_13227(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Count<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13214, 13227);
                    return return_v;
                }


                int
                f_25003_13231_13244(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Count<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13231, 13244);
                    return return_v;
                }


                bool
                f_25003_13249_13271(System.Collections.Generic.IEnumerable<string>
                source1, System.Collections.Generic.IEnumerable<string>
                source2)
                {
                    var return_v = source1.SetEquals<string>(source2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13249, 13271);
                    return return_v;
                }


                bool
                f_25003_13398_13424(System.Collections.Generic.IEnumerable<string>
                first, System.Collections.Generic.IEnumerable<string>
                second)
                {
                    var return_v = first.SequenceEqual<string>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13398, 13424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 10563, 13732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 10563, 13732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 13744, 14767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13802, 13815);

                int
                hashCode
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13829, 13860);

                hashCode = f_25003_13840_13859(_code);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13874, 13941);

                hashCode = f_25003_13885_13940(f_25003_13898_13929(_isWarningAsError), hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 13955, 14018);

                hashCode = f_25003_13966_14017(f_25003_13979_14006(_isSuppressed), hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14205, 14255);

                hashCode = f_25003_14216_14254(_squiggledText, hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14269, 14315);

                hashCode = f_25003_14280_14314(_arguments, hashCode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14329, 14444) || true) && (_startPosition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 14329, 14444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14374, 14444);

                    hashCode = f_25003_14385_14443(hashCode, _startPosition.Value.GetHashCode());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 14329, 14444);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14458, 14583) || true) && (_defaultSeverityOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 14458, 14583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14508, 14583);

                    hashCode = f_25003_14519_14582(hashCode, f_25003_14542_14581(f_25003_14542_14567(_defaultSeverityOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 14458, 14583);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14597, 14726) || true) && (_effectiveSeverityOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 14597, 14726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14649, 14726);

                    hashCode = f_25003_14660_14725(hashCode, f_25003_14683_14724(f_25003_14683_14710(_effectiveSeverityOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 14597, 14726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14740, 14756);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 13744, 14767);

                int
                f_25003_13840_13859(object
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13840, 13859);
                    return return_v;
                }


                int
                f_25003_13898_13929(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13898, 13929);
                    return return_v;
                }


                int
                f_25003_13885_13940(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13885, 13940);
                    return return_v;
                }


                int
                f_25003_13979_14006(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13979, 14006);
                    return return_v;
                }


                int
                f_25003_13966_14017(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 13966, 14017);
                    return return_v;
                }


                int
                f_25003_14216_14254(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14216, 14254);
                    return return_v;
                }


                int
                f_25003_14280_14314(object[]
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14280, 14314);
                    return return_v;
                }


                int
                f_25003_14385_14443(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14385, 14443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25003_14542_14567(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 14542, 14567);
                    return return_v;
                }


                int
                f_25003_14542_14581(Microsoft.CodeAnalysis.DiagnosticSeverity
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14542, 14581);
                    return return_v;
                }


                int
                f_25003_14519_14582(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14519, 14582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25003_14683_14710(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 14683, 14710);
                    return return_v;
                }


                int
                f_25003_14683_14724(Microsoft.CodeAnalysis.DiagnosticSeverity
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14683, 14724);
                    return return_v;
                }


                int
                f_25003_14660_14725(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14660, 14725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 13744, 14767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 13744, 14767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 14779, 17530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14837, 14866);

                var
                sb = f_25003_14846_14865()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14882, 14907);

                f_25003_14882_14906(
                            sb, "Diagnostic(");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14921, 15244) || true) && (_errorCodeType == typeof(string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 14921, 15244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 14991, 15034);

                    f_25003_14991_15033(f_25003_14991_15020(f_25003_14991_15006(sb, "\""), _code), "\"");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 14921, 15244);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 14921, 15244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15100, 15131);

                    f_25003_15100_15130(sb, f_25003_15110_15129(_errorCodeType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15149, 15164);

                    f_25003_15149_15163(sb, ".");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15182, 15229);

                    f_25003_15182_15228(sb, f_25003_15192_15227(_errorCodeType, _code));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 14921, 15244);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15260, 15767) || true) && (_squiggledText != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 15260, 15767);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15320, 15717) || true) && (f_25003_15324_15353(_squiggledText, "\n") || (DynAbs.Tracing.TraceSender.Expression_False(25003, 15324, 15386) || f_25003_15357_15386(_squiggledText, "\\")) || (DynAbs.Tracing.TraceSender.Expression_False(25003, 15324, 15419) || f_25003_15390_15419(_squiggledText, "\"")))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 15320, 15717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15461, 15480);

                        f_25003_15461_15479(sb, ", @\"");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15502, 15550);

                        f_25003_15502_15549(sb, f_25003_15512_15548(_squiggledText, "\"", "\"\""));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 15320, 15717);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 15320, 15717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15632, 15650);

                        f_25003_15632_15649(sb, ", \"");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15672, 15698);

                        f_25003_15672_15697(sb, _squiggledText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 15320, 15717);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15737, 15752);

                    f_25003_15737_15751(
                                    sb, '"');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 15260, 15767);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15783, 15883) || true) && (_isSuppressed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 15783, 15883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15834, 15868);

                    f_25003_15834_15867(sb, ", isSuppressed: true");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 15783, 15883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15899, 15914);

                f_25003_15899_15913(
                            sb, ")");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15930, 16520) || true) && (_arguments != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 15930, 16520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 15986, 16015);

                    f_25003_15986_16014(sb, ".WithArguments(");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16033, 16095);

                    var
                    argumentStrings = f_25003_16055_16094(f_25003_16055_16078(this))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16122, 16127);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16113, 16472) || true) && (f_25003_16129_16155(argumentStrings))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16157, 16160)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 16113, 16472))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 16113, 16472);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16202, 16218);

                            f_25003_16202_16217(sb, "\"");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16240, 16275);

                            f_25003_16240_16274(sb, f_25003_16250_16273(argumentStrings));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16297, 16313);

                            f_25003_16297_16312(sb, "\"");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16335, 16453) || true) && (i < f_25003_16343_16360(_arguments) - 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 16335, 16453);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16414, 16430);

                                f_25003_16414_16429(sb, ", ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 16335, 16453);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25003, 1, 360);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25003, 1, 360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16490, 16505);

                    f_25003_16490_16504(sb, ")");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 15930, 16520);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16536, 16829) || true) && (_startPosition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 16536, 16829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16596, 16624);

                    f_25003_16596_16623(sb, ".WithLocation(");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16642, 16683);

                    f_25003_16642_16682(sb, _startPosition.Value.Line + 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16701, 16717);

                    f_25003_16701_16716(sb, ", ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16735, 16781);

                    f_25003_16735_16780(sb, _startPosition.Value.Character + 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16799, 16814);

                    f_25003_16799_16813(sb, ")");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 16536, 16829);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16845, 16954) || true) && (_isWarningAsError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 16845, 16954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16900, 16939);

                    f_25003_16900_16938(sb, ".WithWarningAsError(true)");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 16845, 16954);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 16970, 17144) || true) && (_defaultSeverityOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 16970, 17144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17035, 17129);

                    f_25003_17035_17128(sb, $".WithDefaultSeverity(DiagnosticSeverity.{f_25003_17088_17124(f_25003_17088_17113(_defaultSeverityOpt))})");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 16970, 17144);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17160, 17340) || true) && (_effectiveSeverityOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 17160, 17340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17227, 17325);

                    f_25003_17227_17324(sb, $".WithEffectiveSeverity(DiagnosticSeverity.{f_25003_17282_17320(f_25003_17282_17309(_effectiveSeverityOpt))})");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 17160, 17340);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17356, 17482) || true) && (_syntaxPredicate != null && (DynAbs.Tracing.TraceSender.Expression_True(25003, 17360, 17402) && _showPredicate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 17356, 17482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17436, 17467);

                    f_25003_17436_17466(sb, ".WhereSyntax(...)");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 17356, 17482);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17498, 17519);

                return f_25003_17505_17518(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 14779, 17530);

                System.Text.StringBuilder
                f_25003_14846_14865()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14846, 14865);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_14882_14906(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14882, 14906);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_14991_15006(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14991, 15006);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_14991_15020(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14991, 15020);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_14991_15033(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 14991, 15033);
                    return return_v;
                }


                string
                f_25003_15110_15129(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 15110, 15129);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15100_15130(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15100, 15130);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15149_15163(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15149, 15163);
                    return return_v;
                }


                string?
                f_25003_15192_15227(System.Type
                enumType, object
                value)
                {
                    var return_v = Enum.GetName(enumType, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15192, 15227);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15182_15228(System.Text.StringBuilder
                this_param, string?
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15182, 15228);
                    return return_v;
                }


                bool
                f_25003_15324_15353(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15324, 15353);
                    return return_v;
                }


                bool
                f_25003_15357_15386(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15357, 15386);
                    return return_v;
                }


                bool
                f_25003_15390_15419(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15390, 15419);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15461_15479(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15461, 15479);
                    return return_v;
                }


                string
                f_25003_15512_15548(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15512, 15548);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15502_15549(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15502, 15549);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15632_15649(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15632, 15649);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15672_15697(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15672, 15697);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15737_15751(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15737, 15751);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15834_15867(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15834, 15867);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15899_15913(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15899, 15913);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_15986_16014(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 15986, 16014);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25003_16055_16078(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param)
                {
                    var return_v = this_param.GetArgumentsAsStrings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16055, 16078);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<string>
                f_25003_16055_16094(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16055, 16094);
                    return return_v;
                }


                bool
                f_25003_16129_16155(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16129, 16155);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16202_16217(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16202, 16217);
                    return return_v;
                }


                string
                f_25003_16250_16273(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 16250, 16273);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16240_16274(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16240, 16274);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16297_16312(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16297, 16312);
                    return return_v;
                }


                int
                f_25003_16343_16360(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 16343, 16360);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16414_16429(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16414, 16429);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16490_16504(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16490, 16504);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16596_16623(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16596, 16623);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16642_16682(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16642, 16682);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16701_16716(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16701, 16716);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16735_16780(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16735, 16780);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16799_16813(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16799, 16813);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_16900_16938(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 16900, 16938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25003_17088_17113(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 17088, 17113);
                    return return_v;
                }


                string
                f_25003_17088_17124(Microsoft.CodeAnalysis.DiagnosticSeverity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17088, 17124);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_17035_17128(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17035, 17128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25003_17282_17309(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 17282, 17309);
                    return return_v;
                }


                string
                f_25003_17282_17320(Microsoft.CodeAnalysis.DiagnosticSeverity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17282, 17320);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_17227_17324(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17227, 17324);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_17436_17466(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17436, 17466);
                    return return_v;
                }


                string
                f_25003_17505_17518(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17505, 17518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 14779, 17530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 14779, 17530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetAssertText(DiagnosticDescription[] expected, IEnumerable<Diagnostic> actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25003, 17542, 21316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17667, 17688);

                const int
                CSharp = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17702, 17728);

                const int
                VisualBasic = 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17742, 17827);

                var
                language = (DynAbs.Tracing.TraceSender.Conditional_F1(25003, 17757, 17803) || ((f_25003_17757_17769(actual) && (DynAbs.Tracing.TraceSender.Expression_True(25003, 17757, 17803) && f_25003_17773_17787(actual) is CSDiagnostic) && DynAbs.Tracing.TraceSender.Conditional_F2(25003, 17806, 17812)) || DynAbs.Tracing.TraceSender.Conditional_F3(25003, 17815, 17826))) ? CSharp : VisualBasic
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17841, 17904);

                var
                includeDiagnosticMessagesAsComments = (language == CSharp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17918, 17965);

                int
                indentDepth = (DynAbs.Tracing.TraceSender.Conditional_F1(25003, 17936, 17956) || (((language == CSharp) && DynAbs.Tracing.TraceSender.Conditional_F2(25003, 17959, 17960)) || DynAbs.Tracing.TraceSender.Conditional_F3(25003, 17963, 17964))) ? 4 : 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 17979, 18071);

                var
                includeDefaultSeverity = f_25003_18008_18022(expected) && (DynAbs.Tracing.TraceSender.Expression_True(25003, 18008, 18070) && f_25003_18026_18070(expected, d => d.DefaultSeverity != null))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18085, 18181);

                var
                includeEffectiveSeverity = f_25003_18116_18130(expected) && (DynAbs.Tracing.TraceSender.Expression_True(25003, 18116, 18180) && f_25003_18134_18180(expected, d => d.EffectiveSeverity != null))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18197, 18490) || true) && (f_25003_18201_18226(expected))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 18197, 18490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18453, 18475);

                    actual = f_25003_18462_18474(actual);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 18197, 18490);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18506, 18543);

                var
                assertText = f_25003_18523_18542()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18557, 18581);

                f_25003_18557_18580(assertText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18658, 18664);

                int
                i
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18678, 18713);

                f_25003_18678_18712(assertText, "Expected:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18727, 18781);

                var
                expectedText = f_25003_18746_18780()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18795, 18929);
                    foreach (var d in f_25003_18813_18821_I(expected))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 18795, 18929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18855, 18914);

                        f_25003_18855_18913(expectedText, f_25003_18872_18912(d, indentDepth));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 18795, 18929);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25003, 1, 135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25003, 1, 135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 18943, 18992);

                f_25003_18943_18991(assertText, expectedText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19106, 19139);

                f_25003_19106_19138(
                            // write out the actual results as method calls (copy/paste this to update baseline)
                            assertText, "Actual:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19153, 19205);

                var
                actualText = f_25003_19170_19204()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19219, 19250);

                var
                e = f_25003_19227_19249(actual)
                ;
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19269, 19274)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19264, 20938) || true) && (f_25003_19276_19288(e))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19290, 19293)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 19264, 20938))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 19264, 20938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19327, 19352);

                        Diagnostic
                        d = f_25003_19342_19351(e)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19370, 19400);

                        string
                        message = f_25003_19387_19399(d)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19418, 19628) || true) && (f_25003_19422_19460(f_25003_19422_19452(message, @"{\d+}")))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 19418, 19628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19502, 19609);

                            f_25003_19502_19608(false, "Diagnostic messages should never contain unsubstituted placeholders.\n    " + message);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 19418, 19628);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19648, 19745) || true) && (i > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 19648, 19745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19699, 19726);

                            f_25003_19699_19725(assertText, ",");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 19648, 19745);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19765, 20366) || true) && (includeDiagnosticMessagesAsComments)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 19765, 20366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19846, 19878);

                            f_25003_19846_19877(assertText, indentDepth);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19900, 19925);

                            f_25003_19900_19924(assertText, "// ");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 19947, 19983);

                            f_25003_19947_19982(assertText, f_25003_19969_19981(d));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20005, 20024);

                            var
                            l = f_25003_20013_20023(d)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20046, 20347) || true) && (f_25003_20050_20062(l))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 20046, 20347);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20112, 20144);

                                f_25003_20112_20143(assertText, indentDepth);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20170, 20195);

                                f_25003_20170_20194(assertText, "// ");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20221, 20324);

                                f_25003_20221_20323(assertText, f_25003_20243_20311(f_25003_20243_20271(f_25003_20243_20265(f_25003_20243_20255(l))), l.SourceSpan.Start).ToString());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 20046, 20347);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 19765, 20366);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20386, 20505);

                        var
                        description = f_25003_20404_20504(d, errorCodeOnly: false, includeDefaultSeverity, includeEffectiveSeverity)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20523, 20557);

                        var
                        diffDescription = description
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20575, 20622);

                        var
                        idx = f_25003_20585_20621(expected, description)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20640, 20746) || true) && (idx != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 20640, 20746);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20695, 20727);

                            diffDescription = expected[idx];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 20640, 20746);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20764, 20834);

                        f_25003_20764_20833(assertText, f_25003_20782_20832(description, indentDepth));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20852, 20923);

                        f_25003_20852_20922(actualText, f_25003_20867_20921(diffDescription, indentDepth));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25003, 1, 1675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25003, 1, 1675);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20952, 21034) || true) && (i > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 20952, 21034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 20995, 21019);

                    f_25003_20995_21018(assertText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 20952, 21034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21050, 21081);

                f_25003_21050_21080(
                            assertText, "Diff:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21095, 21192);

                f_25003_21095_21191(assertText, f_25003_21113_21190(expectedText, actualText, separator: f_25003_21170_21189()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21208, 21226);

                f_25003_21208_21225(
                            actualText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21240, 21260);

                f_25003_21240_21259(expectedText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21276, 21305);

                return f_25003_21283_21304(assertText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25003, 17542, 21316);

                bool
                f_25003_17757_17769(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17757, 17769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25003_17773_17787(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 17773, 17787);
                    return return_v;
                }


                bool
                f_25003_18008_18022(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18008, 18022);
                    return return_v;
                }


                bool
                f_25003_18026_18070(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source, System.Func<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18026, 18070);
                    return return_v;
                }


                bool
                f_25003_18116_18130(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18116, 18130);
                    return return_v;
                }


                bool
                f_25003_18134_18180(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source, System.Func<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18134, 18180);
                    return return_v;
                }


                bool
                f_25003_18201_18226(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                diagnostics)
                {
                    var return_v = IsSortedOrEmpty(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18201, 18226);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_25003_18462_18474(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = Sort(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18462, 18474);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_18523_18542()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18523, 18542);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_18557_18580(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18557, 18580);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_18678_18712(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18678, 18712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_25003_18746_18780()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18746, 18780);
                    return return_v;
                }


                string
                f_25003_18872_18912(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                d, int
                indentDepth)
                {
                    var return_v = GetDiagnosticDescription(d, indentDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18872, 18912);
                    return return_v;
                }


                int
                f_25003_18855_18913(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18855, 18913);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                f_25003_18813_18821_I(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18813, 18821);
                    return return_v;
                }


                int
                f_25003_18943_18991(System.Text.StringBuilder
                sb, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                lines)
                {
                    GetCommaSeparatedLines(sb, lines);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 18943, 18991);
                    return 0;
                }


                System.Text.StringBuilder
                f_25003_19106_19138(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19106, 19138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_25003_19170_19204()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19170, 19204);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.Diagnostic>
                f_25003_19227_19249(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19227, 19249);
                    return return_v;
                }


                bool
                f_25003_19276_19288(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.Diagnostic>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19276, 19288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25003_19342_19351(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.Diagnostic>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 19342, 19351);
                    return return_v;
                }


                string
                f_25003_19387_19399(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19387, 19399);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_25003_19422_19452(string
                input, string
                pattern)
                {
                    var return_v = Regex.Match(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19422, 19452);
                    return return_v;
                }


                bool
                f_25003_19422_19460(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 19422, 19460);
                    return return_v;
                }


                int
                f_25003_19502_19608(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19502, 19608);
                    return 0;
                }


                System.Text.StringBuilder
                f_25003_19699_19725(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19699, 19725);
                    return return_v;
                }


                int
                f_25003_19846_19877(System.Text.StringBuilder
                sb, int
                count)
                {
                    Indent(sb, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19846, 19877);
                    return 0;
                }


                System.Text.StringBuilder
                f_25003_19900_19924(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19900, 19924);
                    return return_v;
                }


                string
                f_25003_19969_19981(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19969, 19981);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_19947_19982(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 19947, 19982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_25003_20013_20023(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 20013, 20023);
                    return return_v;
                }


                bool
                f_25003_20050_20062(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 20050, 20062);
                    return return_v;
                }


                int
                f_25003_20112_20143(System.Text.StringBuilder
                sb, int
                count)
                {
                    Indent(sb, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20112, 20143);
                    return 0;
                }


                System.Text.StringBuilder
                f_25003_20170_20194(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20170, 20194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_25003_20243_20255(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 20243, 20255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_25003_20243_20265(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20243, 20265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_25003_20243_20271(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 20243, 20271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLine
                f_25003_20243_20311(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLineFromPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20243, 20311);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_20221_20323(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20221, 20323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25003_20404_20504(Microsoft.CodeAnalysis.Diagnostic
                d, bool
                errorCodeOnly, bool
                includeDefaultSeverity, bool
                includeEffectiveSeverity)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(d, errorCodeOnly: errorCodeOnly, includeDefaultSeverity, includeEffectiveSeverity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20404, 20504);
                    return return_v;
                }


                int
                f_25003_20585_20621(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                array, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                value)
                {
                    var return_v = Array.IndexOf(array, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20585, 20621);
                    return return_v;
                }


                string
                f_25003_20782_20832(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                d, int
                indentDepth)
                {
                    var return_v = GetDiagnosticDescription(d, indentDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20782, 20832);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_20764_20833(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20764, 20833);
                    return return_v;
                }


                string
                f_25003_20867_20921(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                d, int
                indentDepth)
                {
                    var return_v = GetDiagnosticDescription(d, indentDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20867, 20921);
                    return return_v;
                }


                int
                f_25003_20852_20922(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20852, 20922);
                    return 0;
                }


                System.Text.StringBuilder
                f_25003_20995_21018(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 20995, 21018);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_21050_21080(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21050, 21080);
                    return return_v;
                }


                string
                f_25003_21170_21189()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 21170, 21189);
                    return return_v;
                }


                string
                f_25003_21113_21190(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                expected, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                actual, string
                separator)
                {
                    var return_v = DiffUtil.DiffReport((System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual, separator: separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21113, 21190);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_21095_21191(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21095, 21191);
                    return return_v;
                }


                int
                f_25003_21208_21225(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21208, 21225);
                    return 0;
                }


                int
                f_25003_21240_21259(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21240, 21259);
                    return 0;
                }


                string
                f_25003_21283_21304(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21283, 21304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 17542, 21316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 17542, 21316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<Diagnostic> Sort(IEnumerable<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25003, 21328, 21557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21433, 21546);

                return f_25003_21440_21545(diagnostics, d => d.Location.GetMappedLineSpan().StartLinePosition, LinePositionComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25003, 21328, 21557);

                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_25003_21440_21545(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Text.LinePosition?>
                keySelector, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription.LinePositionComparer
                comparer)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Text.LinePosition?>(keySelector, (System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.Text.LinePosition?>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21440, 21545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 21328, 21557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 21328, 21557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsSortedOrEmpty(DiagnosticDescription[] diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25003, 21569, 22224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21666, 21711);

                var
                comparer = LinePositionComparer.Instance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21725, 21759);

                DiagnosticDescription
                last = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21773, 22187);
                    foreach (var diagnostic in f_25003_21800_21811_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 21773, 22187);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21845, 21956) || true) && (diagnostic._startPosition == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 21845, 21956);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21924, 21937);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 21845, 21956);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 21974, 22136) || true) && (last != null && (DynAbs.Tracing.TraceSender.Expression_True(25003, 21978, 22062) && f_25003_21994_22058(comparer, last._startPosition, diagnostic._startPosition) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 21974, 22136);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22104, 22117);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 21974, 22136);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22154, 22172);

                        last = diagnostic;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 21773, 22187);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25003, 1, 415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25003, 1, 415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22201, 22213);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25003, 21569, 22224);

                int
                f_25003_21994_22058(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription.LinePositionComparer
                this_param, Microsoft.CodeAnalysis.Text.LinePosition?
                x, Microsoft.CodeAnalysis.Text.LinePosition?
                y)
                {
                    var return_v = this_param.Compare(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21994, 22058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                f_25003_21800_21811_I(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 21800, 21811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 21569, 22224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 21569, 22224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetDiagnosticDescription(DiagnosticDescription d, int indentDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25003, 22236, 22415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22349, 22404);

                return f_25003_22356_22388(' ', 4 * indentDepth) + f_25003_22391_22403(d);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25003, 22236, 22415);

                string
                f_25003_22356_22388(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 22356, 22388);
                    return return_v;
                }


                string
                f_25003_22391_22403(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 22391, 22403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 22236, 22415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 22236, 22415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void Indent(StringBuilder sb, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25003, 22427, 22544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22507, 22533);

                f_25003_22507_22532(sb, ' ', 4 * count);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25003, 22427, 22544);

                System.Text.StringBuilder
                f_25003_22507_22532(System.Text.StringBuilder
                this_param, char
                value, int
                repeatCount)
                {
                    var return_v = this_param.Append(value, repeatCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 22507, 22532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 22427, 22544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 22427, 22544);
            }
        }

        private static void GetCommaSeparatedLines(StringBuilder sb, ArrayBuilder<string> lines)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25003, 22556, 22950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22669, 22689);

                int
                n = f_25003_22677_22688(lines)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22712, 22717);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22703, 22939) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22726, 22729)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 22703, 22939))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 22703, 22939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22763, 22783);

                        f_25003_22763_22782(sb, f_25003_22773_22781(lines, i));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22801, 22890) || true) && (i < n - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 22801, 22890);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22856, 22871);

                            f_25003_22856_22870(sb, ',');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 22801, 22890);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 22908, 22924);

                        f_25003_22908_22923(sb);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25003, 1, 237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25003, 1, 237);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25003, 22556, 22950);

                int
                f_25003_22677_22688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 22677, 22688);
                    return return_v;
                }


                string
                f_25003_22773_22781(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 22773, 22781);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_22763_22782(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 22763, 22782);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_22856_22870(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 22856, 22870);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25003_22908_22923(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 22908, 22923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 22556, 22950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 22556, 22950);
            }
        }
        private class LinePositionComparer : IComparer<LinePosition?>
        {
            internal static LinePositionComparer Instance;

            public int Compare(LinePosition? x, LinePosition? y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25003, 23139, 23801);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23224, 23425) || true) && (x == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 23224, 23425);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23279, 23374) || true) && (y == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 23279, 23374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23342, 23351);

                            return 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 23279, 23374);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23396, 23406);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 23224, 23425);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23445, 23528) || true) && (y == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 23445, 23528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23500, 23509);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 23445, 23528);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23548, 23600);

                    int
                    lineDiff = f_25003_23563_23599(x.Value.Line, y.Value.Line)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23618, 23712) || true) && (lineDiff != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25003, 23618, 23712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23677, 23693);

                        return lineDiff;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25003, 23618, 23712);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23732, 23786);

                    return f_25003_23739_23785(x.Value.Character, y.Value.Character);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25003, 23139, 23801);

                    int
                    f_25003_23563_23599(int
                    this_param, int
                    value)
                    {
                        var return_v = this_param.CompareTo(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 23563, 23599);
                        return return_v;
                    }


                    int
                    f_25003_23739_23785(int
                    this_param, int
                    value)
                    {
                        var return_v = this_param.CompareTo(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 23739, 23785);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25003, 23139, 23801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 23139, 23801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LinePositionComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25003, 22962, 23812);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25003, 22962, 23812);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 22962, 23812);
            }


            static LinePositionComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25003, 22962, 23812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 23085, 23122);
                Instance = f_25003_23096_23122(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25003, 22962, 23812);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 22962, 23812);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25003, 22962, 23812);

            static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription.LinePositionComparer
            f_25003_23096_23122()
            {
                var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription.LinePositionComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 23096, 23122);
                return return_v;
            }

        }

        static DiagnosticDescription()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25003, 635, 23819);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 740, 750);
            None = new DiagnosticDescription[] { }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25003, 808, 818);
            Any = null; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25003, 635, 23819);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25003, 635, 23819);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25003, 635, 23819);

        System.Type
        f_25003_3667_3681(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 3667, 3681);
            return return_v;
        }


        System.Type
        f_25003_4709_4723(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 4709, 4723);
            return return_v;
        }


        int
        f_25003_5075_5081(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Code;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5075, 5081);
            return return_v;
        }


        bool
        f_25003_5116_5134(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.IsWarningAsError;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5116, 5134);
            return return_v;
        }


        bool
        f_25003_5165_5179(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.IsSuppressed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5165, 5179);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_25003_5206_5216(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5206, 5216);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticSeverity
        f_25003_5278_5295(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.DefaultSeverity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5278, 5295);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticSeverity
        f_25003_5389_5399(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Severity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5389, 5399);
            return return_v;
        }


        int
        f_25003_5494_5500(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Code;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5494, 5500);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25003_5509_5521(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Descriptor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5509, 5521);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<string>
        f_25003_5509_5532(Microsoft.CodeAnalysis.DiagnosticDescriptor
        this_param)
        {
            var return_v = this_param.CustomTags;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5509, 5532);
            return return_v;
        }


        bool
        f_25003_5509_5581(System.Collections.Generic.IEnumerable<string>
        sequence, string
        s)
        {
            var return_v = sequence.Contains(s);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 5509, 5581);
            return return_v;
        }


        string
        f_25003_5623_5627(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5623, 5627);
            return return_v;
        }


        int
        f_25003_5861_5867(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Code;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 5861, 5867);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticInfo
        f_25003_6018_6028(Microsoft.CodeAnalysis.DiagnosticWithInfo
        this_param)
        {
            var return_v = this_param.Info;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6018, 6028);
            return return_v;
        }


        Microsoft.CodeAnalysis.CommonMessageProvider
        f_25003_6018_6044(Microsoft.CodeAnalysis.DiagnosticInfo
        this_param)
        {
            var return_v = this_param.MessageProvider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6018, 6044);
            return return_v;
        }


        System.Type
        f_25003_6018_6058(Microsoft.CodeAnalysis.CommonMessageProvider
        this_param)
        {
            var return_v = this_param.ErrorCodeType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6018, 6058);
            return return_v;
        }


        int
        f_25003_6089_6095(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Code;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6089, 6095);
            return return_v;
        }


        bool
        f_25003_6280_6300(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.IsInSource;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6280, 6300);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_25003_6499_6519(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.SourceTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6499, 6519);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.SourceText
        f_25003_6499_6529(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetText();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 6499, 6529);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.TextSpan
        f_25003_6539_6559(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.SourceSpan;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6539, 6559);
            return return_v;
        }


        string
        f_25003_6499_6560(Microsoft.CodeAnalysis.Text.SourceText
        this_param, Microsoft.CodeAnalysis.Text.TextSpan
        span)
        {
            var return_v = this_param.ToString(span);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 6499, 6560);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticInfo
        f_25003_6672_6682(Microsoft.CodeAnalysis.DiagnosticWithInfo
        this_param)
        {
            var return_v = this_param.Info;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6672, 6682);
            return return_v;
        }


        object[]
        f_25003_6672_6692(Microsoft.CodeAnalysis.DiagnosticInfo
        this_param)
        {
            var return_v = this_param.Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6672, 6692);
            return return_v;
        }


        System.Collections.Generic.IReadOnlyList<object?>
        f_25003_6786_6797(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6786, 6797);
            return return_v;
        }


        int
        f_25003_6840_6850(System.Collections.Generic.IReadOnlyList<object?>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 6840, 6850);
            return return_v;
        }


        System.Collections.Generic.IReadOnlyList<object?>
        f_25003_7034_7045(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 7034, 7045);
            return return_v;
        }


        object?[]
        f_25003_7034_7055(System.Collections.Generic.IReadOnlyList<object?>
        source)
        {
            var return_v = source.ToArray<object?>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 7034, 7055);
            return return_v;
        }


        int
        f_25003_7144_7161(object[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25003, 7144, 7161);
            return return_v;
        }


        Microsoft.CodeAnalysis.FileLinePositionSpan
        f_25003_7293_7322(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.GetMappedLineSpan();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25003, 7293, 7322);
            return return_v;
        }

    }
}
