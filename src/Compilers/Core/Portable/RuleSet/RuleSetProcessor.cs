// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal class RuleSetProcessor
    {
        private const string
        RuleSetNodeName = "RuleSet"
        ;

        private const string
        RuleSetNameAttributeName = "Name"
        ;

        private const string
        RuleSetDescriptionAttributeName = "Description"
        ;

        private const string
        RuleSetToolsVersionAttributeName = "ToolsVersion"
        ;

        private const string
        RulesNodeName = "Rules"
        ;

        private const string
        RulesAnalyzerIdAttributeName = "AnalyzerId"
        ;

        private const string
        RulesNamespaceAttributeName = "RuleNamespace"
        ;

        private const string
        RuleNodeName = "Rule"
        ;

        private const string
        RuleIdAttributeName = "Id"
        ;

        private const string
        IncludeNodeName = "Include"
        ;

        private const string
        IncludePathAttributeName = "Path"
        ;

        private const string
        IncludeAllNodeName = "IncludeAll"
        ;

        private const string
        RuleActionAttributeName = "Action"
        ;

        private const string
        RuleActionNoneValue = "None"
        ;

        private const string
        RuleActionHiddenValue = "Hidden"
        ;

        private const string
        RuleActionInfoValue = "Info"
        ;

        private const string
        RuleActionWarningValue = "Warning"
        ;

        private const string
        RuleActionErrorValue = "Error"
        ;

        private const string
        RuleActionDefaultValue = "Default"
        ;

        public static RuleSet LoadFromFile(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 2400, 3623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2541, 2598);

                filePath = f_539_2552_2597(filePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2612, 2671);

                XmlReaderSettings
                settings = f_539_2641_2670()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2687, 2721);

                XDocument?
                ruleSetDocument = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2735, 2764);

                XElement?
                ruleSetNode = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2780, 3554);
                using (Stream
                stream = f_539_2803_2835(filePath)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2850, 3554);
                    using (XmlReader
                    xmlReader = f_539_2879_2913(stream, settings)
                    )
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2991, 3035);

                            ruleSetDocument = f_539_3009_3034(xmlReader);
                        }
                        catch (Exception e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(539, 3072, 3196);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 3132, 3177);

                            throw f_539_3138_3176(f_539_3166_3175(e));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(539, 3072, 3196);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 3269, 3346);

                        List<XElement>
                        nodeList = f_539_3295_3345(f_539_3295_3336(ruleSetDocument, RuleSetNodeName))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 3364, 3427);

                        f_539_3364_3426(f_539_3377_3391(nodeList) == 1, "Multiple top-level nodes!");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 3445, 3495);

                        f_539_3445_3494(f_539_3458_3474(f_539_3458_3469(nodeList, 0)) == RuleSetNodeName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 3513, 3539);

                        ruleSetNode = f_539_3527_3538(nodeList, 0);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(539, 2850, 3554);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(539, 2780, 3554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 3570, 3612);

                return f_539_3577_3611(ruleSetNode, filePath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 2400, 3623);

                string
                f_539_2552_2597(string
                path)
                {
                    var return_v = FileUtilities.NormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 2552, 2597);
                    return return_v;
                }


                System.Xml.XmlReaderSettings
                f_539_2641_2670()
                {
                    var return_v = GetDefaultXmlReaderSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 2641, 2670);
                    return return_v;
                }


                System.IO.Stream
                f_539_2803_2835(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 2803, 2835);
                    return return_v;
                }


                System.Xml.XmlReader
                f_539_2879_2913(System.IO.Stream
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create(input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 2879, 2913);
                    return return_v;
                }


                System.Xml.Linq.XDocument
                f_539_3009_3034(System.Xml.XmlReader
                reader)
                {
                    var return_v = XDocument.Load(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 3009, 3034);
                    return return_v;
                }


                string
                f_539_3166_3175(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 3166, 3175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.InvalidRuleSetException
                f_539_3138_3176(string
                message)
                {
                    var return_v = new Microsoft.CodeAnalysis.InvalidRuleSetException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 3138, 3176);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_539_3295_3336(System.Xml.Linq.XDocument
                this_param, string
                name)
                {
                    var return_v = this_param.Elements((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 3295, 3336);
                    return return_v;
                }


                System.Collections.Generic.List<System.Xml.Linq.XElement>
                f_539_3295_3345(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                source)
                {
                    var return_v = source.ToList<System.Xml.Linq.XElement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 3295, 3345);
                    return return_v;
                }


                int
                f_539_3377_3391(System.Collections.Generic.List<System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 3377, 3391);
                    return return_v;
                }


                int
                f_539_3364_3426(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 3364, 3426);
                    return 0;
                }


                System.Xml.Linq.XElement
                f_539_3458_3469(System.Collections.Generic.List<System.Xml.Linq.XElement>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 3458, 3469);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_539_3458_3474(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 3458, 3474);
                    return return_v;
                }


                int
                f_539_3445_3494(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 3445, 3494);
                    return 0;
                }


                System.Xml.Linq.XElement
                f_539_3527_3538(System.Collections.Generic.List<System.Xml.Linq.XElement>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 3527, 3538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_539_3577_3611(System.Xml.Linq.XElement
                ruleSetNode, string
                filePath)
                {
                    var return_v = ReadRuleSet(ruleSetNode, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 3577, 3611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 2400, 3623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 2400, 3623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RuleSet ReadRuleSet(XElement ruleSetNode, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 3998, 6071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4096, 4180);

                var
                specificOptions = f_539_4118_4179()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4194, 4239);

                var
                generalOption = ReportDiagnostic.Default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4253, 4315);

                var
                includes = f_539_4268_4314()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4331, 4396);

                f_539_4331_4395(ruleSetNode, RuleSetToolsVersionAttributeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4410, 4467);

                f_539_4410_4466(ruleSetNode, RuleSetNameAttributeName);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4556, 5945);
                    foreach (XElement childNode in f_539_4587_4609_I(f_539_4587_4609(ruleSetNode)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 4556, 5945);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4643, 5930) || true) && (f_539_4647_4661(childNode) == RulesNodeName)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 4643, 5930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4720, 4753);

                            var
                            rules = f_539_4732_4752(childNode)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4775, 5580);
                                foreach (var rule in f_539_4796_4801_I(rules))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 4775, 5580);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4851, 4873);

                                    var
                                    ruleId = rule.Key
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4899, 4923);

                                    var
                                    action = rule.Value
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 4951, 4983);

                                    ReportDiagnostic
                                    existingAction
                                    = default(ReportDiagnostic);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5009, 5557) || true) && (f_539_5013_5068(specificOptions, ruleId, out existingAction))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 5009, 5557);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5126, 5380) || true) && (existingAction != action)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 5126, 5380);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5220, 5349);

                                            throw f_539_5226_5348(f_539_5254_5347(f_539_5268_5314(), ruleId, existingAction, action));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(539, 5126, 5380);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(539, 5009, 5557);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 5009, 5557);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5494, 5530);

                                        f_539_5494_5529(specificOptions, ruleId, action);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(539, 5009, 5557);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 4775, 5580);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(539, 1, 806);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(539, 1, 806);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(539, 4643, 5930);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 4643, 5930);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5622, 5930) || true) && (f_539_5626_5640(childNode) == IncludeNodeName)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 5622, 5930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5701, 5745);

                                f_539_5701_5744(includes, f_539_5714_5743(childNode));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(539, 5622, 5930);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 5622, 5930);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5787, 5930) || true) && (f_539_5791_5805(childNode) == IncludeAllNodeName)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 5787, 5930);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5869, 5911);

                                    generalOption = f_539_5885_5910(childNode);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 5787, 5930);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(539, 5622, 5930);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(539, 4643, 5930);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(539, 4556, 5945);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(539, 1, 1390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(539, 1, 1390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 5961, 6060);

                return f_539_5968_6059(filePath, generalOption, f_539_6005_6034(specificOptions), f_539_6036_6058(includes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 3998, 6071);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                f_539_4118_4179()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, ReportDiagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4118, 4179);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>.Builder
                f_539_4268_4314()
                {
                    var return_v = ImmutableArray.CreateBuilder<RuleSetInclude>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4268, 4314);
                    return return_v;
                }


                int
                f_539_4331_4395(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    ValidateAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4331, 4395);
                    return 0;
                }


                int
                f_539_4410_4466(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    ValidateAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4410, 4466);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_539_4587_4609(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Elements();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4587, 4609);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_539_4647_4661(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 4647, 4661);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
                f_539_4732_4752(System.Xml.Linq.XElement
                rulesNode)
                {
                    var return_v = ReadRules(rulesNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4732, 4752);
                    return return_v;
                }


                bool
                f_539_5013_5068(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5013, 5068);
                    return return_v;
                }


                string
                f_539_5268_5314()
                {
                    var return_v = CodeAnalysisResources.RuleSetHasDuplicateRules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 5268, 5314);
                    return return_v;
                }


                string
                f_539_5254_5347(string
                format, string
                arg0, Microsoft.CodeAnalysis.ReportDiagnostic
                arg1, Microsoft.CodeAnalysis.ReportDiagnostic
                arg2)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5254, 5347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.InvalidRuleSetException
                f_539_5226_5348(string
                message)
                {
                    var return_v = new Microsoft.CodeAnalysis.InvalidRuleSetException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5226, 5348);
                    return return_v;
                }


                int
                f_539_5494_5529(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5494, 5529);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
                f_539_4796_4801_I(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4796, 4801);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_539_5626_5640(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 5626, 5640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSetInclude
                f_539_5714_5743(System.Xml.Linq.XElement
                includeNode)
                {
                    var return_v = ReadRuleSetInclude(includeNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5714, 5743);
                    return return_v;
                }


                int
                f_539_5701_5744(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>.Builder
                this_param, Microsoft.CodeAnalysis.RuleSetInclude
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5701, 5744);
                    return 0;
                }


                System.Xml.Linq.XName
                f_539_5791_5805(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 5791, 5805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_539_5885_5910(System.Xml.Linq.XElement
                includeAllNode)
                {
                    var return_v = ReadIncludeAll(includeAllNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5885, 5910);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_539_4587_4609_I(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 4587, 4609);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_539_6005_6034(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6005, 6034);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                f_539_6036_6058(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6036, 6058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_539_5968_6059(string
                filePath, Microsoft.CodeAnalysis.ReportDiagnostic
                generalOption, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                includes)
                {
                    var return_v = new Microsoft.CodeAnalysis.RuleSet(filePath, generalOption, specificOptions, includes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 5968, 6059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 3998, 6071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 3998, 6071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<KeyValuePair<string, ReportDiagnostic>> ReadRules(XElement rulesNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 6392, 7333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 6506, 6589);

                string
                analyzerId = f_539_6526_6588(rulesNode, RulesAnalyzerIdAttributeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 6603, 6688);

                string
                ruleNamespace = f_539_6626_6687(rulesNode, RulesNamespaceAttributeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 6704, 6767);

                var
                rules = f_539_6716_6766()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 6827, 7293);
                    foreach (XElement ruleNode in f_539_6857_6877_I(f_539_6857_6877(rulesNode)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 6827, 7293);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 6911, 7278) || true) && (f_539_6915_6928(ruleNode) == RuleNodeName)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 6911, 7278);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 6986, 7043);

                            f_539_6986_7042(rules, f_539_6996_7041(ruleNode, analyzerId, ruleNamespace));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(539, 6911, 7278);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 6911, 7278);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 7203, 7259);

                            f_539_7203_7258(false, "Unknown child node in Rules node");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(539, 6911, 7278);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(539, 6827, 7293);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(539, 1, 467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(539, 1, 467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 7309, 7322);

                return rules;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 6392, 7333);

                string
                f_539_6526_6588(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    var return_v = ReadNonEmptyAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6526, 6588);
                    return return_v;
                }


                string
                f_539_6626_6687(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    var return_v = ReadNonEmptyAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6626, 6687);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
                f_539_6716_6766()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6716, 6766);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_539_6857_6877(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Elements();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6857, 6877);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_539_6915_6928(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 6915, 6928);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_539_6996_7041(System.Xml.Linq.XElement
                ruleNode, string
                analyzer, string
                space)
                {
                    var return_v = ReadRule(ruleNode, analyzer, space);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6996, 7041);
                    return return_v;
                }


                int
                f_539_6986_7042(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
                this_param, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6986, 7042);
                    return 0;
                }


                int
                f_539_7203_7258(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 7203, 7258);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_539_6857_6877_I(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 6857, 6877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 6392, 7333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 6392, 7333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static KeyValuePair<string, ReportDiagnostic> ReadRule(XElement ruleNode, string analyzer, string space)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 7764, 8145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 7901, 7970);

                string
                ruleId = f_539_7917_7969(ruleNode, RuleIdAttributeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 7984, 8052);

                ReportDiagnostic
                action = f_539_8010_8051(ruleNode, allowDefault: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 8068, 8134);

                return f_539_8075_8133(ruleId, action);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 7764, 8145);

                string
                f_539_7917_7969(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    var return_v = ReadNonEmptyAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 7917, 7969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_539_8010_8051(System.Xml.Linq.XElement
                node, bool
                allowDefault)
                {
                    var return_v = ReadAction(node, allowDefault: allowDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 8010, 8051);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_539_8075_8133(string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 8075, 8133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 7764, 8145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 7764, 8145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RuleSetInclude ReadRuleSetInclude(XElement includeNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 8461, 8796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 8556, 8638);

                string
                includePath = f_539_8577_8637(includeNode, IncludePathAttributeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 8652, 8722);

                ReportDiagnostic
                action = f_539_8678_8721(includeNode, allowDefault: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 8738, 8785);

                return f_539_8745_8784(includePath, action);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 8461, 8796);

                string
                f_539_8577_8637(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    var return_v = ReadNonEmptyAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 8577, 8637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_539_8678_8721(System.Xml.Linq.XElement
                node, bool
                allowDefault)
                {
                    var return_v = ReadAction(node, allowDefault: allowDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 8678, 8721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSetInclude
                f_539_8745_8784(string
                includePath, Microsoft.CodeAnalysis.ReportDiagnostic
                action)
                {
                    var return_v = new Microsoft.CodeAnalysis.RuleSetInclude(includePath, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 8745, 8784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 8461, 8796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 8461, 8796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ReportDiagnostic ReadAction(XElement node, bool allowDefault)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 9157, 10374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9258, 9327);

                string
                action = f_539_9274_9326(node, RuleActionAttributeName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9343, 10217) || true) && (f_539_9347_9392(action, RuleActionWarningValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9343, 10217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9426, 9455);

                    return ReportDiagnostic.Warn;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9343, 10217);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9343, 10217);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9489, 10217) || true) && (f_539_9493_9536(action, RuleActionErrorValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9489, 10217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9570, 9600);

                        return ReportDiagnostic.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9489, 10217);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9489, 10217);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9634, 10217) || true) && (f_539_9638_9680(action, RuleActionInfoValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9634, 10217);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9714, 9743);

                            return ReportDiagnostic.Info;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9634, 10217);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9634, 10217);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9777, 10217) || true) && (f_539_9781_9825(action, RuleActionHiddenValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9777, 10217);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9859, 9890);

                                return ReportDiagnostic.Hidden;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9777, 10217);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9777, 10217);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 9924, 10217) || true) && (f_539_9928_9970(action, RuleActionNoneValue))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9924, 10217);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 10004, 10037);

                                    return ReportDiagnostic.Suppress;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9924, 10217);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 9924, 10217);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 10071, 10217) || true) && (f_539_10075_10120(action, RuleActionDefaultValue) && (DynAbs.Tracing.TraceSender.Expression_True(539, 10075, 10136) && allowDefault))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 10071, 10217);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 10170, 10202);

                                        return ReportDiagnostic.Default;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(539, 10071, 10217);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9924, 10217);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9777, 10217);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9634, 10217);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9489, 10217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 9343, 10217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 10233, 10363);

                throw f_539_10239_10362(f_539_10267_10361(f_539_10281_10327(), RuleActionAttributeName, action));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 9157, 10374);

                string
                f_539_9274_9326(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    var return_v = ReadNonEmptyAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 9274, 9326);
                    return return_v;
                }


                bool
                f_539_9347_9392(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 9347, 9392);
                    return return_v;
                }


                bool
                f_539_9493_9536(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 9493, 9536);
                    return return_v;
                }


                bool
                f_539_9638_9680(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 9638, 9680);
                    return return_v;
                }


                bool
                f_539_9781_9825(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 9781, 9825);
                    return return_v;
                }


                bool
                f_539_9928_9970(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 9928, 9970);
                    return return_v;
                }


                bool
                f_539_10075_10120(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 10075, 10120);
                    return return_v;
                }


                string
                f_539_10281_10327()
                {
                    var return_v = CodeAnalysisResources.RuleSetBadAttributeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 10281, 10327);
                    return return_v;
                }


                string
                f_539_10267_10361(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 10267, 10361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.InvalidRuleSetException
                f_539_10239_10362(string
                message)
                {
                    var return_v = new Microsoft.CodeAnalysis.InvalidRuleSetException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 10239, 10362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 9157, 10374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 9157, 10374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ReportDiagnostic ReadIncludeAll(XElement includeAllNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 10682, 10844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 10778, 10833);

                return f_539_10785_10832(includeAllNode, allowDefault: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 10682, 10844);

                Microsoft.CodeAnalysis.ReportDiagnostic
                f_539_10785_10832(System.Xml.Linq.XElement
                node, bool
                allowDefault)
                {
                    var return_v = ReadAction(node, allowDefault: allowDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 10785, 10832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 10682, 10844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 10682, 10844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ReadNonEmptyAttribute(XElement node, string attributeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 11199, 11848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 11304, 11357);

                XAttribute
                attribute = f_539_11327_11356(node, attributeName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 11371, 11563) || true) && (attribute == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 11371, 11563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 11426, 11548);

                    throw f_539_11432_11547(f_539_11460_11546(f_539_11474_11519(), f_539_11521_11530(node), attributeName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 11371, 11563);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 11579, 11798) || true) && (f_539_11583_11620(f_539_11604_11619(attribute)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(539, 11579, 11798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 11654, 11783);

                    throw f_539_11660_11782(f_539_11688_11781(f_539_11702_11748(), attributeName, f_539_11765_11780(attribute)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(539, 11579, 11798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 11814, 11837);

                return f_539_11821_11836(attribute);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 11199, 11848);

                System.Xml.Linq.XAttribute
                f_539_11327_11356(System.Xml.Linq.XElement
                this_param, string
                name)
                {
                    var return_v = this_param.Attribute((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 11327, 11356);
                    return return_v;
                }


                string
                f_539_11474_11519()
                {
                    var return_v = CodeAnalysisResources.RuleSetMissingAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 11474, 11519);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_539_11521_11530(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 11521, 11530);
                    return return_v;
                }


                string
                f_539_11460_11546(string
                format, System.Xml.Linq.XName
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 11460, 11546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.InvalidRuleSetException
                f_539_11432_11547(string
                message)
                {
                    var return_v = new Microsoft.CodeAnalysis.InvalidRuleSetException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 11432, 11547);
                    return return_v;
                }


                string
                f_539_11604_11619(System.Xml.Linq.XAttribute
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 11604, 11619);
                    return return_v;
                }


                bool
                f_539_11583_11620(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 11583, 11620);
                    return return_v;
                }


                string
                f_539_11702_11748()
                {
                    var return_v = CodeAnalysisResources.RuleSetBadAttributeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 11702, 11748);
                    return return_v;
                }


                string
                f_539_11765_11780(System.Xml.Linq.XAttribute
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 11765, 11780);
                    return return_v;
                }


                string
                f_539_11688_11781(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 11688, 11781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.InvalidRuleSetException
                f_539_11660_11782(string
                message)
                {
                    var return_v = new Microsoft.CodeAnalysis.InvalidRuleSetException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 11660, 11782);
                    return return_v;
                }


                string
                f_539_11821_11836(System.Xml.Linq.XAttribute
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(539, 11821, 11836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 11199, 11848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 11199, 11848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static XmlReaderSettings GetDefaultXmlReaderSettings()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 11976, 12610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12063, 12125);

                XmlReaderSettings
                xmlReaderSettings = f_539_12101_12124()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12141, 12182);

                xmlReaderSettings.CheckCharacters = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12196, 12232);

                xmlReaderSettings.CloseInput = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12246, 12309);

                xmlReaderSettings.ConformanceLevel = ConformanceLevel.Document;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12323, 12363);

                xmlReaderSettings.IgnoreComments = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12377, 12431);

                xmlReaderSettings.IgnoreProcessingInstructions = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12445, 12487);

                xmlReaderSettings.IgnoreWhitespace = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12501, 12558);

                xmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12574, 12599);

                return xmlReaderSettings;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 11976, 12610);

                System.Xml.XmlReaderSettings
                f_539_12101_12124()
                {
                    var return_v = new System.Xml.XmlReaderSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 12101, 12124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 11976, 12610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 11976, 12610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ValidateAttribute(XElement node, string attributeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(539, 12622, 12775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 12721, 12764);

                f_539_12721_12763(node, attributeName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(539, 12622, 12775);

                string
                f_539_12721_12763(System.Xml.Linq.XElement
                node, string
                attributeName)
                {
                    var return_v = ReadNonEmptyAttribute(node, attributeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(539, 12721, 12763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(539, 12622, 12775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 12622, 12775);
            }
        }

        public RuleSetProcessor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(539, 642, 12782);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(539, 642, 12782);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 642, 12782);
        }


        static RuleSetProcessor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(539, 642, 12782);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 752, 779);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 811, 844);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 876, 923);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 955, 1004);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1077, 1100);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1132, 1175);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1207, 1252);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1324, 1345);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1377, 1403);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1478, 1505);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1537, 1570);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1648, 1681);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1775, 1809);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1841, 1869);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1901, 1933);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 1965, 1993);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2025, 2059);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2091, 2121);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(539, 2153, 2187);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(539, 642, 12782);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(539, 642, 12782);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(539, 642, 12782);
    }
}
