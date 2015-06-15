﻿using Bardock.Utils.UnitTest.Samples.SUT.Infra;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace Bardock.Utils.UnitTest.Samples.Fixtures.Customizations
{
    internal class DefaultCustomization : CompositeCustomization
    {
        public DefaultCustomization()
            : base(
                new EntityFrameworkCustomization<DataContext>(),
                new DataAnnotationsCustomization(),
                new DataContextCustomization(),
                new DataContextWrapperCustomization(),
                new NoDataAnnotationsCustomization(),
                new AutoMoqCustomization())
        {
        }
    }
}