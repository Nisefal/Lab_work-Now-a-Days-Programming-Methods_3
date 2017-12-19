using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class DECLINEExpression : Expression
    {
        public DECLINEExpression(string lefttext, string righttext) : base(lefttext, righttext)
        {
            Interpret(lefttext, righttext);
        }
    }
}
