using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOfLegendsChampionPicker
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        private string champSelectedFromPool;
        private string champSelectedFromYourPool;

        //Champion Pool
        private string championPool = System.IO.File.ReadAllText(@"..\..\obj\TextFiles\ChampionPool.txt");

        private string yourChampionPool = System.IO.File.ReadAllText(@"..\..\obj\TextFiles\YourChampionPool.txt");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] champArrayYourChampion = ChampionPickerToArray(yourChampionPool);
            string[] champArrayChampionPool = ChampionPickerToArray(championPool);

            ImageCreator(champArrayYourChampion.Length, champArrayYourChampion, grpboxYourChampionPool);
            ImageCreator(champArrayChampionPool.Length, champArrayChampionPool, grpboxChampionPool);

        }

        private void btnChampionPicker_Click(object sender, EventArgs e)
        {
            //Saves the name of the champion picked
            string championPicked = ChampionPickerRandomizer();

            //sets the label to the champion name and to the picture
            lblChampionPicked.Text = championPicked;
            picChampionPic.SizeMode = PictureBoxSizeMode.StretchImage;
            picChampionPic.Image = Image.FromFile(@"..\..\obj\Images\" + championPicked + ".png");
        }

        //Randomize the champion
        private string ChampionPickerRandomizer()
        {
            string [] champArray = ChampionPickerToArray(yourChampionPool);
            //Randomizes the champion and picks one to play
            int championselected = random.Next(0, champArray.Length);

            //Returns the name of the champion
            return champArray[championselected];

        }

        //Converts the given type of pool champ to an array
        private string [] ChampionPickerToArray(string typeOfPoolChamp)
        {
            //Grabs the champion pool and converts it to a list
            List<string> champList = typeOfPoolChamp.Split(',').ToList();

            //Converts list to array
            string[] champArray = champList.ToArray();

            return champArray;
        }

        private void ImageCreator(int numOfChampsInYourList, string [] champArray, GroupBox nameOfGroup )
        {
            //Creates the Image boxes and sets spacing in the groupbox
            int vertMargin = 0;
            int championPosition = 0;
            int counter = 0;
            for (int iVert = 0; iVert < numOfChampsInYourList; iVert++)
            {
                int horizMargin = 0;
                for (int iHoriz = 0; iHoriz < 5; iHoriz++)
                {
                    if (counter >= numOfChampsInYourList)
                    {
                        break;
                    }

                    else if (champArray[championPosition] == "")
                    {
                        break;
                    }
                    else
                    {
                        PictureBox p = new PictureBox();
                        p.Location = new Point(5 + (iHoriz * 5 + horizMargin), 15 + (iVert * 5 + vertMargin));
                        p.Size = new Size(120, 120);
                        p.BorderStyle = BorderStyle.Fixed3D;
                        p.BackColor = Color.Black;
                        p.Name = champArray[championPosition];
                        p.Image = Image.FromFile(@"..\..\obj\Images\" + champArray[championPosition] + ".png");
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        nameOfGroup.Controls.Add(p);
                        horizMargin = horizMargin + 120;

                        championPosition = championPosition + 1;

                        counter++;

                        if (nameOfGroup.Name == "grpboxYourChampionPool")
                            p.MouseClick += P_YourChampionPool_MouseClick;
                        else if (nameOfGroup.Name == "grpboxChampionPool")
                            p.MouseClick += P_ChampionPool_MouseClick;
                        else
                            MessageBox.Show("There was an error");
                    }
                }
                vertMargin = vertMargin + 120;
            }
        }

        private void P_YourChampionPool_MouseClick(object sender, MouseEventArgs e)
        {
            champSelectedFromYourPool += ((PictureBox)sender).Name + ",";
            ((PictureBox)sender).Size = new Size(120, 120);
            ((PictureBox)sender).BackColor = Color.LightBlue;
            ((PictureBox)sender).Padding = new Padding(5);

            MessageBox.Show(yourChampionPool);
            yourChampionPool = yourChampionPool.Replace(((PictureBox)sender).Name + ",", "");
            MessageBox.Show(yourChampionPool);
            System.IO.File.WriteAllText(@"..\..\obj\TextFiles\YourChampionPool.txt", yourChampionPool);
            FormClosed += (o, a) => new MainForm().ShowDialog();

            Hide();
            Close();
        }

        private void P_ChampionPool_MouseClick(object sender, MouseEventArgs e)
        {
            champSelectedFromPool += ((PictureBox)sender).Name + ",";
            ((PictureBox)sender).Size = new Size(120, 120);
            ((PictureBox)sender).BackColor = Color.LightBlue;
            ((PictureBox)sender).Padding = new Padding(5);

            MessageBox.Show(yourChampionPool);
            yourChampionPool += ((PictureBox)sender).Name + ",";
            MessageBox.Show(yourChampionPool);
            System.IO.File.WriteAllText(@"..\..\obj\TextFiles\YourChampionPool.txt", yourChampionPool);
            FormClosed += (o, a) => new MainForm().ShowDialog();

            Hide();
            Close();
        }
    }
    //To do: Add button so that when you click the button it adds/removes all of the selected champions (create new method)
    //to do this add champions to a string then add that string to the file
    //Also, do a search to make sure you are not adding a champion twice.
}
