﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Compiler.Common;
using Xunit;

namespace Compiler.ParserGenerator.Tests
{

    public class GrammarTests : IClassFixture<GrammarFixture>
    {
        GrammarFixture _fixture;
        public GrammarTests(GrammarFixture fixture)
        {
            _fixture = fixture;
        }
        [Fact]
        public void FollowSetShouldGiveProperFollowSet()
        {
            var productions = new List<Production>() {
                new Production{ NonTerminal="E`", Rule = new List<string> {"E"} },
                new Production{ NonTerminal="E", Rule = new List<string> { "E", "+", "T"  } },
                new Production{ NonTerminal="E", Rule = new List<string> { "T" } },
                new Production{ NonTerminal="T", Rule = new List<string>  { "T", "*", "F" } },
                new Production{ NonTerminal="T", Rule = new List<string>  {"F" } },
                new Production{ NonTerminal="F", Rule = new List<string>  { "(", "E", ")" } },
                new Production{ NonTerminal="F", Rule = new List<string> {"id" } }

            };



            var grammar = new Grammar() { Productions = productions };
            grammar.Initialize();
            var followOfE = grammar.Follow("E");
            Assert.Equal((new List<string>() { "$", ")", "+" }).Union(followOfE).Distinct().Count(), 3);
        }

    }
}
