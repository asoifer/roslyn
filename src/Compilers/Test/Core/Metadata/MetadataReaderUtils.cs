// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using System.IO;
using System.IO.Compression;

namespace Roslyn.Test.Utilities
{
    internal static class MetadataReaderUtils
    {
        internal static IEnumerable<ConstantHandle> GetConstants(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 811, 1103);

                var listYield = new List<ConstantHandle>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 929, 934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 936, 984);
                    for (int
        i = 1
        ,
        n = f_25019_940_984(reader, TableIndex.Constant)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 920, 1092) || true) && (i <= n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 994, 997)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 920, 1092))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 920, 1092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1031, 1077);

                        listYield.Add(f_25019_1044_1076(i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 173);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 811, 1103);

                return listYield;

                int
                f_25019_940_984(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.Ecma335.TableIndex
                tableIndex)
                {
                    var return_v = reader.GetTableRowCount(tableIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 940, 984);
                    return return_v;
                }


                System.Reflection.Metadata.ConstantHandle
                f_25019_1044_1076(int
                rowNumber)
                {
                    var return_v = MetadataTokens.ConstantHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 1044, 1076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 811, 1103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 811, 1103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<ParameterHandle> GetParameters(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 1115, 1407);

                var listYield = new List<ParameterHandle>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1235, 1240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1242, 1287);
                    for (int
        i = 1
        ,
        n = f_25019_1246_1287(reader, TableIndex.Param)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1226, 1396) || true) && (i <= n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1297, 1300)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 1226, 1396))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 1226, 1396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1334, 1381);

                        listYield.Add(f_25019_1347_1380(i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 1115, 1407);

                return listYield;

                int
                f_25019_1246_1287(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.Ecma335.TableIndex
                tableIndex)
                {
                    var return_v = reader.GetTableRowCount(tableIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 1246, 1287);
                    return return_v;
                }


                System.Reflection.Metadata.ParameterHandle
                f_25019_1347_1380(int
                rowNumber)
                {
                    var return_v = MetadataTokens.ParameterHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 1347, 1380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 1115, 1407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 1115, 1407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<GenericParameterHandle> GetGenericParameters(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 1419, 1739);

                var listYield = new List<GenericParameterHandle>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1553, 1558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1560, 1612);
                    for (int
        i = 1
        ,
        n = f_25019_1564_1612(reader, TableIndex.GenericParam)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1544, 1728) || true) && (i <= n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1622, 1625)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 1544, 1728))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 1544, 1728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1659, 1713);

                        listYield.Add(f_25019_1672_1712(i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 185);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 1419, 1739);

                return listYield;

                int
                f_25019_1564_1612(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.Ecma335.TableIndex
                tableIndex)
                {
                    var return_v = reader.GetTableRowCount(tableIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 1564, 1612);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterHandle
                f_25019_1672_1712(int
                rowNumber)
                {
                    var return_v = MetadataTokens.GenericParameterHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 1672, 1712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 1419, 1739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 1419, 1739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<GenericParameterConstraintHandle> GetGenericParameterConstraints(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 1751, 2111);

                var listYield = new List<GenericParameterConstraintHandle>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1905, 1910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1912, 1974);
                    for (int
        i = 1
        ,
        n = f_25019_1916_1974(reader, TableIndex.GenericParamConstraint)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1896, 2100) || true) && (i <= n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 1984, 1987)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 1896, 2100))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 1896, 2100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2021, 2085);

                        listYield.Add(f_25019_2034_2084(i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 1751, 2111);

                return listYield;

                int
                f_25019_1916_1974(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.Ecma335.TableIndex
                tableIndex)
                {
                    var return_v = reader.GetTableRowCount(tableIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 1916, 1974);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterConstraintHandle
                f_25019_2034_2084(int
                rowNumber)
                {
                    var return_v = MetadataTokens.GenericParameterConstraintHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 2034, 2084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 1751, 2111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 1751, 2111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<ModuleReferenceHandle> GetModuleReferences(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 2123, 2437);

                var listYield = new List<ModuleReferenceHandle>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2255, 2260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2262, 2311);
                    for (int
        i = 1
        ,
        n = f_25019_2266_2311(reader, TableIndex.ModuleRef)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2246, 2426) || true) && (i <= n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2321, 2324)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 2246, 2426))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 2246, 2426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2358, 2411);

                        listYield.Add(f_25019_2371_2410(i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 181);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 2123, 2437);

                return listYield;

                int
                f_25019_2266_2311(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.Ecma335.TableIndex
                tableIndex)
                {
                    var return_v = reader.GetTableRowCount(tableIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 2266, 2311);
                    return return_v;
                }


                System.Reflection.Metadata.ModuleReferenceHandle
                f_25019_2371_2410(int
                rowNumber)
                {
                    var return_v = MetadataTokens.ModuleReferenceHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 2371, 2410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 2123, 2437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 2123, 2437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<MethodDefinition> GetImportedMethods(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 2449, 2823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2566, 2812);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from handle in reader.MethodDefinitions
                                                                               let method = reader.GetMethodDefinition(handle)
                                                                               let import = method.GetImport()
                                                                               where !import.Name.IsNil
                                                                               select method, 25019, 2573, 2811);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 2449, 2823);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 2449, 2823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 2449, 2823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool RequiresAmdInstructionSet(this PEHeaders headers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 2835, 2992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 2930, 2981);

                return f_25019_2937_2963(f_25019_2937_2955(headers)) == Machine.Amd64;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 2835, 2992);

                System.Reflection.PortableExecutable.CoffHeader
                f_25019_2937_2955(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 2937, 2955);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Machine
                f_25019_2937_2963(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 2937, 2963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 2835, 2992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 2835, 2992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Requires64Bits(this PEHeaders headers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 3004, 3304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3088, 3293);

                return f_25019_3095_3111(headers) != null && (DynAbs.Tracing.TraceSender.Expression_True(25019, 3095, 3165) && f_25019_3123_3145(f_25019_3123_3139(headers)) == PEMagic.PE32Plus
                ) || (DynAbs.Tracing.TraceSender.Expression_False(25019, 3095, 3229) || f_25019_3186_3212(f_25019_3186_3204(headers)) == Machine.Amd64
                ) || (DynAbs.Tracing.TraceSender.Expression_False(25019, 3095, 3292) || f_25019_3250_3276(f_25019_3250_3268(headers)) == Machine.IA64);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 3004, 3304);

                System.Reflection.PortableExecutable.PEHeader?
                f_25019_3095_3111(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 3095, 3111);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeader
                f_25019_3123_3139(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 3123, 3139);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEMagic
                f_25019_3123_3145(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.Magic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 3123, 3145);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_25019_3186_3204(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 3186, 3204);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Machine
                f_25019_3186_3212(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 3186, 3212);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_25019_3250_3268(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 3250, 3268);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Machine
                f_25019_3250_3276(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 3250, 3276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 3004, 3304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 3004, 3304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetString(this IEnumerable<MetadataReader> readers, StringHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 3316, 3854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3434, 3483);

                int
                index = f_25019_3446_3482(handle)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3497, 3817);
                    foreach (var reader in f_25019_3520_3527_I(readers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 3497, 3817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3561, 3611);

                        int
                        length = f_25019_3574_3610(reader, HeapIndex.String)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3629, 3768) || true) && (index < length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 3629, 3768);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3689, 3749);

                            return f_25019_3696_3748(reader, f_25019_3713_3747(index));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 3629, 3768);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3786, 3802);

                        index -= length;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 3497, 3817);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 3831, 3843);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 3316, 3854);

                int
                f_25019_3446_3482(System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 3446, 3482);
                    return return_v;
                }


                int
                f_25019_3574_3610(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.Ecma335.HeapIndex
                heapIndex)
                {
                    var return_v = reader.GetHeapSize(heapIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 3574, 3610);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle
                f_25019_3713_3747(int
                offset)
                {
                    var return_v = MetadataTokens.StringHandle(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 3713, 3747);
                    return return_v;
                }


                string
                f_25019_3696_3748(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 3696, 3748);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
                f_25019_3520_3527_I(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 3520, 3527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 3316, 3854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 3316, 3854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string[] GetStrings(this IEnumerable<MetadataReader> readers, IEnumerable<StringHandle> handles)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 3866, 4081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 4001, 4070);

                return f_25019_4008_4069(f_25019_4008_4059(handles, handle => readers.GetString(handle)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 3866, 4081);

                System.Collections.Generic.IEnumerable<string>
                f_25019_4008_4059(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source, System.Func<System.Reflection.Metadata.StringHandle, string>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.StringHandle, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4008, 4059);
                    return return_v;
                }


                string[]
                f_25019_4008_4069(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4008, 4069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 3866, 4081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 3866, 4081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Guid GetModuleVersionId(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 4093, 4251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 4183, 4240);

                return f_25019_4190_4239(reader, f_25019_4205_4233(reader).Mvid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 4093, 4251);

                System.Reflection.Metadata.ModuleDefinition
                f_25019_4205_4233(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.GetModuleDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4205, 4233);
                    return return_v;
                }


                System.Guid
                f_25019_4190_4239(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GuidHandle
                handle)
                {
                    var return_v = this_param.GetGuid(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4190, 4239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 4093, 4251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 4093, 4251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetAssemblyRefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 4263, 4477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 4364, 4466);

                var temp = reader.AssemblyReferences;
                return f_25019_4371_4465(f_25019_4371_4455(ref temp, handle => reader.GetAssemblyReference(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 4263, 4477);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_4371_4455(ref System.Reflection.Metadata.AssemblyReferenceHandleCollection
                source, System.Func<System.Reflection.Metadata.AssemblyReferenceHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.AssemblyReferenceHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4371, 4455);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_4371_4465(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4371, 4465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 4263, 4477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 4263, 4477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetTypeDefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 4489, 4693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 4586, 4682);

                var temp = reader.TypeDefinitions;
                return f_25019_4593_4681(f_25019_4593_4671(ref temp, handle => reader.GetTypeDefinition(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 4489, 4693);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_4593_4671(ref System.Reflection.Metadata.TypeDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.TypeDefinitionHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.TypeDefinitionHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4593, 4671);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_4593_4681(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4593, 4681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 4489, 4693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 4489, 4693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static (StringHandle Namespace, StringHandle Name)[] GetTypeDefFullNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 4705, 5045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 4837, 5034);

                var temp = reader.TypeDefinitions;
                return f_25019_4844_5033(f_25019_4844_5023(ref temp, handle =>
                            {
                                var td = reader.GetTypeDefinition(handle);
                                return (td.Namespace, td.Name);
                            }));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 4705, 5045);

                System.Collections.Generic.IEnumerable<(System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name)>
                f_25019_4844_5023(ref System.Reflection.Metadata.TypeDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.TypeDefinitionHandle, (System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name)>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.TypeDefinitionHandle, (System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name)>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4844, 5023);
                    return return_v;
                }


                (System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name)[]
                f_25019_4844_5033(System.Collections.Generic.IEnumerable<(System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name)>
                source)
                {
                    var return_v = source.ToArray<(System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 4844, 5033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 4705, 5045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 4705, 5045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetTypeRefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 5057, 5259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 5154, 5248);

                var temp = reader.TypeReferences;
                return f_25019_5161_5247(f_25019_5161_5237(ref temp, handle => reader.GetTypeReference(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 5057, 5259);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_5161_5237(ref System.Reflection.Metadata.TypeReferenceHandleCollection
                source, System.Func<System.Reflection.Metadata.TypeReferenceHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.TypeReferenceHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5161, 5237);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_5161_5247(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5161, 5247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 5057, 5259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 5057, 5259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetEventDefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 5271, 5478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 5369, 5467);

                var temp = reader.EventDefinitions;
                return f_25019_5376_5466(f_25019_5376_5456(ref temp, handle => reader.GetEventDefinition(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 5271, 5478);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_5376_5456(ref System.Reflection.Metadata.EventDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.EventDefinitionHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.EventDefinitionHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5376, 5456);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_5376_5466(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5376, 5466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 5271, 5478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 5271, 5478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetFieldDefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 5490, 5697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 5588, 5686);

                var temp = reader.FieldDefinitions;
                return f_25019_5595_5685(f_25019_5595_5675(ref temp, handle => reader.GetFieldDefinition(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 5490, 5697);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_5595_5675(ref System.Reflection.Metadata.FieldDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.FieldDefinitionHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.FieldDefinitionHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5595, 5675);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_5595_5685(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5595, 5685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 5490, 5697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 5490, 5697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetMethodDefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 5709, 5919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 5808, 5908);

                var temp = reader.MethodDefinitions;
                return f_25019_5815_5907(f_25019_5815_5897(ref temp, handle => reader.GetMethodDefinition(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 5709, 5919);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_5815_5897(ref System.Reflection.Metadata.MethodDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5815, 5897);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_5815_5907(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 5815, 5907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 5709, 5919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 5709, 5919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetMemberRefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 5931, 6139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 6030, 6128);

                var temp = reader.MemberReferences;
                return f_25019_6037_6127(f_25019_6037_6117(ref temp, handle => reader.GetMemberReference(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 5931, 6139);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_6037_6117(ref System.Reflection.Metadata.MemberReferenceHandleCollection
                source, System.Func<System.Reflection.Metadata.MemberReferenceHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.MemberReferenceHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6037, 6117);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_6037_6127(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6037, 6127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 5931, 6139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 5931, 6139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetParameterDefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 6151, 6355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 6253, 6344);

                return f_25019_6260_6343(f_25019_6260_6333(f_25019_6260_6282(reader), handle => reader.GetParameter(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 6151, 6355);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.ParameterHandle>
                f_25019_6260_6282(System.Reflection.Metadata.MetadataReader
                reader)
                {
                    var return_v = reader.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6260, 6282);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_6260_6333(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.ParameterHandle>
                source, System.Func<System.Reflection.Metadata.ParameterHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.ParameterHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6260, 6333);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_6260_6343(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6260, 6343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 6151, 6355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 6151, 6355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle[] GetPropertyDefNames(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 6367, 6583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 6468, 6572);

                var temp = reader.PropertyDefinitions;
                return f_25019_6475_6571(f_25019_6475_6561(ref temp, handle => reader.GetPropertyDefinition(handle).Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 6367, 6583);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_6475_6561(ref System.Reflection.Metadata.PropertyDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.PropertyDefinitionHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.PropertyDefinitionHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6475, 6561);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle[]
                f_25019_6475_6571(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source)
                {
                    var return_v = source.ToArray<System.Reflection.Metadata.StringHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6475, 6571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 6367, 6583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 6367, 6583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringHandle GetName(this MetadataReader reader, EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 6595, 7134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 6702, 7123);

                switch (token.Kind)
                {

                    case HandleKind.TypeReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 6702, 7123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 6806, 6870);

                        return f_25019_6813_6864(reader, token).Name;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 6702, 7123);

                    case HandleKind.TypeDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 6702, 7123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 6941, 7007);

                        return f_25019_6948_7001(reader, token).Name;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 6702, 7123);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 6702, 7123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7055, 7108);

                        throw f_25019_7061_7107(token.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 6702, 7123);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 6595, 7134);

                System.Reflection.Metadata.TypeReference
                f_25019_6813_6864(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference((System.Reflection.Metadata.TypeReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6813, 6864);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_25019_6948_7001(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition((System.Reflection.Metadata.TypeDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 6948, 7001);
                    return return_v;
                }


                System.Exception
                f_25019_7061_7107(System.Reflection.Metadata.HandleKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 7061, 7107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 6595, 7134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 6595, 7134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private delegate T ReadBlobItemDelegate<T>(ref BlobReader blobReader);

        private static ImmutableArray<T> ReadArray<T>(this MetadataReader reader, BlobHandle blobHandle, ReadBlobItemDelegate<T> readItem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 7228, 7813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7383, 7433);

                var
                blobReader = f_25019_7400_7432<T>(reader, blobHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7470, 7494);

                blobReader.ReadUInt16();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7535, 7566);

                int
                n = blobReader.ReadInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7580, 7625);

                var
                builder = f_25019_7594_7624<T>(n)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7648, 7653);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7639, 7752) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7662, 7665)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 7639, 7752))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 7639, 7752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7699, 7737);

                        f_25019_7699_7736<T>(builder, f_25019_7711_7735<T>(readItem, ref blobReader));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7766, 7802);

                return f_25019_7773_7801<T>(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 7228, 7813);

                System.Reflection.Metadata.BlobReader
                f_25019_7400_7432<T>(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 7400, 7432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_25019_7594_7624<T>(int
                capacity)
                {
                    var return_v = ArrayBuilder<T>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 7594, 7624);
                    return return_v;
                }


                T
                f_25019_7711_7735<T>(Roslyn.Test.Utilities.MetadataReaderUtils.ReadBlobItemDelegate<T>
                this_param, ref System.Reflection.Metadata.BlobReader
                blobReader)
                {
                    var return_v = this_param.Invoke(ref blobReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 7711, 7735);
                    return return_v;
                }


                int
                f_25019_7699_7736<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 7699, 7736);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_25019_7773_7801<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 7773, 7801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 7228, 7813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 7228, 7813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<byte> ReadByteArray(this MetadataReader reader, BlobHandle blobHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 7825, 8051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 7949, 8040);

                return f_25019_7956_8039(reader, blobHandle, (ref BlobReader blobReader) => blobReader.ReadByte());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 7825, 8051);

                System.Collections.Immutable.ImmutableArray<byte>
                f_25019_7956_8039(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.BlobHandle
                blobHandle, Roslyn.Test.Utilities.MetadataReaderUtils.ReadBlobItemDelegate<byte>
                readItem)
                {
                    var return_v = reader.ReadArray<byte>(blobHandle, readItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 7956, 8039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 7825, 8051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 7825, 8051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<bool> ReadBoolArray(this MetadataReader reader, BlobHandle blobHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 8063, 8292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8187, 8281);

                return f_25019_8194_8280(reader, blobHandle, (ref BlobReader blobReader) => blobReader.ReadBoolean());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 8063, 8292);

                System.Collections.Immutable.ImmutableArray<bool>
                f_25019_8194_8280(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.BlobHandle
                blobHandle, Roslyn.Test.Utilities.MetadataReaderUtils.ReadBlobItemDelegate<bool>
                readItem)
                {
                    var return_v = reader.ReadArray<bool>(blobHandle, readItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 8194, 8280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 8063, 8292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 8063, 8292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<CustomAttributeRow> GetCustomAttributeRows(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 8304, 8676);

                var listYield = new List<CustomAttributeRow>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8425, 8665);
                    foreach (var handle in f_25019_8448_8471_I(f_25019_8448_8471(reader)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 8425, 8665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8505, 8555);

                        var
                        attribute = f_25019_8521_8554(reader, handle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8573, 8650);

                        listYield.Add(f_25019_8586_8649(attribute.Parent, attribute.Constructor));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 8425, 8665);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 241);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 8304, 8676);

                return listYield;

                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_25019_8448_8471(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.CustomAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 8448, 8471);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttribute
                f_25019_8521_8554(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttribute(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 8521, 8554);
                    return return_v;
                }


                Roslyn.Test.Utilities.CustomAttributeRow
                f_25019_8586_8649(System.Reflection.Metadata.EntityHandle
                parentToken, System.Reflection.Metadata.EntityHandle
                constructorToken)
                {
                    var return_v = new Roslyn.Test.Utilities.CustomAttributeRow(parentToken, constructorToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 8586, 8649);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_25019_8448_8471_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 8448, 8471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 8304, 8676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 8304, 8676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetCustomAttributeName(this MetadataReader reader, CustomAttributeRow row)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 8688, 9511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8808, 8828);

                EntityHandle
                parent
                = default(EntityHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8842, 8875);

                var
                token = row.ConstructorToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8889, 9398);

                switch (token.Kind)
                {

                    case HandleKind.MemberReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 8889, 9398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 8995, 9067);

                        parent = f_25019_9004_9059(reader, token).Parent;
                        DynAbs.Tracing.TraceSender.TraceBreak(25019, 9089, 9095);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 8889, 9398);

                    case HandleKind.MethodDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 8889, 9398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9168, 9254);

                        parent = f_25019_9177_9234(reader, token).GetDeclaringType();
                        DynAbs.Tracing.TraceSender.TraceBreak(25019, 9276, 9282);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 8889, 9398);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 8889, 9398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9330, 9383);

                        throw f_25019_9336_9382(token.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 8889, 9398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9412, 9451);

                var
                strHandle = reader.GetName(parent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9465, 9500);

                return f_25019_9472_9499(reader, strHandle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 8688, 9511);

                System.Reflection.Metadata.MemberReference
                f_25019_9004_9059(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetMemberReference((System.Reflection.Metadata.MemberReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9004, 9059);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_25019_9177_9234(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition((System.Reflection.Metadata.MethodDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9177, 9234);
                    return return_v;
                }


                System.Exception
                f_25019_9336_9382(System.Reflection.Metadata.HandleKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9336, 9382);
                    return return_v;
                }


                string
                f_25019_9472_9499(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9472, 9499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 8688, 9511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 8688, 9511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIncluded(this ImmutableArray<byte> metadata, string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 9523, 10115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9625, 9672);

                var
                builder = f_25019_9639_9671()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9686, 9744);

                f_25019_9686_9743(builder, f_25019_9703_9742(f_25019_9703_9728(), str));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9758, 9773);

                f_25019_9758_9772(builder, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9811, 9852);

                var
                bytes = f_25019_9823_9851(builder)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9877, 9882);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9868, 10077) || true) && (i < metadata.Length - bytes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9920, 9923)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 9868, 10077))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 9868, 10077);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 9957, 10062) || true) && (metadata.IsAtIndex(bytes, i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 9957, 10062);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10031, 10043);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 9957, 10062);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 210);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10091, 10104);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 9523, 10115);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_25019_9639_9671()
                {
                    var return_v = ArrayBuilder<byte>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9639, 9671);
                    return return_v;
                }


                System.Text.Encoding
                f_25019_9703_9728()
                {
                    var return_v = System.Text.Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 9703, 9728);
                    return return_v;
                }


                byte[]
                f_25019_9703_9742(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9703, 9742);
                    return return_v;
                }


                int
                f_25019_9686_9743(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, params byte[]
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9686, 9743);
                    return 0;
                }


                int
                f_25019_9758_9772(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                item)
                {
                    this_param.Add((byte)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9758, 9772);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25019_9823_9851(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 9823, 9851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 9523, 10115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 9523, 10115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAtIndex(this ImmutableArray<byte> metadata, ImmutableArray<byte> bytes, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 10127, 10489);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10265, 10270);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10256, 10452) || true) && (i < bytes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10290, 10293)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 10256, 10452))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 10256, 10452);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10327, 10437) || true) && (metadata[i + offset] != bytes[i])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 10327, 10437);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10405, 10418);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 10327, 10437);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10466, 10478);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 10127, 10489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 10127, 10489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 10127, 10489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<byte> GetSourceLinkBlob(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 10501, 10908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 10606, 10897);

                return f_25019_10613_10896((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from handle in reader.CustomDebugInformation
                                                                                                    let cdi = reader.GetCustomDebugInformation(handle)
                                                                                                    where reader.GetGuid(cdi.Kind) == PortableCustomDebugInfoKinds.SourceLink
                                                                                                    select reader.GetBlobContent(cdi.Value), 25019, 10614, 10886)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 10501, 10908);

                System.Collections.Immutable.ImmutableArray<byte>
                f_25019_10613_10896(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                source)
                {
                    var return_v = source.Single<System.Collections.Immutable.ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 10613, 10896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 10501, 10908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 10501, 10908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourceText GetEmbeddedSource(this MetadataReader reader, DocumentHandle document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 10920, 12301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11040, 11387);

                byte[]
                bytes = f_25019_11055_11386((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from handle in reader.GetCustomDebugInformation(document)
                                                                                                     let cdi = reader.GetCustomDebugInformation(handle)
                                                                                                     where reader.GetGuid(cdi.Kind) == PortableCustomDebugInfoKinds.EmbeddedSource
                                                                                                     select reader.GetBlobBytes(cdi.Value), 25019, 11056, 11367)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11403, 11481) || true) && (bytes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 11403, 11481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11454, 11466);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 11403, 11481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11497, 11551);

                int
                uncompressedSize = f_25019_11520_11550(bytes, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11565, 11643);

                var
                stream = f_25019_11578_11642(bytes, sizeof(int), f_25019_11615_11627(bytes) - sizeof(int))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11659, 12172) || true) && (uncompressedSize != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 11659, 12172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11718, 11772);

                    var
                    decompressed = f_25019_11737_11771(uncompressedSize)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11792, 11958);
                    using (var
                    deflater = f_25019_11814_11867(stream, CompressionMode.Decompress)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11909, 11939);

                        f_25019_11909_11938(deflater, decompressed);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(25019, 11792, 11958);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 11978, 12115) || true) && (f_25019_11982_12001(decompressed) != uncompressedSize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 11978, 12115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 12063, 12096);

                        throw f_25019_12069_12095();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 11978, 12115);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 12135, 12157);

                    stream = decompressed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 11659, 12172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 12188, 12290);
                using (stream)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 12235, 12275);

                    return f_25019_12242_12274(stream);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25019, 12188, 12290);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 10920, 12301);

                byte[]
                f_25019_11055_11386(System.Collections.Generic.IEnumerable<byte[]>
                source)
                {
                    var return_v = source.SingleOrDefault<byte[]>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 11055, 11386);
                    return return_v;
                }


                int
                f_25019_11520_11550(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToInt32(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 11520, 11550);
                    return return_v;
                }


                int
                f_25019_11615_11627(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 11615, 11627);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25019_11578_11642(byte[]
                buffer, int
                index, int
                count)
                {
                    var return_v = new System.IO.MemoryStream(buffer, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 11578, 11642);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25019_11737_11771(int
                capacity)
                {
                    var return_v = new System.IO.MemoryStream(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 11737, 11771);
                    return return_v;
                }


                System.IO.Compression.DeflateStream
                f_25019_11814_11867(System.IO.MemoryStream
                stream, System.IO.Compression.CompressionMode
                mode)
                {
                    var return_v = new System.IO.Compression.DeflateStream((System.IO.Stream)stream, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 11814, 11867);
                    return return_v;
                }


                int
                f_25019_11909_11938(System.IO.Compression.DeflateStream
                this_param, System.IO.MemoryStream
                destination)
                {
                    this_param.CopyTo((System.IO.Stream)destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 11909, 11938);
                    return 0;
                }


                long
                f_25019_11982_12001(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 11982, 12001);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_25019_12069_12095()
                {
                    var return_v = new System.IO.InvalidDataException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 12069, 12095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_25019_12242_12274(System.IO.MemoryStream
                stream)
                {
                    var return_v = EncodedStringText.Create((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 12242, 12274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 10920, 12301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 10920, 12301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<string> DumpAssemblyReferences(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 12313, 12615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 12422, 12604);

                var temp = reader.AssemblyReferences;
                return f_25019_12429_12603(f_25019_12429_12498(ref temp, r => reader.GetAssemblyReference(r)), row => $"{reader.GetString(row.Name)} {row.Version.Major}.{row.Version.Minor}");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 12313, 12615);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyReference>
                f_25019_12429_12498(ref System.Reflection.Metadata.AssemblyReferenceHandleCollection
                source, System.Func<System.Reflection.Metadata.AssemblyReferenceHandle, System.Reflection.Metadata.AssemblyReference>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.AssemblyReferenceHandle, System.Reflection.Metadata.AssemblyReference>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 12429, 12498);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25019_12429_12603(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyReference>
                source, System.Func<System.Reflection.Metadata.AssemblyReference, string>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.AssemblyReference, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 12429, 12603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 12313, 12615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 12313, 12615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<string> DumpTypeReferences(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 12627, 12958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 12732, 12947);

                var temp = reader.TypeReferences;
                return f_25019_12739_12946(f_25019_12739_12818(ref temp
                , t => reader.GetTypeReference(t)), t => $"{reader.GetString(t.Name)}, {reader.GetString(t.Namespace)}, {reader.Dump(t.ResolutionScope)}");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 12627, 12958);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeReference>
                f_25019_12739_12818(ref System.Reflection.Metadata.TypeReferenceHandleCollection
                source, System.Func<System.Reflection.Metadata.TypeReferenceHandle, System.Reflection.Metadata.TypeReference>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.TypeReferenceHandle, System.Reflection.Metadata.TypeReference>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 12739, 12818);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25019_12739_12946(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeReference>
                source, System.Func<System.Reflection.Metadata.TypeReference, string>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.TypeReference, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 12739, 12946);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 12627, 12958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 12627, 12958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Dump(this MetadataReader reader, EntityHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 12970, 13353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13069, 13108);

                string
                value = f_25019_13084_13107(reader, handle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13122, 13159);

                string
                kind = f_25019_13136_13158(handle.Kind)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13173, 13342) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13173, 13342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13224, 13249);

                    return $"{kind}:{value}";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13173, 13342);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13173, 13342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13315, 13327);

                    return kind;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13173, 13342);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 12970, 13353);

                string
                f_25019_13084_13107(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = reader.DumpRec(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 13084, 13107);
                    return return_v;
                }


                string
                f_25019_13136_13158(System.Reflection.Metadata.HandleKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 13136, 13158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 12970, 13353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 12970, 13353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string DumpRec(this MetadataReader reader, EntityHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 13365, 17278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13468, 16906);

                switch (handle.Kind)
                {

                    case HandleKind.AssemblyReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13577, 13668);

                        return f_25019_13584_13667(reader, f_25019_13601_13661(reader, handle).Name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);

                    case HandleKind.TypeDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13766, 13843);

                            TypeDefinition
                            type = f_25019_13788_13842(reader, handle)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 13869, 13920);

                            return f_25019_13876_13919(type.Namespace, type.Name);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);

                    case HandleKind.MethodDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14043, 14128);

                            MethodDefinition
                            method = f_25019_14069_14127(reader, handle)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14154, 14204);

                            var
                            blob = f_25019_14165_14203(reader, method.Signature)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14230, 14349);

                            var
                            decoder = f_25019_14244_14348(ConstantSignatureVisualizer.Instance, reader, genericContext: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14375, 14431);

                            var
                            signature = decoder.DecodeMethodSignature(ref blob)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14457, 14510);

                            var temp2 = signature.ParameterTypes;
                            var
                            parameters = f_25019_14474_14509(ref temp2, ", ")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14536, 14660);

                            return $"{signature.ReturnType} {f_25019_14569_14611(reader, method.GetDeclaringType())}.{f_25019_14614_14643(reader, method.Name)}({parameters})";
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);

                    case HandleKind.MemberReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14782, 14864);

                            MemberReference
                            member = f_25019_14807_14863(reader, handle)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14890, 14940);

                            var
                            blob = f_25019_14901_14939(reader, member.Signature)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 14966, 15085);

                            var
                            decoder = f_25019_14980_15084(ConstantSignatureVisualizer.Instance, reader, genericContext: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15111, 15167);

                            var
                            signature = decoder.DecodeMethodSignature(ref blob)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15193, 15246);

                            var temp = signature.ParameterTypes;
                            var
                            parameters = f_25019_15210_15245(ref temp, ", ")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15272, 15384);

                            return $"{signature.ReturnType} {f_25019_15305_15335(reader, member.Parent)}.{f_25019_15338_15367(reader, member.Name)}({parameters})";
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);

                    case HandleKind.TypeReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15504, 15578);

                            TypeReference
                            type = f_25019_15525_15577(reader, handle)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15604, 15655);

                            return f_25019_15611_15654(type.Namespace, type.Name);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);

                    case HandleKind.FieldDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15777, 15858);

                            FieldDefinition
                            field = f_25019_15801_15857(reader, handle)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15884, 15924);

                            var
                            name = f_25019_15895_15923(reader, field.Name)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 15952, 16001);

                            var
                            blob = f_25019_15963_16000(reader, field.Signature)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16027, 16146);

                            var
                            decoder = f_25019_16041_16145(ConstantSignatureVisualizer.Instance, reader, genericContext: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16172, 16222);

                            var
                            type = decoder.DecodeFieldSignature(ref blob)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16250, 16274);

                            return $"{type} {name}";
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);

                    case HandleKind.TypeSpecification:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16398, 16474);

                            var
                            typeSpec = f_25019_16413_16473(reader, handle)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16500, 16552);

                            var
                            blob = f_25019_16511_16551(reader, typeSpec.Signature)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16578, 16697);

                            var
                            decoder = f_25019_16592_16696(ConstantSignatureVisualizer.Instance, reader, genericContext: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16723, 16763);

                            var
                            type = decoder.DecodeType(ref blob)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16791, 16808);

                            return $"{type}";
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 13468, 16906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 16879, 16891);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 13468, 16906);
                }

                string getQualifiedName(StringHandle leftHandle, StringHandle rightHandle)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 16922, 17267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17029, 17073);

                        string
                        name = f_25019_17043_17072(reader, rightHandle)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17091, 17222) || true) && (f_25019_17095_17112_M(!leftHandle.IsNil))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 17091, 17222);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17154, 17203);

                            name = f_25019_17161_17189(reader, leftHandle) + "." + name;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 17091, 17222);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17240, 17252);

                        return name;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 16922, 17267);

                        string
                        f_25019_17043_17072(System.Reflection.Metadata.MetadataReader
                        this_param, System.Reflection.Metadata.StringHandle
                        handle)
                        {
                            var return_v = this_param.GetString(handle);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 17043, 17072);
                            return return_v;
                        }


                        bool
                        f_25019_17095_17112_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 17095, 17112);
                            return return_v;
                        }


                        string
                        f_25019_17161_17189(System.Reflection.Metadata.MetadataReader
                        this_param, System.Reflection.Metadata.StringHandle
                        handle)
                        {
                            var return_v = this_param.GetString(handle);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 17161, 17189);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 16922, 17267);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 16922, 17267);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 13365, 17278);

                System.Reflection.Metadata.AssemblyReference
                f_25019_13601_13661(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetAssemblyReference((System.Reflection.Metadata.AssemblyReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 13601, 13661);
                    return return_v;
                }


                string
                f_25019_13584_13667(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 13584, 13667);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_25019_13788_13842(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition((System.Reflection.Metadata.TypeDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 13788, 13842);
                    return return_v;
                }


                string
                f_25019_13876_13919(System.Reflection.Metadata.StringHandle
                leftHandle, System.Reflection.Metadata.StringHandle
                rightHandle)
                {
                    var return_v = getQualifiedName(leftHandle, rightHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 13876, 13919);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_25019_14069_14127(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition((System.Reflection.Metadata.MethodDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14069, 14127);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_25019_14165_14203(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14165, 14203);
                    return return_v;
                }


                System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>
                f_25019_14244_14348(Roslyn.Test.Utilities.MetadataReaderUtils.ConstantSignatureVisualizer
                provider, System.Reflection.Metadata.MetadataReader
                metadataReader, object
                genericContext)
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>((System.Reflection.Metadata.ISignatureTypeProvider<string, object>)provider, metadataReader, genericContext: genericContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14244, 14348);
                    return return_v;
                }


                string
                f_25019_14474_14509(ref System.Collections.Immutable.ImmutableArray<string>
                source, string
                separator)
                {
                    var return_v = source.Join(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14474, 14509);
                    return return_v;
                }


                string
                f_25019_14569_14611(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = reader.DumpRec((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14569, 14611);
                    return return_v;
                }


                string
                f_25019_14614_14643(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14614, 14643);
                    return return_v;
                }


                System.Reflection.Metadata.MemberReference
                f_25019_14807_14863(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetMemberReference((System.Reflection.Metadata.MemberReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14807, 14863);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_25019_14901_14939(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14901, 14939);
                    return return_v;
                }


                System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>
                f_25019_14980_15084(Roslyn.Test.Utilities.MetadataReaderUtils.ConstantSignatureVisualizer
                provider, System.Reflection.Metadata.MetadataReader
                metadataReader, object
                genericContext)
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>((System.Reflection.Metadata.ISignatureTypeProvider<string, object>)provider, metadataReader, genericContext: genericContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 14980, 15084);
                    return return_v;
                }


                string
                f_25019_15210_15245(ref System.Collections.Immutable.ImmutableArray<string>
                source, string
                separator)
                {
                    var return_v = source.Join(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15210, 15245);
                    return return_v;
                }


                string
                f_25019_15305_15335(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = reader.DumpRec(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15305, 15335);
                    return return_v;
                }


                string
                f_25019_15338_15367(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15338, 15367);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReference
                f_25019_15525_15577(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference((System.Reflection.Metadata.TypeReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15525, 15577);
                    return return_v;
                }


                string
                f_25019_15611_15654(System.Reflection.Metadata.StringHandle
                leftHandle, System.Reflection.Metadata.StringHandle
                rightHandle)
                {
                    var return_v = getQualifiedName(leftHandle, rightHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15611, 15654);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_25019_15801_15857(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition((System.Reflection.Metadata.FieldDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15801, 15857);
                    return return_v;
                }


                string
                f_25019_15895_15923(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15895, 15923);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_25019_15963_16000(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 15963, 16000);
                    return return_v;
                }


                System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>
                f_25019_16041_16145(Roslyn.Test.Utilities.MetadataReaderUtils.ConstantSignatureVisualizer
                provider, System.Reflection.Metadata.MetadataReader
                metadataReader, object
                genericContext)
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>((System.Reflection.Metadata.ISignatureTypeProvider<string, object>)provider, metadataReader, genericContext: genericContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 16041, 16145);
                    return return_v;
                }


                System.Reflection.Metadata.TypeSpecification
                f_25019_16413_16473(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeSpecification((System.Reflection.Metadata.TypeSpecificationHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 16413, 16473);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_25019_16511_16551(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 16511, 16551);
                    return return_v;
                }


                System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>
                f_25019_16592_16696(Roslyn.Test.Utilities.MetadataReaderUtils.ConstantSignatureVisualizer
                provider, System.Reflection.Metadata.MetadataReader
                metadataReader, object
                genericContext)
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>((System.Reflection.Metadata.ISignatureTypeProvider<string, object>)provider, metadataReader, genericContext: genericContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 16592, 16696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 13365, 17278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 13365, 17278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ConstantSignatureVisualizer : ISignatureTypeProvider<string, object>
        {
            public static readonly ConstantSignatureVisualizer Instance;

            public string GetArrayType(string elementType, ArrayShape shape)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 17598, 17654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17601, 17654);
                    return elementType + "[" + f_25019_17621_17648(',', shape.Rank) + "]"; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 17598, 17654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 17598, 17654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 17598, 17654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetByReferenceType(string elementType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 17741, 17761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17744, 17761);
                    return elementType + "&"; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 17741, 17761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 17741, 17761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 17741, 17761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetFunctionPointerType(MethodSignature<string> signature)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 17867, 17882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17870, 17882);
                    return "method-ptr"; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 17867, 17882);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 17867, 17882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 17867, 17882);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetGenericInstantiation(string genericType, ImmutableArray<string> typeArguments)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18012, 18073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18015, 18073);
                    return genericType + "{" + f_25019_18035_18067(", ", typeArguments) + "}"; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18012, 18073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18012, 18073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18012, 18073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetGenericMethodParameter(object genericContext, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18181, 18196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18184, 18196);
                    return "!!" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (index).ToString(), 25019, 18191, 18196); DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18181, 18196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18181, 18196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18181, 18196);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetGenericTypeParameter(object genericContext, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18302, 18316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18305, 18316);
                    return "!" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (index).ToString(), 25019, 18311, 18316); DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18302, 18316);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18302, 18316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18302, 18316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetModifiedType(string modifier, string unmodifiedType, bool isRequired)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18437, 18515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18440, 18515);
                    return ((DynAbs.Tracing.TraceSender.Conditional_F1(25019, 18441, 18451) || ((isRequired && DynAbs.Tracing.TraceSender.Conditional_F2(25019, 18454, 18462)) || DynAbs.Tracing.TraceSender.Conditional_F3(25019, 18465, 18473))) ? "modreq" : "modopt") + "(" + modifier + ") " + unmodifiedType; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18437, 18515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18437, 18515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18437, 18515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetPinnedType(string elementType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18597, 18623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18600, 18623);
                    return "pinned " + elementType; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18597, 18623);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18597, 18623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18597, 18623);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetPointerType(string elementType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18706, 18726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18709, 18726);
                    return elementType + "*"; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18706, 18726);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18706, 18726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18706, 18726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetPrimitiveType(PrimitiveTypeCode typeCode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18819, 18841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18822, 18841);
                    return f_25019_18822_18841(typeCode); DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18819, 18841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18819, 18841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18819, 18841);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetSZArrayType(string elementType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18924, 18945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 18927, 18945);
                    return elementType + "[]"; DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18924, 18945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18924, 18945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18924, 18945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 18962, 19329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19100, 19147);

                    var
                    typeDef = f_25019_19114_19146(reader, handle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19165, 19207);

                    var
                    name = f_25019_19176_19206(reader, typeDef.Name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19225, 19314);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25019, 19232, 19255) || ((typeDef.Namespace.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(25019, 19258, 19262)) || DynAbs.Tracing.TraceSender.Conditional_F3(25019, 19265, 19313))) ? name : f_25019_19265_19300(reader, typeDef.Namespace) + "." + name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 18962, 19329);

                    System.Reflection.Metadata.TypeDefinition
                    f_25019_19114_19146(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    handle)
                    {
                        var return_v = this_param.GetTypeDefinition(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19114, 19146);
                        return return_v;
                    }


                    string
                    f_25019_19176_19206(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.StringHandle
                    handle)
                    {
                        var return_v = this_param.GetString(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19176, 19206);
                        return return_v;
                    }


                    string
                    f_25019_19265_19300(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.StringHandle
                    handle)
                    {
                        var return_v = this_param.GetString(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19265, 19300);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 18962, 19329);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 18962, 19329);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 19345, 19709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19481, 19527);

                    var
                    typeRef = f_25019_19495_19526(reader, handle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19545, 19587);

                    var
                    name = f_25019_19556_19586(reader, typeRef.Name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19605, 19694);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25019, 19612, 19635) || ((typeRef.Namespace.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(25019, 19638, 19642)) || DynAbs.Tracing.TraceSender.Conditional_F3(25019, 19645, 19693))) ? name : f_25019_19645_19680(reader, typeRef.Namespace) + "." + name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 19345, 19709);

                    System.Reflection.Metadata.TypeReference
                    f_25019_19495_19526(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.TypeReferenceHandle
                    handle)
                    {
                        var return_v = this_param.GetTypeReference(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19495, 19526);
                        return return_v;
                    }


                    string
                    f_25019_19556_19586(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.StringHandle
                    handle)
                    {
                        var return_v = this_param.GetString(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19556, 19586);
                        return return_v;
                    }


                    string
                    f_25019_19645_19680(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.StringHandle
                    handle)
                    {
                        var return_v = this_param.GetString(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19645, 19680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 19345, 19709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 19345, 19709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string GetTypeFromSpecification(MetadataReader reader, object genericContext, TypeSpecificationHandle handle, byte rawTypeKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25019, 19725, 20113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19892, 19976);

                    var
                    sigReader = f_25019_19908_19975(reader, f_25019_19929_19964(reader, handle).Signature)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 19994, 20098);

                    return f_25019_20001_20071(Instance, reader, genericContext).DecodeType(ref sigReader);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25019, 19725, 20113);

                    System.Reflection.Metadata.TypeSpecification
                    f_25019_19929_19964(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.TypeSpecificationHandle
                    handle)
                    {
                        var return_v = this_param.GetTypeSpecification(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19929, 19964);
                        return return_v;
                    }


                    System.Reflection.Metadata.BlobReader
                    f_25019_19908_19975(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.BlobHandle
                    handle)
                    {
                        var return_v = this_param.GetBlobReader(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 19908, 19975);
                        return return_v;
                    }


                    System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>
                    f_25019_20001_20071(Roslyn.Test.Utilities.MetadataReaderUtils.ConstantSignatureVisualizer
                    provider, System.Reflection.Metadata.MetadataReader
                    metadataReader, object
                    genericContext)
                    {
                        var return_v = new System.Reflection.Metadata.Ecma335.SignatureDecoder<string, object>((System.Reflection.Metadata.ISignatureTypeProvider<string, object>)provider, metadataReader, genericContext);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20001, 20071);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 19725, 20113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 19725, 20113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ConstantSignatureVisualizer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25019, 17290, 20124);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25019, 17290, 20124);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 17290, 20124);
            }


            static ConstantSignatureVisualizer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25019, 17290, 20124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 17455, 17499);
                Instance = f_25019_17466_17499(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25019, 17290, 20124);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 17290, 20124);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25019, 17290, 20124);

            static Roslyn.Test.Utilities.MetadataReaderUtils.ConstantSignatureVisualizer
            f_25019_17466_17499()
            {
                var return_v = new Roslyn.Test.Utilities.MetadataReaderUtils.ConstantSignatureVisualizer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 17466, 17499);
                return return_v;
            }


            string
            f_25019_17621_17648(char
            c, int
            count)
            {
                var return_v = new string(c, count);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 17621, 17648);
                return return_v;
            }


            string
            f_25019_18035_18067(string
            separator, System.Collections.Immutable.ImmutableArray<string>
            values)
            {
                var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 18035, 18067);
                return return_v;
            }


            string
            f_25019_18822_18841(System.Reflection.Metadata.PrimitiveTypeCode
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 18822, 18841);
                return return_v;
            }

        }

        internal static void VerifyPEMetadata(string pePath, string[] types, string[] methods, string[] attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 20136, 21175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 20268, 21164);
                using (var
                peStream = f_25019_20290_20311(pePath)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 20326, 21164);
                    using (var
                    refPeReader = f_25019_20351_20373(peStream)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 20407, 20460);

                        var
                        metadataReader = f_25019_20428_20459(refPeReader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 20480, 20573);

                        var temp = metadataReader.TypeDefinitions;
                        f_25019_20480_20572(f_25019_20498_20564(ref temp, t => metadataReader.Dump(t)), types);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 20591, 20688);

                        var temp2 = metadataReader.MethodDefinitions;
                        f_25019_20591_20687(f_25019_20609_20677(ref temp2, t => metadataReader.Dump(t)), methods);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 20708, 21149);

                        var temp3 = metadataReader.CustomAttributes;
                        f_25019_20708_21148(f_25019_20748_21114(f_25019_20748_21047(f_25019_20748_20947(f_25019_20748_20841(ref temp3, a => metadataReader.GetCustomAttribute(a).Constructor), c => metadataReader.GetMemberReference((MemberReferenceHandle)c).Parent), p => metadataReader.GetTypeReference((TypeReferenceHandle)p).Name), n => metadataReader.GetString(n)), attributes);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(25019, 20326, 21164);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25019, 20268, 21164);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 20136, 21175);

                System.IO.FileStream
                f_25019_20290_20311(string
                path)
                {
                    var return_v = File.OpenRead(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20290, 20311);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_25019_20351_20373(System.IO.FileStream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader((System.IO.Stream)peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20351, 20373);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_25019_20428_20459(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20428, 20459);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25019_20498_20564(ref System.Reflection.Metadata.TypeDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.TypeDefinitionHandle, string>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.TypeDefinitionHandle, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20498, 20564);
                    return return_v;
                }


                int
                f_25019_20480_20572(System.Collections.Generic.IEnumerable<string>
                actual, params string[]
                expected)
                {
                    AssertEx.SetEqual(actual, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20480, 20572);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25019_20609_20677(ref System.Reflection.Metadata.MethodDefinitionHandleCollection
                source, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, string>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.MethodDefinitionHandle, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20609, 20677);
                    return return_v;
                }


                int
                f_25019_20591_20687(System.Collections.Generic.IEnumerable<string>
                actual, params string[]
                expected)
                {
                    AssertEx.SetEqual(actual, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20591, 20687);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
                f_25019_20748_20841(ref System.Reflection.Metadata.CustomAttributeHandleCollection
                source, System.Func<System.Reflection.Metadata.CustomAttributeHandle, System.Reflection.Metadata.EntityHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.CustomAttributeHandle, System.Reflection.Metadata.EntityHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20748, 20841);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
                f_25019_20748_20947(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
                source, System.Func<System.Reflection.Metadata.EntityHandle, System.Reflection.Metadata.EntityHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.EntityHandle, System.Reflection.Metadata.EntityHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20748, 20947);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                f_25019_20748_21047(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
                source, System.Func<System.Reflection.Metadata.EntityHandle, System.Reflection.Metadata.StringHandle>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.EntityHandle, System.Reflection.Metadata.StringHandle>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20748, 21047);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25019_20748_21114(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
                source, System.Func<System.Reflection.Metadata.StringHandle, string>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.StringHandle, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20748, 21114);
                    return return_v;
                }


                int
                f_25019_20708_21148(System.Collections.Generic.IEnumerable<string>
                actual, params string[]
                expected)
                {
                    AssertEx.SetEqual(actual, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 20708, 21148);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 20136, 21175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 20136, 21175);
            }
        }

        internal static void VerifyMethodBodies(ImmutableArray<byte> peImage, Action<byte[]> ilValidator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 21187, 21987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21309, 21976);
                using (var
                peReader = f_25019_21331_21352(peImage)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21386, 21436);

                    var
                    metadataReader = f_25019_21407_21435(peReader)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21454, 21961);
                        foreach (var method in f_25019_21477_21509_I(f_25019_21477_21509(metadataReader)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 21454, 21961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21551, 21627);

                            var
                            rva = f_25019_21561_21603(metadataReader, method).RelativeVirtualAddress
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21649, 21942) || true) && (rva != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 21649, 21942);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21711, 21761);

                                var
                                il = f_25019_21720_21760(f_25019_21720_21747(peReader, rva))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21787, 21803);

                                f_25019_21787_21802(ilValidator, il);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 21649, 21942);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25019, 21649, 21942);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 21901, 21919);

                                f_25019_21901_21918(ilValidator, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 21649, 21942);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25019, 21454, 21961);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25019, 1, 508);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25019, 1, 508);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25019, 21309, 21976);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 21187, 21987);

                System.Reflection.PortableExecutable.PEReader
                f_25019_21331_21352(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21331, 21352);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_25019_21407_21435(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21407, 21435);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_25019_21477_21509(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.MethodDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25019, 21477, 21509);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_25019_21561_21603(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21561, 21603);
                    return return_v;
                }


                System.Reflection.Metadata.MethodBodyBlock
                f_25019_21720_21747(System.Reflection.PortableExecutable.PEReader
                peReader, int
                relativeVirtualAddress)
                {
                    var return_v = peReader.GetMethodBody(relativeVirtualAddress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21720, 21747);
                    return return_v;
                }


                byte[]?
                f_25019_21720_21760(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.GetILBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21720, 21760);
                    return return_v;
                }


                int
                f_25019_21787_21802(System.Action<byte[]>
                this_param, byte[]?
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21787, 21802);
                    return 0;
                }


                int
                f_25019_21901_21918(System.Action<byte[]>
                this_param, byte[]
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21901, 21918);
                    return 0;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_25019_21477_21509_I(System.Reflection.Metadata.MethodDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 21477, 21509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 21187, 21987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 21187, 21987);
            }
        }

        static readonly byte[] ThrowNull;

        internal static void AssertEmptyOrThrowNull(ImmutableArray<byte> peImage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 22100, 22399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 22198, 22388);

                f_25019_22198_22387(peImage, (il) =>
                            {
                                if (il != null)
                                {
                                    AssertEx.Equal(ThrowNull, il);
                                }
                            });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 22100, 22399);

                int
                f_25019_22198_22387(System.Collections.Immutable.ImmutableArray<byte>
                peImage, System.Action<byte[]>
                ilValidator)
                {
                    VerifyMethodBodies(peImage, ilValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 22198, 22387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 22100, 22399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 22100, 22399);
            }
        }

        internal static void AssertNotThrowNull(ImmutableArray<byte> peImage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25019, 22411, 22709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 22505, 22698);

                f_25019_22505_22697(peImage, (il) =>
                            {
                                if (il != null)
                                {
                                    AssertEx.NotEqual(ThrowNull, il);
                                }
                            });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25019, 22411, 22709);

                int
                f_25019_22505_22697(System.Collections.Immutable.ImmutableArray<byte>
                peImage, System.Action<byte[]>
                ilValidator)
                {
                    VerifyMethodBodies(peImage, ilValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25019, 22505, 22697);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25019, 22411, 22709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 22411, 22709);
            }
        }

        static MetadataReaderUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25019, 753, 22716);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25019, 22022, 22087);
            ThrowNull = new[] { (byte)ILOpCode.Ldnull, (byte)ILOpCode.Throw }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25019, 753, 22716);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25019, 753, 22716);
        }

    }
}
