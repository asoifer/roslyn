// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Roslyn.Test.Utilities
{
    /// <summary>
    /// CUSTOM ASSERT FOR RETURNING SOMETHING (SLICING PURPOSES)
    /// </summary>
    public static class CustomAssert
    {
        public static bool True(bool condition)
        {
            Assert.True(condition);
            return true;
        }

        public static bool True(bool condition, string userMessage)
        {
            Assert.True(condition, userMessage);
            return true;
        }

        public static bool False(bool condition)
        {
            Assert.False(condition);
            return true;
        }

        public static bool False(bool condition, string userMessage)
        {
            Assert.False(condition, userMessage);
            return true;
        }

        public static bool Null(object @object)
        {
            Assert.Null(@object);
            return true;
        }

        public static bool NotNull(object @object)
        {
            Assert.NotNull(@object);
            return true;
        }

        public static bool Equal<T>(T expected, T actual, IEqualityComparer<T> equalityComparer)
        {
            Assert.Equal(expected, actual, equalityComparer);
            return true;
        }

        public static bool Equal<T>(T expected, T actual)
        {
            Assert.Equal(expected, actual);
            return true;
        }

        public static bool NotEqual<T>(T expected, T actual)
        {
            Assert.NotEqual(expected, actual);
            return true;
        }

        public static bool Empty(IEnumerable enumerable)
        {
            Assert.Empty(enumerable);
            return true;
        }

        public static bool NotEmpty(IEnumerable enumerable)
        {
            Assert.NotEmpty(enumerable);
            return true;
        }

        public static bool Contains(string expectedSubstring, string actualString, StringComparison comparisonType)
        {
            Assert.Contains(expectedSubstring, actualString, comparisonType);
            return true;
        }

        public static bool Contains(string expectedSubstring, string actualString)
        {
            Assert.Contains(expectedSubstring, actualString);
            return true;
        }

        public static bool DoesNotContain(string expectedSubstring, string[] actualString)
        {
            Assert.DoesNotContain(expectedSubstring, actualString);
            return true;
        }

        public static bool StartsWith(string expectedStartString, string actualString, StringComparison comparisonType)
        {
            Assert.StartsWith(expectedStartString, actualString, comparisonType);
            return true;
        }

        public static bool Same(object expected, object actual)
        {
            Assert.Same(expected, actual);
            return true;
        }

        public static bool NotSame(object expected, object actual)
        {
            Assert.NotSame(expected, actual);
            return true;
        }

        public static T IsType<T>(object @object)
        {
            return Assert.IsType<T>(@object);
        }

        public static bool IsAssignableFrom(Type expectedType, object @object)
        {
            Assert.IsAssignableFrom(expectedType, @object);
            return true;
        }

        public static T Throws<T>(Func<object> testCode) where T : Exception
        {
            return Assert.Throws<T>(testCode);
        }

        public static bool InRange(int a, int b, int c)
        {
            Assert.InRange(a, b, c);
            return true;
        }
    }
}
