// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public class RuleSetInclude
    {
        private readonly string _includePath;

        public string IncludePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(538, 633, 661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 639, 659);

                    return _includePath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(538, 633, 661);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(538, 583, 672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 583, 672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly ReportDiagnostic _action;

        public ReportDiagnostic Action
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(538, 907, 930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 913, 928);

                    return _action;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(538, 907, 930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(538, 852, 941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 852, 941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RuleSetInclude(string includePath, ReportDiagnostic action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(538, 1086, 1246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 469, 481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 718, 725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1177, 1204);

                _includePath = includePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1218, 1235);

                _action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(538, 1086, 1246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(538, 1086, 1246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 1086, 1246);
            }
        }

        public RuleSet? LoadRuleSet(RuleSet parent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(538, 1449, 2441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1558, 1582);

                RuleSet?
                ruleSet = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1598, 1626);

                string?
                path = _includePath
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1676, 1706);

                    path = f_538_1683_1705(this, parent);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1724, 1813) || true) && (path == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 1724, 1813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1782, 1794);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(538, 1724, 1813);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 1833, 1879);

                    ruleSet = f_538_1843_1878(path);
                }
                catch (FileNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(538, 1908, 2207);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(538, 1908, 2207);
                    // The compiler uses the same rule set files as FxCop, but doesn't have all of
                    // the same logic for resolving included files. For the moment, just ignore any
                    // includes we can't resolve.
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(538, 2221, 2399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 2273, 2384);

                    throw f_538_2279_2383(f_538_2307_2382(f_538_2321_2364(), path, f_538_2372_2381(e)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(538, 2221, 2399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 2415, 2430);

                return ruleSet;
                DynAbs.Tracing.TraceSender.TraceExitMethod(538, 1449, 2441);

                string?
                f_538_1683_1705(Microsoft.CodeAnalysis.RuleSetInclude
                this_param, Microsoft.CodeAnalysis.RuleSet
                parent)
                {
                    var return_v = this_param.GetIncludePath(parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 1683, 1705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_538_1843_1878(string
                filePath)
                {
                    var return_v = RuleSetProcessor.LoadFromFile(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 1843, 1878);
                    return return_v;
                }


                string
                f_538_2321_2364()
                {
                    var return_v = CodeAnalysisResources.InvalidRuleSetInclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(538, 2321, 2364);
                    return return_v;
                }


                string
                f_538_2372_2381(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(538, 2372, 2381);
                    return return_v;
                }


                string
                f_538_2307_2382(string
                format, string?
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object?)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 2307, 2382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.InvalidRuleSetException
                f_538_2279_2383(string
                message)
                {
                    var return_v = new Microsoft.CodeAnalysis.InvalidRuleSetException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 2279, 2383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(538, 1449, 2441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 1449, 2441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string? GetIncludePath(RuleSet parent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(538, 2699, 4847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 2770, 2847);

                var
                resolvedIncludePath = f_538_2796_2846(_includePath, f_538_2829_2845_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 538, 2829, 2845)?.FilePath))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 2861, 2953) || true) && (resolvedIncludePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 2861, 2953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 2926, 2938);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(538, 2861, 2953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 3016, 3061);

                return f_538_3023_3060(resolvedIncludePath);

                static string? resolveIncludePath(string includePath, string? parentRulesetPath)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(538, 3077, 3818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 3190, 3271);

                        var
                        resolvedIncludePath = f_538_3216_3270(includePath, parentRulesetPath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 3289, 3756) || true) && (resolvedIncludePath == null && (DynAbs.Tracing.TraceSender.Expression_True(538, 3293, 3356) && f_538_3324_3356()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 3289, 3756);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 3569, 3638);

                            includePath = f_538_3583_3637(includePath, '\\', Path.DirectorySeparatorChar);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 3660, 3737);

                            resolvedIncludePath = f_538_3682_3736(includePath, parentRulesetPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(538, 3289, 3756);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 3776, 3803);

                        return resolvedIncludePath;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(538, 3077, 3818);

                        string?
                        f_538_3216_3270(string
                        includePath, string?
                        parentRulesetPath)
                        {
                            var return_v = resolveIncludePathCore(includePath, parentRulesetPath);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 3216, 3270);
                            return return_v;
                        }


                        bool
                        f_538_3324_3356()
                        {
                            var return_v = PathUtilities.IsUnixLikePlatform;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(538, 3324, 3356);
                            return return_v;
                        }


                        string
                        f_538_3583_3637(string
                        this_param, char
                        oldChar, char
                        newChar)
                        {
                            var return_v = this_param.Replace(oldChar, newChar);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 3583, 3637);
                            return return_v;
                        }


                        string?
                        f_538_3682_3736(string
                        includePath, string?
                        parentRulesetPath)
                        {
                            var return_v = resolveIncludePathCore(includePath, parentRulesetPath);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 3682, 3736);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(538, 3077, 3818);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 3077, 3818);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static string? resolveIncludePathCore(string includePath, string? parentRulesetPath)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(538, 3834, 4836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 3951, 4017);

                        includePath = f_538_3965_4016(includePath);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4097, 4789) || true) && (f_538_4101_4131(includePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 4097, 4789);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4173, 4293) || true) && (f_538_4177_4201(includePath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 4173, 4293);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4251, 4270);

                                return includePath;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(538, 4173, 4293);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(538, 4097, 4789);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 4097, 4789);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4335, 4789) || true) && (!f_538_4340_4379(parentRulesetPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 4335, 4789);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4517, 4628);

                                includePath = f_538_4531_4627(f_538_4567_4607(parentRulesetPath) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(538, 4567, 4613) ?? ""), includePath);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4650, 4770) || true) && (f_538_4654_4678(includePath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(538, 4650, 4770);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4728, 4747);

                                    return includePath;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(538, 4650, 4770);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(538, 4335, 4789);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(538, 4097, 4789);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(538, 4809, 4821);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(538, 3834, 4836);

                        string
                        f_538_3965_4016(string
                        name)
                        {
                            var return_v = Environment.ExpandEnvironmentVariables(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 3965, 4016);
                            return return_v;
                        }


                        bool
                        f_538_4101_4131(string
                        path)
                        {
                            var return_v = Path.IsPathRooted(path);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 4101, 4131);
                            return return_v;
                        }


                        bool
                        f_538_4177_4201(string
                        path)
                        {
                            var return_v = File.Exists(path);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 4177, 4201);
                            return return_v;
                        }


                        bool
                        f_538_4340_4379(string?
                        value)
                        {
                            var return_v = string.IsNullOrEmpty(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 4340, 4379);
                            return return_v;
                        }


                        string?
                        f_538_4567_4607(string
                        path)
                        {
                            var return_v = Path.GetDirectoryName(path);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 4567, 4607);
                            return return_v;
                        }


                        string
                        f_538_4531_4627(string
                        root, string
                        relativePath)
                        {
                            var return_v = PathUtilities.CombinePathsUnchecked(root, relativePath);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 4531, 4627);
                            return return_v;
                        }


                        bool
                        f_538_4654_4678(string
                        path)
                        {
                            var return_v = File.Exists(path);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 4654, 4678);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(538, 3834, 4836);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 3834, 4836);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(538, 2699, 4847);

                string?
                f_538_2829_2845_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(538, 2829, 2845);
                    return return_v;
                }


                string?
                f_538_2796_2846(string
                includePath, string?
                parentRulesetPath)
                {
                    var return_v = resolveIncludePath(includePath, parentRulesetPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 2796, 2846);
                    return return_v;
                }


                string
                f_538_3023_3060(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(538, 3023, 3060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(538, 2699, 4847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 2699, 4847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RuleSetInclude()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(538, 401, 4854);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(538, 401, 4854);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(538, 401, 4854);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(538, 401, 4854);
    }
}
