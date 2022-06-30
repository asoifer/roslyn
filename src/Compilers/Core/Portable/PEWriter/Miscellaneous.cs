// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Roslyn.Utilities;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal static class IteratorHelper
    {
        public static bool EnumerableIsNotEmpty<T>([NotNullWhen(returnValue: true)] IEnumerable<T>? enumerable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(503, 830, 1436);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 958, 1042) || true) && (enumerable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(503, 958, 1042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1014, 1027);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(503, 958, 1042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1058, 1096);

                var
                asIListT = enumerable as IList<T>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1110, 1206) || true) && (asIListT != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(503, 1110, 1206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1164, 1191);

                    return f_503_1171_1185(asIListT) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(503, 1110, 1206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1222, 1256);

                var
                asIList = enumerable as IList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1270, 1364) || true) && (asIList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(503, 1270, 1364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1323, 1349);

                    return f_503_1330_1343(asIList) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(503, 1270, 1364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1380, 1425);

                return f_503_1387_1424(f_503_1387_1413(enumerable));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(503, 830, 1436);

                int
                f_503_1171_1185(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(503, 1171, 1185);
                    return return_v;
                }


                int
                f_503_1330_1343(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(503, 1330, 1343);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_503_1387_1413(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(503, 1387, 1413);
                    return return_v;
                }


                bool
                f_503_1387_1424(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(503, 1387, 1424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(503, 830, 1436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 830, 1436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool EnumerableIsEmpty<T>([NotNullWhen(returnValue: false)] IEnumerable<T>? enumerable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(503, 1569, 1750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 1695, 1739);

                return !f_503_1703_1738(enumerable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(503, 1569, 1750);

                bool
                f_503_1703_1738(System.Collections.Generic.IEnumerable<T>?
                enumerable)
                {
                    var return_v = EnumerableIsNotEmpty<T>(enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(503, 1703, 1738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(503, 1569, 1750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 1569, 1750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static uint EnumerableCount<T>(IEnumerable<T>? enumerable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(503, 1925, 2713);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2054, 2134) || true) && (enumerable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(503, 2054, 2134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2110, 2119);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(503, 2054, 2134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2150, 2188);

                var
                asIListT = enumerable as IList<T>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2202, 2299) || true) && (asIListT != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(503, 2202, 2299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2256, 2284);

                    return (uint)f_503_2269_2283(asIListT);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(503, 2202, 2299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2315, 2349);

                var
                asIList = enumerable as IList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2363, 2458) || true) && (asIList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(503, 2363, 2458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2416, 2443);

                    return (uint)f_503_2429_2442(asIList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(503, 2363, 2458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2474, 2490);

                uint
                result = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2504, 2559);

                IEnumerator<T>
                enumerator = f_503_2532_2558(enumerable)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2573, 2659) || true) && (f_503_2580_2601(enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(503, 2573, 2659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2635, 2644);

                        result++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(503, 2573, 2659);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(503, 2573, 2659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(503, 2573, 2659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 2675, 2702);

                return result & 0x7FFFFFFF;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(503, 1925, 2713);

                int
                f_503_2269_2283(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(503, 2269, 2283);
                    return return_v;
                }


                int
                f_503_2429_2442(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(503, 2429, 2442);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_503_2532_2558(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(503, 2532, 2558);
                    return return_v;
                }


                bool
                f_503_2580_2601(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(503, 2580, 2601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(503, 1925, 2713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 1925, 2713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IteratorHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(503, 641, 2720);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(503, 641, 2720);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 641, 2720);
        }

    }

    internal struct SecurityAttribute
    {

        public DeclarativeSecurityAction Action { get; }

        public ICustomAttribute Attribute { get; }

        public SecurityAttribute(DeclarativeSecurityAction action, ICustomAttribute attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(503, 3338, 3512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 3449, 3465);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 3479, 3501);

                Attribute = attribute;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(503, 3338, 3512);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(503, 3338, 3512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 3338, 3512);
            }
        }
        static SecurityAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(503, 3176, 3519);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(503, 3176, 3519);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 3176, 3519);
        }
    }

    /// <summary>
    /// Information about how values of managed types should be marshalled to and from unmanaged types.
    /// </summary>
    internal interface IMarshallingInformation
    {

        object GetCustomMarshaller(EmitContext context);

        string CustomMarshallerRuntimeArgument
        {
            get;
        }

        System.Runtime.InteropServices.UnmanagedType ElementType
        {
            get;
        }

        int IidParameterIndex
        {
            get;
        }

        System.Runtime.InteropServices.UnmanagedType UnmanagedType { get; }

        int NumberOfElements
        {
            get;
        }

        short ParamIndex
        {
            get;
        }

        VarEnum SafeArrayElementSubtype
        {
            get;
        }

        ITypeReference GetSafeArrayElementUserDefinedSubtype(EmitContext context);
    }

    /// <summary>
    /// Implemented by any entity that has a name.
    /// </summary>
    internal interface INamedEntity
    {

        string? Name { get; }
    }

    /// <summary>
    /// The name of the entity depends on other metadata (tokens, signatures) originated from
    /// PeWriter.
    /// </summary>
    internal interface IContextualNamedEntity : INamedEntity
    {

        void AssociateWithMetadataWriter(MetadataWriter metadataWriter);
    }

    /// <summary>
    /// Implemented by an entity that is always a member of a particular parameter list, such as an IParameterDefinition.
    /// Provides a way to determine the position where the entity appears in the parameter list.
    /// </summary>
    internal interface IParameterListEntry
    {

        ushort Index { get; }
    }

    /// <summary>
    /// Information that describes how a method from the underlying Platform is to be invoked.
    /// </summary>
    internal interface IPlatformInvokeInformation
    {

        string? ModuleName { get; }

        string? EntryPointName { get; }

        MethodImportAttributes Flags { get; }
    }
    internal class ResourceSection
    {
        internal ResourceSection(byte[] sectionBytes, uint[] relocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(503, 8718, 8998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 9035, 9047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 9213, 9224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 8808, 8849);

                f_503_8808_8848(sectionBytes != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 8863, 8903);

                f_503_8863_8902(relocations != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 8919, 8947);

                SectionBytes = sectionBytes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(503, 8961, 8987);

                Relocations = relocations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(503, 8718, 8998);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(503, 8718, 8998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 8718, 8998);
            }
        }

        internal readonly byte[] SectionBytes;

        internal readonly uint[] Relocations;

        static ResourceSection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(503, 8671, 9232);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(503, 8671, 9232);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(503, 8671, 9232);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(503, 8671, 9232);

        static int
        f_503_8808_8848(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(503, 8808, 8848);
            return 0;
        }


        static int
        f_503_8863_8902(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(503, 8863, 8902);
            return 0;
        }

    }

    /// <summary>
    /// A resource file formatted according to Win32 API conventions and typically obtained from a Portable Executable (PE) file.
    /// See the Win32 UpdateResource method for more details.
    /// </summary>
    internal interface IWin32Resource
    {

        string TypeName
        {
            get;
        }

        int TypeId
        {
            get;
        }

        string Name
        {
            get;
        }

        int Id { get; }

        uint LanguageId { get; }

        uint CodePage { get; }

        IEnumerable<byte> Data { get; }
    }
}
