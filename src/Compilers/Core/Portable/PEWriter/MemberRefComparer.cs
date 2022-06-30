// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal sealed class MemberRefComparer : IEqualityComparer<ITypeMemberReference>
    {
        private readonly MetadataWriter _metadataWriter;

        internal MemberRefComparer(MetadataWriter metadataWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(496, 500, 626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 472, 487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 582, 615);

                _metadataWriter = metadataWriter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(496, 500, 626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(496, 500, 626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(496, 500, 626);
            }
        }

        public bool Equals(ITypeMemberReference? x, ITypeMemberReference? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(496, 638, 1890);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 731, 802) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 731, 802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 775, 787);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(496, 731, 802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 816, 863);

                f_496_816_862(x is object && (DynAbs.Tracing.TraceSender.Expression_True(496, 835, 861) && y is object));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 879, 1192) || true) && (f_496_883_927(x, _metadataWriter.Context) != f_496_931_975(y, _metadataWriter.Context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 879, 1192);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1009, 1177) || true) && (f_496_1013_1056(_metadataWriter, x) != f_496_1060_1103(_metadataWriter, y))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 1009, 1177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1145, 1158);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(496, 1009, 1177);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(496, 879, 1192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1208, 1290) || true) && (f_496_1212_1218(x) != f_496_1222_1228(y))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 1208, 1290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1262, 1275);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(496, 1208, 1290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1306, 1336);

                var
                xf = x as IFieldReference
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1350, 1380);

                var
                yf = y as IFieldReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1394, 1567) || true) && (xf != null && (DynAbs.Tracing.TraceSender.Expression_True(496, 1398, 1422) && yf != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 1394, 1567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1456, 1552);

                    return f_496_1463_1505(_metadataWriter, xf) == f_496_1509_1551(_metadataWriter, yf);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(496, 1394, 1567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1583, 1614);

                var
                xm = x as IMethodReference
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1628, 1659);

                var
                ym = y as IMethodReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1673, 1850) || true) && (xm != null && (DynAbs.Tracing.TraceSender.Expression_True(496, 1677, 1701) && ym != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 1673, 1850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1735, 1835);

                    return f_496_1742_1786(_metadataWriter, xm) == f_496_1790_1834(_metadataWriter, ym);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(496, 1673, 1850);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1866, 1879);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(496, 638, 1890);

                int
                f_496_816_862(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 816, 862);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_496_883_927(Microsoft.Cci.ITypeMemberReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 883, 927);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_496_931_975(Microsoft.Cci.ITypeMemberReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 931, 975);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_496_1013_1056(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeMemberReference
                memberRef)
                {
                    var return_v = this_param.GetMemberReferenceParent(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 1013, 1056);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_496_1060_1103(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeMemberReference
                memberRef)
                {
                    var return_v = this_param.GetMemberReferenceParent(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 1060, 1103);
                    return return_v;
                }


                string?
                f_496_1212_1218(Microsoft.Cci.ITypeMemberReference
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(496, 1212, 1218);
                    return return_v;
                }


                string?
                f_496_1222_1228(Microsoft.Cci.ITypeMemberReference
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(496, 1222, 1228);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_496_1463_1505(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IFieldReference
                fieldReference)
                {
                    var return_v = this_param.GetFieldSignatureIndex(fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 1463, 1505);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_496_1509_1551(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IFieldReference
                fieldReference)
                {
                    var return_v = this_param.GetFieldSignatureIndex(fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 1509, 1551);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_496_1742_1786(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    var return_v = this_param.GetMethodSignatureHandle(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 1742, 1786);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_496_1790_1834(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    var return_v = this_param.GetMethodSignatureHandle(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 1790, 1834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(496, 638, 1890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(496, 638, 1890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(ITypeMemberReference memberRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(496, 1902, 2665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 1981, 2088);

                int
                hash = f_496_1992_2087(f_496_2005_2019(memberRef), f_496_2021_2072(_metadataWriter, memberRef).GetHashCode())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 2104, 2148);

                var
                fieldRef = memberRef as IFieldReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 2162, 2626) || true) && (fieldRef != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 2162, 2626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 2216, 2306);

                    hash = f_496_2223_2305(hash, f_496_2242_2290(_metadataWriter, fieldRef).GetHashCode());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(496, 2162, 2626);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 2162, 2626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 2372, 2418);

                    var
                    methodRef = memberRef as IMethodReference
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 2436, 2611) || true) && (methodRef != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(496, 2436, 2611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 2499, 2592);

                        hash = f_496_2506_2591(hash, f_496_2525_2576(_metadataWriter, methodRef).GetHashCode());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(496, 2436, 2611);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(496, 2162, 2626);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(496, 2642, 2654);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(496, 1902, 2665);

                string?
                f_496_2005_2019(Microsoft.Cci.ITypeMemberReference
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(496, 2005, 2019);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_496_2021_2072(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeMemberReference
                memberRef)
                {
                    var return_v = this_param.GetMemberReferenceParent(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 2021, 2072);
                    return return_v;
                }


                int
                f_496_1992_2087(string?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 1992, 2087);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_496_2242_2290(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IFieldReference
                fieldReference)
                {
                    var return_v = this_param.GetFieldSignatureIndex(fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 2242, 2290);
                    return return_v;
                }


                int
                f_496_2223_2305(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 2223, 2305);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_496_2525_2576(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    var return_v = this_param.GetMethodSignatureHandle(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 2525, 2576);
                    return return_v;
                }


                int
                f_496_2506_2591(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(496, 2506, 2591);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(496, 1902, 2665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(496, 1902, 2665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MemberRefComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(496, 342, 2672);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(496, 342, 2672);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(496, 342, 2672);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(496, 342, 2672);
    }
}
