﻿namespace Objectivity.AutoFixture.XUnit2.AutoMoq.Tests.Providers
{
    using System.Diagnostics.CodeAnalysis;
    using Objectivity.AutoFixture.XUnit2.Core.Providers;
    using FluentAssertions;
    using Ploeh.AutoFixture;
    using Ploeh.AutoFixture.Xunit2;
    using Xunit;
    using Objectivity.AutoFixture.XUnit2.AutoMoq.Providers;

    [Collection("AutoDataAttributeProvider")]
    [Trait("Category", "Providers")]
    public class AutoDataAttributeProviderTests
    {
        [Theory(DisplayName = "GIVEN initialized fixture WHEN GetAttribute is invoked THEN attribute with specified fixture is returned")]
        [AutoData]
        [SuppressMessage("ReSharper", "PossibleNullReferenceException", Justification = "Assertion checks it earlier and throws exception.")]
        public void GivenInitializedFixture_WhenGetAttributeIsInvoked_ThenAttributeWithSpecifiedFixtureIsReturned(Fixture fixture)
        {
            // Arrange
            var provider = new AutoDataAttributeProvider();

            // Act
            var dataAttribute = provider.GetAttribute(fixture) as AutoDataAttribute;

            // Assert
            dataAttribute.Should().NotBeNull();
            dataAttribute.Fixture.Should().Be(fixture);
        }
    }
}
