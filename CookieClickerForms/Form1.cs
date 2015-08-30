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
        public int build1amount = 0;
        public int build1price = 100;
        public int build2amount = 0;
        public int build2price = 500;
        public int build3amount = 0;
        public int build3price = 1000;
        public int build4amount = 0;
        public int build4price = 2500;
        public int build5amount = 0;
        public int build5price = 5000;
        public int build6amount = 0;
        public int build6price = 10000;
        public int build7amount = 0;
        public int build7price = 25000;
        public int build8amount = 0;
        public int build8price = 50000;
        public int build9amount = 0;
        public int build9price = 75000;
        public int build10amount = 0;
        public int build10price = 100000;
        public int build11amount = 0;
        public int build11price = 150000;
        public int build12amount = 0;
        public int build12price = 200000;
        public int build13amount = 0;
        public int build13price = 250000;
        public int build14amount = 0;
        public int build14price = 500000;
        public int build15amount = 0;
        public int build15price = 1000000;
        public int build16amount = 0;
        public int build16price = 1500000;
        public int build17amount = 0;
        public int build17price = 2500000;
        public int build18amount = 0;
        public int build18price = 5000000;
        public int build19amount = 0;
        public int build19price = 7500000;
        public int build20amount = 0;
        public int build20price = 10000000;

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
        public string build1amounttxt = "0";
        public string build2amounttxt = "0";
        public string build3amounttxt = "0";
        public string build4amounttxt = "0";
        public string build5amounttxt = "0";
        public string build6amounttxt = "0";
        public string build7amounttxt = "0";
        public string build8amounttxt = "0";
        public string build9amounttxt = "0";
        public string build10amounttxt = "0";
        public string build11amounttxt = "0";
        public string build12amounttxt = "0";
        public string build13amounttxt = "0";
        public string build14amounttxt = "0";
        public string build15amounttxt = "0";
        public string build16amounttxt = "0";
        public string build17amounttxt = "0";
        public string build18amounttxt = "0";
        public string build19amounttxt = "0";
        public string build20amounttxt = "0";
        public string build1pricetxt = "100";
        public string build2pricetxt = "500";
        public string build3pricetxt = "1000";
        public string build4pricetxt = "2500";
        public string build5pricetxt = "5000";
        public string build6pricetxt = "10000";
        public string build7pricetxt = "25000";
        public string build8pricetxt = "50000";
        public string build9pricetxt = "75000";
        public string build10pricetxt = "100000";
        public string build11pricetxt = "150000";
        public string build12pricetxt = "200000";
        public string build13pricetxt = "250000";
        public string build14pricetxt = "500000";
        public string build15pricetxt = "1000000";
        public string build16pricetxt = "1500000";
        public string build17pricetxt = "2500000";
        public string build18pricetxt = "5000000";
        public string build19pricetxt = "7500000";
        public string build20pricetxt = "10000000";
        public string achievementamounttxt = "0";
        public bool achatxt = false;
        public bool achbtxt = false;
        public bool achctxt = false;
        public bool achdtxt = false;
        public bool achetxt = false;
        public bool achftxt = false;
        public bool achgtxt = false;
        public bool achhtxt = false;
        public bool achitxt = false;
        public bool achjtxt = false;
        public bool achktxt = false;
        public bool achltxt = false;
        public bool achmtxt = false;
        public string upgradeamounttxt = "0";
        public string upgradepricetxt = "100";

        //Achievements
        public bool acha = false;
        public bool achb = false;
        public bool achc = false;
        public bool achd = false;
        public bool ache = false;
        public bool achf = false;
        public bool achg = false;
        public bool achh = false;
        public bool achi = false;
        public bool achj = false;
        public bool achk = false;
        public bool achl = false;
        public bool achm = false;

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
            label4.Text = "Price: " + build1price + "   Amount: " + build1amount;
            label5.Text = "Price: " + build2price + "   Amount: " + build2amount;
            label6.Text = "Price: " + build3price + "   Amount: " + build3amount;
            label7.Text = "Price: " + build4price + "   Amount: " + build4amount;
            label8.Text = "Price: " + build5price + "   Amount: " + build5amount;
            label9.Text = "Price: " + build6price + "   Amount: " + build6amount;
            label10.Text = "Price: " + build7price + "   Amount: " + build7amount;
            label11.Text = "Price: " + build8price + "   Amount: " + build8amount;
            label12.Text = "Price: " + build9price + "   Amount: " + build9amount;
            label13.Text = "Price: " + build10price + "   Amount: " + build10amount;
            label14.Text = "Price: " + build11price + "   Amount: " + build11amount;
            label15.Text = "Price: " + build12price + "   Amount: " + build12amount;
            label16.Text = "Price: " + build13price + "   Amount: " + build13amount;
            label17.Text = "Price: " + build14price + "   Amount: " + build14amount;
            label18.Text = "Price: " + build15price + "   Amount: " + build15amount;
            label19.Text = "Price: " + build16price + "   Amount: " + build16amount;
            label23.Text = "Price: " + build17price + "   Amount: " + build17amount;
            label24.Text = "Price: " + build18price + "   Amount: " + build18amount;
            label25.Text = "Price: " + build19price + "   Amount: " + build19amount;
            label26.Text = "Price: " + build20price + "   Amount: " + build20amount;
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
            if (cookies >= build1price)
            {
                cookies = cookies - build1price;
                build1amount = build1amount + 1;
                build1price = build1price + 150;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 1;
                label4.Text = "Price: " + build1price + "   Amount: " + build1amount;
            }
        }

        private void button5_Click(object sender, EventArgs e) //When buying building 2
        {
            if (cookies >= build2price)
            {
                cookies = cookies - build2price;
                build2amount = build2amount + 1;
                build2price = build2price + 650;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 5;
                label5.Text = "Price: " + build2price + "   Amount: " + build2amount;
            }
        }

        private void button6_Click(object sender, EventArgs e) //When buying building 3
        {
            if (cookies >= build3price)
            {
                cookies = cookies - build3price;
                build3amount = build3amount + 1;
                build3price = build3price + 1150;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 10;
                label6.Text = "Price: " + build3price + "   Amount: " + build3amount;
            }
        }

        private void button7_Click(object sender, EventArgs e) //When buying building 4
        {
            if (cookies >= build4price)
            {
                cookies = cookies - build4price;
                build4amount = build4amount + 1;
                build4price = build4price + 2650;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 25;
                label7.Text = "Price: " + build4price + "   Amount: " + build4amount;
            }
        }

        private void button8_Click(object sender, EventArgs e) //When buying building 5
        {
            if (cookies >= build5price)
            {
                cookies = cookies - build5price;
                build5amount = build5amount + 1;
                build5price = build5price + 5150;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 50;
                label8.Text = "Price: " + build5price + "   Amount: " + build5amount;
            }
        }

        private void button9_Click(object sender, EventArgs e) //When buying building 6
        {
            if (cookies >= build6price)
            {
                cookies = cookies - build6price;
                build6amount = build6amount + 1;
                build6price = build6price + 10250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 100;
                label9.Text = "Price: " + build6price + "   Amount: " + build6amount;
            }
        }

        private void button10_Click(object sender, EventArgs e) //When buying building 7
        {
            if (cookies >= build7price)
            {
                cookies = cookies - build7price;
                build7amount = build7amount + 1;
                build7price = build7price + 25250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 250;
                label10.Text = "Price: " + build7price + "   Amount: " + build7amount;
            }
        }

        private void button11_Click(object sender, EventArgs e) //When buying building 8
        {
            if (cookies >= build8price)
            {
                cookies = cookies - build8price;
                build8amount = build8amount + 1;
                build8price = build8price + 50250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 500;
                label11.Text = "Price: " + build8price + "   Amount: " + build8amount;
            }
        }

        private void button12_Click(object sender, EventArgs e) //When buying building 9
        {
            if (cookies >= build9price)
            {
                cookies = cookies - build9price;
                build9amount = build9amount + 1;
                build9price = build9price + 75250;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 750;
                label12.Text = "Price: " + build9price + "   Amount: " + build9amount;
            }
        }

        private void button13_Click(object sender, EventArgs e) //When buying building 10
        {
            if (cookies >= build10price)
            {
                cookies = cookies - build10price;
                build10amount = build10amount + 1;
                build10price = build10price + 100500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 1000;
                label13.Text = "Price: " + build10price + "   Amount: " + build10amount;
            }
        }

        private void button14_Click(object sender, EventArgs e) //When buying building 11
        {
            if (cookies >= build11price)
            {
                cookies = cookies - build11price;
                build11amount = build11amount + 1;
                build11price = build11price + 150500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 1500;
                label14.Text = "Price: " + build11price + "   Amount: " + build11amount;
            }
        }

        private void button15_Click(object sender, EventArgs e) //When buying building 12
        {
            if (cookies >= build12price)
            {
                cookies = cookies - build12price;
                build12amount = build12amount + 1;
                build12price = build12price + 200500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 2000;
                label15.Text = "Price: " + build12price + "   Amount: " + build12amount;
            }
        }

        private void button16_Click(object sender, EventArgs e) //When buying building 13
        {
            if (cookies >= build13price)
            {
                cookies = cookies - build13price;
                build13amount = build13amount + 1;
                build13price = build13price + 251000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 2500;
                label16.Text = "Price: " + build13price + "   Amount: " + build13amount;
            }
        }

        private void button17_Click(object sender, EventArgs e) //When buying building 14
        {
            if (cookies >= build14price)
            {
                cookies = cookies - build14price;
                build14amount = build14amount + 1;
                build14price = build14price + 501500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 5000;
                label17.Text = "Price: " + build14price + "   Amount: " + build14amount;
            }
        }

        private void button18_Click(object sender, EventArgs e) //When buying building 15
        {
            if (cookies >= build15price)
            {
                cookies = cookies - build15price;
                build15amount = build15amount + 1;
                build15price = build15price + 1002000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 10000;
                label18.Text = "Price: " + build15price + "   Amount: " + build15amount;
            }
        }

        private void button19_Click(object sender, EventArgs e) //When buying building 16
        {
            if (cookies >= build16price)
            {
                cookies = cookies - build16price;
                build16amount = build16amount + 1;
                build16price = build16price + 1502000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 15000;
                label19.Text = "Price: " + build16price + "   Amount: " + build16amount;
            }
        }

        private void button20_Click(object sender, EventArgs e) //When buying building 17
        {
            if (cookies >= build17price)
            {
                cookies = cookies - build17price;
                build17amount = build17amount + 1;
                build17price = build17price + 2502000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 25000;
                label23.Text = "Price: " + build17price + "   Amount: " + build17amount;
            }
        }
        private void button21_Click(object sender, EventArgs e)//When buying building 18
        {
            if (cookies >= build18price)
            {
                cookies = cookies - build18price;
                build18amount = build18amount + 1;
                build18price = build18price + 5002500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 50000;
                label24.Text = "Price: " + build18price + "   Amount: " + build18amount;
            }
        }

        private void button22_Click(object sender, EventArgs e)//When buying building 19
        {
            if (cookies >= build19price)
            {
                cookies = cookies - build19price;
                build19amount = build19amount + 1;
                build19price = build19price + 7502500;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 75000;
                label25.Text = "Price: " + build19price + "   Amount: " + build19amount;
            }
        }

        private void button23_Click(object sender, EventArgs e)//When buying building 20
        {
            if (cookies >= build20price)
            {
                cookies = cookies - build20price;
                build20amount = build20amount + 1;
                build20price = build20price + 10003000;
                label1.Text = cookies.ToString();
                buildings = buildings + 1;
                cookiessec = cookiessec + 100000;
                label26.Text = "Price: " + build20price + "   Amount: " + build20amount;
            }
        }

        private void timer1000ms_Tick(object sender, EventArgs e) //Runs code every 1 second
        {
            if (build1amount >= 1)
            {
                cookies = cookies + 1 * build1amount;
                label1.Text = cookies.ToString();
                total = total + 1;
            }
        }

        private void timer500ms_Tick(object sender, EventArgs e) //Runs code every 0,5 second
        {
            if (build3amount >= 1)
            {
                cookies = cookies + 5 * build3amount;
                label1.Text = cookies.ToString();
                total = total + 5 * build3amount;
            }
        }

        private void timer200ms_Tick(object sender, EventArgs e) //Runs code every 0,2 second
        {
            if (build2amount >= 1)
            {
                cookies = cookies + 1 * build2amount;
                label1.Text = cookies.ToString();
                total = total + 1 * build2amount;
            }
            if (build4amount >= 1)
            {
                cookies = cookies + 5 * build4amount;
                label1.Text = cookies.ToString();
                total = total + 5 * build4amount;
            }
            if (build7amount >= 1)
            {
                cookies = cookies + 50 * build7amount;
                label1.Text = cookies.ToString();
                total = total + 50 * build7amount;
            }
            if (build8amount >= 1)
            {
                cookies = cookies + 100 * build8amount;
                label1.Text = cookies.ToString();
                total = total + 100 * build8amount;
            }
            label32.Text = buildings.ToString();
            label33.Text = cookiessec.ToString();
        }

        private void timer100ms_Tick(object sender, EventArgs e) //Runs code every 0,1 second
        {
            if (build5amount >= 1)
            {
                cookies = cookies + 5 * build5amount;
                label1.Text = cookies.ToString();
                total = total + 5 * build5amount;
            }
            if (build6amount >= 1)
            {
                cookies = cookies + 10 * build6amount;
                label1.Text = cookies.ToString();
                total = total + 10 * build6amount;
            }
            if (build9amount >= 1)
            {
                cookies = cookies + 75 * build9amount;
                label1.Text = cookies.ToString();
                total = total + 75 * build9amount;
            }
            if (build10amount >= 1)
            {
                cookies = cookies + 100 * build10amount;
                label1.Text = cookies.ToString();
                total = total + 100 * build10amount;
            }
            if (build11amount >= 1)
            {
                cookies = cookies + 150 * build11amount;
                label1.Text = cookies.ToString();
                total = total + 150 * build11amount;
            }
            if (build12amount >= 1)
            {
                cookies = cookies + 200 * build12amount;
                label1.Text = cookies.ToString();
                total = total + 200 * build12amount;
            }
            if (build13amount >= 1)
            {
                cookies = cookies + 250 * build13amount;
                label1.Text = cookies.ToString();
                total = total + 250 * build13amount;
            }
            if (build14amount >= 1)
            {
                cookies = cookies + 500 * build14amount;
                label1.Text = cookies.ToString();
                total = total + 500 * build14amount;
            }
            if (build15amount >= 1)
            {
                cookies = cookies + 1000 * build15amount;
                label1.Text = cookies.ToString();
                total = total + 1000 * build15amount;
            }
            if (build16amount >= 1)
            {
                cookies = cookies + 1500 * build16amount;
                label1.Text = cookies.ToString();
                total = total + 1500 * build16amount;
            }
            if (build17amount >= 1)
            {
                cookies = cookies + 2500 * build17amount;
                label1.Text = cookies.ToString();
                total = total + 2500 * build17amount;
            }
            if (build18amount >= 1)
            {
                cookies = cookies + 5000 * build18amount;
                label1.Text = cookies.ToString();
                total = total + 5000 * build18amount;
            }
            if (build19amount >= 1)
            {
                cookies = cookies + 7500 * build19amount;
                label1.Text = cookies.ToString();
                total = total + 7500 * build19amount;
            }
            if (build20amount >= 1)
            {
                cookies = cookies + 10000 * build20amount;
                label1.Text = cookies.ToString();
                total = total + 10000 * build20amount;
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
                if (acha == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 1000+ cookies.";
                }
                acha = true;
            }
            if (cookies >= 10000)
            {
                if (achb == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 10000+ cookies!";
                }
                achb = true;
            }
            if (cookies >= 100000)
            {
                if (achc == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 100000+ cookies!!";
                }
                achc = true;
            }
            if (cookies >= 1000000)
            {
                if (achd == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 1000000+ cookies!!!";
                }
                achd = true;
            }
            if (cookies >= 10000000)
            {
                if (ache == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 10000000+ cookies!!!!";
                }
                ache = true;
            }
            if (cookies >= 100000000)
            {
                if (achf == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 100000000+ cookies!1!!!";
                }
                achf = true;
            }
            if (cookies >= 1000000000)
            {
                if (achg == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 1000000000+ cookies!!!1!1";
                }
                achg = true;
            }
            if (buildings >= 25)
            {
                if (achh == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 25+ Buildings.";
                }
                achh = true;
            }
            if (buildings >= 50)
            {
                if (achi == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 50+ Buildings!";
                }
                achi = true;
            }
            if (buildings >= 75)
            {
                if (achj == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 75+ Buildings!!";
                }
                achj = true;
            }
            if (buildings >= 100)
            {
                if (achk == false)
                {
                    achievements = achievements + 1;
                    label36.Text = achievements + "/" + achievementamount + " - 100+ Buildings!1!";
                }
                achk = true;
            }
            if (savedgame == true)
            {
                if (achl == false)
                {
                    achievements = achievements + 1;
                    savedgame = true;
                    label36.Text = achievements + "/" + achievementamount + " - Saved the game.";
                }
                achl = true;
            }
            if (loadedgame == true)
            {
                if (achm == false)
                {
                    achievements = achievements + 1;
                    loadedgame = false;
                    label36.Text = achievements + "/" + achievementamount + " - Loaded the game.";
                }
                achm = true;
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
            build1amounttxt = build1amount.ToString();
            build2amounttxt = build2amount.ToString();
            build3amounttxt = build3amount.ToString();
            build4amounttxt = build4amount.ToString();
            build5amounttxt = build5amount.ToString();
            build6amounttxt = build6amount.ToString();
            build7amounttxt = build7amount.ToString();
            build8amounttxt = build8amount.ToString();
            build9amounttxt = build9amount.ToString();
            build10amounttxt = build10amount.ToString();
            build11amounttxt = build11amount.ToString();
            build12amounttxt = build12amount.ToString();
            build13amounttxt = build13amount.ToString();
            build14amounttxt = build14amount.ToString();
            build15amounttxt = build15amount.ToString();
            build16amounttxt = build16amount.ToString();
            build17amounttxt = build17amount.ToString();
            build18amounttxt = build18amount.ToString();
            build19amounttxt = build19amount.ToString();
            build20amounttxt = build20amount.ToString();
            build1pricetxt = build1price.ToString();
            build2pricetxt = build2price.ToString();
            build3pricetxt = build3price.ToString();
            build4pricetxt = build4price.ToString();
            build5pricetxt = build5price.ToString();
            build6pricetxt = build6price.ToString();
            build7pricetxt = build7price.ToString();
            build8pricetxt = build8price.ToString();
            build9pricetxt = build9price.ToString();
            build10pricetxt = build10price.ToString();
            build11pricetxt = build11price.ToString();
            build12pricetxt = build12price.ToString();
            build13pricetxt = build13price.ToString();
            build14pricetxt = build14price.ToString();
            build15pricetxt = build15price.ToString();
            build16pricetxt = build16price.ToString();
            build17pricetxt = build17price.ToString();
            build18pricetxt = build18price.ToString();
            build19pricetxt = build19price.ToString();
            build20pricetxt = build20price.ToString();
            achievementamounttxt = achievementamount.ToString();
            achatxt = acha;
            achatxt = achb;
            achatxt = achc;
            achatxt = achd;
            achatxt = ache;
            achatxt = achf;
            achatxt = achg;
            achatxt = achh;
            achatxt = achi;
            achatxt = achj;
            achatxt = achk;
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
            Save.WriteLine(build1amounttxt);
            Save.WriteLine(build2amounttxt);
            Save.WriteLine(build3amounttxt);
            Save.WriteLine(build4amounttxt);
            Save.WriteLine(build5amounttxt);
            Save.WriteLine(build6amounttxt);
            Save.WriteLine(build7amounttxt);
            Save.WriteLine(build8amounttxt);
            Save.WriteLine(build9amounttxt);
            Save.WriteLine(build10amounttxt);
            Save.WriteLine(build11amounttxt);
            Save.WriteLine(build12amounttxt);
            Save.WriteLine(build13amounttxt);
            Save.WriteLine(build14amounttxt);
            Save.WriteLine(build15amounttxt);
            Save.WriteLine(build16amounttxt);
            Save.WriteLine(build17amounttxt);
            Save.WriteLine(build18amounttxt);
            Save.WriteLine(build19amounttxt);
            Save.WriteLine(build20amounttxt);
            Save.WriteLine(build1pricetxt);
            Save.WriteLine(build2pricetxt);
            Save.WriteLine(build3pricetxt);
            Save.WriteLine(build4pricetxt);
            Save.WriteLine(build5pricetxt);
            Save.WriteLine(build6pricetxt);
            Save.WriteLine(build7pricetxt);
            Save.WriteLine(build8pricetxt);
            Save.WriteLine(build9pricetxt);
            Save.WriteLine(build10pricetxt);
            Save.WriteLine(build11pricetxt);
            Save.WriteLine(build12pricetxt);
            Save.WriteLine(build13pricetxt);
            Save.WriteLine(build14pricetxt);
            Save.WriteLine(build15pricetxt);
            Save.WriteLine(build16pricetxt);
            Save.WriteLine(build17pricetxt);
            Save.WriteLine(build18pricetxt);
            Save.WriteLine(build19pricetxt);
            Save.WriteLine(build20pricetxt);
            Save.WriteLine(achievementamounttxt);
            Save.WriteLine(achatxt);
            Save.WriteLine(achbtxt);
            Save.WriteLine(achctxt);
            Save.WriteLine(achdtxt);
            Save.WriteLine(achetxt);
            Save.WriteLine(achftxt);
            Save.WriteLine(achgtxt);
            Save.WriteLine(achhtxt);
            Save.WriteLine(achitxt);
            Save.WriteLine(achjtxt);
            Save.WriteLine(achktxt);
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
            build1amount = Convert.ToInt32(reader.ReadLine());
            build2amount = Convert.ToInt32(reader.ReadLine());
            build3amount = Convert.ToInt32(reader.ReadLine());
            build4amount = Convert.ToInt32(reader.ReadLine());
            build5amount = Convert.ToInt32(reader.ReadLine());
            build6amount = Convert.ToInt32(reader.ReadLine());
            build7amount = Convert.ToInt32(reader.ReadLine());
            build8amount = Convert.ToInt32(reader.ReadLine());
            build9amount = Convert.ToInt32(reader.ReadLine());
            build10amount = Convert.ToInt32(reader.ReadLine());
            build11amount = Convert.ToInt32(reader.ReadLine());
            build12amount = Convert.ToInt32(reader.ReadLine());
            build13amount = Convert.ToInt32(reader.ReadLine());
            build14amount = Convert.ToInt32(reader.ReadLine());
            build15amount = Convert.ToInt32(reader.ReadLine());
            build16amount = Convert.ToInt32(reader.ReadLine());
            build17amount = Convert.ToInt32(reader.ReadLine());
            build18amount = Convert.ToInt32(reader.ReadLine());
            build19amount = Convert.ToInt32(reader.ReadLine());
            build20amount = Convert.ToInt32(reader.ReadLine());
            build1price = Convert.ToInt32(reader.ReadLine());
            build2price = Convert.ToInt32(reader.ReadLine());
            build3price = Convert.ToInt32(reader.ReadLine());
            build4price = Convert.ToInt32(reader.ReadLine());
            build5price = Convert.ToInt32(reader.ReadLine());
            build6price = Convert.ToInt32(reader.ReadLine());
            build7price = Convert.ToInt32(reader.ReadLine());
            build8price = Convert.ToInt32(reader.ReadLine());
            build9price = Convert.ToInt32(reader.ReadLine());
            build10price = Convert.ToInt32(reader.ReadLine());
            build11price = Convert.ToInt32(reader.ReadLine());
            build12price = Convert.ToInt32(reader.ReadLine());
            build13price = Convert.ToInt32(reader.ReadLine());
            build14price = Convert.ToInt32(reader.ReadLine());
            build15price = Convert.ToInt32(reader.ReadLine());
            build16price = Convert.ToInt32(reader.ReadLine());
            build17price = Convert.ToInt32(reader.ReadLine());
            build18price = Convert.ToInt32(reader.ReadLine());
            build19price = Convert.ToInt32(reader.ReadLine());
            build20price = Convert.ToInt32(reader.ReadLine());
            achievementamount = Convert.ToInt32(reader.ReadLine());
            acha = Convert.ToBoolean(reader.ReadLine());
            achb = Convert.ToBoolean(reader.ReadLine());
            achc = Convert.ToBoolean(reader.ReadLine());
            achd = Convert.ToBoolean(reader.ReadLine());
            ache = Convert.ToBoolean(reader.ReadLine());
            achf = Convert.ToBoolean(reader.ReadLine());
            achg = Convert.ToBoolean(reader.ReadLine());
            achh = Convert.ToBoolean(reader.ReadLine());
            achi = Convert.ToBoolean(reader.ReadLine());
            achj = Convert.ToBoolean(reader.ReadLine());
            achk = Convert.ToBoolean(reader.ReadLine());
            upgradeamount = Convert.ToInt32(reader.ReadLine());
            upgradeprice = Convert.ToInt32(reader.ReadLine());
            reader.Close();

            label1.Text = cookies.ToString();
            label3.Text = "Price: " + upgradeprice + "   Amount: " + upgradeamount;
            label4.Text = "Price: " + build1price + "   Amount: " + build1amount;
            label5.Text = "Price: " + build2price + "   Amount: " + build2amount;
            label6.Text = "Price: " + build3price + "   Amount: " + build3amount;
            label7.Text = "Price: " + build4price + "   Amount: " + build4amount;
            label8.Text = "Price: " + build5price + "   Amount: " + build5amount;
            label9.Text = "Price: " + build6price + "   Amount: " + build6amount;
            label10.Text = "Price: " + build7price + "   Amount: " + build7amount;
            label11.Text = "Price: " + build8price + "   Amount: " + build8amount;
            label12.Text = "Price: " + build9price + "   Amount: " + build9amount;
            label13.Text = "Price: " + build10price + "   Amount: " + build10amount;
            label14.Text = "Price: " + build11price + "   Amount: " + build11amount;
            label15.Text = "Price: " + build12price + "   Amount: " + build12amount;
            label16.Text = "Price: " + build13price + "   Amount: " + build13amount;
            label17.Text = "Price: " + build14price + "   Amount: " + build14amount;
            label18.Text = "Price: " + build15price + "   Amount: " + build15amount;
            label19.Text = "Price: " + build16price + "   Amount: " + build16amount;
            label23.Text = "Price: " + build17price + "   Amount: " + build17amount;
            label24.Text = "Price: " + build18price + "   Amount: " + build18amount;
            label25.Text = "Price: " + build19price + "   Amount: " + build19amount;
            label26.Text = "Price: " + build20price + "   Amount: " + build20amount;
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