//Created by: Tyler Pogson
//Date: October 30, 2018
//Description: Choose your own adventure game of pizza ordering.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CYOA_game
{
    public partial class Form1 : Form
    {
        int scene = 0;

        //Paisano's prices
        const double canadianSPrice = 11.00;
        const double canadianLPrice = 15.00;
        const double hawaiianSPrice = 10.00;
        const double hawaiianLPrice = 14.00;
        const double boneWingPrice = 9.99;
        const double bonelessWingPrice = 8.99;

        //Pasaport's prices
        const double pepperoniSPrice = 8.95;
        const double pepperoniLPrice = 12.80;
        const double cheeseSPrice = 7.50;
        const double cheeseLPrice = 10.95;
        const double friesSPrice = 3.79;
        const double friesLPrice = 4.79;

        //Totals
        double subTotal = 0;
        double taxTotal = 0;
        const double tax = 0.13;
        const double taxFull = 1.13;
        

        public Form1()
        {
            InitializeComponent();
            //opening scene
            locationImage.Image = Properties.Resources.pizza;
            sideImageR.Visible = false;
            outputLabel.Text = "Which Pizza Company";
            redLabel.Text = "Pasaport";
            blueLabel.Text = "Paisano's";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.B) //when blue button is pressed, change the scene
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 9;
                }
                else if (scene == 5)
                {
                    scene = 11;
                }
                else if (scene == 6)
                {
                    scene = 13;
                }
                else if (scene == 7)
                {
                    scene = 15;
                }
                else if (scene == 9)
                {
                    scene = 15;
                }
                else if (scene == 11)
                {
                    scene = 16;
                }
                else if (scene == 13)
                {
                    scene = 16;
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
                else if (scene == 18)
                {
                    scene = 21;
                }
                else if (scene == 19)
                {
                    scene = 24;
                }
                else if (scene == 21)
                {
                    scene = 24;
                }
                else if (scene == 24)
                {
                    scene = 25;
                }
                else if (scene == 25)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 0;
                }
            }

            else if (e.KeyCode == Keys.M) //when the red button is pressed, change the scene
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 6;
                }
                else if (scene == 3)
                {
                    scene = 8;
                }
                else if (scene == 4)
                {
                    scene = 10;
                }
                else if (scene == 5)
                {
                    scene = 12;
                }
                else if (scene == 6)
                {
                    scene = 14;
                }
                else if (scene == 15)
                {
                    scene = 24;
                }
                else if (scene == 16)
                {
                    scene = 24;
                }
                else if (scene == 17)
                {
                    scene = 20;
                }
                else if (scene == 18)
                {
                    scene = 22;
                }
                else if (scene == 24)
                {
                    scene = 25;
                }
                else if (scene == 25)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)//when the black button is pressed, quit the program. 
            {
                Close();
            }

                switch (scene)
            {
                case 0:
                    locationImage.Image = Properties.Resources.pizza;
                    outputLabel.Text = "Which Pizza Company";
                    redLabel.Text = "Pasaport";
                    blueLabel.Text = "Paisano's";
                    break;
                case 1:
                    outputLabel.Text = "What kind of pizza?";
                    redLabel.Text = "Hawaiian";
                    blueLabel.Text = "Canadian";
                    sideImageR.Visible = false;
                    locationImage.Image = Properties.Resources.Paisanos_pizza;
                    break;
                case 2:
                    outputLabel.Text = "What kind of pizza?";
                    redLabel.Text = "Cheese";
                    blueLabel.Text = "Pepperoni";
                    sideImageR.Visible = false;
                    locationImage.Image = Properties.Resources.Pasaport_pizza;
                    break;
                case 3:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    break;
                case 4:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    break;
                case 5:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    break;
                case 6:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    break;
                case 7:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Chicken Wings";
                    sideImageL.Image = Properties.Resources.chickenwings;
                    subTotal = subTotal + canadianLPrice;
                    scene = 15;
                    break;
                case 8:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Chicken Wings";
                    sideImageL.Image = Properties.Resources.chickenwings;
                    subTotal = subTotal + canadianSPrice;
                    scene = 15;
                    break;
                case 9:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Chicken Wings";
                    sideImageL.Image = Properties.Resources.chickenwings;
                    subTotal = subTotal + hawaiianLPrice;
                    scene = 15;
                    break;
                case 10:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Chicken Wings";
                    sideImageL.Image = Properties.Resources.chickenwings;
                    subTotal = subTotal + hawaiianSPrice;
                    scene = 15;
                    break;
                case 11:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Fries";
                    sideImageL.Image = Properties.Resources.fries;
                    subTotal = subTotal + pepperoniLPrice;
                    scene = 16;
                    break;
                case 12:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Fries";
                    sideImageL.Image = Properties.Resources.fries;
                    subTotal = subTotal + pepperoniSPrice;
                    scene = 16;
                    break;
                case 13:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Fries";
                    sideImageL.Image = Properties.Resources.fries;
                    subTotal = subTotal + cheeseLPrice;
                    scene = 16;
                    break;
                case 14:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Fries";
                    sideImageL.Image = Properties.Resources.fries;
                    subTotal = subTotal + cheeseSPrice;
                    scene = 16;
                    break;
                case 15:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Chicken Wings";
                    sideImageL.Image = Properties.Resources.chickenwings;
                    break;
                case 16:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Fries";
                    sideImageL.Image = Properties.Resources.fries;
                    break;
                case 17:
                    sideImageR.Visible = true;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    outputLabel.Text = "Boneless?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 18:
                    sideImageR.Visible = true;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    break;
                case 19:
                    subTotal = subTotal + bonelessWingPrice;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    locationImage.Image = Properties.Resources.tip;
                    double total = taxFull * subTotal;
                    string total1 = total.ToString("C");
                    outputLabel.Text = "Your total is " + total1 + "\n\nWould you like to tip?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    scene = 24;
                    break;
                case 20:
                    subTotal = subTotal + boneWingPrice;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    locationImage.Image = Properties.Resources.tip;
                    total = taxFull * subTotal;
                    total1 = total.ToString("C");
                    outputLabel.Text = "Your total is " + total1 + "\n\nWould you like to tip?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    scene = 24;
                    break;
                case 21:
                    subTotal = subTotal + friesLPrice;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    locationImage.Image = Properties.Resources.tip;
                    total = taxFull * subTotal;
                    total1 = total.ToString("C");
                    outputLabel.Text = "Your total is " + total1 + "\n\nWould you like to tip?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    scene = 24;
                    break;
                case 22:
                    subTotal = subTotal + friesSPrice;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    locationImage.Image = Properties.Resources.tip;
                    total = taxFull * subTotal;
                    total1 = total.ToString("C");
                    outputLabel.Text = "Your total is " + total1 + "\n\nWould you like to tip?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    scene = 24;
                    break;
                case 23:
                    sideImageR.Visible = false;
                    sideImageL.Image = null;
                    total = taxFull * subTotal;
                    taxTotal = tax * subTotal;
                    string tax1 = taxTotal.ToString("C");
                    total1 = total.ToString("C");
                    string subTotal1 = subTotal.ToString("C");
                    outputLabel.Text = "Subtotal: " + subTotal1 + "\nTax:      " + tax1 + "\nTotal:    " + total1;
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 24:
                    sideImageR.Visible = false;
                    sideImageL.Image = null;
                    locationImage.Image = Properties.Resources.tip;
                    total = taxFull * subTotal;
                    total1 = total.ToString("C");
                    outputLabel.Text = "Your total is " + total1 + "\n\nWould you like to tip?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 25:
                    sideImageR.Visible = false;
                    locationImage.Image = Properties.Resources.pay;
                    outputLabel.Text = "How would you like to pay?";
                    redLabel.Text = "Cash";
                    blueLabel.Text = "Credit/Debit";
                    break;
                case 26:
                    locationImage.Image = Properties.Resources.have_nice_day;
                    outputLabel.Text = "Thank You! \nPlease Come Again!";
                    subTotal = 0;
                    total = 0;
                    redLabel.Text = "Quit";
                    blueLabel.Text = "Shop Again";
                    break;
                }
        }
    }
}
