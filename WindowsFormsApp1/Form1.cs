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

//Gerber, Joey
//Mr. T
//ICU3U
//Feb 26th



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random randgen = new Random();
        SoundPlayer xplodeplayer = new SoundPlayer(Properties.Resources.Bomb_Exploding_Sound_Explorer_68256487);
        SoundPlayer ufoplayer = new SoundPlayer(Properties.Resources.UFO_Takeoff_Sonidor_1604321570);
        SoundPlayer chokeplayer = new SoundPlayer(Properties.Resources.neck_snap);


        public Form1()
        {
            InitializeComponent();
            this.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M) //green
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 99; }
                else if (scene == 4) { scene = 13; }
                else if (scene == 5) { scene = 13; }
                else if (scene == 6) { scene = 5; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { scene = 13; }
                else if (scene == 9) { scene = 17; }
                else if (scene == 10) { } //nothing
                else if (scene == 11) { scene = 19; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 14) { } //nothing
                else if (scene == 15) { scene = 99; }
                else if (scene == 16) { scene = 19; }
                else if (scene == 17) { scene = 19; }
                else if (scene == 18) { } // nothing
                else if (scene == 19) { scene = 20; }
                else if (scene == 20) { scene = 99; }
                else if (scene == 21) { scene = 20; }
                else if (scene == 22) { scene = 26; }
                else if (scene == 23) { scene = 25; }
                else if (scene == 24) { scene = 99; }
                else if (scene == 25) { scene = 30; }
                else if (scene == 26) { scene = 27; }
                else if (scene == 27) { scene = 30; }
                else if (scene == 28) { }
                else if (scene == 29) { scene = 99; }
                else if (scene == 30) { scene = 31; }
                else if (scene == 31) { scene = 99; }
                else if (scene == 32) { scene = 99; }
                else if (scene == 33) { }
                else if (scene == 34) { }
                else if (scene == 99) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)
            {
                //red button.

                if (scene == 0) { scene = 5; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 99; }
                else if (scene == 4) { scene = 10; }
                else if (scene == 5) { scene = 10; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 10)
                {
                    int chance = randgen.Next(1, 4);
                    if (chance == 3) { scene = 11; }
                    else { scene = 12; } //33% chance of continue, 66% chance of game over (roughly)

                }
                else if (scene == 11) { scene = 19; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 10; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 16) { scene = 19; }
                else if (scene == 17) { scene = 19; }
                else if (scene == 18) { } //nothing
                else if (scene == 19) { scene = 21; }
                else if (scene == 20) { scene = 99; }
                else if (scene == 21) { scene = 22; }
                else if (scene == 22) { scene = 23; }
                else if (scene == 23) { scene = 24; }
                else if (scene == 24) { scene = 99; }
                else if (scene == 25) { scene = 30; }
                else if (scene == 26) { scene = 29; }
                else if (scene == 27) { scene = 30; }
                else if (scene == 28) { } //nothing
                else if (scene == 29) { scene = 99; }
                else if (scene == 30) { scene = 32; }
                else if (scene == 31) { scene = 99; }
                else if (scene == 32) { scene = 99; }
                else if (scene == 33) { }
                else if (scene == 34) { }
                else if (scene == 99)
                {
                    scene = 100;
                }
            }
            else if (e.KeyCode == Keys.N) //orange button.
            {
                if (scene == 0) { scene = 6; }
                else if (scene == 4) { scene = 9; }
                else if (scene == 5) { scene = 9; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 19) { scene = 22; }
                else if (scene == 14) { scene = 9; }
            }




            switch (scene)
            {
                case 0:
                    storyLabel.Text = "You are a crew member aboard the Archangel, an exploration vessel. What is your occupation?";
                    redButton.Text = "Pilot";
                    orangeButton.Text = "Scientist";
                    greenButton.Text = "Engineer";
                    storyImage.BackgroundImage = Properties.Resources.archangel;
                    ufoplayer.Play();  
                    Refresh();
                    break;
                case 1:
                    storyLabel.Text = $"You are working on the main engines when suddenly you hear some shouting. \n The Captain of the Ship and the head scientist are bickering, more violently than typical. ?";
                    redButton.Text = "Better stick with my job, no need to listen to work gossip.";
                    orangeButton.Text = "";
                    greenButton.Text = "This is interesting, I am going to pay attention.";
                    storyImage.BackgroundImage = Properties.Resources.engine;
                    xplodeplayer.Play();
                    Refresh();

                    break;
                case 2:
                    storyLabel.Text = $"You notice that several parts of the engine, \n critical parts are highlighted in red. \n Looking through the window at the machine in question allows you to see visible smoke.";
                    redButton.Text = "Its no use, I'm out of here.";
                    orangeButton.Text = "";
                    greenButton.Text = "I need to fix it! Everybody get out before it blows!";
                    storyImage.BackgroundImage = Properties.Resources.engine;

                    Refresh();

                    break;
                case 3:
                    storyLabel.Text = $"Not okay! somebody shouts, while another voice says: The course of action is necessary. An explosion breaks out and you feel the cold embrace of the void.";
                    redButton.Text = "Game Over";
                    orangeButton.Text = "Game Over";
                    greenButton.Text = "Game Over";
                    storyImage.BackgroundImage = Properties.Resources.explosion;
                    xplodeplayer.Play();


                    Refresh();

                    break;
                case 4:
                    storyLabel.Text = "You make a run for it, to the surprise of your colleagues. Then, you hear the explosion. Diving out of the room, you realize you are probably the last Engineer left on board.";
                    redButton.Text = "I can be of use in the control room.";
                    orangeButton.Text = "I can be of use in the cockpit.";
                    greenButton.Text = "I should get to the saferoom. That is protocol.";
                    storyImage.BackgroundImage = Properties.Resources.display;
                    xplodeplayer.Play();

                    Refresh();

                    break;
                case 5:
                    storyLabel.Text = $"You are lounging in your quarters (you are off duty, for now) when you hear a resounding crash.";
                    redButton.Text = "I'm going to take cover in the closest room I can find";
                    orangeButton.Text = "I can be of use in the cockpit.";
                    greenButton.Text = "I should get to the saferoom. That is protocol.";
                    storyImage.BackgroundImage = Properties.Resources.archangel;

                    Refresh();

                    break;
                case 6:
                    storyLabel.Text = "You are waiting with eager anticipation, when suddenly you are summoned to the Control Room";
                    redButton.Text = "I'm ready to report for duty";
                    orangeButton.Text = "";
                    greenButton.Text = "If they really need me, they will call again. I don't need to leave my quarters.";
                    storyImage.BackgroundImage = Properties.Resources.archangel;

                    Refresh();

                    break;
                case 7:
                    storyLabel.Text = "You reach the control room. You! the captain says. Tell your boss here that genocide is immoral.";
                    redButton.Text = "Any sort of killing is an evil act. I don't know how you can even be having an argument about this.";
                    greenButton.Text = "I mean, the needs of many...";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.archangel;

                    Refresh();

                    break;
                case 8:
                    storyLabel.Text = $"The Captain won't budge. After a heated conversation, the head scientist lunges at the Captain, brutally stabbing him as you watch in horror. You hear an explosion, as the scientist turns towards you, knife in hand.";
                    redButton.Text = "I'm gonna run and hide.";
                    orangeButton.Text = "Lets get to the cockpit.";
                    greenButton.Text = "I should get to the saferoom. That is protocol. Hopefully he doesn't follow me.";
                    storyImage.BackgroundImage = Properties.Resources.display;

                    Refresh();

                    break;
                case 9:
                    storyLabel.Text = "The pilots are panicking. You have some experience yourself though, and could try to land it. Or you could trust their abilities and attempt to access the ships database to see what is going on.";
                    redButton.Text = "Step aside, I know what I'm doing (grab controls)";
                    greenButton.Text = "Let's see what is going on... (check mission database)";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.cockpit;
                    Refresh();
                    break;
                case 10:
                    storyLabel.Text = "You brace yourself, as the ship crash lands";
                    redButton.Text = "Continue";
                    greenButton.Text = "Continue";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.explosion;

                    break;
                case 11:
                    storyLabel.Text = "The room closes in on you. You are heavily jarred by the impact.";
                    redButton.Text = "Continue";
                    greenButton.Text = "Continue";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.beam;

                    break;
                case 12:
                    storyLabel.Text = "The room closes in on you. A steel beam impales you.";
                    redButton.Text = "Game over";
                    greenButton.Text = "Game over";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.beam;
                    break;
                case 13:
                    storyLabel.Text = "You reach the safe-room with the rest of the crew. The ship is going down fast. Would you like to study the rooms integrity?";
                    redButton.Text = "I better be safe and take a look.";
                    greenButton.Text = "By the time I figure that out, ship could be gone.";
                    storyImage.BackgroundImage = Properties.Resources.display;
                    break;
                case 14:
                    storyLabel.Text = "After checking the monitor, you rule that the ships exoskeleton is heavily damaged, thus exposing the safe room.";
                    redButton.Text = "Continue";
                    greenButton.Text = "Continue";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.display;
                    break;
                case 15:
                    storyLabel.Text = "relieved, you wait with the rest of the crew. Suddenly, the chamber starts to crumble.Your last moments are full of panic, when suddenly you are shattered.";
                    redButton.Text = "Game Over";
                    greenButton.Text = "Game Over";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.beam;
                    break;
                case 16:
                    storyLabel.Text = "You land the ship in a massive crash upon the deserted world. The cockpit manages to defend against the impact.";
                    redButton.Text = "Phew";
                    greenButton.Text = "What a ride";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.alienworld1;

                    break;
                case 17:
                    storyLabel.Text = $"You read the mission transcript: \n Fat Man \n The true cargo of this ship must not be compromised, Dr. Lewwings. \n If nothing else is possible, due to an issue, plant explosives on the following key engine parts. \n This obscure crash will result in the toxication and death of an alien species. Humanity shall claim superiority yet again...";
                    redButton.Text = "There is a stunning impact.";
                    greenButton.Text = "Ouch!";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.display;

                    break;
                case 18:
                    break;
                case 19:
                    storyLabel.Text = "You open your eyes as the dust settles. You are on some alien world. ";
                    redButton.Text = "Maybe some of the others survived in the safe-room.";
                    greenButton.Text = "Lets take a look at the surroundings (exit the ship)";
                    orangeButton.Text = "I might try to find some equipment, see what I can do with it.";
                    storyImage.Image = Properties.Resources.alienworld1;
                    break;
                case 20:
                    storyLabel.Text = "Your head feels as though it is going to explode. You try to make it back, then you see nothing..";
                    redButton.Text = "Game over";
                    greenButton.Text = "Game over";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.alienworld1;

                    break;
                case 21:
                    storyLabel.Text = "There are no survivors. The whole place is caved in.";
                    redButton.Text = "Lets look for equipment";
                    greenButton.Text = "Lets try to see if anyone made it outside.";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.beam;
                    break;
                case 22:
                    storyLabel.Text = "You locate two chambers that are still intact. The cryosleep room, and the control room.";
                    redButton.Text = "lets go to the control room";
                    greenButton.Text = "Cryosleep will keep me alive until a rescue team shows up.";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.cryo_chamber1;

                    break;
                case 23:
                    storyLabel.Text = "The head scientist is lying down in this room. He doesn't see you, but near him is the corpse of the Captain, shot. It is clear what had happened.";
                    redButton.Text = "I shouldn't startle him. Maybe we can piece out a solution to this situation.";
                    greenButton.Text = "YOU KILLED THE CAPTAIN! YOU'LL PAY FOR THAT";
                    orangeButton.Text = "";
                    ufoplayer.Play();
                    break;
                case 24:
                    storyLabel.Text = "Taking this opportunity, the head scientist notices you. You try to talk him down, but the bullet flies through your torso.";
                    redButton.Text = "Game Over";
                    greenButton.Text = "Game Over";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.explosion;
                    break;
                case 25:
                    storyLabel.Text = "You struggle with him for several moments, until finally you manage to choke him out. ";
                    redButton.Text = "Continue";
                    greenButton.Text = "Continue";
                    orangeButton.Text = "";
                    chokeplayer.Play();

                    break;
                case 26:
                    storyLabel.Text = "You reach the one remaining Cryosleep chamber. If anyone ever came to see what happened, they would find you. You hear footsteps. Do you wish to check the integrity of the chamber, or enter the cryosleep chamber.";
                    redButton.Text = "What if somebody else comes? If the room held up, the chamber should have too.";
                    greenButton.Text = "Lets make sure I won't get gassed or anything.";
                    storyImage.BackgroundImage = Properties.Resources.cryo_chamber1;
                    break;
                case 27:
                    storyLabel.Text = "A man, disheveled, who you recognize as the head scientist, pushes you aside and enters the cryosleep chamber.";
                    redButton.Text = "NOOOO! Unless I start signalling, it will be months before anyone comes.";
                    greenButton.Text = "Well, I better check to see if I can signal somebody.";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.cryo_chamber1;
                    break;
                case 28:
                    break;
                case 29:
                    storyLabel.Text = "You enter the cryo-chamber, fall asleep... and never wake up.";
                    redButton.Text = "Game over";
                    greenButton.Text = "Game over";
                    orangeButton.Text = "Game over";
                    storyImage.BackgroundImage = Properties.Resources.cryo_chamber1;
                    ufoplayer.Play();
                    break;
                case 30:
                    storyLabel.Text = "You decide to take a look at the broadcasting controls. You could try to send for help.";
                    redButton.Text = "Is there even a question?";
                    greenButton.Text = "From what I may have learned before, other humans finding this ship may not be a good idea.";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.Wifi_logo;
                    break;
                case 31:
                    storyLabel.Text = "You fall asleep... you're not dead, in fact, you do not know where you are....";
                    redButton.Text = "Game over";
                    greenButton.Text = "Game over";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.alienworld1;
                    break;
                case 32:
                    storyLabel.Text = "After several days, a ship arrives. You are airlifted out as the planet explodes, wiping off all potential life upon it.";
                    redButton.Text = "Continue";
                    greenButton.Text = "Continue";
                    orangeButton.Text = "Continue";
                    storyImage.BackgroundImage = Properties.Resources.space_1728314__340;
                    ufoplayer.Play();
                    break;
                case 98:
                    Thread.Sleep(2000);
                    Refresh();
                    Application.Exit();
                    break;
                case 99:
                    storyLabel.Text = "Would you like to play again?";
                    redButton.Text = "Exit";
                    greenButton.Text = "Play Again";
                    orangeButton.Text = "";
                    storyImage.BackgroundImage = Properties.Resources.display;
                    ufoplayer.Play();

                    break;
                    break;
                    break;





            } 
            }
        
    }
}
