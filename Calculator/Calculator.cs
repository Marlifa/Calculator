using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    enum Oper
    {
        PLUS,
        MINUS,
        MULT,
        DIV,  
        OST,
        ONE_DEV,
        SQRT,
        NONE

    }
    public partial class Calculator : Form
    {
        bool needClear;
        Oper oper;
        bool restart;
        double num;
        double res;
        double cell;
        public Calculator()
        {
            InitializeComponent();
            num = 0;
            res = 0;
            oper = Oper.NONE;
            needClear = false;
            restart = false;
        }
        //обработчики циферблата
        private void b_Num1_Click(object sender, EventArgs e)
        {
            printSymb('1');
        }
        private void b_Num2_Click(object sender, EventArgs e)
        {
            printSymb('2');
        }
        private void b_Num3_Click(object sender, EventArgs e)
        {
            printSymb('3');
        }
        private void b_Num4_Click(object sender, EventArgs e)
        {
            printSymb('4');
        }
        private void b_Num5_Click(object sender, EventArgs e)
        {
            printSymb('5');
        }
        private void b_Num6_Click(object sender, EventArgs e)
        {
            printSymb('6');
        }
        private void b_Num7_Click(object sender, EventArgs e)
        {
            printSymb('7');
        }
        private void b_Num8_Click(object sender, EventArgs e)
        {
            printSymb('8');
        }
        private void b_Num9_Click(object sender, EventArgs e)
        {
            printSymb('9');
        }
        private void b_Num0_Click(object sender, EventArgs e)
        {
            printSymb('0');
        }
        private void b_Dot_Click(object sender, EventArgs e)
        {
            printSymb(',');
        }
        //обработчики кнопок очистки
        private void b_backspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Result.Text))
            {
                tb_Result.Text = tb_Result.Text.Substring(0, tb_Result.Text.Length - 1);
            }
        }
        private void CE_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
        }
        private void b_C_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            needClear = true;
            num = 0;
            res = 0;
            oper = Oper.NONE;
        }
        // обработчики бинарных операций----------------------------------
        private void b_PLUS_Click(object sender, EventArgs e)
        {
            callBianaryOper(Oper.PLUS);
        }
        private void b_minus_Click(object sender, EventArgs e)
        {
            callBianaryOper(Oper.MINUS);
        }
        private void b_Mult_Click(object sender, EventArgs e)
        {
            callBianaryOper(Oper.MULT);
        }
        private void b_DIvide_Click(object sender, EventArgs e)
        {
            callBianaryOper(Oper.DIV);
        }
        private void b_Ost_Click(object sender, EventArgs e)
        {
            callBianaryOper(Oper.OST);
        }
        private void b_OneDivision_Click(object sender, EventArgs e)
        {
            unarOper(Oper.ONE_DEV);
        }
        private void b_SQRT_Click(object sender, EventArgs e)
        {
            unarOper(Oper.SQRT);
        }
        //поменять знак
        private void b__changeSign_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tb_Result.Text))
            { 
                if (tb_Result.Text[0] != '-')
                {
                    tb_Result.Text = "-" + tb_Result.Text;
                }
                else
                {
                    tb_Result.Text = tb_Result.Text.Substring(1, tb_Result.Text.Length - 1);
                }
                double.TryParse(tb_Result.Text, out num);
            }
        }
        //кнопки для работы с ячейкой памяти
        private void b_MS_Click(object sender, EventArgs e)
        {
            double.TryParse(tb_Result.Text, out cell);
        }
        private void b_MR_Click(object sender, EventArgs e)
        {
            if (cell != 0)
            {
                tb_Result.Text = cell.ToString();
                num = cell;
            }
        }
        private void b_MC_Click(object sender, EventArgs e)
        {
            cell = 0;
        }
        private void b_MPlus_Click(object sender, EventArgs e)
        {
            if(double.TryParse(tb_Result.Text, out num))
            {
                cell += num;
            }
        }
        private void b_MMunis_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_Result.Text, out num))
            {
                cell -= num;
            }
        }
        //равно--------------------------------------------------
        private void b_res_Click(object sender, EventArgs e)
        {
            getRes();
            needClear = true;
            restart = true;
        }
        // лог.операции
        void printSymb(char s)
        {
            if(needClear == true)
            {
                clearData();
            }


            if (canPrint(s))
            {
                
              tb_Result.Text += s;
                if (tb_Result.Text[0] == '0' && tb_Result.Text.Length == 1)
                {
                    tb_Result.Text += ",";
                }
                double .TryParse(tb_Result.Text, out num);

            }

        }
        bool canPrint(char s)
        {
            if (tb_Result.Text.Length >= 19)
            {
                return false;
            }
              
            if (s == ',' && !tb_Result.Text.Contains(','))
            {
                return true;
            }
           
            if ( s != ',')
            {
                return true;
            }  
            return false;
           
        
        }  
        void clearData()
        { 
            if(!restart)
            {
                double.TryParse(tb_Result.Text, out res);
            }
            else
            {
                oper = Oper.NONE;
                res = 0;
                restart = false;
            }
            num = 0;
            tb_Result.Clear();
            needClear=false;
        }
        void getRes()
        {
            switch (oper)
            {
                case Oper.PLUS:
                    res += num;
                    break;
                case Oper.MINUS:
                    res -= num;
                    break;
                case Oper.MULT:
                    res *= num;
                    break;
                case Oper.DIV:
                    res/=num;
                    break;
                case Oper.OST:
                    res %= num;
                    break;
                case Oper.ONE_DEV:
                        res = 1 / res;
                    break;
                case Oper.SQRT:
                    res = Math.Sqrt(res);
                    break;

            }
            tb_Result.Text = res.ToString();
        }

        void callBianaryOper(Oper newOper)
            {
                if(num != 0 && !needClear)
            {
                    
                    if (res == 0)
                    {
                        clearData();
                    }
                    else
                    {
                        getRes();
                        needClear = true;
                    }
                    oper = newOper;
            }
            }

        void unarOper(Oper newOper)
        {
            if (res != 0)
            {
                oper = newOper;
                getRes();
            }
            if (res == 0 && num !=0)
            {
                res = num;
                oper = newOper;
                getRes();
            }
            

        }

       
    }
}
