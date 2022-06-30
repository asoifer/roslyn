// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis
{
    internal static class ModuleExtensions
    {
        private const string
        VTableGapMethodNamePrefix = "_VtblGap"
        ;

        public static bool ShouldImportNestedType(this PEModule module, TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(413, 617, 1396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 1373, 1385);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(413, 617, 1396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(413, 617, 1396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(413, 617, 1396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ShouldImportField(this PEModule module, FieldDefinitionHandle field, MetadataImportOptions importOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(413, 1603, 2034);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 1788, 1838);

                    var
                    flags = f_413_1800_1837(module, field)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 1856, 1903);

                    return f_413_1863_1902(flags, importOptions);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(413, 1932, 2023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 1996, 2008);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(413, 1932, 2023);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(413, 1603, 2034);

                System.Reflection.FieldAttributes
                f_413_1800_1837(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetFieldDefFlagsOrThrow(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 1800, 1837);
                    return return_v;
                }


                bool
                f_413_1863_1902(System.Reflection.FieldAttributes
                flags, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions)
                {
                    var return_v = ShouldImportField(flags, importOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 1863, 1902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(413, 1603, 2034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(413, 1603, 2034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ShouldImportField(FieldAttributes flags, MetadataImportOptions importOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(413, 2264, 2834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 2385, 2823);

                switch (flags & FieldAttributes.FieldAccessMask)
                {

                    case FieldAttributes.Private:
                    case FieldAttributes.PrivateScope:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 2385, 2823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 2569, 2619);

                        return importOptions == MetadataImportOptions.All;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(413, 2385, 2823);

                    case FieldAttributes.Assembly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 2385, 2823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 2691, 2746);

                        return importOptions >= MetadataImportOptions.Internal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(413, 2385, 2823);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 2385, 2823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 2796, 2808);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(413, 2385, 2823);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(413, 2264, 2834);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(413, 2264, 2834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(413, 2264, 2834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ShouldImportMethod(this PEModule module, MethodDefinitionHandle methodDef, MetadataImportOptions importOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(413, 3158, 5330);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 3349, 3404);

                    var
                    flags = f_413_3361_3403(module, methodDef)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 3647, 4474) || true) && ((flags & MethodAttributes.Virtual) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 3647, 4474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 3732, 4455);

                        switch (flags & MethodAttributes.MemberAccessMask)
                        {

                            case MethodAttributes.Private:
                            case MethodAttributes.PrivateScope:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 3732, 4455);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 3952, 4108) || true) && (importOptions != MetadataImportOptions.All)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 3952, 4108);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 4064, 4077);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(413, 3952, 4108);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(413, 4140, 4146);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(413, 3732, 4455);

                            case MethodAttributes.Assembly:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 3732, 4455);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 4235, 4394) || true) && (importOptions == MetadataImportOptions.Public)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 4235, 4394);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 4350, 4363);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(413, 4235, 4394);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(413, 4426, 4432);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(413, 3732, 4455);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(413, 3647, 4474);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(413, 4503, 4551);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(413, 4503, 4551);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 5051, 5104);

                    var
                    name = f_413_5062_5103(module, methodDef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 5122, 5199);

                    return !f_413_5130_5198(name, VTableGapMethodNamePrefix, StringComparison.Ordinal);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(413, 5228, 5319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 5292, 5304);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(413, 5228, 5319);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(413, 3158, 5330);

                System.Reflection.MethodAttributes
                f_413_3361_3403(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetMethodDefFlagsOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 3361, 3403);
                    return return_v;
                }


                string
                f_413_5062_5103(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetMethodDefNameOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 5062, 5103);
                    return return_v;
                }


                bool
                f_413_5130_5198(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 5130, 5198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(413, 3158, 5330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(413, 3158, 5330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int GetVTableGapSize(string emittedMethodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(413, 5506, 7958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 6784, 6832);

                const string
                prefix = VTableGapMethodNamePrefix
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 6848, 7922) || true) && (f_413_6852_6914(emittedMethodName, prefix, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 6848, 7922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 6948, 6958);

                    int
                    index
                    = default(int);
                    try
                    {
                        // Skip the SequenceNumber
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7027, 7048)
        , index = f_413_7035_7048(prefix); (DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7022, 7274) || true) && (index < f_413_7058_7082(emittedMethodName))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7084, 7091)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(413, 7022, 7274))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 7022, 7274);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7133, 7255) || true) && (!f_413_7138_7176(emittedMethodName, index))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 7133, 7255);
                                DynAbs.Tracing.TraceSender.TraceBreak(413, 7226, 7232);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(413, 7133, 7255);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(413, 1, 253);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(413, 1, 253);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7294, 7576) || true) && (index == f_413_7307_7320(prefix) || (DynAbs.Tracing.TraceSender.Expression_False(413, 7298, 7382) || index >= f_413_7354_7378(emittedMethodName) - 1) || (DynAbs.Tracing.TraceSender.Expression_False(413, 7298, 7438) || f_413_7407_7431(emittedMethodName, index) != '_') || (DynAbs.Tracing.TraceSender.Expression_False(413, 7298, 7506) || !f_413_7464_7506(emittedMethodName, index + 1)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 7294, 7576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7548, 7557);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(413, 7294, 7576);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7596, 7613);

                    int
                    countOfSlots
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7633, 7878) || true) && (f_413_7637_7756(f_413_7650_7688(emittedMethodName, index + 1), NumberStyles.None, f_413_7709_7737(), out countOfSlots) && (DynAbs.Tracing.TraceSender.Expression_True(413, 7637, 7797) && countOfSlots > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(413, 7633, 7878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7839, 7859);

                        return countOfSlots;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(413, 7633, 7878);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7898, 7907);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(413, 6848, 7922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 7938, 7947);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(413, 5506, 7958);

                bool
                f_413_6852_6914(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 6852, 6914);
                    return return_v;
                }


                int
                f_413_7035_7048(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(413, 7035, 7048);
                    return return_v;
                }


                int
                f_413_7058_7082(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(413, 7058, 7082);
                    return return_v;
                }


                bool
                f_413_7138_7176(string
                s, int
                index)
                {
                    var return_v = char.IsDigit(s, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 7138, 7176);
                    return return_v;
                }


                int
                f_413_7307_7320(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(413, 7307, 7320);
                    return return_v;
                }


                int
                f_413_7354_7378(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(413, 7354, 7378);
                    return return_v;
                }


                char
                f_413_7407_7431(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(413, 7407, 7431);
                    return return_v;
                }


                bool
                f_413_7464_7506(string
                s, int
                index)
                {
                    var return_v = char.IsDigit(s, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 7464, 7506);
                    return return_v;
                }


                string
                f_413_7650_7688(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 7650, 7688);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_413_7709_7737()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(413, 7709, 7737);
                    return return_v;
                }


                bool
                f_413_7637_7756(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 7637, 7756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(413, 5506, 7958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(413, 5506, 7958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetVTableGapName(int sequenceNumber, int countOfSlots)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(413, 7970, 8151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 8070, 8140);

                return f_413_8077_8139("_VtblGap{0}_{1}", sequenceNumber, countOfSlots);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(413, 7970, 8151);

                string
                f_413_8077_8139(string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(413, 8077, 8139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(413, 7970, 8151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(413, 7970, 8151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModuleExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(413, 377, 8158);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(413, 453, 491);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(413, 377, 8158);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(413, 377, 8158);
        }

    }
}
