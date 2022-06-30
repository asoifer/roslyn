// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.Cci
{

    internal struct UsedNamespaceOrType : IEquatable<UsedNamespaceOrType>
    {

        public readonly string? AliasOpt;

        public readonly IAssemblyReference? TargetAssemblyOpt;

        public readonly INamespace? TargetNamespaceOpt;

        public readonly ITypeReference? TargetTypeOpt;

        public readonly string? TargetXmlNamespaceOpt;

        private UsedNamespaceOrType(
                    string? alias = null,
                    IAssemblyReference? targetAssembly = null,
                    INamespace? targetNamespace = null,
                    ITypeReference? targetType = null,
                    string? targetXmlNamespace = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(523, 775, 1290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1064, 1081);

                AliasOpt = alias;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1095, 1130);

                TargetAssemblyOpt = targetAssembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1144, 1181);

                TargetNamespaceOpt = targetNamespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1195, 1222);

                TargetTypeOpt = targetType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1236, 1279);

                TargetXmlNamespaceOpt = targetXmlNamespace;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(523, 775, 1290);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 775, 1290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 775, 1290);
            }
        }

        internal static UsedNamespaceOrType CreateType(ITypeReference type, string? aliasOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 1302, 1543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1419, 1452);

                f_523_1419_1451(type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1466, 1532);

                return f_523_1473_1531(alias: aliasOpt, targetType: type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 1302, 1543);

                int
                f_523_1419_1451(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 1419, 1451);
                    return 0;
                }


                Microsoft.Cci.UsedNamespaceOrType
                f_523_1473_1531(string?
                alias, Microsoft.Cci.ITypeReference
                targetType)
                {
                    var return_v = new Microsoft.Cci.UsedNamespaceOrType(alias: alias, targetType: targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 1473, 1531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 1302, 1543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 1302, 1543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static UsedNamespaceOrType CreateNamespace(INamespace @namespace, IAssemblyReference? assemblyOpt = null, string? aliasOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 1555, 1889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1719, 1758);

                f_523_1719_1757(@namespace != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1772, 1878);

                return f_523_1779_1877(alias: aliasOpt, targetAssembly: assemblyOpt, targetNamespace: @namespace);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 1555, 1889);

                int
                f_523_1719_1757(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 1719, 1757);
                    return 0;
                }


                Microsoft.Cci.UsedNamespaceOrType
                f_523_1779_1877(string?
                alias, Microsoft.Cci.IAssemblyReference?
                targetAssembly, Microsoft.Cci.INamespace
                targetNamespace)
                {
                    var return_v = new Microsoft.Cci.UsedNamespaceOrType(alias: alias, targetAssembly: targetAssembly, targetNamespace: targetNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 1779, 1877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 1555, 1889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 1555, 1889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static UsedNamespaceOrType CreateExternAlias(string alias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 1901, 2097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 1993, 2027);

                f_523_1993_2026(alias != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 2041, 2086);

                return f_523_2048_2085(alias: alias);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 1901, 2097);

                int
                f_523_1993_2026(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 1993, 2026);
                    return 0;
                }


                Microsoft.Cci.UsedNamespaceOrType
                f_523_2048_2085(string
                alias)
                {
                    var return_v = new Microsoft.Cci.UsedNamespaceOrType(alias: alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 2048, 2085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 1901, 2097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 1901, 2097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static UsedNamespaceOrType CreateXmlNamespace(string prefix, string xmlNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 2109, 2419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 2224, 2265);

                f_523_2224_2264(xmlNamespace != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 2279, 2314);

                f_523_2279_2313(prefix != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 2328, 2408);

                return f_523_2335_2407(alias: prefix, targetXmlNamespace: xmlNamespace);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 2109, 2419);

                int
                f_523_2224_2264(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 2224, 2264);
                    return 0;
                }


                int
                f_523_2279_2313(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 2279, 2313);
                    return 0;
                }


                Microsoft.Cci.UsedNamespaceOrType
                f_523_2335_2407(string
                alias, string
                targetXmlNamespace)
                {
                    var return_v = new Microsoft.Cci.UsedNamespaceOrType(alias: alias, targetXmlNamespace: targetXmlNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 2335, 2407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 2109, 2419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 2109, 2419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(523, 2431, 2564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 2496, 2553);

                return obj is UsedNamespaceOrType other && (DynAbs.Tracing.TraceSender.Expression_True(523, 2503, 2552) && Equals(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(523, 2431, 2564);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 2431, 2564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 2431, 2564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(UsedNamespaceOrType other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(523, 2576, 2978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 2646, 2967);

                return AliasOpt == other.AliasOpt
                && (DynAbs.Tracing.TraceSender.Expression_True(523, 2653, 2757) && f_523_2700_2757(TargetAssemblyOpt, other.TargetAssemblyOpt)) && (DynAbs.Tracing.TraceSender.Expression_True(523, 2653, 2830) && Equals(TargetNamespaceOpt, other.TargetNamespaceOpt)) && (DynAbs.Tracing.TraceSender.Expression_True(523, 2653, 2893) && Equals(TargetTypeOpt, other.TargetTypeOpt)) && (DynAbs.Tracing.TraceSender.Expression_True(523, 2653, 2966) && TargetXmlNamespaceOpt == other.TargetXmlNamespaceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(523, 2576, 2978);

                bool
                f_523_2700_2757(Microsoft.Cci.IAssemblyReference?
                objA, Microsoft.Cci.IAssemblyReference?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 2700, 2757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 2576, 2978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 2576, 2978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(523, 2990, 3340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3048, 3329);

                return f_523_3055_3328(AliasOpt, f_523_3098_3327(TargetAssemblyOpt, f_523_3159_3326(GetHashCode(TargetNamespaceOpt), f_523_3225_3325(GetHashCode(TargetTypeOpt), f_523_3286_3324(TargetXmlNamespaceOpt, 0)))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(523, 2990, 3340);

                int
                f_523_3286_3324(string?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3286, 3324);
                    return return_v;
                }


                int
                f_523_3225_3325(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3225, 3325);
                    return return_v;
                }


                int
                f_523_3159_3326(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3159, 3326);
                    return return_v;
                }


                int
                f_523_3098_3327(Microsoft.Cci.IAssemblyReference?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine((object?)newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3098, 3327);
                    return return_v;
                }


                int
                f_523_3055_3328(string?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3055, 3328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 2990, 3340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 2990, 3340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Equals(ITypeReference? x, ITypeReference? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 3352, 4025);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3441, 3512) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 3441, 3512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3485, 3497);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 3441, 3512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3528, 3616) || true) && (x is null || (DynAbs.Tracing.TraceSender.Expression_False(523, 3532, 3554) || y is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 3528, 3616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3588, 3601);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 3528, 3616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3632, 3668);

                var
                xSymbol = f_523_3646_3667(x)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3682, 3718);

                var
                ySymbol = f_523_3696_3717(y)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3734, 3979) || true) && (xSymbol is object && (DynAbs.Tracing.TraceSender.Expression_True(523, 3738, 3776) && ySymbol is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 3734, 3979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3810, 3841);

                    return f_523_3817_3840(xSymbol, ySymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 3734, 3979);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 3734, 3979);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3875, 3979) || true) && (xSymbol is object || (DynAbs.Tracing.TraceSender.Expression_False(523, 3879, 3917) || ySymbol is object))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 3875, 3979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3951, 3964);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(523, 3875, 3979);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 3734, 3979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 3995, 4014);

                return f_523_4002_4013(x, y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 3352, 4025);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_523_3646_3667(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3646, 3667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_523_3696_3717(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3696, 3717);
                    return return_v;
                }


                bool
                f_523_3817_3840(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 3817, 3840);
                    return return_v;
                }


                bool
                f_523_4002_4013(Microsoft.Cci.ITypeReference
                this_param, Microsoft.Cci.ITypeReference
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4002, 4013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 3352, 4025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 3352, 4025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetHashCode(ITypeReference? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 4037, 4331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4113, 4154);

                var
                objSymbol = f_523_4129_4153_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obj, 523, 4129, 4153)?.GetInternalSymbol())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4170, 4273) || true) && (objSymbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 4170, 4273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4227, 4258);

                    return f_523_4234_4257(objSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 4170, 4273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4289, 4320);

                return f_523_4296_4314_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obj, 523, 4296, 4314)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(523, 4296, 4319) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 4037, 4331);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_523_4129_4153_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4129, 4153);
                    return return_v;
                }


                int
                f_523_4234_4257(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4234, 4257);
                    return return_v;
                }


                int?
                f_523_4296_4314_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4296, 4314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 4037, 4331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 4037, 4331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Equals(INamespace? x, INamespace? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 4343, 5008);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4424, 4495) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 4424, 4495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4468, 4480);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 4424, 4495);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4511, 4599) || true) && (x is null || (DynAbs.Tracing.TraceSender.Expression_False(523, 4515, 4537) || y is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 4511, 4599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4571, 4584);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 4511, 4599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4615, 4651);

                var
                xSymbol = f_523_4629_4650(x)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4665, 4701);

                var
                ySymbol = f_523_4679_4700(y)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4717, 4962) || true) && (xSymbol is object && (DynAbs.Tracing.TraceSender.Expression_True(523, 4721, 4759) && ySymbol is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 4717, 4962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4793, 4824);

                    return f_523_4800_4823(xSymbol, ySymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 4717, 4962);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 4717, 4962);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4858, 4962) || true) && (xSymbol is object || (DynAbs.Tracing.TraceSender.Expression_False(523, 4862, 4900) || ySymbol is object))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 4858, 4962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4934, 4947);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(523, 4858, 4962);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 4717, 4962);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 4978, 4997);

                return f_523_4985_4996(x, y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 4343, 5008);

                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                f_523_4629_4650(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4629, 4650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                f_523_4679_4700(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4679, 4700);
                    return return_v;
                }


                bool
                f_523_4800_4823(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                this_param, Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4800, 4823);
                    return return_v;
                }


                bool
                f_523_4985_4996(Microsoft.Cci.INamespace
                this_param, Microsoft.Cci.INamespace
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 4985, 4996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 4343, 5008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 4343, 5008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetHashCode(INamespace? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(523, 5020, 5310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 5092, 5133);

                var
                objSymbol = f_523_5108_5132_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obj, 523, 5108, 5132)?.GetInternalSymbol())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 5149, 5252) || true) && (objSymbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(523, 5149, 5252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 5206, 5237);

                    return f_523_5213_5236(objSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(523, 5149, 5252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(523, 5268, 5299);

                return f_523_5275_5293_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obj, 523, 5275, 5293)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(523, 5275, 5298) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(523, 5020, 5310);

                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                f_523_5108_5132_I(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 5108, 5132);
                    return return_v;
                }


                int
                f_523_5213_5236(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 5213, 5236);
                    return return_v;
                }


                int?
                f_523_5275_5293_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(523, 5275, 5293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(523, 5020, 5310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 5020, 5310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static UsedNamespaceOrType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(523, 411, 5317);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(523, 411, 5317);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(523, 411, 5317);
        }
    }
}
