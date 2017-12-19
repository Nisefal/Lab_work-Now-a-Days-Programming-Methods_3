using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ANDExpression : Expression
    {
        public ANDExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }

    class CopyOfANDExpression : Expression
    {
        public CopyOfANDExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }
}
