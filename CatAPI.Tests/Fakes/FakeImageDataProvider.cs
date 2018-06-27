using CatAPI.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatAPI.Tests.Fakes
{
    public class FakeImageDataProvider : InMemoryDataProvider
    {
        public int count
        {
            get { return base.GetAllImages().Count; }
        }
    }
}
