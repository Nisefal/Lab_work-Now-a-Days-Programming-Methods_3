using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CONTAINSExpression : Expression
    {
        public CONTAINSExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }

    class CopyOfCONTAINSExpression : Expression
    {
        public CopyOfCONTAINSExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }
}
