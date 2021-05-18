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
using System.Media;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        int pageChance;

        Random RandGen = new Random();      // create random number generator

        public Form1()
        {
            InitializeComponent();
            // Display initial message and options
            DisplayPage();
        }
        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2) { page = 6; }
            else if (page == 3) { page = 1; }
            else if (page == 4) { page = 1; }
            else if (page == 5) { page = 1; }
            else if (page == 6) { page = 8; }
            else if (page == 7) { page = 10; }
            else if (page == 8) { page = 1; }
            else if (page == 9) { page = 12; }
            else if (page == 10) { page = 1; }
            else if (page == 11)
            {
                pageChance = RandGen.Next(1, 101);
                if (pageChance > 50)
                {
                    page = 15;
                }
                else
                {
                    page = 16;
                }
            }
            else if (page == 12) { page = 17; }
            else if (page == 13) { page = 1; }
            else if (page == 14) { page = 1; }
            else if (page == 15) { page = 1; }
            else if (page == 16) { page = 1; }
            else if (page == 17) { page = 19; }
            else if (page == 18)
            {
                pageChance = RandGen.Next(1, 101);
                if (pageChance > 70)
                {
                     page = 22; 
                }
                else
                {
                    page = 23;
                }
            } 
            else if (page == 19) { page = 1; }
            else if (page == 20) { page = 1; }
            else if (page == 21) { page = 1; }
            else if (page == 22) { page = 24; }
            else if (page == 23) { page = 1; }
            else if (page == 24) { page = 26; }
            else if (page == 25) { page = 1; }
            else if (page == 26) { page = 1; }
            else if (page == 27) { page = 1; }
            /// Display text and game options to screen based on the 
            /// current page
            DisplayPage();
        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 7; }
            else if (page == 3) { page = 30; }
            else if (page == 4) { page = 30; }
            else if (page == 5) { page = 30; }
            else if (page == 6) { page = 9; }
            else if (page == 7) { page = 11; }
            else if (page == 8) { page = 30; }
            else if (page == 9) { page = 13; }
            else if (page == 10) { page = 30; }
            else if (page == 11) { page = 14; }
            else if (page == 12) { page = 18; }
            else if (page == 13) { page = 30; }
            else if (page == 14) { page = 30; }
            else if (page == 15) { page = 30; }
            else if (page == 16) { page = 30; }
            else if (page == 17) { page = 20; }
            else if (page == 18) { page = 21; }
            else if (page == 19) { page = 30; }
            else if (page == 20) { page = 30; }
            else if (page == 21) { page = 30; }
            else if (page == 22) { page = 25; }
            else if (page == 23) { page = 30; }
            else if (page == 24) { page = 27; }
            else if (page == 25) { page = 30; }
            else if (page == 26) { page = 30; }
            else if (page == 27) { page = 30; }
            DisplayPage();
        }
        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                pageChance = RandGen.Next(1, 101);
                if (pageChance < 20)
                {
                    page = 4;
                }
                else
                {
                    page = 5;
                }
            }
            DisplayPage();
        }
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "The King summons you to his castle. He sets you on a quest to find the lost princess.";
                    option1Label.Text = "Accept";
                    option2Label.Text = "Disobey";
                    option3Label.Text = "Overthrow the king";
                    break;
                case 2:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "The king offer to send a companion with you";
                    option1Label.Text = "Accept";
                    option2Label.Text = "Decline";
                    break;
                case 3:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "The King comes down from his thrown, draws his sword and chops your head off. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You run as fast as lighting straight to the king and slice his head off. The town thanks you for ending his horrible rein and make you king. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "The king and his guards jump on you as soon as you stand and beat you to a pulp. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "You set off on your quest but very slowly because your new companion is extremely slow";
                    option1Label.Text = "Go North";
                    option2Label.Text = "Go South";
                    break;
                case 7:
                    outputLabel.Text = "You set off on your quest with swift speed and are confident you will find the princess within hours.";
                    option1Label.Text = "Go North";
                    option2Label.Text = "Go South";
                    break;
                case 8:
                    outputLabel.Text = "You come across a house where you find the princess. You bring her back to the king and he thanks you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "You fall into a pit because you were running too fast and become trapped.";
                    option1Label.Text = "Ask companion for help";
                    option2Label.Text = "Try to get out alone";
                    break;
                case 10:
                    outputLabel.Text = "You come across a house where you find the princess. You bring her back to the king and he thanks you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "You fall into a pit because you were running too fast and become trapped. ";
                    option1Label.Text = "Try to get out";
                    option2Label.Text = "Give up";
                    break;
                case 12:
                    outputLabel.Text = "Your companion gives you a hand and helps you out. You guys grow tired as night falls.";
                    option1Label.Text = "Go to the nearby village and rest";
                    option2Label.Text = "Keep searching";
                    break;
                case 13:
                    outputLabel.Text = "You try to get out alone but fall backwards and crack your head. You die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "You stay trapped in the pit forever and die from starvation. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "As soon as you escape from the pit you get trampled by horse and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 16:
                    outputLabel.Text = "You fall backwards trying to escape, break your neck and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "You travel to the village. You find an inn and spend the night there. When you wake a mysterious man tells you where the princess is located ";
                    option1Label.Text = "Believe him";
                    option2Label.Text = "Don't believe him ";
                    break;
                case 18:
                    outputLabel.Text = "You run into a pack of blood hungry wolves. But luckily you're a natural wolf whisperer. ";
                    option1Label.Text = "Tame the wolves";
                    option2Label.Text = "Fight the wolves";
                    break;
                case 19:
                    outputLabel.Text = "You arrive where the mysterious man told you to go. The lost princess is there You bring her back to the castle and complete your quest. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 20:
                    outputLabel.Text = "You don't believe him and you are not able to find the princess. She is lost forever. You fail. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 21:
                    outputLabel.Text = "Your companion is scared to death of wolves which leads you to be eaten alive. You die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 22:
                    outputLabel.Text = "You tame the wolves and take them on your quest. The wolves pick up 2 scents of the princess";
                    option1Label.Text = "Scent 1";
                    option2Label.Text = "Scent 2";
                    break;
                case 23:
                    outputLabel.Text = "The wolves eat you alive and you die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 24:
                    outputLabel.Text = "The wolves take you to a village where you meet a mysterious man. He tells you the location of the princess";
                    option1Label.Text = "Believe him";
                    option2Label.Text = "Don't believe him";
                    break;
                case 25:
                    outputLabel.Text = "You follow the dogs to a house. When you go inside you find the lost princess. You bring her back to the castle and complete your quest. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 26:
                    outputLabel.Text = "You arrive where the mysterious man told you to go. The lost princess is there. You bring her back to the castle and complete your quest. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 27:
                    outputLabel.Text = "The dogs lose the other scent of the princess. you are not able to find the princess. She is lost forever. You fail. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 30:
                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(200);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
