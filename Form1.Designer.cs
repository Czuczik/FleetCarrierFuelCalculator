namespace FleetCarrierFuelCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            plannedJRLabel = new Label();
            plannedJRBar = new TrackBar();
            label3 = new Label();
            label5 = new Label();
            comsOnBoardTB1 = new TextBox();
            calcButton1 = new Button();
            tritNeedFJBox = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            PlannedJRTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)plannedJRBar).BeginInit();
            SuspendLayout();
            // 
            // plannedJRLabel
            // 
            plannedJRLabel.Location = new Point(30, 34);
            plannedJRLabel.Name = "plannedJRLabel";
            plannedJRLabel.Size = new Size(170, 29);
            plannedJRLabel.TabIndex = 8;
            plannedJRLabel.Text = "Planned Jump Range";
            plannedJRLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plannedJRBar
            // 
            plannedJRBar.AutoSize = false;
            plannedJRBar.Cursor = Cursors.SizeWE;
            plannedJRBar.Location = new Point(222, 34);
            plannedJRBar.Maximum = 500;
            plannedJRBar.Name = "plannedJRBar";
            plannedJRBar.Size = new Size(238, 29);
            plannedJRBar.TabIndex = 1;
            plannedJRBar.TickStyle = TickStyle.None;
            plannedJRBar.Value = 250;
            plannedJRBar.Scroll += plannedJRBar_Scroll;
            // 
            // label3
            // 
            label3.Location = new Point(30, 91);
            label3.Name = "label3";
            label3.Size = new Size(170, 29);
            label3.TabIndex = 9;
            label3.Text = "Commodities on board";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(123, 269);
            label5.Name = "label5";
            label5.Size = new Size(199, 29);
            label5.TabIndex = 6;
            label5.Text = "Tritium needed for jump:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comsOnBoardTB1
            // 
            comsOnBoardTB1.Location = new Point(222, 91);
            comsOnBoardTB1.Name = "comsOnBoardTB1";
            comsOnBoardTB1.Size = new Size(100, 29);
            comsOnBoardTB1.TabIndex = 3;
            comsOnBoardTB1.Text = "0";
            comsOnBoardTB1.TextAlign = HorizontalAlignment.Center;
            // 
            // calcButton1
            // 
            calcButton1.Location = new Point(123, 223);
            calcButton1.Name = "calcButton1";
            calcButton1.Size = new Size(325, 29);
            calcButton1.TabIndex = 5;
            calcButton1.Text = "CALCULATE TRITIUM CONSUMPTION";
            calcButton1.UseVisualStyleBackColor = true;
            calcButton1.Click += calcButton1_Click;
            // 
            // tritNeedFJBox
            // 
            tritNeedFJBox.Location = new Point(328, 269);
            tritNeedFJBox.Name = "tritNeedFJBox";
            tritNeedFJBox.Size = new Size(120, 29);
            tritNeedFJBox.TabIndex = 7;
            tritNeedFJBox.Text = "0";
            tritNeedFJBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(30, 149);
            label1.Name = "label1";
            label1.Size = new Size(170, 29);
            label1.TabIndex = 10;
            label1.Text = "Tritium Deposit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 4;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PlannedJRTB
            // 
            PlannedJRTB.Location = new Point(480, 34);
            PlannedJRTB.Name = "PlannedJRTB";
            PlannedJRTB.Size = new Size(50, 29);
            PlannedJRTB.TabIndex = 2;
            PlannedJRTB.Text = "250";
            PlannedJRTB.TextAlign = HorizontalAlignment.Center;
            PlannedJRTB.TextChanged += PlannedJRTB_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 357);
            Controls.Add(PlannedJRTB);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(tritNeedFJBox);
            Controls.Add(calcButton1);
            Controls.Add(comsOnBoardTB1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(plannedJRBar);
            Controls.Add(plannedJRLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Fleet Carrier Fuel Calculator";
            ((System.ComponentModel.ISupportInitialize)plannedJRBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label plannedJRLabel;
        private TrackBar plannedJRBar;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox comsOnBoardTB1;
        private TextBox PlannedJRTB;
        private Button calcButton1;
        private Label tritNeedFJBox;
        private Label label1;
        private TextBox textBox1;
    }
}