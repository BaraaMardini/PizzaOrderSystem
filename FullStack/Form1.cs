using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pitzaaaa
{
    public partial class Form1 : Form
    {
        int TotalPrice;
        int PriceOfSize;
        int PriceOfCust;
        int ToppingOfChess;
        int ToppingOfOnion;
        int ToppingOfMashrom;
        int ToppingOfOlives;
        int ToppingOfTomatoes;
        int ToppingOfGreenPeppers;
        string CrustType;
        string PlaceOfEat;
        string ToppingTypes = "No Topping";
        string ToppingOfChess1 = "";
        string ToppingOfOnion1 = "";
        string ToppingOfMashrom1 = "";
        string ToppingOfOlives1 = "";
        string ToppingOfTomatoes1 = "";
        string ToppingOfGreenPeppers1 = "";
        string Size;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

           
         



        }

        private void PriceOfPizza_Click(object sender, EventArgs e)
        {
            TotalPrice = PriceOfSize + PriceOfCust + ToppingOfChess + 
                ToppingOfGreenPeppers + ToppingOfOlives + ToppingOfMashrom + ToppingOfOnion +    ToppingOfTomatoes;
       
            PriceOfPizza.Text="$"+Convert.ToString(TotalPrice);

           
            

        }

        private void SizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            
            PriceOfSize = 10;
            PriceOfPizza_Click((object)sender, new EventArgs());
            Size = "Small";
            label8_Click((object)sender, new EventArgs());
        }

        private void SizeMedium_CheckedChanged(object sender, EventArgs e)
        {

            PriceOfSize = 20;
            PriceOfPizza_Click((object)sender, new EventArgs());
            Size = "Medium";
            label8_Click((object)sender, new EventArgs());
        }

        private void SizeLarg_CheckedChanged(object sender, EventArgs e)
        {
            PriceOfSize = 30; 
            PriceOfPizza_Click((object)sender, new EventArgs());
            Size = "Larg";
            label8_Click((object)sender, new EventArgs());

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            PriceOfCust = 10;
            PriceOfPizza_Click((object)sender, new EventArgs());

            
                CrustType= "thinCust";
            label9_Click((object)sender, new EventArgs());


        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            PriceOfCust = 20;
            PriceOfPizza_Click((object)sender, new EventArgs());
            CrustType = "thinkCust";
            label9_Click((object)sender, new EventArgs());
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                ToppingOfChess = 5;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfChess = 0;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }



            if (checkBox4.Checked)
            {
                ToppingOfChess1 = "Extra Chess,";
                label13_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfChess1 = "";
                label13_Click((object)sender, new EventArgs());
            }


      
            

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                ToppingOfOnion = 5;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfOnion = 0;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }


            if (checkBox6.Checked)
            {
                ToppingOfOnion1 = "Oninon,";
                label13_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfOnion1 = "";
                label13_Click((object)sender, new EventArgs());
            }




        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                ToppingOfMashrom = 5;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfMashrom = 0;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }

            if (checkBox7.Checked)
            {
                ToppingOfMashrom1 = "Mashrom,";
                label13_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfMashrom1 = "";
                label13_Click((object)sender, new EventArgs());
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked)
            {
                ToppingOfOlives = 5;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfOlives = 0;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }


            if (checkBox1.Checked)
            {
                ToppingOfOlives1 = "Olives,";
                label13_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfOlives1 = "";
                label13_Click((object)sender, new EventArgs());
            }



     
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                ToppingOfTomatoes = 5;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfTomatoes = 0;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }

            if (checkBox2.Checked)
            {
                ToppingOfTomatoes1 = "Tomatoes,";
                label13_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfTomatoes1 = "";
                label13_Click((object)sender, new EventArgs());
            }



        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                ToppingOfGreenPeppers = 5;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfGreenPeppers = 0;
                PriceOfPizza_Click((object)sender, new EventArgs());
            }


            if (checkBox3.Checked)
            {
                ToppingOfGreenPeppers1 = "Extra Chess,";
                label13_Click((object)sender, new EventArgs());
            }
            else
            {
                ToppingOfGreenPeppers1 = "";
                label13_Click((object)sender, new EventArgs());
            }





        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
           





        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = CrustType;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Text = PlaceOfEat;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            PlaceOfEat = "Eat In";

            label12_Click((object)sender, new EventArgs());

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            PlaceOfEat = "Take Out";
            label12_Click((object)sender, new EventArgs());
        }

        private void label13_Click(object sender, EventArgs e)
        {

         ToppingTypes= ToppingOfGreenPeppers1 + ToppingOfOlives1 
                + ToppingOfMashrom1 + ToppingOfOnion1 + ToppingOfTomatoes1 + ToppingOfChess1;

            if (ToppingTypes == "")
            {
                ToppingTypes = "No Topping..";
            }


            label13.Text = ToppingTypes   +"." ;

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Confrim Order", "Confrim", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK){

                groupBox1. Enabled = false;
                groupBox2. Enabled = false;
                groupBox3. Enabled = false;
                groupBox4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;

             



            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled    =true;
            groupBox3.Enabled    =true;
            groupBox4.Enabled    =true;
            radioButton5.Enabled =true;
            radioButton6.Enabled = true;
            SizeSmall.Checked = false;
            SizeMedium.Checked = false;
            SizeLarg.Checked = false;
            Size = "No Size";
            label8_Click((object)sender, new EventArgs());
            radioButton5.Checked = false;
            radioButton6.Checked = false;


            CrustType = "No Type";
            label9_Click((object)sender, new EventArgs());

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            ToppingTypes = "No Type";
            PriceOfPizza_Click((object)sender, new EventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = Size;
        }
    }

}
