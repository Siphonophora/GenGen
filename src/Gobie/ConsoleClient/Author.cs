﻿using Gobie;
using System.Collections.Generic;

namespace ConsoleClient.Models
{
    [GobieGeneratorName("PkGen")]
    public sealed class PrimaryKeyGenerator : GobieFieldGenerator
    {
        [GobieTemplate]
        private const string KeyString = "public int {{Name}} { get; set; } // This is a key";
    }

    public sealed class NamePropertyGenerator : GobieFieldGenerator
    {
        [GobieTemplate]
        private const string KeyString = "public string Name { get; set; }";

        [Required(5)]
        public int MyProperty34 { get; set; }

        [Required(5)]
        public int MyProperty2 { get; set; } = 42;

        public string OptionalString { get; set; } = "favorite quote: \"Hello from the magic tavern\"";
    }

    [PkGen]
    [NameProperty(5, 9)]
    public partial class GenTarget
    { }

    [PkGen]
    public partial class GenTarget2
    { }
}