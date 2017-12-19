using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class EQUALSExpression : Expression, IExpression
    {
        public EQUALSExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }
}
