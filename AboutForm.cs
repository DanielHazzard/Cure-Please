namespace CurePlease
{
    using System.Windows.Forms;

    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.InitializeComponent();

            this.label2.Text = Application.ProductVersion;
        }

        #region "== Form About"

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/atom0s/Cure-Please");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ext.elitemmonetwork.com/downloads/eliteapi/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ext.elitemmonetwork.com/downloads/elitemmo_api/");
        }
    }

    #endregion "== Form About"
}
