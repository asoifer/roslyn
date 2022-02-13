// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class QuickAttributeChecker
    {
        private readonly Dictionary<string, QuickAttributes> _nameToAttributeMap;

        private static QuickAttributeChecker _lazyPredefinedQuickAttributeChecker;

        private bool _sealed;

        internal static QuickAttributeChecker Predefined
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10236, 1219, 1560);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1255, 1481) || true) && (_lazyPredefinedQuickAttributeChecker is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10236, 1255, 1481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1345, 1462);

                        f_10236_1345_1461(ref _lazyPredefinedQuickAttributeChecker, f_10236_1415_1454(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10236, 1255, 1481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1501, 1545);

                    return _lazyPredefinedQuickAttributeChecker;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10236, 1219, 1560);

                    Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                    f_10236_1415_1454()
                    {
                        var return_v = CreatePredefinedQuickAttributeChecker();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 1415, 1454);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker?
                    f_10236_1345_1461(ref Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 1345, 1461);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10236, 1146, 1571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 1146, 1571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static QuickAttributeChecker CreatePredefinedQuickAttributeChecker()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10236, 1583, 2047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1684, 1725);

                var
                result = f_10236_1697_1724()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1739, 1837);

                f_10236_1739_1836(result, AttributeDescription.TypeIdentifierAttribute.Name, QuickAttributes.TypeIdentifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1851, 1951);

                f_10236_1851_1950(result, AttributeDescription.TypeForwardedToAttribute.Name, QuickAttributes.TypeForwardedTo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1978, 2000);

                result._sealed = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2022, 2036);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10236, 1583, 2047);

                Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                f_10236_1697_1724()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 1697, 1724);
                    return return_v;
                }


                int
                f_10236_1739_1836(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                this_param, string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                newAttributes)
                {
                    this_param.AddName(name, newAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 1739, 1836);
                    return 0;
                }


                int
                f_10236_1851_1950(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                this_param, string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                newAttributes)
                {
                    this_param.AddName(name, newAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 1851, 1950);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10236, 1583, 2047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 1583, 2047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private QuickAttributeChecker()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10236, 2059, 2251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 978, 997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1118, 1125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2115, 2201);

                _nameToAttributeMap = f_10236_2137_2200(f_10236_2177_2199());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10236, 2059, 2251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10236, 2059, 2251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 2059, 2251);
            }
        }

        private QuickAttributeChecker(QuickAttributeChecker previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10236, 2263, 2515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 978, 997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1118, 1125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2349, 2465);

                _nameToAttributeMap = f_10236_2371_2464(previous._nameToAttributeMap, f_10236_2441_2463());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10236, 2263, 2515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10236, 2263, 2515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 2263, 2515);
            }
        }

        private void AddName(string name, QuickAttributes newAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10236, 2527, 2916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2627, 2650);

                f_10236_2627_2649(!_sealed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2672, 2712);

                var
                currentValue = QuickAttributes.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2726, 2782);

                f_10236_2726_2781(_nameToAttributeMap, name, out currentValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2798, 2854);

                QuickAttributes
                newValue = newAttributes | currentValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 2868, 2905);

                _nameToAttributeMap[name] = newValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10236, 2527, 2916);

                int
                f_10236_2627_2649(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 2627, 2649);
                    return 0;
                }


                bool
                f_10236_2726_2781(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 2726, 2781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10236, 2527, 2916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 2527, 2916);
            }
        }

        internal QuickAttributeChecker AddAliasesIfAny(SyntaxList<UsingDirectiveSyntax> usingsSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10236, 2928, 4103);
                Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes foundAttributes = default(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3046, 3134) || true) && (usingsSyntax.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10236, 3046, 3134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3107, 3119);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10236, 3046, 3134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3150, 3190);

                QuickAttributeChecker
                newChecker = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3206, 3896);
                    foreach (var usingDirective in f_10236_3237_3249_I(usingsSyntax))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10236, 3206, 3896);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3283, 3881) || true) && (f_10236_3287_3307(usingDirective) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10236, 3283, 3881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3357, 3418);

                            string
                            name = f_10236_3371_3396(f_10236_3371_3391(usingDirective)).Identifier.ValueText
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3440, 3518);

                            string
                            target = f_10236_3456_3496(f_10236_3456_3475(usingDirective)).Identifier.ValueText
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3542, 3862) || true) && (f_10236_3546_3610(_nameToAttributeMap, target, out foundAttributes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10236, 3542, 3862);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3745, 3839);

                                f_10236_3745_3838(                        // copy the QuickAttributes from alias target to alias name
                                                        (newChecker ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker?>(10236, 3746, 3806) ?? (newChecker = f_10236_3774_3805(this)))), name, foundAttributes);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10236, 3542, 3862);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10236, 3283, 3881);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10236, 3206, 3896);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10236, 1, 691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10236, 1, 691);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3912, 4064) || true) && (newChecker != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10236, 3912, 4064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 3979, 4005);

                    newChecker._sealed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4031, 4049);

                    return newChecker;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10236, 3912, 4064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4080, 4092);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10236, 2928, 4103);

                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10236_3287_3307(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10236, 3287, 3307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10236_3371_3391(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10236, 3371, 3391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10236_3371_3396(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10236, 3371, 3396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10236_3456_3475(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10236, 3456, 3475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10236_3456_3496(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.GetUnqualifiedName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 3456, 3496);
                    return return_v;
                }


                bool
                f_10236_3546_3610(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 3546, 3610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                f_10236_3774_3805(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                previous)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 3774, 3805);
                    return return_v;
                }


                int
                f_10236_3745_3838(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                this_param, string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                newAttributes)
                {
                    this_param.AddName(name, newAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 3745, 3838);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10236_3237_3249_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 3237, 3249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10236, 2928, 4103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 2928, 4103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsPossibleMatch(AttributeSyntax attr, QuickAttributes pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10236, 4115, 4740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4225, 4247);

                f_10236_4225_4246(_sealed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4269, 4335);

                string
                name = f_10236_4283_4313(f_10236_4283_4292(attr)).Identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4349, 4381);

                QuickAttributes
                foundAttributes
                = default(QuickAttributes);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4456, 4700) || true) && (f_10236_4460_4518(_nameToAttributeMap, name, out foundAttributes) || (DynAbs.Tracing.TraceSender.Expression_False(10236, 4460, 4611) || f_10236_4539_4611(_nameToAttributeMap, name + "Attribute", out foundAttributes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10236, 4456, 4700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4645, 4685);

                    return (foundAttributes & pattern) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10236, 4456, 4700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 4716, 4729);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10236, 4115, 4740);

                int
                f_10236_4225_4246(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 4225, 4246);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10236_4283_4292(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10236, 4283, 4292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10236_4283_4313(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.GetUnqualifiedName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 4283, 4313);
                    return return_v;
                }


                bool
                f_10236_4460_4518(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 4460, 4518);
                    return return_v;
                }


                bool
                f_10236_4539_4611(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 4539, 4611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10236, 4115, 4740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 4115, 4740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static QuickAttributeChecker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10236, 865, 4747);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10236, 1045, 1081);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10236, 865, 4747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10236, 865, 4747);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10236, 865, 4747);

        System.StringComparer
        f_10236_2177_2199()
        {
            var return_v = StringComparer.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10236, 2177, 2199);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>
        f_10236_2137_2200(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 2137, 2200);
            return return_v;
        }


        System.StringComparer
        f_10236_2441_2463()
        {
            var return_v = StringComparer.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10236, 2441, 2463);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>
        f_10236_2371_2464(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>
        dictionary, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>((System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes>)dictionary, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10236, 2371, 2464);
            return return_v;
        }

    }

    [Flags]
    internal enum QuickAttributes : byte
    {
        None = 0,
        TypeIdentifier = 1 << 0,
        TypeForwardedTo = 2 << 0
    }
}
