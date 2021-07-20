using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
        }


        private void riseto_Click(object sender, EventArgs e)
        {
            this.Init();
        }
        #endregion


        #region "Custom methods"
        private void Init()
        {
            this.kuruma.SelectedIndex = 0;
            this.enjin.SelectedIndex = 0;
            this.keeka.Text = "";
        }
        #endregion


        private void kuruma_SelectedIndexChanged(object sender, EventArgs e)    
        {
            if (this.kuruma.SelectedIndex == 0)
            {
                this.enjin.Items.Clear();
                this.enjin.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                this.enjin.Items.Add("151 - 250 / 12.1 - 20HP(12.3 - 20.3PS)");
                this.enjin.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                this.enjin.Items.Add("501-600");
                this.enjin.Items.Add("601-1200");
                this.enjin.Items.Add("1201-1800");
                this.enjin.Items.Add("1801或以上");
                this.enjin.SelectedIndex = 0;
            }
            if (this.kuruma.SelectedIndex == 1)
            {
                this.enjin.Items.Clear();
                this.enjin.Items.Add("500以下");
                this.enjin.Items.Add("501-600");
                this.enjin.Items.Add("601-1200");
                this.enjin.Items.Add("1201-1800");
                this.enjin.Items.Add("1801-2400");
                this.enjin.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.enjin.Items.Add("3001-3600");
                this.enjin.Items.Add("3601-4200 /138.1-200HP(140.2-203.0PS)");
                this.enjin.Items.Add("4201-4800");
                this.enjin.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS");
                this.enjin.Items.Add("5401-6000");
                this.enjin.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS");
                this.enjin.Items.Add("6601-7200");
                this.enjin.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS");
                this.enjin.Items.Add("7801-8400");
                this.enjin.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.enjin.Items.Add("9001-9600");
                this.enjin.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.enjin.Items.Add("10201以上");
                this.enjin.SelectedIndex = 0;
            }
            if (this.kuruma.SelectedIndex == 2)
            {
                this.enjin.Items.Clear();
                this.enjin.Items.Add("600以下");
                this.enjin.Items.Add("601-1200");
                this.enjin.Items.Add("1201-1800");
                this.enjin.Items.Add("1801-2400");
                this.enjin.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.enjin.Items.Add("3001-3600");
                this.enjin.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                this.enjin.Items.Add("4201-4800");
                this.enjin.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.enjin.Items.Add("5401-6000");
                this.enjin.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                this.enjin.Items.Add("6601.7200");
                this.enjin.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS");
                this.enjin.Items.Add("7801-8400");
                this.enjin.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS");
                this.enjin.Items.Add("9001-9600");
                this.enjin.Items.Add("9601-10200 / 361.1HP以上(366.PS以上)");
                this.enjin.Items.Add("10201以上");
                this.enjin.SelectedIndex = 0;
            }
            if (this.kuruma.SelectedIndex == 3)
            {
                this.enjin.Items.Clear();
                this.enjin.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.enjin.Items.Add("501-600 / 38.1-56HP(38.7-56.8PS)");
                this.enjin.Items.Add("601-1200 / 56.1-83HP(56.9-84.2PS)");
                this.enjin.Items.Add("1201-1800 / 83.1-182HP(84.3-184.7PS)");
                this.enjin.Items.Add("1801-2400 / 182.1-262HP(184.8-265.9PS)");
                this.enjin.Items.Add("2401-3000 / 262.1-322HP(266-326.8PS)");
                this.enjin.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                this.enjin.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.enjin.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.enjin.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.enjin.Items.Add("7801以上");
                this.enjin.SelectedIndex = 0;
            }
            if (this.kuruma.SelectedIndex == 4)
            {
                this.enjin.Items.Clear();
                this.enjin.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.enjin.Items.Add("501-600 / 38.1-56HP(38.7-56.8PS)");
                this.enjin.Items.Add("601-1200 / 56.1-83HP(56.9-84.2PS)");
                this.enjin.Items.Add("1201-1800 / 83.1-182HP(84.3-184.7PS)");
                this.enjin.Items.Add("1801-2400 / 182.1-262HP(184.8-265.9PS)");
                this.enjin.Items.Add("2401-3000 / 262.1-322HP(266-326.8PS)");
                this.enjin.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                this.enjin.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.enjin.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.enjin.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.enjin.Items.Add("7801以上");
                this.enjin.SelectedIndex = 0;
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.dateTimePicker1.Visible = true;
                this.dateTimePicker2.Visible = true;
                this.label1.Visible = true;
                this.label2.Visible = true;
            }
            if (radioButton2.Checked == false)
            {
                this.dateTimePicker1.Visible = false;
                this.dateTimePicker2.Visible = false;
                this.label1.Visible = false;
                this.label2.Visible = false;
            }
        }


        void result(string a, string b, int c)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            int diffDays;
            int ryoukin;
            int yearDays;
            string nen;


            if (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                yearDays = 366;
            }

            else
            {
                yearDays = 365;

            }

            if (radioButton2.Checked == true)
            {

                TimeSpan span = date2 - date1;
                diffDays = span.Days + 1;
                nen = (dateTimePicker1.Value.Year - 1911).ToString() + dateTimePicker1.Value.ToString("-MM-dd") + "~" + (dateTimePicker2.Value.Year - 1911).ToString() + dateTimePicker2.Value.ToString("-MM-dd");
            }

            else
            {
                diffDays = yearDays;
                nen = (dateTimePicker1.Value.Year - 1911).ToString() +  "-01-01" + "~" + (dateTimePicker1.Value.Year - 1911).ToString() + "-12-31";
            }

            ryoukin = c * diffDays / yearDays;

            if (diffDays < 0 || dateTimePicker1.Value.Year < 1911)
            {
                this.keeka.Text = "日期設定錯誤,選擇年份台灣尚未建國,請重新設定日期";
            }
             
            else
            {
                this.keeka.Text =
                "使用期間:" + nen + "\r\n" +
                "計算天數: " + diffDays.ToString() + "天" + "\r\n" +
                "汽缸CC數:" + a + "\r\n" +
                "用途: " + b + "\r\n" +
                "計算公式: " + c.ToString() + " * " + diffDays.ToString() + " / " + yearDays.ToString() + "= " + ryoukin.ToString() + " 元 " + "\r\n" +
                "應納稅額: 共 " + ryoukin.ToString() + " 元 ";
            }
        }


        private void kakutei_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            int diffDays;
            int ryoukin;
            //0=機車 1=貨車 2=大客車 3=自用小客車 4=營業用小客車
            if (this.kuruma.SelectedIndex == 0 && this.enjin.SelectedIndex == 0)
            {
                result("150以下 / 12HP以下(12.2PS以下)", "機車", 0);
            }

            else if (this.kuruma.SelectedIndex == 0 && this.enjin.SelectedIndex == 1)
            {
                result("151 - 250 / 12.1 - 20HP(12.3 - 20.3PS)", "機車", 800);
            }

            else if (this.kuruma.SelectedIndex == 0 && this.enjin.SelectedIndex == 2)
            {
                result("汽缸CC數:251-500 / 20.1HP以上(20.4PS以上)", "機車", 1620);
            }

            else if (this.kuruma.SelectedIndex == 0 && this.enjin.SelectedIndex == 3)
            {
                result("501-600", "機車", 2160);
            }

            else if (this.kuruma.SelectedIndex == 0 && this.enjin.SelectedIndex == 4)
            {
                result("601-1200", "機車", 4320);
            }

            else if (this.kuruma.SelectedIndex == 0 && this.enjin.SelectedIndex == 5)
            {
                result("1201-1800", "機車", 7120);
            }

            else if (this.kuruma.SelectedIndex == 0 && this.enjin.SelectedIndex == 6)
            {
                result("1800或以上", "機車", 11230);
            }

            if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 0)
            {
                result("500以下", "貨車", 900);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 1)
            {
                result("501-600", "貨車", 1080);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 2)
            {
                result("601-1200", "貨車", 1800);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 3)
            {
                result("1201-1800", "貨車", 2700);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 4)
            {
                result("1801-2400", "貨車", 3600);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 5)
            {
                result("2401-3000 / 138HP以下(140.1PS以下)", "貨車", 4500);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 6)
            {
                result("3001-3600", "貨車", 5400);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 7)
            {
                result("3601-4200 / 138.1-200HP(140.2-203.0PS)", "貨車", 6300);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 8)
            {
                result("4201-4800", "貨車", 7200);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 9)
            {
                result("4801-5400 / 200.1-247HP(203.1-250.7PS)", "貨車", 8100);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 10)
            {
                result("5401-6000", "貨車", 9000);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 11)
            {
                result("6001-6600 / 247.1-286HP(250.8-290.3PS)", "貨車", 9900);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 12)
            {
                result("6601-7200", "貨車", 10800);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 13)
            {
                result("7201-7800 / 286.1-336HP(290.4-341.0PS)", "貨車", 11700);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 14)
            {
                result("7801-8400", "貨車", 12600);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 15)
            {
                result("8401-9000 / 336.1-361HP(341.1-366.4PS)", "貨車", 13500);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 16)
            {
                result("9001-9600", "貨車", 14400);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 17)
            {
                result("9601-10200 / 361.1HP以上(366.5PS以上)", "貨車", 15300);
            }

            else if (this.kuruma.SelectedIndex == 1 && this.enjin.SelectedIndex == 18)
            {
                result("10201以上", "貨車", 16200);
            }

            if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 0)
            {
                result("600以下", "大客車", 1080);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 1)
            {
                result("601-1200", "大客車", 1800);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 2)
            {
                result("1201-1800", "大客車", 2700);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 3)
            {
                result("1801-2400", "大客車", 3600);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 4)
            {
                result("2401-3000", "大客車", 4500);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 5)
            {
                result("3001-3600", "大客車", 5400);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 6)
            {
                result("3601-4200", "大客車", 6300);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 7)
            {
                result("4201-4800", "大客車", 7200);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 8)
            {
                result("4801-5400 / 200.1-247HP(203.1-250.7PS)", "大客車", 8100);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 9)
            {
                result("5401-6000", "大客車", 9000);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 10)
            {
                result("6001-6600 / 247.1-286HP(250.8-290.3PS)", "大客車", 9900);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 11)
            {
                result("6601-7200", "大客車", 10800);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 12)
            {
                result("7201-7800 / 286.1-336HP(290.4-341.0PS)", "大客車", 11700);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 13)
            {
                result("7801-8400", "大客車", 12600);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 14)
            {
                result("8401-9000 / 336.1-361HP(341.1-366.4PS)", "大客車", 13500);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 15)
            {
                result("9001-9600", "大客車", 14400);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 16)
            {
                result("9601-10200 / 361.1HP以上(366.5PS以上)", "大客車", 15300);
            }

            else if (this.kuruma.SelectedIndex == 2 && this.enjin.SelectedIndex == 17)
            {
                result("10201以上", "大客車", 16200);
            }

            if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 0)
            {
                result("500以下 / 38HP以下(38.6PS以下)", "自用小客車", 1620);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 1)
            {
                result("501-600 / 38.1-56HP(38.7-56.8PS)", "自用小客車", 2160);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 2)
            {
                result("601-1200 / 56.1-83HP(56.9-84.2PS)", "自用小客車", 4320);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 3)
            {
                result("1201-1800 / 83.1-182HP(84.3-184.7PS)", "自用小客車", 7120);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 4)
            {
                result("1801-2400 / 182.1-262HP(184.8-265.9PS)", "自用小客車", 11230);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 5)
            {
                result("2401-3000 / 262.1-322HP(266-326.8PS)", "自用小客車", 15210);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 6)
            {
                result("3001-4200 / 322.1-414HP(326.9-420.2PS)", "自用小客車", 28220);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 7)
            {
                result("4201-5400 / 414.1-469HP(420.3-476.0PS)", "自用小客車", 46170);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 8)
            {
                result("5401-6600 / 469.1-509HP(476.1-516.6PS)", "自用小客車", 69690);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 9)
            {
                result("6601-7800 / 509.1HP以上(516.7PS以上)", "自用小客車", 117000);
            }

            else if (this.kuruma.SelectedIndex == 3 && this.enjin.SelectedIndex == 10)
            {
                result("7801以上", "自用小客車", 151200);
            }

            if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 0)
            {
                result("500以下 / 38HP以下(38.6PS以下)", "營業用小客車", 900);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 1)
            {
                result("501-600 / 38.1-56HP(38.7-56.8PS)", "營業用小客車", 1260);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 2)
            {
                result("601-1200 / 56.1-83HP(56.9-84.2PS)", "營業用小客車", 2160);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 3)
            {
                result("1201-1800 /83.1-182HP(84.3-184.7PS)", "營業用小客車", 3060);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 4)
            {
                result("1801-2400 / 182.1-262HP(184.8-265.9PS)", "營業用小客車", 6480);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 5)
            {
                result("2401-3000 / 262.1-322HP(266-326.8PS)", "營業用小客車", 9900);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 6)
            {
                result("3001-4200 / 322.1-414HP(326.9-420.2PS", "營業用小客車", 16380);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 7)
            {
                result("4201-5400 / 414.1-469HP(420.3-476.0PS)", "營業用小客車", 24300);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 8)
            {
                result("5401-6600 / 469.1-509HP(476.1-516.6PS)", "營業用小客車", 33660);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 9)
            {
                result("6601-7800 /509.1HP以上(516.7PS以上)", "營業用小客車", 44460);
            }

            else if (this.kuruma.SelectedIndex == 4 && this.enjin.SelectedIndex == 10)
            {
                result("7801以上", "營業用小客車", 56700);
            }
        }
    }
}
