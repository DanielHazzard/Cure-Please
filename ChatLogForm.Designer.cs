namespace CurePlease
{
    partial class ChatLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chatlog_box = new System.Windows.Forms.RichTextBox();
            this.ChatLogMessage_textfield = new System.Windows.Forms.TextBox();
            this.SendMessage_botton = new System.Windows.Forms.Button();
            this.CloseChatLog_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.characterNamed_label = new System.Windows.Forms.Label();
            this.chatlogscan_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatlog_box
            // 
            this.chatlog_box.BackColor = System.Drawing.Color.Black;
            this.chatlog_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatlog_box.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatlog_box.ForeColor = System.Drawing.SystemColors.Window;
            this.chatlog_box.Location = new System.Drawing.Point(32, 48);
            this.chatlog_box.Margin = new System.Windows.Forms.Padding(7);
            this.chatlog_box.Name = "chatlog_box";
            this.chatlog_box.ReadOnly = true;
            this.chatlog_box.Size = new System.Drawing.Size(863, 367);
            this.chatlog_box.TabIndex = 0;
            this.chatlog_box.Text = "";
            this.chatlog_box.TextChanged += new System.EventHandler(this.chatlog_box_TextChanged);
            // 
            // ChatLogMessage_textfield
            // 
            this.ChatLogMessage_textfield.Location = new System.Drawing.Point(12, 413);
            this.ChatLogMessage_textfield.MaxLength = 125;
            this.ChatLogMessage_textfield.Name = "ChatLogMessage_textfield";
            this.ChatLogMessage_textfield.Size = new System.Drawing.Size(701, 24);
            this.ChatLogMessage_textfield.TabIndex = 1;
            // 
            // SendMessage_botton
            // 
            this.SendMessage_botton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage_botton.Location = new System.Drawing.Point(719, 413);
            this.SendMessage_botton.Name = "SendMessage_botton";
            this.SendMessage_botton.Size = new System.Drawing.Size(75, 23);
            this.SendMessage_botton.TabIndex = 2;
            this.SendMessage_botton.Text = "Send";
            this.SendMessage_botton.UseVisualStyleBackColor = true;
            this.SendMessage_botton.Click += new System.EventHandler(this.SendMessage_botton_Click);
            // 
            // CloseChatLog_button
            // 
            this.CloseChatLog_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseChatLog_button.Location = new System.Drawing.Point(800, 413);
            this.CloseChatLog_button.Name = "CloseChatLog_button";
            this.CloseChatLog_button.Size = new System.Drawing.Size(75, 23);
            this.CloseChatLog_button.TabIndex = 3;
            this.CloseChatLog_button.Text = "Close";
            this.CloseChatLog_button.UseVisualStyleBackColor = true;
            this.CloseChatLog_button.Click += new System.EventHandler(this.CloseChatLog_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.characterNamed_label);
            this.panel1.Controls.Add(this.chatlog_box);
            this.panel1.Location = new System.Drawing.Point(-20, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 521);
            this.panel1.TabIndex = 4;
            // 
            // characterNamed_label
            // 
            this.characterNamed_label.AutoSize = true;
            this.characterNamed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNamed_label.ForeColor = System.Drawing.Color.White;
            this.characterNamed_label.Location = new System.Drawing.Point(29, 21);
            this.characterNamed_label.Name = "characterNamed_label";
            this.characterNamed_label.Size = new System.Drawing.Size(0, 20);
            this.characterNamed_label.TabIndex = 1;
            // 
            // chatlogscan_timer
            // 
            this.chatlogscan_timer.Enabled = true;
            this.chatlogscan_timer.Tick += new System.EventHandler(this.chatlogscan_timer_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 442);
            this.Controls.Add(this.CloseChatLog_button);
            this.Controls.Add(this.SendMessage_botton);
            this.Controls.Add(this.ChatLogMessage_textfield);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatlog_box;
        private System.Windows.Forms.TextBox ChatLogMessage_textfield;
        private System.Windows.Forms.Button SendMessage_botton;
        private System.Windows.Forms.Button CloseChatLog_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label characterNamed_label;
        private System.Windows.Forms.Timer chatlogscan_timer;
    }
}