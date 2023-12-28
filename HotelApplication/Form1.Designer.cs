namespace HotelApplication
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSidebar = new Panel();
            panel11 = new Panel();
            hotelLogo = new PictureBox();
            panel6 = new Panel();
            employeeButton = new Button();
            panel4 = new Panel();
            serviceButton = new Button();
            panel3 = new Panel();
            listButton = new Button();
            panel5 = new Panel();
            roomsButton = new Button();
            panel1 = new Panel();
            menuToggle = new Button();
            timeSidebarOpen = new System.Windows.Forms.Timer(components);
            timeSidebarClose = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            panel9 = new Panel();
            bottomLabel = new Label();
            panel8 = new Panel();
            labelConnectTest = new Label();
            label1 = new Label();
            hotelHome = new Panel();
            pictureBox1 = new PictureBox();
            panelSidebar.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hotelLogo).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            hotelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 31, 31);
            panelSidebar.Controls.Add(panel11);
            panelSidebar.Controls.Add(panel6);
            panelSidebar.Controls.Add(panel4);
            panelSidebar.Controls.Add(panel3);
            panelSidebar.Controls.Add(panel5);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 38);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(202, 575);
            panelSidebar.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(hotelLogo);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 420);
            panel11.Name = "panel11";
            panel11.Size = new Size(202, 155);
            panel11.TabIndex = 6;
            // 
            // hotelLogo
            // 
            hotelLogo.Image = (Image)resources.GetObject("hotelLogo.Image");
            hotelLogo.Location = new Point(52, 0);
            hotelLogo.Name = "hotelLogo";
            hotelLogo.Size = new Size(87, 152);
            hotelLogo.TabIndex = 0;
            hotelLogo.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(employeeButton);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 315);
            panel6.Name = "panel6";
            panel6.Size = new Size(202, 105);
            panel6.TabIndex = 5;
            // 
            // employeeButton
            // 
            employeeButton.Anchor = AnchorStyles.Left;
            employeeButton.BackColor = Color.FromArgb(31, 31, 31);
            employeeButton.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 29);
            employeeButton.FlatAppearance.BorderSize = 0;
            employeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            employeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            employeeButton.FlatStyle = FlatStyle.Flat;
            employeeButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            employeeButton.ForeColor = Color.FromArgb(82, 82, 82);
            employeeButton.Image = (Image)resources.GetObject("employeeButton.Image");
            employeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeeButton.Location = new Point(0, 0);
            employeeButton.Name = "employeeButton";
            employeeButton.Size = new Size(202, 105);
            employeeButton.TabIndex = 1;
            employeeButton.Text = "             Employees";
            employeeButton.UseVisualStyleBackColor = false;
            employeeButton.Click += employeeButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(serviceButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 210);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 105);
            panel4.TabIndex = 4;
            // 
            // serviceButton
            // 
            serviceButton.Anchor = AnchorStyles.Left;
            serviceButton.BackColor = Color.FromArgb(31, 31, 31);
            serviceButton.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 29);
            serviceButton.FlatAppearance.BorderSize = 0;
            serviceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            serviceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            serviceButton.FlatStyle = FlatStyle.Flat;
            serviceButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            serviceButton.ForeColor = Color.FromArgb(82, 82, 82);
            serviceButton.Image = (Image)resources.GetObject("serviceButton.Image");
            serviceButton.ImageAlign = ContentAlignment.MiddleLeft;
            serviceButton.Location = new Point(0, 0);
            serviceButton.Name = "serviceButton";
            serviceButton.Size = new Size(202, 105);
            serviceButton.TabIndex = 1;
            serviceButton.Text = "      Service";
            serviceButton.UseVisualStyleBackColor = false;
            serviceButton.Click += serviceButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(listButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 105);
            panel3.TabIndex = 3;
            // 
            // listButton
            // 
            listButton.Anchor = AnchorStyles.Left;
            listButton.BackColor = Color.FromArgb(31, 31, 31);
            listButton.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 29);
            listButton.FlatAppearance.BorderSize = 0;
            listButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            listButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            listButton.FlatStyle = FlatStyle.Flat;
            listButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listButton.ForeColor = Color.FromArgb(82, 82, 82);
            listButton.Image = (Image)resources.GetObject("listButton.Image");
            listButton.ImageAlign = ContentAlignment.MiddleLeft;
            listButton.Location = new Point(0, 0);
            listButton.Name = "listButton";
            listButton.Size = new Size(202, 105);
            listButton.TabIndex = 1;
            listButton.Text = "               List";
            listButton.TextAlign = ContentAlignment.MiddleLeft;
            listButton.UseVisualStyleBackColor = false;
            listButton.Click += listButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(roomsButton);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(202, 105);
            panel5.TabIndex = 2;
            // 
            // roomsButton
            // 
            roomsButton.Anchor = AnchorStyles.Left;
            roomsButton.BackColor = Color.FromArgb(31, 31, 31);
            roomsButton.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 29);
            roomsButton.FlatAppearance.BorderSize = 0;
            roomsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            roomsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            roomsButton.FlatStyle = FlatStyle.Flat;
            roomsButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            roomsButton.ForeColor = Color.FromArgb(82, 82, 82);
            roomsButton.Image = (Image)resources.GetObject("roomsButton.Image");
            roomsButton.ImageAlign = ContentAlignment.MiddleLeft;
            roomsButton.Location = new Point(0, 0);
            roomsButton.Name = "roomsButton";
            roomsButton.Size = new Size(202, 105);
            roomsButton.TabIndex = 0;
            roomsButton.Text = "     Rooms";
            roomsButton.UseVisualStyleBackColor = false;
            roomsButton.Click += roomsButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(menuToggle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 38);
            panel1.TabIndex = 1;
            // 
            // menuToggle
            // 
            menuToggle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menuToggle.FlatAppearance.BorderSize = 0;
            menuToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
            menuToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            menuToggle.FlatStyle = FlatStyle.Flat;
            menuToggle.Image = (Image)resources.GetObject("menuToggle.Image");
            menuToggle.Location = new Point(0, 0);
            menuToggle.Name = "menuToggle";
            menuToggle.Size = new Size(75, 38);
            menuToggle.TabIndex = 0;
            menuToggle.Click += menuToggle_Click;
            // 
            // timeSidebarOpen
            // 
            timeSidebarOpen.Interval = 1;
            timeSidebarOpen.Tick += timeSidebarOpen_Tick_1;
            // 
            // timeSidebarClose
            // 
            timeSidebarClose.Interval = 1;
            timeSidebarClose.Tick += timeSidebarClose_Tick_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 31, 31);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(202, 582);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 31);
            panel2.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(31, 31, 31);
            panel9.Controls.Add(bottomLabel);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(751, 31);
            panel9.TabIndex = 1;
            // 
            // bottomLabel
            // 
            bottomLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bottomLabel.AutoSize = true;
            bottomLabel.FlatStyle = FlatStyle.Popup;
            bottomLabel.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bottomLabel.ForeColor = Color.FromArgb(82, 82, 82);
            bottomLabel.Location = new Point(295, 4);
            bottomLabel.Name = "bottomLabel";
            bottomLabel.Size = new Size(208, 27);
            bottomLabel.TabIndex = 0;
            bottomLabel.Text = "BAKY     HOTEL";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(31, 31, 31);
            panel8.Controls.Add(labelConnectTest);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(751, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(292, 31);
            panel8.TabIndex = 0;
            // 
            // labelConnectTest
            // 
            labelConnectTest.AutoSize = true;
            labelConnectTest.ForeColor = Color.FromArgb(12, 121, 121);
            labelConnectTest.Location = new Point(182, 7);
            labelConnectTest.Name = "labelConnectTest";
            labelConnectTest.Size = new Size(93, 19);
            labelConnectTest.TabIndex = 1;
            labelConnectTest.Text = "Connected";
            labelConnectTest.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(121, 121, 121);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(180, 19);
            label1.TabIndex = 0;
            label1.Text = "Database Connection:";
            // 
            // hotelHome
            // 
            hotelHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hotelHome.Controls.Add(pictureBox1);
            hotelHome.Location = new Point(72, 38);
            hotelHome.Name = "hotelHome";
            hotelHome.Size = new Size(1173, 544);
            hotelHome.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(1173, 544);
            pictureBox1.MinimumSize = new Size(1173, 544);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1173, 544);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(1245, 613);
            Controls.Add(panel2);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            Controls.Add(hotelHome);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximumSize = new Size(1261, 652);
            MinimumSize = new Size(1261, 652);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAKY HOTEL";
            Load += Form1_Load;
            panelSidebar.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hotelLogo).EndInit();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            hotelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panel1;
        private Button menuToggle;
        private System.Windows.Forms.Timer timeSidebarOpen;
        private System.Windows.Forms.Timer timeSidebarClose;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel hotelHome;
        private Button roomsButton;
        private Panel panel8;
        private Button serviceButton;
        private Button listButton;
        private Button employeeButton;
        private Panel panel9;
        private Panel panel11;
        private PictureBox hotelLogo;
        private Label bottomLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelConnectTest;
    }
}
