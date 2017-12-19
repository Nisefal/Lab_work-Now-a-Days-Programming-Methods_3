using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ORExpression : Expression
    {
        public ORExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }

    class CopyOfORExpression : Expression
    {
        public CopyOfORExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }
}
