namespace CurePlease
{
    using EliteMMO.API;
    using System;
    using System.Windows.Forms;
    using static CurePleaseForm;

    public partial class ChatLogForm : Form
    {
        private CurePleaseForm f1;

        public ChatLogForm(CurePleaseForm f)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            f1 = f;

            if (f1.setinstance2.Enabled == true)
            {
                #region "== First generate all current chat entries."

                _ELITEAPIPL = new EliteAPI((int)f1.activeprocessids.SelectedItem);
                characterNamed_label.Text = "Chatlog for character: " + _ELITEAPIPL.Player.Name + "\n";

                EliteAPI.ChatEntry cl = new EliteAPI.ChatEntry();

                while ((cl = _ELITEAPIPL.Chat.GetNextChatLine()) != null)
                {
                    chatlog_box.AppendText(cl.Text, cl.ChatColor);
                    chatlog_box.AppendText(Environment.NewLine);
                }

                chatlog_box.SelectionStart = chatlog_box.Text.Length;
                chatlog_box.ScrollToCaret();

                #endregion "== First generate all current chat entries."
            }
            else
            {
                chatlogscan_timer.Enabled = false;
                MessageBox.Show("No character was selected as the power leveler, this can not be opened yet.");

            }
        }

        private void CloseChatLog_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chatlogscan_timer_Tick(object sender, EventArgs e)
        {
            #region "== Now add any additional chat entries every set period of time"

            EliteAPI.ChatEntry cl = new EliteAPI.ChatEntry();

            while ((cl = _ELITEAPIPL.Chat.GetNextChatLine()) != null)
            {
                chatlog_box.AppendText(cl.Text, cl.ChatColor);
                chatlog_box.AppendText(Environment.NewLine);
            }

            #endregion "== Now add any additional chat entries every set period of time"
        }

        private void chatlog_box_TextChanged(object sender, EventArgs e)
        {
            chatlog_box.SelectionStart = chatlog_box.Text.Length;
            chatlog_box.ScrollToCaret();
        }

        private void SendMessage_botton_Click(object sender, EventArgs e)
        {
            _ELITEAPIPL.ThirdParty.SendString(ChatLogMessage_textfield.Text);
            ChatLogMessage_textfield.Text = string.Empty;
        }
    }
}
