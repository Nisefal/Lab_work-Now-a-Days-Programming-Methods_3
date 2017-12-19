using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Expression : IExpression
    {
        IExpression left;
        IExpression right;

        public Expression()
        {
        }

        public Expression(string lefttext, string righttext)
        {
        }

        private Expression Branch(string context)
        {
            string[] comparis = context.Split(new [] { "COMPARISON" }, StringSplitOptions.None);
            string [] compaund = context.Split(new [] { "COMPAUND" }, StringSplitOptions.None);
            string [] contains = context.Split(new [] { "CONTAINS" }, StringSplitOptions.None);
            string [] decline = context.Split(new [] { "DECLINE" }, StringSplitOptions.None);
            string [] equals = context.Split(new [] { "EQUALS" }, StringSplitOptions.None);
            string [] or = context.Split(new [] { "OR" }, StringSplitOptions.None);
            string [] and = context.Split(new [] { "AND" }, StringSplitOptions.None);

            if (comparis.Count() >= 2)
            {
                return new COMPARISONExpression(comparis[0], comparis[1]);
            }
            else
            {
                if (compaund.Count() >= 2)
                {
                    return new COMPAUNDExpression(comparis[0], comparis[1]);
                }
                else
                {
                    if (contains.Count() >= 2)
                    {
                        return new CONTAINSExpression(contains[0], contains[1]);
                    }
                    else
                    {
                        if (decline.Count() >= 2)
                        {
                            return new DECLINEExpression(decline[0], decline[1]);
                        }
                        else
                        {
                            if (equals.Count() >= 2)
                            {
                                return new EQUALSExpression(equals[0], equals[1]);
                            }
                            else
                            {
                                if (or.Count() >= 2)
                                {
                                    return new ORExpression(or[0], or[1]);
                                }
                                else
                                {
                                    if (and.Count() >= 2)
                                    {
                                        return new ANDExpression(and[0], and[1]);
                                    }
                                    else
                                        return new ExpressionObject(context);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Interpret(string lefttext, string righttext)
        {
            left = Branch(lefttext);
            right = Branch(righttext);
        }
    }
}
