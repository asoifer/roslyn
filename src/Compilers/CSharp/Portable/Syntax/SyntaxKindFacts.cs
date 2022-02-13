// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static partial class SyntaxFacts
    {
        public static bool IsKeywordKind(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 349, 494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 423, 483);

                return f_10007_430_453(kind) || (DynAbs.Tracing.TraceSender.Expression_False(10007, 430, 482) || f_10007_457_482(kind));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 349, 494);

                bool
                f_10007_430_453(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsReservedKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 430, 453);
                    return return_v;
                }


                bool
                f_10007_457_482(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsContextualKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 457, 482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 349, 494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 349, 494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<SyntaxKind> GetReservedKeywordKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 506, 764);

                var listYield = new List<SyntaxKind>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 603, 634);
                    for (int
        i = (int)SyntaxKind.BoolKeyword
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 594, 753) || true) && (i <= (int)SyntaxKind.ImplicitKeyword)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 674, 677)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 594, 753))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 594, 753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 711, 738);

                        listYield.Add((SyntaxKind)i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10007, 1, 160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10007, 1, 160);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 506, 764);

                return listYield;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 506, 764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 506, 764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<SyntaxKind> GetKeywordKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 776, 1131);

                var listYield = new List<SyntaxKind>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 856, 977);
                    foreach (var reserved in f_10007_881_906_I(f_10007_881_906()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 856, 977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 940, 962);

                        listYield.Add(reserved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 856, 977);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10007, 1, 122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10007, 1, 122);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 993, 1120);
                    foreach (var contextual in f_10007_1020_1047_I(f_10007_1020_1047()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 993, 1120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 1081, 1105);

                        listYield.Add(contextual);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 993, 1120);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10007, 1, 128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10007, 1, 128);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 776, 1131);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                f_10007_881_906()
                {
                    var return_v = GetReservedKeywordKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 881, 906);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                f_10007_881_906_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 881, 906);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                f_10007_1020_1047()
                {
                    var return_v = GetContextualKeywordKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 1020, 1047);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                f_10007_1020_1047_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 1020, 1047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 776, 1131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 776, 1131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsReservedKeyword(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 1143, 1308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 1221, 1297);

                return kind >= SyntaxKind.BoolKeyword && (DynAbs.Tracing.TraceSender.Expression_True(10007, 1228, 1296) && kind <= SyntaxKind.ImplicitKeyword);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 1143, 1308);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 1143, 1308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 1143, 1308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAttributeTargetSpecifier(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 1320, 1654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 1407, 1643);

                switch (kind)
                {

                    case SyntaxKind.AssemblyKeyword:
                    case SyntaxKind.ModuleKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 1407, 1643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 1555, 1567);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 1407, 1643);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 1407, 1643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 1615, 1628);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 1407, 1643);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 1320, 1654);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 1320, 1654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 1320, 1654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAccessibilityModifier(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 1666, 2097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 1750, 2086);

                switch (kind)
                {

                    case SyntaxKind.PrivateKeyword:
                    case SyntaxKind.ProtectedKeyword:
                    case SyntaxKind.InternalKeyword:
                    case SyntaxKind.PublicKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 1750, 2086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 1998, 2010);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 1750, 2086);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 1750, 2086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 2058, 2071);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 1750, 2086);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 1666, 2097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 1666, 2097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 1666, 2097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPreprocessorKeyword(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 2109, 3543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 2191, 3532);

                switch (kind)
                {

                    case SyntaxKind.TrueKeyword:
                    case SyntaxKind.FalseKeyword:
                    case SyntaxKind.DefaultKeyword:
                    case SyntaxKind.IfKeyword:
                    case SyntaxKind.ElseKeyword:
                    case SyntaxKind.ElifKeyword:
                    case SyntaxKind.EndIfKeyword:
                    case SyntaxKind.RegionKeyword:
                    case SyntaxKind.EndRegionKeyword:
                    case SyntaxKind.DefineKeyword:
                    case SyntaxKind.UndefKeyword:
                    case SyntaxKind.WarningKeyword:
                    case SyntaxKind.ErrorKeyword:
                    case SyntaxKind.LineKeyword:
                    case SyntaxKind.PragmaKeyword:
                    case SyntaxKind.HiddenKeyword:
                    case SyntaxKind.ChecksumKeyword:
                    case SyntaxKind.DisableKeyword:
                    case SyntaxKind.RestoreKeyword:
                    case SyntaxKind.ReferenceKeyword:
                    case SyntaxKind.LoadKeyword:
                    case SyntaxKind.NullableKeyword:
                    case SyntaxKind.EnableKeyword:
                    case SyntaxKind.WarningsKeyword:
                    case SyntaxKind.AnnotationsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 2191, 3532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 3444, 3456);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 2191, 3532);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 2191, 3532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 3504, 3517);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 2191, 3532);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 2109, 3543);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 2109, 3543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 2109, 3543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPreprocessorContextualKeyword(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 3990, 4745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 4084, 4734);

                switch (kind)
                {

                    case SyntaxKind.TrueKeyword:
                    case SyntaxKind.FalseKeyword:
                    case SyntaxKind.DefaultKeyword:
                    case SyntaxKind.HiddenKeyword:
                    case SyntaxKind.ChecksumKeyword:
                    case SyntaxKind.DisableKeyword:
                    case SyntaxKind.RestoreKeyword:
                    case SyntaxKind.EnableKeyword:
                    case SyntaxKind.WarningsKeyword:
                    case SyntaxKind.AnnotationsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 4084, 4734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 4623, 4636);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 4084, 4734);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 4084, 4734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 4684, 4719);

                        return f_10007_4691_4718(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 4084, 4734);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 3990, 4745);

                bool
                f_10007_4691_4718(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsPreprocessorKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 4691, 4718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 3990, 4745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 3990, 4745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<SyntaxKind> GetPreprocessorKeywordKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 4757, 5224);

                var listYield = new List<SyntaxKind>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 4849, 4885);

                listYield.Add(SyntaxKind.TrueKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 4899, 4936);

                listYield.Add(SyntaxKind.FalseKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 4950, 4989);

                listYield.Add(SyntaxKind.DefaultKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5003, 5041);

                listYield.Add(SyntaxKind.HiddenKeyword);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5064, 5095);
                    for (int
        i = (int)SyntaxKind.ElifKeyword
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5055, 5213) || true) && (i <= (int)SyntaxKind.RestoreKeyword)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5134, 5137)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 5055, 5213))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 5055, 5213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5171, 5198);

                        listYield.Add((SyntaxKind)i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10007, 1, 159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10007, 1, 159);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 4757, 5224);

                return listYield;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 4757, 5224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 4757, 5224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPunctuation(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 5236, 5408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5310, 5397);

                return kind >= SyntaxKind.TildeToken && (DynAbs.Tracing.TraceSender.Expression_True(10007, 5317, 5396) && kind <= SyntaxKind.QuestionQuestionEqualsToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 5236, 5408);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 5236, 5408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 5236, 5408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLanguagePunctuation(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 5420, 5611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5502, 5600);

                return f_10007_5509_5528(kind) && (DynAbs.Tracing.TraceSender.Expression_True(10007, 5509, 5560) && !f_10007_5533_5560(kind)) && (DynAbs.Tracing.TraceSender.Expression_True(10007, 5509, 5599) && !f_10007_5565_5599(kind));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 5420, 5611);

                bool
                f_10007_5509_5528(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsPunctuation(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 5509, 5528);
                    return return_v;
                }


                bool
                f_10007_5533_5560(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsPreprocessorKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 5533, 5560);
                    return return_v;
                }


                bool
                f_10007_5565_5599(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsDebuggerSpecialPunctuation(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 5565, 5599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 5420, 5611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 5420, 5611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPreprocessorPunctuation(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 5623, 5756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5709, 5745);

                return kind == SyntaxKind.HashToken;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 5623, 5756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 5623, 5756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 5623, 5756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDebuggerSpecialPunctuation(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 5768, 5996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 5947, 5985);

                return kind == SyntaxKind.DollarToken;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 5768, 5996);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 5768, 5996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 5768, 5996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<SyntaxKind> GetPunctuationKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 6008, 6264);

                var listYield = new List<SyntaxKind>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 6101, 6131);
                    for (int
        i = (int)SyntaxKind.TildeToken
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 6092, 6253) || true) && (i <= (int)SyntaxKind.PercentEqualsToken)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 6174, 6177)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 6092, 6253))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 6092, 6253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 6211, 6238);

                        listYield.Add((SyntaxKind)i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10007, 1, 162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10007, 1, 162);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 6008, 6264);

                return listYield;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 6008, 6264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 6008, 6264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPunctuationOrKeyword(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 6276, 6444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 6359, 6433);

                return kind >= SyntaxKind.TildeToken && (DynAbs.Tracing.TraceSender.Expression_True(10007, 6366, 6432) && kind <= SyntaxKind.EndOfFileToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 6276, 6444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 6276, 6444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 6276, 6444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsLiteral(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 6456, 7109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 6528, 7098);

                switch (kind)
                {

                    case SyntaxKind.IdentifierToken:
                    case SyntaxKind.StringLiteralToken:
                    case SyntaxKind.CharacterLiteralToken:
                    case SyntaxKind.NumericLiteralToken:
                    case SyntaxKind.XmlTextLiteralToken:
                    case SyntaxKind.XmlTextLiteralNewLineToken:
                    case SyntaxKind.XmlEntityLiteralToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 6528, 7098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 7010, 7022);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 6528, 7098);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 6528, 7098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 7070, 7083);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 6528, 7098);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 6456, 7109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 6456, 7109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 6456, 7109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAnyToken(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 7121, 7948);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 7192, 7276) || true) && (kind >= SyntaxKind.TildeToken && (DynAbs.Tracing.TraceSender.Expression_True(10007, 7196, 7262) && kind < SyntaxKind.EndOfLineTrivia))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 7192, 7276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 7264, 7276);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 7192, 7276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 7290, 7937);

                switch (kind)
                {

                    case SyntaxKind.InterpolatedStringToken:
                    case SyntaxKind.InterpolatedStringStartToken:
                    case SyntaxKind.InterpolatedVerbatimStringStartToken:
                    case SyntaxKind.InterpolatedStringTextToken:
                    case SyntaxKind.InterpolatedStringEndToken:
                    case SyntaxKind.LoadKeyword:
                    case SyntaxKind.NullableKeyword:
                    case SyntaxKind.EnableKeyword:
                    case SyntaxKind.UnderscoreToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 7290, 7937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 7849, 7861);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 7290, 7937);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 7290, 7937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 7909, 7922);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 7290, 7937);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 7121, 7948);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 7121, 7948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 7121, 7948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTrivia(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 7960, 8736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 8029, 8725);

                switch (kind)
                {

                    case SyntaxKind.EndOfLineTrivia:
                    case SyntaxKind.WhitespaceTrivia:
                    case SyntaxKind.SingleLineCommentTrivia:
                    case SyntaxKind.MultiLineCommentTrivia:
                    case SyntaxKind.SingleLineDocumentationCommentTrivia:
                    case SyntaxKind.MultiLineDocumentationCommentTrivia:
                    case SyntaxKind.DisabledTextTrivia:
                    case SyntaxKind.DocumentationCommentExteriorTrivia:
                    case SyntaxKind.ConflictMarkerTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 8029, 8725);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 8613, 8625);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 8029, 8725);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 8029, 8725);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 8673, 8710);

                        return f_10007_8680_8709(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 8029, 8725);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 7960, 8736);

                bool
                f_10007_8680_8709(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsPreprocessorDirective(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 8680, 8709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 7960, 8736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 7960, 8736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPreprocessorDirective(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 8748, 9996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 8832, 9985);

                switch (kind)
                {

                    case SyntaxKind.IfDirectiveTrivia:
                    case SyntaxKind.ElifDirectiveTrivia:
                    case SyntaxKind.ElseDirectiveTrivia:
                    case SyntaxKind.EndIfDirectiveTrivia:
                    case SyntaxKind.RegionDirectiveTrivia:
                    case SyntaxKind.EndRegionDirectiveTrivia:
                    case SyntaxKind.DefineDirectiveTrivia:
                    case SyntaxKind.UndefDirectiveTrivia:
                    case SyntaxKind.ErrorDirectiveTrivia:
                    case SyntaxKind.WarningDirectiveTrivia:
                    case SyntaxKind.LineDirectiveTrivia:
                    case SyntaxKind.PragmaWarningDirectiveTrivia:
                    case SyntaxKind.PragmaChecksumDirectiveTrivia:
                    case SyntaxKind.ReferenceDirectiveTrivia:
                    case SyntaxKind.LoadDirectiveTrivia:
                    case SyntaxKind.BadDirectiveTrivia:
                    case SyntaxKind.ShebangDirectiveTrivia:
                    case SyntaxKind.NullableDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 8832, 9985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 9897, 9909);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 8832, 9985);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 8832, 9985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 9957, 9970);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 8832, 9985);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 8748, 9996);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 8748, 9996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 8748, 9996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsName(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 10008, 10420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 10075, 10409);

                switch (kind)
                {

                    case SyntaxKind.IdentifierName:
                    case SyntaxKind.GenericName:
                    case SyntaxKind.QualifiedName:
                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 10075, 10409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 10321, 10333);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 10075, 10409);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 10075, 10409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 10381, 10394);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 10075, 10409);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 10008, 10420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 10008, 10420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 10008, 10420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPredefinedType(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 10432, 11408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 10509, 11397);

                switch (kind)
                {

                    case SyntaxKind.BoolKeyword:
                    case SyntaxKind.ByteKeyword:
                    case SyntaxKind.SByteKeyword:
                    case SyntaxKind.IntKeyword:
                    case SyntaxKind.UIntKeyword:
                    case SyntaxKind.ShortKeyword:
                    case SyntaxKind.UShortKeyword:
                    case SyntaxKind.LongKeyword:
                    case SyntaxKind.ULongKeyword:
                    case SyntaxKind.FloatKeyword:
                    case SyntaxKind.DoubleKeyword:
                    case SyntaxKind.DecimalKeyword:
                    case SyntaxKind.StringKeyword:
                    case SyntaxKind.CharKeyword:
                    case SyntaxKind.ObjectKeyword:
                    case SyntaxKind.VoidKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 10509, 11397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 11309, 11321);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 10509, 11397);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 10509, 11397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 11369, 11382);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 10509, 11397);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 10432, 11408);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 10432, 11408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 10432, 11408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTypeSyntax(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 11420, 11933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 11493, 11922);

                switch (kind)
                {

                    case SyntaxKind.ArrayType:
                    case SyntaxKind.PointerType:
                    case SyntaxKind.NullableType:
                    case SyntaxKind.PredefinedType:
                    case SyntaxKind.TupleType:
                    case SyntaxKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 11493, 11922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 11827, 11839);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 11493, 11922);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 11493, 11922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 11887, 11907);

                        return f_10007_11894_11906(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 11493, 11922);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 11420, 11933);

                bool
                f_10007_11894_11906(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsName(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 11894, 11906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 11420, 11933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 11420, 11933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsGlobalMemberDeclaration(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 12088, 12603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 12174, 12565);

                switch (kind)
                {

                    case SyntaxKind.GlobalStatement:
                    case SyntaxKind.FieldDeclaration:
                    case SyntaxKind.MethodDeclaration:
                    case SyntaxKind.PropertyDeclaration:
                    case SyntaxKind.EventDeclaration:
                    case SyntaxKind.EventFieldDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 12174, 12565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 12538, 12550);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 12174, 12565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 12579, 12592);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 12088, 12603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 12088, 12603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 12088, 12603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTypeDeclaration(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 12615, 13158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 12693, 13147);

                switch (kind)
                {

                    case SyntaxKind.ClassDeclaration:
                    case SyntaxKind.StructDeclaration:
                    case SyntaxKind.InterfaceDeclaration:
                    case SyntaxKind.DelegateDeclaration:
                    case SyntaxKind.EnumDeclaration:
                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 12693, 13147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 13057, 13069);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 12693, 13147);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 12693, 13147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 13119, 13132);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 12693, 13147);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 12615, 13158);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 12615, 13158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 12615, 13158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNamespaceMemberDeclaration(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10007, 13248, 13319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 13251, 13319);
                return f_10007_13251_13274(kind) || (DynAbs.Tracing.TraceSender.Expression_False(10007, 13251, 13319) || (kind == SyntaxKind.NamespaceDeclaration)); DynAbs.Tracing.TraceSender.TraceExitMethod(10007, 13248, 13319);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 13248, 13319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 13248, 13319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAnyUnaryExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 13332, 13498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 13414, 13487);

                return f_10007_13421_13451(token) || (DynAbs.Tracing.TraceSender.Expression_False(10007, 13421, 13486) || f_10007_13455_13486(token));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 13332, 13498);

                bool
                f_10007_13421_13451(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = IsPrefixUnaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 13421, 13451);
                    return return_v;
                }


                bool
                f_10007_13455_13486(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = IsPostfixUnaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 13455, 13486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 13332, 13498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 13332, 13498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPrefixUnaryExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 13510, 13664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 13595, 13653);

                return f_10007_13602_13633(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 13510, 13664);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_13602_13633(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetPrefixUnaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 13602, 13633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 13510, 13664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 13510, 13664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPrefixUnaryExpressionOperatorToken(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 13676, 13843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 13774, 13832);

                return f_10007_13781_13812(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 13676, 13843);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_13781_13812(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetPrefixUnaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 13781, 13812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 13676, 13843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 13676, 13843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetPrefixUnaryExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 13855, 15052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 13947, 15041);

                switch (token)
                {

                    case SyntaxKind.PlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14042, 14080);

                        return SyntaxKind.UnaryPlusExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.MinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14147, 14186);

                        return SyntaxKind.UnaryMinusExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.TildeToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14253, 14292);

                        return SyntaxKind.BitwiseNotExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.ExclamationToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14365, 14404);

                        return SyntaxKind.LogicalNotExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.PlusPlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14474, 14515);

                        return SyntaxKind.PreIncrementExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.MinusMinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14587, 14628);

                        return SyntaxKind.PreDecrementExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.AmpersandToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14699, 14737);

                        return SyntaxKind.AddressOfExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.AsteriskToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14807, 14854);

                        return SyntaxKind.PointerIndirectionExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    case SyntaxKind.CaretToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 14921, 14955);

                        return SyntaxKind.IndexExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 13947, 15041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15003, 15026);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 13947, 15041);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 13855, 15052);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 13855, 15052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 13855, 15052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPostfixUnaryExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 15064, 15220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15150, 15209);

                return f_10007_15157_15189(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 15064, 15220);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_15157_15189(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetPostfixUnaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 15157, 15189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 15064, 15220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 15064, 15220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPostfixUnaryExpressionToken(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 15232, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15323, 15382);

                return f_10007_15330_15362(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 15232, 15393);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_15330_15362(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetPostfixUnaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 15330, 15362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 15232, 15393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 15232, 15393);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetPostfixUnaryExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 15405, 15975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15498, 15964);

                switch (token)
                {

                    case SyntaxKind.PlusPlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 15498, 15964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15597, 15639);

                        return SyntaxKind.PostIncrementExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 15498, 15964);

                    case SyntaxKind.MinusMinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 15498, 15964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15711, 15753);

                        return SyntaxKind.PostDecrementExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 15498, 15964);

                    case SyntaxKind.ExclamationToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 15498, 15964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15826, 15878);

                        return SyntaxKind.SuppressNullableWarningExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 15498, 15964);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 15498, 15964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 15926, 15949);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 15498, 15964);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 15405, 15975);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 15405, 15975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 15405, 15975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsIncrementOrDecrementOperator(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 15987, 16329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 16081, 16318);

                switch (token)
                {

                    case SyntaxKind.PlusPlusToken:
                    case SyntaxKind.MinusMinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 16081, 16318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 16230, 16242);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 16081, 16318);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 16081, 16318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 16290, 16303);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 16081, 16318);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 15987, 16329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 15987, 16329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 15987, 16329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUnaryOperatorDeclarationToken(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 16341, 16607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 16434, 16596);

                return f_10007_16441_16484(token) || (DynAbs.Tracing.TraceSender.Expression_False(10007, 16441, 16539) || token == SyntaxKind.TrueKeyword) || (DynAbs.Tracing.TraceSender.Expression_False(10007, 16441, 16595) || token == SyntaxKind.FalseKeyword);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 16341, 16607);

                bool
                f_10007_16441_16484(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = IsPrefixUnaryExpressionOperatorToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 16441, 16484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 16341, 16607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 16341, 16607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAnyOverloadableOperator(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 16619, 16795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 16705, 16784);

                return f_10007_16712_16746(kind) || (DynAbs.Tracing.TraceSender.Expression_False(10007, 16712, 16783) || f_10007_16750_16783(kind));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 16619, 16795);

                bool
                f_10007_16712_16746(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsOverloadableBinaryOperator(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 16712, 16746);
                    return return_v;
                }


                bool
                f_10007_16750_16783(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsOverloadableUnaryOperator(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 16750, 16783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 16619, 16795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 16619, 16795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsOverloadableBinaryOperator(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 16807, 17848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 16896, 17837);

                switch (kind)
                {

                    case SyntaxKind.PlusToken:
                    case SyntaxKind.MinusToken:
                    case SyntaxKind.AsteriskToken:
                    case SyntaxKind.SlashToken:
                    case SyntaxKind.PercentToken:
                    case SyntaxKind.CaretToken:
                    case SyntaxKind.AmpersandToken:
                    case SyntaxKind.BarToken:
                    case SyntaxKind.EqualsEqualsToken:
                    case SyntaxKind.LessThanToken:
                    case SyntaxKind.LessThanEqualsToken:
                    case SyntaxKind.LessThanLessThanToken:
                    case SyntaxKind.GreaterThanToken:
                    case SyntaxKind.GreaterThanEqualsToken:
                    case SyntaxKind.GreaterThanGreaterThanToken:
                    case SyntaxKind.ExclamationEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 16896, 17837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 17749, 17761);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 16896, 17837);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 16896, 17837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 17809, 17822);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 16896, 17837);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 16807, 17848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 16807, 17848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 16807, 17848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsOverloadableUnaryOperator(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 17860, 18473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 17948, 18462);

                switch (kind)
                {

                    case SyntaxKind.PlusToken:
                    case SyntaxKind.MinusToken:
                    case SyntaxKind.TildeToken:
                    case SyntaxKind.ExclamationToken:
                    case SyntaxKind.PlusPlusToken:
                    case SyntaxKind.MinusMinusToken:
                    case SyntaxKind.TrueKeyword:
                    case SyntaxKind.FalseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 17948, 18462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 18374, 18386);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 17948, 18462);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 17948, 18462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 18434, 18447);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 17948, 18462);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 17860, 18473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 17860, 18473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 17860, 18473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPrimaryFunction(SyntaxKind keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 18485, 18631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 18566, 18620);

                return f_10007_18573_18600(keyword) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 18485, 18631);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_18573_18600(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keyword)
                {
                    var return_v = GetPrimaryFunction(keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 18573, 18600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 18485, 18631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 18485, 18631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetPrimaryFunction(SyntaxKind keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 18643, 19717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 18731, 19706);

                switch (keyword)
                {

                    case SyntaxKind.MakeRefKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 18833, 18869);

                        return SyntaxKind.MakeRefExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    case SyntaxKind.RefTypeKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 18940, 18976);

                        return SyntaxKind.RefTypeExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    case SyntaxKind.RefValueKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19048, 19085);

                        return SyntaxKind.RefValueExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    case SyntaxKind.CheckedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19156, 19192);

                        return SyntaxKind.CheckedExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    case SyntaxKind.UncheckedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19265, 19303);

                        return SyntaxKind.UncheckedExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    case SyntaxKind.DefaultKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19374, 19410);

                        return SyntaxKind.DefaultExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    case SyntaxKind.TypeOfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19480, 19515);

                        return SyntaxKind.TypeOfExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    case SyntaxKind.SizeOfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19585, 19620);

                        return SyntaxKind.SizeOfExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 18731, 19706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19668, 19691);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 18731, 19706);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 18643, 19717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 18643, 19717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 18643, 19717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLiteralExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 19729, 19875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19810, 19864);

                return f_10007_19817_19844(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 19729, 19875);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_19817_19844(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetLiteralExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 19817, 19844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 19729, 19875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 19729, 19875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetLiteralExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 19887, 20893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 19975, 20882);

                switch (token)
                {

                    case SyntaxKind.StringLiteralToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20079, 20121);

                        return SyntaxKind.StringLiteralExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);

                    case SyntaxKind.CharacterLiteralToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20199, 20244);

                        return SyntaxKind.CharacterLiteralExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);

                    case SyntaxKind.NumericLiteralToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20320, 20363);

                        return SyntaxKind.NumericLiteralExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);

                    case SyntaxKind.NullKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20431, 20471);

                        return SyntaxKind.NullLiteralExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);

                    case SyntaxKind.TrueKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20539, 20579);

                        return SyntaxKind.TrueLiteralExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);

                    case SyntaxKind.FalseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20648, 20689);

                        return SyntaxKind.FalseLiteralExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);

                    case SyntaxKind.ArgListKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20760, 20796);

                        return SyntaxKind.ArgListExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 19975, 20882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20844, 20867);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 19975, 20882);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 19887, 20893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 19887, 20893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 19887, 20893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsInstanceExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 20905, 21053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 20987, 21042);

                return f_10007_20994_21022(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 20905, 21053);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_20994_21022(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetInstanceExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 20994, 21022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 20905, 21053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 20905, 21053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetInstanceExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 21065, 21482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 21154, 21471);

                switch (token)
                {

                    case SyntaxKind.ThisKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21154, 21471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 21251, 21284);

                        return SyntaxKind.ThisExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21154, 21471);

                    case SyntaxKind.BaseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21154, 21471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 21352, 21385);

                        return SyntaxKind.BaseExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21154, 21471);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21154, 21471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 21433, 21456);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21154, 21471);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 21065, 21482);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 21065, 21482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 21065, 21482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsBinaryExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 21494, 21638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 21574, 21627);

                return f_10007_21581_21607(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 21494, 21638);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_21581_21607(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetBinaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 21581, 21607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 21494, 21638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 21494, 21638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsBinaryExpressionOperatorToken(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 21650, 21807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 21743, 21796);

                return f_10007_21750_21776(token) != SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 21650, 21807);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_21750_21776(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = GetBinaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 21750, 21776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 21650, 21807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 21650, 21807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetBinaryExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 21819, 24332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 21906, 24321);

                switch (token)
                {

                    case SyntaxKind.QuestionQuestionToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22013, 22050);

                        return SyntaxKind.CoalesceExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.IsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22116, 22147);

                        return SyntaxKind.IsExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.AsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22213, 22244);

                        return SyntaxKind.AsExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.BarToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22309, 22347);

                        return SyntaxKind.BitwiseOrExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.CaretToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22414, 22454);

                        return SyntaxKind.ExclusiveOrExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.AmpersandToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22525, 22564);

                        return SyntaxKind.BitwiseAndExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.EqualsEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22638, 22673);

                        return SyntaxKind.EqualsExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.ExclamationEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22752, 22790);

                        return SyntaxKind.NotEqualsExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.LessThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22860, 22897);

                        return SyntaxKind.LessThanExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.LessThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 22973, 23017);

                        return SyntaxKind.LessThanOrEqualExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.GreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23090, 23130);

                        return SyntaxKind.GreaterThanExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.GreaterThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23209, 23256);

                        return SyntaxKind.GreaterThanOrEqualExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.LessThanLessThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23334, 23372);

                        return SyntaxKind.LeftShiftExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.GreaterThanGreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23456, 23495);

                        return SyntaxKind.RightShiftExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.PlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23561, 23593);

                        return SyntaxKind.AddExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.MinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23660, 23697);

                        return SyntaxKind.SubtractExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.AsteriskToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23767, 23804);

                        return SyntaxKind.MultiplyExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.SlashToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23871, 23906);

                        return SyntaxKind.DivideExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.PercentToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 23975, 24010);

                        return SyntaxKind.ModuloExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.AmpersandAmpersandToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 24090, 24129);

                        return SyntaxKind.LogicalAndExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    case SyntaxKind.BarBarToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 24197, 24235);

                        return SyntaxKind.LogicalOrExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 21906, 24321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 24283, 24306);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 21906, 24321);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 21819, 24332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 21819, 24332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 21819, 24332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAssignmentExpression(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 24344, 25316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 24427, 25305);

                switch (kind)
                {

                    case SyntaxKind.CoalesceAssignmentExpression:
                    case SyntaxKind.OrAssignmentExpression:
                    case SyntaxKind.AndAssignmentExpression:
                    case SyntaxKind.ExclusiveOrAssignmentExpression:
                    case SyntaxKind.LeftShiftAssignmentExpression:
                    case SyntaxKind.RightShiftAssignmentExpression:
                    case SyntaxKind.AddAssignmentExpression:
                    case SyntaxKind.SubtractAssignmentExpression:
                    case SyntaxKind.MultiplyAssignmentExpression:
                    case SyntaxKind.DivideAssignmentExpression:
                    case SyntaxKind.ModuloAssignmentExpression:
                    case SyntaxKind.SimpleAssignmentExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 24427, 25305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 25217, 25229);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 24427, 25305);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 24427, 25305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 25277, 25290);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 24427, 25305);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 24344, 25316);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 24344, 25316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 24344, 25316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAssignmentExpressionOperatorToken(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 25328, 26227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 25425, 26216);

                switch (token)
                {

                    case SyntaxKind.QuestionQuestionEqualsToken:
                    case SyntaxKind.BarEqualsToken:
                    case SyntaxKind.AmpersandEqualsToken:
                    case SyntaxKind.CaretEqualsToken:
                    case SyntaxKind.LessThanLessThanEqualsToken:
                    case SyntaxKind.GreaterThanGreaterThanEqualsToken:
                    case SyntaxKind.PlusEqualsToken:
                    case SyntaxKind.MinusEqualsToken:
                    case SyntaxKind.AsteriskEqualsToken:
                    case SyntaxKind.SlashEqualsToken:
                    case SyntaxKind.PercentEqualsToken:
                    case SyntaxKind.EqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 25425, 26216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26128, 26140);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 25425, 26216);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 25425, 26216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26188, 26201);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 25425, 26216);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 25328, 26227);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 25328, 26227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 25328, 26227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetAssignmentExpression(SyntaxKind token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 26239, 27920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26330, 27909);

                switch (token)
                {

                    case SyntaxKind.BarEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26430, 26471);

                        return SyntaxKind.OrAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.AmpersandEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26548, 26590);

                        return SyntaxKind.AndAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.CaretEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26663, 26713);

                        return SyntaxKind.ExclusiveOrAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.LessThanLessThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26797, 26845);

                        return SyntaxKind.LeftShiftAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.GreaterThanGreaterThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 26935, 26984);

                        return SyntaxKind.RightShiftAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.PlusEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27056, 27098);

                        return SyntaxKind.AddAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.MinusEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27171, 27218);

                        return SyntaxKind.SubtractAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.AsteriskEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27294, 27341);

                        return SyntaxKind.MultiplyAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.SlashEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27414, 27459);

                        return SyntaxKind.DivideAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.PercentEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27534, 27579);

                        return SyntaxKind.ModuloAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.EqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27647, 27692);

                        return SyntaxKind.SimpleAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    case SyntaxKind.QuestionQuestionEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27776, 27823);

                        return SyntaxKind.CoalesceAssignmentExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 26330, 27909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 27871, 27894);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 26330, 27909);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 26239, 27920);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 26239, 27920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 26239, 27920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetCheckStatement(SyntaxKind keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 27932, 28363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28019, 28352);

                switch (keyword)
                {

                    case SyntaxKind.CheckedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28019, 28352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28121, 28156);

                        return SyntaxKind.CheckedStatement;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28019, 28352);

                    case SyntaxKind.UncheckedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28019, 28352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28229, 28266);

                        return SyntaxKind.UncheckedStatement;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28019, 28352);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28019, 28352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28314, 28337);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28019, 28352);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 27932, 28363);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 27932, 28363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 27932, 28363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetAccessorDeclarationKind(SyntaxKind keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 28375, 29147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28471, 29136);

                switch (keyword)
                {

                    case SyntaxKind.GetKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28471, 29136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28569, 28610);

                        return SyntaxKind.GetAccessorDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28471, 29136);

                    case SyntaxKind.SetKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28471, 29136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28677, 28718);

                        return SyntaxKind.SetAccessorDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28471, 29136);

                    case SyntaxKind.InitKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28471, 29136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28786, 28828);

                        return SyntaxKind.InitAccessorDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28471, 29136);

                    case SyntaxKind.AddKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28471, 29136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 28895, 28936);

                        return SyntaxKind.AddAccessorDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28471, 29136);

                    case SyntaxKind.RemoveKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28471, 29136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 29006, 29050);

                        return SyntaxKind.RemoveAccessorDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28471, 29136);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 28471, 29136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 29098, 29121);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 28471, 29136);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 28375, 29147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 28375, 29147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 28375, 29147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAccessorDeclaration(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 29159, 29679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 29241, 29668);

                switch (kind)
                {

                    case SyntaxKind.GetAccessorDeclaration:
                    case SyntaxKind.SetAccessorDeclaration:
                    case SyntaxKind.InitAccessorDeclaration:
                    case SyntaxKind.AddAccessorDeclaration:
                    case SyntaxKind.RemoveAccessorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 29241, 29668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 29580, 29592);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 29241, 29668);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 29241, 29668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 29640, 29653);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 29241, 29668);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 29159, 29679);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 29159, 29679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 29159, 29679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAccessorDeclarationKeyword(SyntaxKind keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 29691, 30164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 29783, 30153);

                switch (keyword)
                {

                    case SyntaxKind.GetKeyword:
                    case SyntaxKind.SetKeyword:
                    case SyntaxKind.InitKeyword:
                    case SyntaxKind.AddKeyword:
                    case SyntaxKind.RemoveKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 29783, 30153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30065, 30077);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 29783, 30153);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 29783, 30153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30125, 30138);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 29783, 30153);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 29691, 30164);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 29691, 30164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 29691, 30164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetSwitchLabelKind(SyntaxKind keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 30176, 30602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30264, 30591);

                switch (keyword)
                {

                    case SyntaxKind.CaseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30264, 30591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30363, 30397);

                        return SyntaxKind.CaseSwitchLabel;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30264, 30591);

                    case SyntaxKind.DefaultKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30264, 30591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30468, 30505);

                        return SyntaxKind.DefaultSwitchLabel;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30264, 30591);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30264, 30591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30553, 30576);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30264, 30591);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 30176, 30602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 30176, 30602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 30176, 30602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetBaseTypeDeclarationKind(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 30614, 30816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30707, 30805);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10007, 30714, 30744) || ((kind == SyntaxKind.EnumKeyword && DynAbs.Tracing.TraceSender.Conditional_F2(10007, 30747, 30773)) || DynAbs.Tracing.TraceSender.Conditional_F3(10007, 30776, 30804))) ? SyntaxKind.EnumDeclaration : f_10007_30776_30804(kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 30614, 30816);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10007_30776_30804(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = GetTypeDeclarationKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 30776, 30804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 30614, 30816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 30614, 30816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetTypeDeclarationKind(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 30828, 31470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 30917, 31459);

                switch (kind)
                {

                    case SyntaxKind.ClassKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30917, 31459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31014, 31049);

                        return SyntaxKind.ClassDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30917, 31459);

                    case SyntaxKind.StructKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30917, 31459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31119, 31155);

                        return SyntaxKind.StructDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30917, 31459);

                    case SyntaxKind.InterfaceKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30917, 31459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31228, 31267);

                        return SyntaxKind.InterfaceDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30917, 31459);

                    case SyntaxKind.RecordKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30917, 31459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31337, 31373);

                        return SyntaxKind.RecordDeclaration;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30917, 31459);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 30917, 31459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31421, 31444);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 30917, 31459);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 30828, 31470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 30828, 31470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 30828, 31470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetKeywordKind(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 31482, 38590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31559, 38579);

                switch (text)
                {

                    case "bool":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31639, 31669);

                        return SyntaxKind.BoolKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "byte":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31721, 31751);

                        return SyntaxKind.ByteKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "sbyte":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31804, 31835);

                        return SyntaxKind.SByteKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "short":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31888, 31919);

                        return SyntaxKind.ShortKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "ushort":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 31973, 32005);

                        return SyntaxKind.UShortKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "int":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32056, 32085);

                        return SyntaxKind.IntKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "uint":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32137, 32167);

                        return SyntaxKind.UIntKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "long":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32219, 32249);

                        return SyntaxKind.LongKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "ulong":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32302, 32333);

                        return SyntaxKind.ULongKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "double":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32387, 32419);

                        return SyntaxKind.DoubleKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "float":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32472, 32503);

                        return SyntaxKind.FloatKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "decimal":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32558, 32591);

                        return SyntaxKind.DecimalKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "string":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32645, 32677);

                        return SyntaxKind.StringKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "char":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32729, 32759);

                        return SyntaxKind.CharKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "void":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32811, 32841);

                        return SyntaxKind.VoidKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "object":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32895, 32927);

                        return SyntaxKind.ObjectKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "typeof":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 32981, 33013);

                        return SyntaxKind.TypeOfKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "sizeof":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33067, 33099);

                        return SyntaxKind.SizeOfKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "null":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33151, 33181);

                        return SyntaxKind.NullKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "true":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33233, 33263);

                        return SyntaxKind.TrueKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "false":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33316, 33347);

                        return SyntaxKind.FalseKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "if":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33397, 33425);

                        return SyntaxKind.IfKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "else":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33477, 33507);

                        return SyntaxKind.ElseKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "while":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33560, 33591);

                        return SyntaxKind.WhileKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "for":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33642, 33671);

                        return SyntaxKind.ForKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "foreach":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33726, 33759);

                        return SyntaxKind.ForEachKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "do":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33809, 33837);

                        return SyntaxKind.DoKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "switch":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33891, 33923);

                        return SyntaxKind.SwitchKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "case":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 33975, 34005);

                        return SyntaxKind.CaseKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "default":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34060, 34093);

                        return SyntaxKind.DefaultKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "lock":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34145, 34175);

                        return SyntaxKind.LockKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "try":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34226, 34255);

                        return SyntaxKind.TryKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "throw":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34308, 34339);

                        return SyntaxKind.ThrowKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "catch":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34392, 34423);

                        return SyntaxKind.CatchKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "finally":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34478, 34511);

                        return SyntaxKind.FinallyKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "goto":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34563, 34593);

                        return SyntaxKind.GotoKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "break":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34646, 34677);

                        return SyntaxKind.BreakKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "continue":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34733, 34767);

                        return SyntaxKind.ContinueKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "return":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34821, 34853);

                        return SyntaxKind.ReturnKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "public":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34907, 34939);

                        return SyntaxKind.PublicKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "private":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 34994, 35027);

                        return SyntaxKind.PrivateKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "internal":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35083, 35117);

                        return SyntaxKind.InternalKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "protected":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35174, 35209);

                        return SyntaxKind.ProtectedKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "static":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35263, 35295);

                        return SyntaxKind.StaticKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "readonly":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35351, 35385);

                        return SyntaxKind.ReadOnlyKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "sealed":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35439, 35471);

                        return SyntaxKind.SealedKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "const":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35524, 35555);

                        return SyntaxKind.ConstKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "fixed":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35608, 35639);

                        return SyntaxKind.FixedKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "stackalloc":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35697, 35733);

                        return SyntaxKind.StackAllocKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "volatile":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35789, 35823);

                        return SyntaxKind.VolatileKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "new":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35874, 35903);

                        return SyntaxKind.NewKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "override":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 35959, 35993);

                        return SyntaxKind.OverrideKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "abstract":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36049, 36083);

                        return SyntaxKind.AbstractKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "virtual":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36138, 36171);

                        return SyntaxKind.VirtualKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "event":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36224, 36255);

                        return SyntaxKind.EventKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "extern":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36309, 36341);

                        return SyntaxKind.ExternKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "ref":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36392, 36421);

                        return SyntaxKind.RefKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "out":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36472, 36501);

                        return SyntaxKind.OutKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "in":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36551, 36579);

                        return SyntaxKind.InKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "is":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36629, 36657);

                        return SyntaxKind.IsKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "as":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36707, 36735);

                        return SyntaxKind.AsKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "params":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36789, 36821);

                        return SyntaxKind.ParamsKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "__arglist":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36878, 36911);

                        return SyntaxKind.ArgListKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "__makeref":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 36968, 37001);

                        return SyntaxKind.MakeRefKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "__reftype":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37058, 37091);

                        return SyntaxKind.RefTypeKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "__refvalue":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37149, 37183);

                        return SyntaxKind.RefValueKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "this":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37235, 37265);

                        return SyntaxKind.ThisKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "base":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37317, 37347);

                        return SyntaxKind.BaseKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "namespace":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37404, 37439);

                        return SyntaxKind.NamespaceKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "using":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37492, 37523);

                        return SyntaxKind.UsingKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "class":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37576, 37607);

                        return SyntaxKind.ClassKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "struct":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37661, 37693);

                        return SyntaxKind.StructKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "interface":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37750, 37785);

                        return SyntaxKind.InterfaceKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "enum":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37837, 37867);

                        return SyntaxKind.EnumKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "delegate":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 37923, 37957);

                        return SyntaxKind.DelegateKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "checked":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38012, 38045);

                        return SyntaxKind.CheckedKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "unchecked":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38102, 38137);

                        return SyntaxKind.UncheckedKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "unsafe":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38191, 38223);

                        return SyntaxKind.UnsafeKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "operator":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38279, 38313);

                        return SyntaxKind.OperatorKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "implicit":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38369, 38403);

                        return SyntaxKind.ImplicitKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    case "explicit":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38459, 38493);

                        return SyntaxKind.ExplicitKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 31559, 38579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38541, 38564);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 31559, 38579);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 31482, 38590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 31482, 38590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 31482, 38590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetOperatorKind(string operatorMetadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 38602, 41740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38696, 41729);

                switch (operatorMetadataName)
                {

                    case WellKnownMemberNames.AdditionOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38806, 38834);

                        return SyntaxKind.PlusToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.BitwiseAndOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 38902, 38935);

                        return SyntaxKind.AmpersandToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.BitwiseOrOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39002, 39029);

                        return SyntaxKind.BarToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.DecrementOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39167, 39201);

                        return SyntaxKind.MinusMinusToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.DivisionOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39267, 39296);

                        return SyntaxKind.SlashToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.EqualityOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39362, 39398);

                        return SyntaxKind.EqualsEqualsToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.ExclusiveOrOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39467, 39496);

                        return SyntaxKind.CaretToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.ExplicitConversionName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39564, 39598);

                        return SyntaxKind.ExplicitKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.FalseOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39729, 39760);

                        return SyntaxKind.FalseKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.GreaterThanOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39829, 39864);

                        return SyntaxKind.GreaterThanToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.GreaterThanOrEqualOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 39940, 39981);

                        return SyntaxKind.GreaterThanEqualsToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.ImplicitConversionName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40049, 40083);

                        return SyntaxKind.ImplicitKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.IncrementOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40150, 40182);

                        return SyntaxKind.PlusPlusToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.InequalityOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40250, 40291);

                        return SyntaxKind.ExclamationEqualsToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.LeftShiftOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40433, 40473);

                        return SyntaxKind.LessThanLessThanToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.LessThanOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40539, 40571);

                        return SyntaxKind.LessThanToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.LessThanOrEqualOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40644, 40682);

                        return SyntaxKind.LessThanEqualsToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.LogicalNotOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40814, 40849);

                        return SyntaxKind.ExclamationToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.ModulusOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 40914, 40945);

                        return SyntaxKind.PercentToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.MultiplyOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41011, 41043);

                        return SyntaxKind.AsteriskToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.OnesComplementOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41115, 41144);

                        return SyntaxKind.TildeToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.RightShiftOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41212, 41258);

                        return SyntaxKind.GreaterThanGreaterThanToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.SubtractionOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41327, 41356);

                        return SyntaxKind.MinusToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.TrueOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41418, 41448);

                        return SyntaxKind.TrueKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.UnaryNegationOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41519, 41548);

                        return SyntaxKind.MinusToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    case WellKnownMemberNames.UnaryPlusOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41615, 41643);

                        return SyntaxKind.PlusToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 38696, 41729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41691, 41714);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 38696, 41729);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 38602, 41740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 38602, 41740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 38602, 41740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetPreprocessorKeywordKind(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 41752, 44114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41841, 44103);

                switch (text)
                {

                    case "true":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 41921, 41951);

                        return SyntaxKind.TrueKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "false":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42004, 42035);

                        return SyntaxKind.FalseKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "default":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42090, 42123);

                        return SyntaxKind.DefaultKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "if":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42173, 42201);

                        return SyntaxKind.IfKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "else":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42253, 42283);

                        return SyntaxKind.ElseKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "elif":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42335, 42365);

                        return SyntaxKind.ElifKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "endif":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42418, 42449);

                        return SyntaxKind.EndIfKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "region":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42503, 42535);

                        return SyntaxKind.RegionKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "endregion":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42592, 42627);

                        return SyntaxKind.EndRegionKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "define":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42681, 42713);

                        return SyntaxKind.DefineKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "undef":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42766, 42797);

                        return SyntaxKind.UndefKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "warning":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42852, 42885);

                        return SyntaxKind.WarningKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "error":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 42938, 42969);

                        return SyntaxKind.ErrorKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "line":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43021, 43051);

                        return SyntaxKind.LineKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "pragma":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43105, 43137);

                        return SyntaxKind.PragmaKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "hidden":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43191, 43223);

                        return SyntaxKind.HiddenKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "checksum":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43279, 43313);

                        return SyntaxKind.ChecksumKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "disable":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43368, 43401);

                        return SyntaxKind.DisableKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "restore":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43456, 43489);

                        return SyntaxKind.RestoreKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "r":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43538, 43573);

                        return SyntaxKind.ReferenceKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "load":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43625, 43655);

                        return SyntaxKind.LoadKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "nullable":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43711, 43745);

                        return SyntaxKind.NullableKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "enable":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43799, 43831);

                        return SyntaxKind.EnableKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "warnings":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43887, 43921);

                        return SyntaxKind.WarningsKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    case "annotations":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 43980, 44017);

                        return SyntaxKind.AnnotationsKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 41841, 44103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 44065, 44088);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 41841, 44103);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 41752, 44114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 41752, 44114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 41752, 44114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<SyntaxKind> GetContextualKeywordKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 44126, 44388);

                var listYield = new List<SyntaxKind>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 44225, 44257);
                    for (int
        i = (int)SyntaxKind.YieldKeyword
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 44216, 44377) || true) && (i <= (int)SyntaxKind.UnmanagedKeyword)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 44298, 44301)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 44216, 44377))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 44216, 44377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 44335, 44362);

                        listYield.Add((SyntaxKind)i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10007, 1, 162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10007, 1, 162);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 44126, 44388);

                return listYield;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 44126, 44388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 44126, 44388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsContextualKeyword(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 44400, 46704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 44480, 46693);

                switch (kind)
                {

                    case SyntaxKind.YieldKeyword:
                    case SyntaxKind.PartialKeyword:
                    case SyntaxKind.FromKeyword:
                    case SyntaxKind.GroupKeyword:
                    case SyntaxKind.JoinKeyword:
                    case SyntaxKind.IntoKeyword:
                    case SyntaxKind.LetKeyword:
                    case SyntaxKind.ByKeyword:
                    case SyntaxKind.WhereKeyword:
                    case SyntaxKind.SelectKeyword:
                    case SyntaxKind.GetKeyword:
                    case SyntaxKind.SetKeyword:
                    case SyntaxKind.AddKeyword:
                    case SyntaxKind.RemoveKeyword:
                    case SyntaxKind.OrderByKeyword:
                    case SyntaxKind.AliasKeyword:
                    case SyntaxKind.OnKeyword:
                    case SyntaxKind.EqualsKeyword:
                    case SyntaxKind.AscendingKeyword:
                    case SyntaxKind.DescendingKeyword:
                    case SyntaxKind.AssemblyKeyword:
                    case SyntaxKind.ModuleKeyword:
                    case SyntaxKind.TypeKeyword:
                    case SyntaxKind.GlobalKeyword:
                    case SyntaxKind.FieldKeyword:
                    case SyntaxKind.MethodKeyword:
                    case SyntaxKind.ParamKeyword:
                    case SyntaxKind.PropertyKeyword:
                    case SyntaxKind.TypeVarKeyword:
                    case SyntaxKind.NameOfKeyword:
                    case SyntaxKind.AsyncKeyword:
                    case SyntaxKind.AwaitKeyword:
                    case SyntaxKind.WhenKeyword:
                    case SyntaxKind.UnderscoreToken:
                    case SyntaxKind.VarKeyword:
                    case SyntaxKind.OrKeyword:
                    case SyntaxKind.AndKeyword:
                    case SyntaxKind.NotKeyword:
                    case SyntaxKind.DataKeyword:
                    case SyntaxKind.WithKeyword:
                    case SyntaxKind.InitKeyword:
                    case SyntaxKind.RecordKeyword:
                    case SyntaxKind.ManagedKeyword:
                    case SyntaxKind.UnmanagedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 44480, 46693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 46605, 46617);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 44480, 46693);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 44480, 46693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 46665, 46678);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 44480, 46693);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 44400, 46704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 44400, 46704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 44400, 46704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsQueryContextualKeyword(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 46716, 47563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 46801, 47552);

                switch (kind)
                {

                    case SyntaxKind.FromKeyword:
                    case SyntaxKind.WhereKeyword:
                    case SyntaxKind.SelectKeyword:
                    case SyntaxKind.GroupKeyword:
                    case SyntaxKind.IntoKeyword:
                    case SyntaxKind.OrderByKeyword:
                    case SyntaxKind.JoinKeyword:
                    case SyntaxKind.LetKeyword:
                    case SyntaxKind.OnKeyword:
                    case SyntaxKind.EqualsKeyword:
                    case SyntaxKind.ByKeyword:
                    case SyntaxKind.AscendingKeyword:
                    case SyntaxKind.DescendingKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 46801, 47552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 47464, 47476);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 46801, 47552);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 46801, 47552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 47524, 47537);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 46801, 47552);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 46716, 47563);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 46716, 47563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 46716, 47563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind GetContextualKeywordKind(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 47575, 51490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 47662, 51479);

                switch (text)
                {

                    case "yield":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 47743, 47774);

                        return SyntaxKind.YieldKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "partial":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 47829, 47862);

                        return SyntaxKind.PartialKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "from":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 47914, 47944);

                        return SyntaxKind.FromKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "group":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 47997, 48028);

                        return SyntaxKind.GroupKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "join":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48080, 48110);

                        return SyntaxKind.JoinKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "into":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48162, 48192);

                        return SyntaxKind.IntoKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "let":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48243, 48272);

                        return SyntaxKind.LetKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "by":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48322, 48350);

                        return SyntaxKind.ByKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "where":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48403, 48434);

                        return SyntaxKind.WhereKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "select":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48488, 48520);

                        return SyntaxKind.SelectKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "get":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48571, 48600);

                        return SyntaxKind.GetKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "set":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48651, 48680);

                        return SyntaxKind.SetKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "add":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48731, 48760);

                        return SyntaxKind.AddKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "remove":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48814, 48846);

                        return SyntaxKind.RemoveKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "orderby":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48901, 48934);

                        return SyntaxKind.OrderByKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "alias":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 48987, 49018);

                        return SyntaxKind.AliasKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "on":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49068, 49096);

                        return SyntaxKind.OnKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "equals":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49150, 49182);

                        return SyntaxKind.EqualsKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "ascending":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49239, 49274);

                        return SyntaxKind.AscendingKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "descending":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49332, 49368);

                        return SyntaxKind.DescendingKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "assembly":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49424, 49458);

                        return SyntaxKind.AssemblyKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "module":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49512, 49544);

                        return SyntaxKind.ModuleKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "type":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49596, 49626);

                        return SyntaxKind.TypeKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "field":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49679, 49710);

                        return SyntaxKind.FieldKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "method":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49764, 49796);

                        return SyntaxKind.MethodKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "param":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49849, 49880);

                        return SyntaxKind.ParamKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "property":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 49936, 49970);

                        return SyntaxKind.PropertyKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "typevar":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50025, 50058);

                        return SyntaxKind.TypeVarKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "global":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50112, 50144);

                        return SyntaxKind.GlobalKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "async":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50197, 50228);

                        return SyntaxKind.AsyncKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "await":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50281, 50312);

                        return SyntaxKind.AwaitKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "when":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50364, 50394);

                        return SyntaxKind.WhenKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "nameof":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50448, 50480);

                        return SyntaxKind.NameOfKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "_":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50529, 50563);

                        return SyntaxKind.UnderscoreToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "var":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50614, 50643);

                        return SyntaxKind.VarKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "and":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50694, 50723);

                        return SyntaxKind.AndKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "or":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50773, 50801);

                        return SyntaxKind.OrKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "not":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50852, 50881);

                        return SyntaxKind.NotKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "data":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 50933, 50963);

                        return SyntaxKind.DataKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "with":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51015, 51045);

                        return SyntaxKind.WithKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "init":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51097, 51127);

                        return SyntaxKind.InitKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "record":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51181, 51213);

                        return SyntaxKind.RecordKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "managed":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51268, 51301);

                        return SyntaxKind.ManagedKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    case "unmanaged":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51358, 51393);

                        return SyntaxKind.UnmanagedKeyword;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 47662, 51479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51441, 51464);

                        return SyntaxKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 47662, 51479);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 47575, 51490);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 47575, 51490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 47575, 51490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetText(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 51502, 69817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51572, 69806);

                switch (kind)
                {

                    case SyntaxKind.TildeToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51667, 51678);

                        return "~";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ExclamationToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51751, 51762);

                        return "!";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DollarToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51830, 51841);

                        return "$";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PercentToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51910, 51921);

                        return "%";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CaretToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 51988, 51999);

                        return "^";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AmpersandToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52070, 52081);

                        return "&";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AsteriskToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52151, 52162);

                        return "*";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OpenParenToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52233, 52244);

                        return "(";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CloseParenToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52316, 52327);

                        return ")";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.MinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52394, 52405);

                        return "-";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52471, 52482);

                        return "+";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52550, 52561);

                        return "=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OpenBraceToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52632, 52643);

                        return "{";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CloseBraceToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52715, 52726);

                        return "}";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OpenBracketToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52799, 52810);

                        return "[";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CloseBracketToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52884, 52895);

                        return "]";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.BarToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 52960, 52971);

                        return "|";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.BackslashToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53042, 53054);

                        return "\\";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ColonToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53121, 53132);

                        return ":";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SemicolonToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53203, 53214);

                        return ";";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DoubleQuoteToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53287, 53299);

                        return "\"";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SingleQuoteToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53372, 53383);

                        return "'";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LessThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53453, 53464);

                        return "<";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CommaToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53531, 53542);

                        return ",";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53615, 53626);

                        return ">";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DotToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53691, 53702);

                        return ".";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.QuestionToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53772, 53783);

                        return "?";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.HashToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53849, 53860);

                        return "#";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SlashToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 53927, 53938);

                        return "/";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SlashGreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54016, 54028);

                        return "/>";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LessThanSlashToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54103, 54115);

                        return "</";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.XmlCommentStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54192, 54206);

                        return "<!--";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.XmlCommentEndToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54281, 54294);

                        return "-->";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.XmlCDataStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54369, 54388);

                        return "<![CDATA[";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.XmlCDataEndToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54461, 54474);

                        return "]]>";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.XmlProcessingInstructionStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54565, 54577);

                        return "<?";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.XmlProcessingInstructionEndToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54666, 54678);

                        return "?>";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.BarBarToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54777, 54789);

                        return "||";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AmpersandAmpersandToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54869, 54881);

                        return "&&";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.MinusMinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 54953, 54965);

                        return "--";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PlusPlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55035, 55047);

                        return "++";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ColonColonToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55119, 55131);

                        return "::";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.QuestionQuestionToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55209, 55221);

                        return "??";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.MinusGreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55299, 55311);

                        return "->";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ExclamationEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55390, 55402);

                        return "!=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EqualsEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55476, 55488);

                        return "==";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EqualsGreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55567, 55579);

                        return "=>";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LessThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55655, 55667);

                        return "<=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LessThanLessThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55745, 55757);

                        return "<<";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LessThanLessThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55841, 55854);

                        return "<<=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GreaterThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 55933, 55945);

                        return ">=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GreaterThanGreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56029, 56041);

                        return ">>";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GreaterThanGreaterThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56131, 56144);

                        return ">>=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SlashEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56217, 56229);

                        return "/=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AsteriskEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56305, 56317);

                        return "*=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.BarEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56388, 56400);

                        return "|=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AmpersandEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56477, 56489);

                        return "&=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PlusEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56561, 56573);

                        return "+=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.MinusEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56646, 56658);

                        return "-=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CaretEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56731, 56743);

                        return "^=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PercentEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56818, 56830);

                        return "%=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.QuestionQuestionEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56914, 56927);

                        return "??=";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DotDotToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 56995, 57007);

                        return "..";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.BoolKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57106, 57120);

                        return "bool";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ByteKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57188, 57202);

                        return "byte";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SByteKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57271, 57286);

                        return "sbyte";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ShortKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57355, 57370);

                        return "short";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UShortKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57440, 57456);

                        return "ushort";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.IntKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57523, 57536);

                        return "int";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UIntKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57604, 57618);

                        return "uint";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LongKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57686, 57700);

                        return "long";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ULongKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57769, 57784);

                        return "ulong";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DoubleKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57854, 57870);

                        return "double";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.FloatKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 57939, 57954);

                        return "float";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DecimalKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58025, 58042);

                        return "decimal";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.StringKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58112, 58128);

                        return "string";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CharKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58196, 58210);

                        return "char";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.VoidKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58278, 58292);

                        return "void";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ObjectKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58362, 58378);

                        return "object";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.TypeOfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58448, 58464);

                        return "typeof";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SizeOfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58534, 58550);

                        return "sizeof";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.NullKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58618, 58632);

                        return "null";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.TrueKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58700, 58714);

                        return "true";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.FalseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58783, 58798);

                        return "false";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.IfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58864, 58876);

                        return "if";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ElseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 58944, 58958);

                        return "else";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.WhileKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59027, 59042);

                        return "while";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ForKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59109, 59122);

                        return "for";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ForEachKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59193, 59210);

                        return "foreach";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DoKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59276, 59288);

                        return "do";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SwitchKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59358, 59374);

                        return "switch";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CaseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59442, 59456);

                        return "case";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DefaultKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59527, 59544);

                        return "default";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.TryKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59611, 59624);

                        return "try";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CatchKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59693, 59708);

                        return "catch";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.FinallyKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59779, 59796);

                        return "finally";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LockKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59864, 59878);

                        return "lock";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GotoKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 59946, 59960);

                        return "goto";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.BreakKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60029, 60044);

                        return "break";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ContinueKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60116, 60134);

                        return "continue";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ReturnKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60204, 60220);

                        return "return";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ThrowKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60289, 60304);

                        return "throw";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PublicKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60374, 60390);

                        return "public";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PrivateKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60461, 60478);

                        return "private";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.InternalKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60550, 60568);

                        return "internal";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ProtectedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60641, 60660);

                        return "protected";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.StaticKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60730, 60746);

                        return "static";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ReadOnlyKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60818, 60836);

                        return "readonly";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SealedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60906, 60922);

                        return "sealed";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ConstKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 60991, 61006);

                        return "const";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.FixedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61075, 61090);

                        return "fixed";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.StackAllocKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61164, 61184);

                        return "stackalloc";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.VolatileKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61256, 61274);

                        return "volatile";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.NewKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61341, 61354);

                        return "new";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OverrideKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61426, 61444);

                        return "override";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AbstractKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61516, 61534);

                        return "abstract";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.VirtualKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61605, 61622);

                        return "virtual";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EventKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61691, 61706);

                        return "event";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ExternKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61776, 61792);

                        return "extern";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.RefKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61859, 61872);

                        return "ref";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OutKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 61939, 61952);

                        return "out";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.InKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62018, 62030);

                        return "in";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.IsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62096, 62108);

                        return "is";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62174, 62186);

                        return "as";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ParamsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62256, 62272);

                        return "params";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ArgListKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62343, 62362);

                        return "__arglist";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.MakeRefKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62433, 62452);

                        return "__makeref";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.RefTypeKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62523, 62542);

                        return "__reftype";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.RefValueKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62614, 62634);

                        return "__refvalue";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ThisKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62702, 62716);

                        return "this";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.BaseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62784, 62798);

                        return "base";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.NamespaceKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62871, 62890);

                        return "namespace";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UsingKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 62959, 62974);

                        return "using";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ClassKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63043, 63058);

                        return "class";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.StructKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63128, 63144);

                        return "struct";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.InterfaceKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63217, 63236);

                        return "interface";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EnumKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63304, 63318);

                        return "enum";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DelegateKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63390, 63408);

                        return "delegate";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.CheckedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63479, 63496);

                        return "checked";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UncheckedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63569, 63588);

                        return "unchecked";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UnsafeKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63658, 63674);

                        return "unsafe";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OperatorKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63746, 63764);

                        return "operator";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ImplicitKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63836, 63854);

                        return "implicit";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ExplicitKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 63926, 63944);

                        return "explicit";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ElifKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64012, 64026);

                        return "elif";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EndIfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64095, 64110);

                        return "endif";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.RegionKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64180, 64196);

                        return "region";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EndRegionKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64269, 64288);

                        return "endregion";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DefineKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64358, 64374);

                        return "define";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UndefKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64443, 64458);

                        return "undef";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.WarningKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64529, 64546);

                        return "warning";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ErrorKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64615, 64630);

                        return "error";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LineKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64698, 64712);

                        return "line";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PragmaKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64782, 64798);

                        return "pragma";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.HiddenKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64868, 64884);

                        return "hidden";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ChecksumKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 64956, 64974);

                        return "checksum";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DisableKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65045, 65062);

                        return "disable";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.RestoreKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65133, 65150);

                        return "restore";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ReferenceKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65223, 65234);

                        return "r";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LoadKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65302, 65316);

                        return "load";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.NullableKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65388, 65406);

                        return "nullable";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EnableKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65476, 65492);

                        return "enable";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.WarningsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65564, 65582);

                        return "warnings";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AnnotationsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65657, 65678);

                        return "annotations";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.YieldKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65789, 65804);

                        return "yield";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PartialKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65875, 65892);

                        return "partial";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.FromKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 65960, 65974);

                        return "from";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GroupKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66043, 66058);

                        return "group";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.JoinKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66126, 66140);

                        return "join";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.IntoKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66208, 66222);

                        return "into";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.LetKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66289, 66302);

                        return "let";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ByKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66368, 66380);

                        return "by";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.WhereKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66449, 66464);

                        return "where";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SelectKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66534, 66550);

                        return "select";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GetKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66617, 66630);

                        return "get";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.SetKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66697, 66710);

                        return "set";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AddKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66777, 66790);

                        return "add";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.RemoveKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66860, 66876);

                        return "remove";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OrderByKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 66947, 66964);

                        return "orderby";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AliasKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67033, 67048);

                        return "alias";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OnKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67114, 67126);

                        return "on";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.EqualsKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67196, 67212);

                        return "equals";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AscendingKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67285, 67304);

                        return "ascending";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DescendingKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67378, 67398);

                        return "descending";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AssemblyKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67470, 67488);

                        return "assembly";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ModuleKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67558, 67574);

                        return "module";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.TypeKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67642, 67656);

                        return "type";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.FieldKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67725, 67740);

                        return "field";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.MethodKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67810, 67826);

                        return "method";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ParamKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67895, 67910);

                        return "param";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.PropertyKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 67982, 68000);

                        return "property";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.TypeVarKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68071, 68088);

                        return "typevar";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.GlobalKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68158, 68174);

                        return "global";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.NameOfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68244, 68260);

                        return "nameof";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AsyncKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68329, 68344);

                        return "async";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AwaitKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68413, 68428);

                        return "await";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.WhenKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68496, 68510);

                        return "when";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.InterpolatedStringStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68595, 68608);

                        return "$\"";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.InterpolatedStringEndToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68691, 68703);

                        return "\"";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.InterpolatedVerbatimStringStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68796, 68810);

                        return "$@\"";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UnderscoreToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68882, 68893);

                        return "_";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.VarKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 68960, 68973);

                        return "var";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.AndKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69040, 69053);

                        return "and";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.OrKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69119, 69131);

                        return "or";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.NotKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69198, 69211);

                        return "not";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.DataKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69279, 69293);

                        return "data";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.WithKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69361, 69375);

                        return "with";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.InitKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69443, 69457);

                        return "init";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.RecordKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69527, 69543);

                        return "record";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.ManagedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69614, 69631);

                        return "managed";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    case SyntaxKind.UnmanagedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69704, 69723);

                        return "unmanaged";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10007, 51572, 69806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69771, 69791);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10007, 51572, 69806);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 51502, 69817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 51502, 69817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 51502, 69817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTypeParameterVarianceKeyword(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 69829, 70000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 69920, 69989);

                return kind == SyntaxKind.OutKeyword || (DynAbs.Tracing.TraceSender.Expression_False(10007, 69927, 69988) || kind == SyntaxKind.InKeyword);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 69829, 70000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 69829, 70000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 69829, 70000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDocumentationCommentTrivia(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10007, 70012, 70250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10007, 70101, 70239);

                return kind == SyntaxKind.SingleLineDocumentationCommentTrivia || (DynAbs.Tracing.TraceSender.Expression_False(10007, 70108, 70238) || kind == SyntaxKind.MultiLineDocumentationCommentTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10007, 70012, 70250);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10007, 70012, 70250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10007, 70012, 70250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static bool
        f_10007_13251_13274(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = IsTypeDeclaration(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10007, 13251, 13274);
            return return_v;
        }

    }
}
