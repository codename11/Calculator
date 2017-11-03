using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
/*
 A simple calculator done in C#. It can operate adding, substructing, division and multiplication operations. 
 All of the mentioned operations can be done with numbers with decimal point in them and with negative numbers also with decimal point.
*/
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool dot = false;
        bool res = false;
        bool sign = false;

        private void No1_Click(object sender, EventArgs e)
        {

            if (res == false && sign == false)
            {
                
                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No1.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No1.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No1.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No1.Text;
            }
   
        }

        private void box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void No2_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No2.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No2.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No2.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No2.Text;
            }

        }

        private void No3_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No3.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No3.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No3.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No3.Text;
            }

        }

        private void No4_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No4.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No4.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No4.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No4.Text;
            }

        }

        private void No5_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No5.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No5.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No5.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No5.Text;
            }

        }

        private void No6_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No6.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No6.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No6.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No6.Text;
            }

        }

        private void No7_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No7.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No7.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No7.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No7.Text;
            }

        }

        private void No8_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No8.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No8.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No8.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No8.Text;
            }

        }

        private void No9_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No9.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No9.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No9.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No9.Text;
            }

        }

        private void No0_Click(object sender, EventArgs e)
        {
            if (res == false && sign == false)
            {

                if (box1.Text == "0")
                {
                    box1.Text = "";
                }
                box1.Text += No0.Text;
            }
            else if (res == true && sign == false)
            {
                res = false;
                box1.Text = "";
                box1.Text += No0.Text;
            }
            else if (res == true && sign == true)
            {
                sign = false;
                res = false;
                box1.Text += No0.Text;
            }
            else if (res == false && sign == true)
            {
                box1.Text += No0.Text;
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            box1.Text += buttonPlus.Text;
            string str1 = box1.Text;
            string str2 = str1.Substring(str1.Length - 1);//Prikazuje zadnji znak u stringu.
            string str3 = str1.Substring(str1.Length - 2, 1);//Prikazuje predzadnji znak u stringu.
            int sign_count = 0;
            int len = box1.Text.Length;
            char strx;
            if (str2 == str3 || (str3 == "+" || str3 == "-" || str3 == "*" || str3 == "/" || str3 == "/" || str3 == "."))
            {
                box1.Text = box1.Text.Substring(0, str1.Length - 2);//Skracuje string u text boxu za unesene znakove.
                box1.Text += buttonPlus.Text;//Dodaje znak na skraceni string. 
            }

            str2 = box1.Text.Substring(0, box1.Text.Length - 1);

            for (int i = 0; i < box1.Text.Length; i++)
            {
                strx = box1.Text[i];
                if (strx == '+' || strx == '-' || strx == '*' || strx == '/')
                {
                    sign_count++;
                }
                
            }
          
            if (sign_count>1)
            {
                
                DataTable dt = new DataTable();
                var v = dt.Compute(str2, "");
                box1.Text = v.ToString();
                box1.Text += buttonPlus.Text;
                res = true;
            }
            sign = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (box1.Text == "0")
            {
                box1.Text = buttonMinus.Text;
            }
            else
            {
                box1.Text += buttonMinus.Text;

                string str1 = box1.Text;
                string str2 = str1.Substring(str1.Length - 1);//Prikazuje zadnji znak u stringu.
                string str3 = str1.Substring(str1.Length - 2, 1);//Prikazuje predzadnji znak u stringu.
                int sign_count = 0;
                int len = box1.Text.Length;
                char strx;
                if (str2 == str3 || (str3 == "+" || str3 == "-" || str3 == "*" || str3 == "/" || str3 == "."))
                {
                    box1.Text = box1.Text.Substring(0, str1.Length - 2);//Skracuje string u text boxu za unesene znakove.
                    box1.Text += buttonMinus.Text;//Dodaje znak na skraceni string. 
                }

                str2 = box1.Text.Substring(0, box1.Text.Length - 1);

                for (int i = 0; i < box1.Text.Length; i++)
                {
                    strx = box1.Text[i];
                    if (strx == '+' || strx == '-' || strx == '*' || strx == '/')
                    {
                        sign_count++;
                    }

                }

                if (sign_count > 1)
                {

                    DataTable dt = new DataTable();
                    var v = dt.Compute(str2, "");
                    box1.Text = v.ToString();
                    box1.Text += buttonMinus.Text;
                    res = true;
                }
            }
            sign = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            box1.Text += buttonMultiply.Text;
            string str1 = box1.Text;
            string str2 = str1.Substring(str1.Length - 1);//Prikazuje zadnji znak u stringu.
            string str3 = str1.Substring(str1.Length - 2, 1);//Prikazuje predzadnji znak u stringu.
            int sign_count = 0;
            int len = box1.Text.Length;
            char strx;
            if (str2 == str3 || (str3 == "+" || str3 == "-" || str3 == "*" || str3 == "/" || str3 == "."))
            {
                box1.Text = box1.Text.Substring(0, str1.Length - 2);//Skracuje string u text boxu za unesene znakove.
                box1.Text += buttonMultiply.Text;//Dodaje znak na skraceni string. 
            }

            str2 = box1.Text.Substring(0, box1.Text.Length - 1);

            for (int i = 0; i < box1.Text.Length; i++)
            {
                strx = box1.Text[i];
                if (strx == '+' || strx == '-' || strx == '*' || strx == '/')
                {
                    sign_count++;
                }

            }

            if (sign_count > 1)
            {

                DataTable dt = new DataTable();
                var v = dt.Compute(str2, "");
                box1.Text = v.ToString();
                box1.Text += buttonMultiply.Text;
                res = true;
            }
            sign = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            box1.Text += buttonDivide.Text;
            string str1 = box1.Text;
            string str2 = str1.Substring(str1.Length - 1);//Prikazuje zadnji znak u stringu.
            string str3 = str1.Substring(str1.Length - 2, 1);//Prikazuje predzadnji znak u stringu.
            int sign_count = 0;
            int len = box1.Text.Length;
            char strx;
            if (str2 == str3 || (str3 == "+" || str3 == "-" || str3 == "*" || str3 == "/" || str3 == "."))
            {
                box1.Text = box1.Text.Substring(0, str1.Length - 2);//Skracuje string u text boxu za unesene znakove.
                box1.Text += buttonDivide.Text;//Dodaje znak na skraceni string. 
            }

            str2 = box1.Text.Substring(0, box1.Text.Length - 1);

            for (int i = 0; i < box1.Text.Length; i++)
            {
                strx = box1.Text[i];
                if (strx == '+' || strx == '-' || strx == '*' || strx == '/')
                {
                    sign_count++;
                }

            }

            if (sign_count > 1)
            {

                DataTable dt = new DataTable();
                var v = dt.Compute(str2, "");
                box1.Text = v.ToString();
                box1.Text += buttonDivide.Text;
                res = true;
            }
            sign = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
           
            if (box1.Text.Length>1)
            {
                string str = box1.Text.Substring(box1.Text.Length-1);
                
                int dot_loc = 0;
                bool dot_contains = false;
                string decimals = "";
                if ((str != "+") && (str != "-") && (str != "*") && (str != "/") && (str != "."))
                {
                    DataTable dt = new DataTable();
                    var v = dt.Compute(box1.Text, "");
                    box1.Text = v.ToString();
                    box1.Text = v.ToString();

                    dot_contains = box1.Text.Contains('.');

                    if (dot_contains == true && box1.Text.Substring(box1.Text.Length)!=".")
                    {
                            dot_loc = box1.Text.IndexOf(".");
                        
                            for (int i = dot_loc+1; i < box1.Text.Length; i++)
                            {
                                decimals += box1.Text[i];
                            }
                        
                            if (box1.Text.Contains(decimals) && Convert.ToInt64(decimals) == 0)
                            {
                                box1.Text = box1.Text.Substring(0, dot_loc);
                            }
                        
                    }

                    res = true;
                    sign = false;
                }
            }

            
            

        }

        private void erase_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box1.Text = "0";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {

            int sign_locPlus = 0;
            int sign_locMinus = 0;
            int sign_locMul = 0;
            int sign_locDiv = 0;
            string patt = "";
            int patt_loc = 0;
            string str = "";
            int val = 0;
            sign_locPlus = box1.Text.IndexOf("+");
            sign_locMinus = box1.Text.IndexOf("-");
            sign_locMul = box1.Text.IndexOf("*");
            sign_locDiv = box1.Text.IndexOf("/");

            if (sign_locPlus > 0 && (sign_locPlus + 1) < box1.Text.Length && sign_locPlus < box1.Text.Length)
            {
                patt = box1.Text[sign_locPlus] + "" + box1.Text[sign_locPlus + 1];
                patt_loc = box1.Text.IndexOf(patt);
                dot = false;
            }
            else if (box1.Text[0] == '-' && (sign_locMinus + 1) < box1.Text.Length)
            {
                patt = box1.Text[sign_locMinus] + "" + box1.Text[sign_locMinus + 1];
                patt_loc = box1.Text.IndexOf(patt);
                dot = false;
            }
            else if ((sign_locMinus > 0 && (sign_locMinus + 1) < box1.Text.Length) && sign_locPlus < box1.Text.Length)
            {
                patt = box1.Text[sign_locMinus] + "" + box1.Text[sign_locMinus + 1];
                patt_loc = box1.Text.IndexOf(patt);
                dot = false;
            }
            else if (sign_locMul > 0 && (sign_locMul + 1) < box1.Text.Length && sign_locPlus < box1.Text.Length)
            {
                patt = box1.Text[sign_locMul] + "" + box1.Text[sign_locMul + 1];
                patt_loc = box1.Text.IndexOf(patt);
                dot = false;
            }
            else if (sign_locDiv > 0 && (sign_locDiv + 1) < box1.Text.Length && sign_locPlus < box1.Text.Length)
            {
                patt = box1.Text[sign_locDiv] + "" + box1.Text[sign_locDiv + 1];
                patt_loc = box1.Text.IndexOf(patt);
                dot = false;
            }

            for (int i = 0; i < box1.Text.Length; i++)
            {

                if (box1.Text[i] == '-')
                {
                    val++;
                }
                
            }

            if (val > patt_loc && dot == false)//Ovde se ispravlja polozaj minusa ukoliko ima dve negative cifre jedna za drugom da bi oznacio drugu.
            {
                MessageBox.Show("Val je: " + val);//Polozaj ispravljene koordinate, tj. polozaj druge negativne cifre.
                patt = box1.Text[val] + "" + box1.Text[val + 1];
                patt_loc = box1.Text.IndexOf(patt);
                MessageBox.Show("Ispravljeno: "+patt + " : " + patt_loc);
            }

        }
    }
}
