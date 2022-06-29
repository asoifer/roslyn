// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;


// Contains support for pseudo-methods on multidimensional arrays.
//
// Opcodes such as newarr, ldelem, ldelema, stelem do not work with
// multidimensional arrays and same functionality is available in
// a form of well known pseudo-methods "Get", "Set", "Address" and ".ctor"
//
//=========================
//
//  14.2 Arrays  (From partition II) -
//The class that the VES creates for arrays contains several methods whose implementation is supplied by the
//VES:
//
//* A constructor that takes a sequence of int32 arguments, one for each dimension of the array, that specify
//the number of elements in each dimension beginning with the first dimension. A lower bound of zero is
//assumed.
//
//* A constructor that takes twice as many int32 arguments as there are dimensions of the array. These
//arguments occur in pairs—one pair per dimension—with the first argument of each pair specifying the
//lower bound for that dimension, and the second argument specifying the total number of elements in that
//dimension. Note that vectors are not created with this constructor, since a zero lower bound is assumed for
//vectors.
//
//* A Get method that takes a sequence of int32 arguments, one for each dimension of the array, and returns
//a value whose type is the element type of the array. This method is used to access a specific element of the
//array where the arguments specify the index into each dimension, beginning with the first, of the element
//to be returned.
//
//* A Set method that takes a sequence of int32 arguments, one for each dimension of the array, followed by
//a value whose type is the element type of the array. The return type of Set is void. This method is used to
//set a specific element of the array where the arguments specify the index into each dimension, beginning
//with the first, of the element to be set and the final argument specifies the value to be stored into the target
//element.
//
//* An Address method that takes a sequence of int32 arguments, one for each dimension of the array, and
//has a return type that is a managed pointer to the array's element type. This method is used to return a
//managed pointer to a specific element of the array where the arguments specify the index into each
//dimension, beginning with the first, of the element whose address is to be returned.

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal class ArrayMethods
    {        // There are four kinds of array pseudo-methods
        // They are specific to a given array type
        private enum ArrayMethodKind : byte
        {
            GET,
            SET,
            ADDRESS,
            CTOR,
        }

        public ArrayMethod GetArrayConstructor(Cci.IArrayTypeReference arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 3538, 3702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 3636, 3691);

                return f_48_3643_3690(this, arrayType, ArrayMethodKind.CTOR);
                DynAbs.Tracing.TraceSender.TraceExitMethod(48, 3538, 3702);

                Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                f_48_3643_3690(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayMethodKind
                id)
                {
                    var return_v = this_param.GetArrayMethod(arrayType, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 3643, 3690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 3538, 3702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 3538, 3702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ArrayMethod GetArrayGet(Cci.IArrayTypeReference arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 3910, 3959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 3913, 3959);
                return f_48_3913_3959(this, arrayType, ArrayMethodKind.GET); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 3910, 3959);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 3910, 3959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 3910, 3959);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CodeGen.ArrayMethod
            f_48_3913_3959(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
            this_param, Microsoft.Cci.IArrayTypeReference
            arrayType, Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayMethodKind
            id)
            {
                var return_v = this_param.GetArrayMethod(arrayType, id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 3913, 3959);
                return return_v;
            }

        }

        public ArrayMethod GetArraySet(Cci.IArrayTypeReference arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 4168, 4217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 4171, 4217);
                return f_48_4171_4217(this, arrayType, ArrayMethodKind.SET); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 4168, 4217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 4168, 4217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 4168, 4217);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CodeGen.ArrayMethod
            f_48_4171_4217(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
            this_param, Microsoft.Cci.IArrayTypeReference
            arrayType, Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayMethodKind
            id)
            {
                var return_v = this_param.GetArrayMethod(arrayType, id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 4171, 4217);
                return return_v;
            }

        }

        public ArrayMethod GetArrayAddress(Cci.IArrayTypeReference arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 4434, 4487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 4437, 4487);
                return f_48_4437_4487(this, arrayType, ArrayMethodKind.ADDRESS); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 4434, 4487);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 4434, 4487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 4434, 4487);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CodeGen.ArrayMethod
            f_48_4437_4487(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
            this_param, Microsoft.Cci.IArrayTypeReference
            arrayType, Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayMethodKind
            id)
            {
                var return_v = this_param.GetArrayMethod(arrayType, id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 4437, 4487);
                return return_v;
            }

        }

        private readonly ConcurrentDictionary<(byte methodKind, IReferenceOrISignature arrayType), ArrayMethod> _dict;

        private ArrayMethod GetArrayMethod(Cci.IArrayTypeReference arrayType, ArrayMethodKind id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 4945, 5422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5059, 5119);

                var
                key = ((byte)id, f_48_5080_5117(arrayType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5133, 5153);

                ArrayMethod?
                result
                = default(ArrayMethod?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5169, 5186);

                var
                dict = _dict
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5200, 5381) || true) && (!f_48_5205_5238(dict, key, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 5200, 5381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5272, 5312);

                    result = f_48_5281_5311(arrayType, id);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5330, 5366);

                    result = f_48_5339_5365(dict, key, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(48, 5200, 5381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5397, 5411);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(48, 4945, 5422);

                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_48_5080_5117(Microsoft.Cci.IArrayTypeReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature((Microsoft.Cci.IReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5080, 5117);
                    return return_v;
                }


                bool
                f_48_5205_5238(System.Collections.Concurrent.ConcurrentDictionary<(byte methodKind, Microsoft.CodeAnalysis.IReferenceOrISignature arrayType), Microsoft.CodeAnalysis.CodeGen.ArrayMethod>
                this_param, (byte, Microsoft.CodeAnalysis.IReferenceOrISignature)
                key, out Microsoft.CodeAnalysis.CodeGen.ArrayMethod?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5205, 5238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                f_48_5281_5311(Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayMethodKind
                id)
                {
                    var return_v = MakeArrayMethod(arrayType, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5281, 5311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                f_48_5339_5365(System.Collections.Concurrent.ConcurrentDictionary<(byte methodKind, Microsoft.CodeAnalysis.IReferenceOrISignature arrayType), Microsoft.CodeAnalysis.CodeGen.ArrayMethod>
                this_param, (byte, Microsoft.CodeAnalysis.IReferenceOrISignature)
                key, Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5339, 5365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 4945, 5422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 4945, 5422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ArrayMethod MakeArrayMethod(Cci.IArrayTypeReference arrayType, ArrayMethodKind id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(48, 5434, 6076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5556, 6004);

                switch (id)
                {

                    case ArrayMethodKind.CTOR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 5556, 6004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5648, 5687);

                        return f_48_5655_5686(arrayType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 5556, 6004);

                    case ArrayMethodKind.GET:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 5556, 6004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5754, 5785);

                        return f_48_5761_5784(arrayType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 5556, 6004);

                    case ArrayMethodKind.SET:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 5556, 6004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5852, 5883);

                        return f_48_5859_5882(arrayType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 5556, 6004);

                    case ArrayMethodKind.ADDRESS:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 5556, 6004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 5954, 5989);

                        return f_48_5961_5988(arrayType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 5556, 6004);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 6020, 6065);

                throw f_48_6026_6064(id);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(48, 5434, 6076);

                Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayConstructor
                f_48_5655_5686(Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayConstructor(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5655, 5686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayGet
                f_48_5761_5784(Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayGet(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5761, 5784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArraySet
                f_48_5859_5882(Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArraySet(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5859, 5882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayAddress
                f_48_5961_5988(Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayAddress(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 5961, 5988);
                    return return_v;
                }


                System.Exception
                f_48_6026_6064(Microsoft.CodeAnalysis.CodeGen.ArrayMethods.ArrayMethodKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 6026, 6064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 5434, 6076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 5434, 6076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ArrayConstructor : ArrayMethod
        {
            public ArrayConstructor(Cci.IArrayTypeReference arrayType) : base(f_48_6413_6422_C(arrayType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 6347, 6427);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 6347, 6427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 6347, 6427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 6347, 6427);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 6471, 6481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 6474, 6481);
                        return ".ctor"; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 6471, 6481);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 6471, 6481);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 6471, 6481);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Cci.ITypeReference GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 6579, 6650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 6582, 6650);
                    return f_48_6582_6650(context.Module, Cci.PlatformType.SystemVoid, context); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 6579, 6650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 6579, 6650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 6579, 6650);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.Cci.ITypeReference
                f_48_6582_6650(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.Cci.PlatformType
                platformType, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetPlatformType(platformType, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 6582, 6650);
                    return return_v;
                }

            }

            static ArrayConstructor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 6271, 6662);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 6271, 6662);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 6271, 6662);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 6271, 6662);

            static Microsoft.Cci.IArrayTypeReference
            f_48_6413_6422_C(Microsoft.Cci.IArrayTypeReference
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(48, 6347, 6427);
                return return_v;
            }

        }
        private sealed class ArrayGet : ArrayMethod
        {
            public ArrayGet(Cci.IArrayTypeReference arrayType) : base(f_48_6971_6980_C(arrayType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 6913, 6985);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 6913, 6985);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 6913, 6985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 6913, 6985);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 7029, 7037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 7032, 7037);
                        return "Get"; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 7029, 7037);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 7029, 7037);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7029, 7037);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Cci.ITypeReference GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 7135, 7171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 7138, 7171);
                    return f_48_7138_7171(arrayType, context); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 7135, 7171);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 7135, 7171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7135, 7171);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.Cci.ITypeReference
                f_48_7138_7171(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 7138, 7171);
                    return return_v;
                }

            }

            static ArrayGet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 6845, 7183);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 6845, 7183);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 6845, 7183);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 6845, 7183);

            static Microsoft.Cci.IArrayTypeReference
            f_48_6971_6980_C(Microsoft.Cci.IArrayTypeReference
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(48, 6913, 6985);
                return return_v;
            }

        }
        private sealed class ArrayAddress : ArrayMethod
        {
            public ArrayAddress(Cci.IArrayTypeReference arrayType) : base(f_48_7505_7514_C(arrayType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 7443, 7519);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 7443, 7519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 7443, 7519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7443, 7519);
                }
            }

            public override bool ReturnValueIsByRef
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 7575, 7582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 7578, 7582);
                        return true; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 7575, 7582);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 7575, 7582);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7575, 7582);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Cci.ITypeReference GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 7680, 7716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 7683, 7716);
                    return f_48_7683_7716(arrayType, context); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 7680, 7716);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 7680, 7716);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7680, 7716);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.Cci.ITypeReference
                f_48_7683_7716(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 7683, 7716);
                    return return_v;
                }

            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 7761, 7773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 7764, 7773);
                        return "Address"; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 7761, 7773);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 7761, 7773);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7761, 7773);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ArrayAddress()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 7371, 7785);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 7371, 7785);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7371, 7785);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 7371, 7785);

            static Microsoft.Cci.IArrayTypeReference
            f_48_7505_7514_C(Microsoft.Cci.IArrayTypeReference
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(48, 7443, 7519);
                return return_v;
            }

        }
        private sealed class ArraySet : ArrayMethod
        {
            public ArraySet(Cci.IArrayTypeReference arrayType) : base(f_48_8094_8103_C(arrayType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 8036, 8108);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 8036, 8108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 8036, 8108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 8036, 8108);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 8152, 8160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8155, 8160);
                        return "Set"; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 8152, 8160);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 8152, 8160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 8152, 8160);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Cci.ITypeReference GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 8258, 8329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8261, 8329);
                    return f_48_8261_8329(context.Module, Cci.PlatformType.SystemVoid, context); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 8258, 8329);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 8258, 8329);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 8258, 8329);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.Cci.ITypeReference
                f_48_8261_8329(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.Cci.PlatformType
                platformType, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetPlatformType(platformType, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 8261, 8329);
                    return return_v;
                }

            }

            protected override ImmutableArray<ArrayMethodParameterInfo> MakeParameters()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 8346, 8926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8455, 8486);

                    int
                    rank = (int)f_48_8471_8485(arrayType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8504, 8582);

                    var
                    parameters = f_48_8521_8581(rank + 1)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8611, 8616);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8602, 8762) || true) && (i < rank)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8628, 8631)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(48, 8602, 8762))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 8602, 8762);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8673, 8743);

                            f_48_8673_8742(parameters, f_48_8688_8741(i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(48, 1, 161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(48, 1, 161);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8782, 8854);

                    f_48_8782_8853(
                                    parameters, f_48_8797_8852((ushort)rank, arrayType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 8872, 8911);

                    return f_48_8879_8910(parameters);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(48, 8346, 8926);

                    int
                    f_48_8471_8485(Microsoft.Cci.IArrayTypeReference
                    this_param)
                    {
                        var return_v = this_param.Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(48, 8471, 8485);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                    f_48_8521_8581(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<ArrayMethodParameterInfo>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 8521, 8581);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
                    f_48_8688_8741(int
                    index)
                    {
                        var return_v = ArrayMethodParameterInfo.GetIndexParameter((ushort)index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 8688, 8741);
                        return return_v;
                    }


                    int
                    f_48_8673_8742(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                    this_param, Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 8673, 8742);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ArraySetValueParameterInfo
                    f_48_8797_8852(int
                    index, Microsoft.Cci.IArrayTypeReference
                    arrayType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ArraySetValueParameterInfo((ushort)index, arrayType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 8797, 8852);
                        return return_v;
                    }


                    int
                    f_48_8782_8853(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                    this_param, Microsoft.CodeAnalysis.CodeGen.ArraySetValueParameterInfo
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 8782, 8853);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                    f_48_8879_8910(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 8879, 8910);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 8346, 8926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 8346, 8926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ArraySet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 7968, 8937);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 7968, 8937);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 7968, 8937);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 7968, 8937);

            static Microsoft.Cci.IArrayTypeReference
            f_48_8094_8103_C(Microsoft.Cci.IArrayTypeReference
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(48, 8036, 8108);
                return return_v;
            }

        }

        public ArrayMethods()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 3126, 8944);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 4734, 4826);
            this._dict = f_48_4755_4826(); DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 3126, 8944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 3126, 8944);
        }


        static ArrayMethods()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 3126, 8944);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 3126, 8944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 3126, 8944);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 3126, 8944);

        System.Collections.Concurrent.ConcurrentDictionary<(byte, Microsoft.CodeAnalysis.IReferenceOrISignature), Microsoft.CodeAnalysis.CodeGen.ArrayMethod>
        f_48_4755_4826()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<(byte, Microsoft.CodeAnalysis.IReferenceOrISignature), Microsoft.CodeAnalysis.CodeGen.ArrayMethod>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 4755, 4826);
            return return_v;
        }

    }
    internal class ArrayMethodParameterInfo : Cci.IParameterTypeInformation
    {
        private readonly ushort _index;

        private static readonly ArrayMethodParameterInfo s_index0;

        private static readonly ArrayMethodParameterInfo s_index1;

        private static readonly ArrayMethodParameterInfo s_index2;

        private static readonly ArrayMethodParameterInfo s_index3;

        protected ArrayMethodParameterInfo(ushort index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 9932, 10031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 9387, 9393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10005, 10020);

                _index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 9932, 10031);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 9932, 10031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 9932, 10031);
            }
        }

        public static ArrayMethodParameterInfo GetIndexParameter(ushort index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(48, 10043, 10420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10138, 10350);

                switch (index)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 10138, 10350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10193, 10209);

                        return s_index0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 10138, 10350);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 10138, 10350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10235, 10251);

                        return s_index1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 10138, 10350);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 10138, 10350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10277, 10293);

                        return s_index2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 10138, 10350);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 10138, 10350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10319, 10335);

                        return s_index3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(48, 10138, 10350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10366, 10409);

                return f_48_10373_10408(index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(48, 10043, 10420);

                Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
                f_48_10373_10408(ushort
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 10373, 10408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 10043, 10420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 10043, 10420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Cci.ICustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 10507, 10551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10510, 10551);
                    return ImmutableArray<Cci.ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 10507, 10551);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 10507, 10551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 10507, 10551);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.ICustomModifier> CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 10636, 10680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10639, 10680);
                    return ImmutableArray<Cci.ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 10636, 10680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 10636, 10680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 10636, 10680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsByReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 10719, 10727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10722, 10727);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 10719, 10727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 10719, 10727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 10719, 10727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual Cci.ITypeReference GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 10816, 10888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10819, 10888);
                return f_48_10819_10888(context.Module, Cci.PlatformType.SystemInt32, context); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 10816, 10888);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 10816, 10888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 10816, 10888);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.Cci.ITypeReference
            f_48_10819_10888(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
            this_param, Microsoft.Cci.PlatformType
            platformType, Microsoft.CodeAnalysis.Emit.EmitContext
            context)
            {
                var return_v = this_param.GetPlatformType(platformType, context);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 10819, 10888);
                return return_v;
            }

        }

        public ushort Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 10921, 10930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 10924, 10930);
                    return _index; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 10921, 10930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 10921, 10930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 10921, 10930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ArrayMethodParameterInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 9237, 10938);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 9571, 9613);
            s_index0 = f_48_9582_9613(0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 9673, 9715);
            s_index1 = f_48_9684_9715(1); DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 9775, 9817);
            s_index2 = f_48_9786_9817(2); DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 9877, 9919);
            s_index3 = f_48_9888_9919(3); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 9237, 10938);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 9237, 10938);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 9237, 10938);

        static Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
        f_48_9582_9613(int
        index)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo((ushort)index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 9582, 9613);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
        f_48_9684_9715(int
        index)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo((ushort)index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 9684, 9715);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
        f_48_9786_9817(int
        index)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo((ushort)index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 9786, 9817);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
        f_48_9888_9919(int
        index)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo((ushort)index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 9888, 9919);
            return return_v;
        }

    }
    internal sealed class ArraySetValueParameterInfo : ArrayMethodParameterInfo
    {
        private readonly Cci.IArrayTypeReference _arrayType;

        internal ArraySetValueParameterInfo(ushort index, Cci.IArrayTypeReference arrayType)
        : base(f_48_11438_11443_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 11333, 11503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 11310, 11320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 11469, 11492);

                _arrayType = arrayType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 11333, 11503);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 11333, 11503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 11333, 11503);
            }
        }

        public override Cci.ITypeReference GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 11592, 11629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 11595, 11629);
                return f_48_11595_11629(_arrayType, context); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 11592, 11629);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 11592, 11629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 11592, 11629);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.Cci.ITypeReference
            f_48_11595_11629(Microsoft.Cci.IArrayTypeReference
            this_param, Microsoft.CodeAnalysis.Emit.EmitContext
            context)
            {
                var return_v = this_param.GetElementType(context);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 11595, 11629);
                return return_v;
            }

        }

        static ArraySetValueParameterInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 11177, 11637);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 11177, 11637);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 11177, 11637);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 11177, 11637);

        static ushort
        f_48_11438_11443_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(48, 11333, 11503);
            return return_v;
        }

    }
    internal abstract class ArrayMethod : Cci.IMethodReference
    {
        private readonly ImmutableArray<ArrayMethodParameterInfo> _parameters;

        protected readonly Cci.IArrayTypeReference arrayType;

        protected ArrayMethod(Cci.IArrayTypeReference arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(48, 11967, 12131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 11945, 11954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12048, 12075);

                this.arrayType = arrayType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12089, 12120);

                _parameters = f_48_12103_12119(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(48, 11967, 12131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 11967, 12131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 11967, 12131);
            }
        }

        public abstract string Name { get; }

        public abstract Cci.ITypeReference GetType(EmitContext context);

        public virtual bool ReturnValueIsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 12349, 12357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12352, 12357);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 12349, 12357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 12349, 12357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 12349, 12357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual ImmutableArray<ArrayMethodParameterInfo> MakeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 12431, 12880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12531, 12562);

                int
                rank = (int)f_48_12547_12561(arrayType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12576, 12650);

                var
                parameters = f_48_12593_12649(rank)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12675, 12680);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12666, 12814) || true) && (i < rank)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12692, 12695)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(48, 12666, 12814))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(48, 12666, 12814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12729, 12799);

                        f_48_12729_12798(parameters, f_48_12744_12797(i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(48, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(48, 1, 149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12830, 12869);

                return f_48_12837_12868(parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(48, 12431, 12880);

                int
                f_48_12547_12561(Microsoft.Cci.IArrayTypeReference
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(48, 12547, 12561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                f_48_12593_12649(int
                capacity)
                {
                    var return_v = ArrayBuilder<ArrayMethodParameterInfo>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 12593, 12649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
                f_48_12744_12797(int
                index)
                {
                    var return_v = ArrayMethodParameterInfo.GetIndexParameter((ushort)index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 12744, 12797);
                    return return_v;
                }


                int
                f_48_12729_12798(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                this_param, Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 12729, 12798);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                f_48_12837_12868(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 12837, 12868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 12431, 12880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 12431, 12880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Cci.IParameterTypeInformation> GetParameters(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 12993, 13055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 12996, 13055);
                return f_48_12996_13055(_parameters); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 12993, 13055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 12993, 13055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 12993, 13055);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
            f_48_12996_13055(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
            from)
            {
                var return_v = StaticCast<Cci.IParameterTypeInformation>.From(from);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 12996, 13055);
                return return_v;
            }

        }

        public bool AcceptsExtraArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13102, 13110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13105, 13110);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13102, 13110);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13102, 13110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13102, 13110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13159, 13163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13162, 13163);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13159, 13163);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13159, 13163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13159, 13163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13198, 13206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13201, 13206);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13198, 13206);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13198, 13206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13198, 13206);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IMethodDefinition? GetResolvedMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13288, 13295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13291, 13295);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13288, 13295);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13288, 13295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13288, 13295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Cci.IParameterTypeInformation> ExtraParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13390, 13444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13393, 13444);
                    return ImmutableArray<Cci.IParameterTypeInformation>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13390, 13444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13390, 13444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13390, 13444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IGenericMethodInstanceReference? AsGenericMethodInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13534, 13541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13537, 13541);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13534, 13541);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13534, 13541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13534, 13541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ISpecializedMethodReference? AsSpecializedMethodReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13623, 13630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13626, 13630);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13623, 13630);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13623, 13630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13623, 13630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13690, 13722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13693, 13722);
                    return Cci.CallingConvention.HasThis; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13690, 13722);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13690, 13722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13690, 13722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13764, 13793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13767, 13793);
                    return (ushort)_parameters.Length; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13764, 13793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13764, 13793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13764, 13793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.ICustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 13881, 13925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 13884, 13925);
                    return ImmutableArray<Cci.ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 13881, 13925);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 13881, 13925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 13881, 13925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.ICustomModifier> ReturnValueCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14021, 14065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 14024, 14065);
                    return ImmutableArray<Cci.ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14021, 14065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14021, 14065);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14021, 14065);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeReference GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14078, 14338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 14305, 14327);

                return this.arrayType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14078, 14338);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14078, 14338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14078, 14338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<Cci.ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14439, 14504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 14442, 14504);
                return f_48_14442_14504(); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14439, 14504);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14439, 14504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14439, 14504);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
            f_48_14442_14504()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 14442, 14504);
                return return_v;
            }

        }

        public void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14580, 14602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 14583, 14602);
                f_48_14583_14602(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14580, 14602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14580, 14602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14580, 14602);
            }

            int
            f_48_14583_14602(Microsoft.Cci.MetadataVisitor
            this_param, Microsoft.CodeAnalysis.CodeGen.ArrayMethod
            methodReference)
            {
                this_param.Visit((Microsoft.Cci.IMethodReference)methodReference);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 14583, 14602);
                return 0;
            }

        }

        public Cci.IDefinition? AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14686, 14693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 14689, 14693);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14686, 14693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14686, 14693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14686, 14693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14753, 14833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 14756, 14833);
                return f_48_14756_14820(((object?)f_48_14766_14795(arrayType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(48, 14757, 14808) ?? arrayType))) + "." + f_48_14829_14833(); DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14753, 14833);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14753, 14833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14753, 14833);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
            f_48_14766_14795(Microsoft.Cci.IArrayTypeReference
            this_param)
            {
                var return_v = this_param.GetInternalSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 14766, 14795);
                return return_v;
            }


            string?
            f_48_14756_14820(object
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 14756, 14820);
                return return_v;
            }


            string
            f_48_14829_14833()
            {
                var return_v = Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(48, 14829, 14833);
                return return_v;
            }

        }

        Symbols.ISymbolInternal? Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14906, 14913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 14909, 14913);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14906, 14913);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14906, 14913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14906, 14913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 14926, 15206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 15141, 15195);

                throw f_48_15147_15194();
                DynAbs.Tracing.TraceSender.TraceExitMethod(48, 14926, 15206);

                System.Exception
                f_48_15147_15194()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(48, 15147, 15194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 14926, 15206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 14926, 15206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(48, 15218, 15491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(48, 15426, 15480);

                throw f_48_15432_15479();
                DynAbs.Tracing.TraceSender.TraceExitMethod(48, 15218, 15491);

                System.Exception
                f_48_15432_15479()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(48, 15432, 15479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(48, 15218, 15491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 15218, 15491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArrayMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(48, 11747, 15498);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(48, 11747, 15498);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(48, 11747, 15498);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(48, 11747, 15498);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ArrayMethodParameterInfo>
        f_48_12103_12119(Microsoft.CodeAnalysis.CodeGen.ArrayMethod
        this_param)
        {
            var return_v = this_param.MakeParameters();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(48, 12103, 12119);
            return return_v;
        }

    }
}
