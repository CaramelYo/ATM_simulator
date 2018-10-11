using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NTD_btn.Click += money_btn_click;
            USD_btn.Click += money_btn_click;

            // initialize status
            status = 1;

            // initialize money
            money = 10000;
            history = "[初始] " + money.ToString() + " NTD\r\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                c.Visible = false;

            switch (status)
            {
                case 0:
                    // reserved
                    break;
                case 1:
                    // login page
                    login_label.Visible = true;
                    login_textbox.Visible = true;
                    login_btn.Visible = true;

                    login_label.Text = "請輸入6~12為晶片卡密碼: \r\nEnter PIN (6~12 Digits)";
                    login_textbox.Text = "";
                    break;
                case 2:
                    // service page
                    service_title.Visible = true;
                    withdraw_btn.Visible = true;
                    top_up_btn.Visible = true;
                    check_balance_btn.Visible = true;
                    check_history_btn.Visible = true;
                    logout_btn.Visible = true;
                    break;
                case 3:
                    // withdraw page
                    money_label.Visible = true;
                    money_textbox.Visible = true;
                    NTD_btn.Visible = true;
                    USD_btn.Visible = true;
                    logout_btn.Visible = true;

                    money_label.Text = "請輸入提款金額: ";
                    money_textbox.Text = "";
                    break;
                case 4:
                    // top_up page
                    money_label.Visible = true;
                    money_textbox.Visible = true;
                    NTD_btn.Visible = true;
                    USD_btn.Visible = true;
                    logout_btn.Visible = true;

                    money_label.Text = "請輸入存款金額: ";
                    money_textbox.Text = "";
                    break;
                case 5:
                    // check_balance page
                    login_label.Visible = true;
                    logout_btn.Visible = true;

                    login_label.Text = "餘額剩下: " + money.ToString() + " NTD\r\n謝謝您的惠顧，歡迎下次再來！";
                    break;
                case 6:
                    // check_history page
                    history_textbox.Visible = true;
                    logout_btn.Visible = true;

                    history_textbox.Text = history;
                    break;
                default:
                    // unexpected status
                    history += "unexpected situation in status switch\r\n";
                    break;
            }
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_textbox.Text == "000000")
            {
                // correct password
                status = 2;
                Form1_Load(this, e);
            }
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            status = 3;
            Form1_Load(this, e);
        }

        private void top_up_btn_Click(object sender, EventArgs e)
        {
            status = 4;
            Form1_Load(this, e);
        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            status = 5;
            Form1_Load(this, e);
        }

        private void check_history_btn_Click(object sender, EventArgs e)
        {
            status = 6;
            Form1_Load(this, e);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            status = 1;
            Form1_Load(this, e);
        }

        private void money_btn_click(object sender, EventArgs e)
        {
            string m_type = ((Button)sender).Text;

            int m = 0, exchange_rate;
            try
            {
                m = int.Parse(money_textbox.Text);
            }
            catch
            {

                // unexpected situation
                history += "unexpected situation in parsing money in money_btn_click\r\n";
                return;
            }

            switch (m_type)
            {
                case "USD":
                    exchange_rate = 3;
                    break;
                case "NTD":
                    exchange_rate = 1;
                    break;
                default:
                    // unexpected situation
                    history += "unexpected situation in money_type in money_btn_click\r\n";
                    return;
            }

            // change to NTD
            int NTD = m * exchange_rate;
            
            if (status == 3)
            {
                // withdraw status
                if (money >= NTD)
                {
                    // sufficient
                    money -= NTD;
                    history += "[提款] " + NTD.ToString() + " NTD (" + m.ToString() + " " + m_type + ")\r\n";
                    history += "[餘額] " + money.ToString() + " NTD\r\n";
                }
            }
            else if (status == 4)
            {
                // top_up status
                money += NTD;
                history += "[存款] " + NTD.ToString() + " NTD (" + m.ToString() + " " + m_type + ")\r\n";
                history += "[餘額] " + money.ToString() + " NTD\r\n";
            }

            status = 1;
            Form1_Load(this, e);
        }

        //List<List<Control>> control_list;
        List<Control> control_list;

        string history;
        int exchange_rate = 30;
        int status, money;
    }
}
