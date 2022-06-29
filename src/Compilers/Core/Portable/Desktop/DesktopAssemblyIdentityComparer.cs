// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Microsoft.CodeAnalysis
{
    public sealed partial class DesktopAssemblyIdentityComparer : AssemblyIdentityComparer
    {
        public static new DesktopAssemblyIdentityComparer Default { get; }

        internal readonly AssemblyPortabilityPolicy policy;

        internal DesktopAssemblyIdentityComparer(AssemblyPortabilityPolicy policy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(175, 2620, 2751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 2719, 2740);

                this.policy = policy;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(175, 2620, 2751);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 2620, 2751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 2620, 2751);
            }
        }

        public static DesktopAssemblyIdentityComparer LoadFromXml(Stream input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(175, 3728, 3924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 3824, 3913);

                return f_175_3831_3912(AssemblyPortabilityPolicy.LoadFromXml(input));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(175, 3728, 3924);

                Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                f_175_3831_3912(Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                policy)
                {
                    var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 3831, 3912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 3728, 3924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 3728, 3924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AssemblyPortabilityPolicy PortabilityPolicy
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(175, 4013, 4083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 4049, 4068);

                    return this.policy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(175, 4013, 4083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 3936, 4094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 3936, 4094);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ApplyUnificationPolicies(
                    ref AssemblyIdentity reference,
                    ref AssemblyIdentity definition,
                    AssemblyIdentityParts referenceParts,
                    out bool isDefinitionFxAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(175, 4106, 7001);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 4367, 4726) || true) && (f_175_4371_4392(reference) == AssemblyContentType.Default && (DynAbs.Tracing.TraceSender.Expression_True(175, 4371, 4502) && f_175_4444_4502(f_175_4444_4462(), f_175_4470_4484(reference), f_175_4486_4501(definition))) && (DynAbs.Tracing.TraceSender.Expression_True(175, 4371, 4576) && f_175_4523_4576(f_175_4523_4541(), f_175_4549_4563(reference), "mscorlib")))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 4367, 4726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 4610, 4640);

                    isDefinitionFxAssembly = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 4658, 4681);

                    reference = definition;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 4699, 4711);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 4367, 4726);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 4742, 5030) || true) && (f_175_4746_4771_M(!reference.IsRetargetable) && (DynAbs.Tracing.TraceSender.Expression_True(175, 4746, 4800) && f_175_4775_4800(definition)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 4742, 5030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 4953, 4984);

                    isDefinitionFxAssembly = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5002, 5015);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 4742, 5030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5431, 5459);

                reference = f_175_5443_5458(this, reference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5473, 5503);

                definition = f_175_5486_5502(this, definition);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5519, 6271) || true) && (f_175_5523_5547(reference) && (DynAbs.Tracing.TraceSender.Expression_True(175, 5523, 5577) && f_175_5551_5577_M(!definition.IsRetargetable)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 5519, 6271);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5611, 5786) || true) && (!f_175_5616_5659(referenceParts))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 5611, 5786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5701, 5732);

                        isDefinitionFxAssembly = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5754, 5767);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(175, 5611, 5786);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 5963, 6123);

                    bool
                    skipRetargeting = f_175_5986_6029(reference) && (DynAbs.Tracing.TraceSender.Expression_True(175, 5986, 6122) && f_175_6073_6122(reference, definition))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 6143, 6256) || true) && (!skipRetargeting)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 6143, 6256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 6205, 6237);

                        reference = f_175_6217_6236(reference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(175, 6143, 6256);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 5519, 6271);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 6673, 6962) || true) && (f_175_6677_6701(reference) && (DynAbs.Tracing.TraceSender.Expression_True(175, 6677, 6730) && f_175_6705_6730(definition)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 6673, 6962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 6764, 6824);

                    isDefinitionFxAssembly = f_175_6789_6823(definition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 6673, 6962);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 6673, 6962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 6890, 6947);

                    isDefinitionFxAssembly = f_175_6915_6946(definition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 6673, 6962);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 6978, 6990);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(175, 4106, 7001);

                System.Reflection.AssemblyContentType
                f_175_4371_4392(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4371, 4392);
                    return return_v;
                }


                System.StringComparer
                f_175_4444_4462()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4444, 4462);
                    return return_v;
                }


                string
                f_175_4470_4484(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4470, 4484);
                    return return_v;
                }


                string
                f_175_4486_4501(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4486, 4501);
                    return return_v;
                }


                bool
                f_175_4444_4502(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 4444, 4502);
                    return return_v;
                }


                System.StringComparer
                f_175_4523_4541()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4523, 4541);
                    return return_v;
                }


                string
                f_175_4549_4563(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4549, 4563);
                    return return_v;
                }


                bool
                f_175_4523_4576(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 4523, 4576);
                    return return_v;
                }


                bool
                f_175_4746_4771_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4746, 4771);
                    return return_v;
                }


                bool
                f_175_4775_4800(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 4775, 4800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_175_5443_5458(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = this_param.Port(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 5443, 5458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_175_5486_5502(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = this_param.Port(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 5486, 5502);
                    return return_v;
                }


                bool
                f_175_5523_5547(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 5523, 5547);
                    return return_v;
                }


                bool
                f_175_5551_5577_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 5551, 5577);
                    return return_v;
                }


                bool
                f_175_5616_5659(Microsoft.CodeAnalysis.AssemblyIdentityParts
                parts)
                {
                    var return_v = AssemblyIdentity.IsFullName(parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 5616, 5659);
                    return return_v;
                }


                bool
                f_175_5986_6029(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = IsOptionallyRetargetableAssembly(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 5986, 6029);
                    return return_v;
                }


                bool
                f_175_6073_6122(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = AssemblyIdentity.KeysEqual(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 6073, 6122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_175_6217_6236(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = Retarget(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 6217, 6236);
                    return return_v;
                }


                bool
                f_175_6677_6701(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 6677, 6701);
                    return return_v;
                }


                bool
                f_175_6705_6730(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 6705, 6730);
                    return return_v;
                }


                bool
                f_175_6789_6823(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = IsRetargetableAssembly(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 6789, 6823);
                    return return_v;
                }


                bool
                f_175_6915_6946(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = IsFrameworkAssembly(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 6915, 6946);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 4106, 7001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 4106, 7001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsFrameworkAssembly(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(175, 7140, 8288);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 7595, 7712) || true) && (f_175_7599_7619(identity) != AssemblyContentType.Default)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 7595, 7712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 7684, 7697);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 7595, 7712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 7728, 7768);

                FrameworkAssemblyDictionary.Value
                value
                = default(FrameworkAssemblyDictionary.Value);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 7782, 7980) || true) && (!f_175_7787_7837(s_arFxPolicy, f_175_7812_7825(identity), out value) || (DynAbs.Tracing.TraceSender.Expression_False(175, 7786, 7918) || !value.PublicKeyToken.SequenceEqual(f_175_7894_7917(identity))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 7782, 7980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 7952, 7965);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 7782, 7980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8051, 8138);

                uint
                thisVersion = ((uint)f_175_8077_8099(f_175_8077_8093(identity)) << 16) | (uint)f_175_8115_8137(f_175_8115_8131(identity))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8152, 8231);

                uint
                fxVersion = ((uint)value.Version.Major << 16) | (uint)value.Version.Minor
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8245, 8277);

                return thisVersion <= fxVersion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(175, 7140, 8288);

                System.Reflection.AssemblyContentType
                f_175_7599_7619(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 7599, 7619);
                    return return_v;
                }


                string
                f_175_7812_7825(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 7812, 7825);
                    return return_v;
                }


                bool
                f_175_7787_7837(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkAssemblyDictionary
                this_param, string
                key, out Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkAssemblyDictionary.Value
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 7787, 7837);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_175_7894_7917(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.PublicKeyToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 7894, 7917);
                    return return_v;
                }


                System.Version
                f_175_8077_8093(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 8077, 8093);
                    return return_v;
                }


                int
                f_175_8077_8099(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 8077, 8099);
                    return return_v;
                }


                System.Version
                f_175_8115_8131(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 8115, 8131);
                    return return_v;
                }


                int
                f_175_8115_8137(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 8115, 8137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 7140, 8288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 7140, 8288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsRetargetableAssembly(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(175, 8300, 8546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8394, 8422);

                bool
                retargetable
                = default(bool),
                portable
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8436, 8501);

                f_175_8436_8500(identity, out retargetable, out portable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8515, 8535);

                return retargetable;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(175, 8300, 8546);

                int
                f_175_8436_8500(Microsoft.CodeAnalysis.AssemblyIdentity
                identity, out bool
                retargetable, out bool
                portable)
                {
                    IsRetargetableAssembly(identity, out retargetable, out portable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 8436, 8500);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 8300, 8546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 8300, 8546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsOptionallyRetargetableAssembly(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(175, 8558, 8932);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8662, 8752) || true) && (f_175_8666_8690_M(!identity.IsRetargetable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 8662, 8752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8724, 8737);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 8662, 8752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8768, 8796);

                bool
                retargetable
                = default(bool),
                portable
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8810, 8875);

                f_175_8810_8874(identity, out retargetable, out portable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 8889, 8921);

                return retargetable && (DynAbs.Tracing.TraceSender.Expression_True(175, 8896, 8920) && portable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(175, 8558, 8932);

                bool
                f_175_8666_8690_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 8666, 8690);
                    return return_v;
                }


                int
                f_175_8810_8874(Microsoft.CodeAnalysis.AssemblyIdentity
                identity, out bool
                retargetable, out bool
                portable)
                {
                    IsRetargetableAssembly(identity, out retargetable, out portable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 8810, 8874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 8558, 8932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 8558, 8932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTriviallyNonRetargetable(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(175, 8944, 9345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9179, 9334);

                return f_175_9186_9213(f_175_9186_9206(identity)) != 0
                || (DynAbs.Tracing.TraceSender.Expression_False(175, 9186, 9290) || f_175_9239_9259(identity) != AssemblyContentType.Default
                ) || (DynAbs.Tracing.TraceSender.Expression_False(175, 9186, 9333) || f_175_9311_9333_M(!identity.IsStrongName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(175, 8944, 9345);

                string
                f_175_9186_9206(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 9186, 9206);
                    return return_v;
                }


                int
                f_175_9186_9213(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 9186, 9213);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_175_9239_9259(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 9239, 9259);
                    return return_v;
                }


                bool
                f_175_9311_9333_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 9311, 9333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 8944, 9345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 8944, 9345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void IsRetargetableAssembly(AssemblyIdentity identity, out bool retargetable, out bool portable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(175, 9357, 9830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9493, 9525);

                retargetable = portable = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9541, 9637) || true) && (f_175_9545_9581(identity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 9541, 9637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9615, 9622);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 9541, 9637);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9653, 9696);

                FrameworkRetargetingDictionary.Value
                value
                = default(FrameworkRetargetingDictionary.Value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9710, 9777);

                retargetable = f_175_9725_9776(s_arRetargetPolicy, identity, out value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9791, 9819);

                portable = value.IsPortable;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(175, 9357, 9830);

                bool
                f_175_9545_9581(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = IsTriviallyNonRetargetable(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 9545, 9581);
                    return return_v;
                }


                bool
                f_175_9725_9776(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity, out Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value
                value)
                {
                    var return_v = this_param.TryGetValue(identity, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 9725, 9776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 9357, 9830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 9357, 9830);
            }
        }

        private static AssemblyIdentity Retarget(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(175, 9842, 10645);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 9934, 10039) || true) && (f_175_9938_9974(identity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 9934, 10039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10008, 10024);

                    return identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 9934, 10039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10055, 10098);

                FrameworkRetargetingDictionary.Value
                value
                = default(FrameworkRetargetingDictionary.Value);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10112, 10602) || true) && (f_175_10116_10167(s_arRetargetPolicy, identity, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 10112, 10602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10201, 10587);

                    return f_175_10208_10586(value.NewName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(175, 10251, 10281) ?? f_175_10268_10281(identity)), value.NewVersion, f_175_10352_10372(identity), value.NewPublicKeyToken, hasPublicKey: false, isRetargetable: f_175_10499_10522(identity), contentType: AssemblyContentType.Default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 10112, 10602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10618, 10634);

                return identity;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(175, 9842, 10645);

                bool
                f_175_9938_9974(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = IsTriviallyNonRetargetable(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 9938, 9974);
                    return return_v;
                }


                bool
                f_175_10116_10167(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity, out Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value
                value)
                {
                    var return_v = this_param.TryGetValue(identity, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 10116, 10167);
                    return return_v;
                }


                string
                f_175_10268_10281(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 10268, 10281);
                    return return_v;
                }


                string
                f_175_10352_10372(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 10352, 10372);
                    return return_v;
                }


                bool
                f_175_10499_10522(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 10499, 10522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_175_10208_10586(string
                name, Microsoft.CodeAnalysis.AssemblyVersion
                version, string
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey, bool
                isRetargetable, System.Reflection.AssemblyContentType
                contentType)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, (System.Version)version, cultureName, publicKeyOrToken, hasPublicKey: hasPublicKey, isRetargetable: isRetargetable, contentType: contentType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 10208, 10586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 9842, 10645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 9842, 10645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AssemblyIdentity Port(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(175, 10657, 13186);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10738, 10911) || true) && (f_175_10742_10765(identity) || (DynAbs.Tracing.TraceSender.Expression_False(175, 10742, 10791) || f_175_10769_10791_M(!identity.IsStrongName)) || (DynAbs.Tracing.TraceSender.Expression_False(175, 10742, 10846) || f_175_10795_10815(identity) != AssemblyContentType.Default))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 10738, 10911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10880, 10896);

                    return identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 10738, 10911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10927, 10954);

                Version?
                newVersion = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 10968, 11017);

                ImmutableArray<byte>
                newPublicKeyToken = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11033, 11081);

                var
                version = (AssemblyVersion)f_175_11064_11080(identity)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11095, 12736) || true) && (version >= f_175_11110_11141(2, 0, 0, 0) && (DynAbs.Tracing.TraceSender.Expression_True(175, 11099, 11187) && version <= f_175_11156_11187(5, 9, 0, 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 11095, 12736);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11221, 12721) || true) && (identity.PublicKeyToken.SequenceEqual(s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 11221, 12721);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11344, 11827) || true) && (!policy.SuppressSilverlightPlatformAssembliesPortability)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 11344, 11827);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11454, 11804) || true) && (f_175_11458_11508(f_175_11458_11476(), f_175_11484_11497(identity), "System") || (DynAbs.Tracing.TraceSender.Expression_False(175, 11458, 11596) || f_175_11541_11596(f_175_11541_11559(), f_175_11567_11580(identity), "System.Core")))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 11454, 11804);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11654, 11704);

                                newVersion = (Version)s_VER_ASSEMBLYVERSION_STR_L;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11734, 11777);

                                newPublicKeyToken = s_ECMA_PUBLICKEY_STR_L;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(175, 11454, 11804);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(175, 11344, 11827);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(175, 11221, 12721);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 11221, 12721);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11869, 12721) || true) && (identity.PublicKeyToken.SequenceEqual(s_SILVERLIGHT_PUBLICKEY_STR_L))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 11869, 12721);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 11983, 12702) || true) && (!policy.SuppressSilverlightLibraryAssembliesPortability)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 11983, 12702);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12092, 12362) || true) && (f_175_12096_12161(f_175_12096_12114(), f_175_12122_12135(identity), "Microsoft.VisualBasic"))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 12092, 12362);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12219, 12257);

                                    newVersion = f_175_12232_12256(10, 0, 0, 0);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12287, 12335);

                                    newPublicKeyToken = s_MICROSOFT_PUBLICKEY_STR_L;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 12092, 12362);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12390, 12679) || true) && (f_175_12394_12471(f_175_12394_12412(), f_175_12420_12433(identity), "System.ComponentModel.Composition"))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 12390, 12679);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12529, 12579);

                                    newVersion = (Version)s_VER_ASSEMBLYVERSION_STR_L;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12609, 12652);

                                    newPublicKeyToken = s_ECMA_PUBLICKEY_STR_L;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 12390, 12679);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(175, 11983, 12702);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(175, 11869, 12721);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(175, 11221, 12721);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 11095, 12736);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12752, 12839) || true) && (newVersion == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(175, 12752, 12839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12808, 12824);

                    return identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(175, 12752, 12839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 12855, 13175);

                return f_175_12862_13174(f_175_12901_12914(identity), newVersion, f_175_12962_12982(identity), newPublicKeyToken, hasPublicKey: false, isRetargetable: f_175_13091_13114(identity), contentType: AssemblyContentType.Default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(175, 10657, 13186);

                bool
                f_175_10742_10765(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 10742, 10765);
                    return return_v;
                }


                bool
                f_175_10769_10791_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 10769, 10791);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_175_10795_10815(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 10795, 10815);
                    return return_v;
                }


                System.Version
                f_175_11064_11080(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 11064, 11080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyVersion
                f_175_11110_11141(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 11110, 11141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyVersion
                f_175_11156_11187(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 11156, 11187);
                    return return_v;
                }


                System.StringComparer
                f_175_11458_11476()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 11458, 11476);
                    return return_v;
                }


                string
                f_175_11484_11497(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 11484, 11497);
                    return return_v;
                }


                bool
                f_175_11458_11508(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 11458, 11508);
                    return return_v;
                }


                System.StringComparer
                f_175_11541_11559()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 11541, 11559);
                    return return_v;
                }


                string
                f_175_11567_11580(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 11567, 11580);
                    return return_v;
                }


                bool
                f_175_11541_11596(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 11541, 11596);
                    return return_v;
                }


                System.StringComparer
                f_175_12096_12114()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 12096, 12114);
                    return return_v;
                }


                string
                f_175_12122_12135(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 12122, 12135);
                    return return_v;
                }


                bool
                f_175_12096_12161(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 12096, 12161);
                    return return_v;
                }


                System.Version
                f_175_12232_12256(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 12232, 12256);
                    return return_v;
                }


                System.StringComparer
                f_175_12394_12412()
                {
                    var return_v = SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 12394, 12412);
                    return return_v;
                }


                string
                f_175_12420_12433(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 12420, 12433);
                    return return_v;
                }


                bool
                f_175_12394_12471(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 12394, 12471);
                    return return_v;
                }


                string
                f_175_12901_12914(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 12901, 12914);
                    return return_v;
                }


                string
                f_175_12962_12982(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 12962, 12982);
                    return return_v;
                }


                bool
                f_175_13091_13114(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(175, 13091, 13114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_175_12862_13174(string
                name, System.Version
                version, string
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey, bool
                isRetargetable, System.Reflection.AssemblyContentType
                contentType)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version, cultureName, publicKeyOrToken, hasPublicKey: hasPublicKey, isRetargetable: isRetargetable, contentType: contentType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 12862, 13174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(175, 10657, 13186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 10657, 13186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DesktopAssemblyIdentityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(175, 367, 13193);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(175, 2288, 2429);
            Default = f_175_2357_2428(default(AssemblyPortabilityPolicy)); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6564, 6677);
            s_NETCF_PUBLIC_KEY_TOKEN_1 = f_176_6593_6677(new byte[] { 0x1c, 0x9e, 0x25, 0x96, 0x86, 0xf9, 0x21, 0xe0 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6733, 6846);
            s_NETCF_PUBLIC_KEY_TOKEN_2 = f_176_6762_6846(new byte[] { 0x5f, 0xd5, 0x7c, 0x54, 0x3a, 0x9c, 0x02, 0x47 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6902, 7015);
            s_NETCF_PUBLIC_KEY_TOKEN_3 = f_176_6931_7015(new byte[] { 0x96, 0x9d, 0xb8, 0x05, 0x3d, 0x33, 0x22, 0xac }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 7071, 7180);
            s_SQL_PUBLIC_KEY_TOKEN = f_176_7096_7180(new byte[] { 0x89, 0x84, 0x5d, 0xcd, 0x80, 0x80, 0xcc, 0x91 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 7236, 7352);
            s_SQL_MOBILE_PUBLIC_KEY_TOKEN = f_176_7268_7352(new byte[] { 0x3b, 0xe2, 0x35, 0xdf, 0x1c, 0x8d, 0x2a, 0xd3 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 7408, 7517);
            s_ECMA_PUBLICKEY_STR_L = f_176_7433_7517(new byte[] { 0xb7, 0x7a, 0x5c, 0x56, 0x19, 0x34, 0xe0, 0x89 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 7573, 7687);
            s_SHAREDLIB_PUBLICKEY_STR_L = f_176_7603_7687(new byte[] { 0x31, 0xbf, 0x38, 0x56, 0xad, 0x36, 0x4e, 0x35 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 7743, 7857);
            s_MICROSOFT_PUBLICKEY_STR_L = f_176_7773_7857(new byte[] { 0xb0, 0x3f, 0x5f, 0x7f, 0x11, 0xd5, 0x0a, 0x3a }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 7913, 8038);
            s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L = f_176_7954_8038(new byte[] { 0x7c, 0xec, 0x85, 0xd7, 0xbe, 0xa7, 0x79, 0x8e }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 8094, 8210);
            s_SILVERLIGHT_PUBLICKEY_STR_L = f_176_8126_8210(new byte[] { 0x31, 0xbf, 0x38, 0x56, 0xad, 0x36, 0x4e, 0x35 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 8266, 8377);
            s_RIA_SERVICES_KEY_TOKEN = f_176_8293_8377(new byte[] { 0xdd, 0xd0, 0xda, 0x4d, 0x3e, 0x67, 0x82, 0x17 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 8430, 8508);
            s_VER_VS_COMPATIBILITY_ASSEMBLYVERSION_STR_L = f_176_8477_8508(8, 0, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 8559, 8624);
            s_VER_VS_ASSEMBLYVERSION_STR_L = f_176_8592_8624(10, 0, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 8675, 8742);
            s_VER_SQL_ASSEMBLYVERSION_STR_L = f_176_8709_8742(9, 0, 242, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 8793, 8859);
            s_VER_LINQ_ASSEMBLYVERSION_STR_L = f_176_8828_8859(3, 0, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 8910, 8978);
            s_VER_LINQ_ASSEMBLYVERSION_STR_2_L = f_176_8947_8978(3, 5, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 9029, 9100);
            s_VER_SQL_ORCAS_ASSEMBLYVERSION_STR_L = f_176_9069_9100(3, 5, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 9151, 9212);
            s_VER_ASSEMBLYVERSION_STR_L = f_176_9181_9212(4, 0, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 9263, 9334);
            s_VER_VC_STLCLR_ASSEMBLYVERSION_STR_L = f_176_9303_9334(2, 0, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 9366, 9377);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 9407, 9418);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 9797, 26501);
            s_arRetargetPolicy = new FrameworkRetargetingDictionary()
        {
            // ECMA v1.0 redirect    
            {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "System",176,9818,26501),s_ECMA_PUBLICKEY_STR_L,f_176_9953_9984(1, 0, 0, 0),NULL,NULL,s_ECMA_PUBLICKEY_STR_L,s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_ECMA_PUBLICKEY_STR_L, f_176_10104_10135(1, 0, 0, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},
            // Compat framework redirect
            {"System", s_NETCF_PUBLIC_KEY_TOKEN_1, f_176_10299_10333(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_10453_10487(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_10615_10649(1, 0, 5000, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Services", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_10787_10821(1, 0, 5000, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_10960_10994(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_11118_11152(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_11272_11306(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_11431_11465(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_11593_11627(1, 0, 5000, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Services", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_11765_11799(1, 0, 5000, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_11938_11972(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_12096_12130(1, 0, 5000, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_12265_12299(7, 0, 5000, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"System", s_NETCF_PUBLIC_KEY_TOKEN_1, f_176_12427_12461(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_12581_12615(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_12743_12777(1, 0, 5500, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Services", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_12915_12949(1, 0, 5500, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_13088_13122(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_13246_13280(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_13400_13434(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_13559_13593(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_13721_13755(1, 0, 5500, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Services", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_13893_13927(1, 0, 5500, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_14066_14100(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_14224_14258(1, 0, 5500, 0), NULL, NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_14393_14427(7, 0, 5500, 0), NULL, NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"Microsoft.WindowsCE.Forms", s_NETCF_PUBLIC_KEY_TOKEN_1, f_176_14574_14608(1, 0, 5000, 0), NULL, NULL, s_NETCF_PUBLIC_KEY_TOKEN_3, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.WindowsCE.Forms", s_NETCF_PUBLIC_KEY_TOKEN_1, f_176_14751_14785(1, 0, 5500, 0), NULL, NULL, s_NETCF_PUBLIC_KEY_TOKEN_3, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.WindowsCE.Forms", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_14928_14962(1, 0, 5000, 0), NULL, NULL, s_NETCF_PUBLIC_KEY_TOKEN_3, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.WindowsCE.Forms", s_NETCF_PUBLIC_KEY_TOKEN_2, f_176_15105_15139(1, 0, 5500, 0), NULL, NULL, s_NETCF_PUBLIC_KEY_TOKEN_3, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.WindowsCE.Forms", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_15282_15316(1, 0, 5000, 0), NULL, NULL, s_NETCF_PUBLIC_KEY_TOKEN_3, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.WindowsCE.Forms", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_15459_15493(1, 0, 5500, 0), NULL, NULL, s_NETCF_PUBLIC_KEY_TOKEN_3, s_VER_ASSEMBLYVERSION_STR_L},
            // Compat framework name redirect
            {"System.Data.SqlClient", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_15681_15715(1, 0, 5000, 0), NULL, "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.SqlClient", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_15859_15893(1, 0, 5500, 0), NULL, "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Common", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_16034_16068(1, 0, 5000, 0), NULL, "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Common", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_16209_16243(1, 0, 5500, 0), NULL, "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms.DataGrid", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_16395_16429(1, 0, 5000, 0), NULL, "System.Windows.Forms", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms.DataGrid", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_16590_16624(1, 0, 5500, 0), NULL, "System.Windows.Forms", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},
            // v2.0 Compact framework redirect
            {"System", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_16812_16843(2, 0, 0, 0), f_176_16845_16877(2, 0, 10, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_16995_17026(2, 0, 0, 0), f_176_17028_17060(2, 0, 10, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_17182_17213(2, 0, 0, 0), f_176_17215_17247(2, 0, 10, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Services", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_17379_17410(2, 0, 0, 0), f_176_17412_17444(2, 0, 10, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_17577_17608(2, 0, 0, 0), f_176_17610_17642(2, 0, 10, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_17761_17792(2, 0, 0, 0), f_176_17794_17826(2, 0, 10, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Messaging", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_17950_17981(2, 0, 0, 0), f_176_17983_18015(2, 0, 10, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.SqlClient", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_18149_18180(2, 0, 0, 0), f_176_18182_18214(2, 0, 10, 0), "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Common", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_18349_18380(2, 0, 0, 0), f_176_18382_18414(2, 0, 10, 0), "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms.DataGrid", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_18560_18591(2, 0, 0, 0), f_176_18593_18625(2, 0, 10, 0), "System.Windows.Forms", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_18772_18803(8, 0, 0, 0), f_176_18805_18837(8, 0, 10, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},
            // v3.5 Compact framework redirect
            {"System", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_19009_19040(3, 5, 0, 0), f_176_19042_19073(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_19191_19222(3, 5, 0, 0), f_176_19224_19255(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_19377_19408(3, 5, 0, 0), f_176_19410_19441(3, 9, 0, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Services", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_19573_19604(3, 5, 0, 0), f_176_19606_19637(3, 9, 0, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_19770_19801(3, 5, 0, 0), f_176_19803_19834(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_19953_19984(3, 5, 0, 0), f_176_19986_20017(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Messaging", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_20141_20172(3, 5, 0, 0), f_176_20174_20205(3, 9, 0, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.SqlClient", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_20339_20370(3, 5, 0, 0), f_176_20372_20403(3, 9, 0, 0), "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms.DataGrid", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_20549_20580(3, 5, 0, 0), f_176_20582_20613(3, 9, 0, 0), "System.Windows.Forms", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_20760_20791(8, 1, 0, 0), f_176_20793_20824(8, 1, 5, 0), "Microsoft.VisualBasic", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},
            // SQL Everywhere redirect for Orcas
            {"System.Data.SqlClient", s_SQL_MOBILE_PUBLIC_KEY_TOKEN, f_176_21035_21066(3, 5, 0, 0), NULL, "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.SqlServerCe", s_SQL_MOBILE_PUBLIC_KEY_TOKEN, f_176_21215_21246(3, 5, 0, 0), NULL, NULL, s_SQL_PUBLIC_KEY_TOKEN, s_VER_SQL_ORCAS_ASSEMBLYVERSION_STR_L},            {"System.Data.SqlServerCe", s_SQL_MOBILE_PUBLIC_KEY_TOKEN, f_176_21396_21427(3, 5, 1, 0), f_176_21429_21464(3, 5, 200, 999), NULL, s_SQL_PUBLIC_KEY_TOKEN, s_VER_SQL_ORCAS_ASSEMBLYVERSION_STR_L},
            // SQL CE redirect
            {"System.Data.SqlClient", s_SQL_MOBILE_PUBLIC_KEY_TOKEN, f_176_21640_21674(3, 0, 3600, 0), NULL, "System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.SqlServerCe", s_SQL_MOBILE_PUBLIC_KEY_TOKEN, f_176_21823_21857(3, 0, 3600, 0), NULL, NULL, s_SQL_PUBLIC_KEY_TOKEN, s_VER_SQL_ASSEMBLYVERSION_STR_L},
            // Linq and friends redirect
            {"system.xml.linq", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_22034_22065(3, 5, 0, 0), f_176_22067_22098(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_LINQ_ASSEMBLYVERSION_STR_2_L},            {"system.data.DataSetExtensions", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_22242_22273(3, 5, 0, 0), f_176_22275_22306(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_LINQ_ASSEMBLYVERSION_STR_2_L},            {"System.Core", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_22432_22463(3, 5, 0, 0), f_176_22465_22496(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_LINQ_ASSEMBLYVERSION_STR_2_L},            {"System.ServiceModel", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_22630_22661(3, 5, 0, 0), f_176_22663_22694(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_LINQ_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Serialization", s_NETCF_PUBLIC_KEY_TOKEN_3, f_176_22835_22866(3, 5, 0, 0), f_176_22868_22899(3, 9, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L, s_VER_LINQ_ASSEMBLYVERSION_STR_L},
            // Portable Library redirects
            {"mscorlib",                           s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_23105_23136(2, 0, 5, 0), f_176_23138_23170(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System",                             s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_23337_23368(2, 0, 5, 0), f_176_23370_23402(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.ComponentModel.Composition",  s_SILVERLIGHT_PUBLICKEY_STR_L,            f_176_23569_23600(2, 0, 5, 0), f_176_23602_23634(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.ComponentModel.DataAnnotations",s_RIA_SERVICES_KEY_TOKEN,               f_176_23801_23832(2, 0, 5, 0), f_176_23834_23866(99, 0, 0, 0), NULL, s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Core",                        s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_24033_24064(2, 0, 5, 0), f_176_24066_24098(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Net",                         s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_24265_24296(2, 0, 5, 0), f_176_24298_24330(99, 0, 0, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Numerics",                    s_SILVERLIGHT_PUBLICKEY_STR_L,            f_176_24497_24528(2, 0, 5, 0), f_176_24530_24562(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"Microsoft.CSharp",                   s_SILVERLIGHT_PUBLICKEY_STR_L,            f_176_24729_24760(2, 0, 5, 0), f_176_24762_24794(99, 0, 0, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Runtime.Serialization",       s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_24961_24992(2, 0, 5, 0), f_176_24994_25026(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.ServiceModel",                s_SILVERLIGHT_PUBLICKEY_STR_L,            f_176_25193_25224(2, 0, 5, 0), f_176_25226_25258(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.ServiceModel.Web",            s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_25425_25456(2, 0, 5, 0), f_176_25458_25490(99, 0, 0, 0), NULL, s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Xml",                         s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_25657_25688(2, 0, 5, 0), f_176_25690_25722(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Xml.Linq",                    s_SILVERLIGHT_PUBLICKEY_STR_L,            f_176_25889_25920(2, 0, 5, 0), f_176_25922_25954(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Xml.Serialization",           s_SILVERLIGHT_PUBLICKEY_STR_L,            f_176_26121_26152(2, 0, 5, 0), f_176_26154_26186(99, 0, 0, 0), NULL, s_ECMA_PUBLICKEY_STR_L,      s_VER_ASSEMBLYVERSION_STR_L, TRUE},            {"System.Windows",                     s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L,   f_176_26353_26384(2, 0, 5, 0), f_176_26386_26418(99, 0, 0, 0), NULL, s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L, TRUE}        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 26619, 48862);
            s_arFxPolicy = new FrameworkAssemblyDictionary()
        {
            {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Accessibility",176,26634,48862),s_MICROSOFT_PUBLICKEY_STR_L,s_VER_ASSEMBLYVERSION_STR_L},            {"CustomMarshalers", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"ISymWrapper", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.JScript", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic.Compatibility", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic.Compatibility.Data", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualC", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"mscorlib", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Configuration", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Configuration.Install", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.OracleClient", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.SqlXml", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Deployment", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Design", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.DirectoryServices", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.DirectoryServices.Protocols", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Drawing.Design", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.EnterpriseServices", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Management", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Messaging", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Remoting", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Serialization.Formatters.Soap", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Security", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceProcess", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Transactions", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Mobile", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.RegularExpressions", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Services", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},

            // Post-Everett FX 2.0 assemblies:
            {"AspNetMMCExt", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"sysglobl", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Build.Engine", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Build.Framework", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},
            // FX 3.0 assemblies:
            // Note: we shipped .NET 4.0 with entries in this list for PresentationCFFRasterizer and System.ServiceModel.Install
            // even though these assemblies did not ship with .NET 4.0. To maintain 100% compatibility with 4.0 we will keep
            // these in .NET 4.5, but we should remove them in a future SxS version of the Framework.
            {"PresentationCFFRasterizer", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationCore", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework.Aero", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework.Classic", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework.Luna", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework.Royale", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationUI", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"ReachFramework", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Printing", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Speech", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"UIAutomationClient", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"UIAutomationClientsideProviders", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"UIAutomationProvider", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"UIAutomationTypes", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"WindowsBase", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"WindowsFormsIntegration", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"SMDiagnostics", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.IdentityModel", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.IdentityModel.Selectors", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.IO.Log", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Serialization", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Install", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.WasHosting", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Workflow.Activities", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Workflow.ComponentModel", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Workflow.Runtime", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Transactions.Bridge", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Transactions.Bridge.Dtc", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},
            // FX 3.5 assemblies:
            {"System.AddIn", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.AddIn.Contract", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ComponentModel.Composition", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Core", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.DataSetExtensions", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Linq", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml.Linq", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.DirectoryServices.AccountManagement", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Management.Instrumentation", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Net", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Web", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Extensions", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Extensions.Design", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Presentation", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.WorkflowServices", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            // Microsoft.Data.Entity.Build.Tasks.dll should not be unified on purpose - it is supported SxS, i.e. both 3.5 and 4.0 versions can be loaded into CLR 4.0+.
            // {"Microsoft.Data.Entity.Build.Tasks", MICROSOFT_PUBLICKEY_STR_L, VER_ASSEMBLYVERSION_STR_L},

            // FX 3.5 SP1 assemblies:
            {"System.ComponentModel.DataAnnotations", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Entity", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Entity.Design", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Services", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Services.Client", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Data.Services.Design", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Abstractions", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.DynamicData", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.DynamicData.Design", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Entity", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Entity.Design", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.Routing", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},
            // FX 4.0 assemblies:
            {"Microsoft.Build", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.CSharp", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Dynamic", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Numerics", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xaml", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            // Microsoft.Workflow.Compiler.exe:
            // System.Workflow.ComponentModel.dll started to depend on Microsoft.Workflow.Compiler.exe in 4.0 RTM
            {"Microsoft.Workflow.Compiler", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},
            // FX 4.5 assemblies:
            {"Microsoft.Activities.Build", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Build.Conversion.v4.0", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Build.Tasks.v4.0", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Build.Utilities.v4.0", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.Internal.Tasks.Dataflow", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualBasic.Activities.Compiler", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VS_ASSEMBLYVERSION_STR_L},            {"Microsoft.VisualC.STLCLR", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_VC_STLCLR_ASSEMBLYVERSION_STR_L},            {"Microsoft.Windows.ApplicationServer.Applications", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationBuildTasks", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework.Aero2", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework.AeroLite", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework-SystemCore", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework-SystemData", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework-SystemDrawing", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework-SystemXml", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"PresentationFramework-SystemXmlLinq", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Activities", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Activities.Core.Presentation", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Activities.DurableInstancing", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Activities.Presentation", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ComponentModel.Composition.Registration", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Device", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.IdentityModel.Services", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.IO.Compression", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.IO.Compression.FileSystem", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Net.Http", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Net.Http.WebRequest", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Reflection.Context", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Caching", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.DurableInstancing", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.WindowsRuntime", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.WindowsRuntime.UI.Xaml", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Activation", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Activities", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Channels", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Discovery", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Internals", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Routing", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.ServiceMoniker40", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.ApplicationServices", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.DataVisualization", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Web.DataVisualization.Design", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Controls.Ribbon", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms.DataVisualization", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Forms.DataVisualization.Design", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Windows.Input.Manipulations", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xaml.Hosting", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"XamlBuildTask", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"XsdBuildTask", s_SHAREDLIB_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Numerics.Vectors", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},
            // FX 4.5 facade assemblies:
            {"System.Collections", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Collections.Concurrent", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ComponentModel", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ComponentModel.Annotations", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ComponentModel.EventBasedAsync", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Diagnostics.Contracts", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Diagnostics.Debug", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Diagnostics.Tools", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Diagnostics.Tracing", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Dynamic.Runtime", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Globalization", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.IO", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Linq", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Linq.Expressions", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Linq.Parallel", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Linq.Queryable", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Net.Http.Rtc", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Net.NetworkInformation", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Net.Primitives", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Net.Requests", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ObjectModel", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Reflection", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Reflection.Emit", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Reflection.Emit.ILGeneration", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Reflection.Emit.Lightweight", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Reflection.Extensions", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Reflection.Primitives", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Resources.ResourceManager", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Extensions", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Handles", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.InteropServices", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.InteropServices.WindowsRuntime", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Numerics", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Serialization.Json", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Serialization.Primitives", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Runtime.Serialization.Xml", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Security.Principal", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Duplex", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Http", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.NetTcp", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Primitives", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.ServiceModel.Security", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Text.Encoding", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Text.Encoding.Extensions", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Text.RegularExpressions", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Threading", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Threading.Tasks", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Threading.Tasks.Parallel", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Threading.Timer", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml.ReaderWriter", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml.XDocument", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml.XmlSerializer", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            // Manually added facades
            {"System.Windows", s_MICROSOFT_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L},            {"System.Xml.Serialization", s_ECMA_PUBLICKEY_STR_L, s_VER_ASSEMBLYVERSION_STR_L}        }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(175, 367, 13193);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(175, 367, 13193);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(175, 367, 13193);

        static Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
        f_175_2357_2428(Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
        policy)
        {
            var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer(policy);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(175, 2357, 2428);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_6593_6677(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 6593, 6677);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_6762_6846(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 6762, 6846);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_6931_7015(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 6931, 7015);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_7096_7180(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 7096, 7180);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_7268_7352(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 7268, 7352);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_7433_7517(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 7433, 7517);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_7603_7687(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 7603, 7687);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_7773_7857(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 7773, 7857);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_7954_8038(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 7954, 8038);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_8126_8210(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 8126, 8210);
            return return_v;
        }
        static System.Collections.Immutable.ImmutableArray<byte>
        f_176_8293_8377(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 8293, 8377);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_8477_8508(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 8477, 8508);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_8592_8624(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 8592, 8624);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_8709_8742(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 8709, 8742);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_8828_8859(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 8828, 8859);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_8947_8978(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 8947, 8978);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_9069_9100(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 9069, 9100);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_9181_9212(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 9181, 9212);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_9303_9334(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 9303, 9334);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_9953_9984(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 9953, 9984);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_10104_10135(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 10104, 10135);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_10299_10333(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 10299, 10333);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_10453_10487(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 10453, 10487);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_10615_10649(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 10615, 10649);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_10787_10821(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 10787, 10821);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_10960_10994(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 10960, 10994);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_11118_11152(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 11118, 11152);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_11272_11306(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 11272, 11306);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_11431_11465(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 11431, 11465);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_11593_11627(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 11593, 11627);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_11765_11799(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 11765, 11799);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_11938_11972(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 11938, 11972);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_12096_12130(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 12096, 12130);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_12265_12299(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 12265, 12299);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_12427_12461(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 12427, 12461);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_12581_12615(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 12581, 12615);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_12743_12777(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 12743, 12777);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_12915_12949(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 12915, 12949);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_13088_13122(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 13088, 13122);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_13246_13280(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 13246, 13280);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_13400_13434(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 13400, 13434);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_13559_13593(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 13559, 13593);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_13721_13755(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 13721, 13755);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_13893_13927(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 13893, 13927);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_14066_14100(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 14066, 14100);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_14224_14258(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 14224, 14258);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_14393_14427(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 14393, 14427);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_14574_14608(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 14574, 14608);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_14751_14785(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 14751, 14785);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_14928_14962(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 14928, 14962);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_15105_15139(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 15105, 15139);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_15282_15316(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 15282, 15316);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_15459_15493(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 15459, 15493);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_15681_15715(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 15681, 15715);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_15859_15893(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 15859, 15893);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_16034_16068(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 16034, 16068);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_16209_16243(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 16209, 16243);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_16395_16429(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 16395, 16429);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_16590_16624(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 16590, 16624);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_16812_16843(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 16812, 16843);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_16845_16877(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 16845, 16877);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_16995_17026(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 16995, 17026);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17028_17060(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17028, 17060);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17182_17213(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17182, 17213);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17215_17247(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17215, 17247);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17379_17410(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17379, 17410);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17412_17444(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17412, 17444);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17577_17608(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17577, 17608);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17610_17642(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17610, 17642);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17761_17792(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17761, 17792);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17794_17826(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17794, 17826);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17950_17981(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17950, 17981);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_17983_18015(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 17983, 18015);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18149_18180(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18149, 18180);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18182_18214(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18182, 18214);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18349_18380(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18349, 18380);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18382_18414(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18382, 18414);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18560_18591(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18560, 18591);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18593_18625(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18593, 18625);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18772_18803(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18772, 18803);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_18805_18837(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 18805, 18837);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19009_19040(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19009, 19040);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19042_19073(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19042, 19073);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19191_19222(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19191, 19222);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19224_19255(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19224, 19255);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19377_19408(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19377, 19408);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19410_19441(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19410, 19441);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19573_19604(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19573, 19604);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19606_19637(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19606, 19637);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19770_19801(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19770, 19801);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19803_19834(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19803, 19834);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19953_19984(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19953, 19984);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_19986_20017(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 19986, 20017);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20141_20172(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20141, 20172);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20174_20205(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20174, 20205);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20339_20370(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20339, 20370);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20372_20403(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20372, 20403);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20549_20580(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20549, 20580);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20582_20613(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20582, 20613);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20760_20791(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20760, 20791);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_20793_20824(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 20793, 20824);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_21035_21066(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 21035, 21066);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_21215_21246(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 21215, 21246);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_21396_21427(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 21396, 21427);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_21429_21464(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 21429, 21464);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_21640_21674(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 21640, 21674);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_21823_21857(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 21823, 21857);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22034_22065(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22034, 22065);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22067_22098(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22067, 22098);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22242_22273(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22242, 22273);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22275_22306(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22275, 22306);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22432_22463(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22432, 22463);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22465_22496(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22465, 22496);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22630_22661(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22630, 22661);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22663_22694(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22663, 22694);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22835_22866(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22835, 22866);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_22868_22899(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 22868, 22899);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23105_23136(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23105, 23136);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23138_23170(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23138, 23170);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23337_23368(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23337, 23368);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23370_23402(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23370, 23402);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23569_23600(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23569, 23600);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23602_23634(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23602, 23634);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23801_23832(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23801, 23832);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_23834_23866(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 23834, 23866);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24033_24064(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24033, 24064);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24066_24098(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24066, 24098);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24265_24296(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24265, 24296);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24298_24330(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24298, 24330);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24497_24528(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24497, 24528);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24530_24562(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24530, 24562);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24729_24760(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24729, 24760);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24762_24794(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24762, 24794);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24961_24992(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24961, 24992);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_24994_25026(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 24994, 25026);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25193_25224(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25193, 25224);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25226_25258(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25226, 25258);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25425_25456(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25425, 25456);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25458_25490(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25458, 25490);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25657_25688(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25657, 25688);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25690_25722(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25690, 25722);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25889_25920(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25889, 25920);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_25922_25954(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 25922, 25954);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_26121_26152(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 26121, 26152);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_26154_26186(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 26154, 26186);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_26353_26384(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 26353, 26384);
            return return_v;
        }
        static Microsoft.CodeAnalysis.AssemblyVersion
        f_176_26386_26418(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 26386, 26418);
            return return_v;
        }

    }
}
