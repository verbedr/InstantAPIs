﻿using Xunit;

namespace Test.Configuration;

public class WhenIncludeDoesNotSpecifyBaseUrl : InstantAPIsConfigBuilderFixture
{

	[Fact]
	public void ShouldSpecifyDefaultUrl()
	{

		// arrange

		// act
		_Builder.IncludeTable(db => db.Contacts);
		var config = _Builder.Build();

		// assert
		Assert.Single(config);
		Assert.Equal(new Uri("/api/Contacts", uriKind: UriKind.Relative), config.First().BaseUrl);

	}
}
