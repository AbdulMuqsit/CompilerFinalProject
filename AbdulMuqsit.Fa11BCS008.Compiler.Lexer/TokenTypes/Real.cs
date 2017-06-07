﻿namespace AbdulMuqsit.Fa11BCS008.Compiler.Lexer
{
    internal class Real : Token
    {
        private string value;

        public Real(string value) : base(Common.Tag.REAL)
        {
            this.value = value;
        }
    }
}