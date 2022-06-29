// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal partial class IdentifierCollection
    {
        private readonly Dictionary<string, object> _map;

        public IdentifierCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(104, 1325, 1376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1227, 1312);
                this._map = f_104_1234_1312(f_104_1279_1311()); DynAbs.Tracing.TraceSender.TraceExitConstructor(104, 1325, 1376);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 1325, 1376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 1325, 1376);
            }
        }

        public IdentifierCollection(IEnumerable<string> identifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(104, 1388, 1517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1227, 1312);
                this._map = f_104_1234_1312(f_104_1279_1311()); DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1473, 1506);

                f_104_1473_1505(this, identifiers);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(104, 1388, 1517);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 1388, 1517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 1388, 1517);
            }
        }

        public void AddIdentifiers(IEnumerable<string> identifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 1529, 1737);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1613, 1726);
                    foreach (var identifier in f_104_1640_1651_I(identifiers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 1613, 1726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1685, 1711);

                        f_104_1685_1710(this, identifier);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(104, 1613, 1726);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(104, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(104, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 1529, 1737);

                int
                f_104_1685_1710(Microsoft.CodeAnalysis.IdentifierCollection
                this_param, string
                identifier)
                {
                    this_param.AddIdentifier(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 1685, 1710);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_104_1640_1651_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 1640, 1651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 1529, 1737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 1529, 1737);
            }
        }

        public void AddIdentifier(string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 1749, 2143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1818, 1857);

                f_104_1818_1856(identifier != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1873, 1887);

                object?
                value
                = default(object?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1901, 2132) || true) && (!f_104_1906_1945(_map, identifier, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 1901, 2132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 1979, 2010);

                    f_104_1979_2009(this, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(104, 1901, 2132);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 1901, 2132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 2076, 2117);

                    f_104_2076_2116(this, identifier, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(104, 1901, 2132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 1749, 2143);

                int
                f_104_1818_1856(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 1818, 1856);
                    return 0;
                }


                bool
                f_104_1906_1945(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, out object?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 1906, 1945);
                    return return_v;
                }


                int
                f_104_1979_2009(Microsoft.CodeAnalysis.IdentifierCollection
                this_param, string
                identifier)
                {
                    this_param.AddInitialSpelling(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 1979, 2009);
                    return 0;
                }


                int
                f_104_2076_2116(Microsoft.CodeAnalysis.IdentifierCollection
                this_param, string
                identifier, object
                value)
                {
                    this_param.AddAdditionalSpelling(identifier, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 2076, 2116);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 1749, 2143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 1749, 2143);
            }
        }

        private void AddAdditionalSpelling(string identifier, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 2155, 3081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 2370, 2401);

                var
                strValue = value as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 2415, 3070) || true) && (strValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 2415, 3070);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 2469, 2789) || true) && (!f_104_2474_2535(identifier, strValue, StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 2469, 2789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 2706, 2770);

                        _map[identifier] = new HashSet<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => identifier, 104, 2725, 2769), strValue };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(104, 2469, 2789);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(104, 2415, 3070);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 2415, 3070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 2911, 2950);

                    var
                    spellings = (HashSet<string>)value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 3029, 3055);

                    f_104_3029_3054(
                                    // Note: the set will prevent duplicates.
                                    spellings, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(104, 2415, 3070);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 2155, 3081);

                bool
                f_104_2474_2535(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 2474, 2535);
                    return return_v;
                }


                bool
                f_104_3029_3054(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 3029, 3054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 2155, 3081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 2155, 3081);
            }
        }

        private void AddInitialSpelling(string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 3093, 3345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 3301, 3334);

                f_104_3301_3333(            // We didn't have any spellings for this word already.  Just
                                            // add the word as the single known spelling.
                            _map, identifier, identifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 3093, 3345);

                int
                f_104_3301_3333(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 3301, 3333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 3093, 3345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 3093, 3345);
            }
        }

        public bool ContainsIdentifier(string identifier, bool caseSensitive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 3357, 3733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 3451, 3490);

                f_104_3451_3489(identifier != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 3506, 3722) || true) && (caseSensitive)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 3506, 3722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 3557, 3598);

                    return f_104_3564_3597(this, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(104, 3506, 3722);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 3506, 3722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 3664, 3707);

                    return f_104_3671_3706(this, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(104, 3506, 3722);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 3357, 3733);

                int
                f_104_3451_3489(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 3451, 3489);
                    return 0;
                }


                bool
                f_104_3564_3597(Microsoft.CodeAnalysis.IdentifierCollection
                this_param, string
                identifier)
                {
                    var return_v = this_param.CaseSensitiveContains(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 3564, 3597);
                    return return_v;
                }


                bool
                f_104_3671_3706(Microsoft.CodeAnalysis.IdentifierCollection
                this_param, string
                identifier)
                {
                    var return_v = this_param.CaseInsensitiveContains(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 3671, 3706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 3357, 3733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 3357, 3733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CaseInsensitiveContains(string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 3745, 4048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4001, 4037);

                return f_104_4008_4036(_map, identifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 3745, 4048);

                bool
                f_104_4008_4036(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 4008, 4036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 3745, 4048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 3745, 4048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CaseSensitiveContains(string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 4060, 4616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4138, 4156);

                object?
                spellings
                = default(object?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4170, 4576) || true) && (f_104_4174_4217(_map, identifier, out spellings))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 4170, 4576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4251, 4286);

                    var
                    spelling = spellings as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4304, 4454) || true) && (spelling != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(104, 4304, 4454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4366, 4435);

                        return f_104_4373_4434(identifier, spelling, StringComparison.Ordinal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(104, 4304, 4454);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4474, 4511);

                    var
                    set = (HashSet<string>)spellings
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4529, 4561);

                    return f_104_4536_4560(set, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(104, 4170, 4576);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4592, 4605);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 4060, 4616);

                bool
                f_104_4174_4217(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, out object?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 4174, 4217);
                    return return_v;
                }


                bool
                f_104_4373_4434(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 4373, 4434);
                    return return_v;
                }


                bool
                f_104_4536_4560(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 4536, 4560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 4060, 4616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 4060, 4616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ICollection<string> AsCaseSensitiveCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 4628, 4759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4707, 4748);

                return f_104_4714_4747(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 4628, 4759);

                Microsoft.CodeAnalysis.IdentifierCollection.CaseSensitiveCollection
                f_104_4714_4747(Microsoft.CodeAnalysis.IdentifierCollection
                identifierCollection)
                {
                    var return_v = new Microsoft.CodeAnalysis.IdentifierCollection.CaseSensitiveCollection(identifierCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 4714, 4747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 4628, 4759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 4628, 4759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ICollection<string> AsCaseInsensitiveCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(104, 4771, 4906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(104, 4852, 4895);

                return f_104_4859_4894(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(104, 4771, 4906);

                Microsoft.CodeAnalysis.IdentifierCollection.CaseInsensitiveCollection
                f_104_4859_4894(Microsoft.CodeAnalysis.IdentifierCollection
                identifierCollection)
                {
                    var return_v = new Microsoft.CodeAnalysis.IdentifierCollection.CaseInsensitiveCollection(identifierCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 4859, 4894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(104, 4771, 4906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(104, 4771, 4906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.StringComparer
        f_104_1279_1311()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(104, 1279, 1311);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, object>
        f_104_1234_1312(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 1234, 1312);
            return return_v;
        }


        static int
        f_104_1473_1505(Microsoft.CodeAnalysis.IdentifierCollection
        this_param, System.Collections.Generic.IEnumerable<string>
        identifiers)
        {
            this_param.AddIdentifiers(identifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(104, 1473, 1505);
            return 0;
        }

    }
}
