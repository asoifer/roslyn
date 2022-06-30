// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    internal struct AttributeUsageInfo : IEquatable<AttributeUsageInfo>
    {
        [Flags()]
        private enum PackedAttributeUsage
        {
            None = 0,
            Assembly = AttributeTargets.Assembly,
            Module = AttributeTargets.Module,
            Class = AttributeTargets.Class,
            Struct = AttributeTargets.Struct,
            Enum = AttributeTargets.Enum,
            Constructor = AttributeTargets.Constructor,
            Method = AttributeTargets.Method,
            Property = AttributeTargets.Property,
            Field = AttributeTargets.Field,
            Event = AttributeTargets.Event,
            Interface = AttributeTargets.Interface,
            Parameter = AttributeTargets.Parameter,
            Delegate = AttributeTargets.Delegate,
            ReturnValue = AttributeTargets.ReturnValue,
            GenericParameter = AttributeTargets.GenericParameter,
            All = AttributeTargets.All,

            // NOTE: VB allows AttributeUsageAttribute with no valid target, i.e. <AttributeUsageAttribute(0)>, and doesn't generate any diagnostics.
            // We use PackedAttributeUsage.Initialized field to differentiate between uninitialized AttributeUsageInfo and initialized AttributeUsageInfo with no valid target.
            Initialized = GenericParameter << 1,

            AllowMultiple = Initialized << 1,
            Inherited = AllowMultiple << 1
        }

        private readonly PackedAttributeUsage _flags;

        internal static readonly AttributeUsageInfo Default;

        internal static readonly AttributeUsageInfo Null;

        internal AttributeUsageInfo(AttributeTargets validTargets, bool allowMultiple, bool inherited)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(785, 2449, 3233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 2897, 2976);

                _flags = (PackedAttributeUsage)validTargets | PackedAttributeUsage.Initialized;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 2992, 3103) || true) && (allowMultiple)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 2992, 3103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 3043, 3088);

                    _flags |= PackedAttributeUsage.AllowMultiple;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(785, 2992, 3103);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 3119, 3222) || true) && (inherited)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 3119, 3222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 3166, 3207);

                    _flags |= PackedAttributeUsage.Inherited;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(785, 3119, 3222);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(785, 2449, 3233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 2449, 3233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 2449, 3233);
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 3288, 3395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 3324, 3380);

                    return (_flags & PackedAttributeUsage.Initialized) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(785, 3288, 3395);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 3245, 3406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 3245, 3406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal AttributeTargets ValidTargets
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 3483, 3595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 3519, 3580);

                    return (AttributeTargets)(_flags & PackedAttributeUsage.All);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(785, 3483, 3595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 3420, 3606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 3420, 3606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool AllowMultiple
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 3670, 3779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 3706, 3764);

                    return (_flags & PackedAttributeUsage.AllowMultiple) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(785, 3670, 3779);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 3618, 3790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 3618, 3790);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool Inherited
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 3850, 3955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 3886, 3940);

                    return (_flags & PackedAttributeUsage.Inherited) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(785, 3850, 3955);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 3802, 3966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 3802, 3966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool operator ==(AttributeUsageInfo left, AttributeUsageInfo right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(785, 3978, 4130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4084, 4119);

                return left._flags == right._flags;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(785, 3978, 4130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 3978, 4130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 3978, 4130);
            }
        }

        public static bool operator !=(AttributeUsageInfo left, AttributeUsageInfo right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(785, 4142, 4294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4248, 4283);

                return left._flags != right._flags;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(785, 4142, 4294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 4142, 4294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 4142, 4294);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 4306, 4533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4371, 4493) || true) && (obj is AttributeUsageInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 4371, 4493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4434, 4478);

                    return this.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(785, 4371, 4493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4509, 4522);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(785, 4306, 4533);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 4306, 4533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 4306, 4533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(AttributeUsageInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 4545, 4646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4614, 4635);

                return this == other;
                DynAbs.Tracing.TraceSender.TraceExitMethod(785, 4545, 4646);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 4545, 4646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 4545, 4646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 4658, 4755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4716, 4744);

                return f_785_4723_4743(_flags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(785, 4658, 4755);

                int
                f_785_4723_4743(Microsoft.CodeAnalysis.AttributeUsageInfo.PackedAttributeUsage
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 4723, 4743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 4658, 4755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 4658, 4755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasValidAttributeTargets
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 4830, 4992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4866, 4896);

                    var
                    value = (int)ValidTargets
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 4914, 4977);

                    return value != 0 && (DynAbs.Tracing.TraceSender.Expression_True(785, 4921, 4976) && (value & (int)~AttributeTargets.All) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(785, 4830, 4992);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 4767, 5003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 4767, 5003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal object GetValidTargetsErrorArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 5015, 5758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5086, 5126);

                var
                validTargetsInt = (int)ValidTargets
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5140, 5238) || true) && (f_785_5144_5169_M(!HasValidAttributeTargets))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 5140, 5238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5203, 5223);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(785, 5140, 5238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5254, 5303);

                var
                builder = f_785_5268_5302()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5317, 5330);

                int
                flag = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5344, 5651) || true) && (validTargetsInt > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 5344, 5651);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5404, 5569) || true) && ((validTargetsInt & 1) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 5404, 5569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5476, 5550);

                            f_785_5476_5549(builder, GetErrorDisplayNameResourceId((AttributeTargets)(1 << flag)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(785, 5404, 5569);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5589, 5611);

                        validTargetsInt >>= 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5629, 5636);

                        flag++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 5344, 5651);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(785, 5344, 5651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(785, 5344, 5651);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 5667, 5747);

                return f_785_5674_5746(f_785_5721_5745(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(785, 5015, 5758);

                bool
                f_785_5144_5169_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(785, 5144, 5169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_785_5268_5302()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 5268, 5302);
                    return return_v;
                }


                int
                f_785_5476_5549(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 5476, 5549);
                    return 0;
                }


                string[]
                f_785_5721_5745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 5721, 5745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo.ValidTargetsStringLocalizableErrorArgument
                f_785_5674_5746(string[]
                targetResourceIds)
                {
                    var return_v = new Microsoft.CodeAnalysis.AttributeUsageInfo.ValidTargetsStringLocalizableErrorArgument(targetResourceIds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 5674, 5746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 5015, 5758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 5015, 5758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct ValidTargetsStringLocalizableErrorArgument : IFormattable
        {

            private readonly string[]? _targetResourceIds;

            internal ValidTargetsStringLocalizableErrorArgument(string[] targetResourceIds)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(785, 5929, 6159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6041, 6087);

                    f_785_6041_6086(targetResourceIds != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6105, 6144);

                    _targetResourceIds = targetResourceIds;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(785, 5929, 6159);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 5929, 6159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 5929, 6159);
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 6175, 6284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6241, 6269);

                    return ToString(null, null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(785, 6175, 6284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 6175, 6284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 6175, 6284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string ToString(string? format, IFormatProvider? formatProvider)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(785, 6300, 7160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6404, 6452);

                    var
                    builder = f_785_6418_6451()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6470, 6535);

                    var
                    culture = formatProvider as System.Globalization.CultureInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6555, 7016) || true) && (_targetResourceIds != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 6555, 7016);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6627, 6997);
                            foreach (string id in f_785_6649_6667_I(_targetResourceIds))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 6627, 6997);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6717, 6861) || true) && (f_785_6721_6743(builder.Builder) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 6717, 6861);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6805, 6834);

                                    f_785_6805_6833(builder.Builder, ", ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(785, 6717, 6861);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 6889, 6974);

                                f_785_6889_6973(
                                                        builder.Builder, f_785_6912_6972(f_785_6912_6949(), id, culture));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(785, 6627, 6997);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(785, 1, 371);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(785, 1, 371);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 6555, 7016);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7036, 7077);

                    var
                    message = f_785_7050_7076(builder.Builder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7095, 7110);

                    f_785_7095_7109(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7130, 7145);

                    return message;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(785, 6300, 7160);

                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_785_6418_6451()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 6418, 6451);
                        return return_v;
                    }


                    int
                    f_785_6721_6743(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(785, 6721, 6743);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_785_6805_6833(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 6805, 6833);
                        return return_v;
                    }


                    System.Resources.ResourceManager
                    f_785_6912_6949()
                    {
                        var return_v = CodeAnalysisResources.ResourceManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(785, 6912, 6949);
                        return return_v;
                    }


                    string?
                    f_785_6912_6972(System.Resources.ResourceManager
                    this_param, string
                    name, System.Globalization.CultureInfo?
                    culture)
                    {
                        var return_v = this_param.GetString(name, culture);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 6912, 6972);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_785_6889_6973(System.Text.StringBuilder
                    this_param, string?
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 6889, 6973);
                        return return_v;
                    }


                    string[]
                    f_785_6649_6667_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 6649, 6667);
                        return return_v;
                    }


                    string
                    f_785_7050_7076(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 7050, 7076);
                        return return_v;
                    }


                    int
                    f_785_7095_7109(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 7095, 7109);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 6300, 7160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 6300, 7160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static ValidTargetsStringLocalizableErrorArgument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(785, 5770, 7171);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(785, 5770, 7171);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 5770, 7171);
            }

            static int
            f_785_6041_6086(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 6041, 6086);
                return 0;
            }

        }

        private static string GetErrorDisplayNameResourceId(AttributeTargets target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(785, 7183, 8870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7284, 8859);

                switch (target)
                {

                    case AttributeTargets.Assembly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7364, 7410);

                        return nameof(CodeAnalysisResources.Assembly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Class:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7457, 7501);

                        return nameof(CodeAnalysisResources.Class1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Constructor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7554, 7603);

                        return nameof(CodeAnalysisResources.Constructor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Delegate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7653, 7700);

                        return nameof(CodeAnalysisResources.Delegate1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7746, 7789);

                        return nameof(CodeAnalysisResources.Enum1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7836, 7880);

                        return nameof(CodeAnalysisResources.Event1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 7927, 7970);

                        return nameof(CodeAnalysisResources.Field);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.GenericParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8028, 8079);

                        return nameof(CodeAnalysisResources.TypeParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8130, 8178);

                        return nameof(CodeAnalysisResources.Interface1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8226, 8270);

                        return nameof(CodeAnalysisResources.Method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Module:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8318, 8362);

                        return nameof(CodeAnalysisResources.Module);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8413, 8460);

                        return nameof(CodeAnalysisResources.Parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8510, 8556);

                        return nameof(CodeAnalysisResources.Property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.ReturnValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8609, 8654);

                        return nameof(CodeAnalysisResources.Return1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    case AttributeTargets.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8702, 8747);

                        return nameof(CodeAnalysisResources.Struct1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(785, 7284, 8859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 8795, 8844);

                        throw f_785_8801_8843(target);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(785, 7284, 8859);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(785, 7183, 8870);

                System.Exception
                f_785_8801_8843(System.AttributeTargets
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 8801, 8843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(785, 7183, 8870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 7183, 8870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AttributeUsageInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(785, 442, 8877);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 2238, 2345);
            Default = f_785_2248_2345(validTargets: AttributeTargets.All, allowMultiple: false, inherited: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(785, 2402, 2436);
            Null = default(AttributeUsageInfo); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(785, 442, 8877);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(785, 442, 8877);
        }

        static Microsoft.CodeAnalysis.AttributeUsageInfo
        f_785_2248_2345(System.AttributeTargets
        validTargets, bool
        allowMultiple, bool
        inherited)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeUsageInfo(validTargets: validTargets, allowMultiple: allowMultiple, inherited: inherited);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(785, 2248, 2345);
            return return_v;
        }

    }
}
