namespace CurePlease
{
    partial class PartyBuffsForm
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
            this.ailment_list = new System.Windows.Forms.RichTextBox();
            this.label_p1 = new System.Windows.Forms.Label();
            this.update_effects = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ailment_list
            // 
            this.ailment_list.Location = new System.Drawing.Point(12, 25);
            this.ailment_list.Name = "ailment_list";
            this.ailment_list.Size = new System.Drawing.Size(454, 239);
            this.ailment_list.TabIndex = 1;
            this.ailment_list.Text = "";
            // 
            // label_p1
            // 
            this.label_p1.AutoSize = true;
            this.label_p1.Location = new System.Drawing.Point(123, 7);
            this.label_p1.Name = "label_p1";
            this.label_p1.Size = new System.Drawing.Size(204, 13);
            this.label_p1.TabIndex = 6;
            this.label_p1.Text = "CURRENT ACTIVE STATUS AILMENTS";
            // 
            // update_effects
            // 
            this.update_effects.Enabled = true;
            this.update_effects.Interval = 1000;
            this.update_effects.Tick += new System.EventHandler(this.update_effects_Tick);
            // 
            // PartyBuffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 277);
            this.Controls.Add(this.label_p1);
            this.Controls.Add(this.ailment_list);
            this.Name = "PartyBuffs";
            this.Text = "PartyBuffs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ailment_list;
        private System.Windows.Forms.Label label_p1;
        private System.Windows.Forms.Timer update_effects;
    }
}