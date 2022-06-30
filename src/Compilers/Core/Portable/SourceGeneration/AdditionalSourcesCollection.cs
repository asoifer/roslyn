// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
namespace Microsoft.CodeAnalysis
{
    internal sealed class AdditionalSourcesCollection
    {
        private readonly ArrayBuilder<GeneratedSourceText> _sourcesAdded;

        private readonly string _fileExtension;

        private const StringComparison
        _hintNameComparison = StringComparison.OrdinalIgnoreCase
        ;

        private static readonly StringComparer s_hintNameComparer;

        internal AdditionalSourcesCollection(string fileExtension)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(545, 886, 1169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 604, 617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 654, 668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 969, 1035);

                f_545_969_1034(f_545_982_1002(fileExtension) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(545, 982, 1033) && f_545_1010_1026(fileExtension, 0) == '.'));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1049, 1113);

                _sourcesAdded = f_545_1065_1112();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1127, 1158);

                _fileExtension = fileExtension;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(545, 886, 1169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 886, 1169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 886, 1169);
            }
        }

        public void Add(string hintName, SourceText source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(545, 1181, 2719);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1257, 1395) || true) && (f_545_1261_1296(hintName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 1257, 1395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1330, 1380);

                    throw f_545_1336_1379(nameof(hintName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(545, 1257, 1395);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1484, 1489);

                    // allow any identifier character or [.,-_ ()[]{}]
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1475, 2196) || true) && (i < f_545_1495_1510(hintName))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1512, 1515)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(545, 1475, 2196))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 1475, 2196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1549, 1570);

                        char
                        c = f_545_1558_1569(hintName, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 1588, 2181) || true) && (!f_545_1593_1647(c) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1680) && c != '.'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1713) && c != ','
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1746) && c != '-'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1779) && c != '_'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1812) && c != ' '
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1845) && c != '('
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1878) && c != ')'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1911) && c != '['
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1944) && c != ']'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 1977) && c != '{'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(545, 1592, 2010) && c != '}'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 1588, 2181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2052, 2162);

                            throw f_545_2058_2161(f_545_2080_2142(f_545_2094_2135(), c, i), nameof(hintName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(545, 1588, 2181);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(545, 1, 722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(545, 1, 722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2212, 2259);

                hintName = f_545_2223_2258(this, hintName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2273, 2445) || true) && (f_545_2277_2300(this, hintName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 2273, 2445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2334, 2430);

                    throw f_545_2340_2429(f_545_2362_2410(), nameof(hintName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(545, 2273, 2445);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2461, 2631) || true) && (f_545_2465_2480(source) is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 2461, 2631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2522, 2616);

                    throw f_545_2528_2615(f_545_2550_2598(), nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(545, 2461, 2631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2647, 2708);

                f_545_2647_2707(
                            _sourcesAdded, f_545_2665_2706(hintName, source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(545, 1181, 2719);

                bool
                f_545_1261_1296(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 1261, 1296);
                    return return_v;
                }


                System.ArgumentNullException
                f_545_1336_1379(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 1336, 1379);
                    return return_v;
                }


                int
                f_545_1495_1510(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 1495, 1510);
                    return return_v;
                }


                char
                f_545_1558_1569(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 1558, 1569);
                    return return_v;
                }


                bool
                f_545_1593_1647(char
                ch)
                {
                    var return_v = UnicodeCharacterUtilities.IsIdentifierPartCharacter(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 1593, 1647);
                    return return_v;
                }


                string
                f_545_2094_2135()
                {
                    var return_v = CodeAnalysisResources.HintNameInvalidChar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 2094, 2135);
                    return return_v;
                }


                string
                f_545_2080_2142(string
                format, char
                arg0, int
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2080, 2142);
                    return return_v;
                }


                System.ArgumentException
                f_545_2058_2161(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2058, 2161);
                    return return_v;
                }


                string
                f_545_2223_2258(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                this_param, string
                hintName)
                {
                    var return_v = this_param.AppendExtensionIfRequired(hintName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2223, 2258);
                    return return_v;
                }


                bool
                f_545_2277_2300(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                this_param, string
                hintName)
                {
                    var return_v = this_param.Contains(hintName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2277, 2300);
                    return return_v;
                }


                string
                f_545_2362_2410()
                {
                    var return_v = CodeAnalysisResources.HintNameUniquePerGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 2362, 2410);
                    return return_v;
                }


                System.ArgumentException
                f_545_2340_2429(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2340, 2429);
                    return return_v;
                }


                System.Text.Encoding?
                f_545_2465_2480(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 2465, 2480);
                    return return_v;
                }


                string
                f_545_2550_2598()
                {
                    var return_v = CodeAnalysisResources.SourceTextRequiresEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 2550, 2598);
                    return return_v;
                }


                System.ArgumentException
                f_545_2528_2615(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2528, 2615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratedSourceText
                f_545_2665_2706(string
                hintName, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratedSourceText(hintName, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2665, 2706);
                    return return_v;
                }


                int
                f_545_2647_2707(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
                this_param, Microsoft.CodeAnalysis.GeneratedSourceText
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2647, 2707);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 1181, 2719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 1181, 2719);
            }
        }

        public void AddRange(ImmutableArray<GeneratedSourceText> texts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(545, 2795, 2827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2798, 2827);
                f_545_2798_2827(_sourcesAdded, texts); DynAbs.Tracing.TraceSender.TraceExitMethod(545, 2795, 2827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 2795, 2827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 2795, 2827);
            }

            int
            f_545_2798_2827(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
            items)
            {
                this_param.AddRange(items);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2798, 2827);
                return 0;
            }

        }

        public void AddRange(ImmutableArray<GeneratedSyntaxTree> trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(545, 2904, 3000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 2907, 3000);
                f_545_2907_3000(_sourcesAdded, trees.SelectAsArray(t => new GeneratedSourceText(t.HintName, t.Text))); DynAbs.Tracing.TraceSender.TraceExitMethod(545, 2904, 3000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 2904, 3000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 2904, 3000);
            }

            int
            f_545_2907_3000(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
            items)
            {
                this_param.AddRange(items);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 2907, 3000);
                return 0;
            }

        }

        public void RemoveSource(string hintName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(545, 3013, 3426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3079, 3126);

                hintName = f_545_3090_3125(this, hintName);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3149, 3154);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3140, 3415) || true) && (i < f_545_3160_3179(_sourcesAdded))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3181, 3184)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(545, 3140, 3415))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 3140, 3415);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3218, 3400) || true) && (f_545_3222_3284(s_hintNameComparer, _sourcesAdded[i].HintName, hintName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 3218, 3400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3326, 3352);

                            f_545_3326_3351(_sourcesAdded, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3374, 3381);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(545, 3218, 3400);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(545, 1, 276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(545, 1, 276);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(545, 3013, 3426);

                string
                f_545_3090_3125(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                this_param, string
                hintName)
                {
                    var return_v = this_param.AppendExtensionIfRequired(hintName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 3090, 3125);
                    return return_v;
                }


                int
                f_545_3160_3179(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 3160, 3179);
                    return return_v;
                }


                bool
                f_545_3222_3284(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 3222, 3284);
                    return return_v;
                }


                int
                f_545_3326_3351(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 3326, 3351);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 3013, 3426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 3013, 3426);
            }
        }

        public bool Contains(string hintName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(545, 3438, 3831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3500, 3547);

                hintName = f_545_3511_3546(this, hintName);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3570, 3575);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3561, 3793) || true) && (i < f_545_3581_3600(_sourcesAdded))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3602, 3605)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(545, 3561, 3793))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 3561, 3793);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3639, 3778) || true) && (f_545_3643_3705(s_hintNameComparer, _sourcesAdded[i].HintName, hintName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 3639, 3778);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3747, 3759);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(545, 3639, 3778);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(545, 1, 233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(545, 1, 233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3807, 3820);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(545, 3438, 3831);

                string
                f_545_3511_3546(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                this_param, string
                hintName)
                {
                    var return_v = this_param.AppendExtensionIfRequired(hintName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 3511, 3546);
                    return return_v;
                }


                int
                f_545_3581_3600(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 3581, 3600);
                    return return_v;
                }


                bool
                f_545_3643_3705(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 3643, 3705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 3438, 3831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 3438, 3831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<GeneratedSourceText> ToImmutableAndFree()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(545, 3909, 3946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 3912, 3946);
                return f_545_3912_3946(_sourcesAdded); DynAbs.Tracing.TraceSender.TraceExitMethod(545, 3909, 3946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 3909, 3946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 3909, 3946);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
            f_545_3912_3946(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 3912, 3946);
                return return_v;
            }

        }

        private string AppendExtensionIfRequired(string hintName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(545, 3959, 4243);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 4041, 4200) || true) && (!f_545_4046_4100(hintName, _fileExtension, _hintNameComparison))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(545, 4041, 4200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 4134, 4185);

                    hintName = f_545_4145_4184(hintName, _fileExtension);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(545, 4041, 4200);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 4216, 4232);

                return hintName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(545, 3959, 4243);

                bool
                f_545_4046_4100(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 4046, 4100);
                    return return_v;
                }


                string
                f_545_4145_4184(string
                str0, string
                str1)
                {
                    var return_v = string.Concat(str0, str1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 4145, 4184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(545, 3959, 4243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 3959, 4243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AdditionalSourcesCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(545, 487, 4250);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 712, 768);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(545, 820, 873);
            s_hintNameComparer = f_545_841_873(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(545, 487, 4250);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(545, 487, 4250);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(545, 487, 4250);

        static System.StringComparer
        f_545_841_873()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 841, 873);
            return return_v;
        }


        static int
        f_545_982_1002(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 982, 1002);
            return return_v;
        }


        static char
        f_545_1010_1026(string
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(545, 1010, 1026);
            return return_v;
        }


        static int
        f_545_969_1034(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 969, 1034);
            return 0;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceText>
        f_545_1065_1112()
        {
            var return_v = ArrayBuilder<GeneratedSourceText>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(545, 1065, 1112);
            return return_v;
        }

    }
}
