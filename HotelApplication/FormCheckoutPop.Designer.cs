namespace HotelApplication
{
    partial class FormCheckoutPop
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(51, 51, 51);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 27);
            comboBox1.TabIndex = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(121, 121, 121);
            label1.Location = new Point(95, 35);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 89;
            label1.Text = "Checkout Room";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(41, 41, 41);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(122, 122, 122);
            button2.Location = new Point(95, 199);
            button2.Name = "button2";
            button2.Size = new Size(133, 57);
            button2.TabIndex = 90;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormCheckoutPop
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(319, 297);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FormCheckoutPop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dele";
            Load += FormCheckoutPop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Button button2;
    }
}