// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class GeneratedNames
    {
        internal const string
        SynthesizedLocalNamePrefix = "CS$"
        ;

        internal const char
        DotReplacementInTypeNames = '-'
        ;

        private const string
        SuffixSeparator = "__"
        ;

        private const char
        IdSeparator = '_'
        ;

        private const char
        GenerationSeparator = '#'
        ;

        private const char
        LocalFunctionNameTerminator = '|'
        ;

        internal static bool IsGeneratedMemberName(string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 922, 1072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 1008, 1061);

                return f_10663_1015_1032(memberName) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10663, 1015, 1060) && f_10663_1040_1053(memberName, 0) == '<');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 922, 1072);

                int
                f_10663_1015_1032(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 1015, 1032);
                    return return_v;
                }


                char
                f_10663_1040_1053(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 1040, 1053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 922, 1072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 922, 1072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeBackingFieldName(string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 1084, 1315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 1173, 1243);

                f_10663_1173_1242((char)GeneratedNameKind.AutoPropertyBackingField == 'k');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 1257, 1304);

                return "<" + propertyName + ">k__BackingField";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 1084, 1315);

                int
                f_10663_1173_1242(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 1173, 1242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 1084, 1315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 1084, 1315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeIteratorFinallyMethodName(int iteratorState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 1327, 1873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 1700, 1767);

                f_10663_1700_1766((char)GeneratedNameKind.IteratorFinallyMethod == 'm');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 1781, 1862);

                return "<>m__Finally" + f_10663_1805_1861(f_10663_1833_1860(iteratorState + 2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 1327, 1873);

                int
                f_10663_1700_1766(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 1700, 1766);
                    return 0;
                }


                int
                f_10663_1833_1860(int
                value)
                {
                    var return_v = Math.Abs(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 1833, 1860);
                    return return_v;
                }


                string
                f_10663_1805_1861(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 1805, 1861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 1327, 1873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 1327, 1873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeStaticLambdaDisplayClassName(int methodOrdinal, int generation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 1885, 2115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 2000, 2104);

                return f_10663_2007_2103(GeneratedNameKind.LambdaDisplayClass, methodOrdinal, generation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 1885, 2115);

                string
                f_10663_2007_2103(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, int
                methodOrdinal, int
                methodGeneration)
                {
                    var return_v = MakeMethodScopedSynthesizedName(kind, methodOrdinal, methodGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 2007, 2103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 1885, 2115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 1885, 2115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeLambdaDisplayClassName(int methodOrdinal, int generation, int closureOrdinal, int closureGeneration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 2127, 2632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 2327, 2362);

                f_10663_2327_2361(closureOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 2376, 2409);

                f_10663_2376_2408(methodOrdinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 2425, 2621);

                return f_10663_2432_2620(GeneratedNameKind.LambdaDisplayClass, methodOrdinal, generation, suffix: "DisplayClass", entityOrdinal: closureOrdinal, entityGeneration: closureGeneration);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 2127, 2632);

                int
                f_10663_2327_2361(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 2327, 2361);
                    return 0;
                }


                int
                f_10663_2376_2408(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 2376, 2408);
                    return 0;
                }


                string
                f_10663_2432_2620(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, int
                methodOrdinal, int
                methodGeneration, string
                suffix, int
                entityOrdinal, int
                entityGeneration)
                {
                    var return_v = MakeMethodScopedSynthesizedName(kind, methodOrdinal, methodGeneration, suffix: suffix, entityOrdinal: entityOrdinal, entityGeneration: entityGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 2432, 2620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 2127, 2632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 2127, 2632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeAnonymousTypeTemplateName(int index, int submissionSlotIndex, string moduleId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 2644, 3052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 2774, 2859);

                var
                name = "<" + moduleId + ">f__AnonymousType" + f_10663_2824_2858(index)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 2873, 3013) || true) && (submissionSlotIndex >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 2873, 3013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 2935, 2998);

                    name += "#" + f_10663_2949_2997(submissionSlotIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 2873, 3013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3029, 3041);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 2644, 3052);

                string
                f_10663_2824_2858(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 2824, 2858);
                    return return_v;
                }


                string
                f_10663_2949_2997(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 2949, 2997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 2644, 3052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 2644, 3052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        AnonymousNamePrefix = "<>f__AnonymousType"
        ;

        internal static bool TryParseAnonymousTypeTemplateName(string name, out int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 3141, 3743);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3370, 3678) || true) && (f_10663_3374_3436(name, AnonymousNamePrefix, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 3370, 3678);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3470, 3663) || true) && (f_10663_3474_3590(f_10663_3487_3529(name, f_10663_3502_3528(AnonymousNamePrefix)), NumberStyles.None, f_10663_3550_3578(), out index))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 3470, 3663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3632, 3644);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 3470, 3663);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 3370, 3678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3694, 3705);

                index = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3719, 3732);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 3141, 3743);

                bool
                f_10663_3374_3436(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 3374, 3436);
                    return return_v;
                }


                int
                f_10663_3502_3528(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 3502, 3528);
                    return return_v;
                }


                string
                f_10663_3487_3529(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 3487, 3529);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10663_3550_3578()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 3550, 3578);
                    return return_v;
                }


                bool
                f_10663_3474_3590(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 3474, 3590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 3141, 3743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 3141, 3743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeAnonymousTypeBackingFieldName(string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 3755, 3908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3857, 3897);

                return "<" + propertyName + ">i__Field";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 3755, 3908);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 3755, 3908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 3755, 3908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeAnonymousTypeParameterName(string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 3920, 4069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4019, 4058);

                return "<" + propertyName + ">j__TPar";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 3920, 4069);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 3920, 4069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 3920, 4069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseAnonymousTypeParameterName(string typeParameterName, out string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 4081, 4589);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4212, 4515) || true) && (f_10663_4216_4275(typeParameterName, "<", StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(10663, 4216, 4360) && f_10663_4296_4360(typeParameterName, ">j__TPar", StringComparison.Ordinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 4212, 4515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4394, 4470);

                    propertyName = f_10663_4409_4469(typeParameterName, 1, f_10663_4440_4464(typeParameterName) - 9);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4488, 4500);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 4212, 4515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4531, 4551);

                propertyName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4565, 4578);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 4081, 4589);

                bool
                f_10663_4216_4275(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 4216, 4275);
                    return return_v;
                }


                bool
                f_10663_4296_4360(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 4296, 4360);
                    return return_v;
                }


                int
                f_10663_4440_4464(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 4440, 4464);
                    return return_v;
                }


                string
                f_10663_4409_4469(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 4409, 4469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 4081, 4589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 4081, 4589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeStateMachineTypeName(string methodName, int methodOrdinal, int generation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 4601, 4946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4727, 4757);

                f_10663_4727_4756(generation >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4771, 4805);

                f_10663_4771_4804(methodOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 4821, 4935);

                return f_10663_4828_4934(GeneratedNameKind.StateMachineType, methodOrdinal, generation, methodName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 4601, 4946);

                int
                f_10663_4727_4756(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 4727, 4756);
                    return 0;
                }


                int
                f_10663_4771_4804(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 4771, 4804);
                    return 0;
                }


                string
                f_10663_4828_4934(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, int
                methodOrdinal, int
                methodGeneration, string
                methodNameOpt)
                {
                    var return_v = MakeMethodScopedSynthesizedName(kind, methodOrdinal, methodGeneration, methodNameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 4828, 4934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 4601, 4946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 4601, 4946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeBaseMethodWrapperName(int uniqueId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 4958, 5188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 5045, 5108);

                f_10663_5045_5107((char)GeneratedNameKind.BaseMethodWrapper == 'n');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 5122, 5177);

                return "<>n__" + f_10663_5139_5176(uniqueId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 4958, 5188);

                int
                f_10663_5045_5107(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 5045, 5107);
                    return 0;
                }


                string
                f_10663_5139_5176(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 5139, 5176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 4958, 5188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 4958, 5188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeLambdaMethodName(string methodName, int methodOrdinal, int methodGeneration, int lambdaOrdinal, int lambdaGeneration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 5200, 5918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 5369, 5403);

                f_10663_5369_5402(methodOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 5417, 5453);

                f_10663_5417_5452(methodGeneration >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 5467, 5500);

                f_10663_5467_5499(lambdaOrdinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 5514, 5550);

                f_10663_5514_5549(lambdaGeneration >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 5725, 5907);

                return f_10663_5732_5906(GeneratedNameKind.LambdaMethod, methodOrdinal, methodGeneration, methodName, entityOrdinal: lambdaOrdinal, entityGeneration: lambdaGeneration);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 5200, 5918);

                int
                f_10663_5369_5402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 5369, 5402);
                    return 0;
                }


                int
                f_10663_5417_5452(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 5417, 5452);
                    return 0;
                }


                int
                f_10663_5467_5499(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 5467, 5499);
                    return 0;
                }


                int
                f_10663_5514_5549(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 5514, 5549);
                    return 0;
                }


                string
                f_10663_5732_5906(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, int
                methodOrdinal, int
                methodGeneration, string
                methodNameOpt, int
                entityOrdinal, int
                entityGeneration)
                {
                    var return_v = MakeMethodScopedSynthesizedName(kind, methodOrdinal, methodGeneration, methodNameOpt, entityOrdinal: entityOrdinal, entityGeneration: entityGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 5732, 5906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 5200, 5918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 5200, 5918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeLambdaCacheFieldName(int methodOrdinal, int generation, int lambdaOrdinal, int lambdaGeneration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 5930, 6354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6078, 6112);

                f_10663_6078_6111(methodOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6126, 6159);

                f_10663_6126_6158(lambdaOrdinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6175, 6343);

                return f_10663_6182_6342(GeneratedNameKind.LambdaCacheField, methodOrdinal, generation, entityOrdinal: lambdaOrdinal, entityGeneration: lambdaGeneration);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 5930, 6354);

                int
                f_10663_6078_6111(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6078, 6111);
                    return 0;
                }


                int
                f_10663_6126_6158(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6126, 6158);
                    return 0;
                }


                string
                f_10663_6182_6342(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, int
                methodOrdinal, int
                methodGeneration, int
                entityOrdinal, int
                entityGeneration)
                {
                    var return_v = MakeMethodScopedSynthesizedName(kind, methodOrdinal, methodGeneration, entityOrdinal: entityOrdinal, entityGeneration: entityGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6182, 6342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 5930, 6354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 5930, 6354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeLocalFunctionName(string methodName, string localFunctionName, int methodOrdinal, int methodGeneration, int lambdaOrdinal, int lambdaGeneration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 6366, 6968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6562, 6596);

                f_10663_6562_6595(methodOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6610, 6646);

                f_10663_6610_6645(methodGeneration >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6660, 6693);

                f_10663_6660_6692(lambdaOrdinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6707, 6743);

                f_10663_6707_6742(lambdaGeneration >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 6759, 6957);

                return f_10663_6766_6956(GeneratedNameKind.LocalFunction, methodOrdinal, methodGeneration, methodName, localFunctionName, LocalFunctionNameTerminator, lambdaOrdinal, lambdaGeneration);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 6366, 6968);

                int
                f_10663_6562_6595(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6562, 6595);
                    return 0;
                }


                int
                f_10663_6610_6645(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6610, 6645);
                    return 0;
                }


                int
                f_10663_6660_6692(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6660, 6692);
                    return 0;
                }


                int
                f_10663_6707_6742(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6707, 6742);
                    return 0;
                }


                string
                f_10663_6766_6956(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, int
                methodOrdinal, int
                methodGeneration, string
                methodNameOpt, string
                suffix, char
                suffixTerminator, int
                entityOrdinal, int
                entityGeneration)
                {
                    var return_v = MakeMethodScopedSynthesizedName(kind, methodOrdinal, methodGeneration, methodNameOpt, suffix, suffixTerminator, entityOrdinal, entityGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 6766, 6956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 6366, 6968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 6366, 6968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string MakeMethodScopedSynthesizedName(
                    GeneratedNameKind kind,
                    int methodOrdinal,
                    int methodGeneration,
                    string methodNameOpt = null,
                    string suffix = null,
                    char suffixTerminator = default,
                    int entityOrdinal = -1,
                    int entityGeneration = -1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 6980, 9852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7363, 7397);

                f_10663_7363_7396(methodOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7411, 7496);

                f_10663_7411_7495(methodGeneration >= 0 || (DynAbs.Tracing.TraceSender.Expression_False(10663, 7424, 7494) || methodGeneration == -1 && (DynAbs.Tracing.TraceSender.Expression_True(10663, 7449, 7494) && methodOrdinal == -1)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7510, 7544);

                f_10663_7510_7543(entityOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7558, 7643);

                f_10663_7558_7642(entityGeneration >= 0 || (DynAbs.Tracing.TraceSender.Expression_False(10663, 7571, 7641) || entityGeneration == -1 && (DynAbs.Tracing.TraceSender.Expression_True(10663, 7596, 7641) && entityOrdinal == -1)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7657, 7734);

                f_10663_7657_7733(entityGeneration == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10663, 7670, 7732) || entityGeneration >= methodGeneration));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7750, 7797);

                var
                result = f_10663_7763_7796()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7811, 7840);

                var
                builder = result.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7854, 7874);

                f_10663_7854_7873(builder, '<');

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7890, 8810) || true) && (methodNameOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 7890, 8810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 7949, 7979);

                    f_10663_7949_7978(builder, methodNameOpt);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 8665, 8795) || true) && (f_10663_8669_8686(kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 8665, 8795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 8728, 8776);

                        f_10663_8728_8775(builder, '.', DotReplacementInTypeNames);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 8665, 8795);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 7890, 8810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 8826, 8846);

                f_10663_8826_8845(
                            builder, '>');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 8860, 8887);

                f_10663_8860_8886(builder, kind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 8903, 9793) || true) && (suffix != null || (DynAbs.Tracing.TraceSender.Expression_False(10663, 8907, 8943) || methodOrdinal >= 0) || (DynAbs.Tracing.TraceSender.Expression_False(10663, 8907, 8965) || entityOrdinal >= 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 8903, 9793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 8999, 9031);

                    f_10663_8999_9030(builder, SuffixSeparator);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9049, 9072);

                    f_10663_9049_9071(builder, suffix);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9092, 9217) || true) && (suffixTerminator != default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 9092, 9217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9165, 9198);

                        f_10663_9165_9197(builder, suffixTerminator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 9092, 9217);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9237, 9424) || true) && (methodOrdinal >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 9237, 9424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9301, 9331);

                        f_10663_9301_9330(builder, methodOrdinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9353, 9405);

                        f_10663_9353_9404(builder, methodGeneration);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 9237, 9424);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9444, 9778) || true) && (entityOrdinal >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 9444, 9778);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9508, 9631) || true) && (methodOrdinal >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 9508, 9631);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9580, 9608);

                            f_10663_9580_9607(builder, IdSeparator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 9508, 9631);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9655, 9685);

                        f_10663_9655_9684(
                                            builder, entityOrdinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9707, 9759);

                        f_10663_9707_9758(builder, entityGeneration);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 9444, 9778);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 8903, 9793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9809, 9841);

                return f_10663_9816_9840(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 6980, 9852);

                int
                f_10663_7363_7396(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7363, 7396);
                    return 0;
                }


                int
                f_10663_7411_7495(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7411, 7495);
                    return 0;
                }


                int
                f_10663_7510_7543(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7510, 7543);
                    return 0;
                }


                int
                f_10663_7558_7642(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7558, 7642);
                    return 0;
                }


                int
                f_10663_7657_7733(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7657, 7733);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10663_7763_7796()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7763, 7796);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_7854_7873(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7854, 7873);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_7949_7978(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 7949, 7978);
                    return return_v;
                }


                bool
                f_10663_8669_8686(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind)
                {
                    var return_v = kind.IsTypeName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 8669, 8686);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_8728_8775(System.Text.StringBuilder
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 8728, 8775);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_8826_8845(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 8826, 8845);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_8860_8886(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                value)
                {
                    var return_v = this_param.Append((char)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 8860, 8886);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_8999_9030(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 8999, 9030);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_9049_9071(System.Text.StringBuilder
                this_param, string?
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9049, 9071);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_9165_9197(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9165, 9197);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_9301_9330(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9301, 9330);
                    return return_v;
                }


                int
                f_10663_9353_9404(System.Text.StringBuilder
                builder, int
                generation)
                {
                    AppendOptionalGeneration(builder, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9353, 9404);
                    return 0;
                }


                System.Text.StringBuilder
                f_10663_9580_9607(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9580, 9607);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_9655_9684(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9655, 9684);
                    return return_v;
                }


                int
                f_10663_9707_9758(System.Text.StringBuilder
                builder, int
                generation)
                {
                    AppendOptionalGeneration(builder, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9707, 9758);
                    return 0;
                }


                string
                f_10663_9816_9840(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 9816, 9840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 6980, 9852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 6980, 9852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AppendOptionalGeneration(StringBuilder builder, int generation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 9864, 10131);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 9972, 10120) || true) && (generation > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 9972, 10120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 10024, 10060);

                    f_10663_10024_10059(builder, GenerationSeparator);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 10078, 10105);

                    f_10663_10078_10104(builder, generation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 9972, 10120);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 9864, 10131);

                System.Text.StringBuilder
                f_10663_10024_10059(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 10024, 10059);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_10078_10104(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 10078, 10104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 9864, 10131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 9864, 10131);
            }
        }

        internal static string MakeHoistedLocalFieldName(SynthesizedLocalKind kind, int slotIndex, string localNameOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 10143, 11980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 10286, 10369);

                f_10663_10286_10368((localNameOpt != null) == (kind == SynthesizedLocalKind.UserDefined));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 10383, 10412);

                f_10663_10383_10411(slotIndex >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 10426, 10459);

                f_10663_10426_10458(f_10663_10439_10457(kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11014, 11061);

                var
                result = f_10663_11027_11060()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11075, 11104);

                var
                builder = result.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11118, 11138);

                f_10663_11118_11137(builder, '<');

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11152, 11318) || true) && (localNameOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 11152, 11318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11210, 11256);

                    f_10663_11210_11255(f_10663_11223_11248(localNameOpt, '.') == -1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11274, 11303);

                    f_10663_11274_11302(builder, localNameOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 11152, 11318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11334, 11354);

                f_10663_11334_11353(
                            builder, '>');

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11370, 11840) || true) && (kind == SynthesizedLocalKind.LambdaDisplayClass)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 11370, 11840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11455, 11520);

                    f_10663_11455_11519(builder, GeneratedNameKind.DisplayClassLocalOrField);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 11370, 11840);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 11370, 11840);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11554, 11840) || true) && (kind == SynthesizedLocalKind.UserDefined)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 11554, 11840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11632, 11690);

                        f_10663_11632_11689(builder, GeneratedNameKind.HoistedLocalField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 11554, 11840);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 11554, 11840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11756, 11825);

                        f_10663_11756_11824(builder, GeneratedNameKind.HoistedSynthesizedLocalField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 11554, 11840);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 11370, 11840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11856, 11877);

                f_10663_11856_11876(
                            builder, "__");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11891, 11921);

                f_10663_11891_11920(builder, slotIndex + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 11937, 11969);

                return f_10663_11944_11968(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 10143, 11980);

                int
                f_10663_10286_10368(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 10286, 10368);
                    return 0;
                }


                int
                f_10663_10383_10411(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 10383, 10411);
                    return 0;
                }


                bool
                f_10663_10439_10457(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 10439, 10457);
                    return return_v;
                }


                int
                f_10663_10426_10458(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 10426, 10458);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10663_11027_11060()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11027, 11060);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_11118_11137(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11118, 11137);
                    return return_v;
                }


                int
                f_10663_11223_11248(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11223, 11248);
                    return return_v;
                }


                int
                f_10663_11210_11255(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11210, 11255);
                    return 0;
                }


                System.Text.StringBuilder
                f_10663_11274_11302(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11274, 11302);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_11334_11353(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11334, 11353);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_11455_11519(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                value)
                {
                    var return_v = this_param.Append((char)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11455, 11519);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_11632_11689(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                value)
                {
                    var return_v = this_param.Append((char)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11632, 11689);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_11756_11824(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                value)
                {
                    var return_v = this_param.Append((char)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11756, 11824);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_11856_11876(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11856, 11876);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_11891_11920(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11891, 11920);
                    return return_v;
                }


                string
                f_10663_11944_11968(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 11944, 11968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 10143, 11980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 10143, 11980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GeneratedNameKind GetKind(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 12059, 12383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 12138, 12161);

                GeneratedNameKind
                kind
                = default(GeneratedNameKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 12175, 12197);

                int
                openBracketOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 12211, 12234);

                int
                closeBracketOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 12248, 12372);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10663, 12255, 12339) || ((f_10663_12255_12339(name, out kind, out openBracketOffset, out closeBracketOffset) && DynAbs.Tracing.TraceSender.Conditional_F2(10663, 12342, 12346)) || DynAbs.Tracing.TraceSender.Conditional_F3(10663, 12349, 12371))) ? kind : GeneratedNameKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 12059, 12383);

                bool
                f_10663_12255_12339(string
                name, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, out int
                openBracketOffset, out int
                closeBracketOffset)
                {
                    var return_v = TryParseGeneratedName(name, out kind, out openBracketOffset, out closeBracketOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 12255, 12339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 12059, 12383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 12059, 12383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseGeneratedName(
                    string name,
                    out GeneratedNameKind kind,
                    out int openBracketOffset,
                    out int closeBracketOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 12737, 14005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 12953, 12976);

                openBracketOffset = -1;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 12990, 13254) || true) && (f_10663_12994_13043(name, "CS$<", StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 12990, 13254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13077, 13099);

                    openBracketOffset = 3;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 12990, 13254);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 12990, 13254);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13133, 13254) || true) && (f_10663_13137_13183(name, "<", StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 13133, 13254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13217, 13239);

                        openBracketOffset = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 13133, 13254);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 12990, 13254);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13270, 13846) || true) && (openBracketOffset >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 13270, 13846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13330, 13407);

                    closeBracketOffset = f_10663_13351_13406(name, openBracketOffset, '>');

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13425, 13831) || true) && (closeBracketOffset >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10663, 13429, 13492) && closeBracketOffset + 1 < f_10663_13481_13492(name)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 13425, 13831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13534, 13571);

                        int
                        c = f_10663_13542_13570(name, closeBracketOffset + 1)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13593, 13812) || true) && ((c >= '1' && (DynAbs.Tracing.TraceSender.Expression_True(10663, 13598, 13618) && c <= '9')) || (DynAbs.Tracing.TraceSender.Expression_False(10663, 13597, 13645) || (c >= 'a' && (DynAbs.Tracing.TraceSender.Expression_True(10663, 13624, 13644) && c <= 'z'))))
                        ) // Note '0' is not special.

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 13593, 13812);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13723, 13751);

                            kind = (GeneratedNameKind)c;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13777, 13789);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 13593, 13812);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 13425, 13831);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 13270, 13846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13862, 13892);

                kind = GeneratedNameKind.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13906, 13929);

                openBracketOffset = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13943, 13967);

                closeBracketOffset = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 13981, 13994);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 12737, 14005);

                bool
                f_10663_12994_13043(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 12994, 13043);
                    return return_v;
                }


                bool
                f_10663_13137_13183(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 13137, 13183);
                    return return_v;
                }


                int
                f_10663_13351_13406(string
                str, int
                openingOffset, char
                closing)
                {
                    var return_v = str.IndexOfBalancedParenthesis(openingOffset, closing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 13351, 13406);
                    return return_v;
                }


                int
                f_10663_13481_13492(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 13481, 13492);
                    return return_v;
                }


                char
                f_10663_13542_13570(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 13542, 13570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 12737, 14005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 12737, 14005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseSourceMethodNameFromGeneratedName(string generatedName, GeneratedNameKind requiredKind, out string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 14017, 14955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14181, 14203);

                int
                openBracketOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14217, 14240);

                int
                closeBracketOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14254, 14277);

                GeneratedNameKind
                kind
                = default(GeneratedNameKind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14291, 14487) || true) && (!f_10663_14296_14389(generatedName, out kind, out openBracketOffset, out closeBracketOffset))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 14291, 14487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14423, 14441);

                    methodName = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14459, 14472);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 14291, 14487);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14503, 14646) || true) && (requiredKind != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10663, 14507, 14548) && kind != requiredKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 14503, 14646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14582, 14600);

                    methodName = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14618, 14631);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 14503, 14646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14662, 14766);

                methodName = f_10663_14675_14765(generatedName, openBracketOffset + 1, closeBracketOffset - openBracketOffset - 1);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14782, 14916) || true) && (f_10663_14786_14803(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 14782, 14916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14837, 14901);

                    methodName = f_10663_14850_14900(methodName, DotReplacementInTypeNames, '.');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 14782, 14916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 14932, 14944);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 14017, 14955);

                bool
                f_10663_14296_14389(string
                name, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, out int
                openBracketOffset, out int
                closeBracketOffset)
                {
                    var return_v = TryParseGeneratedName(name, out kind, out openBracketOffset, out closeBracketOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 14296, 14389);
                    return return_v;
                }


                string
                f_10663_14675_14765(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 14675, 14765);
                    return return_v;
                }


                bool
                f_10663_14786_14803(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind)
                {
                    var return_v = kind.IsTypeName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 14786, 14803);
                    return return_v;
                }


                string
                f_10663_14850_14900(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 14850, 14900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 14017, 14955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 14017, 14955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string AsyncAwaiterFieldName(int slotIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 14967, 15194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15051, 15109);

                f_10663_15051_15108((char)GeneratedNameKind.AwaiterField == 'u');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15123, 15183);

                return "<>u__" + f_10663_15140_15182(slotIndex + 1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 14967, 15194);

                int
                f_10663_15051_15108(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 15051, 15108);
                    return 0;
                }


                string
                f_10663_15140_15182(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 15140, 15182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 14967, 15194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 14967, 15194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseSlotIndex(string fieldName, out int slotIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 15406, 16057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15506, 15549);

                int
                lastUnder = f_10663_15522_15548(fieldName, '_')
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15563, 15747) || true) && (lastUnder - 1 < 0 || (DynAbs.Tracing.TraceSender.Expression_False(10663, 15567, 15617) || lastUnder == f_10663_15601_15617(fieldName)) || (DynAbs.Tracing.TraceSender.Expression_False(10663, 15567, 15652) || f_10663_15621_15645(fieldName, lastUnder - 1) != '_'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 15563, 15747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15686, 15701);

                    slotIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15719, 15732);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 15563, 15747);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15763, 15988) || true) && (f_10663_15767_15879(f_10663_15780_15814(fieldName, lastUnder + 1), NumberStyles.None, f_10663_15835_15863(), out slotIndex) && (DynAbs.Tracing.TraceSender.Expression_True(10663, 15767, 15897) && slotIndex >= 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 15763, 15988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15931, 15943);

                    slotIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 15961, 15973);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 15763, 15988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16004, 16019);

                slotIndex = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16033, 16046);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 15406, 16057);

                int
                f_10663_15522_15548(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 15522, 15548);
                    return return_v;
                }


                int
                f_10663_15601_15617(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 15601, 15617);
                    return return_v;
                }


                char
                f_10663_15621_15645(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 15621, 15645);
                    return return_v;
                }


                string
                f_10663_15780_15814(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 15780, 15814);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10663_15835_15863()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 15835, 15863);
                    return return_v;
                }


                bool
                f_10663_15767_15879(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 15767, 15879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 15406, 16057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 15406, 16057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeCachedFrameInstanceFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 16069, 16251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16151, 16213);

                f_10663_16151_16212((char)GeneratedNameKind.LambdaCacheField == '9');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16227, 16240);

                return "<>9";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 16069, 16251);

                int
                f_10663_16151_16212(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 16151, 16212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 16069, 16251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 16069, 16251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeSynthesizedLocalName(SynthesizedLocalKind kind, ref int uniqueId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 16263, 16706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16380, 16413);

                f_10663_16380_16412(f_10663_16393_16411(kind));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16521, 16667) || true) && (kind == SynthesizedLocalKind.LambdaDisplayClass)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 16521, 16667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16606, 16652);

                    return f_10663_16613_16651(uniqueId++);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 16521, 16667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16683, 16695);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 16263, 16706);

                bool
                f_10663_16393_16411(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 16393, 16411);
                    return return_v;
                }


                int
                f_10663_16380_16412(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 16380, 16412);
                    return 0;
                }


                string
                f_10663_16613_16651(int
                uniqueId)
                {
                    var return_v = MakeLambdaDisplayLocalName(uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 16613, 16651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 16263, 16706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 16263, 16706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeSynthesizedInstrumentationPayloadLocalFieldName(int uniqueId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 16718, 16943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 16831, 16932);

                return SynthesizedLocalNamePrefix + "InstrumentationPayload" + f_10663_16894_16931(uniqueId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 16718, 16943);

                string
                f_10663_16894_16931(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 16894, 16931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 16718, 16943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 16718, 16943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeLambdaDisplayLocalName(int uniqueId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 16955, 17228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 17043, 17113);

                f_10663_17043_17112((char)GeneratedNameKind.DisplayClassLocalOrField == '8');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 17127, 17217);

                return SynthesizedLocalNamePrefix + "<>8__locals" + f_10663_17179_17216(uniqueId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 16955, 17228);

                int
                f_10663_17043_17112(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 17043, 17112);
                    return 0;
                }


                string
                f_10663_17179_17216(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 17179, 17216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 16955, 17228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 16955, 17228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSynthesizedLocalName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 17240, 17409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 17321, 17398);

                return f_10663_17328_17397(name, SynthesizedLocalNamePrefix, StringComparison.Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 17240, 17409);

                bool
                f_10663_17328_17397(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 17328, 17397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 17240, 17409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 17240, 17409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeFixedFieldImplementationName(string fieldName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 17421, 17735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 17605, 17667);

                f_10663_17605_17666((char)GeneratedNameKind.FixedBufferField == 'e');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 17681, 17724);

                return "<" + fieldName + ">e__FixedBuffer";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 17421, 17735);

                int
                f_10663_17605_17666(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 17605, 17666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 17421, 17735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 17421, 17735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeStateMachineStateFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 17747, 18044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 17931, 17999);

                f_10663_17931_17998((char)GeneratedNameKind.StateMachineStateField == '1');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18013, 18033);

                return "<>1__state";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 17747, 18044);

                int
                f_10663_17931_17998(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 17931, 17998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 17747, 18044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 17747, 18044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeAsyncIteratorPromiseOfValueOrEndFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 18056, 18300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18151, 18241);

                f_10663_18151_18240((char)GeneratedNameKind.AsyncIteratorPromiseOfValueOrEndBackingField == 'v');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18255, 18289);

                return "<>v__promiseOfValueOrEnd";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 18056, 18300);

                int
                f_10663_18151_18240(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 18151, 18240);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 18056, 18300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 18056, 18300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeAsyncIteratorCombinedTokensFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 18312, 18521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18402, 18467);

                f_10663_18402_18466((char)GeneratedNameKind.CombinedTokensField == 'x');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18481, 18510);

                return "<>x__combinedTokens";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 18312, 18521);

                int
                f_10663_18402_18466(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 18402, 18466);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 18312, 18521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 18312, 18521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeIteratorCurrentFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 18533, 18731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18611, 18684);

                f_10663_18611_18683((char)GeneratedNameKind.IteratorCurrentBackingField == '2');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18698, 18720);

                return "<>2__current";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 18533, 18731);

                int
                f_10663_18611_18683(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 18611, 18683);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 18533, 18731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 18533, 18731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeDisposeModeFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 18743, 18930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18817, 18879);

                f_10663_18817_18878((char)GeneratedNameKind.DisposeModeField == 'w');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 18893, 18919);

                return "<>w__disposeMode";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 18743, 18930);

                int
                f_10663_18817_18878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 18817, 18878);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 18743, 18930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 18743, 18930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeIteratorCurrentThreadIdFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 18942, 19157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19028, 19102);

                f_10663_19028_19101((char)GeneratedNameKind.IteratorCurrentThreadIdField == 'l');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19116, 19146);

                return "<>l__initialThreadId";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 18942, 19157);

                int
                f_10663_19028_19101(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 19028, 19101);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 18942, 19157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 18942, 19157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ThisProxyFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 19169, 19341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19237, 19297);

                f_10663_19237_19296((char)GeneratedNameKind.ThisProxyField == '4');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19311, 19330);

                return "<>4__this";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 19169, 19341);

                int
                f_10663_19237_19296(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 19237, 19296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 19169, 19341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 19169, 19341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string StateMachineThisParameterProxyName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 19353, 19513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19437, 19502);

                return f_10663_19444_19501(f_10663_19480_19500());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 19353, 19513);

                string
                f_10663_19480_19500()
                {
                    var return_v = ThisProxyFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 19480, 19500);
                    return return_v;
                }


                string
                f_10663_19444_19501(string
                parameterName)
                {
                    var return_v = StateMachineParameterProxyFieldName(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 19444, 19501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 19353, 19513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 19353, 19513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string StateMachineParameterProxyFieldName(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 19525, 19763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19630, 19707);

                f_10663_19630_19706((char)GeneratedNameKind.StateMachineParameterProxyField == '3');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19721, 19752);

                return "<>3__" + parameterName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 19525, 19763);

                int
                f_10663_19630_19706(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 19630, 19706);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 19525, 19763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 19525, 19763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeDynamicCallSiteContainerName(int methodOrdinal, int localFunctionOrdinal, int generation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 19775, 20284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 19916, 20273);

                return f_10663_19923_20272(GeneratedNameKind.DynamicCallSiteContainerType, methodOrdinal, generation, suffix: (DynAbs.Tracing.TraceSender.Conditional_F1(10663, 20090, 20116) || ((localFunctionOrdinal != -1 && DynAbs.Tracing.TraceSender.Conditional_F2(10663, 20119, 20150)) || DynAbs.Tracing.TraceSender.Conditional_F3(10663, 20153, 20157))) ? f_10663_20119_20150(localFunctionOrdinal) : null, suffixTerminator: (DynAbs.Tracing.TraceSender.Conditional_F1(10663, 20229, 20255) || ((localFunctionOrdinal != -1 && DynAbs.Tracing.TraceSender.Conditional_F2(10663, 20258, 20261)) || DynAbs.Tracing.TraceSender.Conditional_F3(10663, 20264, 20271))) ? '_' : default);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 19775, 20284);

                string
                f_10663_20119_20150(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 20119, 20150);
                    return return_v;
                }


                string
                f_10663_19923_20272(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                kind, int
                methodOrdinal, int
                methodGeneration, string?
                suffix, char
                suffixTerminator)
                {
                    var return_v = MakeMethodScopedSynthesizedName(kind, methodOrdinal, methodGeneration, suffix: suffix, suffixTerminator: suffixTerminator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 19923, 20272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 19775, 20284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 19775, 20284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeDynamicCallSiteFieldName(int uniqueId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 20296, 20532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 20386, 20452);

                f_10663_20386_20451((char)GeneratedNameKind.DynamicCallSiteField == 'p');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 20466, 20521);

                return "<>p__" + f_10663_20483_20520(uniqueId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 20296, 20532);

                int
                f_10663_20386_20451(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 20386, 20451);
                    return 0;
                }


                string
                f_10663_20483_20520(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 20483, 20520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 20296, 20532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 20296, 20532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MakeDynamicCallSiteDelegateName(BitVector byRefs, bool returnsVoid, int generation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 20832, 21779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 20963, 21017);

                var
                pooledBuilder = f_10663_20983_21016()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21031, 21067);

                var
                builder = pooledBuilder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21083, 21127);

                f_10663_21083_21126(
                            builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10663, 21098, 21109) || ((returnsVoid && DynAbs.Tracing.TraceSender.Conditional_F2(10663, 21112, 21117)) || DynAbs.Tracing.TraceSender.Conditional_F3(10663, 21120, 21125))) ? "<>A" : "<>F");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21143, 21653) || true) && (f_10663_21147_21161_M(!byRefs.IsNull))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 21143, 21653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21195, 21215);

                    f_10663_21195_21214(builder, "{");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21235, 21245);

                    int
                    i = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21263, 21560);
                        foreach (int byRefIndex in f_10663_21290_21304_I(byRefs.Words()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 21263, 21560);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21346, 21448) || true) && (i > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10663, 21346, 21448);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21405, 21425);

                                f_10663_21405_21424(builder, ",");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 21346, 21448);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21472, 21515);

                            f_10663_21472_21514(
                                                builder, "{0:x8}", byRefIndex);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21537, 21541);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 21263, 21560);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10663, 1, 298);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10663, 1, 298);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21580, 21600);

                    f_10663_21580_21599(
                                    builder, "}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21618, 21638);

                    f_10663_21618_21637(i > 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10663, 21143, 21653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21669, 21715);

                f_10663_21669_21714(builder, generation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21729, 21768);

                return f_10663_21736_21767(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 20832, 21779);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10663_20983_21016()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 20983, 21016);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_21083_21126(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21083, 21126);
                    return return_v;
                }


                bool
                f_10663_21147_21161_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10663, 21147, 21161);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_21195_21214(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21195, 21214);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_21405_21424(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21405, 21424);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_21472_21514(System.Text.StringBuilder
                this_param, string
                format, int
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21472, 21514);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<ulong>
                f_10663_21290_21304_I(System.Collections.Generic.IEnumerable<ulong>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21290, 21304);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10663_21580_21599(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21580, 21599);
                    return return_v;
                }


                int
                f_10663_21618_21637(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21618, 21637);
                    return 0;
                }


                int
                f_10663_21669_21714(System.Text.StringBuilder
                builder, int
                generation)
                {
                    AppendOptionalGeneration(builder, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21669, 21714);
                    return 0;
                }


                string
                f_10663_21736_21767(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21736, 21767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 20832, 21779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 20832, 21779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string AsyncBuilderFieldName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 21791, 22076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 21966, 22029);

                f_10663_21966_22028((char)GeneratedNameKind.AsyncBuilderField == 't');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 22043, 22065);

                return "<>t__builder";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 21791, 22076);

                int
                f_10663_21966_22028(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 21966, 22028);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 21791, 22076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 21791, 22076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ReusableHoistedLocalFieldName(int number)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 22088, 22330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 22177, 22248);

                f_10663_22177_22247((char)GeneratedNameKind.ReusableHoistedLocalField == '7');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 22262, 22319);

                return "<>7__wrap" + f_10663_22283_22318(number);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 22088, 22330);

                int
                f_10663_22177_22247(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 22177, 22247);
                    return 0;
                }


                string
                f_10663_22283_22318(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 22283, 22318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 22088, 22330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 22088, 22330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string LambdaCopyParameterName(int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10663, 22342, 22494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 22426, 22483);

                return "<p" + f_10663_22440_22476(ordinal) + ">";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10663, 22342, 22494);

                string
                f_10663_22440_22476(int
                number)
                {
                    var return_v = StringExtensions.GetNumeral(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10663, 22440, 22476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10663, 22342, 22494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 22342, 22494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GeneratedNames()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10663, 511, 22501);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 594, 628);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 659, 690);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 722, 744);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 774, 791);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 821, 846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 876, 909);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10663, 3086, 3128);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10663, 511, 22501);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10663, 511, 22501);
        }

    }
}
