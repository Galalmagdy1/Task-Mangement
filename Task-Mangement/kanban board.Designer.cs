namespace Task_Mangement
{
    partial class kanban_board
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar Controls
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavProjects;
        private System.Windows.Forms.Button btnNavKanban;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavNotifications;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserEmail;

        // Main Area & Header Controls
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSub;
        private System.Windows.Forms.Label lblProjectFilter;
        private System.Windows.Forms.ComboBox cmbProjects;

        // Column 1: To Do
        private System.Windows.Forms.Panel pnlColTodo;
        private System.Windows.Forms.Label lblTodoDot;
        private System.Windows.Forms.Label lblTodoTitle;
        private System.Windows.Forms.Label lblTodoCount;
        private System.Windows.Forms.FlowLayoutPanel flpTodo;

        // Column 2: In Progress
        private System.Windows.Forms.Panel pnlColProgress;
        private System.Windows.Forms.Label lblProgDot;
        private System.Windows.Forms.Label lblProgTitle;
        private System.Windows.Forms.Label lblProgCount;
        private System.Windows.Forms.FlowLayoutPanel flpProgress;

        // Column 3: Done
        private System.Windows.Forms.Panel pnlColDone;
        private System.Windows.Forms.Label lblDoneDot;
        private System.Windows.Forms.Label lblDoneTitle;
        private System.Windows.Forms.Label lblDoneCount;
        private System.Windows.Forms.FlowLayoutPanel flpDone;

        // Cards (1 to 8)
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Panel c1Stripe;
        private System.Windows.Forms.Label c1Title;
        private System.Windows.Forms.Label c1Badge;
        private System.Windows.Forms.Label c1Due;
        private System.Windows.Forms.Label c1Avatar;

        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Panel c2Stripe;
        private System.Windows.Forms.Label c2Title;
        private System.Windows.Forms.Label c2Badge;
        private System.Windows.Forms.Label c2Due;
        private System.Windows.Forms.Label c2Avatar;

        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Panel c3Stripe;
        private System.Windows.Forms.Label c3Title;
        private System.Windows.Forms.Label c3Badge;
        private System.Windows.Forms.Label c3Due;
        private System.Windows.Forms.Label c3Avatar;

        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Panel c4Stripe;
        private System.Windows.Forms.Label c4Title;
        private System.Windows.Forms.Label c4Badge;
        private System.Windows.Forms.Label c4Due;
        private System.Windows.Forms.Label c4Avatar;

        private System.Windows.Forms.Panel card5;
        private System.Windows.Forms.Panel c5Stripe;
        private System.Windows.Forms.Label c5Title;
        private System.Windows.Forms.Label c5Badge;
        private System.Windows.Forms.Label c5Due;
        private System.Windows.Forms.Label c5Avatar;

        private System.Windows.Forms.Panel card6;
        private System.Windows.Forms.Panel c6Stripe;
        private System.Windows.Forms.Label c6Title;
        private System.Windows.Forms.Label c6Badge;
        private System.Windows.Forms.Label c6Due;
        private System.Windows.Forms.Label c6Avatar;

        private System.Windows.Forms.Panel card7;
        private System.Windows.Forms.Panel c7Stripe;
        private System.Windows.Forms.Label c7Title;
        private System.Windows.Forms.Label c7Badge;
        private System.Windows.Forms.Label c7Due;
        private System.Windows.Forms.Label c7Avatar;

        private System.Windows.Forms.Panel card8;
        private System.Windows.Forms.Panel c8Stripe;
        private System.Windows.Forms.Label c8Title;
        private System.Windows.Forms.Label c8Badge;
        private System.Windows.Forms.Label c8Due;
        private System.Windows.Forms.Label c8Avatar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnNavNotifications = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavKanban = new System.Windows.Forms.Button();
            this.btnNavProjects = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlColDone = new System.Windows.Forms.Panel();
            this.flpDone = new System.Windows.Forms.FlowLayoutPanel();
            this.card7 = new System.Windows.Forms.Panel();
            this.c7Avatar = new System.Windows.Forms.Label();
            this.c7Due = new System.Windows.Forms.Label();
            this.c7Badge = new System.Windows.Forms.Label();
            this.c7Title = new System.Windows.Forms.Label();
            this.c7Stripe = new System.Windows.Forms.Panel();
            this.card8 = new System.Windows.Forms.Panel();
            this.c8Avatar = new System.Windows.Forms.Label();
            this.c8Due = new System.Windows.Forms.Label();
            this.c8Badge = new System.Windows.Forms.Label();
            this.c8Title = new System.Windows.Forms.Label();
            this.c8Stripe = new System.Windows.Forms.Panel();
            this.lblDoneCount = new System.Windows.Forms.Label();
            this.lblDoneTitle = new System.Windows.Forms.Label();
            this.lblDoneDot = new System.Windows.Forms.Label();
            this.pnlColProgress = new System.Windows.Forms.Panel();
            this.flpProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.card5 = new System.Windows.Forms.Panel();
            this.c5Avatar = new System.Windows.Forms.Label();
            this.c5Due = new System.Windows.Forms.Label();
            this.c5Badge = new System.Windows.Forms.Label();
            this.c5Title = new System.Windows.Forms.Label();
            this.c5Stripe = new System.Windows.Forms.Panel();
            this.card6 = new System.Windows.Forms.Panel();
            this.c6Avatar = new System.Windows.Forms.Label();
            this.c6Due = new System.Windows.Forms.Label();
            this.c6Badge = new System.Windows.Forms.Label();
            this.c6Title = new System.Windows.Forms.Label();
            this.c6Stripe = new System.Windows.Forms.Panel();
            this.lblProgCount = new System.Windows.Forms.Label();
            this.lblProgTitle = new System.Windows.Forms.Label();
            this.lblProgDot = new System.Windows.Forms.Label();
            this.pnlColTodo = new System.Windows.Forms.Panel();
            this.flpTodo = new System.Windows.Forms.FlowLayoutPanel();
            this.card1 = new System.Windows.Forms.Panel();
            this.c1Avatar = new System.Windows.Forms.Label();
            this.c1Due = new System.Windows.Forms.Label();
            this.c1Badge = new System.Windows.Forms.Label();
            this.c1Title = new System.Windows.Forms.Label();
            this.c1Stripe = new System.Windows.Forms.Panel();
            this.card2 = new System.Windows.Forms.Panel();
            this.c2Avatar = new System.Windows.Forms.Label();
            this.c2Due = new System.Windows.Forms.Label();
            this.c2Badge = new System.Windows.Forms.Label();
            this.c2Title = new System.Windows.Forms.Label();
            this.c2Stripe = new System.Windows.Forms.Panel();
            this.card3 = new System.Windows.Forms.Panel();
            this.c3Avatar = new System.Windows.Forms.Label();
            this.c3Due = new System.Windows.Forms.Label();
            this.c3Badge = new System.Windows.Forms.Label();
            this.c3Title = new System.Windows.Forms.Label();
            this.c3Stripe = new System.Windows.Forms.Panel();
            this.card4 = new System.Windows.Forms.Panel();
            this.c4Avatar = new System.Windows.Forms.Label();
            this.c4Due = new System.Windows.Forms.Label();
            this.c4Badge = new System.Windows.Forms.Label();
            this.c4Title = new System.Windows.Forms.Label();
            this.c4Stripe = new System.Windows.Forms.Panel();
            this.lblTodoCount = new System.Windows.Forms.Label();
            this.lblTodoTitle = new System.Windows.Forms.Label();
            this.lblTodoDot = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.lblProjectFilter = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlColDone.SuspendLayout();
            this.flpDone.SuspendLayout();
            this.card7.SuspendLayout();
            this.card8.SuspendLayout();
            this.pnlColProgress.SuspendLayout();
            this.flpProgress.SuspendLayout();
            this.card5.SuspendLayout();
            this.card6.SuspendLayout();
            this.pnlColTodo.SuspendLayout();
            this.flpTodo.SuspendLayout();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.card3.SuspendLayout();
            this.card4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.pnlSidebar.Controls.Add(this.lblUserEmail);
            this.pnlSidebar.Controls.Add(this.lblUserName);
            this.pnlSidebar.Controls.Add(this.lblConnection);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavNotifications);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavKanban);
            this.pnlSidebar.Controls.Add(this.btnNavProjects);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.lblAppTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 760);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblUserEmail.Location = new System.Drawing.Point(20, 715);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(168, 15);
            this.lblUserEmail.TabIndex = 0;
            this.lblUserEmail.Text = "Owner · yousef@example.com";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(20, 690);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 19);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Yousef";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblConnection.Location = new System.Drawing.Point(20, 665);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(156, 15);
            this.lblConnection.TabIndex = 2;
            this.lblConnection.Text = "● Connected · 127.0.0.1:5000";
            // 
            // btnNavProfile
            // 
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.btnNavProfile.FlatAppearance.BorderSize = 0;
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnNavProfile.Location = new System.Drawing.Point(12, 305);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(196, 38);
            this.btnNavProfile.TabIndex = 3;
            this.btnNavProfile.Text = "  •  Profile";
            this.btnNavProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfile.UseVisualStyleBackColor = false;
            // 
            // btnNavNotifications
            // 
            this.btnNavNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.btnNavNotifications.FlatAppearance.BorderSize = 0;
            this.btnNavNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNotifications.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnNavNotifications.Location = new System.Drawing.Point(12, 260);
            this.btnNavNotifications.Name = "btnNavNotifications";
            this.btnNavNotifications.Size = new System.Drawing.Size(196, 38);
            this.btnNavNotifications.TabIndex = 4;
            this.btnNavNotifications.Text = "  •  Notifications          3";
            this.btnNavNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavNotifications.UseVisualStyleBackColor = false;
            // 
            // btnNavReports
            // 
            this.btnNavReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnNavReports.Location = new System.Drawing.Point(12, 215);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(196, 38);
            this.btnNavReports.TabIndex = 5;
            this.btnNavReports.Text = "  •  Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.UseVisualStyleBackColor = false;
            // 
            // btnNavKanban
            // 
            this.btnNavKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNavKanban.FlatAppearance.BorderSize = 0;
            this.btnNavKanban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKanban.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavKanban.ForeColor = System.Drawing.Color.White;
            this.btnNavKanban.Location = new System.Drawing.Point(12, 170);
            this.btnNavKanban.Name = "btnNavKanban";
            this.btnNavKanban.Size = new System.Drawing.Size(196, 38);
            this.btnNavKanban.TabIndex = 6;
            this.btnNavKanban.Text = "  •  Kanban board";
            this.btnNavKanban.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavKanban.UseVisualStyleBackColor = false;
            // 
            // btnNavProjects
            // 
            this.btnNavProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.btnNavProjects.FlatAppearance.BorderSize = 0;
            this.btnNavProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProjects.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnNavProjects.Location = new System.Drawing.Point(12, 125);
            this.btnNavProjects.Name = "btnNavProjects";
            this.btnNavProjects.Size = new System.Drawing.Size(196, 38);
            this.btnNavProjects.TabIndex = 7;
            this.btnNavProjects.Text = "  •  Projects";
            this.btnNavProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProjects.UseVisualStyleBackColor = false;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnNavDashboard.Location = new System.Drawing.Point(12, 80);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(196, 38);
            this.btnNavDashboard.TabIndex = 8;
            this.btnNavDashboard.Text = "  •  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click_1);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 25);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(135, 25);
            this.lblAppTitle.TabIndex = 9;
            this.lblAppTitle.Text = "Task Manager";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMain.Controls.Add(this.pnlColDone);
            this.pnlMain.Controls.Add(this.pnlColProgress);
            this.pnlMain.Controls.Add(this.pnlColTodo);
            this.pnlMain.Controls.Add(this.cmbProjects);
            this.pnlMain.Controls.Add(this.lblProjectFilter);
            this.pnlMain.Controls.Add(this.lblPageSub);
            this.pnlMain.Controls.Add(this.lblPageTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 760);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlColDone
            // 
            this.pnlColDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlColDone.Controls.Add(this.flpDone);
            this.pnlColDone.Controls.Add(this.lblDoneCount);
            this.pnlColDone.Controls.Add(this.lblDoneTitle);
            this.pnlColDone.Controls.Add(this.lblDoneDot);
            this.pnlColDone.Location = new System.Drawing.Point(654, 105);
            this.pnlColDone.Name = "pnlColDone";
            this.pnlColDone.Size = new System.Drawing.Size(295, 625);
            this.pnlColDone.TabIndex = 0;
            // 
            // flpDone
            // 
            this.flpDone.AutoScroll = true;
            this.flpDone.Controls.Add(this.card7);
            this.flpDone.Controls.Add(this.card8);
            this.flpDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDone.Location = new System.Drawing.Point(12, 50);
            this.flpDone.Name = "flpDone";
            this.flpDone.Size = new System.Drawing.Size(271, 560);
            this.flpDone.TabIndex = 0;
            this.flpDone.WrapContents = false;
            // 
            // card7
            // 
            this.card7.BackColor = System.Drawing.Color.White;
            this.card7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card7.Controls.Add(this.c7Avatar);
            this.card7.Controls.Add(this.c7Due);
            this.card7.Controls.Add(this.c7Badge);
            this.card7.Controls.Add(this.c7Title);
            this.card7.Controls.Add(this.c7Stripe);
            this.card7.Location = new System.Drawing.Point(0, 0);
            this.card7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(268, 92);
            this.card7.TabIndex = 0;
            // 
            // c7Avatar
            // 
            this.c7Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c7Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c7Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c7Avatar.Location = new System.Drawing.Point(228, 48);
            this.c7Avatar.Name = "c7Avatar";
            this.c7Avatar.Size = new System.Drawing.Size(26, 26);
            this.c7Avatar.TabIndex = 0;
            this.c7Avatar.Text = "S";
            this.c7Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c7Due
            // 
            this.c7Due.AutoSize = true;
            this.c7Due.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c7Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c7Due.Location = new System.Drawing.Point(68, 54);
            this.c7Due.Name = "c7Due";
            this.c7Due.Size = new System.Drawing.Size(65, 15);
            this.c7Due.TabIndex = 1;
            this.c7Due.Text = "Due Oct 28";
            // 
            // c7Badge
            // 
            this.c7Badge.AutoSize = true;
            this.c7Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.c7Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c7Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(65)))), ((int)(((byte)(12)))));
            this.c7Badge.Location = new System.Drawing.Point(16, 52);
            this.c7Badge.Name = "c7Badge";
            this.c7Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c7Badge.Size = new System.Drawing.Size(41, 17);
            this.c7Badge.TabIndex = 2;
            this.c7Badge.Text = "High";
            // 
            // c7Title
            // 
            this.c7Title.AutoSize = true;
            this.c7Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c7Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c7Title.Location = new System.Drawing.Point(16, 14);
            this.c7Title.Name = "c7Title";
            this.c7Title.Size = new System.Drawing.Size(122, 17);
            this.c7Title.TabIndex = 3;
            this.c7Title.Text = "Design ER diagram";
            // 
            // c7Stripe
            // 
            this.c7Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.c7Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c7Stripe.Location = new System.Drawing.Point(0, 0);
            this.c7Stripe.Name = "c7Stripe";
            this.c7Stripe.Size = new System.Drawing.Size(4, 90);
            this.c7Stripe.TabIndex = 4;
            // 
            // card8
            // 
            this.card8.BackColor = System.Drawing.Color.White;
            this.card8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card8.Controls.Add(this.c8Avatar);
            this.card8.Controls.Add(this.c8Due);
            this.card8.Controls.Add(this.c8Badge);
            this.card8.Controls.Add(this.c8Title);
            this.card8.Controls.Add(this.c8Stripe);
            this.card8.Location = new System.Drawing.Point(0, 104);
            this.card8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(268, 92);
            this.card8.TabIndex = 1;
            // 
            // c8Avatar
            // 
            this.c8Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c8Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c8Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c8Avatar.Location = new System.Drawing.Point(228, 48);
            this.c8Avatar.Name = "c8Avatar";
            this.c8Avatar.Size = new System.Drawing.Size(26, 26);
            this.c8Avatar.TabIndex = 0;
            this.c8Avatar.Text = "M";
            this.c8Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c8Due
            // 
            this.c8Due.AutoSize = true;
            this.c8Due.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c8Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c8Due.Location = new System.Drawing.Point(82, 54);
            this.c8Due.Name = "c8Due";
            this.c8Due.Size = new System.Drawing.Size(65, 15);
            this.c8Due.TabIndex = 1;
            this.c8Due.Text = "Due Oct 27";
            // 
            // c8Badge
            // 
            this.c8Badge.AutoSize = true;
            this.c8Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.c8Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c8Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.c8Badge.Location = new System.Drawing.Point(16, 52);
            this.c8Badge.Name = "c8Badge";
            this.c8Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c8Badge.Size = new System.Drawing.Size(59, 17);
            this.c8Badge.TabIndex = 2;
            this.c8Badge.Text = "Medium";
            // 
            // c8Title
            // 
            this.c8Title.AutoSize = true;
            this.c8Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c8Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c8Title.Location = new System.Drawing.Point(16, 14);
            this.c8Title.Name = "c8Title";
            this.c8Title.Size = new System.Drawing.Size(105, 17);
            this.c8Title.TabIndex = 3;
            this.c8Title.Text = "Build login form";
            // 
            // c8Stripe
            // 
            this.c8Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.c8Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c8Stripe.Location = new System.Drawing.Point(0, 0);
            this.c8Stripe.Name = "c8Stripe";
            this.c8Stripe.Size = new System.Drawing.Size(4, 90);
            this.c8Stripe.TabIndex = 4;
            // 
            // lblDoneCount
            // 
            this.lblDoneCount.BackColor = System.Drawing.Color.White;
            this.lblDoneCount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDoneCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDoneCount.Location = new System.Drawing.Point(255, 14);
            this.lblDoneCount.Name = "lblDoneCount";
            this.lblDoneCount.Size = new System.Drawing.Size(24, 22);
            this.lblDoneCount.TabIndex = 1;
            this.lblDoneCount.Text = "2";
            this.lblDoneCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoneTitle
            // 
            this.lblDoneTitle.AutoSize = true;
            this.lblDoneTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDoneTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblDoneTitle.Location = new System.Drawing.Point(34, 15);
            this.lblDoneTitle.Name = "lblDoneTitle";
            this.lblDoneTitle.Size = new System.Drawing.Size(44, 19);
            this.lblDoneTitle.TabIndex = 2;
            this.lblDoneTitle.Text = "Done";
            // 
            // lblDoneDot
            // 
            this.lblDoneDot.AutoSize = true;
            this.lblDoneDot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoneDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblDoneDot.Location = new System.Drawing.Point(14, 15);
            this.lblDoneDot.Name = "lblDoneDot";
            this.lblDoneDot.Size = new System.Drawing.Size(17, 19);
            this.lblDoneDot.TabIndex = 3;
            this.lblDoneDot.Text = "●";
            // 
            // pnlColProgress
            // 
            this.pnlColProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlColProgress.Controls.Add(this.flpProgress);
            this.pnlColProgress.Controls.Add(this.lblProgCount);
            this.pnlColProgress.Controls.Add(this.lblProgTitle);
            this.pnlColProgress.Controls.Add(this.lblProgDot);
            this.pnlColProgress.Location = new System.Drawing.Point(342, 105);
            this.pnlColProgress.Name = "pnlColProgress";
            this.pnlColProgress.Size = new System.Drawing.Size(295, 625);
            this.pnlColProgress.TabIndex = 1;
            // 
            // flpProgress
            // 
            this.flpProgress.AutoScroll = true;
            this.flpProgress.Controls.Add(this.card5);
            this.flpProgress.Controls.Add(this.card6);
            this.flpProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProgress.Location = new System.Drawing.Point(12, 50);
            this.flpProgress.Name = "flpProgress";
            this.flpProgress.Size = new System.Drawing.Size(271, 560);
            this.flpProgress.TabIndex = 0;
            this.flpProgress.WrapContents = false;
            // 
            // card5
            // 
            this.card5.BackColor = System.Drawing.Color.White;
            this.card5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card5.Controls.Add(this.c5Avatar);
            this.card5.Controls.Add(this.c5Due);
            this.card5.Controls.Add(this.c5Badge);
            this.card5.Controls.Add(this.c5Title);
            this.card5.Controls.Add(this.c5Stripe);
            this.card5.Location = new System.Drawing.Point(0, 0);
            this.card5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(268, 92);
            this.card5.TabIndex = 0;
            // 
            // c5Avatar
            // 
            this.c5Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c5Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c5Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c5Avatar.Location = new System.Drawing.Point(228, 48);
            this.c5Avatar.Name = "c5Avatar";
            this.c5Avatar.Size = new System.Drawing.Size(26, 26);
            this.c5Avatar.TabIndex = 0;
            this.c5Avatar.Text = "A";
            this.c5Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c5Due
            // 
            this.c5Due.AutoSize = true;
            this.c5Due.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c5Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.c5Due.Location = new System.Drawing.Point(76, 54);
            this.c5Due.Name = "c5Due";
            this.c5Due.Size = new System.Drawing.Size(70, 15);
            this.c5Due.TabIndex = 1;
            this.c5Due.Text = "Due Oct 29";
            // 
            // c5Badge
            // 
            this.c5Badge.AutoSize = true;
            this.c5Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.c5Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c5Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.c5Badge.Location = new System.Drawing.Point(16, 52);
            this.c5Badge.Name = "c5Badge";
            this.c5Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c5Badge.Size = new System.Drawing.Size(52, 17);
            this.c5Badge.TabIndex = 2;
            this.c5Badge.Text = "Urgent";
            // 
            // c5Title
            // 
            this.c5Title.AutoSize = true;
            this.c5Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c5Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c5Title.Location = new System.Drawing.Point(16, 14);
            this.c5Title.Name = "c5Title";
            this.c5Title.Size = new System.Drawing.Size(111, 17);
            this.c5Title.TabIndex = 3;
            this.c5Title.Text = "Create SQL script";
            // 
            // c5Stripe
            // 
            this.c5Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c5Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c5Stripe.Location = new System.Drawing.Point(0, 0);
            this.c5Stripe.Name = "c5Stripe";
            this.c5Stripe.Size = new System.Drawing.Size(4, 90);
            this.c5Stripe.TabIndex = 4;
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.Color.White;
            this.card6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card6.Controls.Add(this.c6Avatar);
            this.card6.Controls.Add(this.c6Due);
            this.card6.Controls.Add(this.c6Badge);
            this.card6.Controls.Add(this.c6Title);
            this.card6.Controls.Add(this.c6Stripe);
            this.card6.Location = new System.Drawing.Point(0, 104);
            this.card6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(268, 92);
            this.card6.TabIndex = 1;
            // 
            // c6Avatar
            // 
            this.c6Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c6Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c6Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c6Avatar.Location = new System.Drawing.Point(228, 48);
            this.c6Avatar.Name = "c6Avatar";
            this.c6Avatar.Size = new System.Drawing.Size(26, 26);
            this.c6Avatar.TabIndex = 0;
            this.c6Avatar.Text = "Y";
            this.c6Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c6Due
            // 
            this.c6Due.AutoSize = true;
            this.c6Due.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c6Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c6Due.Location = new System.Drawing.Point(68, 54);
            this.c6Due.Name = "c6Due";
            this.c6Due.Size = new System.Drawing.Size(62, 15);
            this.c6Due.TabIndex = 1;
            this.c6Due.Text = "Due Nov 3";
            // 
            // c6Badge
            // 
            this.c6Badge.AutoSize = true;
            this.c6Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.c6Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c6Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(65)))), ((int)(((byte)(12)))));
            this.c6Badge.Location = new System.Drawing.Point(16, 52);
            this.c6Badge.Name = "c6Badge";
            this.c6Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c6Badge.Size = new System.Drawing.Size(41, 17);
            this.c6Badge.TabIndex = 2;
            this.c6Badge.Text = "High";
            // 
            // c6Title
            // 
            this.c6Title.AutoSize = true;
            this.c6Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c6Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c6Title.Location = new System.Drawing.Point(16, 14);
            this.c6Title.Name = "c6Title";
            this.c6Title.Size = new System.Drawing.Size(142, 17);
            this.c6Title.TabIndex = 3;
            this.c6Title.Text = "Implement TCP server";
            // 
            // c6Stripe
            // 
            this.c6Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.c6Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c6Stripe.Location = new System.Drawing.Point(0, 0);
            this.c6Stripe.Name = "c6Stripe";
            this.c6Stripe.Size = new System.Drawing.Size(4, 90);
            this.c6Stripe.TabIndex = 4;
            // 
            // lblProgCount
            // 
            this.lblProgCount.BackColor = System.Drawing.Color.White;
            this.lblProgCount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProgCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblProgCount.Location = new System.Drawing.Point(255, 14);
            this.lblProgCount.Name = "lblProgCount";
            this.lblProgCount.Size = new System.Drawing.Size(24, 22);
            this.lblProgCount.TabIndex = 1;
            this.lblProgCount.Text = "2";
            this.lblProgCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgTitle
            // 
            this.lblProgTitle.AutoSize = true;
            this.lblProgTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblProgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblProgTitle.Location = new System.Drawing.Point(34, 15);
            this.lblProgTitle.Name = "lblProgTitle";
            this.lblProgTitle.Size = new System.Drawing.Size(84, 19);
            this.lblProgTitle.TabIndex = 2;
            this.lblProgTitle.Text = "In progress";
            // 
            // lblProgDot
            // 
            this.lblProgDot.AutoSize = true;
            this.lblProgDot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProgDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblProgDot.Location = new System.Drawing.Point(14, 15);
            this.lblProgDot.Name = "lblProgDot";
            this.lblProgDot.Size = new System.Drawing.Size(17, 19);
            this.lblProgDot.TabIndex = 3;
            this.lblProgDot.Text = "●";
            // 
            // pnlColTodo
            // 
            this.pnlColTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlColTodo.Controls.Add(this.flpTodo);
            this.pnlColTodo.Controls.Add(this.lblTodoCount);
            this.pnlColTodo.Controls.Add(this.lblTodoTitle);
            this.pnlColTodo.Controls.Add(this.lblTodoDot);
            this.pnlColTodo.Location = new System.Drawing.Point(30, 105);
            this.pnlColTodo.Name = "pnlColTodo";
            this.pnlColTodo.Size = new System.Drawing.Size(295, 625);
            this.pnlColTodo.TabIndex = 2;
            // 
            // flpTodo
            // 
            this.flpTodo.AutoScroll = true;
            this.flpTodo.Controls.Add(this.card1);
            this.flpTodo.Controls.Add(this.card2);
            this.flpTodo.Controls.Add(this.card3);
            this.flpTodo.Controls.Add(this.card4);
            this.flpTodo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTodo.Location = new System.Drawing.Point(12, 50);
            this.flpTodo.Name = "flpTodo";
            this.flpTodo.Size = new System.Drawing.Size(271, 560);
            this.flpTodo.TabIndex = 0;
            this.flpTodo.WrapContents = false;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Controls.Add(this.c1Avatar);
            this.card1.Controls.Add(this.c1Due);
            this.card1.Controls.Add(this.c1Badge);
            this.card1.Controls.Add(this.c1Title);
            this.card1.Controls.Add(this.c1Stripe);
            this.card1.Location = new System.Drawing.Point(0, 0);
            this.card1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(268, 92);
            this.card1.TabIndex = 0;
            this.card1.Paint += new System.Windows.Forms.PaintEventHandler(this.card1_Paint);
            // 
            // c1Avatar
            // 
            this.c1Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c1Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c1Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c1Avatar.Location = new System.Drawing.Point(228, 48);
            this.c1Avatar.Name = "c1Avatar";
            this.c1Avatar.Size = new System.Drawing.Size(26, 26);
            this.c1Avatar.TabIndex = 0;
            this.c1Avatar.Text = "S";
            this.c1Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1Due
            // 
            this.c1Due.AutoSize = true;
            this.c1Due.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c1Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c1Due.Location = new System.Drawing.Point(82, 54);
            this.c1Due.Name = "c1Due";
            this.c1Due.Size = new System.Drawing.Size(62, 15);
            this.c1Due.TabIndex = 1;
            this.c1Due.Text = "Due Nov 5";
            // 
            // c1Badge
            // 
            this.c1Badge.AutoSize = true;
            this.c1Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.c1Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c1Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.c1Badge.Location = new System.Drawing.Point(16, 52);
            this.c1Badge.Name = "c1Badge";
            this.c1Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c1Badge.Size = new System.Drawing.Size(59, 17);
            this.c1Badge.TabIndex = 2;
            this.c1Badge.Text = "Medium";
            // 
            // c1Title
            // 
            this.c1Title.AutoSize = true;
            this.c1Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c1Title.Location = new System.Drawing.Point(16, 14);
            this.c1Title.Name = "c1Title";
            this.c1Title.Size = new System.Drawing.Size(96, 17);
            this.c1Title.TabIndex = 3;
            this.c1Title.Text = "GDI+ pie chart";
            // 
            // c1Stripe
            // 
            this.c1Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.c1Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1Stripe.Location = new System.Drawing.Point(0, 0);
            this.c1Stripe.Name = "c1Stripe";
            this.c1Stripe.Size = new System.Drawing.Size(4, 90);
            this.c1Stripe.TabIndex = 4;
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.White;
            this.card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card2.Controls.Add(this.c2Avatar);
            this.card2.Controls.Add(this.c2Due);
            this.card2.Controls.Add(this.c2Badge);
            this.card2.Controls.Add(this.c2Title);
            this.card2.Controls.Add(this.c2Stripe);
            this.card2.Location = new System.Drawing.Point(0, 104);
            this.card2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(268, 92);
            this.card2.TabIndex = 1;
            // 
            // c2Avatar
            // 
            this.c2Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c2Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c2Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c2Avatar.Location = new System.Drawing.Point(228, 48);
            this.c2Avatar.Name = "c2Avatar";
            this.c2Avatar.Size = new System.Drawing.Size(26, 26);
            this.c2Avatar.TabIndex = 0;
            this.c2Avatar.Text = "A";
            this.c2Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2Due
            // 
            this.c2Due.AutoSize = true;
            this.c2Due.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c2Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c2Due.Location = new System.Drawing.Point(82, 54);
            this.c2Due.Name = "c2Due";
            this.c2Due.Size = new System.Drawing.Size(62, 15);
            this.c2Due.TabIndex = 1;
            this.c2Due.Text = "Due Nov 8";
            // 
            // c2Badge
            // 
            this.c2Badge.AutoSize = true;
            this.c2Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.c2Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c2Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.c2Badge.Location = new System.Drawing.Point(16, 52);
            this.c2Badge.Name = "c2Badge";
            this.c2Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c2Badge.Size = new System.Drawing.Size(59, 17);
            this.c2Badge.TabIndex = 2;
            this.c2Badge.Text = "Medium";
            // 
            // c2Title
            // 
            this.c2Title.AutoSize = true;
            this.c2Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c2Title.Location = new System.Drawing.Point(16, 14);
            this.c2Title.Name = "c2Title";
            this.c2Title.Size = new System.Drawing.Size(104, 17);
            this.c2Title.TabIndex = 3;
            this.c2Title.Text = "Write test cases";
            // 
            // c2Stripe
            // 
            this.c2Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.c2Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c2Stripe.Location = new System.Drawing.Point(0, 0);
            this.c2Stripe.Name = "c2Stripe";
            this.c2Stripe.Size = new System.Drawing.Size(4, 90);
            this.c2Stripe.TabIndex = 4;
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.White;
            this.card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card3.Controls.Add(this.c3Avatar);
            this.card3.Controls.Add(this.c3Due);
            this.card3.Controls.Add(this.c3Badge);
            this.card3.Controls.Add(this.c3Title);
            this.card3.Controls.Add(this.c3Stripe);
            this.card3.Location = new System.Drawing.Point(0, 208);
            this.card3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(268, 92);
            this.card3.TabIndex = 2;
            // 
            // c3Avatar
            // 
            this.c3Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c3Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c3Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c3Avatar.Location = new System.Drawing.Point(228, 48);
            this.c3Avatar.Name = "c3Avatar";
            this.c3Avatar.Size = new System.Drawing.Size(26, 26);
            this.c3Avatar.TabIndex = 0;
            this.c3Avatar.Text = "M";
            this.c3Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c3Due
            // 
            this.c3Due.AutoSize = true;
            this.c3Due.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c3Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c3Due.Location = new System.Drawing.Point(65, 54);
            this.c3Due.Name = "c3Due";
            this.c3Due.Size = new System.Drawing.Size(68, 15);
            this.c3Due.TabIndex = 1;
            this.c3Due.Text = "Due Nov 10";
            // 
            // c3Badge
            // 
            this.c3Badge.AutoSize = true;
            this.c3Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.c3Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c3Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.c3Badge.Location = new System.Drawing.Point(16, 52);
            this.c3Badge.Name = "c3Badge";
            this.c3Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c3Badge.Size = new System.Drawing.Size(37, 17);
            this.c3Badge.TabIndex = 2;
            this.c3Badge.Text = "Low";
            // 
            // c3Title
            // 
            this.c3Title.AutoSize = true;
            this.c3Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c3Title.Location = new System.Drawing.Point(16, 14);
            this.c3Title.Name = "c3Title";
            this.c3Title.Size = new System.Drawing.Size(97, 17);
            this.c3Title.TabIndex = 3;
            this.c3Title.Text = "Write README";
            // 
            // c3Stripe
            // 
            this.c3Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.c3Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c3Stripe.Location = new System.Drawing.Point(0, 0);
            this.c3Stripe.Name = "c3Stripe";
            this.c3Stripe.Size = new System.Drawing.Size(4, 90);
            this.c3Stripe.TabIndex = 4;
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.White;
            this.card4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card4.Controls.Add(this.c4Avatar);
            this.card4.Controls.Add(this.c4Due);
            this.card4.Controls.Add(this.c4Badge);
            this.card4.Controls.Add(this.c4Title);
            this.card4.Controls.Add(this.c4Stripe);
            this.card4.Location = new System.Drawing.Point(0, 312);
            this.card4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(268, 92);
            this.card4.TabIndex = 3;
            // 
            // c4Avatar
            // 
            this.c4Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c4Avatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c4Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c4Avatar.Location = new System.Drawing.Point(228, 48);
            this.c4Avatar.Name = "c4Avatar";
            this.c4Avatar.Size = new System.Drawing.Size(26, 26);
            this.c4Avatar.TabIndex = 0;
            this.c4Avatar.Text = "Y";
            this.c4Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c4Due
            // 
            this.c4Due.AutoSize = true;
            this.c4Due.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.c4Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.c4Due.Location = new System.Drawing.Point(68, 54);
            this.c4Due.Name = "c4Due";
            this.c4Due.Size = new System.Drawing.Size(70, 15);
            this.c4Due.TabIndex = 1;
            this.c4Due.Text = "Due Oct 30";
            // 
            // c4Badge
            // 
            this.c4Badge.AutoSize = true;
            this.c4Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.c4Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c4Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(65)))), ((int)(((byte)(12)))));
            this.c4Badge.Location = new System.Drawing.Point(16, 52);
            this.c4Badge.Name = "c4Badge";
            this.c4Badge.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.c4Badge.Size = new System.Drawing.Size(41, 17);
            this.c4Badge.TabIndex = 2;
            this.c4Badge.Text = "High";
            // 
            // c4Title
            // 
            this.c4Title.AutoSize = true;
            this.c4Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.c4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c4Title.Location = new System.Drawing.Point(16, 14);
            this.c4Title.Name = "c4Title";
            this.c4Title.Size = new System.Drawing.Size(148, 17);
            this.c4Title.TabIndex = 3;
            this.c4Title.Text = "Prepare demo scenario";
            // 
            // c4Stripe
            // 
            this.c4Stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.c4Stripe.Dock = System.Windows.Forms.DockStyle.Left;
            this.c4Stripe.Location = new System.Drawing.Point(0, 0);
            this.c4Stripe.Name = "c4Stripe";
            this.c4Stripe.Size = new System.Drawing.Size(4, 90);
            this.c4Stripe.TabIndex = 4;
            // 
            // lblTodoCount
            // 
            this.lblTodoCount.BackColor = System.Drawing.Color.White;
            this.lblTodoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTodoCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTodoCount.Location = new System.Drawing.Point(255, 14);
            this.lblTodoCount.Name = "lblTodoCount";
            this.lblTodoCount.Size = new System.Drawing.Size(24, 22);
            this.lblTodoCount.TabIndex = 1;
            this.lblTodoCount.Text = "4";
            this.lblTodoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTodoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTodoTitle.Location = new System.Drawing.Point(34, 15);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(47, 19);
            this.lblTodoTitle.TabIndex = 2;
            this.lblTodoTitle.Text = "To do";
            // 
            // lblTodoDot
            // 
            this.lblTodoDot.AutoSize = true;
            this.lblTodoDot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTodoDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTodoDot.Location = new System.Drawing.Point(14, 15);
            this.lblTodoDot.Name = "lblTodoDot";
            this.lblTodoDot.Size = new System.Drawing.Size(17, 19);
            this.lblTodoDot.TabIndex = 3;
            this.lblTodoDot.Text = "●";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProjects.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbProjects.Items.AddRange(new object[] {
            "All projects",
            "CS312 Project",
            "Documentation"});
            this.cmbProjects.Location = new System.Drawing.Point(785, 34);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(160, 25);
            this.cmbProjects.TabIndex = 3;
            // 
            // lblProjectFilter
            // 
            this.lblProjectFilter.AutoSize = true;
            this.lblProjectFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblProjectFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblProjectFilter.Location = new System.Drawing.Point(730, 38);
            this.lblProjectFilter.Name = "lblProjectFilter";
            this.lblProjectFilter.Size = new System.Drawing.Size(48, 17);
            this.lblProjectFilter.TabIndex = 4;
            this.lblProjectFilter.Text = "Project";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPageSub.Location = new System.Drawing.Point(33, 62);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(285, 17);
            this.lblPageSub.TabIndex = 5;
            this.lblPageSub.Text = "CS312 Project · drag a card to change its status";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPageTitle.Location = new System.Drawing.Point(30, 25);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(176, 32);
            this.lblPageTitle.TabIndex = 6;
            this.lblPageTitle.Text = "Kanban board";
            // 
            // kanban_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "kanban_board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager - Kanban Board";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlColDone.ResumeLayout(false);
            this.pnlColDone.PerformLayout();
            this.flpDone.ResumeLayout(false);
            this.card7.ResumeLayout(false);
            this.card7.PerformLayout();
            this.card8.ResumeLayout(false);
            this.card8.PerformLayout();
            this.pnlColProgress.ResumeLayout(false);
            this.pnlColProgress.PerformLayout();
            this.flpProgress.ResumeLayout(false);
            this.card5.ResumeLayout(false);
            this.card5.PerformLayout();
            this.card6.ResumeLayout(false);
            this.card6.PerformLayout();
            this.pnlColTodo.ResumeLayout(false);
            this.pnlColTodo.PerformLayout();
            this.flpTodo.ResumeLayout(false);
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}