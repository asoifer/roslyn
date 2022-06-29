// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using System.Linq;
using System.Resources;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed class LocalizableResourceString : LocalizableString, IObjectWritable
    {
        private readonly string _nameOfLocalizableResource;

        private readonly ResourceManager _resourceManager;

        private readonly Type _resourceSource;

        private readonly string[] _formatArguments;

        static LocalizableResourceString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(191, 876, 1062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 935, 1051);

                f_191_935_1050(typeof(LocalizableResourceString), reader => new LocalizableResourceString(reader));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(191, 876, 1062);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 876, 1062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 876, 1062);
            }
        }

        public LocalizableResourceString(string nameOfLocalizableResource, ResourceManager resourceManager, Type resourceSource)
        : this(f_191_1759_1784_C(nameOfLocalizableResource), resourceManager, resourceSource, f_191_1819_1840())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(191, 1618, 1863);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(191, 1618, 1863);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 1618, 1863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 1618, 1863);
            }
        }

        public LocalizableResourceString(string nameOfLocalizableResource, ResourceManager resourceManager, Type resourceSource, params string[] formatArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(191, 2572, 3575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 676, 702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 746, 762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 795, 810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 847, 863);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 2750, 2903) || true) && (nameOfLocalizableResource == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 2750, 2903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 2821, 2888);

                    throw f_191_2827_2887(nameof(nameOfLocalizableResource));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(191, 2750, 2903);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 2919, 3052) || true) && (resourceManager == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 2919, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 2980, 3037);

                    throw f_191_2986_3036(nameof(resourceManager));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(191, 2919, 3052);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3068, 3199) || true) && (resourceSource == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 3068, 3199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3128, 3184);

                    throw f_191_3134_3183(nameof(resourceSource));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(191, 3068, 3199);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3215, 3348) || true) && (formatArguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 3215, 3348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3276, 3333);

                    throw f_191_3282_3332(nameof(formatArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(191, 3215, 3348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3364, 3399);

                _resourceManager = resourceManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3413, 3468);

                _nameOfLocalizableResource = nameOfLocalizableResource;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3482, 3515);

                _resourceSource = resourceSource;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3529, 3564);

                _formatArguments = formatArguments;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(191, 2572, 3575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 2572, 3575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 2572, 3575);
            }
        }

        private LocalizableResourceString(ObjectReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(191, 3587, 4368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 676, 702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 746, 762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 795, 810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 847, 863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3666, 3702);

                _resourceSource = f_191_3684_3701(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3716, 3765);

                _nameOfLocalizableResource = f_191_3745_3764(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3779, 3835);

                _resourceManager = f_191_3798_3834(_resourceSource);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3851, 3883);

                var
                length = f_191_3864_3882(reader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3897, 4357) || true) && (length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 3897, 4357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 3946, 3987);

                    _formatArguments = f_191_3965_3986();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(191, 3897, 4357);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 3897, 4357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4053, 4117);

                    var
                    argumentsBuilder = f_191_4076_4116(length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4144, 4149);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4135, 4269) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4163, 4166)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(191, 4135, 4269))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 4135, 4269);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4208, 4250);

                            f_191_4208_4249(argumentsBuilder, f_191_4229_4248(reader));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(191, 1, 135);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(191, 1, 135);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4289, 4342);

                    _formatArguments = f_191_4308_4341(argumentsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(191, 3897, 4357);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(191, 3587, 4368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 3587, 4368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 3587, 4368);
            }
        }

        bool IObjectWritable.ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(191, 4428, 4436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4431, 4436);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(191, 4428, 4436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 4428, 4436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 4428, 4436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void IObjectWritable.WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(191, 4449, 4854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4523, 4557);

                f_191_4523_4556(writer, _resourceSource);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4571, 4618);

                f_191_4571_4617(writer, _nameOfLocalizableResource);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4632, 4669);

                var
                length = f_191_4645_4668(_formatArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4683, 4709);

                f_191_4683_4708(writer, length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4732, 4737);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4723, 4843) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4751, 4754)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(191, 4723, 4843))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(191, 4723, 4843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4788, 4828);

                        f_191_4788_4827(writer, _formatArguments[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(191, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(191, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(191, 4449, 4854);

                int
                f_191_4523_4556(Roslyn.Utilities.ObjectWriter
                this_param, System.Type
                type)
                {
                    this_param.WriteType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4523, 4556);
                    return 0;
                }


                int
                f_191_4571_4617(Roslyn.Utilities.ObjectWriter
                this_param, string
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4571, 4617);
                    return 0;
                }


                int
                f_191_4645_4668(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(191, 4645, 4668);
                    return return_v;
                }


                int
                f_191_4683_4708(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4683, 4708);
                    return 0;
                }


                int
                f_191_4788_4827(Roslyn.Utilities.ObjectWriter
                this_param, string
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4788, 4827);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 4449, 4854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 4449, 4854);
            }
        }

        protected override string GetText(IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(191, 4866, 5335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 4957, 5033);

                var
                culture = formatProvider as CultureInfo ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Globalization.CultureInfo?>(191, 4971, 5032) ?? f_191_5004_5032())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 5047, 5132);

                var
                resourceString = f_191_5068_5131(_resourceManager, _nameOfLocalizableResource, culture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 5146, 5324);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(191, 5153, 5175) || ((resourceString != null && DynAbs.Tracing.TraceSender.Conditional_F2(191, 5195, 5291)) || DynAbs.Tracing.TraceSender.Conditional_F3(191, 5311, 5323))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(191, 5196, 5223) || ((f_191_5196_5219(_formatArguments) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(191, 5226, 5273)) || DynAbs.Tracing.TraceSender.Conditional_F3(191, 5276, 5290))) ? f_191_5226_5273(resourceString, _formatArguments) : resourceString) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(191, 4866, 5335);

                System.Globalization.CultureInfo
                f_191_5004_5032()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(191, 5004, 5032);
                    return return_v;
                }


                string?
                f_191_5068_5131(System.Resources.ResourceManager
                this_param, string
                name, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.GetString(name, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 5068, 5131);
                    return return_v;
                }


                int
                f_191_5196_5219(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(191, 5196, 5219);
                    return return_v;
                }


                string
                f_191_5226_5273(string
                format, params string[]
                args)
                {
                    var return_v = string.Format(format, (object?[])args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 5226, 5273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 4866, 5335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 4866, 5335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool AreEqual(object? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(191, 5347, 5896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 5419, 5480);

                var
                otherResourceString = other as LocalizableResourceString
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 5494, 5885);

                return otherResourceString != null && (DynAbs.Tracing.TraceSender.Expression_True(191, 5501, 5625) && _nameOfLocalizableResource == otherResourceString._nameOfLocalizableResource) && (DynAbs.Tracing.TraceSender.Expression_True(191, 5501, 5702) && _resourceManager == otherResourceString._resourceManager) && (DynAbs.Tracing.TraceSender.Expression_True(191, 5501, 5777) && _resourceSource == otherResourceString._resourceSource) && (DynAbs.Tracing.TraceSender.Expression_True(191, 5501, 5884) && f_191_5798_5884(_formatArguments, otherResourceString._formatArguments, (a, b) => a == b));
                DynAbs.Tracing.TraceSender.TraceExitMethod(191, 5347, 5896);

                bool
                f_191_5798_5884(string[]
                first, string[]
                second, System.Func<string, string, bool>
                comparer)
                {
                    var return_v = first.SequenceEqual<string>((System.Collections.Generic.IEnumerable<string>)second, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 5798, 5884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 5347, 5896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 5347, 5896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetHash()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(191, 5908, 6218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(191, 5965, 6207);

                return f_191_5972_6206(f_191_5985_6025(_nameOfLocalizableResource), f_191_6044_6205(f_191_6057_6087(_resourceManager), f_191_6106_6204(f_191_6119_6148(_resourceSource), f_191_6167_6203(_formatArguments))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(191, 5908, 6218);

                int
                f_191_5985_6025(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 5985, 6025);
                    return return_v;
                }


                int
                f_191_6057_6087(System.Resources.ResourceManager
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 6057, 6087);
                    return return_v;
                }


                int
                f_191_6119_6148(System.Type
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 6119, 6148);
                    return return_v;
                }


                int
                f_191_6167_6203(string[]
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 6167, 6203);
                    return return_v;
                }


                int
                f_191_6106_6204(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 6106, 6204);
                    return return_v;
                }


                int
                f_191_6044_6205(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 6044, 6205);
                    return return_v;
                }


                int
                f_191_5972_6206(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 5972, 6206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(191, 5908, 6218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(191, 5908, 6218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(191, 553, 6225);

        static int
        f_191_935_1050(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 935, 1050);
            return 0;
        }


        static string[]
        f_191_1819_1840()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 1819, 1840);
            return return_v;
        }


        static string
        f_191_1759_1784_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(191, 1618, 1863);
            return return_v;
        }


        static System.ArgumentNullException
        f_191_2827_2887(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 2827, 2887);
            return return_v;
        }


        static System.ArgumentNullException
        f_191_2986_3036(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 2986, 3036);
            return return_v;
        }


        static System.ArgumentNullException
        f_191_3134_3183(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 3134, 3183);
            return return_v;
        }


        static System.ArgumentNullException
        f_191_3282_3332(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 3282, 3332);
            return return_v;
        }


        static System.Type
        f_191_3684_3701(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 3684, 3701);
            return return_v;
        }


        static string
        f_191_3745_3764(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 3745, 3764);
            return return_v;
        }


        static System.Resources.ResourceManager
        f_191_3798_3834(System.Type
        resourceSource)
        {
            var return_v = new System.Resources.ResourceManager(resourceSource);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 3798, 3834);
            return return_v;
        }


        static int
        f_191_3864_3882(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 3864, 3882);
            return return_v;
        }


        static string[]
        f_191_3965_3986()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 3965, 3986);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
        f_191_4076_4116(int
        capacity)
        {
            var return_v = ArrayBuilder<string>.GetInstance(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4076, 4116);
            return return_v;
        }


        static string
        f_191_4229_4248(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4229, 4248);
            return return_v;
        }


        static int
        f_191_4208_4249(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4208, 4249);
            return 0;
        }


        static string[]
        f_191_4308_4341(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
        this_param)
        {
            var return_v = this_param.ToArrayAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(191, 4308, 4341);
            return return_v;
        }

    }
}
