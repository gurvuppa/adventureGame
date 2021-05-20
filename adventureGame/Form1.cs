/*
 * Gurvir Uppal
 * Adventure Game (The Search)
 * May 19, 2021 
 * Mr.T 
 * ICS3U
 * */
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

        SoundPlayer musicPlayer;

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
                if (pageChance > 50)                      //50% chance of getting this outcome
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
                if (pageChance > 70)                      //70% chance of getting this outcome
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
                if (pageChance < 20)                             //20% chance of getting this outcome
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
                    option3Button.Visible = true;                                           //set button 3's visibility to true 
                    option3Label.Visible = true;                                            //set label 3's visibility to true

                    musicPlayer = new SoundPlayer(Properties.Resources.questSound);
                    musicPlayer.Play();                                                     //play music player 

                    imageBox.Image = Properties.Resources.kneelingKnight;                   //print this image in the image box

                    outputLabel.Text = "The King summons you to his castle. He sets you on a quest to find the lost princess.";
                    option1Label.Text = "Accept";
                    option2Label.Text = "Disobey";
                    option3Label.Text = "Overthrow the king";
                    break;
                case 2:
                    option3Button.Visible = false;                                      //set button 3's visibility to false
                    option3Label.Visible = false;                                       //set label 3's visibility to false

                    imageBox.Image = Properties.Resources.twoKights;

                    outputLabel.Text = "The king offers to send a companion with you";
                    option1Label.Text = "Accept";
                    option2Label.Text = "Decline";
                    break;
                case 3:
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    musicPlayer = new SoundPlayer(Properties.Resources.knightDeath);
                    musicPlayer.Play();

                    imageBox.Image = Properties.Resources.king_killing_man;

                    outputLabel.Text = "The King comes down from his thrown, draws his sword and chops your head off. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    musicPlayer = new SoundPlayer(Properties.Resources.deathGrunt);
                    musicPlayer.Play();

                    imageBox.Image = Properties.Resources.killingTheKing;

                    outputLabel.Text = "You run as fast as lighting straight to the king and slice his head off. The town thanks you for ending his horrible rein and makes you king. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    musicPlayer = new SoundPlayer(Properties.Resources.deathSound);
                    musicPlayer.Play();

                    imageBox.Image = Properties.Resources.Dark_Souls_You_Died_Screen___Completely_Black_Screen_0_2_screenshot;

                    outputLabel.Text = "The king and his guards jump on you as soon as you stand and beat you to a pulp. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    imageBox.Image = Properties.Resources._2_knights_by_the1337chef_d4uzxv0_fullview;

                    musicPlayer = new SoundPlayer(Properties.Resources.slowWalking);
                    musicPlayer.Play();

                    outputLabel.Text = "You set off on your quest but very slowly because your new companion is extremely slow";
                    option1Label.Text = "Go North";
                    option2Label.Text = "Go South";
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.knight_riding_horse_shield_lance_flag_drawing_by_apatrimonio_davoj3d_fullview;

                    musicPlayer = new SoundPlayer(Properties.Resources.horseRunning);
                    musicPlayer.Play();

                    outputLabel.Text = "You set off on your quest with swift speed and are confident you will find the princess within hours.";
                    option1Label.Text = "Go North";
                    option2Label.Text = "Go South";
                    break;
                case 8:
                    imageBox.Image = Properties.Resources.kingThanking_you;

                    musicPlayer = new SoundPlayer(Properties.Resources.questComplete);
                    musicPlayer.Play();

                    outputLabel.Text = "You come across a house where you find the princess. You bring her back to the king and he thanks you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    imageBox.Image = Properties.Resources.deepPit;

                    musicPlayer = new SoundPlayer(Properties.Resources.Wind);
                    musicPlayer.Play();

                    outputLabel.Text = "You fall into a pit because you were running too fast and become trapped.";
                    option1Label.Text = "Ask companion for help";
                    option2Label.Text = "Try to get out alone";
                    break;
                case 10:
                    imageBox.Image = Properties.Resources.kingThanking_you;

                    musicPlayer = new SoundPlayer(Properties.Resources.questComplete);
                    musicPlayer.Play();

                    outputLabel.Text = "You come across a house where you find the princess. You bring her back to the king and he thanks you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    imageBox.Image = Properties.Resources.deepPit;

                    musicPlayer = new SoundPlayer(Properties.Resources.Wind);
                    musicPlayer.Play();

                    outputLabel.Text = "You fall into a pit because you were riding your horse too fast and become trapped.";
                    option1Label.Text = "Try to get out";
                    option2Label.Text = "Give up";
                    break;
                case 12:
                    imageBox.Image = Properties.Resources.helpingHand;

                    musicPlayer = new SoundPlayer(Properties.Resources.liftingSound);
                    musicPlayer.Play();

                    outputLabel.Text = "Your companion gives you a hand and helps you out. You grow tired as night falls.";
                    option1Label.Text = "Go to the nearby village and rest";
                    option2Label.Text = "Keep searching";
                    break;
                case 13:
                    imageBox.Image = Properties.Resources.Dark_Souls_You_Died_Screen___Completely_Black_Screen_0_2_screenshot;

                    musicPlayer = new SoundPlayer(Properties.Resources.deathSound);
                    musicPlayer.Play();

                    outputLabel.Text = "You try to get out alone but fall backwards and crack your head. You die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 14:
                    imageBox.Image = Properties.Resources.Dark_Souls_You_Died_Screen___Completely_Black_Screen_0_2_screenshot;

                    musicPlayer = new SoundPlayer(Properties.Resources.deathSound);
                    musicPlayer.Play();

                    outputLabel.Text = "You stay trapped in the pit forever and die from starvation. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    imageBox.Image = Properties.Resources.Dark_Souls_You_Died_Screen___Completely_Black_Screen_0_2_screenshot;

                    musicPlayer = new SoundPlayer(Properties.Resources.deathSound);
                    musicPlayer.Play();

                    outputLabel.Text = "As soon as you escape from the pit you get trampled by horse and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 16:
                    imageBox.Image = Properties.Resources.Dark_Souls_You_Died_Screen___Completely_Black_Screen_0_2_screenshot;

                    musicPlayer = new SoundPlayer(Properties.Resources.deathSound);
                    musicPlayer.Play();

                    outputLabel.Text = "You fall backwards trying to escape, break your neck and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    imageBox.Image = Properties.Resources.mysteryManBetter;

                    musicPlayer = new SoundPlayer(Properties.Resources.creepyLaugh);
                    musicPlayer.Play();

                    outputLabel.Text = "You travel to the village. You find an inn and spend the night there. When you wake a mysterious man tells you where the princess is located ";
                    option1Label.Text = "Believe him";
                    option2Label.Text = "Don't believe him ";
                    break;
                case 18:
                    imageBox.Image = Properties.Resources.hungryWolves;

                    musicPlayer = new SoundPlayer(Properties.Resources.wolfHowl);
                    musicPlayer.Play();

                    outputLabel.Text = "You run into a pack of blood hungry wolves. But luckily you're a natural wolf whisperer. ";
                    option1Label.Text = "Tame the wolves";
                    option2Label.Text = "Fight the wolves";
                    break;
                case 19:
                    imageBox.Image = Properties.Resources.betterImageOfHouse;

                    musicPlayer = new SoundPlayer(Properties.Resources.questComplete);
                    musicPlayer.Play();

                    outputLabel.Text = "You arrive where the mysterious man told you to go. The lost princess is there. You bring her back to the castle and complete your quest. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 20:
                    imageBox.Image = Properties.Resources.questFaild;

                    musicPlayer = new SoundPlayer(Properties.Resources.failed);
                    musicPlayer.Play();

                    outputLabel.Text = "You don't believe him and you are not able to find the princess. She is lost forever. You fail. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 21:
                    imageBox.Image = Properties.Resources.betterBitingWolve;

                    musicPlayer = new SoundPlayer(Properties.Resources.wolfGrowl);
                    musicPlayer.Play();

                    outputLabel.Text = "Your companion is scared to death by wolves which leads you to be eaten alive. You die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 22:
                    imageBox.Image = Properties.Resources.happyWolves;

                    musicPlayer = new SoundPlayer(Properties.Resources.questComplete);
                    musicPlayer.Play();

                    outputLabel.Text = "You tame the wolves and take them on your quest. The wolves pick up 2 scents of the princess";
                    option1Label.Text = "Scent 1";
                    option2Label.Text = "Scent 2";
                    break;
                case 23:
                    imageBox.Image = Properties.Resources.Dark_Souls_You_Died_Screen___Completely_Black_Screen_0_2_screenshot;

                    musicPlayer = new SoundPlayer(Properties.Resources.deathSound);
                    musicPlayer.Play();

                    outputLabel.Text = "The wolves eat you alive and you die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 24:
                    imageBox.Image = Properties.Resources.mysteryManBetter;

                    musicPlayer = new SoundPlayer(Properties.Resources.creepyLaugh);
                    musicPlayer.Play();

                    outputLabel.Text = "The wolves take you to a village where you meet a mysterious man. He tells you the location of the princess";
                    option1Label.Text = "Believe him";
                    option2Label.Text = "Don't believe him";
                    break;
                case 25:
                    imageBox.Image = Properties.Resources.kingThanking_you;

                    musicPlayer = new SoundPlayer(Properties.Resources.questComplete);
                    musicPlayer.Play();

                    outputLabel.Text = "You follow the wolves to a house. When you go inside you find the lost princess. You bring her back to the castle and complete your quest. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 26:
                    imageBox.Image = Properties.Resources.kingThanking_you;

                    musicPlayer = new SoundPlayer(Properties.Resources.questComplete);
                    musicPlayer.Play();

                    outputLabel.Text = "You arrive where the mysterious man told you to go. The lost princess is there. You bring her back to the castle and complete your quest. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 27:
                    imageBox.Image = Properties.Resources.questFaild;

                    musicPlayer = new SoundPlayer(Properties.Resources.failed);
                    musicPlayer.Play();

                    outputLabel.Text = "The wolves lose the other scent of the princess. you are not able to find the princess. She is lost forever. You fail. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 30:
                    imageBox.Image = Properties.Resources.gamOver;

                    musicPlayer = new SoundPlayer(Properties.Resources.gameOver);
                    musicPlayer.Play();

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
