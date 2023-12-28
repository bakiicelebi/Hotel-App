namespace HotelApplication
{
    partial class FormListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListing));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            button3 = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(82, 82, 82);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(162, 63);
            button1.Name = "button1";
            button1.Size = new Size(136, 112);
            button1.TabIndex = 0;
            button1.Text = "List Customers";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(82, 82, 82);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(162, 236);
            button2.Name = "button2";
            button2.Size = new Size(136, 112);
            button2.TabIndex = 1;
            button2.Text = "List Employees";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(121, 121, 121);
            textBox1.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.FromArgb(51, 51, 51);
            textBox1.Location = new Point(726, 436);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "New Value";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Visible = false;
            textBox1.Click += textBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(781, 344);
            dataGridView1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(121, 121, 121);
            comboBox1.ForeColor = Color.FromArgb(51, 51, 51);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(519, 411);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 27);
            comboBox1.TabIndex = 4;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(936, 432);
            button3.Name = "button3";
            button3.Size = new Size(153, 33);
            button3.TabIndex = 5;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(121, 121, 121);
            comboBox2.ForeColor = Color.FromArgb(51, 51, 51);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(519, 461);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 27);
            comboBox2.TabIndex = 6;
            comboBox2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 414);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 7;
            label1.Text = "Change";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 464);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 8;
            label2.Text = "Where";
            label2.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(726, 436);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 26);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Visible = false;
            // 
            // FormListing
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(1173, 544);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(121, 121, 121);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximumSize = new Size(1173, 544);
            MinimumSize = new Size(1173, 544);
            Name = "FormListing";
            Text = "Listing";
            Load += FormListing_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button3;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}