using System;
using System.Net;
using System.Windows.Forms;

namespace Sms
{
    public partial class Form1 : Form
    {
        private static int totalCount = 60;
        private static string thisText;
        private static string nick;
        private static string alya;
        private static string _sender;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxMessage.KeyDown += textBox_KeyDown;
            textBoxSender.KeyDown += textBox_KeyDown;
            nick = "http://sms.ru/sms/send?api_id=0806be6f-b55d-3614-c937-7713a28f5061&to=79111809287&text=";
            alya = "http://sms.ru/sms/send?api_id=f46db30a-88f8-a704-1d50-8a471e58c30f&to=79811253559&text=";
            radioButtonNick.Select();
            textBoxMessage.Select();
            thisText = this.Text;
            textBoxMessage.MaxLength = totalCount;
            textBoxSender.MaxLength = 5;
            labelCountSymnols.Text = totalCount.ToString();
        }

        void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                buttonSend.PerformClick();
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            labelCountSymnols.Text = (totalCount - textBoxMessage.Text.Length).ToString();
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (radioButtonAlya.Checked) _sender = alya;
            else if (radioButtonNick.Checked) _sender = nick;
            try
            {
                if (!textBoxMessage.Text.Trim().Equals("") && !textBoxSender.Text.Trim().Equals(""))
                {
                    string message = textBoxMessage.Text.Replace(" ", "+") + ". " + textBoxSender.Text;
                    HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(_sender + message);
                    myReq.GetResponse();
                    MessageBox.Show("Сообщение отправлено");
                    textBoxMessage.Text = "";
                    textBoxSender.Text = "";
                    textBoxMessage.Select();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
