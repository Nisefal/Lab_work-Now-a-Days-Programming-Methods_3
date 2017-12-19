using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ExpressionObject : Expression
    {
        public string _object;

        public ExpressionObject(string context, string righttext, string lefttext) : base(righttext, lefttext)
        {
        }

        public ExpressionObject(string context) : base()
        {
            _object = context;
        }
    }
}
