// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed partial class AnalyzerConfig
    {
        private static readonly Regex s_sectionMatcher;

        private static readonly Regex s_propertyMatcher;

        internal const string
        GlobalKey = "is_global"
        ;

        internal const string
        GlobalLevelKey = "global_level"
        ;

        internal const string
        UserGlobalConfigName = ".globalconfig"
        ;

        internal static ImmutableHashSet<string> ReservedKeys { get; }

        internal static ImmutableHashSet<string> ReservedValues { get; }

        internal Section GlobalSection { get; }

        internal string NormalizedDirectory { get; }

        internal string PathToFile { get; }

        internal static Comparer<AnalyzerConfig> DirectoryLengthComparer { get; }

        internal ImmutableArray<Section> NamedSections { get; }

        internal bool IsRoot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(117, 4242, 4323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 4245, 4323);
                    // LAFHIS
                    var temp = f_117_4245_4306(f_117_4245_4269(f_117_4245_4258()), "root", out string? val);
                    return temp && 
                        (DynAbs.Tracing.TraceSender.Expression_True(117, 4245, 4323) && 
                        val == "true"); 
                    DynAbs.Tracing.TraceSender.TraceExitMethod(117, 4242, 4323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 4242, 4323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 4242, 4323);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsGlobal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(117, 4476, 4548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 4479, 4548);
                    return _hasGlobalFileName || (DynAbs.Tracing.TraceSender.Expression_False(117, 4479, 4548) || f_117_4501_4548(f_117_4501_4525(f_117_4501_4514()), GlobalKey)); DynAbs.Tracing.TraceSender.TraceExitMethod(117, 4476, 4548);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 4476, 4548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 4476, 4548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int GlobalLevel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(117, 5463, 5905);
                    string val = default(string);
                    int level = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 5499, 5890) || true) && (f_117_5503_5572(f_117_5503_5527(f_117_5503_5516()), GlobalLevelKey, out val) && (DynAbs.Tracing.TraceSender.Expression_True(117, 5503, 5608) && f_117_5576_5608(val, out level)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 5499, 5890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 5650, 5663);

                        return level;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(117, 5499, 5890);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 5499, 5890);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 5705, 5890) || true) && (_hasGlobalFileName)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 5705, 5890);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 5769, 5780);

                            return 100;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 5705, 5890);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 5705, 5890);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 5862, 5871);

                            return 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 5705, 5890);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(117, 5499, 5890);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(117, 5463, 5905);

                    Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    f_117_5503_5516()
                    {
                        var return_v = GlobalSection;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 5503, 5516);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, string>
                    f_117_5503_5527(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 5503, 5527);
                        return return_v;
                    }


                    bool
                    f_117_5503_5572(System.Collections.Immutable.ImmutableDictionary<string, string>
                    this_param, string
                    key, out string?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 5503, 5572);
                        return return_v;
                    }


                    bool
                    f_117_5576_5608(string
                    s, out int
                    result)
                    {
                        var return_v = int.TryParse(s, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 5576, 5608);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 5414, 5916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 5414, 5916);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly bool _hasGlobalFileName;

        private AnalyzerConfig(
                    Section globalSection,
                    ImmutableArray<Section> namedSections,
                    string pathToFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(117, 5981, 6651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 3191, 3230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 3413, 3457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 3605, 3640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 5950, 5968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 6149, 6179);

                GlobalSection = globalSection;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 6193, 6223);

                NamedSections = namedSections;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 6237, 6261);

                PathToFile = pathToFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 6275, 6390);

                _hasGlobalFileName = f_117_6296_6389(f_117_6296_6324(pathToFile), UserGlobalConfigName, StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 6486, 6553);

                string
                directory = f_117_6505_6538(pathToFile) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(117, 6505, 6552) ?? pathToFile)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 6567, 6640);

                NormalizedDirectory = f_117_6589_6639(directory);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(117, 5981, 6651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 5981, 6651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 5981, 6651);
            }
        }

        public static AnalyzerConfig Parse(string text, string? pathToFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(117, 6880, 7031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 6972, 7020);

                return f_117_6979_7019(f_117_6985_7006(text), pathToFile);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(117, 6880, 7031);

                Microsoft.CodeAnalysis.Text.SourceText
                f_117_6985_7006(string
                text)
                {
                    var return_v = SourceText.From(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6985, 7006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig
                f_117_6979_7019(Microsoft.CodeAnalysis.Text.SourceText
                text, string?
                pathToFile)
                {
                    var return_v = Parse(text, pathToFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6979, 7019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 6880, 7031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 6880, 7031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnalyzerConfig Parse(SourceText text, string? pathToFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(117, 7260, 10966);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 7356, 7615) || true) && (pathToFile is null || (DynAbs.Tracing.TraceSender.Expression_False(117, 7360, 7412) || !f_117_7383_7412(pathToFile)) || (DynAbs.Tracing.TraceSender.Expression_False(117, 7360, 7466) || f_117_7416_7466(f_117_7437_7465(pathToFile))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 7356, 7615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 7500, 7600);

                    throw f_117_7506_7599("Must be an absolute path to an editorconfig file", nameof(pathToFile));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(117, 7356, 7615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 7631, 7661);

                Section?
                globalSection = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 7675, 7741);

                var
                namedSectionBuilder = f_117_7701_7740()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8211, 8340);

                var
                activeSectionProperties = f_117_8241_8339(f_117_8309_8338())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8354, 8384);

                string
                activeSectionName = ""
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8400, 10242);
                    foreach (var textLine in f_117_8425_8435_I(f_117_8425_8435(text)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 8400, 10242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8469, 8503);

                        string
                        line = textLine.ToString()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8523, 8628) || true) && (f_117_8527_8558(line))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 8523, 8628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8600, 8609);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 8523, 8628);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8648, 8737) || true) && (f_117_8652_8667(line))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 8648, 8737);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8709, 8718);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 8648, 8737);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8757, 8809);

                        var
                        sectionMatches = f_117_8778_8808(s_sectionMatcher, line)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8827, 9359) || true) && (f_117_8831_8851(sectionMatches) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(117, 8831, 8893) && f_117_8859_8889(f_117_8859_8883(f_117_8859_8876(sectionMatches, 0))) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 8827, 9359);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8935, 8951);

                            f_117_8935_8950();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 8975, 9027);

                            var
                            sectionName = f_117_8993_9026(f_117_8993_9020(f_117_8993_9017(f_117_8993_9010(sectionMatches, 0)), 1))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9049, 9098);

                            f_117_9049_9097(!f_117_9063_9096(sectionName));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9122, 9154);

                            activeSectionName = sectionName;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9176, 9309);

                            activeSectionProperties = f_117_9202_9308(f_117_9278_9307());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9331, 9340);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 8827, 9359);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9379, 9429);

                        var
                        propMatches = f_117_9397_9428(s_propertyMatcher, line)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9447, 10227) || true) && (f_117_9451_9468(propMatches) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(117, 9451, 9507) && f_117_9476_9503(f_117_9476_9497(f_117_9476_9490(propMatches, 0))) > 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 9447, 10227);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9549, 9590);

                            var
                            key = f_117_9559_9589(f_117_9559_9583(f_117_9559_9580(f_117_9559_9573(propMatches, 0)), 1))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9612, 9655);

                            var
                            value = f_117_9624_9654(f_117_9624_9648(f_117_9624_9645(f_117_9624_9638(propMatches, 0)), 2))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9679, 9720);

                            f_117_9679_9719(!f_117_9693_9718(key));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9742, 9774);

                            f_117_9742_9773(key == f_117_9762_9772(key));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9796, 9833);

                            f_117_9796_9832(value == f_117_9818_9831_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(value, 117, 9818, 9831)?.Trim()));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9857, 9902);

                            key = f_117_9863_9901(key);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 9924, 10110) || true) && (f_117_9928_9954(f_117_9928_9940(), key) || (DynAbs.Tracing.TraceSender.Expression_False(117, 9928, 9988) || f_117_9958_9988(f_117_9958_9972(), value)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 9924, 10110);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10038, 10087);

                                value = f_117_10046_10086(value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(117, 9924, 10110);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10134, 10177);

                            activeSectionProperties[key] = value ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(117, 10165, 10176) ?? "");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10199, 10208);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 9447, 10227);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(117, 8400, 10242);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(117, 1, 1843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(117, 1, 1843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10295, 10311);

                f_117_10295_10310();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10327, 10416);

                return f_117_10334_10415(globalSection!, f_117_10369_10402(namedSectionBuilder), pathToFile);

                void addNewSection()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(117, 10432, 10955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10536, 10628);

                        var
                        previousSection = f_117_10558_10627(activeSectionName, f_117_10589_10626(activeSectionProperties))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10646, 10940) || true) && (activeSectionName == "")
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 10646, 10940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10766, 10798);

                            globalSection = previousSection;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 10646, 10940);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 10646, 10940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 10880, 10921);

                            f_117_10880_10920(namedSectionBuilder, previousSection);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 10646, 10940);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(117, 10432, 10955);

                        System.Collections.Immutable.ImmutableDictionary<string, string>
                        f_117_10589_10626(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10589, 10626);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.AnalyzerConfig.Section
                        f_117_10558_10627(string
                        name, System.Collections.Immutable.ImmutableDictionary<string, string>
                        properties)
                        {
                            var return_v = new Microsoft.CodeAnalysis.AnalyzerConfig.Section(name, properties);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10558, 10627);
                            return return_v;
                        }


                        int
                        f_117_10880_10920(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>.Builder
                        this_param, Microsoft.CodeAnalysis.AnalyzerConfig.Section
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10880, 10920);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 10432, 10955);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 10432, 10955);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(117, 7260, 10966);

                bool
                f_117_7383_7412(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7383, 7412);
                    return return_v;
                }


                string?
                f_117_7437_7465(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7437, 7465);
                    return return_v;
                }


                bool
                f_117_7416_7466(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7416, 7466);
                    return return_v;
                }


                System.ArgumentException
                f_117_7506_7599(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7506, 7599);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>.Builder
                f_117_7701_7740()
                {
                    var return_v = ImmutableArray.CreateBuilder<Section>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7701, 7740);
                    return return_v;
                }


                System.StringComparer
                f_117_8309_8338()
                {
                    var return_v = Section.PropertiesKeyComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8309, 8338);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                f_117_8241_8339(System.StringComparer
                keyComparer)
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, string>((System.Collections.Generic.IEqualityComparer<string>)keyComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8241, 8339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_117_8425_8435(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8425, 8435);
                    return return_v;
                }


                bool
                f_117_8527_8558(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8527, 8558);
                    return return_v;
                }


                bool
                f_117_8652_8667(string
                line)
                {
                    var return_v = IsComment(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8652, 8667);
                    return return_v;
                }


                System.Text.RegularExpressions.MatchCollection
                f_117_8778_8808(System.Text.RegularExpressions.Regex
                this_param, string
                input)
                {
                    var return_v = this_param.Matches(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8778, 8808);
                    return return_v;
                }


                int
                f_117_8831_8851(System.Text.RegularExpressions.MatchCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8831, 8851);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_117_8859_8876(System.Text.RegularExpressions.MatchCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8859, 8876);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_117_8859_8883(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8859, 8883);
                    return return_v;
                }


                int
                f_117_8859_8889(System.Text.RegularExpressions.GroupCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8859, 8889);
                    return return_v;
                }


                int
                f_117_8935_8950()
                {
                    addNewSection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8935, 8950);
                    return 0;
                }


                System.Text.RegularExpressions.Match
                f_117_8993_9010(System.Text.RegularExpressions.MatchCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8993, 9010);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_117_8993_9017(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8993, 9017);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_117_8993_9020(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8993, 9020);
                    return return_v;
                }


                string
                f_117_8993_9026(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8993, 9026);
                    return return_v;
                }


                bool
                f_117_9063_9096(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9063, 9096);
                    return return_v;
                }


                int
                f_117_9049_9097(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9049, 9097);
                    return 0;
                }


                System.StringComparer
                f_117_9278_9307()
                {
                    var return_v = Section.PropertiesKeyComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9278, 9307);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                f_117_9202_9308(System.StringComparer
                keyComparer)
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, string>((System.Collections.Generic.IEqualityComparer<string>)keyComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9202, 9308);
                    return return_v;
                }


                System.Text.RegularExpressions.MatchCollection
                f_117_9397_9428(System.Text.RegularExpressions.Regex
                this_param, string
                input)
                {
                    var return_v = this_param.Matches(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9397, 9428);
                    return return_v;
                }


                int
                f_117_9451_9468(System.Text.RegularExpressions.MatchCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9451, 9468);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_117_9476_9490(System.Text.RegularExpressions.MatchCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9476, 9490);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_117_9476_9497(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9476, 9497);
                    return return_v;
                }


                int
                f_117_9476_9503(System.Text.RegularExpressions.GroupCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9476, 9503);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_117_9559_9573(System.Text.RegularExpressions.MatchCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9559, 9573);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_117_9559_9580(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9559, 9580);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_117_9559_9583(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9559, 9583);
                    return return_v;
                }


                string
                f_117_9559_9589(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9559, 9589);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_117_9624_9638(System.Text.RegularExpressions.MatchCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9624, 9638);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_117_9624_9645(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9624, 9645);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_117_9624_9648(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9624, 9648);
                    return return_v;
                }


                string
                f_117_9624_9654(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9624, 9654);
                    return return_v;
                }


                bool
                f_117_9693_9718(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9693, 9718);
                    return return_v;
                }


                int
                f_117_9679_9719(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9679, 9719);
                    return 0;
                }


                string
                f_117_9762_9772(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9762, 9772);
                    return return_v;
                }


                int
                f_117_9742_9773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9742, 9773);
                    return 0;
                }


                string?
                f_117_9818_9831_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9818, 9831);
                    return return_v;
                }


                int
                f_117_9796_9832(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9796, 9832);
                    return 0;
                }


                string?
                f_117_9863_9901(string
                value)
                {
                    var return_v = CaseInsensitiveComparison.ToLower(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9863, 9901);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_117_9928_9940()
                {
                    var return_v = ReservedKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9928, 9940);
                    return return_v;
                }


                bool
                f_117_9928_9954(System.Collections.Immutable.ImmutableHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9928, 9954);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_117_9958_9972()
                {
                    var return_v = ReservedValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9958, 9972);
                    return return_v;
                }


                bool
                f_117_9958_9988(System.Collections.Immutable.ImmutableHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9958, 9988);
                    return return_v;
                }


                string?
                f_117_10046_10086(string
                value)
                {
                    var return_v = CaseInsensitiveComparison.ToLower(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10046, 10086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_117_8425_8435_I(Microsoft.CodeAnalysis.Text.TextLineCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8425, 8435);
                    return return_v;
                }


                int
                f_117_10295_10310()
                {
                    addNewSection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10295, 10310);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_117_10369_10402(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10369, 10402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig
                f_117_10334_10415(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                globalSection, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                namedSections, string
                pathToFile)
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfig(globalSection, namedSections, pathToFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10334, 10415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 7260, 10966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 7260, 10966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsComment(string line)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(117, 10978, 11271);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 11045, 11231);
                    foreach (char c in f_117_11064_11068_I(line))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 11045, 11231);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 11102, 11216) || true) && (!f_117_11107_11127(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(117, 11102, 11216);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 11169, 11197);

                            return c == '#' || (DynAbs.Tracing.TraceSender.Expression_False(117, 11176, 11196) || c == ';');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(117, 11102, 11216);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(117, 11045, 11231);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(117, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(117, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 11247, 11260);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(117, 10978, 11271);

                bool
                f_117_11107_11127(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 11107, 11127);
                    return return_v;
                }


                string
                f_117_11064_11068_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 11064, 11068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 10978, 11271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 10978, 11271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal sealed class Section
        {
            public static StringComparison NameComparer { get; }

            public static IEqualityComparer<string> NameEqualityComparer { get; }

            public static StringComparer PropertiesKeyComparer { get; }

            public Section(string name, ImmutableDictionary<string, string> properties)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(117, 12503, 12680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 12852, 12879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 13388, 13450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 12611, 12623);

                    Name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 12641, 12665);

                    Properties = properties;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(117, 12503, 12680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117, 12503, 12680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 12503, 12680);
                }
            }

            public string Name { get; }

            public ImmutableDictionary<string, string> Properties { get; }

            static Section()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(117, 11472, 13461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 11725, 11805);
                NameComparer = StringComparison.Ordinal; DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 12020, 12115);
                NameEqualityComparer = f_117_12092_12114(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 12390, 12487);
                PropertiesKeyComparer = f_117_12452_12486(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(117, 11472, 13461);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 11472, 13461);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(117, 11472, 13461);

            static System.StringComparer
            f_117_12092_12114()
            {
                var return_v = StringComparer.Ordinal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12092, 12114);
                return return_v;
            }


            static System.StringComparer
            f_117_12452_12486()
            {
                var return_v = CaseInsensitiveComparison.Comparer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12452, 12486);
                return return_v;
            }

        }

        static AnalyzerConfig()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(117, 629, 13468);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 830, 925);
            s_sectionMatcher = f_117_849_925(@"^\s*\[(([^#;]|\\#|\\;)+)\]\s*([#;].*)?$", RegexOptions.Compiled); DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 1081, 1182);
            s_propertyMatcher = f_117_1101_1182(@"^\s*([\w\.\-_]+)\s*[=:]\s*(.*?)\s*([#;].*)?$", RegexOptions.Compiled); DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 1330, 1353);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 1533, 1564);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 1726, 1764);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 2371, 2799);
            ReservedKeys = f_117_2449_2798(f_117_2478_2507(), new[] {
                "root",
                "indent_style",
                "indent_size",
                "tab_width",
                "end_of_line",
                "charset",
                "trim_trailing_whitespace",
                "insert_final_newline",
            }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 3015, 3179);
            ReservedValues = f_117_3095_3178(f_117_3124_3158(), new[] { "unset" }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(117, 3818, 4024);
            DirectoryLengthComparer = f_117_3894_4023((e1, e2) => e1.NormalizedDirectory.Length.CompareTo(e2.NormalizedDirectory.Length)); 
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(117, 629, 13468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117, 629, 13468);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(117, 629, 13468);

        static System.Text.RegularExpressions.Regex
        f_117_849_925(string
        pattern, System.Text.RegularExpressions.RegexOptions
        options)
        {
            var return_v = new System.Text.RegularExpressions.Regex(pattern, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 849, 925);
            return return_v;
        }


        static System.Text.RegularExpressions.Regex
        f_117_1101_1182(string
        pattern, System.Text.RegularExpressions.RegexOptions
        options)
        {
            var return_v = new System.Text.RegularExpressions.Regex(pattern, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 1101, 1182);
            return return_v;
        }


        static System.StringComparer
        f_117_2478_2507()
        {
            var return_v = Section.PropertiesKeyComparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 2478, 2507);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableHashSet<string>
        f_117_2449_2798(System.StringComparer
        equalityComparer, string[]
        items)
        {
            var return_v = ImmutableHashSet.CreateRange((System.Collections.Generic.IEqualityComparer<string>)equalityComparer, (System.Collections.Generic.IEnumerable<string>)items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 2449, 2798);
            return return_v;
        }


        static System.StringComparer
        f_117_3124_3158()
        {
            var return_v = CaseInsensitiveComparison.Comparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 3124, 3158);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableHashSet<string>
        f_117_3095_3178(System.StringComparer
        equalityComparer, string[]
        items)
        {
            var return_v = ImmutableHashSet.CreateRange((System.Collections.Generic.IEqualityComparer<string>)equalityComparer, (System.Collections.Generic.IEnumerable<string>)items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3095, 3178);
            return return_v;
        }


        static System.Collections.Generic.Comparer<Microsoft.CodeAnalysis.AnalyzerConfig>
        f_117_3894_4023(System.Comparison<Microsoft.CodeAnalysis.AnalyzerConfig>
        comparison)
        {
            var return_v = Comparer<AnalyzerConfig>.Create(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3894, 4023);
            return return_v;
        }


        Microsoft.CodeAnalysis.AnalyzerConfig.Section
        f_117_4245_4258()
        {
            var return_v = GlobalSection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 4245, 4258);
            return return_v;
        }


        System.Collections.Immutable.ImmutableDictionary<string, string>
        f_117_4245_4269(Microsoft.CodeAnalysis.AnalyzerConfig.Section
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 4245, 4269);
            return return_v;
        }


        bool
        f_117_4245_4306(System.Collections.Immutable.ImmutableDictionary<string, string>
        this_param, string
        key, out string?
        value)
        {
            var return_v = this_param.TryGetValue(key, out value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 4245, 4306);
            return return_v;
        }


        Microsoft.CodeAnalysis.AnalyzerConfig.Section
        f_117_4501_4514()
        {
            var return_v = GlobalSection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 4501, 4514);
            return return_v;
        }


        System.Collections.Immutable.ImmutableDictionary<string, string>
        f_117_4501_4525(Microsoft.CodeAnalysis.AnalyzerConfig.Section
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 4501, 4525);
            return return_v;
        }


        bool
        f_117_4501_4548(System.Collections.Immutable.ImmutableDictionary<string, string>
        this_param, string
        key)
        {
            var return_v = this_param.ContainsKey(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 4501, 4548);
            return return_v;
        }


        static string?
        f_117_6296_6324(string
        path)
        {
            var return_v = Path.GetFileName(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6296, 6324);
            return return_v;
        }


        static bool
        f_117_6296_6389(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6296, 6389);
            return return_v;
        }


        static string?
        f_117_6505_6538(string
        path)
        {
            var return_v = Path.GetDirectoryName(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6505, 6538);
            return return_v;
        }


        static string
        f_117_6589_6639(string
        p)
        {
            var return_v = PathUtilities.NormalizeWithForwardSlash(p);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6589, 6639);
            return return_v;
        }

    }
}
