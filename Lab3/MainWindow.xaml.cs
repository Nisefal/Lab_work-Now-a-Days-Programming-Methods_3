using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Expression tree;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tree = BranchText(textbox.Text); 
        }

        private Expression BranchText(string context)
        {
            string [] comparis = context.Split(new [] { "COMPARISON" }, StringSplitOptions.None);
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
    }
}
