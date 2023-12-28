namespace HotelApplication
{
    partial class FormEmployeePop
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(668, 279);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(121, 121, 121);
            label1.Location = new Point(190, 12);
            label1.MinimumSize = new Size(300, 30);
            label1.Name = "label1";
            label1.Size = new Size(300, 30);
            label1.TabIndex = 1;
            label1.Text = " Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEmployeePop
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(692, 346);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(708, 385);
            MinimumSize = new Size(708, 385);
            Name = "FormEmployeePop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Info";
            Load += FormEmployeePop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        public Label label1;
    }
}