using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CookieClickerForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long cookies = 0;
        public int upgradeamount = 0;
        public int upgradeprice = 100;

        public int[] buildamount = new int[20] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public long[] buildprice = new long[20] {100, 500, 1000, 2500, 5000, 10000, 25000, 50000, 75000, 100000, 150000, 200000, 250000, 500000, 1000000, 1500000, 2500000, 5000000, 7500000, 10000000};
        public bool[] ach = new bool[13] {false, false, false, false, false, false, false, false, false, false, false, false, false};

        public long record = 0;
        public long total = 0;
        public int buildings = 0;
        public long cookiessec = 0;
        public int secrets = 0;
        public int achievements = 0;
        public int achievementamount = 13;
        public int totalclicks = 0;
        public bool savedgame = false;
        public bool loadedgame = false;

        public string cookiestxt = "0";
        public string recordtxt = "0";
        public string totalclicktxt = "0";
        public string totalmadetxt = "0";
        public string buildingstxt = "0";
        public string cookiessectxt = "0";
        public string achievementamounttxt = "0";
        public string upgradeamounttxt = "0";
        public string upgradepricetxt = "100";

        private void button1_Click(object sender, EventArgs e) //Make cookie button
        {
            cookies = cookies + 1 + upgradeamount;
            label1.Text = cookies.ToString();
            total = total + 1 + upgradeamount;
            label28.Text = total.ToString();
            totalclicks = totalclicks + 1;
            label37.Text = "Total clicks: " + totalclicks;
            if (record < cookies)
            {
                record = cookies;
                label22.Text = record.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) //1+/click button
        {
            if (cookies >= upgradeprice)
            {
                cookies = cookies - upgradeprice;
                upgradeamount = upgradeamount + 1;
                upgradeprice = upgradeprice + 25;
            }
            label3.Text = "Price: " + upgradeprice + "   Amount: " + upgradeamount;
            label1.Text = cookies.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //Update Button
        {
            label1.Text = cookies.ToString();
            label3.Text = "Price: " + upgradeprice + "   Amount: " + upgradeamount;
            label4.Text = "Price: " + buildprice[0] + "   Amount: " + buildamount[0];
            label5.Text = "Price: " + buildprice[1] + "   Amount: " + buildamount[1];
            label6.Text = "Price: " + buildprice[2] + "   Amount: " + buildamount[2];
            label7.Text = "Price: " + buildprice[3] + "   Amount: " + buildamount[3];
            label8.Text = "Price: " + buildprice[4] + "   Amount: " + buildamount[4];
            label9.Text = "Price: " + buildprice[5] + "   Amount: " + buildamount[5];
            label10.Text = "Price: " + buildprice[6] + "   Amount: " + buildamount[6];
            label11.Text = "Price: " + buildprice[7] + "   Amount: " + buildamount[7];
            label12.Text = "Price: " + buildprice[8] + "   Amount: " + buildamount[8];
            label13.Text = "Price: " + buildprice[9] + "   Amount: " + buildamount[9];
            label14.Text = "Price: " + buildprice[10] + "   Amount: " + buildamount[10];
            label15.Text = "Price: " + buildprice[11] + "   Amount: " + buildamount[11];
            label16.Text = "Price: " + buildprice[12] + "   Amount: " + buildamount[12];
            label17.Text = "Price: " + buildprice[13] + "   Amount: " + buildamount[13];
            label18.Text = "Price: " + buildprice[14] + "   Amount: " + buildamount[14];
            label19.Text = "Price: " + buildprice[15] + "   Amount: " + buildamount[15];
            label23.Text = "Price: " + buildprice[16] + "   Amount: " + buildamount[16];
            label24.Text = "Price: " + buildprice[17] + "   Amount: " + buildamount[17];
            label25.Text = "Price: " + buildprice[18] + "   Amount: " + buildamount[18];
            label26.Text = "Price: " + buildprice[19] + "   Amount: " + buildamount[19];
            label28.Text = total.ToString();
            label32.Text = buildings.ToString();
            label33.Text = cookiessec.ToString();
            if (record < cookies)
            {
                record = cookies;
                label22.Text = record.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e) //When buying building 1
        {
            if (cookies >= buildprice[0])
            {
                cookies = cookies - buildprice[0];
                buildamount[0] = buildamount[0] + 1;
                buildprice[0] = buildprice[0] + 150;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 1;
                label4.Text = "Price: " + buildprice[0] + "   Amount: " + buildamount[0];
            }
        }

        private void button5_Click(object sender, EventArgs e) //When buying building 2
        {
            if (cookies >= buildprice[1])
            {
                cookies = cookies - buildprice[1];
                buildamount[1] = buildamount[1] + 1;
                buildprice[1] = buildprice[1] + 650;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 5;
                label5.Text = "Price: " + buildprice[1] + "   Amount: " + buildamount[1];
            }
        }

        private void button6_Click(object sender, EventArgs e) //When buying building 3
        {
            if (cookies >= buildprice[2])
            {
                cookies = cookies - buildprice[2];
                buildamount[2] = buildamount[2] + 1;
                buildprice[2] = buildprice[2] + 1150;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 10;
                label6.Text = "Price: " + buildprice[2] + "   Amount: " + buildamount[2];
            }
        }

        private void button7_Click(object sender, EventArgs e) //When buying building 4
        {
            if (cookies >= buildprice[3])
            {
                cookies = cookies - buildprice[3];
                buildamount[3] = buildamount[3] + 1;
                buildprice[3] = buildprice[3] + 2650;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 25;
                label7.Text = "Price: " + buildprice[3] + "   Amount: " + buildamount[3];
            }
        }

        private void button8_Click(object sender, EventArgs e) //When buying building 5
        {
            if (cookies >= buildprice[4])
            {
                cookies = cookies - buildprice[4];
                buildamount[4] = buildamount[4] + 1;
                buildprice[4] = buildprice[4] + 5150;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 50;
                label8.Text = "Price: " + buildprice[4] + "   Amount: " + buildamount[4];
            }
        }

        private void button9_Click(object sender, EventArgs e) //When buying building 6
        {
            if (cookies >= buildprice[5])
            {
                cookies = cookies - buildprice[5];
                buildamount[5] = buildamount[5] + 1;
                buildprice[5] = buildprice[5] + 10250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 100;
                label9.Text = "Price: " + buildprice[5] + "   Amount: " + buildamount[5];
            }
        }

        private void button10_Click(object sender, EventArgs e) //When buying building 7
        {
            if (cookies >= buildprice[6])
            {
                cookies = cookies - buildprice[6];
                buildamount[6] = buildamount[6] + 1;
                buildprice[6] = buildprice[6] + 25250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 250;
                label10.Text = "Price: " + buildprice[6] + "   Amount: " + buildamount[6];
            }
        }

        private void button11_Click(object sender, EventArgs e) //When buying building 8
        {
            if (cookies >= buildprice[7])
            {
                cookies = cookies - buildprice[7];
                buildamount[7] = buildamount[7] + 1;
                buildprice[7] = buildprice[7] + 50250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 500;
                label11.Text = "Price: " + buildprice[7] + "   Amount: " + buildamount[7];
            }
        }

        private void button12_Click(object sender, EventArgs e) //When buying building 9
        {
            if (cookies >= buildprice[8])
            {
                cookies = cookies - buildprice[8];
                buildamount[8] = buildamount[8] + 1;
                buildprice[8] = buildprice[8] + 75250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 750;
                label12.Text = "Price: " + buildprice[8] + "   Amount: " + buildamount[8];
            }
        }

        private void button13_Click(object sender, EventArgs e) //When buying building 10
        {
            if (cookies >= buildprice[9])
            {
                cookies = cookies - buildprice[9];
                buildamount[9] = buildamount[9] + 1;
                buildprice[9] = buildprice[9] + 100500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 1000;
                label13.Text = "Price: " + buildprice[9] + "   Amount: " + buildamount[9];
            }
        }

        private void button14_Click(object sender, EventArgs e) //When buying building 11
        {
            if (cookies >= buildprice[10])
            {
                cookies = cookies - buildprice[10];
                buildamount[10] = buildamount[10] + 1;
                buildprice[10] = buildprice[10] + 150500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 1500;
                label14.Text = "Price: " + buildprice[10] + "   Amount: " + buildamount[10];
            }
        }

        private void button15_Click(object sender, EventArgs e) //When buying building 12
        {
            if (cookies >= buildprice[11])
            {
                cookies = cookies - buildprice[11];
                buildamount[11] = buildamount[11] + 1;
                buildprice[11] = buildprice[11] + 200500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 2000;
                label15.Text = "Price: " + buildprice[11] + "   Amount: " + buildamount[11];
            }
        }

        private void button16_Click(object sender, EventArgs e) //When buying building 13
        {
            if (cookies >= buildprice[12])
            {
                cookies = cookies - buildprice[12];
                buildamount[12] = buildamount[12] + 1;
                buildprice[12] = buildprice[12] + 251000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 2500;
                label16.Text = "Price: " + buildprice[12] + "   Amount: " + buildamount[12];
            }
        }

        private void button17_Click(object sender, EventArgs e) //When buying building 14
        {
            if (cookies >= buildprice[13])
            {
                cookies = cookies - buildprice[13];
                buildamount[13] = buildamount[13] + 1;
                buildprice[13] = buildprice[13] + 501500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 5000;
                label17.Text = "Price: " + buildprice[13] + "   Amount: " + buildamount[13];
            }
        }

        private void button18_Click(object sender, EventArgs e) //When buying building 15
        {
            if (cookies >= buildprice[14])
            {
                cookies = cookies - buildprice[14];
                buildamount[14] = buildamount[14] + 1;
                buildprice[14] = buildprice[14] + 1002000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 10000;
                label18.Text = "Price: " + buildprice[14] + "   Amount: " + buildamount[14];
            }
        }

        private void button19_Click(object sender, EventArgs e) //When buying building 16
        {
            if (cookies >= buildprice[15])
            {
                cookies = cookies - buildprice[15];
                buildamount[15] = buildamount[15] + 1;
                buildprice[15] = buildprice[15] + 1502000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 15000;
                label19.Text = "Price: " + buildprice[15] + "   Amount: " + buildamount[15];
            }
        }

        private void button20_Click(object sender, EventArgs e) //When buying building 17
        {
            if (cookies >= buildprice[16])
            {
                cookies = cookies - buildprice[16];
                buildamount[16] = buildamount[16] + 1;
                buildprice[16] = buildprice[16] + 2502000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 25000;
                label23.Text = "Price: " + buildprice[16] + "   Amount: " + buildamount[16];
            }
        }
        private void button21_Click(object sender, EventArgs e)//When buying building 18
        {
            if (cookies >= buildprice[17])
            {
                cookies = cookies - buildprice[17];
                buildamount[17] = buildamount[17] + 1;
                buildprice[17] = buildprice[17] + 5002500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 50000;
                label24.Text = "Price: " + buildprice[17] + "   Amount: " + buildamount[17];
            }
        }

        private void button22_Click(object sender, EventArgs e)//When buying building 19
        {
            if (cookies >= buildprice[18])
            {
                cookies = cookies - buildprice[18];
                buildamount[18] = buildamount[18] + 1;
                buildprice[18] = buildprice[18] + 7502500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 75000;
                label25.Text = "Price: " + buildprice[18] + "   Amount: " + buildamount[18];
            }
        }

        private void button23_Click(object sender, EventArgs e)//When buying building 20
        {
            if (cookies >= buildprice[19])
            {
                cookies = cookies - buildprice[19];
                buildamount[19] = buildamount[19] + 1;
                buildprice[19] = buildprice[19] + 10003000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 100000;
                label26.Text = "Price: " + buildprice[19] + "   Amount: " + buildamount[19];
            }
        }

        private void timer1000ms_Tick(object sender, EventArgs e) //Runs code every 1 second
        {
            if (buildamount[0] >= 1)
            {
                cookies = cookies + 1 * buildamount[0];
                label1.Text = cookies.ToString();
                total = total + 1;
            }
        }

        private void timer500ms_Tick(object sender, EventArgs e) //Runs code every 0,5 second
        {
            if (buildamount[2] >= 1)
            {
                cookies = cookies + 5 * buildamount[2];
                label1.Text = cookies.ToString();
                total = total + 5 * buildamount[2];
            }
        }

        private void timer200ms_Tick(object sender, EventArgs e) //Runs code every 0,2 second
        {
            if (buildamount[1] >= 1)
            {
                cookies = cookies + 1 * buildamount[1];
                label1.Text = cookies.ToString();
                total = total + 1 * buildamount[1];
            }
            if (buildamount[3] >= 1)
            {
                cookies = cookies + 5 * buildamount[3];
                label1.Text = cookies.ToString();
                total = total + 5 * buildamount[3];
            }
            if (buildamount[6] >= 1)
            {
                cookies = cookies + 50 * buildamount[6];
                label1.Text = cookies.ToString();
                total = total + 50 * buildamount[6];
            }
            if (buildamount[7] >= 1)
            {
                cookies = cookies + 100 * buildamount[7];
                label1.Text = cookies.ToString();
                total = total + 100 * buildamount[7];
            }
            label32.Text = buildings.ToString();
            label33.Text = cookiessec.ToString();
        }

        private void timer100ms_Tick(object sender, EventArgs e) //Runs code every 0,1 second
        {
            if (buildamount[4] >= 1)
            {
                cookies = cookies + 5 * buildamount[4];
                label1.Text = cookies.ToString();
                total = total + 5 * buildamount[4];
            }
            if (buildamount[5] >= 1)
            {
                cookies = cookies + 10 * buildamount[5];
                label1.Text = cookies.ToString();
                total = total + 10 * buildamount[5];
            }
            if (buildamount[8] >= 1)
            {
                cookies = cookies + 75 * buildamount[8];
                label1.Text = cookies.ToString();
                total = total + 75 * buildamount[8];
            }
            if (buildamount[9] >= 1)
            {
                cookies = cookies + 100 * buildamount[9];
                label1.Text = cookies.ToString();
                total = total + 100 * buildamount[9];
            }
            if (buildamount[10] >= 1)
            {
                cookies = cookies + 150 * buildamount[10];
                label1.Text = cookies.ToString();
                total = total + 150 * buildamount[10];
            }
            if (buildamount[11] >= 1)
            {
                cookies = cookies + 200 * buildamount[11];
                label1.Text = cookies.ToString();
                total = total + 200 * buildamount[11];
            }
            if (buildamount[12] >= 1)
            {
                cookies = cookies + 250 * buildamount[12];
                label1.Text = cookies.ToString();
                total = total + 250 * buildamount[12];
            }
            if (buildamount[13] >= 1)
            {
                cookies = cookies + 500 * buildamount[13];
                label1.Text = cookies.ToString();
                total = total + 500 * buildamount[13];
            }
            if (buildamount[14] >= 1)
            {
                cookies = cookies + 1000 * buildamount[14];
                label1.Text = cookies.ToString();
                total = total + 1000 * buildamount[14];
            }
            if (buildamount[15] >= 1)
            {
                cookies = cookies + 1500 * buildamount[15];
                label1.Text = cookies.ToString();
                total = total + 1500 * buildamount[15];
            }
            if (buildamount[16] >= 1)
            {
                cookies = cookies + 2500 * buildamount[16];
                label1.Text = cookies.ToString();
                total = total + 2500 * buildamount[16];
            }
            if (buildamount[17] >= 1)
            {
                cookies = cookies + 5000 * buildamount[17];
                label1.Text = cookies.ToString();
                total = total + 5000 * buildamount[17];
            }
            if (buildamount[18] >= 1)
            {
                cookies = cookies + 7500 * buildamount[18];
                label1.Text = cookies.ToString();
                total = total + 7500 * buildamount[18];
            }
            if (buildamount[19] >= 1)
            {
                cookies = cookies + 10000 * buildamount[19];
                label1.Text = cookies.ToString();
                total = total + 10000 * buildamount[19];
            }
            if (record < cookies)
            {
                record = cookies;
                label22.Text = record.ToString();
            }
            label28.Text = total.ToString();
        }

        private void timer10000ms_Tick(object sender, EventArgs e) //Runs the code every 10 seconds
        {
            if (cookies >= 1000)
            {
                if (ach[0] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 1000+ cookies.";
                }
                ach[0] = true;
            }
            if (cookies >= 10000)
            {
                if (ach[1] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 10000+ cookies!";
                }
                ach[1] = true;
            }
            if (cookies >= 100000)
            {
                if (ach[2] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 100000+ cookies!!";
                }
                ach[2] = true;
            }
            if (cookies >= 1000000)
            {
                if (ach[3] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 1000000+ cookies!!!";
                }
                ach[3] = true;
            }
            if (cookies >= 10000000)
            {
                if (ach[4] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 10000000+ cookies!!!!";
                }
                ach[4] = true;
            }
            if (cookies >= 100000000)
            {
                if (ach[5] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 100000000+ cookies!1!!!";
                }
                ach[5] = true;
            }
            if (cookies >= 1000000000)
            {
                if (ach[6] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 1000000000+ cookies!!!1!1";
                }
                ach[6] = true;
            }
            if (buildings >= 25)
            {
                if (ach[7] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 25+ Buildings.";
                }
                ach[7] = true;
            }
            if (buildings >= 50)
            {
                if (ach[8] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 50+ Buildings!";
                }
                ach[8] = true;
            }
            if (buildings >= 75)
            {
                if (ach[9] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 75+ Buildings!!";
                }
                ach[9] = true;
            }
            if (buildings >= 100)
            {
                if (ach[10] == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 100+ Buildings!1!";
                }
                ach[10] = true;
            }
            if (savedgame == true)
            {
                if (ach[11] == false)
                {
                    achievements = achievements + 1;
                    savedgame = true;
                    label36.Text = achievements + "/" + achievementamount + " - Saved the game.";
                }
                ach[11] = true;
            }
            if (loadedgame == true)
            {
                if (ach[12] == false)
                {
                    achievements = achievements + 1;
                    loadedgame = false;
                    label36.Text = achievements + "/" + achievementamount + " - Loaded the game.";
                }
                ach[12] = true;
            }
        }

        public void button24_Click(object sender, EventArgs e) //Save Game
        {
            savedgame = true;
            cookiestxt = cookies.ToString();
            recordtxt = record.ToString();
            totalclicktxt = totalclicks.ToString();
            totalmadetxt = total.ToString();
            buildingstxt = buildings.ToString();
            cookiessectxt = cookiessec.ToString();
            achievementamounttxt = achievementamount.ToString();
            upgradeamounttxt = upgradeamount.ToString();
            upgradepricetxt = upgradeprice.ToString();
        MessageBox.Show("Saved at game file location. \r\n\r\nTo load again, make sure that you have the saved file in same directory as the game!");
            StreamWriter Save = new StreamWriter("cc_game_save.txt");
            Save.WriteLine(cookiestxt);
            Save.WriteLine(recordtxt);
            Save.WriteLine(totalclicktxt);
            Save.WriteLine(totalmadetxt);
            Save.WriteLine(buildingstxt);
            Save.WriteLine(cookiessectxt);
            Save.WriteLine(buildamount[0]);
            Save.WriteLine(buildamount[1]);
            Save.WriteLine(buildamount[2]);
            Save.WriteLine(buildamount[3]);
            Save.WriteLine(buildamount[4]);
            Save.WriteLine(buildamount[5]);
            Save.WriteLine(buildamount[6]);
            Save.WriteLine(buildamount[7]);
            Save.WriteLine(buildamount[8]);
            Save.WriteLine(buildamount[9]);
            Save.WriteLine(buildamount[10]);
            Save.WriteLine(buildamount[11]);
            Save.WriteLine(buildamount[12]);
            Save.WriteLine(buildamount[13]);
            Save.WriteLine(buildamount[14]);
            Save.WriteLine(buildamount[15]);
            Save.WriteLine(buildamount[16]);
            Save.WriteLine(buildamount[17]);
            Save.WriteLine(buildamount[18]);
            Save.WriteLine(buildamount[19]);
            Save.WriteLine(buildprice[0]);
            Save.WriteLine(buildprice[1]);
            Save.WriteLine(buildprice[2]);
            Save.WriteLine(buildprice[3]);
            Save.WriteLine(buildprice[4]);
            Save.WriteLine(buildprice[5]);
            Save.WriteLine(buildprice[6]);
            Save.WriteLine(buildprice[7]);
            Save.WriteLine(buildprice[8]);
            Save.WriteLine(buildprice[9]);
            Save.WriteLine(buildprice[10]);
            Save.WriteLine(buildprice[11]);
            Save.WriteLine(buildprice[12]);
            Save.WriteLine(buildprice[13]);
            Save.WriteLine(buildprice[14]);
            Save.WriteLine(buildprice[15]);
            Save.WriteLine(buildprice[16]);
            Save.WriteLine(buildprice[17]);
            Save.WriteLine(buildprice[18]);
            Save.WriteLine(buildprice[19]);
            Save.WriteLine(achievementamounttxt);
            Save.WriteLine(ach[0]);
            Save.WriteLine(ach[1]);
            Save.WriteLine(ach[2]);
            Save.WriteLine(ach[3]);
            Save.WriteLine(ach[4]);
            Save.WriteLine(ach[5]);
            Save.WriteLine(ach[6]);
            Save.WriteLine(ach[7]);
            Save.WriteLine(ach[8]);
            Save.WriteLine(ach[9]);
            Save.WriteLine(ach[10]);
            Save.WriteLine(ach[11]);
            Save.WriteLine(ach[12]);
            Save.WriteLine(upgradeamounttxt);
            Save.WriteLine(upgradepricetxt);
            Save.Close();
        }

        public void button25_Click(object sender, EventArgs e) //Load Game
        {
            loadedgame = true;
            StreamReader reader = new StreamReader("cc_game_save.txt");


            cookies = Convert.ToInt64(reader.ReadLine());
            record = Convert.ToInt64(reader.ReadLine());
            totalclicks = Convert.ToInt32(reader.ReadLine());
            total = Convert.ToInt64(reader.ReadLine());
            buildings = Convert.ToInt32(reader.ReadLine());
            cookiessec = Convert.ToInt64(reader.ReadLine());
            buildamount[0] = Convert.ToInt32(reader.ReadLine());
            buildamount[1] = Convert.ToInt32(reader.ReadLine());
            buildamount[2] = Convert.ToInt32(reader.ReadLine());
            buildamount[3] = Convert.ToInt32(reader.ReadLine());
            buildamount[4] = Convert.ToInt32(reader.ReadLine());
            buildamount[5] = Convert.ToInt32(reader.ReadLine());
            buildamount[6] = Convert.ToInt32(reader.ReadLine());
            buildamount[7] = Convert.ToInt32(reader.ReadLine());
            buildamount[8] = Convert.ToInt32(reader.ReadLine());
            buildamount[9] = Convert.ToInt32(reader.ReadLine());
            buildamount[10] = Convert.ToInt32(reader.ReadLine());
            buildamount[11] = Convert.ToInt32(reader.ReadLine());
            buildamount[12] = Convert.ToInt32(reader.ReadLine());
            buildamount[13] = Convert.ToInt32(reader.ReadLine());
            buildamount[14] = Convert.ToInt32(reader.ReadLine());
            buildamount[15] = Convert.ToInt32(reader.ReadLine());
            buildamount[16] = Convert.ToInt32(reader.ReadLine());
            buildamount[17] = Convert.ToInt32(reader.ReadLine());
            buildamount[18] = Convert.ToInt32(reader.ReadLine());
            buildamount[19] = Convert.ToInt32(reader.ReadLine());
            buildprice[0] = Convert.ToInt32(reader.ReadLine());
            buildprice[1] = Convert.ToInt32(reader.ReadLine());
            buildprice[2] = Convert.ToInt32(reader.ReadLine());
            buildprice[3] = Convert.ToInt32(reader.ReadLine());
            buildprice[4] = Convert.ToInt32(reader.ReadLine());
            buildprice[5] = Convert.ToInt32(reader.ReadLine());
            buildprice[6] = Convert.ToInt32(reader.ReadLine());
            buildprice[7] = Convert.ToInt32(reader.ReadLine());
            buildprice[8] = Convert.ToInt32(reader.ReadLine());
            buildprice[9] = Convert.ToInt32(reader.ReadLine());
            buildprice[10] = Convert.ToInt32(reader.ReadLine());
            buildprice[11] = Convert.ToInt32(reader.ReadLine());
            buildprice[12] = Convert.ToInt32(reader.ReadLine());
            buildprice[13] = Convert.ToInt32(reader.ReadLine());
            buildprice[14] = Convert.ToInt32(reader.ReadLine());
            buildprice[15] = Convert.ToInt32(reader.ReadLine());
            buildprice[16] = Convert.ToInt32(reader.ReadLine());
            buildprice[17] = Convert.ToInt32(reader.ReadLine());
            buildprice[18] = Convert.ToInt32(reader.ReadLine());
            buildprice[19] = Convert.ToInt32(reader.ReadLine());
            achievementamount = Convert.ToInt32(reader.ReadLine());
            ach[0] = Convert.ToBoolean(reader.ReadLine());
            ach[1] = Convert.ToBoolean(reader.ReadLine());
            ach[2] = Convert.ToBoolean(reader.ReadLine());
            ach[3] = Convert.ToBoolean(reader.ReadLine());
            ach[4] = Convert.ToBoolean(reader.ReadLine());
            ach[5] = Convert.ToBoolean(reader.ReadLine());
            ach[6] = Convert.ToBoolean(reader.ReadLine());
            ach[7] = Convert.ToBoolean(reader.ReadLine());
            ach[8] = Convert.ToBoolean(reader.ReadLine());
            ach[9] = Convert.ToBoolean(reader.ReadLine());
            ach[10] = Convert.ToBoolean(reader.ReadLine());
            ach[11] = Convert.ToBoolean(reader.ReadLine());
            ach[12] = Convert.ToBoolean(reader.ReadLine());
            upgradeamount = Convert.ToInt32(reader.ReadLine());
            upgradeprice = Convert.ToInt32(reader.ReadLine());
            reader.Close();

            label1.Text = cookies.ToString();
            label3.Text = "Price: " + upgradeprice + "   Amount: " + upgradeamount;
            label4.Text = "Price: " + buildprice[0] + "   Amount: " + buildamount[0];
            label5.Text = "Price: " + buildprice[1] + "   Amount: " + buildamount[1];
            label6.Text = "Price: " + buildprice[2] + "   Amount: " + buildamount[2];
            label7.Text = "Price: " + buildprice[3] + "   Amount: " + buildamount[3];
            label8.Text = "Price: " + buildprice[4] + "   Amount: " + buildamount[4];
            label9.Text = "Price: " + buildprice[5] + "   Amount: " + buildamount[5];
            label10.Text = "Price: " + buildprice[6] + "   Amount: " + buildamount[6];
            label11.Text = "Price: " + buildprice[7] + "   Amount: " + buildamount[7];
            label12.Text = "Price: " + buildprice[8] + "   Amount: " + buildamount[8];
            label13.Text = "Price: " + buildprice[9] + "   Amount: " + buildamount[9];
            label14.Text = "Price: " + buildprice[10] + "   Amount: " + buildamount[10];
            label15.Text = "Price: " + buildprice[11] + "   Amount: " + buildamount[11];
            label16.Text = "Price: " + buildprice[12] + "   Amount: " + buildamount[12];
            label17.Text = "Price: " + buildprice[13] + "   Amount: " + buildamount[13];
            label18.Text = "Price: " + buildprice[14] + "   Amount: " + buildamount[14];
            label19.Text = "Price: " + buildprice[15] + "   Amount: " + buildamount[15];
            label23.Text = "Price: " + buildprice[16] + "   Amount: " + buildamount[16];
            label24.Text = "Price: " + buildprice[17] + "   Amount: " + buildamount[17];
            label25.Text = "Price: " + buildprice[18] + "   Amount: " + buildamount[18];
            label26.Text = "Price: " + buildprice[19] + "   Amount: " + buildamount[19];
            label37.Text = "Total clicks: " + totalclicktxt;
            label28.Text = total.ToString();
            label32.Text = buildings.ToString();
            label33.Text = cookiessec.ToString();
            label22.Text = record.ToString();
        }
    }
}

//Code by Mldx Team
//mldx.dk