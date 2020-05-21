namespace Assignment
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnQuery = new System.Windows.Forms.Button();
            this.CustomQueryBox = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NoviceUserBox = new System.Windows.Forms.TextBox();
            this.rbtnTop5Rnage_petrol = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Topspeed_vehicle = new System.Windows.Forms.RadioButton();
            this.rbtnTop5CarryCapacity_vehicle = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Weight_vehicle = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Range_vehicle = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Range_electric = new System.Windows.Forms.RadioButton();
            this.rbtnAvgTopspeed_vehicle = new System.Windows.Forms.RadioButton();
            this.rbtnAvgtopspeed_petrol = new System.Windows.Forms.RadioButton();
            this.rbtnAvgTopspeed_electric = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Weight_petrol = new System.Windows.Forms.RadioButton();
            this.rbtnTop5CarryCapacity_petrol = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Topspeed_petrol = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Weight_Electric = new System.Windows.Forms.RadioButton();
            this.rbtnTop5CarryCapacity_Electric = new System.Windows.Forms.RadioButton();
            this.rbtnTop5Topspeed_Electric = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnTimeDurationVehicle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(25, 65);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(167, 485);
            this.listBox.TabIndex = 15;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid.Location = new System.Drawing.Point(215, 289);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(198, 251);
            this.propertyGrid.TabIndex = 16;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(571, 50);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(72, 33);
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // CustomQueryBox
            // 
            this.CustomQueryBox.Location = new System.Drawing.Point(462, 113);
            this.CustomQueryBox.Name = "CustomQueryBox";
            this.CustomQueryBox.Size = new System.Drawing.Size(311, 20);
            this.CustomQueryBox.TabIndex = 19;
            this.CustomQueryBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(462, 159);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(340, 390);
            this.txtResult.TabIndex = 20;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(215, 65);
            this.ErrorBox.Multiline = true;
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(200, 169);
            this.ErrorBox.TabIndex = 21;
            this.ErrorBox.Text = "Error Display";
            this.ErrorBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NoviceUserBox
            // 
            this.NoviceUserBox.Location = new System.Drawing.Point(838, 12);
            this.NoviceUserBox.Multiline = true;
            this.NoviceUserBox.Name = "NoviceUserBox";
            this.NoviceUserBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoviceUserBox.Size = new System.Drawing.Size(192, 96);
            this.NoviceUserBox.TabIndex = 22;
            this.NoviceUserBox.Text = "Novice User Display ";
            this.NoviceUserBox.TextChanged += new System.EventHandler(this.NoviceUserBox_TextChanged);
            // 
            // rbtnTop5Rnage_petrol
            // 
            this.rbtnTop5Rnage_petrol.AutoSize = true;
            this.rbtnTop5Rnage_petrol.Location = new System.Drawing.Point(839, 229);
            this.rbtnTop5Rnage_petrol.Name = "rbtnTop5Rnage_petrol";
            this.rbtnTop5Rnage_petrol.Size = new System.Drawing.Size(117, 17);
            this.rbtnTop5Rnage_petrol.TabIndex = 27;
            this.rbtnTop5Rnage_petrol.TabStop = true;
            this.rbtnTop5Rnage_petrol.Text = "Top 5 Range petrol";
            this.rbtnTop5Rnage_petrol.UseVisualStyleBackColor = true;
            this.rbtnTop5Rnage_petrol.CheckedChanged += new System.EventHandler(this.rbtnTop5Rnage_petrol_CheckedChanged);
            // 
            // rbtnTop5Topspeed_vehicle
            // 
            this.rbtnTop5Topspeed_vehicle.AutoSize = true;
            this.rbtnTop5Topspeed_vehicle.Location = new System.Drawing.Point(838, 206);
            this.rbtnTop5Topspeed_vehicle.Name = "rbtnTop5Topspeed_vehicle";
            this.rbtnTop5Topspeed_vehicle.Size = new System.Drawing.Size(141, 17);
            this.rbtnTop5Topspeed_vehicle.TabIndex = 26;
            this.rbtnTop5Topspeed_vehicle.TabStop = true;
            this.rbtnTop5Topspeed_vehicle.Text = "Top 5 Topspeed vehicle";
            this.rbtnTop5Topspeed_vehicle.UseVisualStyleBackColor = true;
            this.rbtnTop5Topspeed_vehicle.CheckedChanged += new System.EventHandler(this.rbtnTop5Topspeed_vehicle_CheckedChanged);
            // 
            // rbtnTop5CarryCapacity_vehicle
            // 
            this.rbtnTop5CarryCapacity_vehicle.AutoSize = true;
            this.rbtnTop5CarryCapacity_vehicle.Location = new System.Drawing.Point(839, 183);
            this.rbtnTop5CarryCapacity_vehicle.Name = "rbtnTop5CarryCapacity_vehicle";
            this.rbtnTop5CarryCapacity_vehicle.Size = new System.Drawing.Size(161, 17);
            this.rbtnTop5CarryCapacity_vehicle.TabIndex = 25;
            this.rbtnTop5CarryCapacity_vehicle.TabStop = true;
            this.rbtnTop5CarryCapacity_vehicle.Text = "Top 5 Carry Capacity vehicle";
            this.rbtnTop5CarryCapacity_vehicle.UseVisualStyleBackColor = true;
            this.rbtnTop5CarryCapacity_vehicle.CheckedChanged += new System.EventHandler(this.rbtnTop5CarryCapacity_vehicle_CheckedChanged);
            // 
            // rbtnTop5Weight_vehicle
            // 
            this.rbtnTop5Weight_vehicle.AutoSize = true;
            this.rbtnTop5Weight_vehicle.Location = new System.Drawing.Point(838, 160);
            this.rbtnTop5Weight_vehicle.Name = "rbtnTop5Weight_vehicle";
            this.rbtnTop5Weight_vehicle.Size = new System.Drawing.Size(127, 17);
            this.rbtnTop5Weight_vehicle.TabIndex = 24;
            this.rbtnTop5Weight_vehicle.TabStop = true;
            this.rbtnTop5Weight_vehicle.Text = "Top 5 Weight vehicle";
            this.rbtnTop5Weight_vehicle.UseVisualStyleBackColor = true;
            this.rbtnTop5Weight_vehicle.CheckedChanged += new System.EventHandler(this.rbtnTop5Weight_vehicle_CheckedChanged);
            // 
            // rbtnTop5Range_vehicle
            // 
            this.rbtnTop5Range_vehicle.AutoSize = true;
            this.rbtnTop5Range_vehicle.Location = new System.Drawing.Point(838, 137);
            this.rbtnTop5Range_vehicle.Name = "rbtnTop5Range_vehicle";
            this.rbtnTop5Range_vehicle.Size = new System.Drawing.Size(125, 17);
            this.rbtnTop5Range_vehicle.TabIndex = 23;
            this.rbtnTop5Range_vehicle.TabStop = true;
            this.rbtnTop5Range_vehicle.Text = "Top 5 Range vehicle";
            this.rbtnTop5Range_vehicle.UseVisualStyleBackColor = true;
            this.rbtnTop5Range_vehicle.CheckedChanged += new System.EventHandler(this.rbtnTop5Range_vehicle_CheckedChanged);
            // 
            // rbtnTop5Range_electric
            // 
            this.rbtnTop5Range_electric.AutoSize = true;
            this.rbtnTop5Range_electric.Location = new System.Drawing.Point(839, 321);
            this.rbtnTop5Range_electric.Name = "rbtnTop5Range_electric";
            this.rbtnTop5Range_electric.Size = new System.Drawing.Size(126, 17);
            this.rbtnTop5Range_electric.TabIndex = 29;
            this.rbtnTop5Range_electric.TabStop = true;
            this.rbtnTop5Range_electric.Text = "Top 5 Range Electric";
            this.rbtnTop5Range_electric.UseVisualStyleBackColor = true;
            this.rbtnTop5Range_electric.CheckedChanged += new System.EventHandler(this.rbtnTop5Range_electric_CheckedChanged);
            // 
            // rbtnAvgTopspeed_vehicle
            // 
            this.rbtnAvgTopspeed_vehicle.AutoSize = true;
            this.rbtnAvgTopspeed_vehicle.Location = new System.Drawing.Point(839, 411);
            this.rbtnAvgTopspeed_vehicle.Name = "rbtnAvgTopspeed_vehicle";
            this.rbtnAvgTopspeed_vehicle.Size = new System.Drawing.Size(152, 17);
            this.rbtnAvgTopspeed_vehicle.TabIndex = 30;
            this.rbtnAvgTopspeed_vehicle.TabStop = true;
            this.rbtnAvgTopspeed_vehicle.Text = "Average topspeed  vehicle";
            this.rbtnAvgTopspeed_vehicle.UseVisualStyleBackColor = true;
            this.rbtnAvgTopspeed_vehicle.CheckedChanged += new System.EventHandler(this.rbtnAvgTopspeed_vehicle_CheckedChanged);
            // 
            // rbtnAvgtopspeed_petrol
            // 
            this.rbtnAvgtopspeed_petrol.AutoSize = true;
            this.rbtnAvgtopspeed_petrol.Location = new System.Drawing.Point(839, 434);
            this.rbtnAvgtopspeed_petrol.Name = "rbtnAvgtopspeed_petrol";
            this.rbtnAvgtopspeed_petrol.Size = new System.Drawing.Size(144, 17);
            this.rbtnAvgtopspeed_petrol.TabIndex = 31;
            this.rbtnAvgtopspeed_petrol.TabStop = true;
            this.rbtnAvgtopspeed_petrol.Text = "Average topspeed  petrol";
            this.rbtnAvgtopspeed_petrol.UseVisualStyleBackColor = true;
            this.rbtnAvgtopspeed_petrol.CheckedChanged += new System.EventHandler(this.rbtnAvgtopspeed_petrol_CheckedChanged);
            // 
            // rbtnAvgTopspeed_electric
            // 
            this.rbtnAvgTopspeed_electric.AutoSize = true;
            this.rbtnAvgTopspeed_electric.Location = new System.Drawing.Point(839, 457);
            this.rbtnAvgTopspeed_electric.Name = "rbtnAvgTopspeed_electric";
            this.rbtnAvgTopspeed_electric.Size = new System.Drawing.Size(152, 17);
            this.rbtnAvgTopspeed_electric.TabIndex = 32;
            this.rbtnAvgTopspeed_electric.TabStop = true;
            this.rbtnAvgTopspeed_electric.Text = "Average topspeed  electric";
            this.rbtnAvgTopspeed_electric.UseVisualStyleBackColor = true;
            this.rbtnAvgTopspeed_electric.CheckedChanged += new System.EventHandler(this.rbtnAvgTopspeed_electric_CheckedChanged);
            // 
            // rbtnTop5Weight_petrol
            // 
            this.rbtnTop5Weight_petrol.AutoSize = true;
            this.rbtnTop5Weight_petrol.Location = new System.Drawing.Point(839, 252);
            this.rbtnTop5Weight_petrol.Name = "rbtnTop5Weight_petrol";
            this.rbtnTop5Weight_petrol.Size = new System.Drawing.Size(119, 17);
            this.rbtnTop5Weight_petrol.TabIndex = 33;
            this.rbtnTop5Weight_petrol.TabStop = true;
            this.rbtnTop5Weight_petrol.Text = "Top 5 Weight petrol";
            this.rbtnTop5Weight_petrol.UseVisualStyleBackColor = true;
            this.rbtnTop5Weight_petrol.CheckedChanged += new System.EventHandler(this.rbtnTop5Weight_petrol_CheckedChanged);
            // 
            // rbtnTop5CarryCapacity_petrol
            // 
            this.rbtnTop5CarryCapacity_petrol.AutoSize = true;
            this.rbtnTop5CarryCapacity_petrol.Location = new System.Drawing.Point(838, 275);
            this.rbtnTop5CarryCapacity_petrol.Name = "rbtnTop5CarryCapacity_petrol";
            this.rbtnTop5CarryCapacity_petrol.Size = new System.Drawing.Size(153, 17);
            this.rbtnTop5CarryCapacity_petrol.TabIndex = 34;
            this.rbtnTop5CarryCapacity_petrol.TabStop = true;
            this.rbtnTop5CarryCapacity_petrol.Text = "Top 5 Carry Capacity petrol";
            this.rbtnTop5CarryCapacity_petrol.UseVisualStyleBackColor = true;
            this.rbtnTop5CarryCapacity_petrol.CheckedChanged += new System.EventHandler(this.rbtnTop5CarryCapacity_petrol_CheckedChanged);
            // 
            // rbtnTop5Topspeed_petrol
            // 
            this.rbtnTop5Topspeed_petrol.AutoSize = true;
            this.rbtnTop5Topspeed_petrol.Location = new System.Drawing.Point(839, 298);
            this.rbtnTop5Topspeed_petrol.Name = "rbtnTop5Topspeed_petrol";
            this.rbtnTop5Topspeed_petrol.Size = new System.Drawing.Size(133, 17);
            this.rbtnTop5Topspeed_petrol.TabIndex = 35;
            this.rbtnTop5Topspeed_petrol.TabStop = true;
            this.rbtnTop5Topspeed_petrol.Text = "Top 5 Topspeed petrol";
            this.rbtnTop5Topspeed_petrol.UseVisualStyleBackColor = true;
            this.rbtnTop5Topspeed_petrol.CheckedChanged += new System.EventHandler(this.rbtnTop5Topspeed_petrol_CheckedChanged);
            // 
            // rbtnTop5Weight_Electric
            // 
            this.rbtnTop5Weight_Electric.AutoSize = true;
            this.rbtnTop5Weight_Electric.Location = new System.Drawing.Point(839, 344);
            this.rbtnTop5Weight_Electric.Name = "rbtnTop5Weight_Electric";
            this.rbtnTop5Weight_Electric.Size = new System.Drawing.Size(128, 17);
            this.rbtnTop5Weight_Electric.TabIndex = 36;
            this.rbtnTop5Weight_Electric.TabStop = true;
            this.rbtnTop5Weight_Electric.Text = "Top 5 Weight Electric";
            this.rbtnTop5Weight_Electric.UseVisualStyleBackColor = true;
            this.rbtnTop5Weight_Electric.CheckedChanged += new System.EventHandler(this.rbtnTop5Weight_Electric_CheckedChanged);
            // 
            // rbtnTop5CarryCapacity_Electric
            // 
            this.rbtnTop5CarryCapacity_Electric.AutoSize = true;
            this.rbtnTop5CarryCapacity_Electric.Location = new System.Drawing.Point(839, 367);
            this.rbtnTop5CarryCapacity_Electric.Name = "rbtnTop5CarryCapacity_Electric";
            this.rbtnTop5CarryCapacity_Electric.Size = new System.Drawing.Size(159, 17);
            this.rbtnTop5CarryCapacity_Electric.TabIndex = 37;
            this.rbtnTop5CarryCapacity_Electric.TabStop = true;
            this.rbtnTop5CarryCapacity_Electric.Text = "Top 5 CarryCapacity Electric";
            this.rbtnTop5CarryCapacity_Electric.UseVisualStyleBackColor = true;
            this.rbtnTop5CarryCapacity_Electric.CheckedChanged += new System.EventHandler(this.rbtnTop5CarryCapacity_Electric_CheckedChanged);
            // 
            // rbtnTop5Topspeed_Electric
            // 
            this.rbtnTop5Topspeed_Electric.AutoSize = true;
            this.rbtnTop5Topspeed_Electric.Location = new System.Drawing.Point(839, 390);
            this.rbtnTop5Topspeed_Electric.Name = "rbtnTop5Topspeed_Electric";
            this.rbtnTop5Topspeed_Electric.Size = new System.Drawing.Size(142, 17);
            this.rbtnTop5Topspeed_Electric.TabIndex = 38;
            this.rbtnTop5Topspeed_Electric.TabStop = true;
            this.rbtnTop5Topspeed_Electric.Text = "Top 5 Topspeed Electric";
            this.rbtnTop5Topspeed_Electric.UseVisualStyleBackColor = true;
            this.rbtnTop5Topspeed_Electric.CheckedChanged += new System.EventHandler(this.rbtnTop5Topspeed_Electric_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(971, 480);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(856, 530);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(984, 530);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(981, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Topspeed";
            // 
            // rbtnTimeDurationVehicle
            // 
            this.rbtnTimeDurationVehicle.AutoSize = true;
            this.rbtnTimeDurationVehicle.Location = new System.Drawing.Point(839, 480);
            this.rbtnTimeDurationVehicle.Name = "rbtnTimeDurationVehicle";
            this.rbtnTimeDurationVehicle.Size = new System.Drawing.Size(126, 17);
            this.rbtnTimeDurationVehicle.TabIndex = 46;
            this.rbtnTimeDurationVehicle.TabStop = true;
            this.rbtnTimeDurationVehicle.Text = "Time duration vehicle";
            this.rbtnTimeDurationVehicle.UseVisualStyleBackColor = true;
            this.rbtnTimeDurationVehicle.CheckedChanged += new System.EventHandler(this.rbtnTimeDurationVehicle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 587);
            this.Controls.Add(this.rbtnTimeDurationVehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbtnTop5Topspeed_Electric);
            this.Controls.Add(this.rbtnTop5CarryCapacity_Electric);
            this.Controls.Add(this.rbtnTop5Weight_Electric);
            this.Controls.Add(this.rbtnTop5Topspeed_petrol);
            this.Controls.Add(this.rbtnTop5CarryCapacity_petrol);
            this.Controls.Add(this.rbtnTop5Weight_petrol);
            this.Controls.Add(this.rbtnAvgTopspeed_electric);
            this.Controls.Add(this.rbtnAvgtopspeed_petrol);
            this.Controls.Add(this.rbtnAvgTopspeed_vehicle);
            this.Controls.Add(this.rbtnTop5Range_electric);
            this.Controls.Add(this.rbtnTop5Rnage_petrol);
            this.Controls.Add(this.rbtnTop5Topspeed_vehicle);
            this.Controls.Add(this.rbtnTop5CarryCapacity_vehicle);
            this.Controls.Add(this.rbtnTop5Weight_vehicle);
            this.Controls.Add(this.rbtnTop5Range_vehicle);
            this.Controls.Add(this.NoviceUserBox);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.CustomQueryBox);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Autonomous Vehicle Configuration details App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox CustomQueryBox;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox NoviceUserBox;
        private System.Windows.Forms.RadioButton rbtnTop5Rnage_petrol;
        private System.Windows.Forms.RadioButton rbtnTop5Topspeed_vehicle;
        private System.Windows.Forms.RadioButton rbtnTop5CarryCapacity_vehicle;
        private System.Windows.Forms.RadioButton rbtnTop5Weight_vehicle;
        private System.Windows.Forms.RadioButton rbtnTop5Range_vehicle;
        private System.Windows.Forms.RadioButton rbtnTop5Range_electric;
        private System.Windows.Forms.RadioButton rbtnAvgTopspeed_vehicle;
        private System.Windows.Forms.RadioButton rbtnAvgtopspeed_petrol;
        private System.Windows.Forms.RadioButton rbtnAvgTopspeed_electric;
        private System.Windows.Forms.RadioButton rbtnTop5Weight_petrol;
        private System.Windows.Forms.RadioButton rbtnTop5CarryCapacity_petrol;
        private System.Windows.Forms.RadioButton rbtnTop5Topspeed_petrol;
        private System.Windows.Forms.RadioButton rbtnTop5Weight_Electric;
        private System.Windows.Forms.RadioButton rbtnTop5CarryCapacity_Electric;
        private System.Windows.Forms.RadioButton rbtnTop5Topspeed_Electric;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnTimeDurationVehicle;
    }
}

