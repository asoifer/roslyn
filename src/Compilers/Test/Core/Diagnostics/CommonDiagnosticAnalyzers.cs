// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis
{
    public static class CommonDiagnosticAnalyzers
    {
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class AnalyzerForErrorLogTest : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor1;

            public static readonly DiagnosticDescriptor Descriptor2;

            private static readonly ImmutableDictionary<string, string> s_properties;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 2221, 2339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 2265, 2320);

                        return f_25069_2272_2319(Descriptor1, Descriptor2);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 2221, 2339);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25069_2272_2319(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item2)
                        {
                            var return_v = ImmutableArray.Create(item1, item2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 2272, 2319);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 2115, 2354);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 2115, 2354);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 2370, 3014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 2459, 2999);

                    f_25069_2459_2998(context, compilationContext =>
                    {
                    // With location diagnostic.
                    var location = compilationContext.Compilation.SyntaxTrees.First().GetRoot().GetLocation();
                        compilationContext.ReportDiagnostic(Diagnostic.Create(Descriptor1, location, s_properties));

                    // No location diagnostic.
                    compilationContext.ReportDiagnostic(Diagnostic.Create(Descriptor2, Location.None, s_properties));
                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 2370, 3014);

                    int
                    f_25069_2459_2998(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 2459, 2998);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 2370, 3014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 2370, 3014);
                }
            }

            private static string GetExpectedPropertiesMapText()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 3030, 3657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3115, 3175);

                    var
                    expectedText = @"
            ""customProperties"": {"
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3195, 3547);
                        foreach (var kvp in f_25069_3215_3251_I(f_25069_3215_3251(s_properties, kvp => kvp.Key)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 3195, 3547);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3293, 3417) || true) && (!f_25069_3298_3324(expectedText, "{"))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 3293, 3417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3374, 3394);

                                expectedText += ",";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 3293, 3417);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3441, 3528);

                            expectedText += f_25069_3457_3527(@"
              ""{0}"": ""{1}""", kvp.Key, kvp.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 3195, 3547);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 353);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 353);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3567, 3602);

                    expectedText += @"
            }";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3622, 3642);

                    return expectedText;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 3030, 3657);

                    System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    f_25069_3215_3251(System.Collections.Immutable.ImmutableDictionary<string, string>
                    source, System.Func<System.Collections.Generic.KeyValuePair<string, string>, string>
                    keySelector)
                    {
                        var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<string, string>, string>(keySelector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3215, 3251);
                        return return_v;
                    }


                    bool
                    f_25069_3298_3324(string
                    this_param, string
                    value)
                    {
                        var return_v = this_param.EndsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3298, 3324);
                        return return_v;
                    }


                    string
                    f_25069_3457_3527(string
                    format, string
                    arg0, string
                    arg1)
                    {
                        var return_v = string.Format(format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3457, 3527);
                        return return_v;
                    }


                    System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    f_25069_3215_3251_I(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3215, 3251);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 3030, 3657);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 3030, 3657);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static string GetExpectedV1ErrorLogResultsAndRulesText(Compilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 3673, 7027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3792, 3835);

                    var
                    tree = f_25069_3803_3834(f_25069_3803_3826(compilation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3853, 3879);

                    var
                    root = f_25069_3864_3878(tree)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3897, 3953);

                    var
                    expectedLineSpan = f_25069_3920_3952(f_25069_3920_3938(root))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 3971, 4015);

                    var
                    filePath = f_25069_3986_4014(f_25069_4000_4013(tree))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 4035, 7012);

                    return @"
      ""results"": [
        {
          ""ruleId"": """ + f_25069_4107_4121(Descriptor1) + @""",
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 4159, 4214) || ((f_25069_4159_4186(Descriptor1) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 4217, 4224)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 4227, 4236))) ? "error" : "warning") + @""",
          ""message"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_4276_4301(Descriptor1)).ToString(), 25069, 4276, 4301) + @""",
          ""locations"": [
            {
              ""resultFile"": {
                ""uri"": """ + filePath + @""",
                ""region"": {
                  ""startLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Line + 1)).ToString(), 25069, 4504, 4549) + @",
                  ""startColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Character + 1)).ToString(), 25069, 4596, 4646) + @",
                  ""endLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Line + 1)).ToString(), 25069, 4689, 4732) + @",
                  ""endColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Character + 1)).ToString(), 25069, 4777, 4825) + @"
                }
              }
            }
          ],
          ""properties"": {
            ""warningLevel"": 1," + f_25069_4962_4992() + @"
          }
        },
        {
          ""ruleId"": """ + f_25069_5063_5077(Descriptor2) + @""",
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 5115, 5170) || ((f_25069_5115_5142(Descriptor2) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 5173, 5180)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 5183, 5192))) ? "error" : "warning") + @""",
          ""message"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_5232_5257(Descriptor2)).ToString(), 25069, 5232, 5257) + @""",
          ""properties"": {" +
                    f_25069_5312_5342() + @"
          }
        }
      ],
      ""rules"": {
        """ + f_25069_5417_5431(Descriptor1) + @""": {
          ""id"": """ + f_25069_5467_5481(Descriptor1) + @""",
          ""shortDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_5529_5546(Descriptor1)).ToString(), 25069, 5529, 5546) + @""",
          ""fullDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_5593_5616(Descriptor1)).ToString(), 25069, 5593, 5616) + @""",
          ""defaultLevel"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 5661, 5716) || ((f_25069_5661_5688(Descriptor1) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 5719, 5726)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 5729, 5738))) ? "error" : "warning") + @""",
          ""helpUri"": """ + f_25069_5778_5801(Descriptor1) + @""",
          ""properties"": {
            ""category"": """ + f_25069_5872_5892(Descriptor1) + @""",
            ""isEnabledByDefault"": " + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 5943, 5973) || ((f_25069_5943_5973(Descriptor2) && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 5976, 5982)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 5985, 5992))) ? "true" : "false") + @",
            ""tags"": [
              " + f_25069_6044_6149("," + f_25069_6062_6081() + "              ", f_25069_6102_6148(f_25069_6102_6124(Descriptor1), s => $"\"{s}\"")) + @"
            ]
          }
        },
        """ + f_25069_6210_6224(Descriptor2) + @""": {
          ""id"": """ + f_25069_6260_6274(Descriptor2) + @""",
          ""shortDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_6322_6339(Descriptor2)).ToString(), 25069, 6322, 6339) + @""",
          ""fullDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_6386_6409(Descriptor2)).ToString(), 25069, 6386, 6409) + @""",
          ""defaultLevel"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 6454, 6509) || ((f_25069_6454_6481(Descriptor2) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 6512, 6519)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 6522, 6531))) ? "error" : "warning") + @""",
          ""helpUri"": """ + f_25069_6571_6594(Descriptor2) + @""",
          ""properties"": {
            ""category"": """ + f_25069_6665_6685(Descriptor2) + @""",
            ""isEnabledByDefault"": " + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 6736, 6766) || ((f_25069_6736_6766(Descriptor2) && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 6769, 6775)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 6778, 6785))) ? "true" : "false") + @",
            ""tags"": [
              " + f_25069_6837_6942("," + f_25069_6855_6874() + "              ", f_25069_6895_6941(f_25069_6895_6917(Descriptor2), s => $"\"{s}\"")) + @"
            ]
          }
        }
      }
    }
  ]
}";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 3673, 7027);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_25069_3803_3826(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.SyntaxTrees;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 3803, 3826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_25069_3803_3834(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    source)
                    {
                        var return_v = source.First<Microsoft.CodeAnalysis.SyntaxTree>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3803, 3834);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25069_3864_3878(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3864, 3878);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_25069_3920_3938(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3920, 3938);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FileLinePositionSpan
                    f_25069_3920_3952(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.GetLineSpan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3920, 3952);
                        return return_v;
                    }


                    string
                    f_25069_4000_4013(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 4000, 4013);
                        return return_v;
                    }


                    string
                    f_25069_3986_4014(string
                    path)
                    {
                        var return_v = GetUriForPath(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 3986, 4014);
                        return return_v;
                    }


                    string
                    f_25069_4107_4121(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 4107, 4121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_4159_4186(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 4159, 4186);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_4276_4301(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 4276, 4301);
                        return return_v;
                    }


                    string
                    f_25069_4962_4992()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 4962, 4992);
                        return return_v;
                    }


                    string
                    f_25069_5063_5077(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5063, 5077);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_5115_5142(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5115, 5142);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_5232_5257(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5232, 5257);
                        return return_v;
                    }


                    string
                    f_25069_5312_5342()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 5312, 5342);
                        return return_v;
                    }


                    string
                    f_25069_5417_5431(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5417, 5431);
                        return return_v;
                    }


                    string
                    f_25069_5467_5481(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5467, 5481);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_5529_5546(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Title;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5529, 5546);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_5593_5616(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5593, 5616);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_5661_5688(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5661, 5688);
                        return return_v;
                    }


                    string
                    f_25069_5778_5801(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.HelpLinkUri;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5778, 5801);
                        return return_v;
                    }


                    string
                    f_25069_5872_5892(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5872, 5892);
                        return return_v;
                    }


                    bool
                    f_25069_5943_5973(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.IsEnabledByDefault;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 5943, 5973);
                        return return_v;
                    }


                    string
                    f_25069_6062_6081()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6062, 6081);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_6102_6124(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6102, 6124);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_6102_6148(System.Collections.Generic.IEnumerable<string>
                    source, System.Func<string, string>
                    selector)
                    {
                        var return_v = source.Select<string, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 6102, 6148);
                        return return_v;
                    }


                    string
                    f_25069_6044_6149(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = String.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 6044, 6149);
                        return return_v;
                    }


                    string
                    f_25069_6210_6224(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6210, 6224);
                        return return_v;
                    }


                    string
                    f_25069_6260_6274(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6260, 6274);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_6322_6339(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Title;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6322, 6339);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_6386_6409(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6386, 6409);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_6454_6481(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6454, 6481);
                        return return_v;
                    }


                    string
                    f_25069_6571_6594(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.HelpLinkUri;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6571, 6594);
                        return return_v;
                    }


                    string
                    f_25069_6665_6685(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6665, 6685);
                        return return_v;
                    }


                    bool
                    f_25069_6736_6766(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.IsEnabledByDefault;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6736, 6766);
                        return return_v;
                    }


                    string
                    f_25069_6855_6874()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6855, 6874);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_6895_6917(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 6895, 6917);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_6895_6941(System.Collections.Generic.IEnumerable<string>
                    source, System.Func<string, string>
                    selector)
                    {
                        var return_v = source.Select<string, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 6895, 6941);
                        return return_v;
                    }


                    string
                    f_25069_6837_6942(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = String.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 6837, 6942);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 3673, 7027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 3673, 7027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static string GetExpectedV1ErrorLogWithSuppressionResultsAndRulesText(Compilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 7043, 10498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 7177, 7220);

                    var
                    tree = f_25069_7188_7219(f_25069_7188_7211(compilation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 7238, 7264);

                    var
                    root = f_25069_7249_7263(tree)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 7282, 7338);

                    var
                    expectedLineSpan = f_25069_7305_7337(f_25069_7305_7323(root))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 7356, 7400);

                    var
                    filePath = f_25069_7371_7399(f_25069_7385_7398(tree))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 7420, 10483);

                    return @"
      ""results"": [
        {
          ""ruleId"": """ + f_25069_7492_7506(Descriptor1) + @""",
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 7544, 7599) || ((f_25069_7544_7571(Descriptor1) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 7602, 7609)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 7612, 7621))) ? "error" : "warning") + @""",
          ""message"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_7661_7686(Descriptor1)).ToString(), 25069, 7661, 7686) + @""",
          ""suppressionStates"": [
            ""suppressedInSource""
          ],
          ""locations"": [
            {
              ""resultFile"": {
                ""uri"": """ + filePath + @""",
                ""region"": {
                  ""startLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Line + 1)).ToString(), 25069, 7975, 8020) + @",
                  ""startColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Character + 1)).ToString(), 25069, 8067, 8117) + @",
                  ""endLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Line + 1)).ToString(), 25069, 8160, 8203) + @",
                  ""endColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Character + 1)).ToString(), 25069, 8248, 8296) + @"
                }
              }
            }
          ],
          ""properties"": {
            ""warningLevel"": 1," + f_25069_8433_8463() + @"
          }
        },
        {
          ""ruleId"": """ + f_25069_8534_8548(Descriptor2) + @""",
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 8586, 8641) || ((f_25069_8586_8613(Descriptor2) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 8644, 8651)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 8654, 8663))) ? "error" : "warning") + @""",
          ""message"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_8703_8728(Descriptor2)).ToString(), 25069, 8703, 8728) + @""",
          ""properties"": {" +
                    f_25069_8783_8813() + @"
          }
        }
      ],
      ""rules"": {
        """ + f_25069_8888_8902(Descriptor1) + @""": {
          ""id"": """ + f_25069_8938_8952(Descriptor1) + @""",
          ""shortDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_9000_9017(Descriptor1)).ToString(), 25069, 9000, 9017) + @""",
          ""fullDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_9064_9087(Descriptor1)).ToString(), 25069, 9064, 9087) + @""",
          ""defaultLevel"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 9132, 9187) || ((f_25069_9132_9159(Descriptor1) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 9190, 9197)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 9200, 9209))) ? "error" : "warning") + @""",
          ""helpUri"": """ + f_25069_9249_9272(Descriptor1) + @""",
          ""properties"": {
            ""category"": """ + f_25069_9343_9363(Descriptor1) + @""",
            ""isEnabledByDefault"": " + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 9414, 9444) || ((f_25069_9414_9444(Descriptor2) && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 9447, 9453)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 9456, 9463))) ? "true" : "false") + @",
            ""tags"": [
              " + f_25069_9515_9620("," + f_25069_9533_9552() + "              ", f_25069_9573_9619(f_25069_9573_9595(Descriptor1), s => $"\"{s}\"")) + @"
            ]
          }
        },
        """ + f_25069_9681_9695(Descriptor2) + @""": {
          ""id"": """ + f_25069_9731_9745(Descriptor2) + @""",
          ""shortDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_9793_9810(Descriptor2)).ToString(), 25069, 9793, 9810) + @""",
          ""fullDescription"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_9857_9880(Descriptor2)).ToString(), 25069, 9857, 9880) + @""",
          ""defaultLevel"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 9925, 9980) || ((f_25069_9925_9952(Descriptor2) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 9983, 9990)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 9993, 10002))) ? "error" : "warning") + @""",
          ""helpUri"": """ + f_25069_10042_10065(Descriptor2) + @""",
          ""properties"": {
            ""category"": """ + f_25069_10136_10156(Descriptor2) + @""",
            ""isEnabledByDefault"": " + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 10207, 10237) || ((f_25069_10207_10237(Descriptor2) && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 10240, 10246)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 10249, 10256))) ? "true" : "false") + @",
            ""tags"": [
              " + f_25069_10308_10413("," + f_25069_10326_10345() + "              ", f_25069_10366_10412(f_25069_10366_10388(Descriptor2), s => $"\"{s}\"")) + @"
            ]
          }
        }
      }
    }
  ]
}";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 7043, 10498);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_25069_7188_7211(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.SyntaxTrees;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 7188, 7211);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_25069_7188_7219(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    source)
                    {
                        var return_v = source.First<Microsoft.CodeAnalysis.SyntaxTree>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 7188, 7219);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25069_7249_7263(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 7249, 7263);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_25069_7305_7323(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 7305, 7323);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FileLinePositionSpan
                    f_25069_7305_7337(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.GetLineSpan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 7305, 7337);
                        return return_v;
                    }


                    string
                    f_25069_7385_7398(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 7385, 7398);
                        return return_v;
                    }


                    string
                    f_25069_7371_7399(string
                    path)
                    {
                        var return_v = GetUriForPath(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 7371, 7399);
                        return return_v;
                    }


                    string
                    f_25069_7492_7506(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 7492, 7506);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_7544_7571(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 7544, 7571);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_7661_7686(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 7661, 7686);
                        return return_v;
                    }


                    string
                    f_25069_8433_8463()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 8433, 8463);
                        return return_v;
                    }


                    string
                    f_25069_8534_8548(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 8534, 8548);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_8586_8613(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 8586, 8613);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_8703_8728(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 8703, 8728);
                        return return_v;
                    }


                    string
                    f_25069_8783_8813()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 8783, 8813);
                        return return_v;
                    }


                    string
                    f_25069_8888_8902(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 8888, 8902);
                        return return_v;
                    }


                    string
                    f_25069_8938_8952(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 8938, 8952);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_9000_9017(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Title;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9000, 9017);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_9064_9087(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9064, 9087);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_9132_9159(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9132, 9159);
                        return return_v;
                    }


                    string
                    f_25069_9249_9272(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.HelpLinkUri;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9249, 9272);
                        return return_v;
                    }


                    string
                    f_25069_9343_9363(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9343, 9363);
                        return return_v;
                    }


                    bool
                    f_25069_9414_9444(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.IsEnabledByDefault;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9414, 9444);
                        return return_v;
                    }


                    string
                    f_25069_9533_9552()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9533, 9552);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_9573_9595(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9573, 9595);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_9573_9619(System.Collections.Generic.IEnumerable<string>
                    source, System.Func<string, string>
                    selector)
                    {
                        var return_v = source.Select<string, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 9573, 9619);
                        return return_v;
                    }


                    string
                    f_25069_9515_9620(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = String.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 9515, 9620);
                        return return_v;
                    }


                    string
                    f_25069_9681_9695(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9681, 9695);
                        return return_v;
                    }


                    string
                    f_25069_9731_9745(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9731, 9745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_9793_9810(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Title;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9793, 9810);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_9857_9880(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9857, 9880);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_9925_9952(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 9925, 9952);
                        return return_v;
                    }


                    string
                    f_25069_10042_10065(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.HelpLinkUri;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10042, 10065);
                        return return_v;
                    }


                    string
                    f_25069_10136_10156(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10136, 10156);
                        return return_v;
                    }


                    bool
                    f_25069_10207_10237(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.IsEnabledByDefault;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10207, 10237);
                        return return_v;
                    }


                    string
                    f_25069_10326_10345()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10326, 10345);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_10366_10388(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10366, 10388);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_10366_10412(System.Collections.Generic.IEnumerable<string>
                    source, System.Func<string, string>
                    selector)
                    {
                        var return_v = source.Select<string, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 10366, 10412);
                        return return_v;
                    }


                    string
                    f_25069_10308_10413(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = String.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 10308, 10413);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 7043, 10498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 7043, 10498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static string GetExpectedV2ErrorLogResultsText(Compilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 10514, 12431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 10625, 10668);

                    var
                    tree = f_25069_10636_10667(f_25069_10636_10659(compilation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 10686, 10712);

                    var
                    root = f_25069_10697_10711(tree)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 10730, 10786);

                    var
                    expectedLineSpan = f_25069_10753_10785(f_25069_10753_10771(root))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 10804, 10848);

                    var
                    filePath = f_25069_10819_10847(f_25069_10833_10846(tree))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 10868, 12416);

                    return
                    @"      ""results"": [
        {
          ""ruleId"": """ + f_25069_10939_10953(Descriptor1) + @""",
          ""ruleIndex"": 0,
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 11020, 11075) || ((f_25069_11020_11047(Descriptor1) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 11078, 11085)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 11088, 11097))) ? "error" : "warning") + @""",
          ""message"": {
            ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_11162_11187(Descriptor1)).ToString(), 25069, 11162, 11187) + @"""
          },
          ""locations"": [
            {
              ""physicalLocation"": {
                ""artifactLocation"": {
                  ""uri"": """ + filePath + @"""
                },
                ""region"": {
                  ""startLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Line + 1)).ToString(), 25069, 11471, 11516) + @",
                  ""startColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Character + 1)).ToString(), 25069, 11563, 11613) + @",
                  ""endLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Line + 1)).ToString(), 25069, 11656, 11699) + @",
                  ""endColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Character + 1)).ToString(), 25069, 11744, 11792) + @"
                }
              }
            }
          ],
          ""properties"": {
            ""warningLevel"": 1," + f_25069_11929_11959() + @"
          }
        },
        {
          ""ruleId"": """ + f_25069_12030_12044(Descriptor2) + @""",
          ""ruleIndex"": 1,
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 12111, 12166) || ((f_25069_12111_12138(Descriptor2) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 12169, 12176)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 12179, 12188))) ? "error" : "warning") + @""",
          ""message"": {
            ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_12253_12278(Descriptor2)).ToString(), 25069, 12253, 12278) + @"""
          },
          ""properties"": {" +
                    f_25069_12346_12376() + @"
          }
        }
      ]";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 10514, 12431);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_25069_10636_10659(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.SyntaxTrees;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10636, 10659);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_25069_10636_10667(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    source)
                    {
                        var return_v = source.First<Microsoft.CodeAnalysis.SyntaxTree>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 10636, 10667);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25069_10697_10711(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 10697, 10711);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_25069_10753_10771(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 10753, 10771);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FileLinePositionSpan
                    f_25069_10753_10785(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.GetLineSpan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 10753, 10785);
                        return return_v;
                    }


                    string
                    f_25069_10833_10846(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10833, 10846);
                        return return_v;
                    }


                    string
                    f_25069_10819_10847(string
                    path)
                    {
                        var return_v = GetUriForPath(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 10819, 10847);
                        return return_v;
                    }


                    string
                    f_25069_10939_10953(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 10939, 10953);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_11020_11047(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 11020, 11047);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_11162_11187(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 11162, 11187);
                        return return_v;
                    }


                    string
                    f_25069_11929_11959()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 11929, 11959);
                        return return_v;
                    }


                    string
                    f_25069_12030_12044(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 12030, 12044);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_12111_12138(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 12111, 12138);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_12253_12278(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 12253, 12278);
                        return return_v;
                    }


                    string
                    f_25069_12346_12376()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 12346, 12376);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 10514, 12431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 10514, 12431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static string GetExpectedV2ErrorLogWithSuppressionResultsText(Compilation compilation, string justification)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 12447, 14621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 12595, 12638);

                    var
                    tree = f_25069_12606_12637(f_25069_12606_12629(compilation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 12656, 12682);

                    var
                    root = f_25069_12667_12681(tree)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 12700, 12756);

                    var
                    expectedLineSpan = f_25069_12723_12755(f_25069_12723_12741(root))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 12774, 12818);

                    var
                    filePath = f_25069_12789_12817(f_25069_12803_12816(tree))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 12838, 14606);

                    return
                    @"      ""results"": [
        {
          ""ruleId"": """ + f_25069_12909_12923(Descriptor1) + @""",
          ""ruleIndex"": 0,
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 12990, 13045) || ((f_25069_12990_13017(Descriptor1) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 13048, 13055)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 13058, 13067))) ? "error" : "warning") + @""",
          ""message"": {
            ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_13132_13157(Descriptor1)).ToString(), 25069, 13132, 13157) + @"""
          },
          ""suppressions"": [
            {
              ""kind"": ""inSource""" + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 13267, 13288) || ((justification == null && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 13291, 13293)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 13296, 13363))) ? "" : @",
              ""justification"": """ + (justification) + @"""") + @"
            }
          ],
          ""locations"": [
            {
              ""physicalLocation"": {
                ""artifactLocation"": {
                  ""uri"": """ + filePath + @"""
                },
                ""region"": {
                  ""startLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Line + 1)).ToString(), 25069, 13661, 13706) + @",
                  ""startColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.StartLinePosition.Character + 1)).ToString(), 25069, 13753, 13803) + @",
                  ""endLine"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Line + 1)).ToString(), 25069, 13846, 13889) + @",
                  ""endColumn"": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((expectedLineSpan.EndLinePosition.Character + 1)).ToString(), 25069, 13934, 13982) + @"
                }
              }
            }
          ],
          ""properties"": {
            ""warningLevel"": 1," + f_25069_14119_14149() + @"
          }
        },
        {
          ""ruleId"": """ + f_25069_14220_14234(Descriptor2) + @""",
          ""ruleIndex"": 1,
          ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 14301, 14356) || ((f_25069_14301_14328(Descriptor2) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 14359, 14366)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 14369, 14378))) ? "error" : "warning") + @""",
          ""message"": {
            ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_14443_14468(Descriptor2)).ToString(), 25069, 14443, 14468) + @"""
          },
          ""properties"": {" +
                    f_25069_14536_14566() + @"
          }
        }
      ]";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 12447, 14621);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_25069_12606_12629(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.SyntaxTrees;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 12606, 12629);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_25069_12606_12637(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    source)
                    {
                        var return_v = source.First<Microsoft.CodeAnalysis.SyntaxTree>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 12606, 12637);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25069_12667_12681(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 12667, 12681);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_25069_12723_12741(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 12723, 12741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FileLinePositionSpan
                    f_25069_12723_12755(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.GetLineSpan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 12723, 12755);
                        return return_v;
                    }


                    string
                    f_25069_12803_12816(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 12803, 12816);
                        return return_v;
                    }


                    string
                    f_25069_12789_12817(string
                    path)
                    {
                        var return_v = GetUriForPath(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 12789, 12817);
                        return return_v;
                    }


                    string
                    f_25069_12909_12923(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 12909, 12923);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_12990_13017(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 12990, 13017);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_13132_13157(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 13132, 13157);
                        return return_v;
                    }


                    string
                    f_25069_14119_14149()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 14119, 14149);
                        return return_v;
                    }


                    string
                    f_25069_14220_14234(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 14220, 14234);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_14301_14328(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 14301, 14328);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_14443_14468(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 14443, 14468);
                        return return_v;
                    }


                    string
                    f_25069_14536_14566()
                    {
                        var return_v = GetExpectedPropertiesMapText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 14536, 14566);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 12447, 14621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 12447, 14621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static string GetExpectedV2ErrorLogRulesText()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 14637, 16338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 14723, 16323);

                    return
                    @"          ""rules"": [
            {
              ""id"": """ + f_25069_14800_14814(Descriptor1) + @""",
              ""shortDescription"": {
                ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_14895_14912(Descriptor1)).ToString(), 25069, 14895, 14912) + @"""
              },
              ""fullDescription"": {
                ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_15009_15032(Descriptor1)).ToString(), 25069, 15009, 15032) + @"""
              },
              ""helpUri"": """ + f_25069_15092_15115(Descriptor1) + @""",
              ""properties"": {
                ""category"": """ + f_25069_15194_15214(Descriptor1) + @""",
                ""tags"": [
                  " + f_25069_15275_15384("," + f_25069_15293_15312() + "                  ", f_25069_15337_15383(f_25069_15337_15359(Descriptor1), s => $"\"{s}\"")) + @"
                ]
              }
            },
            {
              ""id"": """ + f_25069_15486_15500(Descriptor2) + @""",
              ""shortDescription"": {
                ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_15581_15598(Descriptor2)).ToString(), 25069, 15581, 15598) + @"""
              },
              ""fullDescription"": {
                ""text"": """ + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25069_15695_15718(Descriptor2)).ToString(), 25069, 15695, 15718) + @"""
              },
              ""defaultConfiguration"": {
                ""level"": """ + ((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 15822, 15877) || ((f_25069_15822_15849(Descriptor2) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 15880, 15887)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 15890, 15899))) ? "error" : "warning") + @"""
              },
              ""helpUri"": """ + f_25069_15960_15983(Descriptor2) + @""",
              ""properties"": {
                ""category"": """ + f_25069_16062_16082(Descriptor2) + @""",
                ""tags"": [
                  " + f_25069_16143_16252("," + f_25069_16161_16180() + "                  ", f_25069_16205_16251(f_25069_16205_16227(Descriptor2), s => $"\"{s}\"")) + @"
                ]
              }
            }
          ]";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 14637, 16338);

                    string
                    f_25069_14800_14814(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 14800, 14814);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_14895_14912(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Title;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 14895, 14912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_15009_15032(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15009, 15032);
                        return return_v;
                    }


                    string
                    f_25069_15092_15115(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.HelpLinkUri;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15092, 15115);
                        return return_v;
                    }


                    string
                    f_25069_15194_15214(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15194, 15214);
                        return return_v;
                    }


                    string
                    f_25069_15293_15312()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15293, 15312);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_15337_15359(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15337, 15359);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_15337_15383(System.Collections.Generic.IEnumerable<string>
                    source, System.Func<string, string>
                    selector)
                    {
                        var return_v = source.Select<string, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 15337, 15383);
                        return return_v;
                    }


                    string
                    f_25069_15275_15384(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = String.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 15275, 15384);
                        return return_v;
                    }


                    string
                    f_25069_15486_15500(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15486, 15500);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_15581_15598(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Title;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15581, 15598);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_25069_15695_15718(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15695, 15718);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_25069_15822_15849(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15822, 15849);
                        return return_v;
                    }


                    string
                    f_25069_15960_15983(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.HelpLinkUri;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 15960, 15983);
                        return return_v;
                    }


                    string
                    f_25069_16062_16082(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 16062, 16082);
                        return return_v;
                    }


                    string
                    f_25069_16161_16180()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 16161, 16180);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_16205_16227(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 16205, 16227);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_25069_16205_16251(System.Collections.Generic.IEnumerable<string>
                    source, System.Func<string, string>
                    selector)
                    {
                        var return_v = source.Select<string, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 16205, 16251);
                        return return_v;
                    }


                    string
                    f_25069_16143_16252(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = String.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 16143, 16252);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 14637, 16338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 14637, 16338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static string GetUriForPath(string path)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 16354, 16643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 16434, 16486);

                    var
                    uri = f_25069_16444_16485(path, UriKind.RelativeOrAbsolute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 16504, 16628);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25069, 16511, 16528) || ((f_25069_16511_16528(uri) && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 16552, 16567)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 16591, 16627))) ? f_25069_16552_16567(uri) : f_25069_16591_16627(f_25069_16612_16626(uri));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 16354, 16643);

                    System.Uri
                    f_25069_16444_16485(string
                    uriString, System.UriKind
                    uriKind)
                    {
                        var return_v = new System.Uri(uriString, uriKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 16444, 16485);
                        return return_v;
                    }


                    bool
                    f_25069_16511_16528(System.Uri
                    this_param)
                    {
                        var return_v = this_param.IsAbsoluteUri
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 16511, 16528);
                        return return_v;
                    }


                    string
                    f_25069_16552_16567(System.Uri
                    this_param)
                    {
                        var return_v = this_param.AbsoluteUri
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 16552, 16567);
                        return return_v;
                    }


                    string
                    f_25069_16612_16626(System.Uri
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 16612, 16626);
                        return return_v;
                    }


                    string?
                    f_25069_16591_16627(string
                    value)
                    {
                        var return_v = WebUtility.UrlEncode(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 16591, 16627);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 16354, 16643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 16354, 16643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AnalyzerForErrorLogTest()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 796, 16654);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 796, 16654);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 796, 16654);
            }


            static AnalyzerForErrorLogTest()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 796, 16654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 1001, 1415);
                Descriptor1 = f_25069_1015_1415("ID1", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true, description: "Description1", helpLinkUri: "HelpLink1", customTags: new[] { "1_CustomTag1", "1_CustomTag2" }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 1476, 1888);
                Descriptor2 = f_25069_1490_1888("ID2", "Title2", "Message2", "Category2", defaultSeverity: DiagnosticSeverity.Error, isEnabledByDefault: true, description: "Description2", helpLinkUri: "HelpLink2", customTags: new[] { "2_CustomTag1", "2_CustomTag2" }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 1965, 2098);
                s_properties = f_25069_1997_2098(new Dictionary<string, string> { { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Key1", 25069, 1997, 2074), "Value1" }, { "Key2", "Value2" } }); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 796, 16654);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 796, 16654);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 796, 16654);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_1015_1415(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, string
            description, string
            helpLinkUri, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, description: description, helpLinkUri: helpLinkUri, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 1015, 1415);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_1490_1888(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, string
            description, string
            helpLinkUri, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, description: description, helpLinkUri: helpLinkUri, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 1490, 1888);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableDictionary<string, string>
            f_25069_1997_2098(System.Collections.Generic.Dictionary<string, string>
            source)
            {
                var return_v = source.ToImmutableDictionary<string, string>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 1997, 2098);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class NotConfigurableDiagnosticAnalyzer : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor EnabledRule;

            public static readonly DiagnosticDescriptor DisabledRule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 17715, 17834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 17759, 17815);

                        return f_25069_17766_17814(EnabledRule, DisabledRule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 17715, 17834);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25069_17766_17814(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item2)
                        {
                            var return_v = ImmutableArray.Create(item1, item2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 17766, 17814);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 17609, 17849);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 17609, 17849);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 17865, 18387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 17954, 18372);

                    f_25069_17954_18371(context, compilationContext =>
                    {
                    // Report enabled diagnostic.
                    compilationContext.ReportDiagnostic(Diagnostic.Create(EnabledRule, Location.None));

                    // Try to report disabled diagnostic.
                    compilationContext.ReportDiagnostic(Diagnostic.Create(DisabledRule, Location.None));
                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 17865, 18387);

                    int
                    f_25069_17954_18371(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 17954, 18371);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 17865, 18387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 17865, 18387);
                }
            }

            public NotConfigurableDiagnosticAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 16666, 18398);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 16666, 18398);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 16666, 18398);
            }


            static NotConfigurableDiagnosticAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 16666, 18398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 16881, 17205);
                EnabledRule = f_25069_16895_17205("ID1", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true, customTags: WellKnownDiagnosticTags.NotConfigurable); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 17266, 17592);
                DisabledRule = f_25069_17281_17592("ID2", "Title2", "Message2", "Category2", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: false, customTags: WellKnownDiagnosticTags.NotConfigurable); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 16666, 18398);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 16666, 18398);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 16666, 18398);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_16895_17205(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 16895, 17205);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_17281_17592(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 17281, 17592);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class CodeBlockActionAnalyzer : DiagnosticAnalyzer
        {
            private readonly bool _onlyStatelessAction;

            public CodeBlockActionAnalyzer(bool onlyStatelessAction = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 18630, 18785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 18593, 18613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 18727, 18770);

                    _onlyStatelessAction = onlyStatelessAction;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 18630, 18785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 18630, 18785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 18630, 18785);
                }
            }

            public static readonly DiagnosticDescriptor CodeBlockTopLevelRule;

            public static readonly DiagnosticDescriptor CodeBlockPerCompilationRule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 19667, 19811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 19711, 19792);

                        return f_25069_19718_19791(CodeBlockTopLevelRule, CodeBlockPerCompilationRule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 19667, 19811);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25069_19718_19791(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item2)
                        {
                            var return_v = ImmutableArray.Create(item1, item2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 19718, 19791);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 19561, 19826);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 19561, 19826);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 19842, 20775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 19931, 20200);

                    f_25069_19931_20199(context, codeBlockContext =>
                    {
                        codeBlockContext.ReportDiagnostic(Diagnostic.Create(CodeBlockTopLevelRule, codeBlockContext.OwningSymbol.Locations[0], codeBlockContext.OwningSymbol.Name));
                    });

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 20220, 20760) || true) && (!_onlyStatelessAction)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 20220, 20760);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 20287, 20741);

                        f_25069_20287_20740(context, compilationStartContext =>
                        {
                            compilationStartContext.RegisterCodeBlockAction(codeBlockContext =>
                            {
                                codeBlockContext.ReportDiagnostic(Diagnostic.Create(CodeBlockPerCompilationRule, codeBlockContext.OwningSymbol.Locations[0], codeBlockContext.OwningSymbol.Name));
                            });
                        });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 20220, 20760);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 19842, 20775);

                    int
                    f_25069_19931_20199(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                    action)
                    {
                        this_param.RegisterCodeBlockAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 19931, 20199);
                        return 0;
                    }


                    int
                    f_25069_20287_20740(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 20287, 20740);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 19842, 20775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 19842, 20775);
                }
            }

            static CodeBlockActionAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 18410, 20786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 18845, 19155);
                CodeBlockTopLevelRule = f_25069_18869_19155("CodeBlockTopLevelRuleId", "CodeBlockTopLevelRuleTitle", "CodeBlock : {0}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 19216, 19544);
                CodeBlockPerCompilationRule = f_25069_19246_19544("CodeBlockPerCompilationRuleId", "CodeBlockPerCompilationRuleTitle", "CodeBlock : {0}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 18410, 20786);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 18410, 20786);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 18410, 20786);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_18869_19155(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 18869, 19155);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_19246_19544(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 19246, 19544);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp)]
        public class CSharpCodeBlockObjectCreationAnalyzer : CodeBlockObjectCreationAnalyzer<SyntaxKind>
        {
            protected override SyntaxKind ObjectCreationExpressionKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 21030, 21068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 21033, 21068);
                        return SyntaxKind.ObjectCreationExpression; DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 21030, 21068);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 21030, 21068);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 21030, 21068);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public CSharpCodeBlockObjectCreationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 20798, 21080);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 20798, 21080);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 20798, 21080);
            }


            static CSharpCodeBlockObjectCreationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 20798, 21080);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 20798, 21080);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 20798, 21080);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 20798, 21080);
        }
        [DiagnosticAnalyzer(LanguageNames.VisualBasic)]
        public class VisualBasicCodeBlockObjectCreationAnalyzer : CodeBlockObjectCreationAnalyzer<VisualBasic.SyntaxKind>
        {
            protected override VisualBasic.SyntaxKind ObjectCreationExpressionKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 21358, 21408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 21361, 21408);
                        return VisualBasic.SyntaxKind.ObjectCreationExpression; DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 21358, 21408);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 21358, 21408);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 21358, 21408);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public VisualBasicCodeBlockObjectCreationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 21092, 21420);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 21092, 21420);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 21092, 21420);
            }


            static VisualBasicCodeBlockObjectCreationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 21092, 21420);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 21092, 21420);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 21092, 21420);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 21092, 21420);
        }
        public abstract class CodeBlockObjectCreationAnalyzer<TLanguageKindEnum> : DiagnosticAnalyzer
                    where TLanguageKindEnum : struct
        {
            public static readonly DiagnosticDescriptor DiagnosticDescriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 21990, 22036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 21993, 22036);
                        return f_25069_21993_22036(DiagnosticDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 21990, 22036);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 21990, 22036);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 21990, 22036);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected abstract TLanguageKindEnum ObjectCreationExpressionKind { get; }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 22141, 22693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 22230, 22678);

                    f_25069_22230_22677(context, codeBlockStartContext =>
                    {
                        codeBlockStartContext.RegisterSyntaxNodeAction(syntaxNodeContext =>
                        {
                            syntaxNodeContext.ReportDiagnostic(Diagnostic.Create(DiagnosticDescriptor, syntaxNodeContext.Node.GetLocation()));
                        },
                        ObjectCreationExpressionKind);
                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 22141, 22693);

                    int
                    f_25069_22230_22677(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                    action)
                    {
                        this_param.RegisterCodeBlockStartAction<TLanguageKindEnum>(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 22230, 22677);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 22141, 22693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 22141, 22693);
                }
            }

            public CodeBlockObjectCreationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 21432, 22704);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 21432, 22704);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 21432, 22704);
            }


            static CodeBlockObjectCreationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 21432, 22704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 21640, 21899);
                DiagnosticDescriptor = f_25069_21663_21899("Id", "Title", "Message", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 21432, 22704);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 21432, 22704);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 21432, 22704);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_21663_21899(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 21663, 21899);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_21993_22036(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 21993, 22036);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp)]
        public class CSharpGenericNameAnalyzer : DiagnosticAnalyzer
        {
            public const string
            DiagnosticId = nameof(DiagnosticId)
            ;

            public const string
            Title = nameof(Title)
            ;

            public const string
            Message = nameof(Message)
            ;

            public const string
            Category = nameof(Category)
            ;

            public const DiagnosticSeverity
            Severity = DiagnosticSeverity.Warning
            ;

            internal static DiagnosticDescriptor Rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 23480, 23528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 23501, 23528);
                        return f_25069_23501_23528(Rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 23480, 23528);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 23480, 23528);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 23480, 23528);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 23545, 23719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 23634, 23704);

                    f_25069_23634_23703(context, AnalyzeNode, SyntaxKind.GenericName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 23545, 23719);

                    int
                    f_25069_23634_23703(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                    action, params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
                    syntaxKinds)
                    {
                        this_param.RegisterSyntaxNodeAction<Microsoft.CodeAnalysis.CSharp.SyntaxKind>(action, syntaxKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 23634, 23703);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 23545, 23719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 23545, 23719);
                }
            }

            private void AnalyzeNode(SyntaxNodeAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 23735, 23920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 23827, 23905);

                    context.ReportDiagnostic(f_25069_23852_23903(Rule, f_25069_23876_23902(context.Node)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 23735, 23920);

                    Microsoft.CodeAnalysis.Location
                    f_25069_23876_23902(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 23876, 23902);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_23852_23903(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 23852, 23903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 23735, 23920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 23735, 23920);
                }
            }

            public CSharpGenericNameAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 22716, 23931);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 22716, 23931);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 22716, 23931);
            }


            static CSharpGenericNameAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 22716, 23931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 22872, 22907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 22942, 22963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 22998, 23023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 23058, 23085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 23132, 23169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 23223, 23389);
                Rule = f_25069_23247_23389(DiagnosticId, Title, Message, Category, Severity, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 22716, 23931);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 22716, 23931);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 22716, 23931);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_23247_23389(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 23247, 23389);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_23501_23528(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 23501, 23528);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp)]
        public class CSharpNamespaceDeclarationAnalyzer : AbstractNamespaceDeclarationAnalyzer<SyntaxKind>
        {
            protected override SyntaxKind NamespaceDeclarationSyntaxKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 24179, 24213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 24182, 24213);
                        return SyntaxKind.NamespaceDeclaration; DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 24179, 24213);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 24179, 24213);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 24179, 24213);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public CSharpNamespaceDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 23943, 24225);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 23943, 24225);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 23943, 24225);
            }


            static CSharpNamespaceDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 23943, 24225);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 23943, 24225);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 23943, 24225);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 23943, 24225);
        }
        [DiagnosticAnalyzer(LanguageNames.VisualBasic)]
        public class VisualBasicNamespaceDeclarationAnalyzer : AbstractNamespaceDeclarationAnalyzer<VisualBasic.SyntaxKind>
        {
            protected override VisualBasic.SyntaxKind NamespaceDeclarationSyntaxKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 24507, 24551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 24510, 24551);
                        return VisualBasic.SyntaxKind.NamespaceStatement; DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 24507, 24551);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 24507, 24551);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 24507, 24551);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public VisualBasicNamespaceDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 24237, 24563);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 24237, 24563);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 24237, 24563);
            }


            static VisualBasicNamespaceDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 24237, 24563);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 24237, 24563);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 24237, 24563);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 24237, 24563);
        }
        public abstract class AbstractNamespaceDeclarationAnalyzer<TLanguageKindEnum> : DiagnosticAnalyzer
                    where TLanguageKindEnum : struct
        {
            public const string
            DiagnosticId = nameof(DiagnosticId)
            ;

            public const string
            Title = nameof(Title)
            ;

            public const string
            Message = nameof(Message)
            ;

            public const string
            Category = nameof(Category)
            ;

            public const DiagnosticSeverity
            Severity = DiagnosticSeverity.Warning
            ;

            internal static DiagnosticDescriptor Rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 25372, 25420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 25393, 25420);
                        return f_25069_25393_25420(Rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 25372, 25420);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 25372, 25420);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 25372, 25420);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected abstract TLanguageKindEnum NamespaceDeclarationSyntaxKind { get; }

            public override void Initialize(AnalysisContext context)
            {
                context.RegisterSyntaxNodeAction(AnalyzeNode, NamespaceDeclarationSyntaxKind);
            }

            private void AnalyzeNode(SyntaxNodeAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 25725, 25910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 25817, 25895);

                    context.ReportDiagnostic(f_25069_25842_25893(Rule, f_25069_25866_25892(context.Node)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 25725, 25910);

                    Microsoft.CodeAnalysis.Location
                    f_25069_25866_25892(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 25866, 25892);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_25842_25893(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 25842, 25893);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 25725, 25910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 25725, 25910);
                }
            }

            public AbstractNamespaceDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 24575, 25921);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 24575, 25921);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 24575, 25921);
            }


            static AbstractNamespaceDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 24575, 25921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 24764, 24799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 24834, 24855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 24890, 24915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 24950, 24977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 25024, 25061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 25115, 25281);
                Rule = f_25069_25139_25281(DiagnosticId, Title, Message, Category, Severity, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 24575, 25921);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 24575, 25921);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 24575, 25921);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_25139_25281(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 25139, 25281);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_25393_25420(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 25393, 25420);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithNoActions : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor DummyRule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 26486, 26521);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 26489, 26521);
                        return f_25069_26489_26521(DummyRule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 26486, 26521);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 26486, 26521);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 26486, 26521);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 26536, 26596);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 26536, 26596);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 26536, 26596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 26536, 26596);
                }
            }

            public AnalyzerWithNoActions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 25933, 26607);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 25933, 26607);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 25933, 26607);
            }


            static AnalyzerWithNoActions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 25933, 26607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 26143, 26395);
                DummyRule = f_25069_26155_26395("ID1", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 25933, 26607);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 25933, 26607);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 25933, 26607);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_26155_26395(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 26155, 26395);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_26489_26521(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 26489, 26521);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithDisabledRules : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 27172, 27202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27175, 27202);
                        return f_25069_27175_27202(Rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 27172, 27202);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 27172, 27202);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 27172, 27202);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 27217, 27382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27306, 27367);

                    f_25069_27306_27366(context, _ => { }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 27217, 27382);

                    int
                    f_25069_27306_27366(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 27306, 27366);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 27217, 27382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 27217, 27382);
                }
            }

            public AnalyzerWithDisabledRules()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 26619, 27393);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 26619, 27393);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 26619, 27393);
            }


            static AnalyzerWithDisabledRules()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 26619, 27393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 26833, 27081);
                Rule = f_25069_26840_27081("ID1", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: false); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 26619, 27393);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 26619, 27393);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 26619, 27393);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_26840_27081(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 26840, 27081);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_27175_27202(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 27175, 27202);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class EnsureNoMergedNamespaceSymbolAnalyzer : DiagnosticAnalyzer
        {
            public const string
            DiagnosticId = nameof(DiagnosticId)
            ;

            public const string
            Title = nameof(Title)
            ;

            public const string
            Message = nameof(Message)
            ;

            public const string
            Category = nameof(Category)
            ;

            public const DiagnosticSeverity
            Severity = DiagnosticSeverity.Warning
            ;

            internal static DiagnosticDescriptor Rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 28215, 28263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 28236, 28263);
                        return f_25069_28236_28263(Rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 28215, 28263);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 28215, 28263);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 28215, 28263);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 28280, 28450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 28369, 28435);

                    f_25069_28369_28434(context, AnalyzeSymbol, SymbolKind.Namespace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 28280, 28450);

                    int
                    f_25069_28369_28434(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 28369, 28434);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 28280, 28450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 28280, 28450);
                }
            }

            private void AnalyzeSymbol(SymbolAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 28466, 28999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 28700, 28742);

                    var
                    ns = (INamespaceSymbol)context.Symbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 28760, 28984) || true) && (f_25069_28764_28785(ns) != f_25069_28789_28817(context.Compilation) || (DynAbs.Tracing.TraceSender.Expression_False(25069, 28764, 28856) || ns.ConstituentNamespaces.Length > 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 28760, 28984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 28898, 28965);

                        context.ReportDiagnostic(f_25069_28923_28963(Rule, f_25069_28947_28959(ns)[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 28760, 28984);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 28466, 28999);

                    Microsoft.CodeAnalysis.IAssemblySymbol
                    f_25069_28764_28785(Microsoft.CodeAnalysis.INamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 28764, 28785);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IAssemblySymbol
                    f_25069_28789_28817(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.Assembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 28789, 28817);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_25069_28947_28959(Microsoft.CodeAnalysis.INamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 28947, 28959);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_28923_28963(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 28923, 28963);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 28466, 28999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 28466, 28999);
                }
            }

            public EnsureNoMergedNamespaceSymbolAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 27405, 29010);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 27405, 29010);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 27405, 29010);
            }


            static EnsureNoMergedNamespaceSymbolAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 27405, 29010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27607, 27642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27677, 27698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27733, 27758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27793, 27820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27867, 27904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 27958, 28124);
                Rule = f_25069_27982_28124(DiagnosticId, Title, Message, Category, Severity, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 27405, 29010);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 27405, 29010);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 27405, 29010);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_27982_28124(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 27982, 28124);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_28236_28263(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 28236, 28263);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithNoSupportedDiagnostics : DiagnosticAnalyzer
        {
            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 29297, 29357);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 29297, 29357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 29297, 29357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 29297, 29357);
                }
            }

            public AnalyzerWithNoSupportedDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 29022, 29368);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 29022, 29368);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 29022, 29368);
            }


            static AnalyzerWithNoSupportedDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 29022, 29368);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 29022, 29368);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 29022, 29368);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 29022, 29368);
        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithInvalidDiagnosticId : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 29951, 29987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 29954, 29987);
                        return f_25069_29954_29987(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 29951, 29987);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 29951, 29987);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 29951, 29987);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 30002, 30266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 30091, 30251);

                    f_25069_30091_30250(context, compilationContext =>
                        compilationContext.ReportDiagnostic(Diagnostic.Create(Descriptor, Location.None)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 30002, 30266);

                    int
                    f_25069_30091_30250(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 30091, 30250);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 30002, 30266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 30002, 30266);
                }
            }

            public AnalyzerWithInvalidDiagnosticId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 29380, 30277);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 29380, 30277);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 29380, 30277);
            }


            static AnalyzerWithInvalidDiagnosticId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 29380, 30277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 29600, 29860);
                Descriptor = f_25069_29613_29860("Invalid ID", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 29380, 30277);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 29380, 30277);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 29380, 30277);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_29613_29860(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 29613, 29860);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_29954_29987(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 29954, 29987);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithNullDescriptor : DiagnosticAnalyzer
        {
            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 30534, 30586);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 30537, 30586);
                        return f_25069_30537_30586(null); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 30534, 30586);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 30534, 30586);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 30534, 30586);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 30601, 30749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 30690, 30734);

                    f_25069_30690_30733(context, _ => { });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 30601, 30749);

                    int
                    f_25069_30690_30733(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 30690, 30733);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 30601, 30749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 30601, 30749);
                }
            }

            public AnalyzerWithNullDescriptor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 30289, 30760);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 30289, 30760);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 30289, 30760);
            }


            static AnalyzerWithNullDescriptor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 30289, 30760);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 30289, 30760);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 30289, 30760);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 30289, 30760);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor?>
            f_25069_30537_30586(Microsoft.CodeAnalysis.DiagnosticDescriptor?
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 30537, 30586);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithCSharpCompilerDiagnosticId : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 31487, 31523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 31490, 31523);
                        return f_25069_31490_31523(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 31487, 31523);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 31487, 31523);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 31487, 31523);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 31538, 31802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 31627, 31787);

                    f_25069_31627_31786(context, compilationContext =>
                        compilationContext.ReportDiagnostic(Diagnostic.Create(Descriptor, Location.None)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 31538, 31802);

                    int
                    f_25069_31627_31786(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 31627, 31786);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 31538, 31802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 31538, 31802);
                }
            }

            public AnalyzerWithCSharpCompilerDiagnosticId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 30772, 31813);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 30772, 31813);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 30772, 31813);
            }


            static AnalyzerWithCSharpCompilerDiagnosticId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 30772, 31813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 30999, 31396);
                Descriptor = f_25069_31012_31396("CS101", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 30772, 31813);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 30772, 31813);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 30772, 31813);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_31012_31396(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 31012, 31396);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_31490_31523(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 31490, 31523);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithBasicCompilerDiagnosticId : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 32539, 32575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 32542, 32575);
                        return f_25069_32542_32575(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 32539, 32575);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 32539, 32575);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 32539, 32575);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 32590, 32854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 32679, 32839);

                    f_25069_32679_32838(context, compilationContext =>
                        compilationContext.ReportDiagnostic(Diagnostic.Create(Descriptor, Location.None)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 32590, 32854);

                    int
                    f_25069_32679_32838(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 32679, 32838);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 32590, 32854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 32590, 32854);
                }
            }

            public AnalyzerWithBasicCompilerDiagnosticId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 31825, 32865);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 31825, 32865);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 31825, 32865);
            }


            static AnalyzerWithBasicCompilerDiagnosticId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 31825, 32865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 32051, 32448);
                Descriptor = f_25069_32064_32448("BC101", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 31825, 32865);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 31825, 32865);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 31825, 32865);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_32064_32448(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 32064, 32448);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_32542_32575(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 32542, 32575);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithInvalidDiagnosticSpan : DiagnosticAnalyzer
        {
            private readonly TextSpan _badSpan;

            public static readonly DiagnosticDescriptor Descriptor;

            public AnalyzerWithInvalidDiagnosticSpan(TextSpan badSpan)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 33418, 33499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 33513, 33559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 33480, 33498);
                    _badSpan = badSpan; DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 33418, 33499);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 33418, 33499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 33418, 33499);
                }
            }

            public Exception ThrownException { get; set; }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 33647, 33683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 33650, 33683);
                        return f_25069_33650_33683(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 33647, 33683);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 33647, 33683);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 33647, 33683);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 33698, 34281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 33787, 34266);

                    f_25069_33787_34265(context, c =>
                    {
                        try
                        {
                            ThrownException = null;
                            c.ReportDiagnostic(Diagnostic.Create(Descriptor, SourceLocation.Create(c.Tree, _badSpan)));
                        }
                        catch (Exception e)
                        {
                            ThrownException = e;
                            throw;
                        }
                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 33698, 34281);

                    int
                    f_25069_33787_34265(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 33787, 34265);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 33698, 34281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 33698, 34281);
                }
            }

            static AnalyzerWithInvalidDiagnosticSpan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 32877, 34292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 33150, 33401);
                Descriptor = f_25069_33163_33401("ID", "Title1", "Message", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 32877, 34292);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 32877, 34292);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 32877, 34292);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_33163_33401(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 33163, 33401);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_33650_33683(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 33650, 33683);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithInvalidDiagnosticLocation : DiagnosticAnalyzer
        {
            private readonly Location _invalidLocation;

            private readonly ActionKind _actionKind;

            public static readonly DiagnosticDescriptor Descriptor;

            public enum ActionKind
            {
                Symbol,
                CodeBlock,
                Operation,
                OperationBlockEnd,
                Compilation,
                CompilationEnd,
                SyntaxTree
            }

            public AnalyzerWithInvalidDiagnosticLocation(SyntaxTree treeInAnotherCompilation, ActionKind actionKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 35191, 35454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 34512, 34528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 34571, 34582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 35328, 35396);

                    _invalidLocation = f_25069_35347_35395(f_25069_35347_35381(treeInAnotherCompilation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 35414, 35439);

                    _actionKind = actionKind;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 35191, 35454);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 35191, 35454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 35191, 35454);
                }
            }

            private void ReportDiagnostic(Action<Diagnostic> addDiagnostic, ActionKind actionKindBeingRun)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 35470, 35823);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 35597, 35808) || true) && (_actionKind == actionKindBeingRun)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 35597, 35808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 35676, 35741);

                        var
                        diagnostic = f_25069_35693_35740(Descriptor, _invalidLocation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 35763, 35789);

                        f_25069_35763_35788(addDiagnostic, diagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 35597, 35808);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 35470, 35823);

                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_35693_35740(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 35693, 35740);
                        return return_v;
                    }


                    int
                    f_25069_35763_35788(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    obj)
                    {
                        this_param.Invoke(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 35763, 35788);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 35470, 35823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 35470, 35823);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 35913, 35949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 35916, 35949);
                        return f_25069_35916_35949(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 35913, 35949);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 35913, 35949);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 35913, 35949);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 35964, 37166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 36053, 36911);

                    f_25069_36053_36910(context, cc =>
                    {
                        cc.RegisterSymbolAction(c => ReportDiagnostic(c.ReportDiagnostic, ActionKind.Symbol), SymbolKind.NamedType);
                        cc.RegisterCodeBlockAction(c => ReportDiagnostic(c.ReportDiagnostic, ActionKind.CodeBlock));
                        cc.RegisterCompilationEndAction(c => ReportDiagnostic(c.ReportDiagnostic, ActionKind.CompilationEnd));

                        cc.RegisterOperationBlockStartAction(oc =>
                        {
                            oc.RegisterOperationAction(c => ReportDiagnostic(c.ReportDiagnostic, ActionKind.Operation), OperationKind.VariableDeclarationGroup);
                            oc.RegisterOperationBlockEndAction(c => ReportDiagnostic(c.ReportDiagnostic, ActionKind.OperationBlockEnd));
                        });
                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 36931, 37030);

                    f_25069_36931_37029(
                                    context, c => ReportDiagnostic(c.ReportDiagnostic, ActionKind.SyntaxTree));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 37048, 37151);

                    f_25069_37048_37150(context, cc => ReportDiagnostic(cc.ReportDiagnostic, ActionKind.Compilation));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 35964, 37166);

                    int
                    f_25069_36053_36910(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 36053, 36910);
                        return 0;
                    }


                    int
                    f_25069_36931_37029(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 36931, 37029);
                        return 0;
                    }


                    int
                    f_25069_37048_37150(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 37048, 37150);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 35964, 37166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 35964, 37166);
                }
            }

            static AnalyzerWithInvalidDiagnosticLocation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 34304, 37177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 34643, 34898);
                Descriptor = f_25069_34656_34898("ID", "Title1", "Message {0}", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 34304, 37177);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 34304, 37177);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 34304, 37177);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_34656_34898(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 34656, 34898);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxNode
            f_25069_35347_35381(Microsoft.CodeAnalysis.SyntaxTree
            this_param)
            {
                var return_v = this_param.GetRoot();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 35347, 35381);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Location
            f_25069_35347_35395(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.GetLocation();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 35347, 35395);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_35916_35949(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 35916, 35949);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithAsyncMethodRegistration : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 37756, 37792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 37759, 37792);
                        return f_25069_37759_37792(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 37756, 37792);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 37756, 37792);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 37756, 37792);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 37807, 37958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 37896, 37943);

                    f_25069_37896_37942(context, AsyncAction);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 37807, 37958);

                    int
                    f_25069_37896_37942(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 37896, 37942);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 37807, 37958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 37807, 37958);
                }
            }

#pragma warning disable VSTHRD100 // Avoid async void methods
            private async void AsyncAction(CompilationAnalysisContext context)
            {
#pragma warning restore VSTHRD100 // Avoid async void methods
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 38037, 38331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 38199, 38270);

                    context.ReportDiagnostic(f_25069_38224_38268(Descriptor, f_25069_38254_38267()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 38288, 38316);

                    await f_25069_38294_38315(true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 38037, 38331);

                    Microsoft.CodeAnalysis.Location
                    f_25069_38254_38267()
                    {
                        var return_v = Location.None;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 38254, 38267);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_38224_38268(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 38224, 38268);
                        return return_v;
                    }


                    System.Threading.Tasks.Task<bool>
                    f_25069_38294_38315(bool
                    result)
                    {
                        var return_v = Task.FromResult(result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 38294, 38315);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 38037, 38331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 38037, 38331);
                }
            }

            public AnalyzerWithAsyncMethodRegistration()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 37189, 38342);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 37189, 38342);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 37189, 38342);
            }


            static AnalyzerWithAsyncMethodRegistration()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 37189, 38342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 37413, 37665);
                Descriptor = f_25069_37426_37665("ID", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 37189, 38342);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 37189, 38342);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 37189, 38342);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_37426_37665(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 37426, 37665);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_37759_37792(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 37759, 37792);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithAsyncLambdaRegistration : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 38921, 38957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 38924, 38957);
                        return f_25069_38924_38957(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 38921, 38957);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 38921, 38957);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 38921, 38957);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 38972, 39477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 39133, 39462);

                    f_25069_39133_39461(
#pragma warning disable VSTHRD101 // Avoid unsupported async delegates
                context, async (compilationContext) =>
#pragma warning restore VSTHRD101 // Avoid unsupported async delegates
                {
                    compilationContext.ReportDiagnostic(Diagnostic.Create(Descriptor, Location.None));
                    await Task.FromResult(true);
                });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 38972, 39477);

                    int
                    f_25069_39133_39461(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 39133, 39461);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 38972, 39477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 38972, 39477);
                }
            }

            public AnalyzerWithAsyncLambdaRegistration()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 38354, 39488);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 38354, 39488);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 38354, 39488);
            }


            static AnalyzerWithAsyncLambdaRegistration()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 38354, 39488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 38578, 38830);
                Descriptor = f_25069_38591_38830("ID", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 38354, 39488);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 38354, 39488);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 38354, 39488);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_38591_38830(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 38591, 38830);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_38924_38957(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 38924, 38957);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerThatThrowsInSupportedDiagnostics : DiagnosticAnalyzer
        {
            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 39759, 39797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 39762, 39797);
                        throw f_25069_39768_39797(); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 39759, 39797);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 39759, 39797);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 39759, 39797);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 39812, 39872);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 39812, 39872);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 39812, 39872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 39812, 39872);
                }
            }

            public AnalyzerThatThrowsInSupportedDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 39500, 39883);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 39500, 39883);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 39500, 39883);
            }


            static AnalyzerThatThrowsInSupportedDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 39500, 39883);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 39500, 39883);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 39500, 39883);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 39500, 39883);

            System.NotImplementedException
            f_25069_39768_39797()
            {
                var return_v = new System.NotImplementedException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 39768, 39797);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerThatThrowsInGetMessage : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 40477, 40507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 40480, 40507);
                        return f_25069_40480_40507(Rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 40477, 40507);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 40477, 40507);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 40477, 40507);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 40522, 40846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 40611, 40831);

                    f_25069_40611_40830(context, symbolContext =>
                    {
                        symbolContext.ReportDiagnostic(Diagnostic.Create(Rule, symbolContext.Symbol.Locations[0]));
                    }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 40522, 40846);

                    int
                    f_25069_40611_40830(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 40611, 40830);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 40522, 40846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 40522, 40846);
                }
            }
            private sealed class MyLocalizableStringThatThrows : LocalizableString
            {
                protected override bool AreEqual(object other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 40965, 41107);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 41052, 41088);

                        return f_25069_41059_41087(this, other);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 40965, 41107);

                        bool
                        f_25069_41059_41087(Microsoft.CodeAnalysis.CommonDiagnosticAnalyzers.AnalyzerThatThrowsInGetMessage.MyLocalizableStringThatThrows
                        objA, object
                        objB)
                        {
                            var return_v = ReferenceEquals((object)objA, objB);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 41059, 41087);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 40965, 41107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 40965, 41107);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                protected override int GetHash()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 41127, 41228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 41200, 41209);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 41127, 41228);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 41127, 41228);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 41127, 41228);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                protected override string GetText(IFormatProvider formatProvider)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 41248, 41409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 41354, 41390);

                        throw f_25069_41360_41389();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 41248, 41409);

                        System.NotImplementedException
                        f_25069_41360_41389()
                        {
                            var return_v = new System.NotImplementedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 41360, 41389);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 41248, 41409);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 41248, 41409);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public MyLocalizableStringThatThrows()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 40862, 41424);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 40862, 41424);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 40862, 41424);
                }


                static MyLocalizableStringThatThrows()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 40862, 41424);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 40862, 41424);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 40862, 41424);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 40862, 41424);
            }

            public AnalyzerThatThrowsInGetMessage()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 39895, 41435);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 39895, 41435);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 39895, 41435);
            }


            static AnalyzerThatThrowsInGetMessage()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 39895, 41435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 40114, 40386);
                Rule = f_25069_40121_40386("ID1", "Title1", f_25069_40215_40250(), "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 39895, 41435);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 39895, 41435);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 39895, 41435);

            static Microsoft.CodeAnalysis.CommonDiagnosticAnalyzers.AnalyzerThatThrowsInGetMessage.MyLocalizableStringThatThrows
            f_25069_40215_40250()
            {
                var return_v = new Microsoft.CodeAnalysis.CommonDiagnosticAnalyzers.AnalyzerThatThrowsInGetMessage.MyLocalizableStringThatThrows();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 40215, 40250);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_40121_40386(string
            id, string
            title, Microsoft.CodeAnalysis.CommonDiagnosticAnalyzers.AnalyzerThatThrowsInGetMessage.MyLocalizableStringThatThrows
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, (Microsoft.CodeAnalysis.LocalizableString)title, (Microsoft.CodeAnalysis.LocalizableString)messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 40121, 40386);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_40480_40507(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 40480, 40507);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerReportingMisformattedDiagnostic : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 42042, 42072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 42045, 42072);
                        return f_25069_42045_42072(Rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 42042, 42072);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 42042, 42072);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 42042, 42072);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 42087, 42531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 42176, 42516);

                    f_25069_42176_42515(context, symbolContext =>
                    {
                    // Report diagnostic with incorrect number of message format arguments.
                    symbolContext.ReportDiagnostic(Diagnostic.Create(Rule, symbolContext.Symbol.Locations[0], symbolContext.Symbol.Name));
                    }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 42087, 42531);

                    int
                    f_25069_42176_42515(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 42176, 42515);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 42087, 42531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 42087, 42531);
                }
            }

            public AnalyzerReportingMisformattedDiagnostic()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 41447, 42542);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 41447, 42542);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 41447, 42542);
            }


            static AnalyzerReportingMisformattedDiagnostic()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 41447, 42542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 41675, 41951);
                Rule = f_25069_41682_41951("ID1", "Title1", "Symbol Name: {0}, Extra argument: {1}", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 41447, 42542);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 41447, 42542);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 41447, 42542);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_41682_41951(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 41682, 41951);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_42045_42072(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 42045, 42072);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class CompilationAnalyzerWithSeverity : DiagnosticAnalyzer
        {
            public const string
            DiagnosticId = "ID1000"
            ;

            public CompilationAnalyzerWithSeverity(
                            DiagnosticSeverity severity,
                            bool configurable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 42781, 43357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 43373, 43420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 42935, 43042);

                    var
                    customTags = (DynAbs.Tracing.TraceSender.Conditional_F1(25069, 42952, 42965) || ((!configurable && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 42968, 43017)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 43020, 43041))) ? new[] { WellKnownDiagnosticTags.NotConfigurable } : f_25069_43020_43041()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 43060, 43342);

                    Descriptor = f_25069_43073_43341(DiagnosticId, "Description1", string.Empty, "Analysis", severity, true, customTags: customTags);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 42781, 43357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 42781, 43357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 42781, 43357);
                }
            }

            public DiagnosticDescriptor Descriptor { get; }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 43510, 43546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 43513, 43546);
                        return f_25069_43513_43546(f_25069_43535_43545()); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 43510, 43546);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 43510, 43546);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 43510, 43546);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 43563, 43721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 43652, 43706);

                    f_25069_43652_43705(context, this.OnCompilation);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 43563, 43721);

                    int
                    f_25069_43652_43705(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 43652, 43705);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 43563, 43721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 43563, 43721);
                }
            }

            private void OnCompilation(CompilationAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 43737, 44117);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 43903, 44102);
                        foreach (var tree in f_25069_43924_43955_I(f_25069_43924_43955(context.Compilation)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 43903, 44102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 43997, 44083);

                            context.ReportDiagnostic(f_25069_44022_44081(f_25069_44040_44050(), f_25069_44052_44080(f_25069_44052_44066(tree))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 43903, 44102);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 200);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 43737, 44117);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_25069_43924_43955(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.SyntaxTrees;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 43924, 43955);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_25069_44040_44050()
                    {
                        var return_v = Descriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 44040, 44050);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25069_44052_44066(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 44052, 44066);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_25069_44052_44080(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 44052, 44080);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_44022_44081(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 44022, 44081);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_25069_43924_43955_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 43924, 43955);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 43737, 44117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 43737, 44117);
                }
            }

            static CompilationAnalyzerWithSeverity()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 42554, 44128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 42743, 42766);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 42554, 44128);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 42554, 44128);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 42554, 44128);

            static string[]
            f_25069_43020_43041()
            {
                var return_v = Array.Empty<string>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 43020, 43041);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_43073_43341(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 43073, 43341);
                return return_v;
            }


            Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_43535_43545()
            {
                var return_v = Descriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 43535, 43545);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_43513_43546(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 43513, 43546);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class ConcurrentAnalyzer : DiagnosticAnalyzer
        {
            private readonly ImmutableHashSet<string> _symbolNames;

            private int _token;

            public static readonly DiagnosticDescriptor Descriptor;

            public ConcurrentAnalyzer(IEnumerable<string> symbolNames)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 45185, 45504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 44797, 44809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 44836, 44842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 45276, 45394);

                    f_25069_45276_45393(f_25069_45288_45314() > 1, "This analyzer is intended to be used only in a concurrent environment.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 45412, 45460);

                    _symbolNames = f_25069_45427_45459(symbolNames);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 45478, 45489);

                    _token = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 45185, 45504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 45185, 45504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 45185, 45504);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 45594, 45630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 45597, 45630);
                        return f_25069_45597_45630(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 45594, 45630);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 45594, 45630);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 45594, 45630);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 45645, 45937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 45734, 45798);

                    f_25069_45734_45797(context, this.OnCompilationStart);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 45886, 45922);

                    f_25069_45886_45921(
                                    // Enable concurrent action callbacks on analyzer.
                                    context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 45645, 45937);

                    int
                    f_25069_45734_45797(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 45734, 45797);
                        return 0;
                    }


                    int
                    f_25069_45886_45921(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param)
                    {
                        this_param.EnableConcurrentExecution();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 45886, 45921);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 45645, 45937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 45645, 45937);
                }
            }

            private void OnCompilationStart(CompilationStartAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 45953, 47622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 46058, 46194);

                    f_25069_46058_46193(f_25069_46070_46113(f_25069_46070_46097(f_25069_46070_46089(context))), "This analyzer is intended to be used only when concurrent build is enabled.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 46214, 46273);

                    var
                    pendingSymbols = f_25069_46235_46272()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 46291, 46559);
                        foreach (var type in f_25069_46312_46364_I(f_25069_46312_46364(f_25069_46312_46347(f_25069_46312_46331(context)))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 46291, 46559);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 46406, 46540) || true) && (f_25069_46410_46442(_symbolNames, f_25069_46432_46441(type)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 46406, 46540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 46492, 46517);

                                f_25069_46492_46516(pendingSymbols, type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 46406, 46540);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 46291, 46559);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 269);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 269);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 46579, 47607);

                    f_25069_46579_47606(
                                    context, symbolContext =>
                                    {
                                        if (!pendingSymbols.Remove((INamedTypeSymbol)symbolContext.Symbol))
                                        {
                                            return;
                                        }

                                        var myToken = Interlocked.Increment(ref _token);
                                        if (myToken == 1)
                                        {
                        // Wait for all symbol callbacks to execute.
                        // This analyzer will deadlock if the driver doesn't attempt concurrent callbacks.
                        while (pendingSymbols.Any())
                                            {
                                                Thread.Sleep(10);
                                            }
                                        }

                    // ok, now report diagnostic on the symbol.
                    var diagnostic = Diagnostic.Create(Descriptor, symbolContext.Symbol.Locations[0], symbolContext.Symbol.Name);
                                        symbolContext.ReportDiagnostic(diagnostic);
                                    }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 45953, 47622);

                    Microsoft.CodeAnalysis.Compilation
                    f_25069_46070_46089(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 46070, 46089);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CompilationOptions
                    f_25069_46070_46097(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 46070, 46097);
                        return return_v;
                    }


                    bool
                    f_25069_46070_46113(Microsoft.CodeAnalysis.CompilationOptions
                    this_param)
                    {
                        var return_v = this_param.ConcurrentBuild;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 46070, 46113);
                        return return_v;
                    }


                    int
                    f_25069_46058_46193(bool
                    condition, string
                    userMessage)
                    {
                        Assert.True(condition, userMessage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 46058, 46193);
                        return 0;
                    }


                    Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.INamedTypeSymbol>
                    f_25069_46235_46272()
                    {
                        var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.INamedTypeSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 46235, 46272);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Compilation
                    f_25069_46312_46331(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 46312, 46331);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceSymbol
                    f_25069_46312_46347(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 46312, 46347);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                    f_25069_46312_46364(Microsoft.CodeAnalysis.INamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 46312, 46364);
                        return return_v;
                    }


                    string
                    f_25069_46432_46441(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 46432, 46441);
                        return return_v;
                    }


                    bool
                    f_25069_46410_46442(System.Collections.Immutable.ImmutableHashSet<string>
                    this_param, string
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 46410, 46442);
                        return return_v;
                    }


                    bool
                    f_25069_46492_46516(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.INamedTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                    value)
                    {
                        var return_v = this_param.Add(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 46492, 46516);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                    f_25069_46312_46364_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 46312, 46364);
                        return return_v;
                    }


                    int
                    f_25069_46579_47606(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 46579, 47606);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 45953, 47622);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 45953, 47622);
                }
            }

            static ConcurrentAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 44599, 47633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 44903, 45168);
                Descriptor = f_25069_44916_45168("ConcurrentAnalyzerId", "Title", "ConcurrentAnalyzerMessage for symbol '{0}'", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 44599, 47633);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 44599, 47633);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 44599, 47633);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_44916_45168(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 44916, 45168);
                return return_v;
            }


            static int
            f_25069_45288_45314()
            {
                var return_v = Environment.ProcessorCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 45288, 45314);
                return return_v;
            }


            static int
            f_25069_45276_45393(bool
            condition, string
            userMessage)
            {
                Assert.True(condition, userMessage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 45276, 45393);
                return 0;
            }


            static System.Collections.Immutable.ImmutableHashSet<string>
            f_25069_45427_45459(System.Collections.Generic.IEnumerable<string>
            source)
            {
                var return_v = source.ToImmutableHashSet<string>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 45427, 45459);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_45597_45630(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 45597, 45630);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class NonConcurrentAnalyzer : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            private const int
            registeredActionCounts = 1000
            ;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 48628, 48664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48631, 48664);
                        return f_25069_48631_48664(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 48628, 48664);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 48628, 48664);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 48628, 48664);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 48679, 49336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48768, 48845);

                    SemaphoreSlim
                    gate = f_25069_48789_48844(initialCount: registeredActionCounts)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48872, 48877);
                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48863, 49321) || true) && (i < registeredActionCounts)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48907, 48910)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 48863, 49321))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 48863, 49321);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48952, 49302);

                            f_25069_48952_49301(context, symbolContext =>
                            {
                                using (gate.DisposableWait(symbolContext.CancellationToken))
                                {
                                    ReportDiagnosticIfActionInvokedConcurrently(gate, symbolContext);
                                }
                            }, SymbolKind.NamedType);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 459);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 459);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 48679, 49336);

                    System.Threading.SemaphoreSlim
                    f_25069_48789_48844(int
                    initialCount)
                    {
                        var return_v = new System.Threading.SemaphoreSlim(initialCount: initialCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 48789, 48844);
                        return return_v;
                    }


                    int
                    f_25069_48952_49301(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 48952, 49301);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 48679, 49336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 48679, 49336);
                }
            }

            private void ReportDiagnosticIfActionInvokedConcurrently(SemaphoreSlim gate, SymbolAnalysisContext symbolContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 49352, 49772);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 49498, 49757) || true) && (f_25069_49502_49519(gate) != registeredActionCounts - 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 49498, 49757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 49591, 49673);

                        var
                        diagnostic = f_25069_49608_49672(Descriptor, f_25069_49638_49668(symbolContext.Symbol)[0])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 49695, 49738);

                        symbolContext.ReportDiagnostic(diagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 49498, 49757);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 49352, 49772);

                    int
                    f_25069_49502_49519(System.Threading.SemaphoreSlim
                    this_param)
                    {
                        var return_v = this_param.CurrentCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 49502, 49519);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_25069_49638_49668(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 49638, 49668);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_49608_49672(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 49608, 49672);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 49352, 49772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 49352, 49772);
                }
            }

            public NonConcurrentAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 47942, 49783);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 47942, 49783);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 47942, 49783);
            }


            static NonConcurrentAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 47942, 49783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48145, 48475);
                Descriptor = f_25069_48158_48475("NonConcurrentAnalyzerId", "Title", "Analyzer driver made concurrent action callbacks, when analyzer didn't register for concurrent execution", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 48508, 48537);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 47942, 49783);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 47942, 49783);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 47942, 49783);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_48158_48475(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 48158, 48475);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_48631_48664(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 48631, 48664);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class OperationAnalyzer : DiagnosticAnalyzer
        {
            private readonly ActionKind _actionKind;

            private readonly bool _verifyGetControlFlowGraph;

            private readonly ConcurrentDictionary<IOperation, (ControlFlowGraph Graph, ISymbol AssociatedSymbol)> _controlFlowGraphMapOpt;

            public static readonly DiagnosticDescriptor Descriptor;

            public enum ActionKind
            {
                Operation,
                OperationInOperationBlockStart,
                OperationBlock,
                OperationBlockEnd
            }

            public OperationAnalyzer(ActionKind actionKind, bool verifyGetControlFlowGraph = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 50748, 51128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 49985, 49996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 50033, 50059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 50176, 50199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 50868, 50893);

                    _actionKind = actionKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 50911, 50966);

                    _verifyGetControlFlowGraph = verifyGetControlFlowGraph;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 50984, 51113);

                    _controlFlowGraphMapOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(25069, 51010, 51035) || ((verifyGetControlFlowGraph && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 51038, 51105)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 51108, 51112))) ? f_25069_51038_51105() : null;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 50748, 51128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 50748, 51128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 50748, 51128);
                }
            }

            public ImmutableArray<(ControlFlowGraph Graph, ISymbol AssociatedSymbol)> GetControlFlowGraphs()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 51144, 51494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 51273, 51313);

                    f_25069_51273_51312(_verifyGetControlFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 51331, 51479);

                    return f_25069_51338_51478(f_25069_51338_51459(f_25069_51338_51368(_controlFlowGraphMapOpt), flowGraphAndSymbol => flowGraphAndSymbol.Graph.OriginalOperation.Syntax.SpanStart));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 51144, 51494);

                    int
                    f_25069_51273_51312(bool
                    condition)
                    {
                        Assert.True(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 51273, 51312);
                        return 0;
                    }


                    System.Collections.Generic.ICollection<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    f_25069_51338_51368(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 51338, 51368);
                        return return_v;
                    }


                    System.Linq.IOrderedEnumerable<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    f_25069_51338_51459(System.Collections.Generic.ICollection<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    source, System.Func<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol), int>
                    keySelector)
                    {
                        var return_v = source.OrderBy<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol), int>(keySelector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 51338, 51459);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    f_25069_51338_51478(System.Linq.IOrderedEnumerable<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    items)
                    {
                        var return_v = items.ToImmutableArray<(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 51338, 51478);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 51144, 51494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 51144, 51494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void ReportDiagnostic(Action<Diagnostic> addDiagnostic, Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 51510, 51754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 51625, 51695);

                    var
                    diagnostic = f_25069_51642_51694(Descriptor, location, _actionKind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 51713, 51739);

                    f_25069_51713_51738(addDiagnostic, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 51510, 51754);

                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_51642_51694(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 51642, 51694);
                        return return_v;
                    }


                    int
                    f_25069_51713_51738(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    obj)
                    {
                        this_param.Invoke(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 51713, 51738);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 51510, 51754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 51510, 51754);
                }
            }

            private void CacheAndVerifyControlFlowGraph(ImmutableArray<IOperation> operationBlocks, Func<IOperation, (ControlFlowGraph Graph, ISymbol AssociatedSymbol)> getControlFlowGraph)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 51770, 53672);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 51980, 53657) || true) && (_verifyGetControlFlowGraph)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 51980, 53657);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 52052, 53638);
                            foreach (var operationBlock in f_25069_52083_52098_I(operationBlocks))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 52052, 53638);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 52148, 52216);

                                var
                                controlFlowGraphAndSymbol = f_25069_52180_52215(getControlFlowGraph, operationBlock)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 52242, 52284);

                                f_25069_52242_52283(controlFlowGraphAndSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 52310, 52408);

                                f_25069_52310_52407(f_25069_52322_52355(operationBlock), f_25069_52357_52406(controlFlowGraphAndSymbol.Graph));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 52436, 52542);

                                f_25069_52436_52541(
                                                        _controlFlowGraphMapOpt, f_25069_52464_52513(controlFlowGraphAndSymbol.Graph), controlFlowGraphAndSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 52644, 52732);

                                f_25069_52644_52731(controlFlowGraphAndSymbol.Graph, f_25069_52689_52724(getControlFlowGraph, operationBlock).Graph);

                                // Verify exceptions for invalid inputs.
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 52886, 52916);

                                    _ = f_25069_52890_52915(getControlFlowGraph, null);
                                }
                                catch (ArgumentNullException ex)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25069, 52969, 53163);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 53058, 53136);

                                    f_25069_53058_53135(f_25069_53071_53122(f_25069_53071_53114("operationBlock")), f_25069_53124_53134(ex));
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(25069, 52969, 53163);
                                }

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 53251, 53313);

                                    _ = f_25069_53255_53312(getControlFlowGraph, f_25069_53275_53311(f_25069_53275_53303(operationBlock)));
                                }
                                catch (ArgumentException ex)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25069, 53366, 53615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 53451, 53588);

                                    f_25069_53451_53587(f_25069_53464_53574(f_25069_53464_53566(f_25069_53486_53547(), "operationBlock")), f_25069_53576_53586(ex));
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(25069, 53366, 53615);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 52052, 53638);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 1587);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 1587);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 51980, 53657);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 51770, 53672);

                    (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)
                    f_25069_52180_52215(System.Func<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52180, 52215);
                        return return_v;
                    }


                    int
                    f_25069_52242_52283((Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)
                    @object)
                    {
                        Assert.NotNull((object)@object);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52242, 52283);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_25069_52322_52355(Microsoft.CodeAnalysis.IOperation
                    operation)
                    {
                        var return_v = operation.GetRootOperation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52322, 52355);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_25069_52357_52406(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    this_param)
                    {
                        var return_v = this_param.OriginalOperation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 52357, 52406);
                        return return_v;
                    }


                    int
                    f_25069_52310_52407(Microsoft.CodeAnalysis.IOperation
                    expected, Microsoft.CodeAnalysis.IOperation
                    actual)
                    {
                        Assert.Same((object)expected, (object)actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52310, 52407);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_25069_52464_52513(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    this_param)
                    {
                        var return_v = this_param.OriginalOperation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 52464, 52513);
                        return return_v;
                    }


                    int
                    f_25069_52436_52541(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    dict, Microsoft.CodeAnalysis.IOperation
                    key, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)
                    value)
                    {
                        dict.Add<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52436, 52541);
                        return 0;
                    }


                    (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)
                    f_25069_52689_52724(System.Func<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52689, 52724);
                        return return_v;
                    }


                    int
                    f_25069_52644_52731(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    actual)
                    {
                        Assert.Same((object)expected, (object)actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52644, 52731);
                        return 0;
                    }


                    (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)
                    f_25069_52890_52915(System.Func<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52890, 52915);
                        return return_v;
                    }


                    System.ArgumentNullException
                    f_25069_53071_53114(string
                    paramName)
                    {
                        var return_v = new System.ArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53071, 53114);
                        return return_v;
                    }


                    string
                    f_25069_53071_53122(System.ArgumentNullException
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 53071, 53122);
                        return return_v;
                    }


                    string
                    f_25069_53124_53134(System.ArgumentNullException
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 53124, 53134);
                        return return_v;
                    }


                    int
                    f_25069_53058_53135(string
                    expected, string
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53058, 53135);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                    f_25069_53275_53303(Microsoft.CodeAnalysis.IOperation
                    operation)
                    {
                        var return_v = operation.Descendants();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53275, 53303);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_25069_53275_53311(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                    source)
                    {
                        var return_v = source.First<Microsoft.CodeAnalysis.IOperation>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53275, 53311);
                        return return_v;
                    }


                    (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)
                    f_25069_53255_53312(System.Func<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph Graph, Microsoft.CodeAnalysis.ISymbol AssociatedSymbol)>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53255, 53312);
                        return return_v;
                    }


                    string
                    f_25069_53486_53547()
                    {
                        var return_v = CodeAnalysisResources.InvalidOperationBlockForAnalysisContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 53486, 53547);
                        return return_v;
                    }


                    System.ArgumentException
                    f_25069_53464_53566(string
                    message, string
                    paramName)
                    {
                        var return_v = new System.ArgumentException(message, paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53464, 53566);
                        return return_v;
                    }


                    string
                    f_25069_53464_53574(System.ArgumentException
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 53464, 53574);
                        return return_v;
                    }


                    string
                    f_25069_53576_53586(System.ArgumentException
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 53576, 53586);
                        return return_v;
                    }


                    int
                    f_25069_53451_53587(string
                    expected, string
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53451, 53587);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                    f_25069_52083_52098_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 52083, 52098);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 51770, 53672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 51770, 53672);
                }
            }

            private void VerifyControlFlowGraph(OperationAnalysisContext operationContext, bool inBlockAnalysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 53688, 54795);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 53828, 54780) || true) && (_verifyGetControlFlowGraph)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 53828, 54780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 53900, 53962);

                        var
                        controlFlowGraph = operationContext.GetControlFlowGraph()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 53984, 54017);

                        f_25069_53984_54016(controlFlowGraph);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 54111, 54181);

                        f_25069_54111_54180(controlFlowGraph, operationContext.GetControlFlowGraph());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 54205, 54271);

                        var
                        rootOperation = f_25069_54225_54270(operationContext.Operation)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 54293, 54761) || true) && (inBlockAnalysisContext)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 54293, 54761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 54469, 54545);

                            f_25069_54469_54544(controlFlowGraph, _controlFlowGraphMapOpt[rootOperation].Graph);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 54293, 54761);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 54293, 54761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 54643, 54738);

                            _controlFlowGraphMapOpt[rootOperation] = (controlFlowGraph, operationContext.ContainingSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 54293, 54761);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 53828, 54780);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 53688, 54795);

                    int
                    f_25069_53984_54016(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    @object)
                    {
                        Assert.NotNull((object)@object);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 53984, 54016);
                        return 0;
                    }


                    int
                    f_25069_54111_54180(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    actual)
                    {
                        Assert.Same((object)expected, (object)actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 54111, 54180);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_25069_54225_54270(Microsoft.CodeAnalysis.IOperation
                    operation)
                    {
                        var return_v = operation.GetRootOperation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 54225, 54270);
                        return return_v;
                    }


                    int
                    f_25069_54469_54544(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    actual)
                    {
                        Assert.Same((object)expected, (object)actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 54469, 54544);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 53688, 54795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 53688, 54795);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 54885, 54921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 54888, 54921);
                        return f_25069_54888_54921(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 54885, 54921);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 54885, 54921);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 54885, 54921);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 54936, 57460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 55025, 57445);

                    switch (_actionKind)
                    {

                        case ActionKind.OperationBlockEnd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 55025, 57445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 55146, 55595);

                            f_25069_55146_55594(context, blockStartContext =>
                            {
                                blockStartContext.RegisterOperationBlockEndAction(c => ReportDiagnostic(c.ReportDiagnostic, c.OwningSymbol.Locations[0]));
                                CacheAndVerifyControlFlowGraph(blockStartContext.OperationBlocks, op => (blockStartContext.GetControlFlowGraph(op), blockStartContext.OwningSymbol));
                            });
                            DynAbs.Tracing.TraceSender.TraceBreak(25069, 55623, 55629);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 55025, 57445);

                        case ActionKind.OperationBlock:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 55025, 57445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 55710, 56100);

                            f_25069_55710_56099(context, blockContext =>
                            {
                                ReportDiagnostic(blockContext.ReportDiagnostic, blockContext.OwningSymbol.Locations[0]);
                                CacheAndVerifyControlFlowGraph(blockContext.OperationBlocks, op => (blockContext.GetControlFlowGraph(op), blockContext.OwningSymbol));
                            });
                            DynAbs.Tracing.TraceSender.TraceBreak(25069, 56128, 56134);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 55025, 57445);

                        case ActionKind.Operation:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 55025, 57445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 56210, 56573);

                            f_25069_56210_56572(context, operationContext =>
                            {
                                ReportDiagnostic(operationContext.ReportDiagnostic, operationContext.Operation.Syntax.GetLocation());
                                VerifyControlFlowGraph(operationContext, inBlockAnalysisContext: false);
                            }, OperationKind.Literal);
                            DynAbs.Tracing.TraceSender.TraceBreak(25069, 56601, 56607);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 55025, 57445);

                        case ActionKind.OperationInOperationBlockStart:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 55025, 57445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 56704, 57394);

                            f_25069_56704_57393(context, blockContext =>
                            {
                                CacheAndVerifyControlFlowGraph(blockContext.OperationBlocks, op => (blockContext.GetControlFlowGraph(op), blockContext.OwningSymbol));
                                blockContext.RegisterOperationAction(operationContext =>
                                {
                                    ReportDiagnostic(operationContext.ReportDiagnostic, operationContext.Operation.Syntax.GetLocation());
                                    VerifyControlFlowGraph(operationContext, inBlockAnalysisContext: true);
                                }, OperationKind.Literal);
                            });
                            DynAbs.Tracing.TraceSender.TraceBreak(25069, 57420, 57426);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 55025, 57445);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 54936, 57460);

                    int
                    f_25069_55146_55594(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterOperationBlockStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 55146, 55594);
                        return 0;
                    }


                    int
                    f_25069_55710_56099(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                    action)
                    {
                        this_param.RegisterOperationBlockAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 55710, 56099);
                        return 0;
                    }


                    int
                    f_25069_56210_56572(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                    action, params Microsoft.CodeAnalysis.OperationKind[]
                    operationKinds)
                    {
                        this_param.RegisterOperationAction(action, operationKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 56210, 56572);
                        return 0;
                    }


                    int
                    f_25069_56704_57393(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterOperationBlockStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 56704, 57393);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 54936, 57460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 54936, 57460);
                }
            }

            static OperationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 49795, 57471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 50260, 50518);
                Descriptor = f_25069_50273_50518("ID", "Title1", "{0} diagnostic", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 49795, 57471);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 49795, 57471);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 49795, 57471);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_50273_50518(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 50273, 50518);
                return return_v;
            }


            static System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph, Microsoft.CodeAnalysis.ISymbol)>
            f_25069_51038_51105()
            {
                var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph, Microsoft.CodeAnalysis.ISymbol)>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 51038, 51105);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_54888_54921(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 54888, 54921);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class OperationBlockAnalyzer : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 58056, 58092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 58059, 58092);
                        return f_25069_58059_58092(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 58056, 58092);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 58056, 58092);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 58056, 58092);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 58107, 58608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 58196, 58593);

                    f_25069_58196_58592(context, c =>
                    {
                        foreach (var operationRoot in c.OperationBlocks)
                        {
                            var diagnostic = Diagnostic.Create(Descriptor, c.OwningSymbol.Locations[0], c.OwningSymbol.Name, operationRoot.Kind);
                            c.ReportDiagnostic(diagnostic);
                        }
                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 58107, 58608);

                    int
                    f_25069_58196_58592(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                    action)
                    {
                        this_param.RegisterOperationBlockAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 58196, 58592);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 58107, 58608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 58107, 58608);
                }
            }

            public OperationBlockAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 57483, 58619);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 57483, 58619);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 57483, 58619);
            }


            static OperationBlockAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 57483, 58619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 57694, 57965);
                Descriptor = f_25069_57707_57965("ID", "Title1", "OperationBlock for {0}: {1}", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 57483, 58619);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 57483, 58619);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 57483, 58619);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_57707_57965(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 57707, 57965);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_58059_58092(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 58059, 58092);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class FieldReferenceOperationAnalyzer : DiagnosticAnalyzer
        {
            private readonly bool _doOperationBlockAnalysis;

            public static readonly DiagnosticDescriptor Descriptor;

            public FieldReferenceOperationAnalyzer(bool doOperationBlockAnalysis)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 59187, 59357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 58829, 58854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 59289, 59342);

                    _doOperationBlockAnalysis = doOperationBlockAnalysis;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 59187, 59357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 59187, 59357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 59187, 59357);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 59447, 59483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 59450, 59483);
                        return f_25069_59450_59483(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 59447, 59483);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 59447, 59483);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 59447, 59483);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 59498, 60443);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 59587, 60428) || true) && (_doOperationBlockAnalysis)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 59587, 60428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 59658, 60246);

                        f_25069_59658_60245(context, operationBlockAnalysisContext =>
                        {
                            foreach (var operationBlock in operationBlockAnalysisContext.OperationBlocks)
                            {
                                foreach (var operation in operationBlock.DescendantsAndSelf().OfType<IFieldReferenceOperation>())
                                {
                                    AnalyzerFieldReferenceOperation(operation, operationBlockAnalysisContext.ReportDiagnostic);
                                }
                            }
                        });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 59587, 60428);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 59587, 60428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 60328, 60409);

                        f_25069_60328_60408(context, AnalyzerOperation, OperationKind.FieldReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 59587, 60428);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 59498, 60443);

                    int
                    f_25069_59658_60245(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                    action)
                    {
                        this_param.RegisterOperationBlockAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 59658, 60245);
                        return 0;
                    }


                    int
                    f_25069_60328_60408(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                    action, params Microsoft.CodeAnalysis.OperationKind[]
                    operationKinds)
                    {
                        this_param.RegisterOperationAction(action, operationKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 60328, 60408);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 59498, 60443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 59498, 60443);
                }
            }

            private static void AnalyzerOperation(OperationAnalysisContext operationAnalysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 60459, 60732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 60580, 60717);

                    f_25069_60580_60716(operationAnalysisContext.Operation, operationAnalysisContext.ReportDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 60459, 60732);

                    int
                    f_25069_60580_60716(Microsoft.CodeAnalysis.IOperation
                    operation, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    reportDiagnostic)
                    {
                        AnalyzerFieldReferenceOperation((Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation)operation, reportDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 60580, 60716);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 60459, 60732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 60459, 60732);
                }
            }

            private static void AnalyzerFieldReferenceOperation(IFieldReferenceOperation operation, Action<Diagnostic> reportDiagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25069, 60748, 61099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 60905, 61037);

                    var
                    diagnostic = f_25069_60922_61036(Descriptor, f_25069_60952_60982(f_25069_60952_60968(operation)), f_25069_60984_61004(f_25069_60984_60999(operation)), f_25069_61006_61035(f_25069_61006_61021(operation)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 61055, 61084);

                    f_25069_61055_61083(reportDiagnostic, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25069, 60748, 61099);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25069_60952_60968(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                    this_param)
                    {
                        var return_v = this_param.Syntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 60952, 60968);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_25069_60952_60982(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 60952, 60982);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IFieldSymbol
                    f_25069_60984_60999(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                    this_param)
                    {
                        var return_v = this_param.Field;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 60984, 60999);
                        return return_v;
                    }


                    string
                    f_25069_60984_61004(Microsoft.CodeAnalysis.IFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 60984, 61004);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IFieldSymbol
                    f_25069_61006_61021(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                    this_param)
                    {
                        var return_v = this_param.Field;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 61006, 61021);
                        return return_v;
                    }


                    object?
                    f_25069_61006_61035(Microsoft.CodeAnalysis.IFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 61006, 61035);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_60922_61036(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 60922, 61036);
                        return return_v;
                    }


                    int
                    f_25069_61055_61083(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    obj)
                    {
                        this_param.Invoke(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 61055, 61083);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 60748, 61099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 60748, 61099);
                }
            }

            static FieldReferenceOperationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 58631, 61110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 58913, 59170);
                Descriptor = f_25069_58926_59170("ID", "Title", "Field {0} = {1}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 58631, 61110);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 58631, 61110);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 58631, 61110);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_58926_59170(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 58926, 59170);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_59450_59483(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 59450, 59483);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class MethodOrConstructorBodyOperationAnalyzer : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 61694, 61730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 61697, 61730);
                        return f_25069_61697_61730(Descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 61694, 61730);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 61694, 61730);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 61694, 61730);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 61745, 62223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 61834, 62208);

                    f_25069_61834_62207(context, operationContext =>
                    {
                        var diagnostic = Diagnostic.Create(Descriptor, operationContext.Operation.Syntax.GetLocation(), operationContext.ContainingSymbol.Name);
                        operationContext.ReportDiagnostic(diagnostic);
                    }, OperationKind.MethodBody, OperationKind.ConstructorBody);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 61745, 62223);

                    int
                    f_25069_61834_62207(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                    action, params Microsoft.CodeAnalysis.OperationKind[]
                    operationKinds)
                    {
                        this_param.RegisterOperationAction(action, operationKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 61834, 62207);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 61745, 62223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 61745, 62223);
                }
            }

            public MethodOrConstructorBodyOperationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 61122, 62234);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 61122, 62234);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 61122, 62234);
            }


            static MethodOrConstructorBodyOperationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 61122, 62234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 61351, 61603);
                Descriptor = f_25069_61364_61603("ID", "Title", "Method {0}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 61122, 62234);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 61122, 62234);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 61122, 62234);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_61364_61603(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 61364, 61603);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_61697_61730(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 61697, 61730);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class GeneratedCodeAnalyzer : DiagnosticAnalyzer
        {
            private readonly GeneratedCodeAnalysisFlags? _generatedCodeAnalysisFlagsOpt;

            public static readonly DiagnosticDescriptor Warning;

            public static readonly DiagnosticDescriptor Error;

            public static readonly DiagnosticDescriptor Summary;

            public GeneratedCodeAnalyzer(GeneratedCodeAnalysisFlags? generatedCodeAnalysisFlagsOpt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 63508, 63706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 62450, 62480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 63628, 63691);

                    _generatedCodeAnalysisFlagsOpt = generatedCodeAnalysisFlagsOpt;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 63508, 63706);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 63508, 63706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 63508, 63706);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 63796, 63845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 63799, 63845);
                        return f_25069_63799_63845(Warning, Error, Summary); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 63796, 63845);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 63796, 63845);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 63796, 63845);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 63860, 64291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 63949, 64013);

                    f_25069_63949_64012(context, this.OnCompilationStart);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 64033, 64276) || true) && (f_25069_64037_64076(_generatedCodeAnalysisFlagsOpt))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 64033, 64276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 64180, 64257);

                        f_25069_64180_64256(                    // Configure analysis on generated code.
                                            context, f_25069_64219_64255(_generatedCodeAnalysisFlagsOpt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 64033, 64276);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 63860, 64291);

                    int
                    f_25069_63949_64012(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 63949, 64012);
                        return 0;
                    }


                    bool
                    f_25069_64037_64076(Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 64037, 64076);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                    f_25069_64219_64255(Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 64219, 64255);
                        return return_v;
                    }


                    int
                    f_25069_64180_64256(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                    analysisMode)
                    {
                        this_param.ConfigureGeneratedCodeAnalysis(analysisMode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 64180, 64256);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 63860, 64291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 63860, 64291);
                }
            }

            private void OnCompilationStart(CompilationStartAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 64307, 65608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 64412, 64468);

                    var
                    sortedCallbackSymbolNames = f_25069_64444_64467()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 64486, 64540);

                    var
                    sortedCallbackTreePaths = f_25069_64516_64539()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 64558, 64844);

                    f_25069_64558_64843(context, symbolContext =>
                    {
                        sortedCallbackSymbolNames.Add(symbolContext.Symbol.Name);
                        ReportSymbolDiagnostics(symbolContext.Symbol, symbolContext.ReportDiagnostic);
                    }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 64864, 65120);

                    f_25069_64864_65119(
                                    context, treeContext =>
                                    {
                                        sortedCallbackTreePaths.Add(treeContext.Tree.FilePath);
                                        ReportTreeDiagnostics(treeContext.Tree, treeContext.ReportDiagnostic);
                                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 65140, 65593);

                    f_25069_65140_65592(
                                    context, endContext =>
                                    {
                                        var arg1 = sortedCallbackSymbolNames.Join(",");
                                        var arg2 = sortedCallbackTreePaths.Join(",");

                    // Summary diagnostics about received callbacks.
                    var diagnostic = Diagnostic.Create(Summary, Location.None, arg1, arg2);
                                        endContext.ReportDiagnostic(diagnostic);
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 64307, 65608);

                    System.Collections.Generic.SortedSet<string>
                    f_25069_64444_64467()
                    {
                        var return_v = new System.Collections.Generic.SortedSet<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 64444, 64467);
                        return return_v;
                    }


                    System.Collections.Generic.SortedSet<string>
                    f_25069_64516_64539()
                    {
                        var return_v = new System.Collections.Generic.SortedSet<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 64516, 64539);
                        return return_v;
                    }


                    int
                    f_25069_64558_64843(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 64558, 64843);
                        return 0;
                    }


                    int
                    f_25069_64864_65119(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 64864, 65119);
                        return 0;
                    }


                    int
                    f_25069_65140_65592(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationEndAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 65140, 65592);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 64307, 65608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 64307, 65608);
                }
            }

            private void ReportSymbolDiagnostics(ISymbol symbol, Action<Diagnostic> addDiagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 65624, 65829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 65743, 65814);

                    f_25069_65743_65813(this, addDiagnostic, f_25069_65780_65796(symbol)[0], f_25069_65801_65812(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 65624, 65829);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_25069_65780_65796(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 65780, 65796);
                        return return_v;
                    }


                    string
                    f_25069_65801_65812(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 65801, 65812);
                        return return_v;
                    }


                    int
                    f_25069_65743_65813(Microsoft.CodeAnalysis.CommonDiagnosticAnalyzers.GeneratedCodeAnalyzer
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    addDiagnostic, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    messageArguments)
                    {
                        this_param.ReportDiagnosticsCore(addDiagnostic, location, messageArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 65743, 65813);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 65624, 65829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 65624, 65829);
                }
            }

            private void ReportTreeDiagnostics(SyntaxTree tree, Action<Diagnostic> addDiagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 65845, 66075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 65963, 66060);

                    f_25069_65963_66059(this, addDiagnostic, f_25069_66000_66029(f_25069_66000_66014(tree)).GetLocation(), f_25069_66045_66058(tree));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 65845, 66075);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25069_66000_66014(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 66000, 66014);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_25069_66000_66029(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLastToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 66000, 66029);
                        return return_v;
                    }


                    string
                    f_25069_66045_66058(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 66045, 66058);
                        return return_v;
                    }


                    int
                    f_25069_65963_66059(Microsoft.CodeAnalysis.CommonDiagnosticAnalyzers.GeneratedCodeAnalyzer
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    addDiagnostic, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    messageArguments)
                    {
                        this_param.ReportDiagnosticsCore(addDiagnostic, location, messageArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 65963, 66059);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 65845, 66075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 65845, 66075);
                }
            }

            private void ReportDiagnosticsCore(Action<Diagnostic> addDiagnostic, Location location, params object[] messageArguments)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 66091, 66582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 66284, 66356);

                    var
                    diagnostic = f_25069_66301_66355(Warning, location, messageArguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 66374, 66400);

                    f_25069_66374_66399(addDiagnostic, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 66457, 66523);

                    diagnostic = f_25069_66470_66522(Error, location, messageArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 66541, 66567);

                    f_25069_66541_66566(addDiagnostic, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 66091, 66582);

                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_66301_66355(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 66301, 66355);
                        return return_v;
                    }


                    int
                    f_25069_66374_66399(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    obj)
                    {
                        this_param.Invoke(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 66374, 66399);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_66470_66522(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 66470, 66522);
                        return return_v;
                    }


                    int
                    f_25069_66541_66566(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    obj)
                    {
                        this_param.Invoke(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 66541, 66566);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 66091, 66582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 66091, 66582);
                }
            }

            static GeneratedCodeAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 62246, 66593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 62541, 62807);
                Warning = f_25069_62551_62807("GeneratedCodeAnalyzerWarning", "Title", "GeneratedCodeAnalyzerMessage for '{0}'", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 62868, 63128);
                Error = f_25069_62876_63128("GeneratedCodeAnalyzerError", "Title", "GeneratedCodeAnalyzerMessage for '{0}'", "Category", DiagnosticSeverity.Error, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 63189, 63491);
                Summary = f_25069_63199_63491("GeneratedCodeAnalyzerSummary", "Title2", "GeneratedCodeAnalyzer received callbacks for: '{0}' types and '{1}' files", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 62246, 66593);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 62246, 66593);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 62246, 66593);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_62551_62807(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 62551, 62807);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_62876_63128(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 62876, 63128);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_63199_63491(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 63199, 63491);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_63799_63845(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
            item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
            item3)
            {
                var return_v = ImmutableArray.Create(item1, item2, item3);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 63799, 63845);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class GeneratedCodeAnalyzer2 : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor Rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 67194, 67224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 67197, 67224);
                        return f_25069_67197_67224(Rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 67194, 67224);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 67194, 67224);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 67194, 67224);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 67239, 68301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 67404, 67479);

                    f_25069_67404_67478(                // Analyze but don't report diagnostics on generated code.
                                    context, GeneratedCodeAnalysisFlags.Analyze);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 67499, 68286);

                    f_25069_67499_68285(
                                    context, compilationStartContext =>
                                    {
                                        var namedTypes = new HashSet<ISymbol>();
                                        compilationStartContext.RegisterSymbolAction(symbolContext => namedTypes.Add(symbolContext.Symbol), SymbolKind.NamedType);

                                        compilationStartContext.RegisterCompilationEndAction(compilationEndContext =>
                                        {
                                            foreach (var namedType in namedTypes)
                                            {
                                                var diagnostic = Diagnostic.Create(Rule, namedType.Locations[0], namedType.Name, namedTypes.Count);
                                                compilationEndContext.ReportDiagnostic(diagnostic);
                                            }
                                        });
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 67239, 68301);

                    int
                    f_25069_67404_67478(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                    analysisMode)
                    {
                        this_param.ConfigureGeneratedCodeAnalysis(analysisMode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 67404, 67478);
                        return 0;
                    }


                    int
                    f_25069_67499_68285(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 67499, 68285);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 67239, 68301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 67239, 68301);
                }
            }

            public GeneratedCodeAnalyzer2()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 66605, 68312);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 66605, 68312);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 66605, 68312);
            }


            static GeneratedCodeAnalyzer2()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 66605, 68312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 66809, 67103);
                Rule = f_25069_66816_67103("GeneratedCodeAnalyzer2Warning", "Title", "GeneratedCodeAnalyzer2Message for '{0}'; Total types analyzed: '{1}'", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 66605, 68312);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 66605, 68312);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 66605, 68312);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_66816_67103(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 66816, 67103);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_67197_67224(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 67197, 67224);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class SharedStateAnalyzer : DiagnosticAnalyzer
        {
            private readonly SyntaxTreeValueProvider<bool> _treeValueProvider;

            private readonly HashSet<SyntaxTree> _treeCallbackSet;

            private readonly SourceTextValueProvider<int> _textValueProvider;

            private readonly HashSet<SourceText> _textCallbackSet;

            public static readonly DiagnosticDescriptor GeneratedCodeDescriptor;

            public static readonly DiagnosticDescriptor NonGeneratedCodeDescriptor;

            public static readonly DiagnosticDescriptor UniqueTextFileDescriptor;

            public static readonly DiagnosticDescriptor NumberOfUniqueTextFileDescriptor;

            public SharedStateAnalyzer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 70115, 70536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 68528, 68546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 68598, 68614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 68677, 68695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 68747, 68763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70176, 70248);

                    _treeValueProvider = f_25069_70197_70247(IsGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70266, 70338);

                    _treeCallbackSet = f_25069_70285_70337(SyntaxTreeComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70358, 70431);

                    _textValueProvider = f_25069_70379_70430(GetCharacterCount);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70449, 70521);

                    _textCallbackSet = f_25069_70468_70520(SourceTextComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 70115, 70536);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 70115, 70536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 70115, 70536);
                }
            }

            private bool IsGeneratedCode(SyntaxTree tree)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 70552, 71239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70636, 70652);
                    lock (_treeCallbackSet)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70694, 70872) || true) && (!f_25069_70699_70725(_treeCallbackSet, tree))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 70694, 70872);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70775, 70849);

                            throw f_25069_70781_70848("Expected driver to make a single callback per tree");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 70694, 70872);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 70911, 71008);

                    var
                    fileNameWithoutExtension = f_25069_70942_71007(f_25069_70968_70981(tree), includeExtension: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 71026, 71224);

                    return f_25069_71033_71115(fileNameWithoutExtension, ".designer", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(25069, 71033, 71223) || f_25069_71140_71223(fileNameWithoutExtension, ".generated", StringComparison.OrdinalIgnoreCase));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 70552, 71239);

                    bool
                    f_25069_70699_70725(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 70699, 70725);
                        return return_v;
                    }


                    System.Exception
                    f_25069_70781_70848(string
                    message)
                    {
                        var return_v = new System.Exception(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 70781, 70848);
                        return return_v;
                    }


                    string
                    f_25069_70968_70981(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 70968, 70981);
                        return return_v;
                    }


                    string?
                    f_25069_70942_71007(string
                    path, bool
                    includeExtension)
                    {
                        var return_v = PathUtilities.GetFileName(path, includeExtension: includeExtension);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 70942, 71007);
                        return return_v;
                    }


                    bool
                    f_25069_71033_71115(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.EndsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 71033, 71115);
                        return return_v;
                    }


                    bool
                    f_25069_71140_71223(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.EndsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 71140, 71223);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 70552, 71239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 70552, 71239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int GetCharacterCount(SourceText text)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 71255, 71649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 71340, 71356);
                    lock (_textCallbackSet)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 71398, 71576) || true) && (!f_25069_71403_71429(_textCallbackSet, text))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 71398, 71576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 71479, 71553);

                            throw f_25069_71485_71552("Expected driver to make a single callback per text");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 71398, 71576);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 71615, 71634);

                    return f_25069_71622_71633(text);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 71255, 71649);

                    bool
                    f_25069_71403_71429(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
                    this_param, Microsoft.CodeAnalysis.Text.SourceText
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 71403, 71429);
                        return return_v;
                    }


                    System.Exception
                    f_25069_71485_71552(string
                    message)
                    {
                        var return_v = new System.Exception(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 71485, 71552);
                        return return_v;
                    }


                    int
                    f_25069_71622_71633(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 71622, 71633);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 71255, 71649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 71255, 71649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 71739, 71876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 71742, 71876);
                        return f_25069_71742_71876(GeneratedCodeDescriptor, NonGeneratedCodeDescriptor, UniqueTextFileDescriptor, NumberOfUniqueTextFileDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 71739, 71876);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 71739, 71876);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 71739, 71876);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 71893, 72061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 71982, 72046);

                    f_25069_71982_72045(context, this.OnCompilationStart);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 71893, 72061);

                    int
                    f_25069_71982_72045(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 71982, 72045);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 71893, 72061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 71893, 72061);
                }
            }

            private void OnCompilationStart(CompilationStartAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 72077, 74342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 72182, 72993);

                    f_25069_72182_72992(context, symbolContext =>
                    {
                        var descriptor = GeneratedCodeDescriptor;
                        foreach (var location in symbolContext.Symbol.Locations)
                        {
                            context.TryGetValue(location.SourceTree, _treeValueProvider, out var isGeneratedCode);
                            if (!isGeneratedCode)
                            {
                                descriptor = NonGeneratedCodeDescriptor;
                                break;
                            }
                        }

                        var diagnostic = Diagnostic.Create(descriptor, symbolContext.Symbol.Locations[0], symbolContext.Symbol.Name);
                        symbolContext.ReportDiagnostic(diagnostic);
                    }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 73013, 73783);

                    f_25069_73013_73782(
                                    context, treeContext =>
                                    {
                                        context.TryGetValue(treeContext.Tree, _treeValueProvider, out var isGeneratedCode);
                                        var descriptor = isGeneratedCode ? GeneratedCodeDescriptor : NonGeneratedCodeDescriptor;

                                        var diagnostic = Diagnostic.Create(descriptor, Location.None, treeContext.Tree.FilePath);
                                        treeContext.ReportDiagnostic(diagnostic);

                                        context.TryGetValue(treeContext.Tree.GetText(), _textValueProvider, out var length);
                                        diagnostic = Diagnostic.Create(UniqueTextFileDescriptor, Location.None, treeContext.Tree.FilePath);
                                        treeContext.ReportDiagnostic(diagnostic);
                                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 73803, 74327);

                    f_25069_73803_74326(
                                    context, endContext =>
                                    {
                                        if (_treeCallbackSet.Count != endContext.Compilation.SyntaxTrees.Count())
                                        {
                                            throw new Exception("Expected driver to make a callback for every tree");
                                        }

                                        var diagnostic = Diagnostic.Create(NumberOfUniqueTextFileDescriptor, Location.None, _textCallbackSet.Count);
                                        endContext.ReportDiagnostic(diagnostic);
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 72077, 74342);

                    int
                    f_25069_72182_72992(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 72182, 72992);
                        return 0;
                    }


                    int
                    f_25069_73013_73782(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 73013, 73782);
                        return 0;
                    }


                    int
                    f_25069_73803_74326(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationEndAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 73803, 74326);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 72077, 74342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 72077, 74342);
                }
            }

            static SharedStateAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 68324, 74353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 68824, 69091);
                GeneratedCodeDescriptor = f_25069_68850_69091("GeneratedCodeDiagnostic", "Title1", "GeneratedCodeDiagnostic {0}", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 69152, 69412);
                NonGeneratedCodeDescriptor = f_25069_69181_69412("UserCodeDiagnostic", "Title2", "UserCodeDiagnostic {0}", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 69473, 69743);
                UniqueTextFileDescriptor = f_25069_69500_69743("UniqueTextFileDiagnostic", "Title3", "UniqueTextFileDiagnostic {0}", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 69804, 70098);
                NumberOfUniqueTextFileDescriptor = f_25069_69839_70098("NumberOfUniqueTextFileDescriptor", "Title4", "NumberOfUniqueTextFileDescriptor {0}", "Category", DiagnosticSeverity.Warning, true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 68324, 74353);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 68324, 74353);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 68324, 74353);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_68850_69091(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 68850, 69091);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_69181_69412(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 69181, 69412);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_69500_69743(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 69500, 69743);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_69839_70098(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 69839, 70098);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeValueProvider<bool>
            f_25069_70197_70247(System.Func<Microsoft.CodeAnalysis.SyntaxTree, bool>
            computeValue)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeValueProvider<bool>(computeValue);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 70197, 70247);
                return return_v;
            }


            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
            f_25069_70285_70337(Microsoft.CodeAnalysis.SyntaxTreeComparer
            comparer)
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.SyntaxTree>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 70285, 70337);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Diagnostics.SourceTextValueProvider<int>
            f_25069_70379_70430(System.Func<Microsoft.CodeAnalysis.Text.SourceText, int>
            computeValue)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceTextValueProvider<int>(computeValue);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 70379, 70430);
                return return_v;
            }


            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
            f_25069_70468_70520(Microsoft.CodeAnalysis.Text.SourceTextComparer
            comparer)
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Text.SourceText>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 70468, 70520);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_71742_71876(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
            item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
            item3, Microsoft.CodeAnalysis.DiagnosticDescriptor
            item4)
            {
                var return_v = ImmutableArray.Create(item1, item2, item3, item4);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 71742, 71876);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class AnalyzerForParameters : DiagnosticAnalyzer
        {
            public static readonly DiagnosticDescriptor ParameterDescriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 74957, 75002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 74960, 75002);
                        return f_25069_74960_75002(ParameterDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 74957, 75002);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 74957, 75002);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 74957, 75002);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 75019, 75188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 75108, 75173);

                    f_25069_75108_75172(context, SymbolAction, SymbolKind.Parameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 75019, 75188);

                    int
                    f_25069_75108_75172(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 75108, 75172);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 75019, 75188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 75019, 75188);
                }
            }

            private void SymbolAction(SymbolAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 75204, 75402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 75293, 75387);

                    context.ReportDiagnostic(f_25069_75318_75385(ParameterDescriptor, f_25069_75357_75381(context.Symbol)[0]));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 75204, 75402);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_25069_75357_75381(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 75357, 75381);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_75318_75385(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 75318, 75385);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 75204, 75402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 75204, 75402);
                }
            }

            public AnalyzerForParameters()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 74365, 75413);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 74365, 75413);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 74365, 75413);
            }


            static AnalyzerForParameters()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 74365, 75413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 74568, 74866);
                ParameterDescriptor = f_25069_74590_74866("Parameter_ID", "Parameter_Title", "Parameter_Message", "Parameter_Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 74365, 75413);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 74365, 75413);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 74365, 75413);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_74590_74866(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 74590, 74866);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_74960_75002(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 74960, 75002);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class SymbolStartAnalyzer : DiagnosticAnalyzer
        {
            private readonly SymbolKind _symbolKind;

            private readonly bool _topLevelAction;

            private readonly OperationKind? _operationKind;

            private readonly string _analyzerId;

            public SymbolStartAnalyzer(bool topLevelAction, SymbolKind symbolKind, OperationKind? operationKindOpt = null, int? analyzerId = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 75801, 76265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 75610, 75621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 75658, 75673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 75720, 75734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 75773, 75784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 76281, 76336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 75968, 76001);

                    _topLevelAction = topLevelAction;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 76019, 76044);

                    _symbolKind = symbolKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 76062, 76096);

                    _operationKind = operationKindOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 76114, 76186);

                    _analyzerId = $"Analyzer{((DynAbs.Tracing.TraceSender.Conditional_F1(25069, 76140, 76159) || ((f_25069_76140_76159(analyzerId) && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 76162, 76178)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 76181, 76182))) ? f_25069_76162_76178(analyzerId) : 1)}";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 76204, 76250);

                    SymbolsStarted = f_25069_76221_76249();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 75801, 76265);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 75801, 76265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 75801, 76265);
                }
            }

            internal ConcurrentSet<ISymbol> SymbolsStarted { get; }

            public static readonly DiagnosticDescriptor SymbolStartTopLevelRule;

            public static readonly DiagnosticDescriptor SymbolStartCompilationLevelRule;

            public static readonly DiagnosticDescriptor SymbolStartedEndedDifferRule;

            public static readonly DiagnosticDescriptor SymbolStartedOrderingRule;

            public static readonly DiagnosticDescriptor SymbolEndedOrderingRule;

            public static readonly DiagnosticDescriptor OperationOrderingRule;

            public static readonly DiagnosticDescriptor DuplicateStartActionRule;

            public static readonly DiagnosticDescriptor DuplicateEndActionRule;

            public static readonly DiagnosticDescriptor OperationRule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 80072, 80618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 80116, 80599);

                        return f_25069_80123_80598(SymbolStartTopLevelRule, SymbolStartCompilationLevelRule, SymbolStartedEndedDifferRule, SymbolStartedOrderingRule, SymbolEndedOrderingRule, DuplicateStartActionRule, DuplicateEndActionRule, OperationRule, OperationOrderingRule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 80072, 80618);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25069_80123_80598(params Microsoft.CodeAnalysis.DiagnosticDescriptor[]
                        items)
                        {
                            var return_v = ImmutableArray.Create(items);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 80123, 80598);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 79966, 80633);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 79966, 80633);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 80649, 89786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 80738, 80788);

                    var
                    diagnostics = f_25069_80756_80787()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 80806, 80854);

                    var
                    symbolsEnded = f_25069_80825_80853()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 80872, 80970);

                    var
                    seenOperationContainers = f_25069_80902_80969()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 80990, 82062) || true) && (_topLevelAction)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 80990, 82062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 81051, 81113);

                        f_25069_81051_81112(context, onSymbolStart, _symbolKind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 81137, 81496);

                        f_25069_81137_81495(
                                            context, compilationStartContext =>
                                            {
                                                compilationStartContext.RegisterCompilationEndAction(compilationEndContext =>
                                                {
                                                    reportDiagnosticsAtCompilationEnd(compilationEndContext);
                                                });
                                            });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 80990, 82062);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 80990, 82062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 81578, 82043);

                        f_25069_81578_82042(context, compilationStartContext =>
                        {
                            compilationStartContext.RegisterSymbolStartAction(onSymbolStart, _symbolKind);

                            compilationStartContext.RegisterCompilationEndAction(compilationEndContext =>
                            {
                                reportDiagnosticsAtCompilationEnd(compilationEndContext);
                            });
                        });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 80990, 82062);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 82082, 82089);

                    return;

                    void onSymbolStart(SymbolStartAnalysisContext symbolStartContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 82109, 82891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 82215, 82272);

                            f_25069_82215_82271(symbolStartContext);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 82296, 82639) || true) && (f_25069_82300_82323(_operationKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 82296, 82639);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 82373, 82616);

                                f_25069_82373_82615(symbolStartContext, operationContext =>
                                {
                                    performOperationActionVerification(operationContext, symbolStartContext);
                                }, f_25069_82594_82614(_operationKind));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 82296, 82639);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 82663, 82872);

                            f_25069_82663_82871(
                                                symbolStartContext, symbolEndContext =>
                                                {
                                                    performSymbolEndActionVerification(symbolEndContext, symbolStartContext);
                                                });
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 82109, 82891);

                            int
                            f_25069_82215_82271(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            symbolStartContext)
                            {
                                performSymbolStartActionVerification(symbolStartContext);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 82215, 82271);
                                return 0;
                            }


                            bool
                            f_25069_82300_82323(Microsoft.CodeAnalysis.OperationKind?
                            this_param)
                            {
                                var return_v = this_param.HasValue;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 82300, 82323);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.OperationKind
                            f_25069_82594_82614(Microsoft.CodeAnalysis.OperationKind?
                            this_param)
                            {
                                var return_v = this_param.Value;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 82594, 82614);
                                return return_v;
                            }


                            int
                            f_25069_82373_82615(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                            action, params Microsoft.CodeAnalysis.OperationKind[]
                            operationKinds)
                            {
                                this_param.RegisterOperationAction(action, operationKinds);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 82373, 82615);
                                return 0;
                            }


                            int
                            f_25069_82663_82871(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                            action)
                            {
                                this_param.RegisterSymbolEndAction(action);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 82663, 82871);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 82109, 82891);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 82109, 82891);
                        }
                    }

                    void reportDiagnosticsAtCompilationEnd(CompilationAnalysisContext compilationEndContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 82911, 83847);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 83040, 83642) || true) && (!f_25069_83045_83083(f_25069_83045_83059(), symbolsEnded))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 83040, 83642);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 83221, 83320);

                                var
                                symbolsStartedStr = f_25069_83245_83319(", ", f_25069_83263_83318(f_25069_83263_83310(f_25069_83263_83277(), s => s.ToDisplayString())))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 83346, 83441);

                                var
                                symbolsEndedStr = f_25069_83368_83440(", ", f_25069_83386_83439(f_25069_83386_83431(symbolsEnded, s => s.ToDisplayString())))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 83467, 83619);

                                compilationEndContext.ReportDiagnostic(f_25069_83506_83617(SymbolStartedEndedDifferRule, f_25069_83554_83567(), symbolsStartedStr, symbolsEndedStr, _analyzerId));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 83040, 83642);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 83666, 83828);
                                foreach (var diagnostic in f_25069_83693_83704_I(diagnostics))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 83666, 83828);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 83754, 83805);

                                    compilationEndContext.ReportDiagnostic(diagnostic);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 83666, 83828);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 163);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 163);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 82911, 83847);

                            Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_83045_83059()
                            {
                                var return_v = SymbolsStarted;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 83045, 83059);
                                return return_v;
                            }


                            bool
                            f_25069_83045_83083(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            source1, Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            source2)
                            {
                                var return_v = source1.SetEquals<Microsoft.CodeAnalysis.ISymbol>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)source2);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83045, 83083);
                                return return_v;
                            }


                            Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_83263_83277()
                            {
                                var return_v = SymbolsStarted;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 83263, 83277);
                                return return_v;
                            }


                            System.Collections.Generic.IEnumerable<string>
                            f_25069_83263_83310(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            source, System.Func<Microsoft.CodeAnalysis.ISymbol, string>
                            selector)
                            {
                                var return_v = source.Select<Microsoft.CodeAnalysis.ISymbol, string>(selector);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83263, 83310);
                                return return_v;
                            }


                            System.Linq.IOrderedEnumerable<string>
                            f_25069_83263_83318(System.Collections.Generic.IEnumerable<string>
                            source)
                            {
                                var return_v = source.Order<string>();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83263, 83318);
                                return return_v;
                            }


                            string
                            f_25069_83245_83319(string
                            separator, System.Linq.IOrderedEnumerable<string>
                            values)
                            {
                                var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83245, 83319);
                                return return_v;
                            }


                            System.Collections.Generic.IEnumerable<string>
                            f_25069_83386_83431(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            source, System.Func<Microsoft.CodeAnalysis.ISymbol, string>
                            selector)
                            {
                                var return_v = source.Select<Microsoft.CodeAnalysis.ISymbol, string>(selector);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83386, 83431);
                                return return_v;
                            }


                            System.Linq.IOrderedEnumerable<string>
                            f_25069_83386_83439(System.Collections.Generic.IEnumerable<string>
                            source)
                            {
                                var return_v = source.Order<string>();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83386, 83439);
                                return return_v;
                            }


                            string
                            f_25069_83368_83440(string
                            separator, System.Linq.IOrderedEnumerable<string>
                            values)
                            {
                                var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83368, 83440);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_83554_83567()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 83554, 83567);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_83506_83617(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83506, 83617);
                                return return_v;
                            }


                            System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                            f_25069_83693_83704_I(System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83693, 83704);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 82911, 83847);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 82911, 83847);
                        }
                    }

                    void performSymbolStartActionVerification(SymbolStartAnalysisContext symbolStartContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 83867, 84407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 83996, 84042);

                            f_25069_83996_84041(symbolStartContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 84064, 84122);

                            f_25069_84064_84121(symbolStartContext);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 84144, 84388) || true) && (!f_25069_84149_84194(f_25069_84149_84163(), f_25069_84168_84193(symbolStartContext)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 84144, 84388);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 84244, 84365);

                                f_25069_84244_84364(diagnostics, f_25069_84260_84363(DuplicateStartActionRule, f_25069_84304_84317(), f_25069_84319_84349(f_25069_84319_84344(symbolStartContext)), _analyzerId));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 84144, 84388);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 83867, 84407);

                            int
                            f_25069_83996_84041(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            symbolStartContext)
                            {
                                verifySymbolStartOrdering(symbolStartContext);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 83996, 84041);
                                return 0;
                            }


                            int
                            f_25069_84064_84121(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            symbolStartContext)
                            {
                                verifySymbolStartAndOperationOrdering(symbolStartContext);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84064, 84121);
                                return 0;
                            }


                            Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_84149_84163()
                            {
                                var return_v = SymbolsStarted;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84149, 84163);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_84168_84193(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84168, 84193);
                                return return_v;
                            }


                            bool
                            f_25069_84149_84194(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            this_param, Microsoft.CodeAnalysis.ISymbol
                            value)
                            {
                                var return_v = this_param.Add(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84149, 84194);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_84304_84317()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84304, 84317);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_84319_84344(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84319, 84344);
                                return return_v;
                            }


                            string
                            f_25069_84319_84349(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.Name;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84319, 84349);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_84260_84363(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84260, 84363);
                                return return_v;
                            }


                            int
                            f_25069_84244_84364(System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                            this_param, Microsoft.CodeAnalysis.Diagnostic
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84244, 84364);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 83867, 84407);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 83867, 84407);
                        }
                    }

                    void performSymbolEndActionVerification(SymbolAnalysisContext symbolEndContext, SymbolStartAnalysisContext symbolStartContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 84427, 85333);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 84594, 84659);

                            f_25069_84594_84658(f_25069_84607_84632(symbolStartContext), symbolEndContext.Symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 84681, 84723);

                            f_25069_84681_84722(symbolEndContext);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 84745, 84981) || true) && (!f_25069_84750_84791(symbolsEnded, symbolEndContext.Symbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 84745, 84981);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 84841, 84958);

                                f_25069_84841_84957(diagnostics, f_25069_84857_84956(DuplicateEndActionRule, f_25069_84899_84912(), f_25069_84914_84942(symbolEndContext.Symbol), _analyzerId));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 84745, 84981);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 85005, 85064);

                            f_25069_85005_85063(f_25069_85018_85062(symbolEndContext.Symbol));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 85086, 85173);

                            var
                            rule = (DynAbs.Tracing.TraceSender.Conditional_F1(25069, 85097, 85112) || ((_topLevelAction && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 85115, 85138)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 85141, 85172))) ? SymbolStartTopLevelRule : SymbolStartCompilationLevelRule
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 85195, 85314);

                            symbolEndContext.ReportDiagnostic(f_25069_85229_85312(rule, f_25069_85253_85266(), f_25069_85268_85298(f_25069_85268_85293(symbolStartContext)), _analyzerId));
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 84427, 85333);

                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_84607_84632(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84607, 84632);
                                return return_v;
                            }


                            int
                            f_25069_84594_84658(Microsoft.CodeAnalysis.ISymbol
                            expected, Microsoft.CodeAnalysis.ISymbol
                            actual)
                            {
                                Assert.Equal(expected, actual);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84594, 84658);
                                return 0;
                            }


                            int
                            f_25069_84681_84722(Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext
                            symbolEndContext)
                            {
                                verifySymbolEndOrdering(symbolEndContext);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84681, 84722);
                                return 0;
                            }


                            bool
                            f_25069_84750_84791(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            this_param, Microsoft.CodeAnalysis.ISymbol
                            value)
                            {
                                var return_v = this_param.Add(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84750, 84791);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_84899_84912()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84899, 84912);
                                return return_v;
                            }


                            string
                            f_25069_84914_84942(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.Name;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 84914, 84942);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_84857_84956(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84857, 84956);
                                return return_v;
                            }


                            int
                            f_25069_84841_84957(System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                            this_param, Microsoft.CodeAnalysis.Diagnostic
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 84841, 84957);
                                return 0;
                            }


                            bool
                            f_25069_85018_85062(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.IsImplicitlyDeclared;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 85018, 85062);
                                return return_v;
                            }


                            int
                            f_25069_85005_85063(bool
                            condition)
                            {
                                Assert.False(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 85005, 85063);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_85253_85266()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 85253, 85266);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_85268_85293(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 85268, 85293);
                                return return_v;
                            }


                            string
                            f_25069_85268_85298(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.Name;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 85268, 85298);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_85229_85312(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 85229, 85312);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 84427, 85333);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 84427, 85333);
                        }
                    }

                    void performOperationActionVerification(OperationAnalysisContext operationContext, SymbolStartAnalysisContext symbolStartContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 85353, 86240);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 85523, 85618);

                            var
                            containingSymbols = f_25069_85547_85617(f_25069_85547_85609(operationContext.ContainingSymbol))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 85640, 85705);

                            seenOperationContainers.Add(operationContext, containingSymbols);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 85727, 85789);

                            f_25069_85727_85788(f_25069_85743_85768(symbolStartContext), containingSymbols);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 85811, 85886);

                            f_25069_85811_85885(containingSymbols, s => Assert.DoesNotContain(s, symbolsEnded));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 86007, 86221);

                            operationContext.ReportDiagnostic(f_25069_86041_86219(OperationRule, f_25069_86074_86087(), f_25069_86089_86119(f_25069_86089_86114(symbolStartContext)), f_25069_86121_86159(operationContext.ContainingSymbol), f_25069_86161_86205(f_25069_86161_86194(operationContext.Operation)), _analyzerId));
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 85353, 86240);

                            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_85547_85609(Microsoft.CodeAnalysis.ISymbol
                            symbol)
                            {
                                var return_v = GetContainingSymbolsAndThis(symbol);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 85547, 85609);
                                return return_v;
                            }


                            System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_85547_85617(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                            source)
                            {
                                var return_v = source.ToSet<Microsoft.CodeAnalysis.ISymbol>();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 85547, 85617);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_85743_85768(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 85743, 85768);
                                return return_v;
                            }


                            int
                            f_25069_85727_85788(Microsoft.CodeAnalysis.ISymbol
                            expected, System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>
                            collection)
                            {
                                Assert.Contains(expected, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)collection);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 85727, 85788);
                                return 0;
                            }


                            int
                            f_25069_85811_85885(System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>
                            collection, System.Action<Microsoft.CodeAnalysis.ISymbol>
                            action)
                            {
                                Assert.All((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)collection, action);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 85811, 85885);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_86074_86087()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86074, 86087);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_86089_86114(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86089, 86114);
                                return return_v;
                            }


                            string
                            f_25069_86089_86119(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.Name;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86089, 86119);
                                return return_v;
                            }


                            string
                            f_25069_86121_86159(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.Name;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86121, 86159);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.SyntaxNode
                            f_25069_86161_86194(Microsoft.CodeAnalysis.IOperation
                            this_param)
                            {
                                var return_v = this_param.Syntax;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86161, 86194);
                                return return_v;
                            }


                            string
                            f_25069_86161_86205(Microsoft.CodeAnalysis.SyntaxNode
                            this_param)
                            {
                                var return_v = this_param.ToString();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 86161, 86205);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_86041_86219(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 86041, 86219);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 85353, 86240);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 85353, 86240);
                        }
                    }

                    IEnumerable<ISymbol> GetContainingSymbolsAndThis(ISymbol symbol)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 86260, 86614);

                            var listYield = new List<ISymbol>();
                            {
                                try
                                {
                                    do

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 86365, 86595);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 86416, 86436);

                                        listYield.Add(symbol);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 86462, 86495);

                                        symbol = f_25069_86471_86494(symbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 86365, 86595);
                                    }
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 86365, 86595) || true) && (symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(25069, 86547, 86593) && f_25069_86565_86593_M(!symbol.IsImplicitlyDeclared)))
                                    );
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 86365, 86595);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 86365, 86595);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 86260, 86614);

                            return listYield;

                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_86471_86494(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.ContainingSymbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86471, 86494);
                                return return_v;
                            }


                            bool
                            f_25069_86565_86593_M(bool
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86565, 86593);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 86260, 86614);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 86260, 86614);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    void verifySymbolStartOrdering(SymbolStartAnalysisContext symbolStartContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 86634, 87843);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 86752, 86802);

                            ISymbol
                            symbolStarted = f_25069_86776_86801(symbolStartContext)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 86824, 86853);

                            IEnumerable<ISymbol>
                            members
                            = default(IEnumerable<ISymbol>);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 86875, 87338);

                            switch (symbolStarted)
                            {

                                case INamedTypeSymbol namedType:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 86875, 87338);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 87008, 87041);

                                    members = f_25069_87018_87040(namedType);
                                    DynAbs.Tracing.TraceSender.TraceBreak(25069, 87071, 87077);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 86875, 87338);

                                case INamespaceSymbol namespaceSym:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 86875, 87338);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 87170, 87206);

                                    members = f_25069_87180_87205(namespaceSym);
                                    DynAbs.Tracing.TraceSender.TraceBreak(25069, 87236, 87242);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 86875, 87338);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 86875, 87338);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 87308, 87315);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 86875, 87338);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 87362, 87824);
                                foreach (var member in f_25069_87385_87428_I(f_25069_87385_87428(members, m => !m.IsImplicitlyDeclared)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 87362, 87824);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 87478, 87801) || true) && (f_25069_87482_87513(f_25069_87482_87496(), member))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 87478, 87801);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 87661, 87774);

                                        f_25069_87661_87773(                            // Member '{0}' started before container '{1}', Analyzer {2}
                                                                    diagnostics, f_25069_87677_87772(SymbolStartedOrderingRule, f_25069_87722_87735(), member, symbolStarted, _analyzerId));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 87478, 87801);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 87362, 87824);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 463);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 463);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 86634, 87843);

                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_86776_86801(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 86776, 86801);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_87018_87040(Microsoft.CodeAnalysis.INamedTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.GetMembers();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 87018, 87040);
                                return return_v;
                            }


                            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                            f_25069_87180_87205(Microsoft.CodeAnalysis.INamespaceSymbol
                            this_param)
                            {
                                var return_v = this_param.GetMembers();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 87180, 87205);
                                return return_v;
                            }


                            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_87385_87428(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                            source, System.Func<Microsoft.CodeAnalysis.ISymbol, bool>
                            predicate)
                            {
                                var return_v = source.Where<Microsoft.CodeAnalysis.ISymbol>(predicate);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 87385, 87428);
                                return return_v;
                            }


                            Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_87482_87496()
                            {
                                var return_v = SymbolsStarted;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 87482, 87496);
                                return return_v;
                            }


                            bool
                            f_25069_87482_87513(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            this_param, Microsoft.CodeAnalysis.ISymbol
                            value)
                            {
                                var return_v = this_param.Contains(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 87482, 87513);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_87722_87735()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 87722, 87735);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_87677_87772(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 87677, 87772);
                                return return_v;
                            }


                            int
                            f_25069_87661_87773(System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                            this_param, Microsoft.CodeAnalysis.Diagnostic
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 87661, 87773);
                                return 0;
                            }


                            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_87385_87428_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 87385, 87428);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 86634, 87843);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 86634, 87843);
                        }
                    }

                    void verifySymbolEndOrdering(SymbolAnalysisContext symbolEndContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 87863, 88957);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 87972, 88018);

                            ISymbol
                            symbolEnded = symbolEndContext.Symbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88040, 88096);

                            IList<ISymbol>
                            containersToVerify = f_25069_88076_88095()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88118, 88280) || true) && (f_25069_88122_88148(symbolEnded) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 88118, 88280);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88206, 88257);

                                f_25069_88206_88256(containersToVerify, f_25069_88229_88255(symbolEnded));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 88118, 88280);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88304, 88476) || true) && (f_25069_88308_88339(symbolEnded) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 88304, 88476);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88397, 88453);

                                f_25069_88397_88452(containersToVerify, f_25069_88420_88451(symbolEnded));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 88304, 88476);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88500, 88938);
                                foreach (var container in f_25069_88526_88544_I(containersToVerify))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 88500, 88938);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88594, 88915) || true) && (f_25069_88598_88630(symbolsEnded, container))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 88594, 88915);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 88776, 88888);

                                        f_25069_88776_88887(                            // Container '{0}' ended before member '{1}', Analyzer {2}
                                                                    diagnostics, f_25069_88792_88886(SymbolEndedOrderingRule, f_25069_88835_88848(), container, symbolEnded, _analyzerId));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 88594, 88915);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 88500, 88938);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 439);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 439);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 87863, 88957);

                            System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_88076_88095()
                            {
                                var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 88076, 88095);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.INamedTypeSymbol
                            f_25069_88122_88148(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.ContainingType;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 88122, 88148);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.INamedTypeSymbol
                            f_25069_88229_88255(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.ContainingType;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 88229, 88255);
                                return return_v;
                            }


                            int
                            f_25069_88206_88256(System.Collections.Generic.IList<Microsoft.CodeAnalysis.ISymbol>
                            this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                            item)
                            {
                                this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 88206, 88256);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.INamespaceSymbol
                            f_25069_88308_88339(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.ContainingNamespace;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 88308, 88339);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.INamespaceSymbol
                            f_25069_88420_88451(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.ContainingNamespace;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 88420, 88451);
                                return return_v;
                            }


                            int
                            f_25069_88397_88452(System.Collections.Generic.IList<Microsoft.CodeAnalysis.ISymbol>
                            this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                            item)
                            {
                                this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 88397, 88452);
                                return 0;
                            }


                            bool
                            f_25069_88598_88630(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                            this_param, Microsoft.CodeAnalysis.ISymbol
                            value)
                            {
                                var return_v = this_param.Contains(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 88598, 88630);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_88835_88848()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 88835, 88848);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_88792_88886(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 88792, 88886);
                                return return_v;
                            }


                            int
                            f_25069_88776_88887(System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                            this_param, Microsoft.CodeAnalysis.Diagnostic
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 88776, 88887);
                                return 0;
                            }


                            System.Collections.Generic.IList<Microsoft.CodeAnalysis.ISymbol>
                            f_25069_88526_88544_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.ISymbol>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 88526, 88544);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 87863, 88957);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 87863, 88957);
                        }
                    }

                    void verifySymbolStartAndOperationOrdering(SymbolStartAnalysisContext symbolStartContext)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 88977, 89771);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 89107, 89752);
                                foreach (var kvp in f_25069_89127_89150_I(seenOperationContainers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 89107, 89752);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 89200, 89252);

                                    OperationAnalysisContext
                                    operationContext = kvp.Key
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 89278, 89315);

                                    ISet<ISymbol>
                                    containers = kvp.Value
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 89343, 89729) || true) && (f_25069_89347_89393(containers, f_25069_89367_89392(symbolStartContext)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 89343, 89729);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 89543, 89702);

                                        f_25069_89543_89701(                            // Container '{0}' started after operation '{1}', Analyzer {2}
                                                                    diagnostics, f_25069_89559_89700(OperationOrderingRule, f_25069_89600_89613(), f_25069_89615_89640(symbolStartContext), f_25069_89642_89686(f_25069_89642_89675(operationContext.Operation)), _analyzerId));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 89343, 89729);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 89107, 89752);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 646);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 646);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 88977, 89771);

                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_89367_89392(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 89367, 89392);
                                return return_v;
                            }


                            bool
                            f_25069_89347_89393(System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>
                            this_param, Microsoft.CodeAnalysis.ISymbol
                            item)
                            {
                                var return_v = this_param.Contains(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 89347, 89393);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_25069_89600_89613()
                            {
                                var return_v = Location.None;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 89600, 89613);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ISymbol
                            f_25069_89615_89640(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                            this_param)
                            {
                                var return_v = this_param.Symbol;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 89615, 89640);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.SyntaxNode
                            f_25069_89642_89675(Microsoft.CodeAnalysis.IOperation
                            this_param)
                            {
                                var return_v = this_param.Syntax;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 89642, 89675);
                                return return_v;
                            }


                            string
                            f_25069_89642_89686(Microsoft.CodeAnalysis.SyntaxNode
                            this_param)
                            {
                                var return_v = this_param.ToString();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 89642, 89686);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Diagnostic
                            f_25069_89559_89700(Microsoft.CodeAnalysis.DiagnosticDescriptor
                            descriptor, Microsoft.CodeAnalysis.Location
                            location, params object?[]
                            messageArgs)
                            {
                                var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 89559, 89700);
                                return return_v;
                            }


                            int
                            f_25069_89543_89701(System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                            this_param, Microsoft.CodeAnalysis.Diagnostic
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 89543, 89701);
                                return 0;
                            }


                            System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext, System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>>
                            f_25069_89127_89150_I(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext, System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 89127, 89150);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 88977, 89771);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 88977, 89771);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 80649, 89786);

                    System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>
                    f_25069_80756_80787()
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentBag<Microsoft.CodeAnalysis.Diagnostic>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 80756, 80787);
                        return return_v;
                    }


                    Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                    f_25069_80825_80853()
                    {
                        var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 80825, 80853);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext, System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>>
                    f_25069_80902_80969()
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext, System.Collections.Generic.ISet<Microsoft.CodeAnalysis.ISymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 80902, 80969);
                        return return_v;
                    }


                    int
                    f_25069_81051_81112(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                    action, Microsoft.CodeAnalysis.SymbolKind
                    symbolKind)
                    {
                        this_param.RegisterSymbolStartAction(action, symbolKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 81051, 81112);
                        return 0;
                    }


                    int
                    f_25069_81137_81495(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 81137, 81495);
                        return 0;
                    }


                    int
                    f_25069_81578_82042(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 81578, 82042);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 80649, 89786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 80649, 89786);
                }
            }

            static SymbolStartAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 75425, 89797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 76396, 76724);
                SymbolStartTopLevelRule = f_25069_76422_76724("SymbolStartTopLevelRuleId", "SymbolStartTopLevelRuleTitle", "Symbol : {0}, Analyzer: {1}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 76785, 77105);
                SymbolStartCompilationLevelRule = f_25069_76819_77105("SymbolStartRuleId", "SymbolStartRuleTitle", "Symbol : {0}, Analyzer: {1}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 77166, 77541);
                SymbolStartedEndedDifferRule = f_25069_77197_77541("SymbolStartedEndedDifferRuleId", "SymbolStartedEndedDifferRuleTitle", "Symbols Started: '{0}', Symbols Ended: '{1}', Analyzer: {2}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 77602, 77961);
                SymbolStartedOrderingRule = f_25069_77630_77961("SymbolStartedOrderingRuleId", "SymbolStartedOrderingRuleTitle", "Member '{0}' started before container '{1}', Analyzer: {2}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 78022, 78373);
                SymbolEndedOrderingRule = f_25069_78048_78373("SymbolEndedOrderingRuleId", "SymbolEndedOrderingRuleTitle", "Container '{0}' ended before member '{1}', Analyzer: {2}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 78434, 78783);
                OperationOrderingRule = f_25069_78458_78783("OperationOrderingRuleId", "OperationOrderingRuleTitle", "Container '{0}' started after operation '{1}', Analyzer: {2}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 78844, 79169);
                DuplicateStartActionRule = f_25069_78871_79169("DuplicateStartActionRuleId", "DuplicateStartActionRuleTitle", "Symbol : {0}, Analyzer: {1}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 79230, 79543);
                DuplicateEndActionRule = f_25069_79255_79543("DuplicateEndActionRuleId", "DuplicateEndActionRuleTitle", "Symbol : {0}, Analyzer: {1}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 79604, 79949);
                OperationRule = f_25069_79620_79949("OperationRuleId", "OperationRuleTitle", "Symbol Started: '{0}', Owning Symbol: '{1}' Operation : {2}, Analyzer: {3}", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 75425, 89797);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 75425, 89797);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 75425, 89797);

            static bool
            f_25069_76140_76159(int?
            this_param)
            {
                var return_v = this_param.HasValue;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 76140, 76159);
                return return_v;
            }


            static int
            f_25069_76162_76178(int?
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 76162, 76178);
                return return_v;
            }


            static Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
            f_25069_76221_76249()
            {
                var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 76221, 76249);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_76422_76724(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 76422, 76724);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_76819_77105(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 76819, 77105);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_77197_77541(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 77197, 77541);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_77630_77961(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 77630, 77961);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_78048_78373(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 78048, 78373);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_78458_78783(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 78458, 78783);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_78871_79169(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 78871, 79169);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_79255_79543(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 79255, 79543);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_79620_79949(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 79620, 79949);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class DiagnosticSuppressorForId : DiagnosticSuppressor
        {
            public SuppressionDescriptor SuppressionDescriptor { get; }

            public DiagnosticSuppressorForId(string suppressedDiagnosticId, string suppressionId = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 90054, 90441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 89981, 90040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 90179, 90426);

                    SuppressionDescriptor = f_25069_90203_90425(id: suppressionId ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(25069, 90255, 90281) ?? "SPR0001"), suppressedDiagnosticId: suppressedDiagnosticId, justification: $"Suppress {suppressedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 90054, 90441);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 90054, 90441);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 90054, 90441);
                }
            }

            public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 90550, 90597);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 90553, 90597);
                        return f_25069_90553_90597(f_25069_90575_90596()); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 90550, 90597);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 90550, 90597);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 90550, 90597);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void ReportSuppressions(SuppressionAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 90614, 91029);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 90722, 91014);
                        foreach (var diagnostic in f_25069_90749_90776_I(context.ReportedDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 90722, 91014);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 90818, 90892);

                            f_25069_90818_90891(f_25069_90831_90875(f_25069_90831_90852()), f_25069_90877_90890(diagnostic));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 90914, 90995);

                            context.ReportSuppression(Suppression.Create(f_25069_90959_90980(), diagnostic));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 90722, 91014);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 293);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 293);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 90614, 91029);

                    Microsoft.CodeAnalysis.SuppressionDescriptor
                    f_25069_90831_90852()
                    {
                        var return_v = SuppressionDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 90831, 90852);
                        return return_v;
                    }


                    string
                    f_25069_90831_90875(Microsoft.CodeAnalysis.SuppressionDescriptor
                    this_param)
                    {
                        var return_v = this_param.SuppressedDiagnosticId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 90831, 90875);
                        return return_v;
                    }


                    string
                    f_25069_90877_90890(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 90877, 90890);
                        return return_v;
                    }


                    int
                    f_25069_90818_90891(string
                    expected, string
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 90818, 90891);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SuppressionDescriptor
                    f_25069_90959_90980()
                    {
                        var return_v = SuppressionDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 90959, 90980);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_25069_90749_90776_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 90749, 90776);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 90614, 91029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 90614, 91029);
                }
            }

            static DiagnosticSuppressorForId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 89809, 91040);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 89809, 91040);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 89809, 91040);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 89809, 91040);

            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_90203_90425(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id: id, suppressedDiagnosticId: suppressedDiagnosticId, justification: justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 90203, 90425);
                return return_v;
            }


            Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_90575_90596()
            {
                var return_v = SuppressionDescriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 90575, 90596);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
            f_25069_90553_90597(Microsoft.CodeAnalysis.SuppressionDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 90553, 90597);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class DiagnosticSuppressorForId_ThrowsOperationCancelledException : DiagnosticSuppressor
        {
            public CancellationTokenSource CancellationTokenSource { get; }

            public SuppressionDescriptor SuppressionDescriptor { get; }

            public DiagnosticSuppressorForId_ThrowsOperationCancelledException(string suppressedDiagnosticId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 91441, 91816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 91258, 91354);
                    this.CancellationTokenSource = f_25069_91324_91353(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 91368, 91427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 91571, 91801);

                    SuppressionDescriptor = f_25069_91595_91800(id: "SPR0001", suppressedDiagnosticId: suppressedDiagnosticId, justification: $"Suppress {suppressedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 91441, 91816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 91441, 91816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 91441, 91816);
                }
            }

            public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 91925, 91972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 91928, 91972);
                        return f_25069_91928_91972(f_25069_91950_91971()); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 91925, 91972);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 91925, 91972);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 91925, 91972);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void ReportSuppressions(SuppressionAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 91989, 92220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 92097, 92130);

                    f_25069_92097_92129(f_25069_92097_92120());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 92148, 92205);

                    context.CancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 91989, 92220);

                    System.Threading.CancellationTokenSource
                    f_25069_92097_92120()
                    {
                        var return_v = CancellationTokenSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 92097, 92120);
                        return return_v;
                    }


                    int
                    f_25069_92097_92129(System.Threading.CancellationTokenSource
                    this_param)
                    {
                        this_param.Cancel();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 92097, 92129);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 91989, 92220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 91989, 92220);
                }
            }

            static DiagnosticSuppressorForId_ThrowsOperationCancelledException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 91052, 92231);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 91052, 92231);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 91052, 92231);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 91052, 92231);

            System.Threading.CancellationTokenSource
            f_25069_91324_91353()
            {
                var return_v = new System.Threading.CancellationTokenSource();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 91324, 91353);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_91595_91800(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id: id, suppressedDiagnosticId: suppressedDiagnosticId, justification: justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 91595, 91800);
                return return_v;
            }


            Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_91950_91971()
            {
                var return_v = SuppressionDescriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 91950, 91971);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
            f_25069_91928_91972(Microsoft.CodeAnalysis.SuppressionDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 91928, 91972);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class DiagnosticSuppressorThrowsExceptionFromSupportedSuppressions : DiagnosticSuppressor
        {
            private readonly NotImplementedException _exception;

            public DiagnosticSuppressorThrowsExceptionFromSupportedSuppressions(NotImplementedException exception)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 92518, 92691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 92491, 92501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 92653, 92676);

                    _exception = exception;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 92518, 92691);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 92518, 92691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 92518, 92691);
                }
            }

            public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 92800, 92819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 92803, 92819);
                        throw _exception; DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 92800, 92819);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 92800, 92819);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 92800, 92819);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void ReportSuppressions(SuppressionAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 92836, 92941);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 92836, 92941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 92836, 92941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 92836, 92941);
                }
            }

            static DiagnosticSuppressorThrowsExceptionFromSupportedSuppressions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 92243, 92952);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 92243, 92952);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 92243, 92952);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 92243, 92952);
        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class DiagnosticSuppressorThrowsExceptionFromReportedSuppressions : DiagnosticSuppressor
        {
            private readonly SuppressionDescriptor _descriptor;

            private readonly NotImplementedException _exception;

            public DiagnosticSuppressorThrowsExceptionFromReportedSuppressions(string suppressedDiagnosticId, NotImplementedException exception)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 93303, 93701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 93209, 93220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 93276, 93286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 93468, 93645);

                    _descriptor = f_25069_93482_93644("SPR0001", suppressedDiagnosticId, $"Suppress {suppressedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 93663, 93686);

                    _exception = exception;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 93303, 93701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 93303, 93701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 93303, 93701);
                }
            }

            public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 93810, 93847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 93813, 93847);
                        return f_25069_93813_93847(_descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 93810, 93847);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 93810, 93847);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 93810, 93847);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void ReportSuppressions(SuppressionAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 93864, 94004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 93972, 93989);

                    throw _exception;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 93864, 94004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 93864, 94004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 93864, 94004);
                }
            }

            static DiagnosticSuppressorThrowsExceptionFromReportedSuppressions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 92964, 94015);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 92964, 94015);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 92964, 94015);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 92964, 94015);

            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_93482_93644(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id, suppressedDiagnosticId, justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 93482, 93644);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
            f_25069_93813_93847(Microsoft.CodeAnalysis.SuppressionDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 93813, 93847);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class DiagnosticSuppressor_UnsupportedSuppressionReported : DiagnosticSuppressor
        {
            private readonly SuppressionDescriptor _supportedDescriptor;

            private readonly SuppressionDescriptor _unsupportedDescriptor;

            public DiagnosticSuppressor_UnsupportedSuppressionReported(string suppressedDiagnosticId, string supportedSuppressionId, string unsupportedSuppressionId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 94377, 95000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 94264, 94284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 94338, 94360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 94563, 94762);

                    _supportedDescriptor = f_25069_94586_94761(supportedSuppressionId, suppressedDiagnosticId, $"Suppress {suppressedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 94782, 94985);

                    _unsupportedDescriptor = f_25069_94807_94984(unsupportedSuppressionId, suppressedDiagnosticId, $"Suppress {suppressedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 94377, 95000);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 94377, 95000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 94377, 95000);
                }
            }

            public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 95109, 95155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 95112, 95155);
                        return f_25069_95112_95155(_supportedDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 95109, 95155);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 95109, 95155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 95109, 95155);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void ReportSuppressions(SuppressionAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 95172, 95589);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 95280, 95574);
                        foreach (var diagnostic in f_25069_95307_95334_I(context.ReportedDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 95280, 95574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 95376, 95451);

                            f_25069_95376_95450(f_25069_95389_95434(_unsupportedDescriptor), f_25069_95436_95449(diagnostic));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 95473, 95555);

                            context.ReportSuppression(Suppression.Create(_unsupportedDescriptor, diagnostic));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 95280, 95574);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 295);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 95172, 95589);

                    string
                    f_25069_95389_95434(Microsoft.CodeAnalysis.SuppressionDescriptor
                    this_param)
                    {
                        var return_v = this_param.SuppressedDiagnosticId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 95389, 95434);
                        return return_v;
                    }


                    string
                    f_25069_95436_95449(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 95436, 95449);
                        return return_v;
                    }


                    int
                    f_25069_95376_95450(string
                    expected, string
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 95376, 95450);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_25069_95307_95334_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 95307, 95334);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 95172, 95589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 95172, 95589);
                }
            }

            static DiagnosticSuppressor_UnsupportedSuppressionReported()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 94027, 95600);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 94027, 95600);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 94027, 95600);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 94027, 95600);

            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_94586_94761(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id, suppressedDiagnosticId, justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 94586, 94761);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_94807_94984(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id, suppressedDiagnosticId, justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 94807, 94984);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
            f_25069_95112_95155(Microsoft.CodeAnalysis.SuppressionDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 95112, 95155);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class DiagnosticSuppressor_InvalidDiagnosticSuppressionReported : DiagnosticSuppressor
        {
            private readonly SuppressionDescriptor _supportedDescriptor;

            private readonly SuppressionDescriptor _unsupportedDescriptor;

            public DiagnosticSuppressor_InvalidDiagnosticSuppressionReported(string suppressedDiagnosticId, string unsupportedSuppressedDiagnosticId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 95968, 96569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 95855, 95875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 95929, 95951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 96138, 96324);

                    _supportedDescriptor = f_25069_96161_96323("SPR0001", suppressedDiagnosticId, $"Suppress {suppressedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 96344, 96554);

                    _unsupportedDescriptor = f_25069_96369_96553("SPR0002", unsupportedSuppressedDiagnosticId, $"Suppress {unsupportedSuppressedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 95968, 96569);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 95968, 96569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 95968, 96569);
                }
            }

            public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 96678, 96724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 96681, 96724);
                        return f_25069_96681_96724(_supportedDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 96678, 96724);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 96678, 96724);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 96678, 96724);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void ReportSuppressions(SuppressionAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 96741, 97156);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 96849, 97141);
                        foreach (var diagnostic in f_25069_96876_96903_I(context.ReportedDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 96849, 97141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 96945, 97018);

                            f_25069_96945_97017(f_25069_96958_97001(_supportedDescriptor), f_25069_97003_97016(diagnostic));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 97040, 97122);

                            context.ReportSuppression(Suppression.Create(_unsupportedDescriptor, diagnostic));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 96849, 97141);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25069, 1, 293);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25069, 1, 293);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 96741, 97156);

                    string
                    f_25069_96958_97001(Microsoft.CodeAnalysis.SuppressionDescriptor
                    this_param)
                    {
                        var return_v = this_param.SuppressedDiagnosticId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 96958, 97001);
                        return return_v;
                    }


                    string
                    f_25069_97003_97016(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 97003, 97016);
                        return return_v;
                    }


                    int
                    f_25069_96945_97017(string
                    expected, string
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 96945, 97017);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_25069_96876_96903_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 96876, 96903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 96741, 97156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 96741, 97156);
                }
            }

            static DiagnosticSuppressor_InvalidDiagnosticSuppressionReported()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 95612, 97167);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 95612, 97167);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 95612, 97167);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 95612, 97167);

            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_96161_96323(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id, suppressedDiagnosticId, justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 96161, 96323);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_96369_96553(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id, suppressedDiagnosticId, justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 96369, 96553);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
            f_25069_96681_96724(Microsoft.CodeAnalysis.SuppressionDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 96681, 96724);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class DiagnosticSuppressor_NonReportedDiagnosticCannotBeSuppressed : DiagnosticSuppressor
        {
            private readonly SuppressionDescriptor _descriptor1, _descriptor2;

            private readonly string _nonReportedDiagnosticId;

            public DiagnosticSuppressor_NonReportedDiagnosticCannotBeSuppressed(string reportedDiagnosticId, string nonReportedDiagnosticId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 97531, 98148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 97425, 97437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 97439, 97451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 97490, 97514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 97692, 97866);

                    _descriptor1 = f_25069_97707_97865("SPR0001", reportedDiagnosticId, $"Suppress {reportedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 97884, 98064);

                    _descriptor2 = f_25069_97899_98063("SPR0002", nonReportedDiagnosticId, $"Suppress {nonReportedDiagnosticId}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 98082, 98133);

                    _nonReportedDiagnosticId = nonReportedDiagnosticId;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 97531, 98148);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 97531, 98148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 97531, 98148);
                }
            }

            public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 98257, 98309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 98260, 98309);
                        return f_25069_98260_98309(_descriptor1, _descriptor2); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 98257, 98309);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 98257, 98309);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 98257, 98309);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void ReportSuppressions(SuppressionAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 98326, 98942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 98434, 98826);

                    var
                    nonReportedDiagnostic = f_25069_98462_98825(id: _nonReportedDiagnosticId, category: "Category", message: "Message", severity: DiagnosticSeverity.Warning, defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true, warningLevel: 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 98844, 98927);

                    context.ReportSuppression(Suppression.Create(_descriptor2, nonReportedDiagnostic));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 98326, 98942);

                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_98462_98825(string
                    id, string
                    category, string
                    message, Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity, Microsoft.CodeAnalysis.DiagnosticSeverity
                    defaultSeverity, bool
                    isEnabledByDefault, int
                    warningLevel)
                    {
                        var return_v = Diagnostic.Create(id: id, category: category, message: (Microsoft.CodeAnalysis.LocalizableString)message, severity: severity, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, warningLevel: warningLevel);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 98462, 98825);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 98326, 98942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 98326, 98942);
                }
            }

            static DiagnosticSuppressor_NonReportedDiagnosticCannotBeSuppressed()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 97179, 98953);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 97179, 98953);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 97179, 98953);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 97179, 98953);

            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_97707_97865(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id, suppressedDiagnosticId, justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 97707, 97865);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SuppressionDescriptor
            f_25069_97899_98063(string
            id, string
            suppressedDiagnosticId, string
            justification)
            {
                var return_v = new Microsoft.CodeAnalysis.SuppressionDescriptor(id, suppressedDiagnosticId, justification);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 97899, 98063);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
            f_25069_98260_98309(Microsoft.CodeAnalysis.SuppressionDescriptor
            item1, Microsoft.CodeAnalysis.SuppressionDescriptor
            item2)
            {
                var return_v = ImmutableArray.Create(item1, item2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 98260, 98309);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class NamedTypeAnalyzer : DiagnosticAnalyzer
        {
            public enum AnalysisKind
            {
                Symbol,
                SymbolStartEnd,
                CompilationStartEnd
            }

            public const string
            RuleId = "ID1"
            ;

            public const string
            RuleCategory = "Category1"
            ;

            private readonly DiagnosticDescriptor _rule;

            private readonly AnalysisKind _analysisKind;

            private readonly GeneratedCodeAnalysisFlags _analysisFlags;

            private readonly ConcurrentSet<ISymbol> _symbolCallbacks;

            public NamedTypeAnalyzer(AnalysisKind analysisKind, GeneratedCodeAnalysisFlags analysisFlags = GeneratedCodeAnalysisFlags.None, bool configurable = true)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 99664, 100476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99440, 99445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99490, 99503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99562, 99576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99631, 99647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99850, 99879);

                    _analysisKind = analysisKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99897, 99928);

                    _analysisFlags = analysisFlags;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99946, 99994);

                    _symbolCallbacks = f_25069_99965_99993();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 100014, 100120);

                    var
                    customTags = (DynAbs.Tracing.TraceSender.Conditional_F1(25069, 100031, 100043) || ((configurable && DynAbs.Tracing.TraceSender.Conditional_F2(25069, 100046, 100067)) || DynAbs.Tracing.TraceSender.Conditional_F3(25069, 100070, 100119))) ? f_25069_100046_100067() : new[] { WellKnownDiagnosticTags.NotConfigurable }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 100138, 100461);

                    _rule = f_25069_100146_100460(RuleId, "Title1", "Symbol: {0}", RuleCategory, defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true, customTags: customTags);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 99664, 100476);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 99664, 100476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 99664, 100476);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 100566, 100597);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 100569, 100597);
                        return f_25069_100569_100597(_rule); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 100566, 100597);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 100566, 100597);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 100566, 100597);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public string GetSortedSymbolCallbacksString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 100659, 100725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 100662, 100725);
                    return f_25069_100662_100725(", ", f_25069_100680_100724(f_25069_100680_100716(_symbolCallbacks, s => s.Name))); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 100659, 100725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 100659, 100725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 100659, 100725);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Generic.IEnumerable<string>
                f_25069_100680_100716(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
                source, System.Func<Microsoft.CodeAnalysis.ISymbol, string>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.ISymbol, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 100680, 100716);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_25069_100680_100724(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Order<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 100680, 100724);
                    return return_v;
                }


                string
                f_25069_100662_100725(string
                separator, System.Linq.IOrderedEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 100662, 100725);
                    return return_v;
                }

            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 100742, 102718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 100831, 100886);

                    f_25069_100831_100885(context, _analysisFlags);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 100906, 102703);

                    switch (_analysisKind)
                    {

                        case AnalysisKind.Symbol:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 100906, 102703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 101020, 101285);

                            f_25069_101020_101284(context, c =>
                                {
                                    _symbolCallbacks.Add(c.Symbol);
                                    ReportDiagnostic(c.Symbol, c.ReportDiagnostic);
                                }, SymbolKind.NamedType);
                            DynAbs.Tracing.TraceSender.TraceBreak(25069, 101311, 101317);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 100906, 102703);

                        case AnalysisKind.SymbolStartEnd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 100906, 102703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 101400, 101880);

                            f_25069_101400_101879(context, symbolStartContext =>
                            {
                                symbolStartContext.RegisterSymbolEndAction(symbolEndContext =>
                                {
                                    _symbolCallbacks.Add(symbolEndContext.Symbol);
                                    ReportDiagnostic(symbolEndContext.Symbol, symbolEndContext.ReportDiagnostic);
                                });
                            }, SymbolKind.NamedType);
                            DynAbs.Tracing.TraceSender.TraceBreak(25069, 101908, 101914);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 100906, 102703);

                        case AnalysisKind.CompilationStartEnd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 100906, 102703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 102002, 102650);

                            f_25069_102002_102649(context, compilationStartContext =>
                            {
                                compilationStartContext.RegisterSymbolAction(c =>
                                {
                                    _symbolCallbacks.Add(c.Symbol);
                                }, SymbolKind.NamedType);

                                compilationStartContext.RegisterCompilationEndAction(
                                    compilationEndContext => compilationEndContext.ReportDiagnostic(
                                        Diagnostic.Create(_rule, Location.None, GetSortedSymbolCallbacksString())));
                            });
                            DynAbs.Tracing.TraceSender.TraceBreak(25069, 102678, 102684);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 100906, 102703);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 100742, 102718);

                    int
                    f_25069_100831_100885(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                    analysisMode)
                    {
                        this_param.ConfigureGeneratedCodeAnalysis(analysisMode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 100831, 100885);
                        return 0;
                    }


                    int
                    f_25069_101020_101284(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 101020, 101284);
                        return 0;
                    }


                    int
                    f_25069_101400_101879(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                    action, Microsoft.CodeAnalysis.SymbolKind
                    symbolKind)
                    {
                        this_param.RegisterSymbolStartAction(action, symbolKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 101400, 101879);
                        return 0;
                    }


                    int
                    f_25069_102002_102649(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 102002, 102649);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 100742, 102718);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 100742, 102718);
                }
            }

            private void ReportDiagnostic(ISymbol symbol, Action<Diagnostic> reportDiagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 102834, 102913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 102837, 102913);
                    f_25069_102837_102913(reportDiagnostic, f_25069_102854_102912(_rule, f_25069_102879_102895(symbol)[0], f_25069_102900_102911(symbol))); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 102834, 102913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 102834, 102913);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 102834, 102913);
                }

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_25069_102879_102895(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 102879, 102895);
                    return return_v;
                }


                string
                f_25069_102900_102911(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 102900, 102911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25069_102854_102912(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 102854, 102912);
                    return return_v;
                }


                int
                f_25069_102837_102913(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 102837, 102913);
                    return 0;
                }

            }

            static NamedTypeAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 98965, 102925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99312, 99326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 99361, 99387);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 98965, 102925);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 98965, 102925);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 98965, 102925);

            static Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>
            f_25069_99965_99993()
            {
                var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.ISymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 99965, 99993);
                return return_v;
            }


            static string[]
            f_25069_100046_100067()
            {
                var return_v = Array.Empty<string>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 100046, 100067);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_100146_100460(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 100146, 100460);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_100569_100597(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 100569, 100597);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class AnalyzerWithNoLocationDiagnostics : DiagnosticAnalyzer
        {
            public AnalyzerWithNoLocationDiagnostics(bool isEnabledByDefault)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 103115, 103503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 103519, 103566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 103213, 103488);

                    Descriptor = f_25069_103226_103487("ID0001", "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 103115, 103503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 103115, 103503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 103115, 103503);
                }
            }

            public DiagnosticDescriptor Descriptor { get; }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 103656, 103692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 103659, 103692);
                        return f_25069_103659_103692(f_25069_103681_103691()); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 103656, 103692);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 103656, 103692);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 103656, 103692);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 103707, 103971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 103796, 103956);

                    f_25069_103796_103955(context, compilationContext =>
                        compilationContext.ReportDiagnostic(Diagnostic.Create(Descriptor, Location.None)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 103707, 103971);

                    int
                    f_25069_103796_103955(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 103796, 103955);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 103707, 103971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 103707, 103971);
                }
            }

            static AnalyzerWithNoLocationDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 102937, 103982);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 102937, 103982);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 102937, 103982);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 102937, 103982);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_103226_103487(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 103226, 103487);
                return return_v;
            }


            Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_103681_103691()
            {
                var return_v = Descriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 103681, 103691);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_103659_103692(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 103659, 103692);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class NamedTypeAnalyzerWithConfigurableEnabledByDefault : DiagnosticAnalyzer
        {
            private readonly bool _throwOnAllNamedTypes;

            public NamedTypeAnalyzerWithConfigurableEnabledByDefault(bool isEnabledByDefault, DiagnosticSeverity defaultSeverity, bool throwOnAllNamedTypes = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 104246, 104756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 104210, 104231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 104772, 104819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 104431, 104678);

                    Descriptor = f_25069_104444_104677("ID0001", "Title1", "Message1", "Category1", defaultSeverity, isEnabledByDefault);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 104696, 104741);

                    _throwOnAllNamedTypes = throwOnAllNamedTypes;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 104246, 104756);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 104246, 104756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 104246, 104756);
                }
            }

            public DiagnosticDescriptor Descriptor { get; }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 104909, 104945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 104912, 104945);
                        return f_25069_104912_104945(f_25069_104934_104944()); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 104909, 104945);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 104909, 104945);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 104909, 104945);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 104960, 105479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 105049, 105464);

                    f_25069_105049_105463(context, context =>
                        {
                            if (_throwOnAllNamedTypes)
                            {
                                throw new NotImplementedException();
                            }

                            context.ReportDiagnostic(Diagnostic.Create(Descriptor, context.Symbol.Locations[0]));
                        }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 104960, 105479);

                    int
                    f_25069_105049_105463(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 105049, 105463);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 104960, 105479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 104960, 105479);
                }
            }

            static NamedTypeAnalyzerWithConfigurableEnabledByDefault()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 103994, 105490);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 103994, 105490);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 103994, 105490);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 103994, 105490);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_104444_104677(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 104444, 104677);
                return return_v;
            }


            Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_104934_104944()
            {
                var return_v = Descriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 104934, 104944);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_104912_104945(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 104912, 104945);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class RegisterOperationBlockAndOperationActionAnalyzer : DiagnosticAnalyzer
        {
            private static readonly DiagnosticDescriptor s_descriptor;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 106086, 106124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 106089, 106124);
                        return f_25069_106089_106124(s_descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 106086, 106124);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 106086, 106124);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 106086, 106124);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 106139, 106418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 106236, 106312);

                    f_25069_106236_106311(analysisContext, _ => { }, OperationKind.Invocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 106330, 106403);

                    f_25069_106330_106402(analysisContext, OnOperationBlockStart);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 106139, 106418);

                    int
                    f_25069_106236_106311(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                    action, params Microsoft.CodeAnalysis.OperationKind[]
                    operationKinds)
                    {
                        this_param.RegisterOperationAction(action, operationKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 106236, 106311);
                        return 0;
                    }


                    int
                    f_25069_106330_106402(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterOperationBlockStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 106330, 106402);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 106139, 106418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 106139, 106418);
                }
            }

            private void OnOperationBlockStart(OperationBlockStartAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 106434, 106733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 106545, 106718);

                    f_25069_106545_106717(context, endContext => endContext.ReportDiagnostic(Diagnostic.Create(s_descriptor, context.OwningSymbol.Locations[0])));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 106434, 106733);

                    int
                    f_25069_106545_106717(Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                    action)
                    {
                        this_param.RegisterOperationBlockEndAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 106545, 106717);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 106434, 106733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 106434, 106733);
                }
            }

            public RegisterOperationBlockAndOperationActionAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 105502, 106744);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 105502, 106744);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 105502, 106744);
            }


            static RegisterOperationBlockAndOperationActionAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 105502, 106744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 105740, 105995);
                s_descriptor = f_25069_105755_105995("ID0001", "Title", "Message", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 105502, 106744);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 105502, 106744);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 105502, 106744);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_105755_105995(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 105755, 105995);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_106089_106124(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 106089, 106124);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp)]
        public sealed class FieldAnalyzer : DiagnosticAnalyzer
        {
            private readonly bool _syntaxTreeAction;

            public FieldAnalyzer(string diagnosticId, bool syntaxTreeAction)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 106941, 107390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 106909, 106926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 107406, 107453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 107038, 107075);

                    _syntaxTreeAction = syntaxTreeAction;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 107093, 107375);

                    Descriptor = f_25069_107106_107374(diagnosticId, "Title", "Message", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 106941, 107390);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 106941, 107390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 106941, 107390);
                }
            }

            public DiagnosticDescriptor Descriptor { get; }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 107543, 107579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 107546, 107579);
                        return f_25069_107546_107579(f_25069_107568_107578()); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 107543, 107579);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 107543, 107579);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 107543, 107579);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 107596, 108551);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 107685, 108536) || true) && (_syntaxTreeAction)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 107685, 108536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 107748, 108240);

                        f_25069_107748_108239(context, context =>
                        {
                            var fields = context.Tree.GetRoot().DescendantNodes().OfType<CSharp.Syntax.FieldDeclarationSyntax>();
                            foreach (var variable in fields.SelectMany(f => f.Declaration.Variables))
                            {
                                context.ReportDiagnostic(Diagnostic.Create(Descriptor, variable.Identifier.GetLocation()));
                            }
                        });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 107685, 108536);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 107685, 108536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 108322, 108517);

                        f_25069_108322_108516(context, context => context.ReportDiagnostic(Diagnostic.Create(Descriptor, context.Symbol.Locations[0])), SymbolKind.Field);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 107685, 108536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 107596, 108551);

                    int
                    f_25069_107748_108239(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 107748, 108239);
                        return 0;
                    }


                    int
                    f_25069_108322_108516(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 108322, 108516);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 107596, 108551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 107596, 108551);
                }
            }

            static FieldAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 106756, 108562);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 106756, 108562);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 106756, 108562);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 106756, 108562);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_107106_107374(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 107106, 107374);
                return return_v;
            }


            Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_107568_107578()
            {
                var return_v = Descriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 107568, 107578);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_107546_107579(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 107546, 107579);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public class AdditionalFileAnalyzer : DiagnosticAnalyzer
        {
            private readonly bool _registerFromInitialize;

            private readonly TextSpan _diagnosticSpan;

            public AdditionalFileAnalyzer(bool registerFromInitialize, TextSpan diagnosticSpan, string id = "ID0001")
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 108852, 109400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 108756, 108779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 109416, 109463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 108990, 109039);

                    _registerFromInitialize = registerFromInitialize;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 109057, 109090);

                    _diagnosticSpan = diagnosticSpan;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 109110, 109385);

                    Descriptor = f_25069_109123_109384(id, "Title1", "Message1", "Category1", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 108852, 109400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 108852, 109400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 108852, 109400);
                }
            }

            public DiagnosticDescriptor Descriptor { get; }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 109553, 109589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 109556, 109589);
                        return f_25069_109556_109589(f_25069_109578_109588()); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 109553, 109589);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 109553, 109589);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 109553, 109589);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 109604, 110074);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 109693, 110059) || true) && (_registerFromInitialize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 109693, 110059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 109762, 109822);

                        f_25069_109762_109821(context, AnalyzeAdditionalFile);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 109693, 110059);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 109693, 110059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 109904, 110040);

                        f_25069_109904_110039(context, context =>
                            context.RegisterAdditionalFileAction(AnalyzeAdditionalFile));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 109693, 110059);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 109604, 110074);

                    int
                    f_25069_109762_109821(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext>
                    action)
                    {
                        this_param.RegisterAdditionalFileAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 109762, 109821);
                        return 0;
                    }


                    int
                    f_25069_109904_110039(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 109904, 110039);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 109604, 110074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 109604, 110074);
                }
            }

            private void AnalyzeAdditionalFile(AdditionalFileAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 110090, 110610);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 110196, 110303) || true) && (f_25069_110200_110227(context.AdditionalFile) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25069, 110196, 110303);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 110277, 110284);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25069, 110196, 110303);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 110323, 110367);

                    var
                    text = f_25069_110334_110366(context.AdditionalFile)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 110385, 110511);

                    var
                    location = f_25069_110400_110510(f_25069_110416_110443(context.AdditionalFile), _diagnosticSpan, f_25069_110462_110509(f_25069_110462_110472(text), _diagnosticSpan))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 110529, 110595);

                    context.ReportDiagnostic(f_25069_110554_110593(f_25069_110572_110582(), location));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 110090, 110610);

                    string
                    f_25069_110200_110227(Microsoft.CodeAnalysis.AdditionalText
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 110200, 110227);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceText?
                    f_25069_110334_110366(Microsoft.CodeAnalysis.AdditionalText
                    this_param)
                    {
                        var return_v = this_param.GetText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 110334, 110366);
                        return return_v;
                    }


                    string
                    f_25069_110416_110443(Microsoft.CodeAnalysis.AdditionalText
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 110416, 110443);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextLineCollection
                    f_25069_110462_110472(Microsoft.CodeAnalysis.Text.SourceText?
                    this_param)
                    {
                        var return_v = this_param.Lines;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 110462, 110472);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.LinePositionSpan
                    f_25069_110462_110509(Microsoft.CodeAnalysis.Text.TextLineCollection
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = this_param.GetLinePositionSpan(span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 110462, 110509);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_25069_110400_110510(string
                    filePath, Microsoft.CodeAnalysis.Text.TextSpan
                    textSpan, Microsoft.CodeAnalysis.Text.LinePositionSpan
                    lineSpan)
                    {
                        var return_v = Location.Create(filePath, textSpan, lineSpan);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 110400, 110510);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_25069_110572_110582()
                    {
                        var return_v = Descriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 110572, 110582);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_25069_110554_110593(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 110554, 110593);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 110090, 110610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 110090, 110610);
                }
            }

            static AdditionalFileAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 108574, 110621);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 108574, 110621);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 108574, 110621);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 108574, 110621);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_109123_109384(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 109123, 109384);
                return return_v;
            }


            Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_109578_109588()
            {
                var return_v = Descriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 109578, 109588);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_109556_109589(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 109556, 109589);
                return return_v;
            }

        }
        [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
        public sealed class RegisterSyntaxTreeCancellationAnalyzer : DiagnosticAnalyzer
        {
            public const string
            DiagnosticId = "ID0001"
            ;

            private static readonly DiagnosticDescriptor s_descriptor;

            private readonly CancellationTokenSource _cancellationTokenSource;

            public CancellationToken CancellationToken
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 111348, 111381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 111351, 111381);
                        return f_25069_111351_111381(_cancellationTokenSource); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 111348, 111381);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 111348, 111381);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 111348, 111381);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 111472, 111510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 111475, 111510);
                        return f_25069_111475_111510(s_descriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 111472, 111510);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 111472, 111510);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 111472, 111510);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25069, 111525, 112364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 111614, 112349);

                    f_25069_111614_112348(context, context =>
                    {
                    // Mimic cancellation by throwing an OperationCanceledException in first callback.
                    if (!_cancellationTokenSource.IsCancellationRequested)
                        {
                            _cancellationTokenSource.Cancel();

                            while (true)
                            {
                                context.CancellationToken.ThrowIfCancellationRequested();
                            }

                            throw ExceptionUtilities.Unreachable;
                        }

                        context.ReportDiagnostic(Diagnostic.Create(s_descriptor, context.Tree.GetRoot().GetLocation()));
                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25069, 111525, 112364);

                    int
                    f_25069_111614_112348(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 111614, 112348);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25069, 111525, 112364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 111525, 112364);
                }
            }

            public RegisterSyntaxTreeCancellationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25069, 110633, 112375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 111234, 111290);
                this._cancellationTokenSource = f_25069_111261_111290(); DynAbs.Tracing.TraceSender.TraceExitConstructor(25069, 110633, 112375);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 110633, 112375);
            }


            static RegisterSyntaxTreeCancellationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 110633, 112375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 110836, 110859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25069, 110919, 111178);
                s_descriptor = f_25069_110934_111178(DiagnosticId, "Title", "Message", "Category", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 110633, 112375);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 110633, 112375);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25069, 110633, 112375);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25069_110934_111178(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 110934, 111178);
                return return_v;
            }


            System.Threading.CancellationTokenSource
            f_25069_111261_111290()
            {
                var return_v = new System.Threading.CancellationTokenSource();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 111261, 111290);
                return return_v;
            }


            System.Threading.CancellationToken
            f_25069_111351_111381(System.Threading.CancellationTokenSource
            this_param)
            {
                var return_v = this_param.Token;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25069, 111351, 111381);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
            f_25069_111475_111510(Microsoft.CodeAnalysis.DiagnosticDescriptor
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25069, 111475, 111510);
                return return_v;
            }

        }

        static CommonDiagnosticAnalyzers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25069, 734, 112382);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25069, 734, 112382);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25069, 734, 112382);
        }

    }
}
