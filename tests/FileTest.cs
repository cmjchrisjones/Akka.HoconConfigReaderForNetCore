using Akka.Configuration.Hocon;
using CJTech.Akka.Helpers.HoconConfigReader;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HoconConfigReader.Tests
{
    public class FileTest
    {
        [Fact]
        public void CanReadHoconFile()
        {
            // Arrange

            var sut = new AkkaHoconConfigurationHelper();

            // Act

            var result = sut.ReadHoconConfigFile($"{Directory.GetCurrentDirectory()}\\example-hocon.config");

            // Assert
            var root = result.Root;
            root.Should().BeOfType<HoconValue>();
            root.IsEmpty.Should().BeFalse();
            List<IHoconElement> values = root.Values;
            values.First().Should().BeOfType<HoconObject>();
        }
    }
}