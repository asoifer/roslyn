// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    public class AssemblyIdentityComparer
    {
        public static AssemblyIdentityComparer Default { get; }

        public static StringComparer SimpleNameComparer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(422, 692, 740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 698, 738);

                    return f_422_705_737();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(422, 692, 740);

                    System.StringComparer
                    f_422_705_737()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 705, 737);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 620, 751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 620, 751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static StringComparer CultureComparer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(422, 832, 880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 838, 878);

                    return f_422_845_877();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(422, 832, 880);

                    System.StringComparer
                    f_422_845_877()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 845, 877);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 763, 891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 763, 891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal AssemblyIdentityComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(422, 903, 960);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(422, 903, 960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 903, 960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 903, 960);
            }
        }

        /// <summary>
        /// A set of possible outcomes of <see cref="AssemblyIdentity"/> comparison.
        /// </summary>
        public enum ComparisonResult
        {
            /// <summary>
            /// Reference doesn't match definition.
            /// </summary>
            NotEquivalent = 0,

            /// <summary>
            /// Strongly named reference matches strongly named definition (strong identity is identity with public key or token),
            /// Or weak reference matches weak definition.
            /// </summary>
            Equivalent = 1,

            /// <summary>
            /// Reference matches definition except for version (reference version is lower or higher than definition version).
            /// </summary>
            EquivalentIgnoringVersion = 2
        }

        public bool ReferenceMatchesDefinition(string referenceDisplayName, AssemblyIdentity definition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(422, 2213, 2494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 2334, 2483);

                return f_422_2341_2448(this, reference: null, referenceDisplayName, definition, unificationApplied: out _, ignoreVersion: false) != ComparisonResult.NotEquivalent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(422, 2213, 2494);

                Microsoft.CodeAnalysis.AssemblyIdentityComparer.ComparisonResult
                f_422_2341_2448(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity?
                reference, string
                referenceDisplayName, Microsoft.CodeAnalysis.AssemblyIdentity
                definition, out bool
                unificationApplied, bool
                ignoreVersion)
                {
                    var return_v = this_param.Compare(reference: reference, referenceDisplayName, definition, out unificationApplied, ignoreVersion: ignoreVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 2341, 2448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 2213, 2494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 2213, 2494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ReferenceMatchesDefinition(AssemblyIdentity reference, AssemblyIdentity definition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(422, 2873, 3153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 2993, 3142);

                return f_422_3000_3107(this, reference, referenceDisplayName: null, definition, unificationApplied: out _, ignoreVersion: false) != ComparisonResult.NotEquivalent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(422, 2873, 3153);

                Microsoft.CodeAnalysis.AssemblyIdentityComparer.ComparisonResult
                f_422_3000_3107(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, string?
                referenceDisplayName, Microsoft.CodeAnalysis.AssemblyIdentity
                definition, out bool
                unificationApplied, bool
                ignoreVersion)
                {
                    var return_v = this_param.Compare(reference, referenceDisplayName: referenceDisplayName, definition, out unificationApplied, ignoreVersion: ignoreVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 3000, 3107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 2873, 3153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 2873, 3153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ComparisonResult Compare(AssemblyIdentity reference, AssemblyIdentity definition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(422, 3451, 3689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 3564, 3678);

                return f_422_3571_3677(this, reference, referenceDisplayName: null, definition, unificationApplied: out _, ignoreVersion: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(422, 3451, 3689);

                Microsoft.CodeAnalysis.AssemblyIdentityComparer.ComparisonResult
                f_422_3571_3677(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, string?
                referenceDisplayName, Microsoft.CodeAnalysis.AssemblyIdentity
                definition, out bool
                unificationApplied, bool
                ignoreVersion)
                {
                    var return_v = this_param.Compare(reference, referenceDisplayName: referenceDisplayName, definition, out unificationApplied, ignoreVersion: ignoreVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 3571, 3677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 3451, 3689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 3451, 3689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ComparisonResult Compare(AssemblyIdentity? reference, string? referenceDisplayName, AssemblyIdentity definition, out bool unificationApplied, bool ignoreVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(422, 3734, 8575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 3929, 3996);

                f_422_3929_3995((reference != null) ^ (referenceDisplayName != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4010, 4037);

                unificationApplied = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4051, 4079);

                AssemblyIdentityParts
                parts
                = default(AssemblyIdentityParts);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4095, 4907) || true) && (reference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 4095, 4907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4180, 4234);

                    bool?
                    eq = f_422_4191_4233(reference, definition)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4252, 4407) || true) && (f_422_4256_4267(eq))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 4252, 4407);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4309, 4388);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(422, 4316, 4324) || ((f_422_4316_4324(eq) && DynAbs.Tracing.TraceSender.Conditional_F2(422, 4327, 4354)) || DynAbs.Tracing.TraceSender.Conditional_F3(422, 4357, 4387))) ? ComparisonResult.Equivalent : ComparisonResult.NotEquivalent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(422, 4252, 4407);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4427, 4565);

                    parts = AssemblyIdentityParts.Name | AssemblyIdentityParts.Version | AssemblyIdentityParts.Culture | AssemblyIdentityParts.PublicKeyToken;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 4095, 4907);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 4095, 4907);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4631, 4892) || true) && (!f_422_4636_4721(referenceDisplayName!, out reference, out parts) || (DynAbs.Tracing.TraceSender.Expression_False(422, 4635, 4793) || f_422_4746_4767(reference) != f_422_4771_4793(definition)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 4631, 4892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4835, 4873);

                        return ComparisonResult.NotEquivalent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(422, 4631, 4892);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 4095, 4907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 4923, 4985);

                f_422_4923_4984(f_422_4936_4957(reference) == f_422_4961_4983(definition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5001, 5029);

                bool
                isDefinitionFxAssembly
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5043, 5225) || true) && (!f_422_5048_5138(this, ref reference, ref definition, parts, out isDefinitionFxAssembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 5043, 5225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5172, 5210);

                    return ComparisonResult.NotEquivalent;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 5043, 5225);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5241, 5367) || true) && (f_422_5245_5283(reference, definition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 5241, 5367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5317, 5352);

                    return ComparisonResult.Equivalent;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 5241, 5367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5383, 5450);

                bool
                compareCulture = (parts & AssemblyIdentityParts.Culture) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5464, 5547);

                bool
                comparePublicKeyToken = (parts & AssemblyIdentityParts.PublicKeyOrToken) != 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5563, 6441) || true) && (f_422_5567_5591_M(!definition.IsStrongName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 5563, 6441);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5625, 5750) || true) && (f_422_5629_5651(reference))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 5625, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5693, 5731);

                        return ComparisonResult.NotEquivalent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(422, 5625, 5750);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5770, 6375) || true) && (!f_422_5775_5809(parts))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 5770, 6375);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5851, 6025) || true) && (!f_422_5856_5914(f_422_5856_5874(), f_422_5882_5896(reference), f_422_5898_5913(definition)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 5851, 6025);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 5964, 6002);

                            return ComparisonResult.NotEquivalent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(422, 5851, 6025);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6049, 6252) || true) && (compareCulture && (DynAbs.Tracing.TraceSender.Expression_True(422, 6053, 6141) && !f_422_6072_6141(f_422_6072_6087(), f_422_6095_6116(reference), f_422_6118_6140(definition))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 6049, 6252);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6191, 6229);

                            return ComparisonResult.NotEquivalent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(422, 6049, 6252);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6321, 6356);

                        return ComparisonResult.Equivalent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(422, 5770, 6375);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6395, 6426);

                    isDefinitionFxAssembly = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 5563, 6441);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6457, 6607) || true) && (!f_422_6462_6520(f_422_6462_6480(), f_422_6488_6502(reference), f_422_6504_6519(definition)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 6457, 6607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6554, 6592);

                    return ComparisonResult.NotEquivalent;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 6457, 6607);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6623, 6802) || true) && (compareCulture && (DynAbs.Tracing.TraceSender.Expression_True(422, 6627, 6715) && !f_422_6646_6715(f_422_6646_6661(), f_422_6669_6690(reference), f_422_6692_6714(definition))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 6623, 6802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6749, 6787);

                    return ComparisonResult.NotEquivalent;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 6623, 6802);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6818, 6984) || true) && (comparePublicKeyToken && (DynAbs.Tracing.TraceSender.Expression_True(422, 6822, 6897) && !f_422_6848_6897(reference, definition)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 6818, 6984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 6931, 6969);

                    return ComparisonResult.NotEquivalent;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 6818, 6984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 7000, 7072);

                bool
                hasSomeVersionParts = (parts & AssemblyIdentityParts.Version) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 7086, 7184);

                bool
                hasPartialVersion = (parts & AssemblyIdentityParts.Version) != AssemblyIdentityParts.Version
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 7335, 8513) || true) && (f_422_7339_7362(definition) && (DynAbs.Tracing.TraceSender.Expression_True(422, 7339, 7402) && hasSomeVersionParts) && (DynAbs.Tracing.TraceSender.Expression_True(422, 7339, 7485) && (hasPartialVersion || (DynAbs.Tracing.TraceSender.Expression_False(422, 7424, 7484) || f_422_7445_7462(reference) != f_422_7466_7484(definition)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 7335, 8513);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8122, 8292) || true) && (isDefinitionFxAssembly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 8122, 8292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8190, 8216);

                        unificationApplied = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8238, 8273);

                        return ComparisonResult.Equivalent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(422, 8122, 8292);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8312, 8440) || true) && (ignoreVersion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 8312, 8440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8371, 8421);

                        return ComparisonResult.EquivalentIgnoringVersion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(422, 8312, 8440);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8460, 8498);

                    return ComparisonResult.NotEquivalent;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 7335, 8513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8529, 8564);

                return ComparisonResult.Equivalent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(422, 3734, 8575);

                int
                f_422_3929_3995(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 3929, 3995);
                    return 0;
                }


                bool?
                f_422_4191_4233(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = TriviallyEquivalent(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 4191, 4233);
                    return return_v;
                }


                bool
                f_422_4256_4267(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 4256, 4267);
                    return return_v;
                }


                bool
                f_422_4316_4324(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 4316, 4324);
                    return return_v;
                }


                bool
                f_422_4636_4721(string
                displayName, out Microsoft.CodeAnalysis.AssemblyIdentity?
                identity, out Microsoft.CodeAnalysis.AssemblyIdentityParts
                parts)
                {
                    var return_v = AssemblyIdentity.TryParseDisplayName(displayName, out identity, out parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 4636, 4721);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_422_4746_4767(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 4746, 4767);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_422_4771_4793(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 4771, 4793);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_422_4936_4957(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 4936, 4957);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_422_4961_4983(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 4961, 4983);
                    return return_v;
                }


                int
                f_422_4923_4984(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 4923, 4984);
                    return 0;
                }


                bool
                f_422_5048_5138(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, ref Microsoft.CodeAnalysis.AssemblyIdentity
                reference, ref Microsoft.CodeAnalysis.AssemblyIdentity
                definition, Microsoft.CodeAnalysis.AssemblyIdentityParts
                referenceParts, out bool
                isDefinitionFxAssembly)
                {
                    var return_v = this_param.ApplyUnificationPolicies(ref reference, ref definition, referenceParts, out isDefinitionFxAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 5048, 5138);
                    return return_v;
                }


                bool
                f_422_5245_5283(Microsoft.CodeAnalysis.AssemblyIdentity
                objA, Microsoft.CodeAnalysis.AssemblyIdentity
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 5245, 5283);
                    return return_v;
                }


                bool
                f_422_5567_5591_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 5567, 5591);
                    return return_v;
                }


                bool
                f_422_5629_5651(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 5629, 5651);
                    return return_v;
                }


                bool
                f_422_5775_5809(Microsoft.CodeAnalysis.AssemblyIdentityParts
                parts)
                {
                    var return_v = AssemblyIdentity.IsFullName(parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 5775, 5809);
                    return return_v;
                }


                System.StringComparer
                f_422_5856_5874()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 5856, 5874);
                    return return_v;
                }


                string
                f_422_5882_5896(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 5882, 5896);
                    return return_v;
                }


                string
                f_422_5898_5913(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 5898, 5913);
                    return return_v;
                }


                bool
                f_422_5856_5914(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 5856, 5914);
                    return return_v;
                }


                System.StringComparer
                f_422_6072_6087()
                {
                    var return_v = CultureComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6072, 6087);
                    return return_v;
                }


                string
                f_422_6095_6116(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6095, 6116);
                    return return_v;
                }


                string
                f_422_6118_6140(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6118, 6140);
                    return return_v;
                }


                bool
                f_422_6072_6141(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 6072, 6141);
                    return return_v;
                }


                System.StringComparer
                f_422_6462_6480()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6462, 6480);
                    return return_v;
                }


                string
                f_422_6488_6502(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6488, 6502);
                    return return_v;
                }


                string
                f_422_6504_6519(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6504, 6519);
                    return return_v;
                }


                bool
                f_422_6462_6520(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 6462, 6520);
                    return return_v;
                }


                System.StringComparer
                f_422_6646_6661()
                {
                    var return_v = CultureComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6646, 6661);
                    return return_v;
                }


                string
                f_422_6669_6690(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6669, 6690);
                    return return_v;
                }


                string
                f_422_6692_6714(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 6692, 6714);
                    return return_v;
                }


                bool
                f_422_6646_6715(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 6646, 6715);
                    return return_v;
                }


                bool
                f_422_6848_6897(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = AssemblyIdentity.KeysEqual(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 6848, 6897);
                    return return_v;
                }


                bool
                f_422_7339_7362(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 7339, 7362);
                    return return_v;
                }


                System.Version
                f_422_7445_7462(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 7445, 7462);
                    return return_v;
                }


                System.Version
                f_422_7466_7484(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 7466, 7484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 3734, 8575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 3734, 8575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool? TriviallyEquivalent(AssemblyIdentity x, AssemblyIdentity y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(422, 8587, 9112);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8762, 8858) || true) && (f_422_8766_8779(x) != f_422_8783_8796(y))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 8762, 8858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8830, 8843);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 8762, 8858);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 8938, 9039) || true) && (f_422_8942_8958(x) || (DynAbs.Tracing.TraceSender.Expression_False(422, 8942, 8978) || f_422_8962_8978(y)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(422, 8938, 9039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 9012, 9024);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(422, 8938, 9039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 9055, 9101);

                return f_422_9062_9100(x, y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(422, 8587, 9112);

                System.Reflection.AssemblyContentType
                f_422_8766_8779(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 8766, 8779);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_422_8783_8796(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 8783, 8796);
                    return return_v;
                }


                bool
                f_422_8942_8958(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 8942, 8958);
                    return return_v;
                }


                bool
                f_422_8962_8978(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(422, 8962, 8978);
                    return return_v;
                }


                bool?
                f_422_9062_9100(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = AssemblyIdentity.MemberwiseEqual(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 9062, 9100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 8587, 9112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 8587, 9112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool ApplyUnificationPolicies(ref AssemblyIdentity reference, ref AssemblyIdentity definition, AssemblyIdentityParts referenceParts, out bool isDefinitionFxAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(422, 9124, 9399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 9331, 9362);

                isDefinitionFxAssembly = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 9376, 9388);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(422, 9124, 9399);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(422, 9124, 9399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 9124, 9399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblyIdentityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(422, 465, 9406);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(422, 519, 608);
            Default = f_422_577_607(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(422, 465, 9406);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(422, 465, 9406);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(422, 465, 9406);

        static Microsoft.CodeAnalysis.AssemblyIdentityComparer
        f_422_577_607()
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyIdentityComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(422, 577, 607);
            return return_v;
        }

    }
}

