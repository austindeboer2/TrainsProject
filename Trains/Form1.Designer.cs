namespace Trains
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTownBtn = new System.Windows.Forms.Button();
            this.newTown = new System.Windows.Forms.TextBox();
            this.townsList = new System.Windows.Forms.TextBox();
            this.startConnect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stopConnect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weightConnect = new System.Windows.Forms.ComboBox();
            this.AddConnection = new System.Windows.Forms.Button();
            this.connectionText = new System.Windows.Forms.TextBox();
            this.GenNetwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTownBtn
            // 
            this.AddTownBtn.Location = new System.Drawing.Point(12, 59);
            this.AddTownBtn.Name = "AddTownBtn";
            this.AddTownBtn.Size = new System.Drawing.Size(202, 23);
            this.AddTownBtn.TabIndex = 1;
            this.AddTownBtn.Text = "Add Town";
            this.AddTownBtn.UseVisualStyleBackColor = true;
            this.AddTownBtn.Click += new System.EventHandler(this.AddTownBtn_Click);
            // 
            // newTown
            // 
            this.newTown.Location = new System.Drawing.Point(12, 30);
            this.newTown.Name = "newTown";
            this.newTown.Size = new System.Drawing.Size(202, 23);
            this.newTown.TabIndex = 2;
            // 
            // townsList
            // 
            this.townsList.Location = new System.Drawing.Point(12, 88);
            this.townsList.Multiline = true;
            this.townsList.Name = "townsList";
            this.townsList.ReadOnly = true;
            this.townsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.townsList.Size = new System.Drawing.Size(202, 459);
            this.townsList.TabIndex = 3;
            // 
            // startConnect
            // 
            this.startConnect.FormattingEnabled = true;
            this.startConnect.Location = new System.Drawing.Point(229, 106);
            this.startConnect.Name = "startConnect";
            this.startConnect.Size = new System.Drawing.Size(121, 23);
            this.startConnect.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connections";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(396, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stop";
            // 
            // stopConnect
            // 
            this.stopConnect.FormattingEnabled = true;
            this.stopConnect.Location = new System.Drawing.Point(356, 106);
            this.stopConnect.Name = "stopConnect";
            this.stopConnect.Size = new System.Drawing.Size(121, 23);
            this.stopConnect.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(523, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weight";
            // 
            // weightConnect
            // 
            this.weightConnect.FormattingEnabled = true;
            this.weightConnect.Location = new System.Drawing.Point(483, 106);
            this.weightConnect.Name = "weightConnect";
            this.weightConnect.Size = new System.Drawing.Size(121, 23);
            this.weightConnect.TabIndex = 9;
            // 
            // AddConnection
            // 
            this.AddConnection.Location = new System.Drawing.Point(229, 144);
            this.AddConnection.Name = "AddConnection";
            this.AddConnection.Size = new System.Drawing.Size(375, 27);
            this.AddConnection.TabIndex = 11;
            this.AddConnection.Text = "Add Connection";
            this.AddConnection.UseVisualStyleBackColor = true;
            this.AddConnection.Click += new System.EventHandler(this.AddConnection_Click);
            // 
            // connectionText
            // 
            this.connectionText.Location = new System.Drawing.Point(229, 185);
            this.connectionText.Multiline = true;
            this.connectionText.Name = "connectionText";
            this.connectionText.ReadOnly = true;
            this.connectionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.connectionText.Size = new System.Drawing.Size(375, 363);
            this.connectionText.TabIndex = 12;
            // 
            // GenNetwork
            // 
            this.GenNetwork.Location = new System.Drawing.Point(612, 30);
            this.GenNetwork.Name = "GenNetwork";
            this.GenNetwork.Size = new System.Drawing.Size(111, 517);
            this.GenNetwork.TabIndex = 13;
            this.GenNetwork.Text = "Generate Network";
            this.GenNetwork.UseVisualStyleBackColor = true;
            this.GenNetwork.Click += new System.EventHandler(this.GenNetwork_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(735, 566);
            this.Controls.Add(this.GenNetwork);
            this.Controls.Add(this.connectionText);
            this.Controls.Add(this.AddConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weightConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startConnect);
            this.Controls.Add(this.townsList);
            this.Controls.Add(this.newTown);
            this.Controls.Add(this.AddTownBtn);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button addTown;
        private Button AddTownBtn;
        private TextBox newTown;
        private TextBox townsList;
        private ComboBox startConnect;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox stopConnect;
        private Label label4;
        private ComboBox weightConnect;
        private Button AddConnection;
        private TextBox connectionText;
        private Button GenNetwork;
    }
}