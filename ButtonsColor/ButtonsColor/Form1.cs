using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonsColor
{
    public partial class Form1 : Form
    {
        Button[] btns = new Button[30];
       
        
         public Form1()
        {
            InitializeComponent();
           btns[0] = button1;
            btns[1] = button2;
            btns[2] = button3;
            btns[3] = button4;
            btns[4] = button5;
            btns[5] = button6;
            btns[6] = button7;
            btns[7] = button8;
            btns[8] = button9;
            btns[9] = button10;
            btns[10] = button11;
            btns[11] = button12;
            btns[12] = button13;
            btns[13] = button14;
            btns[14] = button15;
            btns[15] = button16;
            btns[16] = button17;
            btns[17] = button18;
            btns[18] = button19;
            btns[19] = button20;
            btns[20] = button21;
            btns[21] = button22;
            btns[22] = button23;
            btns[23] = button24;
            btns[24] = button25;
            btns[25] = button26;
            btns[26] = button27;
            btns[27] = button28;
            btns[28] = button29;
            btns[29] = button30;
            foreach(Button b in btns)
            {
                b.BackColor = Color.Aquamarine; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Button b in btns)
            {
               if (b.BackColor == Color.Red)
                {
                    b.BackColor = Color.Aquamarine;
                         
                }
            }

            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            foreach(Button b in btns)
            {
                if (Math.Abs( int.Parse(btn.Text) - int.Parse(b.Text)) % 10 == 0 || Math.Abs(int.Parse(btn.Text) - int.Parse(b.Text)) < 5)
                {
                    b.BackColor = Color.Red;
                }
            }
           
          
        }
    }
}
