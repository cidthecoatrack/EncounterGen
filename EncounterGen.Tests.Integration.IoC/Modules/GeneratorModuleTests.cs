﻿using EncounterGen.Generators;
using NUnit.Framework;

namespace EncounterGen.Tests.Integration.IoC.Modules
{
    [TestFixture]
    public class GeneratorModuleTests : BootstrapTests
    {
        [Test]
        public void EncounterGeneratorIsNotASingleton()
        {
            AssertNotSingleton<IEncounterGenerator>();
        }
    }
}