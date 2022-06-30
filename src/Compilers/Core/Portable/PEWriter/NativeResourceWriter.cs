// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal static class NativeResourceWriter
    {
        private class Directory
        {
            internal readonly string Name;

            internal readonly int ID;

            internal ushort NumberOfNamedEntries;

            internal ushort NumberOfIdEntries;

            internal readonly List<object> Entries;

            internal Directory(string name, int id)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(505, 5724, 5911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5512, 5516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5553, 5555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5586, 5606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5637, 5654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5700, 5707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5796, 5813);

                    this.Name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5831, 5844);

                    this.ID = id;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 5862, 5896);

                    this.Entries = f_505_5877_5895();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(505, 5724, 5911);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 5724, 5911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 5724, 5911);
                }
            }

            static Directory()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(505, 5439, 5922);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(505, 5439, 5922);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 5439, 5922);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(505, 5439, 5922);

            static System.Collections.Generic.List<object>
            f_505_5877_5895()
            {
                var return_v = new System.Collections.Generic.List<object>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 5877, 5895);
                return return_v;
            }

        }

        private static int CompareResources(IWin32Resource left, IWin32Resource right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(505, 5934, 6263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6037, 6135);

                int
                result = f_505_6050_6134(f_505_6077_6088(left), f_505_6090_6103(left), f_505_6105_6117(right), f_505_6119_6133(right))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6151, 6252);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(505, 6158, 6171) || (((result == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(505, 6174, 6242)) || DynAbs.Tracing.TraceSender.Conditional_F3(505, 6245, 6251))) ? f_505_6174_6242(f_505_6201_6208(left), f_505_6210_6219(left), f_505_6221_6229(right), f_505_6231_6241(right)) : result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(505, 5934, 6263);

                int
                f_505_6077_6088(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6077, 6088);
                    return return_v;
                }


                string
                f_505_6090_6103(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6090, 6103);
                    return return_v;
                }


                int
                f_505_6105_6117(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6105, 6117);
                    return return_v;
                }


                string
                f_505_6119_6133(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6119, 6133);
                    return return_v;
                }


                int
                f_505_6050_6134(int
                xOrdinal, string
                xString, int
                yOrdinal, string
                yString)
                {
                    var return_v = CompareResourceIdentifiers(xOrdinal, xString, yOrdinal, yString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 6050, 6134);
                    return return_v;
                }


                int
                f_505_6201_6208(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6201, 6208);
                    return return_v;
                }


                string
                f_505_6210_6219(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6210, 6219);
                    return return_v;
                }


                int
                f_505_6221_6229(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6221, 6229);
                    return return_v;
                }


                string
                f_505_6231_6241(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 6231, 6241);
                    return return_v;
                }


                int
                f_505_6174_6242(int
                xOrdinal, string
                xString, int
                yOrdinal, string
                yString)
                {
                    var return_v = CompareResourceIdentifiers(xOrdinal, xString, yOrdinal, yString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 6174, 6242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 5934, 6263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 5934, 6263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int CompareResourceIdentifiers(int xOrdinal, string xString, int yOrdinal, string yString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(505, 6469, 7115);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6599, 7104) || true) && (xString == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 6599, 7104);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6652, 6850) || true) && (yString == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 6652, 6850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6713, 6740);

                        return xOrdinal - yOrdinal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(505, 6652, 6850);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 6652, 6850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6822, 6831);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(505, 6652, 6850);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(505, 6599, 7104);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 6599, 7104);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6884, 7104) || true) && (yString == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 6884, 7104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 6937, 6947);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(505, 6884, 7104);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 6884, 7104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7013, 7089);

                        return f_505_7020_7088(xString, yString, StringComparison.OrdinalIgnoreCase);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(505, 6884, 7104);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(505, 6599, 7104);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(505, 6469, 7115);

                int
                f_505_7020_7088(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = String.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 7020, 7088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 6469, 7115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 6469, 7115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<IWin32Resource> SortResources(IEnumerable<IWin32Resource> resources)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(505, 7279, 7454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7400, 7443);

                return f_505_7407_7442(resources, CompareResources);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(505, 7279, 7454);

                System.Linq.IOrderedEnumerable<Microsoft.Cci.IWin32Resource>
                f_505_7407_7442(System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
                source, System.Comparison<Microsoft.Cci.IWin32Resource>
                compare)
                {
                    var return_v = source.OrderBy<Microsoft.Cci.IWin32Resource>(compare);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 7407, 7442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 7279, 7454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 7279, 7454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void SerializeWin32Resources(BlobBuilder builder, IEnumerable<IWin32Resource> theResources, int resourcesRva)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(505, 7466, 10480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7614, 7657);

                theResources = f_505_7629_7656(theResources);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7673, 7730);

                Directory
                typeDirectory = f_505_7699_7729(string.Empty, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7744, 7775);

                Directory
                nameDirectory = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7789, 7824);

                Directory
                languageDirectory = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7838, 7868);

                int
                lastTypeID = int.MinValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7882, 7909);

                string
                lastTypeName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7923, 7949);

                int
                lastID = int.MinValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 7963, 7986);

                string
                lastName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8000, 8030);

                uint
                sizeOfDirectoryTree = 16
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8177, 10075);
                    foreach (IWin32Resource r in f_505_8206_8218_I(theResources))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 8177, 10075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8252, 8343);

                        bool
                        typeDifferent = (f_505_8274_8282(r) < 0 && (DynAbs.Tracing.TraceSender.Expression_True(505, 8274, 8316) && f_505_8290_8300(r) != lastTypeName)) || (DynAbs.Tracing.TraceSender.Expression_False(505, 8273, 8342) || f_505_8321_8329(r) > lastTypeID)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8361, 9110) || true) && (typeDifferent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 8361, 9110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8420, 8442);

                            lastTypeID = f_505_8433_8441(r);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8464, 8490);

                            lastTypeName = f_505_8479_8489(r);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8512, 8936) || true) && (lastTypeID < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 8512, 8936);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8580, 8718);

                                f_505_8580_8717(typeDirectory.NumberOfIdEntries == 0, "Not all Win32 resources with types encoded as strings precede those encoded as ints");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8744, 8781);

                                typeDirectory.NumberOfNamedEntries++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 8512, 8936);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 8512, 8936);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8879, 8913);

                                typeDirectory.NumberOfIdEntries++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 8512, 8936);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 8960, 8986);

                            sizeOfDirectoryTree += 24;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9008, 9091);

                            f_505_9008_9090(typeDirectory.Entries, nameDirectory = f_505_9050_9089(lastTypeName, lastTypeID));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 8361, 9110);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9130, 9908) || true) && (typeDifferent || (DynAbs.Tracing.TraceSender.Expression_False(505, 9134, 9183) || (f_505_9152_9156(r) < 0 && (DynAbs.Tracing.TraceSender.Expression_True(505, 9152, 9182) && f_505_9164_9170(r) != lastName))) || (DynAbs.Tracing.TraceSender.Expression_False(505, 9134, 9200) || f_505_9187_9191(r) > lastID))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 9130, 9908);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9242, 9256);

                            lastID = f_505_9251_9255(r);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9278, 9296);

                            lastName = f_505_9289_9295(r);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9318, 9738) || true) && (lastID < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 9318, 9738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9382, 9520);

                                f_505_9382_9519(nameDirectory.NumberOfIdEntries == 0, "Not all Win32 resources with names encoded as strings precede those encoded as ints");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9546, 9583);

                                nameDirectory.NumberOfNamedEntries++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 9318, 9738);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 9318, 9738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9681, 9715);

                                nameDirectory.NumberOfIdEntries++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 9318, 9738);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9762, 9788);

                            sizeOfDirectoryTree += 24;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9810, 9889);

                            f_505_9810_9888(nameDirectory.Entries, languageDirectory = f_505_9856_9887(lastName, lastID));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 9130, 9908);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9928, 9966);

                        languageDirectory.NumberOfIdEntries++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 9984, 10009);

                        sizeOfDirectoryTree += 8;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10027, 10060);

                        f_505_10027_10059(languageDirectory.Entries, r);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(505, 8177, 10075);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(505, 1, 1899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(505, 1, 1899);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10091, 10126);

                var
                dataWriter = f_505_10108_10125()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10266, 10358);

                f_505_10266_10357(typeDirectory, builder, 0, 0, sizeOfDirectoryTree, resourcesRva, dataWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10372, 10403);

                f_505_10372_10402(builder, dataWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10417, 10438);

                f_505_10417_10437(builder, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10452, 10469);

                f_505_10452_10468(builder, 4);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(505, 7466, 10480);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
                f_505_7629_7656(System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
                resources)
                {
                    var return_v = SortResources(resources);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 7629, 7656);
                    return return_v;
                }


                Microsoft.Cci.NativeResourceWriter.Directory
                f_505_7699_7729(string
                name, int
                id)
                {
                    var return_v = new Microsoft.Cci.NativeResourceWriter.Directory(name, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 7699, 7729);
                    return return_v;
                }


                int
                f_505_8274_8282(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 8274, 8282);
                    return return_v;
                }


                string
                f_505_8290_8300(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 8290, 8300);
                    return return_v;
                }


                int
                f_505_8321_8329(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 8321, 8329);
                    return return_v;
                }


                int
                f_505_8433_8441(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 8433, 8441);
                    return return_v;
                }


                string
                f_505_8479_8489(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 8479, 8489);
                    return return_v;
                }


                int
                f_505_8580_8717(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 8580, 8717);
                    return 0;
                }


                Microsoft.Cci.NativeResourceWriter.Directory
                f_505_9050_9089(string
                name, int
                id)
                {
                    var return_v = new Microsoft.Cci.NativeResourceWriter.Directory(name, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 9050, 9089);
                    return return_v;
                }


                int
                f_505_9008_9090(System.Collections.Generic.List<object>
                this_param, Microsoft.Cci.NativeResourceWriter.Directory
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 9008, 9090);
                    return 0;
                }


                int
                f_505_9152_9156(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 9152, 9156);
                    return return_v;
                }


                string
                f_505_9164_9170(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 9164, 9170);
                    return return_v;
                }


                int
                f_505_9187_9191(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 9187, 9191);
                    return return_v;
                }


                int
                f_505_9251_9255(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 9251, 9255);
                    return return_v;
                }


                string
                f_505_9289_9295(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 9289, 9295);
                    return return_v;
                }


                int
                f_505_9382_9519(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 9382, 9519);
                    return 0;
                }


                Microsoft.Cci.NativeResourceWriter.Directory
                f_505_9856_9887(string
                name, int
                id)
                {
                    var return_v = new Microsoft.Cci.NativeResourceWriter.Directory(name, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 9856, 9887);
                    return return_v;
                }


                int
                f_505_9810_9888(System.Collections.Generic.List<object>
                this_param, Microsoft.Cci.NativeResourceWriter.Directory
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 9810, 9888);
                    return 0;
                }


                int
                f_505_10027_10059(System.Collections.Generic.List<object>
                this_param, Microsoft.Cci.IWin32Resource
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10027, 10059);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
                f_505_8206_8218_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 8206, 8218);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_505_10108_10125()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10108, 10125);
                    return return_v;
                }


                int
                f_505_10266_10357(Microsoft.Cci.NativeResourceWriter.Directory
                directory, System.Reflection.Metadata.BlobBuilder
                writer, int
                offset, int
                level, uint
                sizeOfDirectoryTree, int
                virtualAddressBase, System.Reflection.Metadata.BlobBuilder
                dataWriter)
                {
                    WriteDirectory(directory, writer, (uint)offset, (uint)level, sizeOfDirectoryTree, virtualAddressBase, dataWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10266, 10357);
                    return 0;
                }


                int
                f_505_10372_10402(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                suffix)
                {
                    this_param.LinkSuffix(suffix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10372, 10402);
                    return 0;
                }


                int
                f_505_10417_10437(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10417, 10437);
                    return 0;
                }


                int
                f_505_10452_10468(System.Reflection.Metadata.BlobBuilder
                this_param, int
                alignment)
                {
                    this_param.Align(alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10452, 10468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 7466, 10480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 7466, 10480);
            }
        }

        private static void WriteDirectory(Directory directory, BlobBuilder writer, uint offset, uint level, uint sizeOfDirectoryTree, int virtualAddressBase, BlobBuilder dataWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(505, 10492, 14637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10691, 10713);

                f_505_10691_10712(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10746, 10768);

                f_505_10746_10767(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10795, 10817);

                f_505_10795_10816(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10842, 10893);

                f_505_10842_10892(writer, directory.NumberOfNamedEntries);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10907, 10955);

                f_505_10907_10954(writer, directory.NumberOfIdEntries);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 10969, 11008);

                uint
                n = (uint)f_505_10984_11007(directory.Entries)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11022, 11051);

                uint
                k = offset + 16 + n * 8
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11074, 11079);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11065, 13972) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11088, 11091)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(505, 11065, 13972))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 11065, 13972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11125, 11132);

                        int
                        id
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11150, 11162);

                        string
                        name
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11180, 11243);

                        uint
                        nameOffset = (uint)f_505_11204_11220(dataWriter) + sizeOfDirectoryTree
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11261, 11286);

                        uint
                        directoryOffset = k
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11304, 11357);

                        Directory
                        subDir = f_505_11323_11343(directory.Entries, i) as Directory
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11375, 13207) || true) && (subDir != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 11375, 13207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11435, 11450);

                            id = subDir.ID;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11472, 11491);

                            name = subDir.Name;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11513, 11768) || true) && (level == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 11513, 11768);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11577, 11606);

                                k += f_505_11582_11605(subDir);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 11513, 11768);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 11513, 11768);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 11704, 11745);

                                k += 16 + 8 * (uint)f_505_11724_11744(subDir.Entries);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 11513, 11768);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 11375, 13207);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 11375, 13207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12401, 12457);

                            IWin32Resource
                            r = (IWin32Resource)f_505_12436_12456(directory.Entries, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12479, 12546);

                            id = (DynAbs.Tracing.TraceSender.Conditional_F1(505, 12484, 12494) || ((level == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(505, 12497, 12505)) || DynAbs.Tracing.TraceSender.Conditional_F3(505, 12508, 12545))) ? f_505_12497_12505(r) : (DynAbs.Tracing.TraceSender.Conditional_F1(505, 12508, 12518) || ((level == 1 && DynAbs.Tracing.TraceSender.Conditional_F2(505, 12521, 12525)) || DynAbs.Tracing.TraceSender.Conditional_F3(505, 12528, 12545))) ? f_505_12521_12525(r) : (int)f_505_12533_12545(r);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12568, 12628);

                            name = (DynAbs.Tracing.TraceSender.Conditional_F1(505, 12575, 12585) || ((level == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(505, 12588, 12598)) || DynAbs.Tracing.TraceSender.Conditional_F3(505, 12601, 12627))) ? f_505_12588_12598(r) : (DynAbs.Tracing.TraceSender.Conditional_F1(505, 12601, 12611) || ((level == 1 && DynAbs.Tracing.TraceSender.Conditional_F2(505, 12614, 12620)) || DynAbs.Tracing.TraceSender.Conditional_F3(505, 12623, 12627))) ? f_505_12614_12620(r) : null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12650, 12747);

                            f_505_12650_12746(dataWriter, (virtualAddressBase + sizeOfDirectoryTree + 16 + f_505_12728_12744(dataWriter)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12769, 12816);

                            byte[]
                            data = f_505_12783_12815(f_505_12783_12805(f_505_12798_12804(r)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12838, 12880);

                            f_505_12838_12879(dataWriter, f_505_12867_12878(data));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12902, 12937);

                            f_505_12902_12936(dataWriter, f_505_12925_12935(r));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 12959, 12985);

                            f_505_12959_12984(dataWriter, 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13007, 13035);

                            f_505_13007_13034(dataWriter, data);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13057, 13188) || true) && ((f_505_13065_13081(dataWriter) % 4) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 13057, 13188);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13141, 13165);

                                    f_505_13141_13164(dataWriter, 0);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(505, 13057, 13188);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(505, 13057, 13188);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(505, 13057, 13188);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 11375, 13207);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13227, 13696) || true) && (id >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 13227, 13696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13280, 13302);

                            f_505_13280_13301(writer, id);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 13227, 13696);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 13227, 13696);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13384, 13493) || true) && (name == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 13384, 13493);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13450, 13470);

                                name = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 13384, 13493);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13517, 13561);

                            f_505_13517_13560(
                                                writer, nameOffset | 0x80000000);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13583, 13627);

                            f_505_13583_13626(dataWriter, f_505_13614_13625(name));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13649, 13677);

                            f_505_13649_13676(dataWriter, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 13227, 13696);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13716, 13957) || true) && (subDir != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 13716, 13957);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13776, 13825);

                            f_505_13776_13824(writer, directoryOffset | 0x80000000);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 13716, 13957);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 13716, 13957);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13907, 13938);

                            f_505_13907_13937(writer, nameOffset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 13716, 13957);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(505, 1, 2908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(505, 1, 2908);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 13988, 14012);

                k = offset + 16 + n * 8;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14035, 14040);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14026, 14626) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14049, 14052)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(505, 14026, 14626))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 14026, 14626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14086, 14139);

                        Directory
                        subDir = f_505_14105_14125(directory.Entries, i) as Directory
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14157, 14611) || true) && (subDir != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 14157, 14611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14217, 14315);

                            f_505_14217_14314(subDir, writer, k, level + 1, sizeOfDirectoryTree, virtualAddressBase, dataWriter);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14337, 14592) || true) && (level == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 14337, 14592);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14401, 14430);

                                k += f_505_14406_14429(subDir);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 14337, 14592);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 14337, 14592);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14528, 14569);

                                k += 16 + 8 * (uint)f_505_14548_14568(subDir.Entries);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(505, 14337, 14592);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 14157, 14611);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(505, 1, 601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(505, 1, 601);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(505, 10492, 14637);

                int
                f_505_10691_10712(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10691, 10712);
                    return 0;
                }


                int
                f_505_10746_10767(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10746, 10767);
                    return 0;
                }


                int
                f_505_10795_10816(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10795, 10816);
                    return 0;
                }


                int
                f_505_10842_10892(System.Reflection.Metadata.BlobBuilder
                this_param, ushort
                value)
                {
                    this_param.WriteUInt16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10842, 10892);
                    return 0;
                }


                int
                f_505_10907_10954(System.Reflection.Metadata.BlobBuilder
                this_param, ushort
                value)
                {
                    this_param.WriteUInt16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 10907, 10954);
                    return 0;
                }


                int
                f_505_10984_11007(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 10984, 11007);
                    return return_v;
                }


                int
                f_505_11204_11220(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 11204, 11220);
                    return return_v;
                }


                object
                f_505_11323_11343(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 11323, 11343);
                    return return_v;
                }


                uint
                f_505_11582_11605(Microsoft.Cci.NativeResourceWriter.Directory
                directory)
                {
                    var return_v = SizeOfDirectory(directory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 11582, 11605);
                    return return_v;
                }


                int
                f_505_11724_11744(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 11724, 11744);
                    return return_v;
                }


                object
                f_505_12436_12456(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12436, 12456);
                    return return_v;
                }


                int
                f_505_12497_12505(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12497, 12505);
                    return return_v;
                }


                int
                f_505_12521_12525(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12521, 12525);
                    return return_v;
                }


                uint
                f_505_12533_12545(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.LanguageId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12533, 12545);
                    return return_v;
                }


                string
                f_505_12588_12598(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12588, 12598);
                    return return_v;
                }


                string
                f_505_12614_12620(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12614, 12620);
                    return return_v;
                }


                int
                f_505_12728_12744(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12728, 12744);
                    return return_v;
                }


                int
                f_505_12650_12746(System.Reflection.Metadata.BlobBuilder
                this_param, long
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 12650, 12746);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<byte>
                f_505_12798_12804(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12798, 12804);
                    return return_v;
                }


                System.Collections.Generic.List<byte>
                f_505_12783_12805(System.Collections.Generic.IEnumerable<byte>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<byte>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 12783, 12805);
                    return return_v;
                }


                byte[]
                f_505_12783_12815(System.Collections.Generic.List<byte>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 12783, 12815);
                    return return_v;
                }


                int
                f_505_12867_12878(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12867, 12878);
                    return return_v;
                }


                int
                f_505_12838_12879(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 12838, 12879);
                    return 0;
                }


                uint
                f_505_12925_12935(Microsoft.Cci.IWin32Resource
                this_param)
                {
                    var return_v = this_param.CodePage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 12925, 12935);
                    return return_v;
                }


                int
                f_505_12902_12936(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 12902, 12936);
                    return 0;
                }


                int
                f_505_12959_12984(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 12959, 12984);
                    return 0;
                }


                int
                f_505_13007_13034(System.Reflection.Metadata.BlobBuilder
                this_param, byte[]
                buffer)
                {
                    this_param.WriteBytes(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13007, 13034);
                    return 0;
                }


                int
                f_505_13065_13081(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 13065, 13081);
                    return return_v;
                }


                int
                f_505_13141_13164(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13141, 13164);
                    return 0;
                }


                int
                f_505_13280_13301(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13280, 13301);
                    return 0;
                }


                int
                f_505_13517_13560(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13517, 13560);
                    return 0;
                }


                int
                f_505_13614_13625(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 13614, 13625);
                    return return_v;
                }


                int
                f_505_13583_13626(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt16((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13583, 13626);
                    return 0;
                }


                int
                f_505_13649_13676(System.Reflection.Metadata.BlobBuilder
                this_param, string
                value)
                {
                    this_param.WriteUTF16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13649, 13676);
                    return 0;
                }


                int
                f_505_13776_13824(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13776, 13824);
                    return 0;
                }


                int
                f_505_13907_13937(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 13907, 13937);
                    return 0;
                }


                object
                f_505_14105_14125(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 14105, 14125);
                    return return_v;
                }


                int
                f_505_14217_14314(Microsoft.Cci.NativeResourceWriter.Directory
                directory, System.Reflection.Metadata.BlobBuilder
                writer, uint
                offset, uint
                level, uint
                sizeOfDirectoryTree, int
                virtualAddressBase, System.Reflection.Metadata.BlobBuilder
                dataWriter)
                {
                    WriteDirectory(directory, writer, offset, level, sizeOfDirectoryTree, virtualAddressBase, dataWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 14217, 14314);
                    return 0;
                }


                uint
                f_505_14406_14429(Microsoft.Cci.NativeResourceWriter.Directory
                directory)
                {
                    var return_v = SizeOfDirectory(directory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 14406, 14429);
                    return return_v;
                }


                int
                f_505_14548_14568(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 14548, 14568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 10492, 14637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 10492, 14637);
            }
        }

        private static uint SizeOfDirectory(Directory/*!*/ directory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(505, 14649, 15133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14735, 14774);

                uint
                n = (uint)f_505_14750_14773(directory.Entries)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14788, 14811);

                uint
                size = 16 + 8 * n
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14834, 14839);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14825, 15094) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14848, 14851)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(505, 14825, 15094))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 14825, 15094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14885, 14938);

                        Directory
                        subDir = f_505_14904_14924(directory.Entries, i) as Directory
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 14956, 15079) || true) && (subDir != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 14956, 15079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15016, 15060);

                            size += 16 + 8 * (uint)f_505_15039_15059(subDir.Entries);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(505, 14956, 15079);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(505, 1, 270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(505, 1, 270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15110, 15122);

                return size;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(505, 14649, 15133);

                int
                f_505_14750_14773(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 14750, 14773);
                    return return_v;
                }


                object
                f_505_14904_14924(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 14904, 14924);
                    return return_v;
                }


                int
                f_505_15039_15059(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 15039, 15059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 14649, 15133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 14649, 15133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void SerializeWin32Resources(BlobBuilder builder, ResourceSection resourceSections, int resourcesRva)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(505, 15145, 15908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15285, 15380);

                var
                sectionWriter = f_505_15305_15379(f_505_15320_15378(builder, f_505_15341_15377(resourceSections.SectionBytes)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15394, 15450);

                sectionWriter.WriteBytes(resourceSections.SectionBytes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15466, 15531);

                var
                readStream = f_505_15483_15530(resourceSections.SectionBytes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15545, 15587);

                var
                reader = f_505_15558_15586(readStream)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15603, 15897);
                    foreach (int addressToFixup in f_505_15634_15662_I(resourceSections.Relocations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(505, 15603, 15897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15696, 15734);

                        sectionWriter.Offset = addressToFixup;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15752, 15796);

                        f_505_15752_15769(reader).Position = addressToFixup;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(505, 15814, 15882);

                        sectionWriter.WriteUInt32(f_505_15840_15859(reader) + (uint)resourcesRva);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(505, 15603, 15897);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(505, 1, 295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(505, 1, 295);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(505, 15145, 15908);

                int
                f_505_15341_15377(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 15341, 15377);
                    return return_v;
                }


                System.Reflection.Metadata.Blob
                f_505_15320_15378(System.Reflection.Metadata.BlobBuilder
                this_param, int
                byteCount)
                {
                    var return_v = this_param.ReserveBytes(byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 15320, 15378);
                    return return_v;
                }


                System.Reflection.Metadata.BlobWriter
                f_505_15305_15379(System.Reflection.Metadata.Blob
                blob)
                {
                    var return_v = new System.Reflection.Metadata.BlobWriter(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 15305, 15379);
                    return return_v;
                }


                System.IO.MemoryStream
                f_505_15483_15530(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 15483, 15530);
                    return return_v;
                }


                System.IO.BinaryReader
                f_505_15558_15586(System.IO.MemoryStream
                input)
                {
                    var return_v = new System.IO.BinaryReader((System.IO.Stream)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 15558, 15586);
                    return return_v;
                }


                System.IO.Stream
                f_505_15752_15769(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(505, 15752, 15769);
                    return return_v;
                }


                uint
                f_505_15840_15859(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 15840, 15859);
                    return return_v;
                }


                uint[]
                f_505_15634_15662_I(uint[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(505, 15634, 15662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(505, 15145, 15908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 15145, 15908);
            }
        }

        static NativeResourceWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(505, 418, 15915);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(505, 418, 15915);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(505, 418, 15915);
        }

    }
}
