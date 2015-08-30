using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Argument.Test
{
    [TestFixture]
    class ArgumentTest
    {
        [Test]
        public void CheckIfNullOnNullObjectBlows()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Argument.CheckIfNull(null, "Argument");
            });
        }

        [Test]
        public void CheckIfNullOnNonNullObjectDoesNotBlow()
        {
            Assert.DoesNotThrow(() =>
            {
                Argument.CheckIfNull("Hello", "Argument");
            });
        }

        [Test]
        public void CheckIfNullOrEmptyOnNullObjectBlows()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Argument.CheckIfNullOrEmpty(null, "Argument");
            });
        }

        [Test]
        public void CheckIfNullOrEmptyOnNonNullObjectDoesNotBlow()
        {
            Assert.DoesNotThrow(() =>
            {
                Argument.CheckIfNullOrEmpty("Hello", "Argument");
            });
        }

        [Test]
        public void CheckIfNullOrEmptyOnEmptyObjectBlows()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Argument.CheckIfNullOrEmpty(string.Empty, "Argument");
            });
        }

        [Test]
        public void CheckIfNullOrEmptyOnNonEmptyObjectBlows()
        {
            Assert.DoesNotThrow(() =>
            {
                Argument.CheckIfNullOrEmpty("Hello", "Argument");
            });
        }
    }
}
