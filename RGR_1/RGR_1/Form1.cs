using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            label_Calc.Text = "Formula and result";
            tbStrResult.ReadOnly = true;
            tbStrResult.BackColor = Color.White;
            tb_Generate.ReadOnly = true;
            tb_Generate.BackColor = Color.White;
            tbPerimeter.ReadOnly = true;
            tbPerimeter.BackColor = Color.White;
            tbArr.ReadOnly = true;
            tbArr.BackColor = Color.White;
            tbMin.ReadOnly = true;
            tbMin.BackColor = Color.White;
            tbMax.ReadOnly = true;
            tbMax.BackColor = Color.White;
            tbSum.ReadOnly = true;
            tbSum.BackColor = Color.White;
            tbArr1D.ReadOnly = true;
            tbArr1D.BackColor = Color.White;
            tbArr2D.ReadOnly = true;
            tbArr2D.BackColor = Color.White;
        }

        //WORK WITH PAGE "OOP" WORK WITH PAGE "OOP" WORK WITH PAGE "OOP" WORK WITH PAGE "OOP" WORK WITH PAGE "OOP" WORK WITH PAGE "OOP" 

        
        private void tbEnterX_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strX = tbEnterX.Text;
            char digitX = e.KeyChar;
            if (!Char.IsDigit(digitX) && digitX != 8 && digitX != 44)
            {
                e.Handled = true;
            }
            else if (char.IsDigit(digitX) && (sender as TextBox).Text == "0")
                {
                    (sender as TextBox).Text = digitX.ToString();
                    e.Handled = true;
                    (sender as TextBox).Select(1, 0);
                }
            if ((digitX == ',' && (sender as TextBox).Text.Contains(','))
            | (!char.IsDigit(digitX) && digitX != (char)8 && digitX != ','))
            {
                e.Handled = true;
            }
        }

        private void tbEnterY_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strY = tbEnterY.Text;
            char digitY = e.KeyChar;
            if (!Char.IsDigit(digitY) && digitY != 8 && digitY != 44)
            {
                e.Handled = true;
            }
            else if (char.IsDigit(digitY) && (sender as TextBox).Text == "0")
            {
                (sender as TextBox).Text = digitY.ToString();
                e.Handled = true;
                (sender as TextBox).Select(1, 0);
            }
            if ((digitY == ',' && (sender as TextBox).Text.Contains(','))
            | (!char.IsDigit(digitY) && digitY != (char)8 && digitY != ','))
            {
                e.Handled = true;
            }

        }

        private void btnCalcP_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.X = Convert.ToDouble(tbEnterX.Text);
            r.Y = Convert.ToDouble(tbEnterY.Text);
            if (tbEnterY.Text != "" && tbEnterX.Text != "")
            {
                tbPerimeter.Text = r.CalculatePerimetr().ToString();
            }
            else
                MessageBox.Show("YOU DIDNT ENTER COORDINATES");
        }

        private void btnINFO_OOP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The task is to get perimeter by entering two coordinates\n" +
                "You enter horizontal coordinate in 'X' field\n" +
                "Then you enter vertical coordinate in 'Y' field\n" +
                "You click a 'Calculate Perimeter' button and get your result");
        }




        //WORK WITH PAGE "IF" WORK WITH PAGE "IF" WORK WITH PAGE "IF" WORK WITH PAGE "IF" WORK WITH PAGE "IF" WORK WITH PAGE "IF"

        private void btnGenC_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;
            tb_Generate.Text = "x = " + (x = (rand.NextDouble() * 200 - 100)).ToString();
            string Y = "";

            if (x <= -1)
            {
                y = 8 * x * x * x + 2;
                Y = "y = 8 * x * x * x + 2";
            }
            else
                if (x >= 1)
            {
                y = x + 1;
                Y = "y = x + 1";
            }
            else
            {
                y = x * x - 1;
                Y = "y = x * x - 1";
            }

            label_Calc.Text = Y + "\ny=" + y.ToString();
        }

        private void btnINFO_IF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The task is to get value of y\n" +
              "Value of y is based on the value of x\nso there are some conditions:\n" +
              "If x <= -1   -   y = 8 * x * x * x + 2\n" +
              "If x >= 1   -   y = x + 1\n" +
              "If x = 0   -   y = x * x - 1\n\n" +
              "You can get x by clicking the button 'Gen&C'\n" +
              "The same button will make all calculations");
        }

        //WORK WITH PAGE "ARRAY" WORK WITH PAGE "ARRAY" WORK WITH PAGE "ARRAY" WORK WITH PAGE "ARRAY" WORK WITH PAGE "ARRAY" 

        private void tbArrSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strAr = tbArrSize.Text;
            char digitArr = e.KeyChar;
            if (!Char.IsDigit(digitArr) && digitArr != 8 && digitArr != 45) 
            {
                e.Handled = true;
            }
           
        }

        private void btnGenArr_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (tbArrSize.Text != "")
            {
                n = Convert.ToInt32(tbArrSize.Text);
            }
            else if(tbArrSize.Text=="")
            {
                n = 0;
            }
            else if(tbArrSize.Text=="-")
            {
               n = (-1)*Convert.ToInt32(tbArrSize.Text);
            }
            int[] array = new int[19+n];
            Array.Clear(array, 0, 19+n);
            

            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(19+n)-10;

            foreach (int item in array)
               tbArr.Text += item + " ";

            int min = array[0];
            int max = array[0];

            for (int k = 0; k < array.Length; k++)
            {
                if(array[k]<min)
                {
                    min = array[k];
                }
                if(array[k]>max)
                {
                    max = array[k];
                }
            }

            int sum = min + max;
            tbSum.Text = Convert.ToString(sum);
            tbMin.Text = Convert.ToString(min);
            tbMax.Text = Convert.ToString(max);

        }

        private void lbArr_DoubleClick(object sender, EventArgs e)
        {
            tbMin.Text = "";
            tbMax.Text = "";
            tbArr.Text = "";
            tbArrSize.Text = "";
            tbSum.Text = "";
        }

        private void btnINFO_Arr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The task is to create an array\n" +
                             "and to count sum of the smallest and the largest elements of it\n\n"+
                             "You can set the size of the array.\n"+
                             "It counts according to the next formula\n"+
                             "19 + digit you enter in the 'Array size' field\n"+
                             "If you want to clean all fields DOUBLE CLICK inscription 'Array itself'");
        }

        //WORK WITH PAGE ARRAY2D WORK WITH PAGE ARRAY2D WORK WITH PAGE ARRAY2D WORK WITH PAGE ARRAY2D WORK WITH PAGE ARRAY2D 

        private void btnINFO_ARR2D_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The task is to rewrite non-negative elements\n" +
                            "that are placed between first and second negative elements\n" +
                            "form two-dimensional array into one-dimensional array.\n" +
                            "The only thing you have to do to cope with it - to press one button");
        }


        private void btnGenArr2D_Click(object sender, EventArgs e)
        {
            int x = 5;
            int c = 5;
            int z = 0;
            int[] m1 = new int[25];
            int[,] m2 = new int[x, c];


            tbArr2D.Clear();
            tbArr1D.Clear();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    m2[j, i] = rand.Next(100) - 50;
                    tbArr2D.Text += m2[j, i].ToString() + " ";
                }
                tbArr2D.Text += "\r\n" + "\r\n";
            }

            int firstNeg = 0;
            int secondNeg = 0;

            for (int j = 0; j < c; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (m2[i, j] < 0)
                    {
                        firstNeg = m2[j, i];
                        break;
                    }
                }
            }

            for (int j = 0; j < c; j++)
            {
                for (int i = 0; i < x; i++)
                {

                    if(m2[i,j]> 0)
                    {
                        m1[z] = m2[j, i];
                        tbArr1D.Text += m1[z].ToString() + " ";
                    }
                    else if (m2[j, i] < 0)
                    {
                        secondNeg = m2[j, i];
                        break;
                    }
                    break;
                    
                }
            }
        }





        //WORK WITH PAGE "STRING" WORK WITH PAGE "STRING" WORK WITH PAGE "STRING" WORK WITH PAGE "STRING" WORK WITH PAGE "STRING"
        private void btnINFO_STR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The task is to transform the string\n" +
            "You have to enter the string containing symbols,numbers etc\n " +
            "The string must include dots and comas.\n" +
            "By pressing the button dots change into 'ТЧК' and comas into 'ЗПТ'\n\n" +
            "It will happen in next sequence:\n" +
            "You enter the string in the textbox\n" +
            "You press the 'Thransformation' button\n" +
            "You get the result lower and you are happy\n");
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            string str = tbStrEnter.Text;
            if (str.Contains(".") && str.Contains(","))
            {
                str = str.Replace(".", "ТЧК");
                str = str.Replace(",", "ЗПТ");
                //tbStrEnter.Clear();
                tbStrResult.AppendText(str.Replace(".", "ТЧК"));
                //tbStrResult.AppendText(str.Replace(",", "ЗПТ"));
            }
            else
                if (!str.Contains(".") && !str.Contains(","))
            {
                tbStrEnter.Clear();
                MessageBox.Show("Oh.Something has gone wrong\n" +
                    "Maybe you forgot to put dots and comas?\n" +
                    "Enter the string again,with dots and comas this time\n");
            }
            else if (!str.Contains(".") && str.Contains(","))
            {
                tbStrEnter.Clear();
                MessageBox.Show("If you see this - you forgot to put dots\n" +
                    "Enter your string again and dont forget\nto put dots and comas both this time");
            }
            else if (str.Contains(".") && !str.Contains(","))
            {
                tbStrEnter.Clear();
                MessageBox.Show("If you see this - you forgot to put comas\n" +
                   "Enter your string again and dont forget\nto put dots and comas both this time");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                tbStrEnter.Text = "";
                tbStrResult.Text = "";

            
        }

        
    }



}


