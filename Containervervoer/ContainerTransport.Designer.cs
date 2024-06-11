namespace Containervervoer
{
    partial class ContainerTransport
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
            Submit = new Button();
            normalWeightInput = new NumericUpDown();
            valuableWeightInput = new NumericUpDown();
            coolableWeightInput = new NumericUpDown();
            NormalWeightLabel = new Label();
            ValuableWeightLable = new Label();
            CoolableWeightLabel = new Label();
            groupBox1 = new GroupBox();
            BothInput = new NumericUpDown();
            BothLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            LengthInput = new NumericUpDown();
            WidthInput = new NumericUpDown();
            label1 = new Label();
            ExplenationLabel = new Label();
            ShipLayoutPanel = new FlowLayoutPanel();
            ErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)normalWeightInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valuableWeightInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coolableWeightInput).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BothInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LengthInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WidthInput).BeginInit();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.Location = new Point(132, 370);
            Submit.Name = "Submit";
            Submit.Size = new Size(133, 55);
            Submit.TabIndex = 0;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // normalWeightInput
            // 
            normalWeightInput.Location = new Point(152, 34);
            normalWeightInput.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            normalWeightInput.Name = "normalWeightInput";
            normalWeightInput.Size = new Size(113, 27);
            normalWeightInput.TabIndex = 1;
            // 
            // valuableWeightInput
            // 
            valuableWeightInput.Location = new Point(152, 78);
            valuableWeightInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            valuableWeightInput.Name = "valuableWeightInput";
            valuableWeightInput.Size = new Size(113, 27);
            valuableWeightInput.TabIndex = 2;
            // 
            // coolableWeightInput
            // 
            coolableWeightInput.Location = new Point(152, 124);
            coolableWeightInput.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            coolableWeightInput.Name = "coolableWeightInput";
            coolableWeightInput.Size = new Size(113, 27);
            coolableWeightInput.TabIndex = 3;
            // 
            // NormalWeightLabel
            // 
            NormalWeightLabel.AutoSize = true;
            NormalWeightLabel.Location = new Point(36, 36);
            NormalWeightLabel.Name = "NormalWeightLabel";
            NormalWeightLabel.Size = new Size(113, 20);
            NormalWeightLabel.TabIndex = 4;
            NormalWeightLabel.Text = "Normal Weight:";
            // 
            // ValuableWeightLable
            // 
            ValuableWeightLable.AutoSize = true;
            ValuableWeightLable.Location = new Point(29, 80);
            ValuableWeightLable.Name = "ValuableWeightLable";
            ValuableWeightLable.Size = new Size(120, 20);
            ValuableWeightLable.TabIndex = 5;
            ValuableWeightLable.Text = "Valuable Weight:";
            // 
            // CoolableWeightLabel
            // 
            CoolableWeightLabel.AutoSize = true;
            CoolableWeightLabel.Location = new Point(25, 126);
            CoolableWeightLabel.Name = "CoolableWeightLabel";
            CoolableWeightLabel.Size = new Size(123, 20);
            CoolableWeightLabel.TabIndex = 6;
            CoolableWeightLabel.Text = "Coolable Weight:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BothInput);
            groupBox1.Controls.Add(BothLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LengthInput);
            groupBox1.Controls.Add(WidthInput);
            groupBox1.Controls.Add(CoolableWeightLabel);
            groupBox1.Controls.Add(Submit);
            groupBox1.Controls.Add(ValuableWeightLable);
            groupBox1.Controls.Add(normalWeightInput);
            groupBox1.Controls.Add(NormalWeightLabel);
            groupBox1.Controls.Add(valuableWeightInput);
            groupBox1.Controls.Add(coolableWeightInput);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 453);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // BothInput
            // 
            BothInput.Location = new Point(152, 166);
            BothInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            BothInput.Name = "BothInput";
            BothInput.Size = new Size(113, 27);
            BothInput.TabIndex = 12;
            // 
            // BothLabel
            // 
            BothLabel.AutoSize = true;
            BothLabel.Location = new Point(103, 168);
            BothLabel.Name = "BothLabel";
            BothLabel.Size = new Size(43, 20);
            BothLabel.TabIndex = 11;
            BothLabel.Text = "Both:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 285);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 10;
            label3.Text = "Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 242);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Width:";
            // 
            // LengthInput
            // 
            LengthInput.Location = new Point(152, 283);
            LengthInput.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            LengthInput.Name = "LengthInput";
            LengthInput.Size = new Size(112, 27);
            LengthInput.TabIndex = 8;
            // 
            // WidthInput
            // 
            WidthInput.Location = new Point(152, 240);
            WidthInput.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            WidthInput.Name = "WidthInput";
            WidthInput.Size = new Size(113, 27);
            WidthInput.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 55);
            label1.Name = "label1";
            label1.Size = new Size(77, 38);
            label1.TabIndex = 9;
            label1.Text = "Ship:";
            // 
            // ExplenationLabel
            // 
            ExplenationLabel.AutoSize = true;
            ExplenationLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ExplenationLabel.Location = new Point(1036, 95);
            ExplenationLabel.Name = "ExplenationLabel";
            ExplenationLabel.Size = new Size(202, 100);
            ExplenationLabel.TabIndex = 10;
            ExplenationLabel.Text = "1 = Normal\r\n2 = Valuable\r\n3 = Coolable\r\n4 = Valuable + Coolable";
            // 
            // ShipLayoutPanel
            // 
            ShipLayoutPanel.AutoScroll = true;
            ShipLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ShipLayoutPanel.Location = new Point(372, 95);
            ShipLayoutPanel.Name = "ShipLayoutPanel";
            ShipLayoutPanel.Size = new Size(618, 510);
            ShipLayoutPanel.TabIndex = 11;
            ShipLayoutPanel.WrapContents = false;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(537, 26);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 38);
            ErrorLabel.TabIndex = 12;
            // 
            // ContainerTransport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 631);
            Controls.Add(ErrorLabel);
            Controls.Add(ShipLayoutPanel);
            Controls.Add(ExplenationLabel);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "ContainerTransport";
            Text = "ContainerVervoer";
            Load += ContainerTransport_Load;
            ((System.ComponentModel.ISupportInitialize)normalWeightInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)valuableWeightInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)coolableWeightInput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BothInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)LengthInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)WidthInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submit;
        private NumericUpDown normalWeightInput;
        private NumericUpDown valuableWeightInput;
        private NumericUpDown coolableWeightInput;
        private Label NormalWeightLabel;
        private Label ValuableWeightLable;
        private Label CoolableWeightLabel;
        private GroupBox groupBox1;
        private Label label1;
        private Label ExplenationLabel;
        private FlowLayoutPanel ShipLayoutPanel;
        private NumericUpDown WidthInput;
        private NumericUpDown LengthInput;
        private Label label3;
        private Label label2;
        private Label ErrorLabel;
        private NumericUpDown BothInput;
        private Label BothLabel;
    }
}
