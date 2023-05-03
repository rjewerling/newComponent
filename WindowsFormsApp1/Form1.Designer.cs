namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelTextBox1 = new WinFormsLibrary1.LabelTextBox();
            this.labelTextBox2 = new WinFormsLibrary1.LabelTextBox();
            this.labelTextBox3 = new WinFormsLibrary1.LabelTextBox();
            this.labelTextBox4 = new WinFormsLibrary1.LabelTextBox();
            this.SuspendLayout();
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(243, 83);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.SetLabelLocation = new System.Drawing.Point(0, 4);
            this.labelTextBox1.SetLabelMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox1.SetLabelSize = new System.Drawing.Size(81, 13);
            this.labelTextBox1.SetLabelValue = "Código do Item:";
            this.labelTextBox1.SetTextBoxLocation = new System.Drawing.Point(81, 1);
            this.labelTextBox1.SetTextBoxMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox1.SetTextBoxSize = new System.Drawing.Size(69, 20);
            this.labelTextBox1.Size = new System.Drawing.Size(150, 22);
            this.labelTextBox1.TabIndex = 0;
            // 
            // labelTextBox2
            // 
            this.labelTextBox2.Location = new System.Drawing.Point(243, 135);
            this.labelTextBox2.Name = "labelTextBox2";
            this.labelTextBox2.SetLabelLocation = new System.Drawing.Point(0, 4);
            this.labelTextBox2.SetLabelMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox2.SetLabelSize = new System.Drawing.Size(92, 13);
            this.labelTextBox2.SetLabelValue = "Código do cliente:";
            this.labelTextBox2.SetTextBoxLocation = new System.Drawing.Point(92, 1);
            this.labelTextBox2.SetTextBoxMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox2.SetTextBoxSize = new System.Drawing.Size(146, 20);
            this.labelTextBox2.SetTextBoxValue = "Painel aumentou de tamanho!!!";
            this.labelTextBox2.Size = new System.Drawing.Size(238, 22);
            this.labelTextBox2.TabIndex = 1;
            // 
            // labelTextBox3
            // 
            this.labelTextBox3.Location = new System.Drawing.Point(218, 217);
            this.labelTextBox3.Name = "labelTextBox3";
            this.labelTextBox3.SetLabelLocation = new System.Drawing.Point(0, 4);
            this.labelTextBox3.SetLabelMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox3.SetLabelSize = new System.Drawing.Size(38, 13);
            this.labelTextBox3.SetLabelValue = "Nome:";
            this.labelTextBox3.SetTextBoxLocation = new System.Drawing.Point(38, 1);
            this.labelTextBox3.SetTextBoxMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox3.SetTextBoxSize = new System.Drawing.Size(214, 20);
            this.labelTextBox3.Size = new System.Drawing.Size(252, 22);
            this.labelTextBox3.TabIndex = 2;
            // 
            // labelTextBox4
            // 
            this.labelTextBox4.Location = new System.Drawing.Point(221, 250);
            this.labelTextBox4.Name = "labelTextBox4";
            this.labelTextBox4.SetLabelLocation = new System.Drawing.Point(0, 4);
            this.labelTextBox4.SetLabelMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox4.SetLabelSize = new System.Drawing.Size(56, 13);
            this.labelTextBox4.SetLabelValue = "Endereço:";
            this.labelTextBox4.SetTextBoxLocation = new System.Drawing.Point(56, 1);
            this.labelTextBox4.SetTextBoxMargin = new System.Windows.Forms.Padding(0);
            this.labelTextBox4.SetTextBoxSize = new System.Drawing.Size(193, 20);
            this.labelTextBox4.Size = new System.Drawing.Size(249, 22);
            this.labelTextBox4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTextBox4);
            this.Controls.Add(this.labelTextBox3);
            this.Controls.Add(this.labelTextBox2);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsLibrary1.LabelTextBox labelTextBox1;
        private WinFormsLibrary1.LabelTextBox labelTextBox2;
        private WinFormsLibrary1.LabelTextBox labelTextBox3;
        private WinFormsLibrary1.LabelTextBox labelTextBox4;
    }
}