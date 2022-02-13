// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SingleTypeDeclaration : SingleNamespaceOrTypeDeclaration
    {
        private readonly DeclarationKind _kind;

        private readonly TypeDeclarationFlags _flags;

        private readonly ushort _arity;

        private readonly DeclarationModifiers _modifiers;

        private readonly ImmutableArray<SingleTypeDeclaration> _children;

        [Flags]
        internal enum TypeDeclarationFlags : ushort
        {
            None = 0,
            AnyMemberHasExtensionMethodSyntax = 1 << 1,
            HasAnyAttributes = 1 << 2,
            HasBaseDeclarations = 1 << 3,
            AnyMemberHasAttributes = 1 << 4,
            HasAnyNontypeMembers = 1 << 5,

            /// <summary>
            /// Simple program uses await expressions. Set only for <see cref="DeclarationKind.SimpleProgram"/>
            /// </summary>
            HasAwaitExpressions = 1 << 6,

            /// <summary>
            /// Set only for <see cref="DeclarationKind.SimpleProgram"/>
            /// </summary>
            IsIterator = 1 << 7,

            /// <summary>
            /// Set only for <see cref="DeclarationKind.SimpleProgram"/>
            /// </summary>
            HasReturnWithExpression = 1 << 8,
        }

        internal SingleTypeDeclaration(
                    DeclarationKind kind,
                    string name,
                    int arity,
                    DeclarationModifiers modifiers,
                    TypeDeclarationFlags declFlags,
                    SyntaxReference syntaxReference,
                    SourceLocation nameLocation,
                    ImmutableHashSet<string> memberNames,
                    ImmutableArray<SingleTypeDeclaration> children,
                    ImmutableArray<Diagnostic> diagnostics)
        : base(f_10400_2142_2146_C(name), syntaxReference, nameLocation, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10400, 1662, 2486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 511, 516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 565, 571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 606, 612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 661, 671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 3102, 3154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2216, 2264);

                f_10400_2216_2263(kind != DeclarationKind.Namespace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2280, 2293);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2307, 2330);

                _arity = (ushort)arity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2344, 2367);

                _modifiers = modifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2381, 2407);

                MemberNames = memberNames;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2421, 2442);

                _children = children;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2456, 2475);

                _flags = declFlags;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10400, 1662, 2486);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 1662, 2486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 1662, 2486);
            }
        }

        public override DeclarationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 2559, 2623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2595, 2608);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 2559, 2623);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 2498, 2634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 2498, 2634);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new ImmutableArray<SingleTypeDeclaration> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 2728, 2796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2764, 2781);

                    return _children;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 2728, 2796);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 2646, 2807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 2646, 2807);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 2860, 2925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 2896, 2910);

                    return _arity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 2860, 2925);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 2819, 2936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 2819, 2936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DeclarationModifiers Modifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 3010, 3079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 3046, 3064);

                    return _modifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 3010, 3079);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 2948, 3090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 2948, 3090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableHashSet<string> MemberNames { get; }

        public bool AnyMemberHasExtensionMethodSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 3236, 3365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 3272, 3350);

                    return (_flags & TypeDeclarationFlags.AnyMemberHasExtensionMethodSyntax) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 3236, 3365);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 3166, 3376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 3166, 3376);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnyAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 3441, 3553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 3477, 3538);

                    return (_flags & TypeDeclarationFlags.HasAnyAttributes) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 3441, 3553);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 3388, 3564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 3388, 3564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasBaseDeclarations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 3632, 3747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 3668, 3732);

                    return (_flags & TypeDeclarationFlags.HasBaseDeclarations) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 3632, 3747);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 3576, 3758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 3576, 3758);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool AnyMemberHasAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 3829, 3947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 3865, 3932);

                    return (_flags & TypeDeclarationFlags.AnyMemberHasAttributes) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 3829, 3947);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 3770, 3958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 3770, 3958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnyNontypeMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 4027, 4143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 4063, 4128);

                    return (_flags & TypeDeclarationFlags.HasAnyNontypeMembers) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 4027, 4143);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 3970, 4154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 3970, 4154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAwaitExpressions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 4222, 4337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 4258, 4322);

                    return (_flags & TypeDeclarationFlags.HasAwaitExpressions) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 4222, 4337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 4166, 4348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 4166, 4348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasReturnWithExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 4420, 4539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 4456, 4524);

                    return (_flags & TypeDeclarationFlags.HasReturnWithExpression) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 4420, 4539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 4360, 4550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 4360, 4550);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 4609, 4715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 4645, 4700);

                    return (_flags & TypeDeclarationFlags.IsIterator) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 4609, 4715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 4562, 4726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 4562, 4726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<SingleNamespaceOrTypeDeclaration> GetNamespaceOrTypeDeclarationChildren()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 4738, 4949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 4870, 4938);

                return f_10400_4877_4937(_children);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 4738, 4949);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10400_4877_4937(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                from)
                {
                    var return_v = StaticCast<SingleNamespaceOrTypeDeclaration>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10400, 4877, 4937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 4738, 4949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 4738, 4949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeDeclarationIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 5027, 5119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 5063, 5104);

                    return f_10400_5070_5103(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 5027, 5119);

                    Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity
                    f_10400_5070_5103(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    decl)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity(decl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10400, 5070, 5103);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 4961, 5130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 4961, 5130);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal struct TypeDeclarationIdentity : IEquatable<TypeDeclarationIdentity>
        {

            private readonly SingleTypeDeclaration _decl;

            internal TypeDeclarationIdentity(SingleTypeDeclaration decl)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10400, 5425, 5546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 5518, 5531);

                    _decl = decl;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10400, 5425, 5546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 5425, 5546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 5425, 5546);
                }
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 5562, 5727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 5634, 5712);

                    return obj is TypeDeclarationIdentity && (DynAbs.Tracing.TraceSender.Expression_True(10400, 5641, 5711) && Equals(obj));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 5562, 5727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 5562, 5727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 5562, 5727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(TypeDeclarationIdentity other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 5743, 6664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 5825, 5846);

                    var
                    thisDecl = _decl
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 5864, 5892);

                    var
                    otherDecl = other._decl
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 5947, 6053) || true) && ((object)thisDecl == otherDecl)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10400, 5947, 6053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6022, 6034);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10400, 5947, 6053);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6122, 6355) || true) && ((thisDecl._arity != otherDecl._arity) || (DynAbs.Tracing.TraceSender.Expression_False(10400, 6126, 6223) || (thisDecl._kind != otherDecl._kind)) || (DynAbs.Tracing.TraceSender.Expression_False(10400, 6126, 6281) || (thisDecl.name != otherDecl.name)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10400, 6122, 6355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6323, 6336);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10400, 6122, 6355);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6375, 6617) || true) && (thisDecl._kind == DeclarationKind.Enum || (DynAbs.Tracing.TraceSender.Expression_False(10400, 6379, 6463) || thisDecl._kind == DeclarationKind.Delegate))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10400, 6375, 6617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6585, 6598);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10400, 6375, 6617);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6637, 6649);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 5743, 6664);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 5743, 6664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 5743, 6664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10400, 6680, 6955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6746, 6767);

                    var
                    thisDecl = _decl
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10400, 6785, 6940);

                    return f_10400_6792_6939(f_10400_6805_6832(f_10400_6805_6818(thisDecl)), f_10400_6855_6938(f_10400_6868_6896(f_10400_6868_6882(thisDecl)), f_10400_6924_6937(thisDecl)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10400, 6680, 6955);

                    string
                    f_10400_6805_6818(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10400, 6805, 6818);
                        return return_v;
                    }


                    int
                    f_10400_6805_6832(string
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10400, 6805, 6832);
                        return return_v;
                    }


                    int
                    f_10400_6868_6882(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10400, 6868, 6882);
                        return return_v;
                    }


                    int
                    f_10400_6868_6896(int
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10400, 6868, 6896);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.DeclarationKind
                    f_10400_6924_6937(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10400, 6924, 6937);
                        return return_v;
                    }


                    int
                    f_10400_6855_6938(int
                    newKey, Microsoft.CodeAnalysis.CSharp.DeclarationKind
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, (int)currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10400, 6855, 6938);
                        return return_v;
                    }


                    int
                    f_10400_6792_6939(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10400, 6792, 6939);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10400, 6680, 6955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 6680, 6955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static TypeDeclarationIdentity()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10400, 5262, 6966);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10400, 5262, 6966);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 5262, 6966);
            }
        }

        static SingleTypeDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10400, 383, 6973);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10400, 383, 6973);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10400, 383, 6973);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10400, 383, 6973);

        int
        f_10400_2216_2263(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10400, 2216, 2263);
            return 0;
        }


        static string
        f_10400_2142_2146_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10400, 1662, 2486);
            return return_v;
        }

    }
}
