namespace HotelApplication
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(121, 121, 121);
            label1.Location = new Point(43, 197);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 0;
            label1.Text = "DataBase Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(121, 121, 121);
            label2.Location = new Point(133, 236);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(121, 121, 121);
            label3.Location = new Point(88, 274);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(121, 121, 121);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(121, 121, 121);
            button1.Location = new Point(133, 328);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 3;
            button1.Tag = "Connect";
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 146);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 51, 51);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(121, 121, 121);
            textBox1.Location = new Point(220, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 18);
            textBox1.TabIndex = 42;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(51, 51, 51);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(121, 121, 121);
            textBox2.Location = new Point(220, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 18);
            textBox2.TabIndex = 43;
            textBox2.KeyDown += textBox1_KeyDown;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(51, 51, 51);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            textBox3.ForeColor = Color.FromArgb(121, 121, 121);
            textBox3.Location = new Point(220, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 18);
            textBox3.TabIndex = 44;
            textBox3.KeyDown += textBox1_KeyDown;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(414, 396);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(430, 435);
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(430, 435);
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
    }
}