// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    internal class MetadataSignatureUnitTestHelper
    {
        internal static void VerifyMemberSignatures(
                    IRuntimeEnvironment appDomainHost, params SignatureDescription[] expectedSignatures)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25018, 869, 1951);
                System.Collections.Generic.List<string> actualSignatures = default(System.Collections.Generic.List<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1036, 1071);

                f_25018_1036_1070(expectedSignatures);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1085, 1121);

                f_25018_1085_1120(expectedSignatures);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1137, 1158);

                var
                succeeded = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1172, 1206);

                var
                expected = f_25018_1187_1205()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1220, 1252);

                var
                actual = f_25018_1233_1251()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1268, 1811);
                    foreach (var signature in f_25018_1294_1312_I(expectedSignatures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 1268, 1811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1346, 1398);

                        var
                        expectedSignature = f_25018_1370_1397(signature)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1418, 1692) || true) && (!f_25018_1423_1613(appDomainHost, f_25018_1488_1520(signature), f_25018_1522_1542(signature), ref expectedSignature, out actualSignatures))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 1418, 1692);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1655, 1673);

                            succeeded = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 1418, 1692);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1712, 1744);

                        f_25018_1712_1743(
                                        expected, expectedSignature);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1762, 1796);

                        f_25018_1762_1795(actual, actualSignatures);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 1268, 1811);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25018, 1, 544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25018, 1, 544);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1827, 1940) || true) && (!succeeded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 1827, 1940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 1875, 1925);

                    f_25018_1875_1924(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 1827, 1940);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25018, 869, 1951);

                int
                f_25018_1036_1070(Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1036, 1070);
                    return 0;
                }


                int
                f_25018_1085_1120(Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]
                collection)
                {
                    Assert.NotEmpty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1085, 1120);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_25018_1187_1205()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1187, 1205);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_25018_1233_1251()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1233, 1251);
                    return return_v;
                }


                string
                f_25018_1370_1397(Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription
                this_param)
                {
                    var return_v = this_param.ExpectedSignature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25018, 1370, 1397);
                    return return_v;
                }


                string
                f_25018_1488_1520(Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription
                this_param)
                {
                    var return_v = this_param.FullyQualifiedTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25018, 1488, 1520);
                    return return_v;
                }


                string
                f_25018_1522_1542(Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription
                this_param)
                {
                    var return_v = this_param.MemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25018, 1522, 1542);
                    return return_v;
                }


                bool
                f_25018_1423_1613(Roslyn.Test.Utilities.IRuntimeEnvironment
                appDomainHost, string
                fullyQualifiedTypeName, string
                memberName, ref string
                expectedSignature, out System.Collections.Generic.List<string>
                actualSignatures)
                {
                    var return_v = VerifyMemberSignatureHelper(appDomainHost, fullyQualifiedTypeName, memberName, ref expectedSignature, out actualSignatures);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1423, 1613);
                    return return_v;
                }


                int
                f_25018_1712_1743(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1712, 1743);
                    return 0;
                }


                int
                f_25018_1762_1795(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.List<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1762, 1795);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]
                f_25018_1294_1312_I(Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1294, 1312);
                    return return_v;
                }


                int
                f_25018_1875_1924(System.Collections.Generic.List<string>
                expectedSignatures, System.Collections.Generic.List<string>
                actualSignatures)
                {
                    TriggerSignatureMismatchFailure(expectedSignatures, actualSignatures);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 1875, 1924);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25018, 869, 1951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25018, 869, 1951);
            }
        }

        private static bool VerifyMemberSignatureHelper(
                    IRuntimeEnvironment appDomainHost, string fullyQualifiedTypeName, string memberName,
                    ref string expectedSignature, out List<string> actualSignatures)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25018, 3366, 5881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 3615, 3730);

                f_25018_3615_3729(f_25018_3628_3677(fullyQualifiedTypeName), "'fullyQualifiedTypeName' can't be null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 3744, 3835);

                f_25018_3744_3834(f_25018_3757_3794(memberName), "'memberName' can't be null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 3851, 3869);

                var
                retVal = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 3883, 3921);

                actualSignatures = f_25018_3902_3920();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 3935, 4034);

                var
                signatures = f_25018_3952_4033(appDomainHost, fullyQualifiedTypeName, memberName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4048, 4156);

                var
                signatureAssertText = "Signature(\"" + fullyQualifiedTypeName + "\", \"" + memberName + "\", \"{0}\"),"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4172, 4330) || true) && (!f_25018_4177_4221(expectedSignature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 4172, 4330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4255, 4315);

                    expectedSignature = f_25018_4275_4314(expectedSignature, "\"", "\\\"");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 4172, 4330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4344, 4418);

                expectedSignature = f_25018_4364_4417(signatureAssertText, expectedSignature);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4434, 5840) || true) && (f_25018_4438_4454(signatures) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 4434, 5840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4492, 4510);

                    var
                    found = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4528, 5204);
                        foreach (var signature in f_25018_4554_4564_I(signatures))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 4528, 5204);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4606, 4660);

                            var
                            actualSignature = f_25018_4628_4659(signature, "\"", "\\\"")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4682, 4752);

                            actualSignature = f_25018_4700_4751(signatureAssertText, actualSignature);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4776, 5185) || true) && (actualSignature == expectedSignature)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 4776, 5185);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4866, 4891);

                                f_25018_4866_4890(actualSignatures);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4917, 4955);

                                f_25018_4917_4954(actualSignatures, actualSignature);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 4981, 4994);

                                found = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(25018, 5020, 5026);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 4776, 5185);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 4776, 5185);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5124, 5162);

                                f_25018_5124_5161(actualSignatures, actualSignature);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 4776, 5185);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 4528, 5204);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25018, 1, 677);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25018, 1, 677);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5222, 5308) || true) && (!found)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 5222, 5308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5274, 5289);

                        retVal = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 5222, 5308);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 4434, 5840);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 4434, 5840);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5342, 5840) || true) && (f_25018_5346_5362(signatures) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 5342, 5840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5401, 5464);

                        var
                        actualSignature = f_25018_5423_5463(f_25018_5423_5441(signatures), "\"", "\\\"")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5482, 5552);

                        actualSignature = f_25018_5500_5551(signatureAssertText, actualSignature);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5570, 5608);

                        f_25018_5570_5607(actualSignatures, actualSignature);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5628, 5744) || true) && (expectedSignature != actualSignature)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 5628, 5744);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5710, 5725);

                            retVal = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 5628, 5744);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 5342, 5840);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 5342, 5840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5810, 5825);

                        retVal = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 5342, 5840);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 4434, 5840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 5856, 5870);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25018, 3366, 5881);

                bool
                f_25018_3628_3677(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 3628, 3677);
                    return return_v;
                }


                int
                f_25018_3615_3729(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 3615, 3729);
                    return 0;
                }


                bool
                f_25018_3757_3794(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 3757, 3794);
                    return return_v;
                }


                int
                f_25018_3744_3834(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 3744, 3834);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_25018_3902_3920()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 3902, 3920);
                    return return_v;
                }


                System.Collections.Generic.SortedSet<string>
                f_25018_3952_4033(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param, string
                fullyQualifiedTypeName, string
                memberName)
                {
                    var return_v = this_param.GetMemberSignaturesFromMetadata(fullyQualifiedTypeName, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 3952, 4033);
                    return return_v;
                }


                bool
                f_25018_4177_4221(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4177, 4221);
                    return return_v;
                }


                string
                f_25018_4275_4314(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4275, 4314);
                    return return_v;
                }


                string
                f_25018_4364_4417(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4364, 4417);
                    return return_v;
                }


                int
                f_25018_4438_4454(System.Collections.Generic.SortedSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25018, 4438, 4454);
                    return return_v;
                }


                string
                f_25018_4628_4659(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4628, 4659);
                    return return_v;
                }


                string
                f_25018_4700_4751(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4700, 4751);
                    return return_v;
                }


                int
                f_25018_4866_4890(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4866, 4890);
                    return 0;
                }


                int
                f_25018_4917_4954(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4917, 4954);
                    return 0;
                }


                int
                f_25018_5124_5161(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 5124, 5161);
                    return 0;
                }


                System.Collections.Generic.SortedSet<string>
                f_25018_4554_4564_I(System.Collections.Generic.SortedSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 4554, 4564);
                    return return_v;
                }


                int
                f_25018_5346_5362(System.Collections.Generic.SortedSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25018, 5346, 5362);
                    return return_v;
                }


                string
                f_25018_5423_5441(System.Collections.Generic.SortedSet<string>
                source)
                {
                    var return_v = source.First<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 5423, 5441);
                    return return_v;
                }


                string
                f_25018_5423_5463(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 5423, 5463);
                    return return_v;
                }


                string
                f_25018_5500_5551(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 5500, 5551);
                    return return_v;
                }


                int
                f_25018_5570_5607(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 5570, 5607);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25018, 3366, 5881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25018, 3366, 5881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void TriggerSignatureMismatchFailure(List<string> expectedSignatures, List<string> actualSignatures)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25018, 6199, 7605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6339, 6371);

                var
                expectedText = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6385, 6415);

                var
                actualText = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6429, 6476);

                var
                distinctSignatures = f_25018_6454_6475()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6492, 6860);
                    foreach (var signature in f_25018_6518_6536_I(expectedSignatures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 6492, 6860);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6650, 6845) || true) && (!f_25018_6655_6693(distinctSignatures, signature))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 6650, 6845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6735, 6770);

                            expectedText += "\n\t" + signature;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6792, 6826);

                            f_25018_6792_6825(distinctSignatures, signature);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 6650, 6845);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 6492, 6860);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25018, 1, 369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25018, 1, 369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6876, 6903);

                f_25018_6876_6902(
                            distinctSignatures);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 6917, 7281);
                    foreach (var signature in f_25018_6943_6959_I(actualSignatures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 6917, 7281);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 7073, 7266) || true) && (!f_25018_7078_7116(distinctSignatures, signature))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25018, 7073, 7266);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 7158, 7191);

                            actualText += "\n\t" + signature;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 7213, 7247);

                            f_25018_7213_7246(distinctSignatures, signature);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 7073, 7266);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25018, 6917, 7281);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25018, 1, 365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25018, 1, 365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 7297, 7338);

                expectedText = f_25018_7312_7337(expectedText, ',');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 7352, 7389);

                actualText = f_25018_7365_7388(actualText, ',');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 7403, 7464);

                var
                diffText = f_25018_7418_7463(expectedText, actualText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25018, 7480, 7594);

                f_25018_7480_7593(false, "\n\nExpected:" + expectedText + "\n\nActual:" + actualText + "\n\nDifferences:\n" + diffText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25018, 6199, 7605);

                System.Collections.Generic.HashSet<string>
                f_25018_6454_6475()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 6454, 6475);
                    return return_v;
                }


                bool
                f_25018_6655_6693(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 6655, 6693);
                    return return_v;
                }


                bool
                f_25018_6792_6825(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 6792, 6825);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_25018_6518_6536_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 6518, 6536);
                    return return_v;
                }


                int
                f_25018_6876_6902(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 6876, 6902);
                    return 0;
                }


                bool
                f_25018_7078_7116(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 7078, 7116);
                    return return_v;
                }


                bool
                f_25018_7213_7246(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 7213, 7246);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_25018_6943_6959_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 6943, 6959);
                    return return_v;
                }


                string
                f_25018_7312_7337(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 7312, 7337);
                    return return_v;
                }


                string
                f_25018_7365_7388(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 7365, 7388);
                    return return_v;
                }


                string
                f_25018_7418_7463(string
                expected, string
                actual)
                {
                    var return_v = DiffUtil.DiffReport(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 7418, 7463);
                    return return_v;
                }


                int
                f_25018_7480_7593(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25018, 7480, 7593);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25018, 6199, 7605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25018, 6199, 7605);
            }
        }

        public MetadataSignatureUnitTestHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25018, 422, 7612);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25018, 422, 7612);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25018, 422, 7612);
        }


        static MetadataSignatureUnitTestHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25018, 422, 7612);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25018, 422, 7612);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25018, 422, 7612);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25018, 422, 7612);
    }
}
