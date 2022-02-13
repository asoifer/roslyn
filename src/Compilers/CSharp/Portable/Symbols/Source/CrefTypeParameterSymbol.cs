// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class CrefTypeParameterSymbol : TypeParameterSymbol
    {
        private readonly string _name;

        private readonly int _ordinal;

        private readonly SyntaxReference _declaringSyntax;

        public CrefTypeParameterSymbol(string name, int ordinal, IdentifierNameSyntax declaringSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10224, 3566, 3806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 3448, 3453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 3485, 3493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 3537, 3553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 3685, 3698);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 3712, 3731);

                _ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 3745, 3795);

                _declaringSyntax = f_10224_3764_3794(declaringSyntax);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10224, 3566, 3806);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 3566, 3806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 3566, 3806);
            }
        }

        public override TypeParameterKind TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 3894, 3975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 3930, 3960);

                    return TypeParameterKind.Cref;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 3894, 3975);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 3818, 3986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 3818, 3986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 4050, 4071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4056, 4069);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 4050, 4071);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 3998, 4082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 3998, 4082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 4146, 4170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4152, 4168);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 4146, 4170);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 4094, 4181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 4094, 4181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 4193, 4787);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4290, 4380) || true) && (f_10224_4294_4319(this, t2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10224, 4290, 4380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4353, 4365);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10224, 4290, 4380);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4396, 4480) || true) && ((object)t2 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10224, 4396, 4480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4452, 4465);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10224, 4396, 4480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4496, 4558);

                CrefTypeParameterSymbol
                other = t2 as CrefTypeParameterSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4572, 4776);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10224, 4579, 4641) && other._name == _name) && (DynAbs.Tracing.TraceSender.Expression_True(10224, 4579, 4688) && other._ordinal == _ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(10224, 4579, 4775) && f_10224_4709_4743(other._declaringSyntax) == f_10224_4747_4775(_declaringSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 4193, 4787);

                bool
                f_10224_4294_4319(Microsoft.CodeAnalysis.CSharp.Symbols.CrefTypeParameterSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 4294, 4319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10224_4709_4743(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 4709, 4743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10224_4747_4775(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 4747, 4775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 4193, 4787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 4193, 4787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 4799, 4905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4857, 4894);

                return f_10224_4864_4893(_name, _ordinal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 4799, 4905);

                int
                f_10224_4864_4893(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 4864, 4893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 4799, 4905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 4799, 4905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override VarianceKind Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 4979, 5012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 4985, 5010);

                    return VarianceKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 4979, 5012);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 4917, 5023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 4917, 5023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5103, 5124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5109, 5122);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5103, 5124);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5035, 5135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5035, 5135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5223, 5244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5229, 5242);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5223, 5244);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5147, 5255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5147, 5255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5339, 5360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5345, 5358);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5339, 5360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5267, 5371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5267, 5371);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5463, 5484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5469, 5482);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5463, 5484);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5383, 5495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5383, 5495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? ReferenceTypeConstraintIsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5589, 5610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5595, 5608);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5589, 5610);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5507, 5621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5507, 5621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5675, 5683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5678, 5683);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5675, 5683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5675, 5683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5675, 5683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5734, 5741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5737, 5741);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5734, 5741);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5734, 5741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5734, 5741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5826, 5847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5832, 5845);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5826, 5847);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5754, 5858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5754, 5858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 5940, 5961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 5946, 5959);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 5940, 5961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5870, 5972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5870, 5972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 6048, 6111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 6084, 6096);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 6048, 6111);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 5984, 6122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 5984, 6122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 6209, 6331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 6245, 6316);

                    return f_10224_6252_6315(f_10224_6284_6314(_declaringSyntax));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 6209, 6331);

                    Microsoft.CodeAnalysis.Location
                    f_10224_6284_6314(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 6284, 6314);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10224_6252_6315(Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = ImmutableArray.Create<Location>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 6252, 6315);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 6134, 6342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 6134, 6342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 6452, 6567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 6488, 6552);

                    return f_10224_6495_6551(_declaringSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 6452, 6567);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10224_6495_6551(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create<SyntaxReference>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 6495, 6551);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 6354, 6578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 6354, 6578);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void EnsureAllConstraintsAreResolved()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 6590, 6668);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 6590, 6668);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 6590, 6668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 6590, 6668);
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 6680, 6879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 6819, 6868);

                return ImmutableArray<TypeWithAnnotations>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 6680, 6879);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 6680, 6879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 6680, 6879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 6891, 7077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 7021, 7066);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 6891, 7077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 6891, 7077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 6891, 7077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 7089, 7347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 7299, 7336);

                throw f_10224_7305_7335();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 7089, 7347);

                System.Exception
                f_10224_7305_7335()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10224, 7305, 7335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 7089, 7347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 7089, 7347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 7359, 7609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 7561, 7598);

                throw f_10224_7567_7597();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 7359, 7609);

                System.Exception
                f_10224_7567_7597()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10224, 7567, 7597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 7359, 7609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 7359, 7609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10224, 7687, 7708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10224, 7693, 7706);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10224, 7687, 7708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10224, 7621, 7719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 7621, 7719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static CrefTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10224, 3340, 7726);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10224, 3340, 7726);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10224, 3340, 7726);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10224, 3340, 7726);

        Microsoft.CodeAnalysis.SyntaxReference
        f_10224_3764_3794(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10224, 3764, 3794);
            return return_v;
        }

    }
}
