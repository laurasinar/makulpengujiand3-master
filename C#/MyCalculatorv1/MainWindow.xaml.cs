//houssem.dellai@ieee.org 
//+216 95 325 964 

using System;
using System.Windows;
using System.Windows.Controls;

namespace MyCalculatorv1
{
    public partial class MainWindow : Window
    {
        public double penjumlahan(double op1, double op2)
        {
            return (op1 + op2);
        }

        public double pengurangan(double op1, double op2)
        {
            return (op1 - op2);
        }

        public double perkalian(double op1, double op2)
        {
            return (op1 * op2);
        }

        public double pembagian(double op1, double op2)
        {
            return (op1 / op2);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button) sender;
            tb.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {

                tb.Text = exc.Message;
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (tb.Text.Contains("+"))
            {
                iOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }
            else
            {
                //error
            }

            op = tb.Text.Substring(iOp, 1);
            //op1
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));
            //op2
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            if (op == "+")//penjumlahan
            {
                tb.Text += "=" + penjumlahan(op1, op2);
            }
            else if (op == "-")//pengurangan
            {
                tb.Text += "=" + pengurangan(op1, op2);
            }
            else if (op == "*")//perkalian
            {
                tb.Text += "=" + perkalian(op1, op2);
            }
            else // pembagian
            {
                tb.Text += "=" + pembagian(op1, op2);
            }
        }


        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }

        public void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }


        
    }
}
