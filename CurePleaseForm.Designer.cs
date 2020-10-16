using System.Windows.Forms;

namespace CurePlease
{
    partial class CurePleaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurePleaseForm));
            this.player0optionsButton = new System.Windows.Forms.Button();
            this.party0 = new System.Windows.Forms.GroupBox();
            this.player5HP = new CurePlease.NewProgressBar();
            this.player4HP = new CurePlease.NewProgressBar();
            this.player3HP = new CurePlease.NewProgressBar();
            this.player1HP = new CurePlease.NewProgressBar();
            this.player2HP = new CurePlease.NewProgressBar();
            this.player0HP = new CurePlease.NewProgressBar();
            this.player5buffsButton = new System.Windows.Forms.Button();
            this.player4buffsButton = new System.Windows.Forms.Button();
            this.player3buffsButton = new System.Windows.Forms.Button();
            this.player2buffsButton = new System.Windows.Forms.Button();
            this.player1buffsButton = new System.Windows.Forms.Button();
            this.player0buffsButton = new System.Windows.Forms.Button();
            this.player5optionsButton = new System.Windows.Forms.Button();
            this.player4optionsButton = new System.Windows.Forms.Button();
            this.player3optionsButton = new System.Windows.Forms.Button();
            this.player2optionsButton = new System.Windows.Forms.Button();
            this.player1optionsButton = new System.Windows.Forms.Button();
            this.player5priority = new System.Windows.Forms.CheckBox();
            this.player5enabled = new System.Windows.Forms.CheckBox();
            this.player4priority = new System.Windows.Forms.CheckBox();
            this.player4enabled = new System.Windows.Forms.CheckBox();
            this.player3priority = new System.Windows.Forms.CheckBox();
            this.player3enabled = new System.Windows.Forms.CheckBox();
            this.player2priority = new System.Windows.Forms.CheckBox();
            this.player2enabled = new System.Windows.Forms.CheckBox();
            this.player1priority = new System.Windows.Forms.CheckBox();
            this.player1enabled = new System.Windows.Forms.CheckBox();
            this.player0priority = new System.Windows.Forms.CheckBox();
            this.player0enabled = new System.Windows.Forms.CheckBox();
            this.player5 = new System.Windows.Forms.Label();
            this.player4 = new System.Windows.Forms.Label();
            this.player3 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player0 = new System.Windows.Forms.Label();
            this.playerOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.followToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopfollowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EntrustTargetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoTargetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DevotionTargetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HateEstablisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.autoHasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoHasteIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoAdloquiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoFlurryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoFlurryIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoProtectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.enableDebuffRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeperator13 = new System.Windows.Forms.ToolStripSeparator();
            this.stormspellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sneakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phalanxIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.regenIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regenIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regenIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacrificeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.blindnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paralynaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poisonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.protectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protectIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protectVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoShellIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoShellVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoProtectIVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoProtectVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setinstance = new System.Windows.Forms.Button();
            this.POLID = new System.Windows.Forms.ComboBox();
            this.plLabel = new System.Windows.Forms.Label();
            this.party2 = new System.Windows.Forms.GroupBox();
            this.player17HP = new CurePlease.NewProgressBar();
            this.player17optionsButton = new System.Windows.Forms.Button();
            this.player16HP = new CurePlease.NewProgressBar();
            this.player17priority = new System.Windows.Forms.CheckBox();
            this.player15HP = new CurePlease.NewProgressBar();
            this.player17enabled = new System.Windows.Forms.CheckBox();
            this.player13HP = new CurePlease.NewProgressBar();
            this.player16optionsButton = new System.Windows.Forms.Button();
            this.player14HP = new CurePlease.NewProgressBar();
            this.player16priority = new System.Windows.Forms.CheckBox();
            this.player12HP = new CurePlease.NewProgressBar();
            this.player16enabled = new System.Windows.Forms.CheckBox();
            this.player15optionsButton = new System.Windows.Forms.Button();
            this.player15priority = new System.Windows.Forms.CheckBox();
            this.player15enabled = new System.Windows.Forms.CheckBox();
            this.player14optionsButton = new System.Windows.Forms.Button();
            this.player14priority = new System.Windows.Forms.CheckBox();
            this.player14enabled = new System.Windows.Forms.CheckBox();
            this.player13optionsButton = new System.Windows.Forms.Button();
            this.player13priority = new System.Windows.Forms.CheckBox();
            this.player12optionsButton = new System.Windows.Forms.Button();
            this.player13enabled = new System.Windows.Forms.CheckBox();
            this.player12priority = new System.Windows.Forms.CheckBox();
            this.player12enabled = new System.Windows.Forms.CheckBox();
            this.player17 = new System.Windows.Forms.Label();
            this.player16 = new System.Windows.Forms.Label();
            this.player15 = new System.Windows.Forms.Label();
            this.player14 = new System.Windows.Forms.Label();
            this.player13 = new System.Windows.Forms.Label();
            this.player12 = new System.Windows.Forms.Label();
            this.partyMembersUpdate = new System.Windows.Forms.Timer(this.components);
            this.actionTimer = new System.Windows.Forms.Timer(this.components);
            this.player6 = new System.Windows.Forms.Label();
            this.player7 = new System.Windows.Forms.Label();
            this.player8 = new System.Windows.Forms.Label();
            this.player9 = new System.Windows.Forms.Label();
            this.player10 = new System.Windows.Forms.Label();
            this.player11 = new System.Windows.Forms.Label();
            this.player6enabled = new System.Windows.Forms.CheckBox();
            this.player7enabled = new System.Windows.Forms.CheckBox();
            this.player8enabled = new System.Windows.Forms.CheckBox();
            this.player9enabled = new System.Windows.Forms.CheckBox();
            this.player10enabled = new System.Windows.Forms.CheckBox();
            this.player11enabled = new System.Windows.Forms.CheckBox();
            this.party1 = new System.Windows.Forms.GroupBox();
            this.player11HP = new CurePlease.NewProgressBar();
            this.player11optionsButton = new System.Windows.Forms.Button();
            this.player10HP = new CurePlease.NewProgressBar();
            this.player11priority = new System.Windows.Forms.CheckBox();
            this.player9HP = new CurePlease.NewProgressBar();
            this.player10optionsButton = new System.Windows.Forms.Button();
            this.player7HP = new CurePlease.NewProgressBar();
            this.player8HP = new CurePlease.NewProgressBar();
            this.player9optionsButton = new System.Windows.Forms.Button();
            this.player6HP = new CurePlease.NewProgressBar();
            this.player10priority = new System.Windows.Forms.CheckBox();
            this.player8optionsButton = new System.Windows.Forms.Button();
            this.player7optionsButton = new System.Windows.Forms.Button();
            this.player9priority = new System.Windows.Forms.CheckBox();
            this.player6optionsButton = new System.Windows.Forms.Button();
            this.player8priority = new System.Windows.Forms.CheckBox();
            this.player7priority = new System.Windows.Forms.CheckBox();
            this.player6priority = new System.Windows.Forms.CheckBox();
            this.POLID2 = new System.Windows.Forms.ComboBox();
            this.setinstance2 = new System.Windows.Forms.Button();
            this.monitoredLabel = new System.Windows.Forms.Label();
            this.hpUpdates = new System.Windows.Forms.Timer(this.components);
            this.plPosition = new System.Windows.Forms.Timer(this.components);
            this.pauseButton = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.autoOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoPhalanxIIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRegenVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRefreshIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SandstormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RainstormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindstormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirestormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AurorastormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VoidstormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThunderstormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HailstormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRegenIVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.charselect = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.debugging_MSGBOX = new System.Windows.Forms.Label();
            this.resetSongTimer = new System.Windows.Forms.Timer(this.components);
            this.checkSCHCharges = new System.Windows.Forms.Timer(this.components);
            this.AutomaticChecks = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debug = new System.Windows.Forms.Button();
            this.currentAction = new System.Windows.Forms.Label();
            this.updateInstances = new System.Windows.Forms.Timer(this.components);
            this.checkCustomActions = new System.Windows.Forms.Timer(this.components);
            this.castingLockLabel = new System.Windows.Forms.Label();
            this.Follow_BGW = new System.ComponentModel.BackgroundWorker();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.ChatLogButton = new System.Windows.Forms.Button();
            this.PartyBuffsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.AddonReader = new System.ComponentModel.BackgroundWorker();
            this.JobAbilityDelay = new System.ComponentModel.BackgroundWorker();
            this.FullCircle_Timer = new System.Windows.Forms.Timer(this.components);
            this.AddOnStatus = new System.Windows.Forms.Button();
            this.ProtectCasting = new System.ComponentModel.BackgroundWorker();
            this.JobAbility_Delay = new System.ComponentModel.BackgroundWorker();
            this.EclipticTimer = new System.Windows.Forms.Timer(this.components);
            this.CustomCommand_Tracker = new System.ComponentModel.BackgroundWorker();
            this.party0.SuspendLayout();
            this.playerOptions.SuspendLayout();
            this.party2.SuspendLayout();
            this.party1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.autoOptions.SuspendLayout();
            this.charselect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // player0optionsButton
            // 
            this.player0optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player0optionsButton.Enabled = false;
            this.player0optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player0optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player0optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player0optionsButton.Location = new System.Drawing.Point(121, 9);
            this.player0optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player0optionsButton.Name = "player0optionsButton";
            this.player0optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player0optionsButton.TabIndex = 3;
            this.player0optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player0optionsButton, "View spells/options for this player.");
            this.player0optionsButton.UseVisualStyleBackColor = false;
            this.player0optionsButton.Click += new System.EventHandler(this.player0optionsButton_Click);
            this.player0optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // party0
            // 
            this.party0.BackColor = System.Drawing.Color.Transparent;
            this.party0.Controls.Add(this.player5HP);
            this.party0.Controls.Add(this.player4HP);
            this.party0.Controls.Add(this.player3HP);
            this.party0.Controls.Add(this.player1HP);
            this.party0.Controls.Add(this.player2HP);
            this.party0.Controls.Add(this.player0HP);
            this.party0.Controls.Add(this.player5buffsButton);
            this.party0.Controls.Add(this.player4buffsButton);
            this.party0.Controls.Add(this.player3buffsButton);
            this.party0.Controls.Add(this.player2buffsButton);
            this.party0.Controls.Add(this.player1buffsButton);
            this.party0.Controls.Add(this.player0buffsButton);
            this.party0.Controls.Add(this.player5optionsButton);
            this.party0.Controls.Add(this.player4optionsButton);
            this.party0.Controls.Add(this.player3optionsButton);
            this.party0.Controls.Add(this.player2optionsButton);
            this.party0.Controls.Add(this.player1optionsButton);
            this.party0.Controls.Add(this.player0optionsButton);
            this.party0.Controls.Add(this.player5priority);
            this.party0.Controls.Add(this.player5enabled);
            this.party0.Controls.Add(this.player4priority);
            this.party0.Controls.Add(this.player4enabled);
            this.party0.Controls.Add(this.player3priority);
            this.party0.Controls.Add(this.player3enabled);
            this.party0.Controls.Add(this.player2priority);
            this.party0.Controls.Add(this.player2enabled);
            this.party0.Controls.Add(this.player1priority);
            this.party0.Controls.Add(this.player1enabled);
            this.party0.Controls.Add(this.player0priority);
            this.party0.Controls.Add(this.player0enabled);
            this.party0.Controls.Add(this.player5);
            this.party0.Controls.Add(this.player4);
            this.party0.Controls.Add(this.player3);
            this.party0.Controls.Add(this.player2);
            this.party0.Controls.Add(this.player1);
            this.party0.Controls.Add(this.player0);
            this.party0.ForeColor = System.Drawing.SystemColors.GrayText;
            this.party0.Location = new System.Drawing.Point(19, 104);
            this.party0.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.party0.Name = "party0";
            this.party0.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.party0.Size = new System.Drawing.Size(230, 226);
            this.party0.TabIndex = 0;
            this.party0.TabStop = false;
            this.party0.Text = " Party 1 ";
            this.party0.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorderlessGroupBox);
            // 
            // player5HP
            // 
            this.player5HP.Location = new System.Drawing.Point(7, 208);
            this.player5HP.Name = "player5HP";
            this.player5HP.Size = new System.Drawing.Size(219, 12);
            this.player5HP.TabIndex = 39;
            // 
            // player4HP
            // 
            this.player4HP.Location = new System.Drawing.Point(7, 173);
            this.player4HP.Name = "player4HP";
            this.player4HP.Size = new System.Drawing.Size(219, 12);
            this.player4HP.TabIndex = 38;
            // 
            // player3HP
            // 
            this.player3HP.Location = new System.Drawing.Point(7, 136);
            this.player3HP.Name = "player3HP";
            this.player3HP.Size = new System.Drawing.Size(219, 12);
            this.player3HP.TabIndex = 37;
            // 
            // player1HP
            // 
            this.player1HP.Location = new System.Drawing.Point(7, 65);
            this.player1HP.Name = "player1HP";
            this.player1HP.Size = new System.Drawing.Size(219, 12);
            this.player1HP.TabIndex = 36;
            // 
            // player2HP
            // 
            this.player2HP.Location = new System.Drawing.Point(7, 101);
            this.player2HP.Name = "player2HP";
            this.player2HP.Size = new System.Drawing.Size(219, 12);
            this.player2HP.TabIndex = 35;
            // 
            // player0HP
            // 
            this.player0HP.Location = new System.Drawing.Point(7, 30);
            this.player0HP.Name = "player0HP";
            this.player0HP.Size = new System.Drawing.Size(219, 12);
            this.player0HP.TabIndex = 28;
            // 
            // player5buffsButton
            // 
            this.player5buffsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player5buffsButton.Enabled = false;
            this.player5buffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player5buffsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player5buffsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player5buffsButton.Location = new System.Drawing.Point(177, 187);
            this.player5buffsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player5buffsButton.Name = "player5buffsButton";
            this.player5buffsButton.Size = new System.Drawing.Size(49, 19);
            this.player5buffsButton.TabIndex = 34;
            this.player5buffsButton.Text = "AUTO";
            this.toolTips.SetToolTip(this.player5buffsButton, "Auto Casting Party Spells for this Player");
            this.player5buffsButton.UseVisualStyleBackColor = false;
            this.player5buffsButton.Click += new System.EventHandler(this.player5buffsButton_Click);
            this.player5buffsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player4buffsButton
            // 
            this.player4buffsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player4buffsButton.Enabled = false;
            this.player4buffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player4buffsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4buffsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player4buffsButton.Location = new System.Drawing.Point(177, 151);
            this.player4buffsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player4buffsButton.Name = "player4buffsButton";
            this.player4buffsButton.Size = new System.Drawing.Size(49, 19);
            this.player4buffsButton.TabIndex = 33;
            this.player4buffsButton.Text = "AUTO";
            this.toolTips.SetToolTip(this.player4buffsButton, "Auto Casting Party Spells for this Player");
            this.player4buffsButton.UseVisualStyleBackColor = false;
            this.player4buffsButton.Click += new System.EventHandler(this.player4buffsButton_Click);
            this.player4buffsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player3buffsButton
            // 
            this.player3buffsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player3buffsButton.Enabled = false;
            this.player3buffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player3buffsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3buffsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player3buffsButton.Location = new System.Drawing.Point(177, 115);
            this.player3buffsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player3buffsButton.Name = "player3buffsButton";
            this.player3buffsButton.Size = new System.Drawing.Size(49, 19);
            this.player3buffsButton.TabIndex = 32;
            this.player3buffsButton.Text = "AUTO";
            this.toolTips.SetToolTip(this.player3buffsButton, "Auto Casting Party Spells for this Player");
            this.player3buffsButton.UseVisualStyleBackColor = false;
            this.player3buffsButton.Click += new System.EventHandler(this.player3buffsButton_Click);
            this.player3buffsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player2buffsButton
            // 
            this.player2buffsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player2buffsButton.Enabled = false;
            this.player2buffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player2buffsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2buffsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player2buffsButton.Location = new System.Drawing.Point(177, 79);
            this.player2buffsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player2buffsButton.Name = "player2buffsButton";
            this.player2buffsButton.Size = new System.Drawing.Size(49, 19);
            this.player2buffsButton.TabIndex = 31;
            this.player2buffsButton.Text = "AUTO";
            this.toolTips.SetToolTip(this.player2buffsButton, "Auto Casting Party Spells for this Player");
            this.player2buffsButton.UseVisualStyleBackColor = false;
            this.player2buffsButton.Click += new System.EventHandler(this.player2buffsButton_Click);
            this.player2buffsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player1buffsButton
            // 
            this.player1buffsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player1buffsButton.Enabled = false;
            this.player1buffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player1buffsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1buffsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player1buffsButton.Location = new System.Drawing.Point(178, 44);
            this.player1buffsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player1buffsButton.Name = "player1buffsButton";
            this.player1buffsButton.Size = new System.Drawing.Size(49, 19);
            this.player1buffsButton.TabIndex = 30;
            this.player1buffsButton.Text = "AUTO";
            this.toolTips.SetToolTip(this.player1buffsButton, "Auto Casting Party Spells for this Player");
            this.player1buffsButton.UseVisualStyleBackColor = false;
            this.player1buffsButton.Click += new System.EventHandler(this.player1buffsButton_Click);
            this.player1buffsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player0buffsButton
            // 
            this.player0buffsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player0buffsButton.Enabled = false;
            this.player0buffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player0buffsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player0buffsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player0buffsButton.Location = new System.Drawing.Point(178, 9);
            this.player0buffsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player0buffsButton.Name = "player0buffsButton";
            this.player0buffsButton.Size = new System.Drawing.Size(49, 19);
            this.player0buffsButton.TabIndex = 29;
            this.player0buffsButton.Text = "AUTO";
            this.toolTips.SetToolTip(this.player0buffsButton, "Auto Casting Party Spells for this Player");
            this.player0buffsButton.UseVisualStyleBackColor = false;
            this.player0buffsButton.Click += new System.EventHandler(this.player0buffsButton_Click);
            this.player0buffsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player5optionsButton
            // 
            this.player5optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player5optionsButton.Enabled = false;
            this.player5optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player5optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player5optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player5optionsButton.Location = new System.Drawing.Point(120, 187);
            this.player5optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player5optionsButton.Name = "player5optionsButton";
            this.player5optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player5optionsButton.TabIndex = 3;
            this.player5optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player5optionsButton, "View spells/options for this player.");
            this.player5optionsButton.UseVisualStyleBackColor = false;
            this.player5optionsButton.Click += new System.EventHandler(this.player5optionsButton_Click);
            this.player5optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player4optionsButton
            // 
            this.player4optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player4optionsButton.Enabled = false;
            this.player4optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player4optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player4optionsButton.Location = new System.Drawing.Point(120, 151);
            this.player4optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player4optionsButton.Name = "player4optionsButton";
            this.player4optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player4optionsButton.TabIndex = 3;
            this.player4optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player4optionsButton, "View spells/options for this player.");
            this.player4optionsButton.UseVisualStyleBackColor = false;
            this.player4optionsButton.Click += new System.EventHandler(this.player4optionsButton_Click);
            this.player4optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player3optionsButton
            // 
            this.player3optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player3optionsButton.Enabled = false;
            this.player3optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player3optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player3optionsButton.Location = new System.Drawing.Point(120, 115);
            this.player3optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player3optionsButton.Name = "player3optionsButton";
            this.player3optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player3optionsButton.TabIndex = 3;
            this.player3optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player3optionsButton, "View spells/options for this player.");
            this.player3optionsButton.UseVisualStyleBackColor = false;
            this.player3optionsButton.Click += new System.EventHandler(this.player3optionsButton_Click);
            this.player3optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player2optionsButton
            // 
            this.player2optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player2optionsButton.Enabled = false;
            this.player2optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player2optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player2optionsButton.Location = new System.Drawing.Point(120, 79);
            this.player2optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player2optionsButton.Name = "player2optionsButton";
            this.player2optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player2optionsButton.TabIndex = 3;
            this.player2optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player2optionsButton, "View spells/options for this player.");
            this.player2optionsButton.UseVisualStyleBackColor = false;
            this.player2optionsButton.Click += new System.EventHandler(this.player2optionsButton_Click);
            this.player2optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player1optionsButton
            // 
            this.player1optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player1optionsButton.Enabled = false;
            this.player1optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player1optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player1optionsButton.Location = new System.Drawing.Point(121, 44);
            this.player1optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player1optionsButton.Name = "player1optionsButton";
            this.player1optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player1optionsButton.TabIndex = 3;
            this.player1optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player1optionsButton, "View spells/options for this player.");
            this.player1optionsButton.UseVisualStyleBackColor = false;
            this.player1optionsButton.Click += new System.EventHandler(this.player1optionsButton_Click);
            this.player1optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player5priority
            // 
            this.player5priority.AutoSize = true;
            this.player5priority.Location = new System.Drawing.Point(29, 192);
            this.player5priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player5priority.Name = "player5priority";
            this.player5priority.Size = new System.Drawing.Size(15, 14);
            this.player5priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player5priority, "Check to Enable Player Priority");
            this.player5priority.UseVisualStyleBackColor = true;
            // 
            // player5enabled
            // 
            this.player5enabled.AutoSize = true;
            this.player5enabled.Checked = true;
            this.player5enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player5enabled.Location = new System.Drawing.Point(7, 192);
            this.player5enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player5enabled.Name = "player5enabled";
            this.player5enabled.Size = new System.Drawing.Size(15, 14);
            this.player5enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player5enabled, "Check to enable actions on this player.");
            this.player5enabled.UseVisualStyleBackColor = true;
            // 
            // player4priority
            // 
            this.player4priority.AutoSize = true;
            this.player4priority.Location = new System.Drawing.Point(29, 156);
            this.player4priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player4priority.Name = "player4priority";
            this.player4priority.Size = new System.Drawing.Size(15, 14);
            this.player4priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player4priority, "Check to Enable Player Priority");
            this.player4priority.UseVisualStyleBackColor = true;
            // 
            // player4enabled
            // 
            this.player4enabled.AutoSize = true;
            this.player4enabled.Checked = true;
            this.player4enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player4enabled.Location = new System.Drawing.Point(7, 156);
            this.player4enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player4enabled.Name = "player4enabled";
            this.player4enabled.Size = new System.Drawing.Size(15, 14);
            this.player4enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player4enabled, "Check to enable actions on this player.");
            this.player4enabled.UseVisualStyleBackColor = true;
            // 
            // player3priority
            // 
            this.player3priority.AutoSize = true;
            this.player3priority.Location = new System.Drawing.Point(29, 120);
            this.player3priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player3priority.Name = "player3priority";
            this.player3priority.Size = new System.Drawing.Size(15, 14);
            this.player3priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player3priority, "Check to Enable Player Priority");
            this.player3priority.UseVisualStyleBackColor = true;
            // 
            // player3enabled
            // 
            this.player3enabled.AutoSize = true;
            this.player3enabled.Checked = true;
            this.player3enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player3enabled.Location = new System.Drawing.Point(7, 120);
            this.player3enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player3enabled.Name = "player3enabled";
            this.player3enabled.Size = new System.Drawing.Size(15, 14);
            this.player3enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player3enabled, "Check to enable actions on this player.");
            this.player3enabled.UseVisualStyleBackColor = true;
            // 
            // player2priority
            // 
            this.player2priority.AutoSize = true;
            this.player2priority.Location = new System.Drawing.Point(29, 84);
            this.player2priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player2priority.Name = "player2priority";
            this.player2priority.Size = new System.Drawing.Size(15, 14);
            this.player2priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player2priority, "Check to Enable Player Priority");
            this.player2priority.UseVisualStyleBackColor = true;
            // 
            // player2enabled
            // 
            this.player2enabled.AutoSize = true;
            this.player2enabled.Checked = true;
            this.player2enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player2enabled.Location = new System.Drawing.Point(7, 84);
            this.player2enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player2enabled.Name = "player2enabled";
            this.player2enabled.Size = new System.Drawing.Size(15, 14);
            this.player2enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player2enabled, "Check to enable actions on this player.");
            this.player2enabled.UseVisualStyleBackColor = true;
            // 
            // player1priority
            // 
            this.player1priority.AutoSize = true;
            this.player1priority.Location = new System.Drawing.Point(29, 49);
            this.player1priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player1priority.Name = "player1priority";
            this.player1priority.Size = new System.Drawing.Size(15, 14);
            this.player1priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player1priority, "Check to Enable Player Priority");
            this.player1priority.UseVisualStyleBackColor = true;
            // 
            // player1enabled
            // 
            this.player1enabled.AutoSize = true;
            this.player1enabled.Checked = true;
            this.player1enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player1enabled.Location = new System.Drawing.Point(7, 49);
            this.player1enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player1enabled.Name = "player1enabled";
            this.player1enabled.Size = new System.Drawing.Size(15, 14);
            this.player1enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player1enabled, "Check to enable actions on this player.");
            this.player1enabled.UseVisualStyleBackColor = true;
            // 
            // player0priority
            // 
            this.player0priority.AutoSize = true;
            this.player0priority.Location = new System.Drawing.Point(29, 14);
            this.player0priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player0priority.Name = "player0priority";
            this.player0priority.Size = new System.Drawing.Size(15, 14);
            this.player0priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player0priority, "Check to Enable Player Priority");
            this.player0priority.UseVisualStyleBackColor = true;
            // 
            // player0enabled
            // 
            this.player0enabled.AutoSize = true;
            this.player0enabled.Checked = true;
            this.player0enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player0enabled.Location = new System.Drawing.Point(7, 14);
            this.player0enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player0enabled.Name = "player0enabled";
            this.player0enabled.Size = new System.Drawing.Size(15, 14);
            this.player0enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player0enabled, "Check to enable actions on this player.");
            this.player0enabled.UseVisualStyleBackColor = true;
            // 
            // player5
            // 
            this.player5.AutoSize = true;
            this.player5.Enabled = false;
            this.player5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player5.Location = new System.Drawing.Point(46, 192);
            this.player5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(45, 13);
            this.player5.TabIndex = 1;
            this.player5.Text = "Inactive";
            // 
            // player4
            // 
            this.player4.AutoSize = true;
            this.player4.Enabled = false;
            this.player4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player4.Location = new System.Drawing.Point(46, 156);
            this.player4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(45, 13);
            this.player4.TabIndex = 1;
            this.player4.Text = "Inactive";
            // 
            // player3
            // 
            this.player3.AutoSize = true;
            this.player3.Enabled = false;
            this.player3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player3.Location = new System.Drawing.Point(46, 120);
            this.player3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(45, 13);
            this.player3.TabIndex = 1;
            this.player3.Text = "Inactive";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Enabled = false;
            this.player2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player2.Location = new System.Drawing.Point(46, 84);
            this.player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(45, 13);
            this.player2.TabIndex = 1;
            this.player2.Text = "Inactive";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Enabled = false;
            this.player1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player1.Location = new System.Drawing.Point(46, 49);
            this.player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(45, 13);
            this.player1.TabIndex = 1;
            this.player1.Text = "Inactive";
            // 
            // player0
            // 
            this.player0.AutoSize = true;
            this.player0.Enabled = false;
            this.player0.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player0.Location = new System.Drawing.Point(46, 14);
            this.player0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player0.Name = "player0";
            this.player0.Size = new System.Drawing.Size(45, 13);
            this.player0.TabIndex = 1;
            this.player0.Text = "Inactive";
            // 
            // playerOptions
            // 
            this.playerOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followToolStripMenuItem,
            this.stopfollowToolStripMenuItem,
            this.toolStripSeparator2,
            this.EntrustTargetToolStripMenuItem,
            this.GeoTargetToolStripMenuItem,
            this.DevotionTargetToolStripMenuItem,
            this.HateEstablisherToolStripMenuItem,
            this.toolStripSeparator7,
            this.autoHasteToolStripMenuItem,
            this.autoHasteIIToolStripMenuItem,
            this.autoAdloquiumToolStripMenuItem,
            this.autoFlurryToolStripMenuItem,
            this.autoFlurryIIToolStripMenuItem,
            this.autoShellToolStripMenuItem,
            this.autoProtectToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem1,
            this.enableDebuffRemovalToolStripMenuItem,
            this.toolStripSeperator13});
            this.playerOptions.Name = "player0rightclick";
            this.playerOptions.Size = new System.Drawing.Size(226, 342);
            // 
            // followToolStripMenuItem
            // 
            this.followToolStripMenuItem.Name = "followToolStripMenuItem";
            this.followToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.followToolStripMenuItem.Text = "/follow";
            this.followToolStripMenuItem.Click += new System.EventHandler(this.followToolStripMenuItem_Click);
            // 
            // stopfollowToolStripMenuItem
            // 
            this.stopfollowToolStripMenuItem.Name = "stopfollowToolStripMenuItem";
            this.stopfollowToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.stopfollowToolStripMenuItem.Text = "Cancel /follow";
            this.stopfollowToolStripMenuItem.Click += new System.EventHandler(this.stopfollowToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // EntrustTargetToolStripMenuItem
            // 
            this.EntrustTargetToolStripMenuItem.Name = "EntrustTargetToolStripMenuItem";
            this.EntrustTargetToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.EntrustTargetToolStripMenuItem.Text = "Make Entrusted Target";
            this.EntrustTargetToolStripMenuItem.Click += new System.EventHandler(this.EntrustTargetToolStripMenuItem_Click);
            // 
            // GeoTargetToolStripMenuItem
            // 
            this.GeoTargetToolStripMenuItem.Name = "GeoTargetToolStripMenuItem";
            this.GeoTargetToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.GeoTargetToolStripMenuItem.Text = "Make GEO-Spell Target";
            this.GeoTargetToolStripMenuItem.Click += new System.EventHandler(this.GeoTargetToolStripMenuItem_Click);
            // 
            // DevotionTargetToolStripMenuItem
            // 
            this.DevotionTargetToolStripMenuItem.Name = "DevotionTargetToolStripMenuItem";
            this.DevotionTargetToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.DevotionTargetToolStripMenuItem.Text = "Make Devotion Target";
            this.DevotionTargetToolStripMenuItem.Click += new System.EventHandler(this.DevotionTargetToolStripMenuItem_Click);
            // 
            // HateEstablisherToolStripMenuItem
            // 
            this.HateEstablisherToolStripMenuItem.Name = "HateEstablisherToolStripMenuItem";
            this.HateEstablisherToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.HateEstablisherToolStripMenuItem.Text = "Make Hate Establisher Target";
            this.HateEstablisherToolStripMenuItem.Click += new System.EventHandler(this.HateEstablisherToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(222, 6);
            // 
            // autoHasteToolStripMenuItem
            // 
            this.autoHasteToolStripMenuItem.Name = "autoHasteToolStripMenuItem";
            this.autoHasteToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.autoHasteToolStripMenuItem.Text = "Auto Haste";
            this.autoHasteToolStripMenuItem.ToolTipText = "Auto Haste (Default 3 minutes)";
            this.autoHasteToolStripMenuItem.Click += new System.EventHandler(this.autoHasteToolStripMenuItem_Click);
            // 
            // autoHasteIIToolStripMenuItem
            // 
            this.autoHasteIIToolStripMenuItem.Name = "autoHasteIIToolStripMenuItem";
            this.autoHasteIIToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.autoHasteIIToolStripMenuItem.Text = "Auto Haste II";
            this.autoHasteIIToolStripMenuItem.ToolTipText = "Auto Haste II (Default 3 minutes)";
            this.autoHasteIIToolStripMenuItem.Click += new System.EventHandler(this.autoHasteIIToolStripMenuItem_Click);
            // 
            // autoAdloquiumToolStripMenuItem
            // 
            this.autoAdloquiumToolStripMenuItem.Name = "autoAdloquiumToolStripMenuItem";
            this.autoAdloquiumToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.autoAdloquiumToolStripMenuItem.Text = "Auto Adloquium";
            this.autoAdloquiumToolStripMenuItem.ToolTipText = "Auto Adloquium (Default 3 minutes)";
            this.autoAdloquiumToolStripMenuItem.Click += new System.EventHandler(this.autoAdloquiumToolStripMenuItem_Click);
            // 
            // autoFlurryToolStripMenuItem
            // 
            this.autoFlurryToolStripMenuItem.Name = "autoFlurryToolStripMenuItem";
            this.autoFlurryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.autoFlurryToolStripMenuItem.Text = "Auto Flurry";
            this.autoFlurryToolStripMenuItem.ToolTipText = "Auto Flurry (Default 3 minutes)";
            this.autoFlurryToolStripMenuItem.Click += new System.EventHandler(this.autoFlurryToolStripMenuItem_Click);
            // 
            // autoFlurryIIToolStripMenuItem
            // 
            this.autoFlurryIIToolStripMenuItem.Name = "autoFlurryIIToolStripMenuItem";
            this.autoFlurryIIToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.autoFlurryIIToolStripMenuItem.Text = "Auto Flurry II";
            this.autoFlurryIIToolStripMenuItem.ToolTipText = "Auto Flurry II (Default 3 minutes)";
            this.autoFlurryIIToolStripMenuItem.Click += new System.EventHandler(this.autoFlurryIIToolStripMenuItem_Click);
            // 
            // autoShellToolStripMenuItem
            // 
            this.autoShellToolStripMenuItem.Name = "autoShellToolStripMenuItem";
            this.autoShellToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.autoShellToolStripMenuItem.Text = "Auto Shell";
            this.autoShellToolStripMenuItem.Click += new System.EventHandler(this.autoShellToolStripMenuItem_Click);
            // 
            // autoProtectToolStripMenuItem
            // 
            this.autoProtectToolStripMenuItem.Name = "autoProtectToolStripMenuItem";
            this.autoProtectToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.autoProtectToolStripMenuItem.Text = "Auto Protect";
            this.autoProtectToolStripMenuItem.Click += new System.EventHandler(this.autoProtectToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // enableDebuffRemovalToolStripMenuItem
            // 
            this.enableDebuffRemovalToolStripMenuItem.Name = "enableDebuffRemovalToolStripMenuItem";
            this.enableDebuffRemovalToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.enableDebuffRemovalToolStripMenuItem.Text = "Enable Debuff Removal";
            this.enableDebuffRemovalToolStripMenuItem.Click += new System.EventHandler(this.enableDebuffRemovalToolStripMenuItem_Click);
            // 
            // toolStripSeperator13
            // 
            this.toolStripSeperator13.Name = "toolStripSeperator13";
            this.toolStripSeperator13.Size = new System.Drawing.Size(222, 6);
            // 
            // stormspellToolStripMenuItem
            // 
            this.stormspellToolStripMenuItem.Name = "stormspellToolStripMenuItem";
            this.stormspellToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.stormspellToolStripMenuItem.Text = "Auto Stormspell";
            // 
            // hasteToolStripMenuItem
            // 
            this.hasteToolStripMenuItem.Name = "hasteToolStripMenuItem";
            this.hasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sneakToolStripMenuItem
            // 
            this.sneakToolStripMenuItem.Name = "sneakToolStripMenuItem";
            this.sneakToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // invisibleToolStripMenuItem
            // 
            this.invisibleToolStripMenuItem.Name = "invisibleToolStripMenuItem";
            this.invisibleToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // refreshIIToolStripMenuItem
            // 
            this.refreshIIToolStripMenuItem.Name = "refreshIIToolStripMenuItem";
            this.refreshIIToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // refreshIIIToolStripMenuItem
            // 
            this.refreshIIIToolStripMenuItem.Name = "refreshIIIToolStripMenuItem";
            this.refreshIIIToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // phalanxIIToolStripMenuItem
            // 
            this.phalanxIIToolStripMenuItem.Name = "phalanxIIToolStripMenuItem";
            this.phalanxIIToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(6, 6);
            // 
            // regenIIToolStripMenuItem
            // 
            this.regenIIToolStripMenuItem.Name = "regenIIToolStripMenuItem";
            this.regenIIToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // regenIIIToolStripMenuItem
            // 
            this.regenIIIToolStripMenuItem.Name = "regenIIIToolStripMenuItem";
            this.regenIIIToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // regenIVToolStripMenuItem
            // 
            this.regenIVToolStripMenuItem.Name = "regenIVToolStripMenuItem";
            this.regenIVToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(6, 6);
            // 
            // eraseToolStripMenuItem
            // 
            this.eraseToolStripMenuItem.Name = "eraseToolStripMenuItem";
            this.eraseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sacrificeToolStripMenuItem
            // 
            this.sacrificeToolStripMenuItem.Name = "sacrificeToolStripMenuItem";
            this.sacrificeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(6, 6);
            // 
            // blindnaToolStripMenuItem
            // 
            this.blindnaToolStripMenuItem.Name = "blindnaToolStripMenuItem";
            this.blindnaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // cursnaToolStripMenuItem
            // 
            this.cursnaToolStripMenuItem.Name = "cursnaToolStripMenuItem";
            this.cursnaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // paralynaToolStripMenuItem
            // 
            this.paralynaToolStripMenuItem.Name = "paralynaToolStripMenuItem";
            this.paralynaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // poisonaToolStripMenuItem
            // 
            this.poisonaToolStripMenuItem.Name = "poisonaToolStripMenuItem";
            this.poisonaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // stonaToolStripMenuItem
            // 
            this.stonaToolStripMenuItem.Name = "stonaToolStripMenuItem";
            this.stonaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // silenaToolStripMenuItem
            // 
            this.silenaToolStripMenuItem.Name = "silenaToolStripMenuItem";
            this.silenaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // virunaToolStripMenuItem
            // 
            this.virunaToolStripMenuItem.Name = "virunaToolStripMenuItem";
            this.virunaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // protectToolStripMenuItem
            // 
            this.protectToolStripMenuItem.Name = "protectToolStripMenuItem";
            this.protectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // protectIVToolStripMenuItem
            // 
            this.protectIVToolStripMenuItem.Name = "protectIVToolStripMenuItem";
            this.protectIVToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // protectVToolStripMenuItem
            // 
            this.protectVToolStripMenuItem.Name = "protectVToolStripMenuItem";
            this.protectVToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // shellToolStripMenuItem
            // 
            this.shellToolStripMenuItem.Name = "shellToolStripMenuItem";
            this.shellToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // shellIVToolStripMenuItem
            // 
            this.shellIVToolStripMenuItem.Name = "shellIVToolStripMenuItem";
            this.shellIVToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // shellVToolStripMenuItem
            // 
            this.shellVToolStripMenuItem.Name = "shellVToolStripMenuItem";
            this.shellVToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // autoShellIVToolStripMenuItem
            // 
            this.autoShellIVToolStripMenuItem.Name = "autoShellIVToolStripMenuItem";
            this.autoShellIVToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // autoShellVToolStripMenuItem
            // 
            this.autoShellVToolStripMenuItem.Name = "autoShellVToolStripMenuItem";
            this.autoShellVToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // autoProtectIVToolStripMenuItem1
            // 
            this.autoProtectIVToolStripMenuItem1.Name = "autoProtectIVToolStripMenuItem1";
            this.autoProtectIVToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // autoProtectVToolStripMenuItem1
            // 
            this.autoProtectVToolStripMenuItem1.Name = "autoProtectVToolStripMenuItem1";
            this.autoProtectVToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // setinstance
            // 
            this.setinstance.BackColor = System.Drawing.SystemColors.Menu;
            this.setinstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setinstance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.setinstance.Location = new System.Drawing.Point(299, 10);
            this.setinstance.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.setinstance.Name = "setinstance";
            this.setinstance.Size = new System.Drawing.Size(74, 22);
            this.setinstance.TabIndex = 4;
            this.setinstance.Text = "Select";
            this.toolTips.SetToolTip(this.setinstance, "Select Power Leveler");
            this.setinstance.UseVisualStyleBackColor = false;
            this.setinstance.Click += new System.EventHandler(this.setinstance_Click);
            this.setinstance.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // POLID
            // 
            this.POLID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.POLID.FormattingEnabled = true;
            this.POLID.Location = new System.Drawing.Point(178, 11);
            this.POLID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.POLID.Name = "POLID";
            this.POLID.Size = new System.Drawing.Size(117, 21);
            this.POLID.TabIndex = 3;
            // 
            // plLabel
            // 
            this.plLabel.AutoSize = true;
            this.plLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.plLabel.Location = new System.Drawing.Point(5, 16);
            this.plLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plLabel.Name = "plLabel";
            this.plLabel.Size = new System.Drawing.Size(119, 13);
            this.plLabel.TabIndex = 5;
            this.plLabel.Text = "Selected PL: NONE";
            // 
            // party2
            // 
            this.party2.BackColor = System.Drawing.Color.Transparent;
            this.party2.Controls.Add(this.player17HP);
            this.party2.Controls.Add(this.player17optionsButton);
            this.party2.Controls.Add(this.player16HP);
            this.party2.Controls.Add(this.player17priority);
            this.party2.Controls.Add(this.player15HP);
            this.party2.Controls.Add(this.player17enabled);
            this.party2.Controls.Add(this.player13HP);
            this.party2.Controls.Add(this.player16optionsButton);
            this.party2.Controls.Add(this.player14HP);
            this.party2.Controls.Add(this.player16priority);
            this.party2.Controls.Add(this.player12HP);
            this.party2.Controls.Add(this.player16enabled);
            this.party2.Controls.Add(this.player15optionsButton);
            this.party2.Controls.Add(this.player15priority);
            this.party2.Controls.Add(this.player15enabled);
            this.party2.Controls.Add(this.player14optionsButton);
            this.party2.Controls.Add(this.player14priority);
            this.party2.Controls.Add(this.player14enabled);
            this.party2.Controls.Add(this.player13optionsButton);
            this.party2.Controls.Add(this.player13priority);
            this.party2.Controls.Add(this.player12optionsButton);
            this.party2.Controls.Add(this.player13enabled);
            this.party2.Controls.Add(this.player12priority);
            this.party2.Controls.Add(this.player12enabled);
            this.party2.Controls.Add(this.player17);
            this.party2.Controls.Add(this.player16);
            this.party2.Controls.Add(this.player15);
            this.party2.Controls.Add(this.player14);
            this.party2.Controls.Add(this.player13);
            this.party2.Controls.Add(this.player12);
            this.party2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.party2.Location = new System.Drawing.Point(453, 104);
            this.party2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.party2.Name = "party2";
            this.party2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.party2.Size = new System.Drawing.Size(196, 226);
            this.party2.TabIndex = 6;
            this.party2.TabStop = false;
            this.party2.Text = " Party 3 ";
            this.party2.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorderlessGroupBox);
            // 
            // player17HP
            // 
            this.player17HP.Location = new System.Drawing.Point(5, 208);
            this.player17HP.Name = "player17HP";
            this.player17HP.Size = new System.Drawing.Size(187, 12);
            this.player17HP.TabIndex = 51;
            // 
            // player17optionsButton
            // 
            this.player17optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player17optionsButton.Enabled = false;
            this.player17optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player17optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player17optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player17optionsButton.Location = new System.Drawing.Point(137, 187);
            this.player17optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player17optionsButton.Name = "player17optionsButton";
            this.player17optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player17optionsButton.TabIndex = 3;
            this.player17optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player17optionsButton, "View spells/options for this player.");
            this.player17optionsButton.UseVisualStyleBackColor = false;
            this.player17optionsButton.Click += new System.EventHandler(this.player17optionsButton_Click);
            this.player17optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player16HP
            // 
            this.player16HP.Location = new System.Drawing.Point(5, 173);
            this.player16HP.Name = "player16HP";
            this.player16HP.Size = new System.Drawing.Size(187, 12);
            this.player16HP.TabIndex = 50;
            // 
            // player17priority
            // 
            this.player17priority.AutoSize = true;
            this.player17priority.Location = new System.Drawing.Point(29, 192);
            this.player17priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player17priority.Name = "player17priority";
            this.player17priority.Size = new System.Drawing.Size(15, 14);
            this.player17priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player17priority, "Check to Enable Player Priority");
            this.player17priority.UseVisualStyleBackColor = true;
            // 
            // player15HP
            // 
            this.player15HP.Location = new System.Drawing.Point(5, 136);
            this.player15HP.Name = "player15HP";
            this.player15HP.Size = new System.Drawing.Size(187, 12);
            this.player15HP.TabIndex = 49;
            // 
            // player17enabled
            // 
            this.player17enabled.AutoSize = true;
            this.player17enabled.Location = new System.Drawing.Point(7, 192);
            this.player17enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player17enabled.Name = "player17enabled";
            this.player17enabled.Size = new System.Drawing.Size(15, 14);
            this.player17enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player17enabled, "Check to enable actions on this player.");
            this.player17enabled.UseVisualStyleBackColor = true;
            // 
            // player13HP
            // 
            this.player13HP.Location = new System.Drawing.Point(5, 65);
            this.player13HP.Name = "player13HP";
            this.player13HP.Size = new System.Drawing.Size(187, 12);
            this.player13HP.TabIndex = 48;
            // 
            // player16optionsButton
            // 
            this.player16optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player16optionsButton.Enabled = false;
            this.player16optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player16optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player16optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player16optionsButton.Location = new System.Drawing.Point(137, 151);
            this.player16optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player16optionsButton.Name = "player16optionsButton";
            this.player16optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player16optionsButton.TabIndex = 3;
            this.player16optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player16optionsButton, "View spells/options for this player.");
            this.player16optionsButton.UseVisualStyleBackColor = false;
            this.player16optionsButton.Click += new System.EventHandler(this.player16optionsButton_Click);
            this.player16optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player14HP
            // 
            this.player14HP.Location = new System.Drawing.Point(5, 101);
            this.player14HP.Name = "player14HP";
            this.player14HP.Size = new System.Drawing.Size(187, 12);
            this.player14HP.TabIndex = 47;
            // 
            // player16priority
            // 
            this.player16priority.AutoSize = true;
            this.player16priority.Location = new System.Drawing.Point(29, 156);
            this.player16priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player16priority.Name = "player16priority";
            this.player16priority.Size = new System.Drawing.Size(15, 14);
            this.player16priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player16priority, "Check to Enable Player Priority");
            this.player16priority.UseVisualStyleBackColor = true;
            // 
            // player12HP
            // 
            this.player12HP.Location = new System.Drawing.Point(5, 30);
            this.player12HP.Name = "player12HP";
            this.player12HP.Size = new System.Drawing.Size(187, 12);
            this.player12HP.TabIndex = 46;
            // 
            // player16enabled
            // 
            this.player16enabled.AutoSize = true;
            this.player16enabled.Location = new System.Drawing.Point(7, 156);
            this.player16enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player16enabled.Name = "player16enabled";
            this.player16enabled.Size = new System.Drawing.Size(15, 14);
            this.player16enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player16enabled, "Check to enable actions on this player.");
            this.player16enabled.UseVisualStyleBackColor = true;
            // 
            // player15optionsButton
            // 
            this.player15optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player15optionsButton.Enabled = false;
            this.player15optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player15optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player15optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player15optionsButton.Location = new System.Drawing.Point(137, 115);
            this.player15optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player15optionsButton.Name = "player15optionsButton";
            this.player15optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player15optionsButton.TabIndex = 3;
            this.player15optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player15optionsButton, "View spells/options for this player.");
            this.player15optionsButton.UseVisualStyleBackColor = false;
            this.player15optionsButton.Click += new System.EventHandler(this.player15optionsButton_Click);
            this.player15optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player15priority
            // 
            this.player15priority.AutoSize = true;
            this.player15priority.Location = new System.Drawing.Point(29, 120);
            this.player15priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player15priority.Name = "player15priority";
            this.player15priority.Size = new System.Drawing.Size(15, 14);
            this.player15priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player15priority, "Check to Enable Player Priority");
            this.player15priority.UseVisualStyleBackColor = true;
            // 
            // player15enabled
            // 
            this.player15enabled.AutoSize = true;
            this.player15enabled.Location = new System.Drawing.Point(7, 120);
            this.player15enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player15enabled.Name = "player15enabled";
            this.player15enabled.Size = new System.Drawing.Size(15, 14);
            this.player15enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player15enabled, "Check to enable actions on this player.");
            this.player15enabled.UseVisualStyleBackColor = true;
            // 
            // player14optionsButton
            // 
            this.player14optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player14optionsButton.Enabled = false;
            this.player14optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player14optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player14optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player14optionsButton.Location = new System.Drawing.Point(137, 79);
            this.player14optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player14optionsButton.Name = "player14optionsButton";
            this.player14optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player14optionsButton.TabIndex = 3;
            this.player14optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player14optionsButton, "View spells/options for this player.");
            this.player14optionsButton.UseVisualStyleBackColor = false;
            this.player14optionsButton.Click += new System.EventHandler(this.player14optionsButton_Click);
            this.player14optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player14priority
            // 
            this.player14priority.AutoSize = true;
            this.player14priority.Location = new System.Drawing.Point(29, 84);
            this.player14priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player14priority.Name = "player14priority";
            this.player14priority.Size = new System.Drawing.Size(15, 14);
            this.player14priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player14priority, "Check to Enable Player Priority");
            this.player14priority.UseVisualStyleBackColor = true;
            // 
            // player14enabled
            // 
            this.player14enabled.AutoSize = true;
            this.player14enabled.Location = new System.Drawing.Point(7, 84);
            this.player14enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player14enabled.Name = "player14enabled";
            this.player14enabled.Size = new System.Drawing.Size(15, 14);
            this.player14enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player14enabled, "Check to enable actions on this player.");
            this.player14enabled.UseVisualStyleBackColor = true;
            // 
            // player13optionsButton
            // 
            this.player13optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player13optionsButton.Enabled = false;
            this.player13optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player13optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player13optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player13optionsButton.Location = new System.Drawing.Point(137, 43);
            this.player13optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player13optionsButton.Name = "player13optionsButton";
            this.player13optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player13optionsButton.TabIndex = 3;
            this.player13optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player13optionsButton, "View spells/options for this player.");
            this.player13optionsButton.UseVisualStyleBackColor = false;
            this.player13optionsButton.Click += new System.EventHandler(this.player13optionsButton_Click);
            this.player13optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player13priority
            // 
            this.player13priority.AutoSize = true;
            this.player13priority.Location = new System.Drawing.Point(29, 49);
            this.player13priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player13priority.Name = "player13priority";
            this.player13priority.Size = new System.Drawing.Size(15, 14);
            this.player13priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player13priority, "Check to Enable Player Priority");
            this.player13priority.UseVisualStyleBackColor = true;
            // 
            // player12optionsButton
            // 
            this.player12optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player12optionsButton.Enabled = false;
            this.player12optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player12optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player12optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player12optionsButton.Location = new System.Drawing.Point(137, 9);
            this.player12optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player12optionsButton.Name = "player12optionsButton";
            this.player12optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player12optionsButton.TabIndex = 3;
            this.player12optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player12optionsButton, "View spells/options for this player.");
            this.player12optionsButton.UseVisualStyleBackColor = false;
            this.player12optionsButton.Click += new System.EventHandler(this.player12optionsButton_Click);
            this.player12optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player13enabled
            // 
            this.player13enabled.AutoSize = true;
            this.player13enabled.Location = new System.Drawing.Point(7, 49);
            this.player13enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player13enabled.Name = "player13enabled";
            this.player13enabled.Size = new System.Drawing.Size(15, 14);
            this.player13enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player13enabled, "Check to enable actions on this player.");
            this.player13enabled.UseVisualStyleBackColor = true;
            // 
            // player12priority
            // 
            this.player12priority.AutoSize = true;
            this.player12priority.Location = new System.Drawing.Point(29, 14);
            this.player12priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player12priority.Name = "player12priority";
            this.player12priority.Size = new System.Drawing.Size(15, 14);
            this.player12priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player12priority, "Check to Enable Player Priority");
            this.player12priority.UseVisualStyleBackColor = true;
            // 
            // player12enabled
            // 
            this.player12enabled.AutoSize = true;
            this.player12enabled.Location = new System.Drawing.Point(7, 14);
            this.player12enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player12enabled.Name = "player12enabled";
            this.player12enabled.Size = new System.Drawing.Size(15, 14);
            this.player12enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player12enabled, "Check to enable actions on this player.");
            this.player12enabled.UseVisualStyleBackColor = true;
            // 
            // player17
            // 
            this.player17.AutoSize = true;
            this.player17.Enabled = false;
            this.player17.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player17.Location = new System.Drawing.Point(48, 192);
            this.player17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player17.Name = "player17";
            this.player17.Size = new System.Drawing.Size(45, 13);
            this.player17.TabIndex = 1;
            this.player17.Text = "Inactive";
            // 
            // player16
            // 
            this.player16.AutoSize = true;
            this.player16.Enabled = false;
            this.player16.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player16.Location = new System.Drawing.Point(46, 156);
            this.player16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player16.Name = "player16";
            this.player16.Size = new System.Drawing.Size(45, 13);
            this.player16.TabIndex = 1;
            this.player16.Text = "Inactive";
            // 
            // player15
            // 
            this.player15.AutoSize = true;
            this.player15.Enabled = false;
            this.player15.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player15.Location = new System.Drawing.Point(46, 120);
            this.player15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player15.Name = "player15";
            this.player15.Size = new System.Drawing.Size(45, 13);
            this.player15.TabIndex = 1;
            this.player15.Text = "Inactive";
            // 
            // player14
            // 
            this.player14.AutoSize = true;
            this.player14.Enabled = false;
            this.player14.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player14.Location = new System.Drawing.Point(46, 84);
            this.player14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player14.Name = "player14";
            this.player14.Size = new System.Drawing.Size(45, 13);
            this.player14.TabIndex = 1;
            this.player14.Text = "Inactive";
            // 
            // player13
            // 
            this.player13.AutoSize = true;
            this.player13.Enabled = false;
            this.player13.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player13.Location = new System.Drawing.Point(46, 49);
            this.player13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player13.Name = "player13";
            this.player13.Size = new System.Drawing.Size(45, 13);
            this.player13.TabIndex = 1;
            this.player13.Text = "Inactive";
            // 
            // player12
            // 
            this.player12.AutoSize = true;
            this.player12.Enabled = false;
            this.player12.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player12.Location = new System.Drawing.Point(46, 14);
            this.player12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player12.Name = "player12";
            this.player12.Size = new System.Drawing.Size(45, 13);
            this.player12.TabIndex = 1;
            this.player12.Text = "Inactive";
            // 
            // partyMembersUpdate
            // 
            this.partyMembersUpdate.Interval = 500;
            this.partyMembersUpdate.Tick += new System.EventHandler(this.partyMembersUpdate_TickAsync);
            // 
            // actionTimer
            // 
            this.actionTimer.Interval = 500;
            this.actionTimer.Tick += new System.EventHandler(this.actionTimer_TickAsync);
            // 
            // player6
            // 
            this.player6.AutoSize = true;
            this.player6.BackColor = System.Drawing.Color.Transparent;
            this.player6.Enabled = false;
            this.player6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player6.Location = new System.Drawing.Point(46, 14);
            this.player6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player6.Name = "player6";
            this.player6.Size = new System.Drawing.Size(45, 13);
            this.player6.TabIndex = 1;
            this.player6.Text = "Inactive";
            // 
            // player7
            // 
            this.player7.AutoSize = true;
            this.player7.Enabled = false;
            this.player7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player7.Location = new System.Drawing.Point(46, 49);
            this.player7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player7.Name = "player7";
            this.player7.Size = new System.Drawing.Size(45, 13);
            this.player7.TabIndex = 1;
            this.player7.Text = "Inactive";
            // 
            // player8
            // 
            this.player8.AutoSize = true;
            this.player8.Enabled = false;
            this.player8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player8.Location = new System.Drawing.Point(46, 84);
            this.player8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player8.Name = "player8";
            this.player8.Size = new System.Drawing.Size(45, 13);
            this.player8.TabIndex = 1;
            this.player8.Text = "Inactive";
            // 
            // player9
            // 
            this.player9.AutoSize = true;
            this.player9.Enabled = false;
            this.player9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player9.Location = new System.Drawing.Point(46, 120);
            this.player9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player9.Name = "player9";
            this.player9.Size = new System.Drawing.Size(45, 13);
            this.player9.TabIndex = 1;
            this.player9.Text = "Inactive";
            // 
            // player10
            // 
            this.player10.AutoSize = true;
            this.player10.Enabled = false;
            this.player10.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player10.Location = new System.Drawing.Point(46, 156);
            this.player10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player10.Name = "player10";
            this.player10.Size = new System.Drawing.Size(45, 13);
            this.player10.TabIndex = 1;
            this.player10.Text = "Inactive";
            // 
            // player11
            // 
            this.player11.AutoSize = true;
            this.player11.Enabled = false;
            this.player11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player11.Location = new System.Drawing.Point(46, 192);
            this.player11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player11.Name = "player11";
            this.player11.Size = new System.Drawing.Size(45, 13);
            this.player11.TabIndex = 1;
            this.player11.Text = "Inactive";
            // 
            // player6enabled
            // 
            this.player6enabled.AutoSize = true;
            this.player6enabled.Location = new System.Drawing.Point(7, 14);
            this.player6enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player6enabled.Name = "player6enabled";
            this.player6enabled.Size = new System.Drawing.Size(15, 14);
            this.player6enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player6enabled, "Check to enable actions on this player.");
            this.player6enabled.UseVisualStyleBackColor = true;
            // 
            // player7enabled
            // 
            this.player7enabled.AutoSize = true;
            this.player7enabled.Location = new System.Drawing.Point(7, 49);
            this.player7enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player7enabled.Name = "player7enabled";
            this.player7enabled.Size = new System.Drawing.Size(15, 14);
            this.player7enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player7enabled, "Check to enable actions on this player.");
            this.player7enabled.UseVisualStyleBackColor = true;
            // 
            // player8enabled
            // 
            this.player8enabled.AutoSize = true;
            this.player8enabled.Location = new System.Drawing.Point(7, 84);
            this.player8enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player8enabled.Name = "player8enabled";
            this.player8enabled.Size = new System.Drawing.Size(15, 14);
            this.player8enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player8enabled, "Check to enable actions on this player.");
            this.player8enabled.UseVisualStyleBackColor = true;
            // 
            // player9enabled
            // 
            this.player9enabled.AutoSize = true;
            this.player9enabled.Location = new System.Drawing.Point(7, 120);
            this.player9enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player9enabled.Name = "player9enabled";
            this.player9enabled.Size = new System.Drawing.Size(15, 14);
            this.player9enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player9enabled, "Check to enable actions on this player.");
            this.player9enabled.UseVisualStyleBackColor = true;
            // 
            // player10enabled
            // 
            this.player10enabled.AutoSize = true;
            this.player10enabled.Location = new System.Drawing.Point(7, 156);
            this.player10enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player10enabled.Name = "player10enabled";
            this.player10enabled.Size = new System.Drawing.Size(15, 14);
            this.player10enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player10enabled, "Check to enable actions on this player.");
            this.player10enabled.UseVisualStyleBackColor = true;
            // 
            // player11enabled
            // 
            this.player11enabled.AutoSize = true;
            this.player11enabled.Location = new System.Drawing.Point(8, 192);
            this.player11enabled.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player11enabled.Name = "player11enabled";
            this.player11enabled.Size = new System.Drawing.Size(15, 14);
            this.player11enabled.TabIndex = 2;
            this.toolTips.SetToolTip(this.player11enabled, "Check to enable actions on this player.");
            this.player11enabled.UseVisualStyleBackColor = true;
            // 
            // party1
            // 
            this.party1.BackColor = System.Drawing.Color.Transparent;
            this.party1.Controls.Add(this.player11HP);
            this.party1.Controls.Add(this.player11optionsButton);
            this.party1.Controls.Add(this.player10HP);
            this.party1.Controls.Add(this.player11priority);
            this.party1.Controls.Add(this.player9HP);
            this.party1.Controls.Add(this.player10optionsButton);
            this.party1.Controls.Add(this.player7HP);
            this.party1.Controls.Add(this.player11enabled);
            this.party1.Controls.Add(this.player8HP);
            this.party1.Controls.Add(this.player9optionsButton);
            this.party1.Controls.Add(this.player6HP);
            this.party1.Controls.Add(this.player10priority);
            this.party1.Controls.Add(this.player8optionsButton);
            this.party1.Controls.Add(this.player10enabled);
            this.party1.Controls.Add(this.player7optionsButton);
            this.party1.Controls.Add(this.player9priority);
            this.party1.Controls.Add(this.player6optionsButton);
            this.party1.Controls.Add(this.player9enabled);
            this.party1.Controls.Add(this.player8priority);
            this.party1.Controls.Add(this.player8enabled);
            this.party1.Controls.Add(this.player7priority);
            this.party1.Controls.Add(this.player7enabled);
            this.party1.Controls.Add(this.player6priority);
            this.party1.Controls.Add(this.player6enabled);
            this.party1.Controls.Add(this.player11);
            this.party1.Controls.Add(this.player10);
            this.party1.Controls.Add(this.player9);
            this.party1.Controls.Add(this.player8);
            this.party1.Controls.Add(this.player7);
            this.party1.Controls.Add(this.player6);
            this.party1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.party1.Location = new System.Drawing.Point(253, 104);
            this.party1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.party1.Name = "party1";
            this.party1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.party1.Size = new System.Drawing.Size(196, 226);
            this.party1.TabIndex = 3;
            this.party1.TabStop = false;
            this.party1.Text = " Party 2 ";
            this.party1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorderlessGroupBox);
            // 
            // player11HP
            // 
            this.player11HP.Location = new System.Drawing.Point(5, 208);
            this.player11HP.Name = "player11HP";
            this.player11HP.Size = new System.Drawing.Size(187, 12);
            this.player11HP.TabIndex = 45;
            // 
            // player11optionsButton
            // 
            this.player11optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player11optionsButton.Enabled = false;
            this.player11optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player11optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player11optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player11optionsButton.Location = new System.Drawing.Point(137, 187);
            this.player11optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player11optionsButton.Name = "player11optionsButton";
            this.player11optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player11optionsButton.TabIndex = 3;
            this.player11optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player11optionsButton, "View spells/options for this player.");
            this.player11optionsButton.UseVisualStyleBackColor = false;
            this.player11optionsButton.Click += new System.EventHandler(this.player11optionsButton_Click);
            this.player11optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player10HP
            // 
            this.player10HP.Location = new System.Drawing.Point(5, 173);
            this.player10HP.Name = "player10HP";
            this.player10HP.Size = new System.Drawing.Size(187, 12);
            this.player10HP.TabIndex = 44;
            // 
            // player11priority
            // 
            this.player11priority.AutoSize = true;
            this.player11priority.Location = new System.Drawing.Point(29, 192);
            this.player11priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player11priority.Name = "player11priority";
            this.player11priority.Size = new System.Drawing.Size(15, 14);
            this.player11priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player11priority, "Check to Enable Player Priority");
            this.player11priority.UseVisualStyleBackColor = true;
            // 
            // player9HP
            // 
            this.player9HP.Location = new System.Drawing.Point(5, 136);
            this.player9HP.Name = "player9HP";
            this.player9HP.Size = new System.Drawing.Size(187, 12);
            this.player9HP.TabIndex = 43;
            // 
            // player10optionsButton
            // 
            this.player10optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player10optionsButton.Enabled = false;
            this.player10optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player10optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player10optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player10optionsButton.Location = new System.Drawing.Point(137, 151);
            this.player10optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player10optionsButton.Name = "player10optionsButton";
            this.player10optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player10optionsButton.TabIndex = 3;
            this.player10optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player10optionsButton, "View spells/options for this player.");
            this.player10optionsButton.UseVisualStyleBackColor = false;
            this.player10optionsButton.Click += new System.EventHandler(this.player10optionsButton_Click);
            this.player10optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player7HP
            // 
            this.player7HP.Location = new System.Drawing.Point(5, 65);
            this.player7HP.Name = "player7HP";
            this.player7HP.Size = new System.Drawing.Size(187, 12);
            this.player7HP.TabIndex = 42;
            // 
            // player8HP
            // 
            this.player8HP.Location = new System.Drawing.Point(5, 101);
            this.player8HP.Name = "player8HP";
            this.player8HP.Size = new System.Drawing.Size(187, 12);
            this.player8HP.TabIndex = 41;
            // 
            // player9optionsButton
            // 
            this.player9optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player9optionsButton.Enabled = false;
            this.player9optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player9optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player9optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player9optionsButton.Location = new System.Drawing.Point(137, 115);
            this.player9optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player9optionsButton.Name = "player9optionsButton";
            this.player9optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player9optionsButton.TabIndex = 3;
            this.player9optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player9optionsButton, "View spells/options for this player.");
            this.player9optionsButton.UseVisualStyleBackColor = false;
            this.player9optionsButton.Click += new System.EventHandler(this.player9optionsButton_Click);
            this.player9optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player6HP
            // 
            this.player6HP.Location = new System.Drawing.Point(5, 30);
            this.player6HP.Name = "player6HP";
            this.player6HP.Size = new System.Drawing.Size(187, 12);
            this.player6HP.TabIndex = 40;
            // 
            // player10priority
            // 
            this.player10priority.AutoSize = true;
            this.player10priority.Location = new System.Drawing.Point(29, 156);
            this.player10priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player10priority.Name = "player10priority";
            this.player10priority.Size = new System.Drawing.Size(15, 14);
            this.player10priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player10priority, "Check to Enable Player Priority");
            this.player10priority.UseVisualStyleBackColor = true;
            // 
            // player8optionsButton
            // 
            this.player8optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player8optionsButton.Enabled = false;
            this.player8optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player8optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player8optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player8optionsButton.Location = new System.Drawing.Point(137, 79);
            this.player8optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player8optionsButton.Name = "player8optionsButton";
            this.player8optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player8optionsButton.TabIndex = 3;
            this.player8optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player8optionsButton, "View spells/options for this player.");
            this.player8optionsButton.UseVisualStyleBackColor = false;
            this.player8optionsButton.Click += new System.EventHandler(this.player8optionsButton_Click);
            this.player8optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player7optionsButton
            // 
            this.player7optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player7optionsButton.Enabled = false;
            this.player7optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player7optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player7optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player7optionsButton.Location = new System.Drawing.Point(137, 43);
            this.player7optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player7optionsButton.Name = "player7optionsButton";
            this.player7optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player7optionsButton.TabIndex = 3;
            this.player7optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player7optionsButton, "View spells/options for this player.");
            this.player7optionsButton.UseVisualStyleBackColor = false;
            this.player7optionsButton.Click += new System.EventHandler(this.player7optionsButton_Click);
            this.player7optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player9priority
            // 
            this.player9priority.AutoSize = true;
            this.player9priority.Location = new System.Drawing.Point(29, 120);
            this.player9priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player9priority.Name = "player9priority";
            this.player9priority.Size = new System.Drawing.Size(15, 14);
            this.player9priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player9priority, "Check to Enable Player Priority");
            this.player9priority.UseVisualStyleBackColor = true;
            // 
            // player6optionsButton
            // 
            this.player6optionsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.player6optionsButton.Enabled = false;
            this.player6optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player6optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player6optionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.player6optionsButton.Location = new System.Drawing.Point(137, 9);
            this.player6optionsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player6optionsButton.Name = "player6optionsButton";
            this.player6optionsButton.Size = new System.Drawing.Size(55, 19);
            this.player6optionsButton.TabIndex = 3;
            this.player6optionsButton.Text = "MENU";
            this.toolTips.SetToolTip(this.player6optionsButton, "View spells/options for this player.");
            this.player6optionsButton.UseVisualStyleBackColor = false;
            this.player6optionsButton.Click += new System.EventHandler(this.player6optionsButton_Click);
            this.player6optionsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // player8priority
            // 
            this.player8priority.AutoSize = true;
            this.player8priority.Location = new System.Drawing.Point(29, 84);
            this.player8priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player8priority.Name = "player8priority";
            this.player8priority.Size = new System.Drawing.Size(15, 14);
            this.player8priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player8priority, "Check to Enable Player Priority");
            this.player8priority.UseVisualStyleBackColor = true;
            // 
            // player7priority
            // 
            this.player7priority.AutoSize = true;
            this.player7priority.Location = new System.Drawing.Point(29, 49);
            this.player7priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player7priority.Name = "player7priority";
            this.player7priority.Size = new System.Drawing.Size(15, 14);
            this.player7priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player7priority, "Check to Enable Player Priority");
            this.player7priority.UseVisualStyleBackColor = true;
            // 
            // player6priority
            // 
            this.player6priority.AutoSize = true;
            this.player6priority.Location = new System.Drawing.Point(29, 14);
            this.player6priority.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.player6priority.Name = "player6priority";
            this.player6priority.Size = new System.Drawing.Size(15, 14);
            this.player6priority.TabIndex = 2;
            this.toolTips.SetToolTip(this.player6priority, "Check to Enable Player Priority");
            this.player6priority.UseVisualStyleBackColor = true;
            // 
            // POLID2
            // 
            this.POLID2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.POLID2.FormattingEnabled = true;
            this.POLID2.Location = new System.Drawing.Point(178, 36);
            this.POLID2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.POLID2.Name = "POLID2";
            this.POLID2.Size = new System.Drawing.Size(117, 21);
            this.POLID2.TabIndex = 3;
            // 
            // setinstance2
            // 
            this.setinstance2.BackColor = System.Drawing.SystemColors.Menu;
            this.setinstance2.Enabled = false;
            this.setinstance2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setinstance2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.setinstance2.Location = new System.Drawing.Point(299, 35);
            this.setinstance2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.setinstance2.Name = "setinstance2";
            this.setinstance2.Size = new System.Drawing.Size(74, 22);
            this.setinstance2.TabIndex = 4;
            this.setinstance2.Text = "Select";
            this.toolTips.SetToolTip(this.setinstance2, "Select Monitored Player");
            this.setinstance2.UseVisualStyleBackColor = false;
            this.setinstance2.Click += new System.EventHandler(this.setinstance2_Click);
            this.setinstance2.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // monitoredLabel
            // 
            this.monitoredLabel.AutoSize = true;
            this.monitoredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitoredLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.monitoredLabel.Location = new System.Drawing.Point(4, 38);
            this.monitoredLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monitoredLabel.Name = "monitoredLabel";
            this.monitoredLabel.Size = new System.Drawing.Size(145, 13);
            this.monitoredLabel.TabIndex = 5;
            this.monitoredLabel.Text = "Monitored Player: NONE";
            // 
            // hpUpdates
            // 
            this.hpUpdates.Interval = 500;
            this.hpUpdates.Tick += new System.EventHandler(this.hpUpdates_Tick);
            // 
            // plPosition
            // 
            this.plPosition.Interval = 1000;
            this.plPosition.Tick += new System.EventHandler(this.plPosition_Tick);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.SystemColors.Menu;
            this.pauseButton.Enabled = false;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.pauseButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pauseButton.Location = new System.Drawing.Point(404, 43);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(245, 54);
            this.pauseButton.TabIndex = 10;
            this.pauseButton.Text = "Pause";
            this.toolTips.SetToolTip(this.pauseButton, "Pauses Bot");
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.button3_Click);
            this.pauseButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.checkBox1.Location = new System.Drawing.Point(11, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Always on Top";
            this.toolTips.SetToolTip(this.checkBox1, "Always on Top");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackBar1.Location = new System.Drawing.Point(7, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 12;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(93, 17);
            this.trackBar1.TabIndex = 19;
            this.toolTips.SetToolTip(this.trackBar1, "Cure Please Transparency");
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // autoOptions
            // 
            this.autoOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoPhalanxIIToolStripMenuItem1,
            this.autoRegenVToolStripMenuItem,
            this.autoRefreshIIToolStripMenuItem,
            this.toolStripSeparator1,
            this.SandstormToolStripMenuItem,
            this.RainstormToolStripMenuItem,
            this.WindstormToolStripMenuItem,
            this.FirestormToolStripMenuItem,
            this.AurorastormToolStripMenuItem,
            this.VoidstormToolStripMenuItem,
            this.ThunderstormToolStripMenuItem,
            this.HailstormToolStripMenuItem});
            this.autoOptions.Name = "proshellOptions";
            this.autoOptions.Size = new System.Drawing.Size(179, 252);
            // 
            // autoPhalanxIIToolStripMenuItem1
            // 
            this.autoPhalanxIIToolStripMenuItem1.Name = "autoPhalanxIIToolStripMenuItem1";
            this.autoPhalanxIIToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.autoPhalanxIIToolStripMenuItem1.Text = "Auto Phalanx II";
            this.autoPhalanxIIToolStripMenuItem1.Click += new System.EventHandler(this.autoPhalanxIIToolStripMenuItem1_Click);
            // 
            // autoRegenVToolStripMenuItem
            // 
            this.autoRegenVToolStripMenuItem.Name = "autoRegenVToolStripMenuItem";
            this.autoRegenVToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.autoRegenVToolStripMenuItem.Text = "Auto Regen";
            this.autoRegenVToolStripMenuItem.Click += new System.EventHandler(this.autoRegenVToolStripMenuItem_Click);
            // 
            // autoRefreshIIToolStripMenuItem
            // 
            this.autoRefreshIIToolStripMenuItem.Name = "autoRefreshIIToolStripMenuItem";
            this.autoRefreshIIToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.autoRefreshIIToolStripMenuItem.Text = "Auto Refresh";
            this.autoRefreshIIToolStripMenuItem.Click += new System.EventHandler(this.autoRefreshIIToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // SandstormToolStripMenuItem
            // 
            this.SandstormToolStripMenuItem.Name = "SandstormToolStripMenuItem";
            this.SandstormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SandstormToolStripMenuItem.Text = "Auto Sandstorm";
            this.SandstormToolStripMenuItem.Click += new System.EventHandler(this.SandstormToolStripMenuItem_Click);
            // 
            // RainstormToolStripMenuItem
            // 
            this.RainstormToolStripMenuItem.Name = "RainstormToolStripMenuItem";
            this.RainstormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.RainstormToolStripMenuItem.Text = "Auto Rainstorm";
            this.RainstormToolStripMenuItem.Click += new System.EventHandler(this.RainstormToolStripMenuItem_Click);
            // 
            // WindstormToolStripMenuItem
            // 
            this.WindstormToolStripMenuItem.Name = "WindstormToolStripMenuItem";
            this.WindstormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.WindstormToolStripMenuItem.Text = "Auto Windstorm";
            this.WindstormToolStripMenuItem.Click += new System.EventHandler(this.WindstormToolStripMenuItem_Click);
            // 
            // FirestormToolStripMenuItem
            // 
            this.FirestormToolStripMenuItem.Name = "FirestormToolStripMenuItem";
            this.FirestormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.FirestormToolStripMenuItem.Text = "Auto Firestorm";
            this.FirestormToolStripMenuItem.Click += new System.EventHandler(this.FirestormToolStripMenuItem_Click);
            // 
            // AurorastormToolStripMenuItem
            // 
            this.AurorastormToolStripMenuItem.Name = "AurorastormToolStripMenuItem";
            this.AurorastormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.AurorastormToolStripMenuItem.Text = "Auto Aurorastorm";
            this.AurorastormToolStripMenuItem.Click += new System.EventHandler(this.AurorastormToolStripMenuItem_Click);
            // 
            // VoidstormToolStripMenuItem
            // 
            this.VoidstormToolStripMenuItem.Name = "VoidstormToolStripMenuItem";
            this.VoidstormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.VoidstormToolStripMenuItem.Text = "Auto Voidstorm";
            this.VoidstormToolStripMenuItem.Click += new System.EventHandler(this.VoidstormToolStripMenuItem_Click);
            // 
            // ThunderstormToolStripMenuItem
            // 
            this.ThunderstormToolStripMenuItem.Name = "ThunderstormToolStripMenuItem";
            this.ThunderstormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ThunderstormToolStripMenuItem.Text = "Auto Thunderstorm";
            this.ThunderstormToolStripMenuItem.Click += new System.EventHandler(this.ThunderstormToolStripMenuItem_Click);
            // 
            // HailstormToolStripMenuItem
            // 
            this.HailstormToolStripMenuItem.Name = "HailstormToolStripMenuItem";
            this.HailstormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.HailstormToolStripMenuItem.Text = "Auto Hailstorm";
            this.HailstormToolStripMenuItem.Click += new System.EventHandler(this.HailstormToolStripMenuItem_Click);
            // 
            // autoRegenIVToolStripMenuItem1
            // 
            this.autoRegenIVToolStripMenuItem1.Name = "autoRegenIVToolStripMenuItem1";
            this.autoRegenIVToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // charselect
            // 
            this.charselect.BackColor = System.Drawing.Color.Transparent;
            this.charselect.Controls.Add(this.POLID2);
            this.charselect.Controls.Add(this.monitoredLabel);
            this.charselect.Controls.Add(this.plLabel);
            this.charselect.Controls.Add(this.POLID);
            this.charselect.Controls.Add(this.setinstance);
            this.charselect.Controls.Add(this.setinstance2);
            this.charselect.ForeColor = System.Drawing.SystemColors.GrayText;
            this.charselect.Location = new System.Drawing.Point(19, 37);
            this.charselect.Name = "charselect";
            this.charselect.Size = new System.Drawing.Size(377, 60);
            this.charselect.TabIndex = 16;
            this.charselect.TabStop = false;
            this.charselect.Text = " Character Selection ";
            this.charselect.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorderlessGroupBox);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(131, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 31);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " windows settings ";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorderlessGroupBox);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Location = new System.Drawing.Point(19, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 31);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " transparency ";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorderlessGroupBox);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cure Please 1.0.2.1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickTray);
            // 
            // debugging_MSGBOX
            // 
            this.debugging_MSGBOX.AutoSize = true;
            this.debugging_MSGBOX.Location = new System.Drawing.Point(641, 5);
            this.debugging_MSGBOX.Name = "debugging_MSGBOX";
            this.debugging_MSGBOX.Size = new System.Drawing.Size(0, 13);
            this.debugging_MSGBOX.TabIndex = 22;
            // 
            // resetSongTimer
            // 
            this.resetSongTimer.Enabled = true;
            this.resetSongTimer.Interval = 60000;
            this.resetSongTimer.Tick += new System.EventHandler(this.resetSongTimer_Tick);
            // 
            // checkSCHCharges
            // 
            this.checkSCHCharges.Enabled = true;
            this.checkSCHCharges.Interval = 500;
            this.checkSCHCharges.Tick += new System.EventHandler(this.checkSCHCharges_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.debug);
            this.groupBox2.Controls.Add(this.currentAction);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(255, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 31);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " current action ";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorderlessGroupBox);
            // 
            // debug
            // 
            this.debug.BackColor = System.Drawing.SystemColors.Menu;
            this.debug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debug.ForeColor = System.Drawing.Color.Black;
            this.debug.Location = new System.Drawing.Point(318, 6);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(76, 25);
            this.debug.TabIndex = 24;
            this.debug.Text = "debug";
            this.debug.UseVisualStyleBackColor = false;
            this.debug.Visible = false;
            this.debug.Click += new System.EventHandler(this.Debug_Click);
            this.debug.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintButton);
            // 
            // currentAction
            // 
            this.currentAction.AutoSize = true;
            this.currentAction.ForeColor = System.Drawing.Color.Black;
            this.currentAction.Location = new System.Drawing.Point(7, 14);
            this.currentAction.Name = "currentAction";
            this.currentAction.Size = new System.Drawing.Size(103, 13);
            this.currentAction.TabIndex = 0;
            this.currentAction.Text = "CURRENT ACTION";
            // 
            // updateInstances
            // 
            this.updateInstances.Enabled = true;
            this.updateInstances.Interval = 60000;
            this.updateInstances.Tick += new System.EventHandler(this.updateInstances_Tick);
            // 
            // checkCustomActions
            // 
            this.checkCustomActions.Enabled = true;
            this.checkCustomActions.Interval = 1000;
            this.checkCustomActions.Tick += new System.EventHandler(this.CheckCustomActions_TickAsync);
            // 
            // castingLockLabel
            // 
            this.castingLockLabel.AutoSize = true;
            this.castingLockLabel.Location = new System.Drawing.Point(79, 16);
            this.castingLockLabel.Name = "castingLockLabel";
            this.castingLockLabel.Size = new System.Drawing.Size(0, 13);
            this.castingLockLabel.TabIndex = 28;
            // 
            // Follow_BGW
            // 
            this.Follow_BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Follow_BGW_DoWork);
            this.Follow_BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Follow_BGW_RunWorkerCompleted);
            // 
            // OptionsButton
            // 
            this.OptionsButton.AutoSize = true;
            this.OptionsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionsButton.BackColor = System.Drawing.Color.White;
            this.OptionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.Location = new System.Drawing.Point(376, 8);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(61, 27);
            this.OptionsButton.TabIndex = 29;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // ChatLogButton
            // 
            this.ChatLogButton.AutoSize = true;
            this.ChatLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChatLogButton.BackColor = System.Drawing.Color.White;
            this.ChatLogButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChatLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatLogButton.Location = new System.Drawing.Point(443, 8);
            this.ChatLogButton.Name = "ChatLogButton";
            this.ChatLogButton.Size = new System.Drawing.Size(68, 27);
            this.ChatLogButton.TabIndex = 30;
            this.ChatLogButton.Text = "Chat Log";
            this.ChatLogButton.UseVisualStyleBackColor = false;
            this.ChatLogButton.Click += new System.EventHandler(this.ChatLogButton_Click);
            // 
            // PartyBuffsButton
            // 
            this.PartyBuffsButton.AutoSize = true;
            this.PartyBuffsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PartyBuffsButton.BackColor = System.Drawing.Color.White;
            this.PartyBuffsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PartyBuffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PartyBuffsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyBuffsButton.Location = new System.Drawing.Point(517, 8);
            this.PartyBuffsButton.Name = "PartyBuffsButton";
            this.PartyBuffsButton.Size = new System.Drawing.Size(76, 27);
            this.PartyBuffsButton.TabIndex = 31;
            this.PartyBuffsButton.Text = "Party Buffs";
            this.PartyBuffsButton.UseVisualStyleBackColor = false;
            this.PartyBuffsButton.Click += new System.EventHandler(this.PartyBuffsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.AutoSize = true;
            this.AboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AboutButton.BackColor = System.Drawing.Color.White;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(599, 8);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(50, 27);
            this.AboutButton.TabIndex = 32;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // AddonReader
            // 
            this.AddonReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AddonReader_DoWork);
            this.AddonReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AddonReader_RunWorkerCompleted);
            // 
            // FullCircle_Timer
            // 
            this.FullCircle_Timer.Interval = 5000;
            this.FullCircle_Timer.Tick += new System.EventHandler(this.FullCircle_Timer_Tick);
            // 
            // AddOnStatus
            // 
            this.AddOnStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddOnStatus.BackColor = System.Drawing.Color.DarkRed;
            this.AddOnStatus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddOnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOnStatus.Location = new System.Drawing.Point(302, 8);
            this.AddOnStatus.Name = "AddOnStatus";
            this.AddOnStatus.Size = new System.Drawing.Size(68, 27);
            this.AddOnStatus.TabIndex = 33;
            this.AddOnStatus.Text = "AddOn";
            this.AddOnStatus.UseVisualStyleBackColor = false;
            this.AddOnStatus.Click += new System.EventHandler(this.AddOnStatus_Click);
            // 
            // ProtectCasting
            // 
            this.ProtectCasting.WorkerSupportsCancellation = true;
            this.ProtectCasting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProtectCasting_DoWork);
            // 
            // JobAbility_Delay
            // 
            this.JobAbility_Delay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.JobAbility_Delay_DoWork);
            // 
            // EclipticTimer
            // 
            this.EclipticTimer.Interval = 1000;
            this.EclipticTimer.Tick += new System.EventHandler(this.EclipticTimer_Tick);
            // 
            // CustomCommand_Tracker
            // 
            this.CustomCommand_Tracker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CustomCommand_Tracker_DoWork);
            this.CustomCommand_Tracker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CustomCommand_Tracker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.AddOnStatus);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.PartyBuffsButton);
            this.Controls.Add(this.ChatLogButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.castingLockLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.debugging_MSGBOX);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.charselect);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.party2);
            this.Controls.Add(this.party1);
            this.Controls.Add(this.party0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Cure Please v. 2.0.0.5";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.party0.ResumeLayout(false);
            this.party0.PerformLayout();
            this.playerOptions.ResumeLayout(false);
            this.party2.ResumeLayout(false);
            this.party2.PerformLayout();
            this.party1.ResumeLayout(false);
            this.party1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.autoOptions.ResumeLayout(false);
            this.charselect.ResumeLayout(false);
            this.charselect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.GroupBox party0;
        private System.Windows.Forms.Label player0;
        private System.Windows.Forms.CheckBox player0enabled;
        private System.Windows.Forms.ComboBox POLID;
        private System.Windows.Forms.Label plLabel;
        private System.Windows.Forms.CheckBox player1enabled;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.CheckBox player5enabled;
        private System.Windows.Forms.CheckBox player4enabled;
        private System.Windows.Forms.CheckBox player3enabled;
        private System.Windows.Forms.CheckBox player2enabled;
        private System.Windows.Forms.Label player5;
        private System.Windows.Forms.Label player4;
        private System.Windows.Forms.Label player3;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.GroupBox party2;
        private System.Windows.Forms.CheckBox player17enabled;
        private System.Windows.Forms.CheckBox player16enabled;
        private System.Windows.Forms.CheckBox player15enabled;
        private System.Windows.Forms.CheckBox player14enabled;
        private System.Windows.Forms.CheckBox player13enabled;
        private System.Windows.Forms.CheckBox player12enabled;
        private System.Windows.Forms.Label player17;
        private System.Windows.Forms.Label player16;
        private System.Windows.Forms.Label player15;
        private System.Windows.Forms.Label player14;
        private System.Windows.Forms.Label player13;
        private System.Windows.Forms.Label player12;
        private System.Windows.Forms.Timer partyMembersUpdate;
        private System.Windows.Forms.Timer actionTimer;
        private System.Windows.Forms.Label player6;
        private System.Windows.Forms.Label player7;
        private System.Windows.Forms.Label player8;
        private System.Windows.Forms.Label player9;
        private System.Windows.Forms.Label player10;
        private System.Windows.Forms.Label player11;
        private System.Windows.Forms.CheckBox player6enabled;
        private System.Windows.Forms.CheckBox player7enabled;
        private System.Windows.Forms.CheckBox player8enabled;
        private System.Windows.Forms.CheckBox player9enabled;
        private System.Windows.Forms.CheckBox player10enabled;
        private System.Windows.Forms.CheckBox player11enabled;
        private System.Windows.Forms.GroupBox party1;
        private System.Windows.Forms.ComboBox POLID2;
        private System.Windows.Forms.Label monitoredLabel;
        private System.Windows.Forms.Timer hpUpdates;
        private System.Windows.Forms.CheckBox player5priority;
        private System.Windows.Forms.CheckBox player4priority;
        private System.Windows.Forms.CheckBox player3priority;
        private System.Windows.Forms.CheckBox player2priority;
        private System.Windows.Forms.CheckBox player1priority;
        private System.Windows.Forms.CheckBox player0priority;
        private System.Windows.Forms.CheckBox player17priority;
        private System.Windows.Forms.CheckBox player16priority;
        private System.Windows.Forms.CheckBox player15priority;
        private System.Windows.Forms.CheckBox player14priority;
        private System.Windows.Forms.CheckBox player13priority;
        private System.Windows.Forms.CheckBox player12priority;
        private System.Windows.Forms.CheckBox player11priority;
        private System.Windows.Forms.CheckBox player10priority;
        private System.Windows.Forms.CheckBox player9priority;
        private System.Windows.Forms.CheckBox player8priority;
        private System.Windows.Forms.CheckBox player7priority;
        private System.Windows.Forms.CheckBox player6priority;
        private System.Windows.Forms.Timer plPosition;
        private System.Windows.Forms.ContextMenuStrip playerOptions;
        private System.Windows.Forms.ToolStripMenuItem paralynaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoHasteToolStripMenuItem;
        private System.Windows.Forms.Button player1optionsButton;
        private System.Windows.Forms.ToolStripMenuItem eraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem blindnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poisonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phalanxIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sneakToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button player5optionsButton;
        private System.Windows.Forms.Button player4optionsButton;
        private System.Windows.Forms.Button player3optionsButton;
        private System.Windows.Forms.Button player2optionsButton;
        private System.Windows.Forms.Button player17optionsButton;
        private System.Windows.Forms.Button player16optionsButton;
        private System.Windows.Forms.Button player15optionsButton;
        private System.Windows.Forms.Button player14optionsButton;
        private System.Windows.Forms.Button player13optionsButton;
        private System.Windows.Forms.Button player12optionsButton;
        private System.Windows.Forms.Button player11optionsButton;
        private System.Windows.Forms.Button player10optionsButton;
        private System.Windows.Forms.Button player9optionsButton;
        private System.Windows.Forms.Button player8optionsButton;
        private System.Windows.Forms.Button player7optionsButton;
        private System.Windows.Forms.Button player6optionsButton;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ToolStripMenuItem sacrificeToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem regenIVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip autoOptions;
        private System.Windows.Forms.Button player5buffsButton;
        private System.Windows.Forms.Button player4buffsButton;
        private System.Windows.Forms.Button player3buffsButton;
        private System.Windows.Forms.Button player2buffsButton;
        private System.Windows.Forms.Button player1buffsButton;
        private System.Windows.Forms.Button player0buffsButton;
        private System.Windows.Forms.GroupBox charselect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem refreshIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshIIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regenIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem stormspellToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem protectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protectIVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protectVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellIVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoPhalanxIIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoRegenIVToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem regenIIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoProtectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoProtectIVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enableDebuffRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeperator13;
        private System.Windows.Forms.ToolStripMenuItem autoProtectVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoShellIVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoShellVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRegenVToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem followToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopfollowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem GeoTargetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EntrustTargetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DevotionTargetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HateEstablisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem autoHasteIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoAdloquiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoFlurryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoFlurryIIToolStripMenuItem;
        private ToolStripMenuItem autoRefreshIIToolStripMenuItem;
        public Button setinstance;
        public Button setinstance2;
        public Label debugging_MSGBOX;
        private Timer resetSongTimer;
        private Timer checkSCHCharges;
        private Timer AutomaticChecks;
        private GroupBox groupBox2;
        private Label currentAction;
        private Button debug;
        private Timer updateInstances;
        private Button player0optionsButton;
        private Timer checkCustomActions;
        private NewProgressBar player0HP;
        private NewProgressBar player5HP;
        private NewProgressBar player4HP;
        private NewProgressBar player3HP;
        private NewProgressBar player1HP;
        private NewProgressBar player2HP;
        private NewProgressBar player17HP;
        private NewProgressBar player16HP;
        private NewProgressBar player15HP;
        private NewProgressBar player13HP;
        private NewProgressBar player14HP;
        private NewProgressBar player12HP;
        private NewProgressBar player11HP;
        private NewProgressBar player10HP;
        private NewProgressBar player9HP;
        private NewProgressBar player7HP;
        private NewProgressBar player8HP;
        private NewProgressBar player6HP;
        private TrackBar trackBar1;
        private Label castingLockLabel;
        private System.ComponentModel.BackgroundWorker Follow_BGW;
        private Button OptionsButton;
        private Button ChatLogButton;
        private Button PartyBuffsButton;
        private Button AboutButton;
        private System.ComponentModel.BackgroundWorker AddonReader;
        private System.ComponentModel.BackgroundWorker JobAbilityDelay;
        private Timer FullCircle_Timer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SandstormToolStripMenuItem;
        private ToolStripMenuItem RainstormToolStripMenuItem;
        private ToolStripMenuItem WindstormToolStripMenuItem;
        private ToolStripMenuItem FirestormToolStripMenuItem;
        private ToolStripMenuItem AurorastormToolStripMenuItem;
        private ToolStripMenuItem VoidstormToolStripMenuItem;
        private ToolStripMenuItem ThunderstormToolStripMenuItem;
        private ToolStripMenuItem HailstormToolStripMenuItem;
        private Button AddOnStatus;
        private System.ComponentModel.BackgroundWorker ProtectCasting;
        private System.ComponentModel.BackgroundWorker JobAbility_Delay;
        private Timer EclipticTimer;
        private System.ComponentModel.BackgroundWorker CustomCommand_Tracker;
    }
}
