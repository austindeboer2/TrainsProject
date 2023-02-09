namespace Trains
{
    partial class NetworkSim
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
            this.weightsTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.routeDistInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenRouteDist = new System.Windows.Forms.Button();
            this.routeDistOutput = new System.Windows.Forms.TextBox();
            this.uniqueOutput = new System.Windows.Forms.TextBox();
            this.GenUnique = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exactDrop = new System.Windows.Forms.ComboBox();
            this.startDrop = new System.Windows.Forms.ComboBox();
            this.stopDrop = new System.Windows.Forms.ComboBox();
            this.numberDrop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stopDrop2 = new System.Windows.Forms.ComboBox();
            this.startDrop2 = new System.Windows.Forms.ComboBox();
            this.GenShortRoute = new System.Windows.Forms.Button();
            this.shortOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.weightsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // weightsTable
            // 
            this.weightsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.weightsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.weightsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weightsTable.Location = new System.Drawing.Point(98, 12);
            this.weightsTable.Name = "weightsTable";
            this.weightsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.weightsTable.RowTemplate.Height = 25;
            this.weightsTable.Size = new System.Drawing.Size(318, 258);
            this.weightsTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Route Distance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // routeDistInput
            // 
            this.routeDistInput.Location = new System.Drawing.Point(34, 350);
            this.routeDistInput.Name = "routeDistInput";
            this.routeDistInput.Size = new System.Drawing.Size(100, 23);
            this.routeDistInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "EX: A-B-C-A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenRouteDist
            // 
            this.GenRouteDist.Location = new System.Drawing.Point(34, 379);
            this.GenRouteDist.Name = "GenRouteDist";
            this.GenRouteDist.Size = new System.Drawing.Size(100, 23);
            this.GenRouteDist.TabIndex = 4;
            this.GenRouteDist.Text = "Generate";
            this.GenRouteDist.UseVisualStyleBackColor = true;
            this.GenRouteDist.Click += new System.EventHandler(this.GenRouteDist_Click);
            // 
            // routeDistOutput
            // 
            this.routeDistOutput.Location = new System.Drawing.Point(34, 408);
            this.routeDistOutput.Name = "routeDistOutput";
            this.routeDistOutput.ReadOnly = true;
            this.routeDistOutput.Size = new System.Drawing.Size(100, 23);
            this.routeDistOutput.TabIndex = 5;
            // 
            // uniqueOutput
            // 
            this.uniqueOutput.Location = new System.Drawing.Point(266, 409);
            this.uniqueOutput.Name = "uniqueOutput";
            this.uniqueOutput.ReadOnly = true;
            this.uniqueOutput.Size = new System.Drawing.Size(100, 23);
            this.uniqueOutput.TabIndex = 10;
            // 
            // GenUnique
            // 
            this.GenUnique.Location = new System.Drawing.Point(160, 409);
            this.GenUnique.Name = "GenUnique";
            this.GenUnique.Size = new System.Drawing.Size(100, 23);
            this.GenUnique.TabIndex = 9;
            this.GenUnique.Text = "Generate";
            this.GenUnique.UseVisualStyleBackColor = true;
            this.GenUnique.Click += new System.EventHandler(this.GenUnique_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(160, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unique Routes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(160, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exactDrop
            // 
            this.exactDrop.FormattingEnabled = true;
            this.exactDrop.Location = new System.Drawing.Point(266, 297);
            this.exactDrop.Name = "exactDrop";
            this.exactDrop.Size = new System.Drawing.Size(100, 23);
            this.exactDrop.TabIndex = 12;
            // 
            // startDrop
            // 
            this.startDrop.FormattingEnabled = true;
            this.startDrop.Location = new System.Drawing.Point(266, 324);
            this.startDrop.Name = "startDrop";
            this.startDrop.Size = new System.Drawing.Size(100, 23);
            this.startDrop.TabIndex = 13;
            // 
            // stopDrop
            // 
            this.stopDrop.FormattingEnabled = true;
            this.stopDrop.Location = new System.Drawing.Point(266, 351);
            this.stopDrop.Name = "stopDrop";
            this.stopDrop.Size = new System.Drawing.Size(100, 23);
            this.stopDrop.TabIndex = 14;
            // 
            // numberDrop
            // 
            this.numberDrop.FormattingEnabled = true;
            this.numberDrop.Location = new System.Drawing.Point(266, 380);
            this.numberDrop.Name = "numberDrop";
            this.numberDrop.Size = new System.Drawing.Size(100, 23);
            this.numberDrop.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(160, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stop";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(160, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max Stops / Distance";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(398, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Shortest Route";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(372, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stop";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(372, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Start";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopDrop2
            // 
            this.stopDrop2.FormattingEnabled = true;
            this.stopDrop2.Location = new System.Drawing.Point(433, 350);
            this.stopDrop2.Name = "stopDrop2";
            this.stopDrop2.Size = new System.Drawing.Size(100, 23);
            this.stopDrop2.TabIndex = 22;
            // 
            // startDrop2
            // 
            this.startDrop2.FormattingEnabled = true;
            this.startDrop2.Location = new System.Drawing.Point(433, 323);
            this.startDrop2.Name = "startDrop2";
            this.startDrop2.Size = new System.Drawing.Size(100, 23);
            this.startDrop2.TabIndex = 21;
            // 
            // GenShortRoute
            // 
            this.GenShortRoute.Location = new System.Drawing.Point(398, 379);
            this.GenShortRoute.Name = "GenShortRoute";
            this.GenShortRoute.Size = new System.Drawing.Size(100, 23);
            this.GenShortRoute.TabIndex = 23;
            this.GenShortRoute.Text = "Generate";
            this.GenShortRoute.UseVisualStyleBackColor = true;
            this.GenShortRoute.Click += new System.EventHandler(this.GenShortRoute_Click);
            // 
            // shortOutput
            // 
            this.shortOutput.Location = new System.Drawing.Point(398, 408);
            this.shortOutput.Name = "shortOutput";
            this.shortOutput.ReadOnly = true;
            this.shortOutput.Size = new System.Drawing.Size(100, 23);
            this.shortOutput.TabIndex = 24;
            // 
            // NetworkSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 453);
            this.Controls.Add(this.shortOutput);
            this.Controls.Add(this.GenShortRoute);
            this.Controls.Add(this.stopDrop2);
            this.Controls.Add(this.startDrop2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberDrop);
            this.Controls.Add(this.stopDrop);
            this.Controls.Add(this.startDrop);
            this.Controls.Add(this.exactDrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uniqueOutput);
            this.Controls.Add(this.GenUnique);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.routeDistOutput);
            this.Controls.Add(this.GenRouteDist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.routeDistInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightsTable);
            this.Name = "NetworkSim";
            this.Text = "NetworkSim";
            ((System.ComponentModel.ISupportInitialize)(this.weightsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView weightsTable;
        private Label label1;
        private TextBox routeDistInput;
        private Label label2;
        private Button GenRouteDist;
        private TextBox routeDistOutput;
        private TextBox uniqueOutput;
        private Button GenUnique;
        private Label label4;
        private Label label3;
        private ComboBox exactDrop;
        private ComboBox startDrop;
        private ComboBox stopDrop;
        private ComboBox numberDrop;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox stopDrop2;
        private ComboBox startDrop2;
        private Button GenShortRoute;
        private TextBox shortOutput;
    }
}