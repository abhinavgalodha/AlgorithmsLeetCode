using FluentAssertions;
using FluentAssertions.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Test.Extension
{
    public static class ExtensionMethods
    {
        public static AndConstraint<TAssertions> BeEquivalentWithStrictOrderTo<TAssertions, TSubject, TExpectation>(this CollectionAssertions<TSubject, TAssertions> collectionAssertions,IEnumerable<TExpectation> expectation, string because = "", params object[] becauseArgs)
             where TSubject : IEnumerable
             where TAssertions : CollectionAssertions<TSubject, TAssertions>
        { 
            return collectionAssertions.BeEquivalentTo(expectation, options => options.WithStrictOrdering());
        }
    }
}
