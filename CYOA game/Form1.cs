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
                    scene = 23;
                }
                else if (scene == 21)
                {
                    scene = 23;
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
                    scene = 23;
                }
                else if (scene == 16)
                {
                    scene = 23;
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

                }
            }

            switch (scene)
            {
                case 0:
                    outputLabel.Text = "Which Pizza Company";
                    redLabel.Text = "Pasaport";
                    blueLabel.Text = "Paisano's";
                    break;
                case 1:
                    outputLabel.Text = "What kind of pizza?";
                    redLabel.Text = "Hawaiian";
                    blueLabel.Text = "Canadian";
                    locationImage.Image = Properties.Resources.Paisanos_pizza;
                    break;
                case 2:
                    outputLabel.Text = "What kind of pizza?";
                    redLabel.Text = "Cheese";
                    blueLabel.Text = "Pepperoni";
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
                    subTotal = subTotal + canadianLPrice;
                    scene = 15;
                    break;
                case 8:
                    subTotal = subTotal + canadianSPrice;
                    scene = 15;
                    break;
                case 9:
                    subTotal = subTotal + hawaiianLPrice;
                    scene = 15;
                    break;
                case 10:
                    subTotal = subTotal + hawaiianSPrice;
                    scene = 15;
                    break;
                case 11:
                    subTotal = subTotal + pepperoniLPrice;
                    scene = 16;
                    break;
                case 12:
                    subTotal = subTotal + pepperoniSPrice;
                    scene = 16;
                    break;
                case 13:
                    subTotal = subTotal + cheeseLPrice;
                    scene = 16;
                    break;
                case 14:
                    subTotal = subTotal + cheeseSPrice;
                    scene = 16;
                    break;
                case 15:
                    outputLabel.Text = "Any sides or extras?";
                    redLabel.Text = "Nothing";
                    blueLabel.Text = "Chicken Wings";
                    break;
                case 16:
                    outputLabel.Text = "Any sides or extras?";
                    redLabel.Text = "Nothing";
                    blueLabel.Text = "Fries";
                    break;
                case 17:
                    outputLabel.Text = "Boneless?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 18:
                    outputLabel.Text = "What size?";
                    redLabel.Text = "Small";
                    blueLabel.Text = "Large";
                    break;
                case 19:
                    subTotal = subTotal + bonelessWingPrice;
                    scene = 23;
                    break;
                case 20:
                    subTotal = subTotal + boneWingPrice;
                    scene = 23;
                    break;
                case 21:
                    subTotal = subTotal + friesLPrice;
                    scene = 23;
                    break;
                case 22:
                    subTotal = subTotal + friesSPrice;
                    scene = 23;
                    break;
                case 23:
                    double total = taxFull * subTotal;
                    taxTotal = tax * subTotal;
                    outputLabel.Text = "Calculating...";
                    Thread.Sleep(300);
                    outputLabel.Text = "Subtotal: " + subTotal + "\nTax: " + taxTotal + "\nTotal: " + total;
                    Thread.Sleep(1000);
                    scene = 24;
                    break;
                case 24:
                    total = taxFull * subTotal;
                    outputLabel.Text = "Your total is " + total + "\n\n Would you like to tip?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 25:
                    outputLabel.Text = "How would you like to pay?";
                    redLabel.Text = "Cash";
                    blueLabel.Text = "Credit/Debit";
                    break;
                case 26:
                    outputLabel.Text = "Thank You! \nPlease Come Again!";
                    redLabel.Text = "Quit";
                    blueLabel.Text = "Shop Again";
                    break;
            }
        }
    }
}
