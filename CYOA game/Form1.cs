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

        //Domino's prices
        const double canadianSPrice = 11.00;
        const double canadianLPrice = 15.00;
        const double hawaiianSPrice = 10.00;
        const double hawaiianLPrice = 14.00;
        const double boneWingPrice = 9.99;
        const double bonelessWingPrice = 8.99;

        //Pizza Pizza prices
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
            outputLabel.Text = "Which Pizza Company";
            redLabel.Text = "Pasaport";
            blueLabel.Text = "Paisano's";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.B) //blue button
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
                    Thread.Sleep(100);
                    scene = 15;
                }
                else if (scene == 4)
                {
                    scene = 9;
                    Thread.Sleep(100);
                    scene = 15;
                }
                else if (scene == 5)
                {
                    scene = 11;
                    Thread.Sleep(100);
                    scene = 16;
                }
                else if (scene == 6)
                {
                    scene = 13;
                    Thread.Sleep(100);
                    scene = 16;
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
                    Thread.Sleep(100);
                    scene = 24;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 19;
                    Thread.Sleep(100);
                    scene = 24;
                }
                else if (scene == 18)
                {
                    scene = 21;
                    Thread.Sleep(100);
                    scene = 24;
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

            else if (e.KeyCode == Keys.M) //red button
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
                    Thread.Sleep(100);
                    scene = 15;
                }
                else if (scene == 4)
                {
                    scene = 10;
                    Thread.Sleep(100);
                    scene = 15;
                }
                else if (scene == 5)
                {
                    scene = 12;
                    Thread.Sleep(100);
                    scene = 16;
                }
                else if (scene == 6)
                {
                    scene = 14;
                    Thread.Sleep(100);
                    scene = 16;
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
                    Thread.Sleep(100);
                    scene = 24;
                }
                else if (scene == 18)
                {
                    scene = 22;
                    Thread.Sleep(100);
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
                    Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

                switch (scene)
            {
                case 0:
                    outputLabel.Text = "Which Pizza Company";
                    redLabel.Text = "Pasaport";
                    blueLabel.Text = "Paisano's";
                    sceneTest.Text = "0";
                    break;
                case 1:
                    outputLabel.Text = "What kind of pizza?";
                    redLabel.Text = "Hawaiian";
                    blueLabel.Text = "Canadian";
                    sideImageR.Visible = false;
                    locationImage.Image = Properties.Resources.Paisanos_pizza;
                    sceneTest.Text = "1";
                    break;
                case 2:
                    outputLabel.Text = "What kind of pizza?";
                    redLabel.Text = "Cheese";
                    blueLabel.Text = "Pepperoni";
                    sideImageR.Visible = false;
                    locationImage.Image = Properties.Resources.Pasaport_pizza;
                    sceneTest.Text = "2";
                    break;
                case 3:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    sceneTest.Text = "3";
                    break;
                case 4:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    sceneTest.Text = "4";
                    break;
                case 5:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    sceneTest.Text = "5";
                    break;
                case 6:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    sceneTest.Text = "6";
                    break;
                case 7:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + canadianLPrice;
                    sceneTest.Text = "7";
                    break;
                case 8:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + canadianSPrice;
                    sceneTest.Text = "8";
                    break;
                case 9:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + hawaiianLPrice;
                    sceneTest.Text = "9";
                    break;
                case 10:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + hawaiianSPrice;
                    sceneTest.Text = "10";
                    break;
                case 11:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + pepperoniLPrice;
                    sceneTest.Text = "11";
                    break;
                case 12:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + pepperoniSPrice;
                    sceneTest.Text = "12";
                    break;
                case 13:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + cheeseLPrice;
                    sceneTest.Text = "13";
                    break;
                case 14:
                    outputLabel.Text = "What size? \nClick again. ";
                    subTotal = subTotal + cheeseSPrice;
                    sceneTest.Text = "14";
                    break;
                case 15:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Chicken Wings";
                    sideImageL.Image = Properties.Resources.chickenwings;
                    sceneTest.Text = "15";
                    break;
                case 16:
                    outputLabel.Text = "Any sides or extras?";
                    locationImage.Image = null;
                    sideImageR.Visible = true;
                    redLabel.Text = "Nothing";
                    sideImageR.Image = Properties.Resources.nothing;
                    blueLabel.Text = "Fries";
                    sideImageL.Image = Properties.Resources.fries;
                    sceneTest.Text = "16";
                    break;
                case 17:
                    sideImageR.Visible = true;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    outputLabel.Text = "Boneless?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    sceneTest.Text = "17";
                    break;
                case 18:
                    sideImageR.Visible = true;
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    sceneTest.Text = "18";
                    break;
                case 19:
                    outputLabel.Text = "Boneless? \nClick again";
                    subTotal = subTotal + bonelessWingPrice;
                    sceneTest.Text = "19";
                    break;
                case 20:
                    outputLabel.Text = "Boneless? \nClick again.";
                    subTotal = subTotal + boneWingPrice;
                    sceneTest.Text = "20";
                    break;
                case 21:
                    outputLabel.Text = "What size? \nClick again.";
                    subTotal = subTotal + friesLPrice;
                    sceneTest.Text = "21";
                    break;
                case 22:
                    outputLabel.Text = "What size? \nClick again.";
                    subTotal = subTotal + friesSPrice;
                    sceneTest.Text = "22";
                    break;
                case 23:
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    double total = taxFull * subTotal;
                    taxTotal = tax * subTotal;
                    string tax1 = taxTotal.ToString("C");
                    string total1 = total.ToString("C");
                    string subTotal1 = subTotal.ToString("C");
                    outputLabel.Text = "Subtotal: " + subTotal1 + "\nTax:      " + tax1 + "\nTotal:    " + total1;
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    sceneTest.Text = "23";
                    break;
                case 24:
                    sideImageR.Image = null;
                    sideImageL.Image = null;
                    total = taxFull * subTotal;
                    total1 = total.ToString("C");
                    outputLabel.Text = "Your total is " + total1 + "\n\nWould you like to tip?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    sceneTest.Text = "24";
                    break;
                case 25:
                    outputLabel.Text = "How would you like to pay?";
                    redLabel.Text = "Cash";
                    blueLabel.Text = "Credit/Debit";
                    sceneTest.Text = "25";
                    break;
                case 26:
                    outputLabel.Text = "Thank You! \nPlease Come Again!";
                    redLabel.Text = "Quit";
                    blueLabel.Text = "Shop Again";
                    sceneTest.Text = "26";
                    break;
            }
        }
    }
}
