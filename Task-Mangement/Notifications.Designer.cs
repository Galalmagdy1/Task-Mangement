namespace Task_Mangement
{
    partial class Notifications
    {
        private System.ComponentModel.IContainer components = null;

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

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblUnreadCount;
        private System.Windows.Forms.Button btnMarkAllRead;
        private System.Windows.Forms.Button btnClearAll;

        private System.Windows.Forms.FlowLayoutPanel flpFilters;
        private System.Windows.Forms.Button btnFilterAll;
        private System.Windows.Forms.Button btnFilterUnread;
        private System.Windows.Forms.Button btnFilterAssigned;
        private System.Windows.Forms.Button btnFilterCompleted;
        private System.Windows.Forms.Button btnFilterDeadlines;
        private System.Windows.Forms.Button btnFilterProjects;

        private System.Windows.Forms.FlowLayoutPanel flpNotifications;

        // Card 1 Controls
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Label c1Dot;
        private System.Windows.Forms.Label c1Icon;
        private System.Windows.Forms.Label c1Title;
        private System.Windows.Forms.Label c1Desc;
        private System.Windows.Forms.Label c1Badge;
        private System.Windows.Forms.Label c1Time;
        private System.Windows.Forms.LinkLabel c1MarkRead;
        private System.Windows.Forms.LinkLabel c1Dismiss;

        // Card 2 Controls
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label c2Dot;
        private System.Windows.Forms.Label c2Icon;
        private System.Windows.Forms.Label c2Title;
        private System.Windows.Forms.Label c2Desc;
        private System.Windows.Forms.Label c2Badge;
        private System.Windows.Forms.Label c2Time;
        private System.Windows.Forms.LinkLabel c2MarkRead;
        private System.Windows.Forms.LinkLabel c2Dismiss;

        // Card 3 Controls
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Label c3Dot;
        private System.Windows.Forms.Label c3Icon;
        private System.Windows.Forms.Label c3Title;
        private System.Windows.Forms.Label c3Desc;
        private System.Windows.Forms.Label c3Badge;
        private System.Windows.Forms.Label c3Time;
        private System.Windows.Forms.LinkLabel c3MarkRead;
        private System.Windows.Forms.LinkLabel c3Dismiss;

        // Card 4 Controls
        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Label c4Icon;
        private System.Windows.Forms.Label c4Title;
        private System.Windows.Forms.Label c4Desc;
        private System.Windows.Forms.Label c4Badge;
        private System.Windows.Forms.Label c4Time;
        private System.Windows.Forms.LinkLabel c4Dismiss;

        // Card 5 Controls
        private System.Windows.Forms.Panel card5;
        private System.Windows.Forms.Label c5Icon;
        private System.Windows.Forms.Label c5Title;
        private System.Windows.Forms.Label c5Desc;
        private System.Windows.Forms.Label c5Badge;
        private System.Windows.Forms.Label c5Time;
        private System.Windows.Forms.LinkLabel c5Dismiss;

        // Card 6 Controls
        private System.Windows.Forms.Panel card6;
        private System.Windows.Forms.Label c6Icon;
        private System.Windows.Forms.Label c6Title;
        private System.Windows.Forms.Label c6Desc;
        private System.Windows.Forms.Label c6Badge;
        private System.Windows.Forms.Label c6Time;
        private System.Windows.Forms.LinkLabel c6Dismiss;

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
            this.flpNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.card1 = new System.Windows.Forms.Panel();
            this.c1Dot = new System.Windows.Forms.Label();
            this.c1Icon = new System.Windows.Forms.Label();
            this.c1Title = new System.Windows.Forms.Label();
            this.c1Desc = new System.Windows.Forms.Label();
            this.c1Badge = new System.Windows.Forms.Label();
            this.c1Time = new System.Windows.Forms.Label();
            this.c1MarkRead = new System.Windows.Forms.LinkLabel();
            this.c1Dismiss = new System.Windows.Forms.LinkLabel();
            this.card2 = new System.Windows.Forms.Panel();
            this.c2Dot = new System.Windows.Forms.Label();
            this.c2Icon = new System.Windows.Forms.Label();
            this.c2Title = new System.Windows.Forms.Label();
            this.c2Desc = new System.Windows.Forms.Label();
            this.c2Badge = new System.Windows.Forms.Label();
            this.c2Time = new System.Windows.Forms.Label();
            this.c2MarkRead = new System.Windows.Forms.LinkLabel();
            this.c2Dismiss = new System.Windows.Forms.LinkLabel();
            this.card3 = new System.Windows.Forms.Panel();
            this.c3Dot = new System.Windows.Forms.Label();
            this.c3Icon = new System.Windows.Forms.Label();
            this.c3Title = new System.Windows.Forms.Label();
            this.c3Desc = new System.Windows.Forms.Label();
            this.c3Badge = new System.Windows.Forms.Label();
            this.c3Time = new System.Windows.Forms.Label();
            this.c3MarkRead = new System.Windows.Forms.LinkLabel();
            this.c3Dismiss = new System.Windows.Forms.LinkLabel();
            this.card4 = new System.Windows.Forms.Panel();
            this.c4Icon = new System.Windows.Forms.Label();
            this.c4Title = new System.Windows.Forms.Label();
            this.c4Desc = new System.Windows.Forms.Label();
            this.c4Badge = new System.Windows.Forms.Label();
            this.c4Time = new System.Windows.Forms.Label();
            this.c4Dismiss = new System.Windows.Forms.LinkLabel();
            this.card5 = new System.Windows.Forms.Panel();
            this.c5Icon = new System.Windows.Forms.Label();
            this.c5Title = new System.Windows.Forms.Label();
            this.c5Desc = new System.Windows.Forms.Label();
            this.c5Badge = new System.Windows.Forms.Label();
            this.c5Time = new System.Windows.Forms.Label();
            this.c5Dismiss = new System.Windows.Forms.LinkLabel();
            this.card6 = new System.Windows.Forms.Panel();
            this.c6Icon = new System.Windows.Forms.Label();
            this.c6Title = new System.Windows.Forms.Label();
            this.c6Desc = new System.Windows.Forms.Label();
            this.c6Badge = new System.Windows.Forms.Label();
            this.c6Time = new System.Windows.Forms.Label();
            this.c6Dismiss = new System.Windows.Forms.LinkLabel();
            this.flpFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.btnFilterUnread = new System.Windows.Forms.Button();
            this.btnFilterAssigned = new System.Windows.Forms.Button();
            this.btnFilterCompleted = new System.Windows.Forms.Button();
            this.btnFilterDeadlines = new System.Windows.Forms.Button();
            this.btnFilterProjects = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnMarkAllRead = new System.Windows.Forms.Button();
            this.lblUnreadCount = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.flpNotifications.SuspendLayout();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.card3.SuspendLayout();
            this.card4.SuspendLayout();
            this.card5.SuspendLayout();
            this.card6.SuspendLayout();
            this.flpFilters.SuspendLayout();
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
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
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
            this.btnNavNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNavNotifications.FlatAppearance.BorderSize = 0;
            this.btnNavNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNotifications.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavNotifications.ForeColor = System.Drawing.Color.White;
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
            this.btnNavReports.Click += new System.EventHandler(this.btnNavReports_Click);
            // 
            // btnNavKanban
            // 
            this.btnNavKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.btnNavKanban.FlatAppearance.BorderSize = 0;
            this.btnNavKanban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKanban.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavKanban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
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
            this.pnlMain.Controls.Add(this.flpNotifications);
            this.pnlMain.Controls.Add(this.flpFilters);
            this.pnlMain.Controls.Add(this.btnClearAll);
            this.pnlMain.Controls.Add(this.btnMarkAllRead);
            this.pnlMain.Controls.Add(this.lblUnreadCount);
            this.pnlMain.Controls.Add(this.lblPageTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 760);
            this.pnlMain.TabIndex = 0;
            // 
            // flpNotifications
            // 
            this.flpNotifications.AutoScroll = true;
            this.flpNotifications.Controls.Add(this.card1);
            this.flpNotifications.Controls.Add(this.card2);
            this.flpNotifications.Controls.Add(this.card3);
            this.flpNotifications.Controls.Add(this.card4);
            this.flpNotifications.Controls.Add(this.card5);
            this.flpNotifications.Controls.Add(this.card6);
            this.flpNotifications.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNotifications.Location = new System.Drawing.Point(30, 135);
            this.flpNotifications.Name = "flpNotifications";
            this.flpNotifications.Size = new System.Drawing.Size(925, 600);
            this.flpNotifications.TabIndex = 0;
            this.flpNotifications.WrapContents = false;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Controls.Add(this.c1Dot);
            this.card1.Controls.Add(this.c1Icon);
            this.card1.Controls.Add(this.c1Title);
            this.card1.Controls.Add(this.c1Desc);
            this.card1.Controls.Add(this.c1Badge);
            this.card1.Controls.Add(this.c1Time);
            this.card1.Controls.Add(this.c1MarkRead);
            this.card1.Controls.Add(this.c1Dismiss);
            this.card1.Location = new System.Drawing.Point(0, 0);
            this.card1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(895, 86);
            this.card1.TabIndex = 0;
            // 
            // c1Dot
            // 
            this.c1Dot.AutoSize = true;
            this.c1Dot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.c1Dot.Location = new System.Drawing.Point(10, 32);
            this.c1Dot.Name = "c1Dot";
            this.c1Dot.Size = new System.Drawing.Size(14, 15);
            this.c1Dot.TabIndex = 0;
            this.c1Dot.Text = "●";
            // 
            // c1Icon
            // 
            this.c1Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c1Icon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.c1Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c1Icon.Location = new System.Drawing.Point(32, 24);
            this.c1Icon.Name = "c1Icon";
            this.c1Icon.Size = new System.Drawing.Size(32, 32);
            this.c1Icon.TabIndex = 1;
            this.c1Icon.Text = "→";
            this.c1Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1Title
            // 
            this.c1Title.AutoSize = true;
            this.c1Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.c1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c1Title.Location = new System.Drawing.Point(78, 12);
            this.c1Title.Name = "c1Title";
            this.c1Title.Size = new System.Drawing.Size(191, 19);
            this.c1Title.TabIndex = 2;
            this.c1Title.Text = "Ahmed assigned you a task";
            // 
            // c1Desc
            // 
            this.c1Desc.AutoSize = true;
            this.c1Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c1Desc.Location = new System.Drawing.Point(78, 34);
            this.c1Desc.Name = "c1Desc";
            this.c1Desc.Size = new System.Drawing.Size(256, 15);
            this.c1Desc.TabIndex = 3;
            this.c1Desc.Text = "\"Write test cases\" · Medium priority · due Nov 8";
            // 
            // c1Badge
            // 
            this.c1Badge.AutoSize = true;
            this.c1Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c1Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c1Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c1Badge.Location = new System.Drawing.Point(80, 58);
            this.c1Badge.Name = "c1Badge";
            this.c1Badge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.c1Badge.Size = new System.Drawing.Size(63, 15);
            this.c1Badge.TabIndex = 4;
            this.c1Badge.Text = "Assigned";
            // 
            // c1Time
            // 
            this.c1Time.AutoSize = true;
            this.c1Time.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c1Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.c1Time.Location = new System.Drawing.Point(155, 59);
            this.c1Time.Name = "c1Time";
            this.c1Time.Size = new System.Drawing.Size(60, 15);
            this.c1Time.TabIndex = 5;
            this.c1Time.Text = "5 min ago";
            // 
            // c1MarkRead
            // 
            this.c1MarkRead.AutoSize = true;
            this.c1MarkRead.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.c1MarkRead.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c1MarkRead.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.c1MarkRead.Location = new System.Drawing.Point(800, 16);
            this.c1MarkRead.Name = "c1MarkRead";
            this.c1MarkRead.Size = new System.Drawing.Size(74, 15);
            this.c1MarkRead.TabIndex = 6;
            this.c1MarkRead.TabStop = true;
            this.c1MarkRead.Text = "Mark as read";
            // 
            // c1Dismiss
            // 
            this.c1Dismiss.AutoSize = true;
            this.c1Dismiss.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c1Dismiss.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c1Dismiss.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c1Dismiss.Location = new System.Drawing.Point(830, 56);
            this.c1Dismiss.Name = "c1Dismiss";
            this.c1Dismiss.Size = new System.Drawing.Size(47, 15);
            this.c1Dismiss.TabIndex = 7;
            this.c1Dismiss.TabStop = true;
            this.c1Dismiss.Text = "Dismiss";
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.White;
            this.card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card2.Controls.Add(this.c2Dot);
            this.card2.Controls.Add(this.c2Icon);
            this.card2.Controls.Add(this.c2Title);
            this.card2.Controls.Add(this.c2Desc);
            this.card2.Controls.Add(this.c2Badge);
            this.card2.Controls.Add(this.c2Time);
            this.card2.Controls.Add(this.c2MarkRead);
            this.card2.Controls.Add(this.c2Dismiss);
            this.card2.Location = new System.Drawing.Point(0, 96);
            this.card2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(895, 86);
            this.card2.TabIndex = 1;
            this.card2.Paint += new System.Windows.Forms.PaintEventHandler(this.card2_Paint);
            // 
            // c2Dot
            // 
            this.c2Dot.AutoSize = true;
            this.c2Dot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c2Dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.c2Dot.Location = new System.Drawing.Point(10, 32);
            this.c2Dot.Name = "c2Dot";
            this.c2Dot.Size = new System.Drawing.Size(14, 15);
            this.c2Dot.TabIndex = 0;
            this.c2Dot.Text = "●";
            // 
            // c2Icon
            // 
            this.c2Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.c2Icon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.c2Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.c2Icon.Location = new System.Drawing.Point(32, 24);
            this.c2Icon.Name = "c2Icon";
            this.c2Icon.Size = new System.Drawing.Size(32, 32);
            this.c2Icon.TabIndex = 1;
            this.c2Icon.Text = "✓";
            this.c2Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2Title
            // 
            this.c2Title.AutoSize = true;
            this.c2Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.c2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c2Title.Location = new System.Drawing.Point(78, 12);
            this.c2Title.Name = "c2Title";
            this.c2Title.Size = new System.Drawing.Size(158, 19);
            this.c2Title.TabIndex = 2;
            this.c2Title.Text = "Sara completed a task";
            // 
            // c2Desc
            // 
            this.c2Desc.AutoSize = true;
            this.c2Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c2Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c2Desc.Location = new System.Drawing.Point(78, 34);
            this.c2Desc.Name = "c2Desc";
            this.c2Desc.Size = new System.Drawing.Size(184, 15);
            this.c2Desc.TabIndex = 3;
            this.c2Desc.Text = "\"Design ER diagram\" is now Done";
            // 
            // c2Badge
            // 
            this.c2Badge.AutoSize = true;
            this.c2Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.c2Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c2Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.c2Badge.Location = new System.Drawing.Point(80, 58);
            this.c2Badge.Name = "c2Badge";
            this.c2Badge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.c2Badge.Size = new System.Drawing.Size(74, 15);
            this.c2Badge.TabIndex = 4;
            this.c2Badge.Text = "Completed";
            // 
            // c2Time
            // 
            this.c2Time.AutoSize = true;
            this.c2Time.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c2Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.c2Time.Location = new System.Drawing.Point(155, 59);
            this.c2Time.Name = "c2Time";
            this.c2Time.Size = new System.Drawing.Size(66, 15);
            this.c2Time.TabIndex = 5;
            this.c2Time.Text = "20 min ago";
            // 
            // c2MarkRead
            // 
            this.c2MarkRead.AutoSize = true;
            this.c2MarkRead.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.c2MarkRead.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c2MarkRead.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.c2MarkRead.Location = new System.Drawing.Point(800, 16);
            this.c2MarkRead.Name = "c2MarkRead";
            this.c2MarkRead.Size = new System.Drawing.Size(74, 15);
            this.c2MarkRead.TabIndex = 6;
            this.c2MarkRead.TabStop = true;
            this.c2MarkRead.Text = "Mark as read";
            // 
            // c2Dismiss
            // 
            this.c2Dismiss.AutoSize = true;
            this.c2Dismiss.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c2Dismiss.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c2Dismiss.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c2Dismiss.Location = new System.Drawing.Point(830, 56);
            this.c2Dismiss.Name = "c2Dismiss";
            this.c2Dismiss.Size = new System.Drawing.Size(47, 15);
            this.c2Dismiss.TabIndex = 7;
            this.c2Dismiss.TabStop = true;
            this.c2Dismiss.Text = "Dismiss";
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.White;
            this.card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card3.Controls.Add(this.c3Dot);
            this.card3.Controls.Add(this.c3Icon);
            this.card3.Controls.Add(this.c3Title);
            this.card3.Controls.Add(this.c3Desc);
            this.card3.Controls.Add(this.c3Badge);
            this.card3.Controls.Add(this.c3Time);
            this.card3.Controls.Add(this.c3MarkRead);
            this.card3.Controls.Add(this.c3Dismiss);
            this.card3.Location = new System.Drawing.Point(0, 192);
            this.card3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(895, 86);
            this.card3.TabIndex = 2;
            this.card3.Paint += new System.Windows.Forms.PaintEventHandler(this.card3_Paint);
            // 
            // c3Dot
            // 
            this.c3Dot.AutoSize = true;
            this.c3Dot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c3Dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.c3Dot.Location = new System.Drawing.Point(10, 32);
            this.c3Dot.Name = "c3Dot";
            this.c3Dot.Size = new System.Drawing.Size(14, 15);
            this.c3Dot.TabIndex = 0;
            this.c3Dot.Text = "●";
            // 
            // c3Icon
            // 
            this.c3Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.c3Icon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.c3Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.c3Icon.Location = new System.Drawing.Point(32, 24);
            this.c3Icon.Name = "c3Icon";
            this.c3Icon.Size = new System.Drawing.Size(32, 32);
            this.c3Icon.TabIndex = 1;
            this.c3Icon.Text = "!";
            this.c3Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c3Title
            // 
            this.c3Title.AutoSize = true;
            this.c3Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.c3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c3Title.Location = new System.Drawing.Point(78, 12);
            this.c3Title.Name = "c3Title";
            this.c3Title.Size = new System.Drawing.Size(140, 19);
            this.c3Title.TabIndex = 2;
            this.c3Title.Text = "Deadline tomorrow";
            // 
            // c3Desc
            // 
            this.c3Desc.AutoSize = true;
            this.c3Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c3Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c3Desc.Location = new System.Drawing.Point(78, 34);
            this.c3Desc.Name = "c3Desc";
            this.c3Desc.Size = new System.Drawing.Size(218, 15);
            this.c3Desc.TabIndex = 3;
            this.c3Desc.Text = "\"Implement TCP server\" is due on Nov 3";
            // 
            // c3Badge
            // 
            this.c3Badge.AutoSize = true;
            this.c3Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.c3Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c3Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.c3Badge.Location = new System.Drawing.Point(80, 58);
            this.c3Badge.Name = "c3Badge";
            this.c3Badge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.c3Badge.Size = new System.Drawing.Size(62, 15);
            this.c3Badge.TabIndex = 4;
            this.c3Badge.Text = "Deadline";
            // 
            // c3Time
            // 
            this.c3Time.AutoSize = true;
            this.c3Time.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c3Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.c3Time.Location = new System.Drawing.Point(155, 59);
            this.c3Time.Name = "c3Time";
            this.c3Time.Size = new System.Drawing.Size(64, 15);
            this.c3Time.TabIndex = 5;
            this.c3Time.Text = "1 hour ago";
            // 
            // c3MarkRead
            // 
            this.c3MarkRead.AutoSize = true;
            this.c3MarkRead.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.c3MarkRead.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c3MarkRead.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.c3MarkRead.Location = new System.Drawing.Point(800, 16);
            this.c3MarkRead.Name = "c3MarkRead";
            this.c3MarkRead.Size = new System.Drawing.Size(74, 15);
            this.c3MarkRead.TabIndex = 6;
            this.c3MarkRead.TabStop = true;
            this.c3MarkRead.Text = "Mark as read";
            // 
            // c3Dismiss
            // 
            this.c3Dismiss.AutoSize = true;
            this.c3Dismiss.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c3Dismiss.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c3Dismiss.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c3Dismiss.Location = new System.Drawing.Point(830, 56);
            this.c3Dismiss.Name = "c3Dismiss";
            this.c3Dismiss.Size = new System.Drawing.Size(47, 15);
            this.c3Dismiss.TabIndex = 7;
            this.c3Dismiss.TabStop = true;
            this.c3Dismiss.Text = "Dismiss";
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.White;
            this.card4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card4.Controls.Add(this.c4Icon);
            this.card4.Controls.Add(this.c4Title);
            this.card4.Controls.Add(this.c4Desc);
            this.card4.Controls.Add(this.c4Badge);
            this.card4.Controls.Add(this.c4Time);
            this.card4.Controls.Add(this.c4Dismiss);
            this.card4.Location = new System.Drawing.Point(0, 288);
            this.card4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(895, 86);
            this.card4.TabIndex = 3;
            // 
            // c4Icon
            // 
            this.c4Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.c4Icon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.c4Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(33)))), ((int)(((byte)(168)))));
            this.c4Icon.Location = new System.Drawing.Point(32, 24);
            this.c4Icon.Name = "c4Icon";
            this.c4Icon.Size = new System.Drawing.Size(32, 32);
            this.c4Icon.TabIndex = 0;
            this.c4Icon.Text = "+";
            this.c4Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c4Title
            // 
            this.c4Title.AutoSize = true;
            this.c4Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.c4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c4Title.Location = new System.Drawing.Point(78, 12);
            this.c4Title.Name = "c4Title";
            this.c4Title.Size = new System.Drawing.Size(188, 19);
            this.c4Title.TabIndex = 1;
            this.c4Title.Text = "Mona added you to a project";
            // 
            // c4Desc
            // 
            this.c4Desc.AutoSize = true;
            this.c4Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c4Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c4Desc.Location = new System.Drawing.Point(78, 34);
            this.c4Desc.Name = "c4Desc";
            this.c4Desc.Size = new System.Drawing.Size(239, 15);
            this.c4Desc.TabIndex = 2;
            this.c4Desc.Text = "You are now a member of \"Documentation\"";
            // 
            // c4Badge
            // 
            this.c4Badge.AutoSize = true;
            this.c4Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.c4Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c4Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(33)))), ((int)(((byte)(168)))));
            this.c4Badge.Location = new System.Drawing.Point(80, 58);
            this.c4Badge.Name = "c4Badge";
            this.c4Badge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.c4Badge.Size = new System.Drawing.Size(52, 15);
            this.c4Badge.TabIndex = 3;
            this.c4Badge.Text = "Project";
            // 
            // c4Time
            // 
            this.c4Time.AutoSize = true;
            this.c4Time.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c4Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.c4Time.Location = new System.Drawing.Point(155, 59);
            this.c4Time.Name = "c4Time";
            this.c4Time.Size = new System.Drawing.Size(57, 15);
            this.c4Time.TabIndex = 4;
            this.c4Time.Text = "Yesterday";
            // 
            // c4Dismiss
            // 
            this.c4Dismiss.AutoSize = true;
            this.c4Dismiss.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c4Dismiss.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c4Dismiss.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c4Dismiss.Location = new System.Drawing.Point(830, 56);
            this.c4Dismiss.Name = "c4Dismiss";
            this.c4Dismiss.Size = new System.Drawing.Size(47, 15);
            this.c4Dismiss.TabIndex = 5;
            this.c4Dismiss.TabStop = true;
            this.c4Dismiss.Text = "Dismiss";
            // 
            // card5
            // 
            this.card5.BackColor = System.Drawing.Color.White;
            this.card5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card5.Controls.Add(this.c5Icon);
            this.card5.Controls.Add(this.c5Title);
            this.card5.Controls.Add(this.c5Desc);
            this.card5.Controls.Add(this.c5Badge);
            this.card5.Controls.Add(this.c5Time);
            this.card5.Controls.Add(this.c5Dismiss);
            this.card5.Location = new System.Drawing.Point(0, 384);
            this.card5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(895, 86);
            this.card5.TabIndex = 4;
            // 
            // c5Icon
            // 
            this.c5Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.c5Icon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.c5Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.c5Icon.Location = new System.Drawing.Point(32, 24);
            this.c5Icon.Name = "c5Icon";
            this.c5Icon.Size = new System.Drawing.Size(32, 32);
            this.c5Icon.TabIndex = 0;
            this.c5Icon.Text = "!";
            this.c5Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c5Title
            // 
            this.c5Title.AutoSize = true;
            this.c5Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.c5Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c5Title.Location = new System.Drawing.Point(78, 12);
            this.c5Title.Name = "c5Title";
            this.c5Title.Size = new System.Drawing.Size(101, 19);
            this.c5Title.TabIndex = 1;
            this.c5Title.Text = "Task is overdue";
            // 
            // c5Desc
            // 
            this.c5Desc.AutoSize = true;
            this.c5Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c5Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c5Desc.Location = new System.Drawing.Point(78, 34);
            this.c5Desc.Name = "c5Desc";
            this.c5Desc.Size = new System.Drawing.Size(263, 15);
            this.c5Desc.TabIndex = 2;
            this.c5Desc.Text = "\"Create SQL script\" passed its deadline on Oct 29";
            // 
            // c5Badge
            // 
            this.c5Badge.AutoSize = true;
            this.c5Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.c5Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c5Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.c5Badge.Location = new System.Drawing.Point(80, 58);
            this.c5Badge.Name = "c5Badge";
            this.c5Badge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.c5Badge.Size = new System.Drawing.Size(60, 15);
            this.c5Badge.TabIndex = 3;
            this.c5Badge.Text = "Overdue";
            // 
            // c5Time
            // 
            this.c5Time.AutoSize = true;
            this.c5Time.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c5Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.c5Time.Location = new System.Drawing.Point(155, 59);
            this.c5Time.Name = "c5Time";
            this.c5Time.Size = new System.Drawing.Size(63, 15);
            this.c5Time.TabIndex = 4;
            this.c5Time.Text = "2 days ago";
            // 
            // c5Dismiss
            // 
            this.c5Dismiss.AutoSize = true;
            this.c5Dismiss.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c5Dismiss.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c5Dismiss.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c5Dismiss.Location = new System.Drawing.Point(830, 56);
            this.c5Dismiss.Name = "c5Dismiss";
            this.c5Dismiss.Size = new System.Drawing.Size(47, 15);
            this.c5Dismiss.TabIndex = 5;
            this.c5Dismiss.TabStop = true;
            this.c5Dismiss.Text = "Dismiss";
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.Color.White;
            this.card6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card6.Controls.Add(this.c6Icon);
            this.card6.Controls.Add(this.c6Title);
            this.card6.Controls.Add(this.c6Desc);
            this.card6.Controls.Add(this.c6Badge);
            this.card6.Controls.Add(this.c6Time);
            this.card6.Controls.Add(this.c6Dismiss);
            this.card6.Location = new System.Drawing.Point(0, 480);
            this.card6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(895, 86);
            this.card6.TabIndex = 5;
            // 
            // c6Icon
            // 
            this.c6Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c6Icon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.c6Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c6Icon.Location = new System.Drawing.Point(32, 24);
            this.c6Icon.Name = "c6Icon";
            this.c6Icon.Size = new System.Drawing.Size(32, 32);
            this.c6Icon.TabIndex = 0;
            this.c6Icon.Text = "→";
            this.c6Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c6Title
            // 
            this.c6Title.AutoSize = true;
            this.c6Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.c6Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.c6Title.Location = new System.Drawing.Point(78, 12);
            this.c6Title.Name = "c6Title";
            this.c6Title.Size = new System.Drawing.Size(173, 19);
            this.c6Title.TabIndex = 1;
            this.c6Title.Text = "Yousef assigned you a task";
            // 
            // c6Desc
            // 
            this.c6Desc.AutoSize = true;
            this.c6Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c6Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c6Desc.Location = new System.Drawing.Point(78, 34);
            this.c6Desc.Name = "c6Desc";
            this.c6Desc.Size = new System.Drawing.Size(235, 15);
            this.c6Desc.TabIndex = 2;
            this.c6Desc.Text = "\"Write README\" · Low priority · due Nov 10";
            // 
            // c6Badge
            // 
            this.c6Badge.AutoSize = true;
            this.c6Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.c6Badge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.c6Badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.c6Badge.Location = new System.Drawing.Point(80, 58);
            this.c6Badge.Name = "c6Badge";
            this.c6Badge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.c6Badge.Size = new System.Drawing.Size(63, 15);
            this.c6Badge.TabIndex = 3;
            this.c6Badge.Text = "Assigned";
            // 
            // c6Time
            // 
            this.c6Time.AutoSize = true;
            this.c6Time.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c6Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.c6Time.Location = new System.Drawing.Point(155, 59);
            this.c6Time.Name = "c6Time";
            this.c6Time.Size = new System.Drawing.Size(63, 15);
            this.c6Time.TabIndex = 4;
            this.c6Time.Text = "3 days ago";
            // 
            // c6Dismiss
            // 
            this.c6Dismiss.AutoSize = true;
            this.c6Dismiss.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.c6Dismiss.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c6Dismiss.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.c6Dismiss.Location = new System.Drawing.Point(830, 56);
            this.c6Dismiss.Name = "c6Dismiss";
            this.c6Dismiss.Size = new System.Drawing.Size(47, 15);
            this.c6Dismiss.TabIndex = 5;
            this.c6Dismiss.TabStop = true;
            this.c6Dismiss.Text = "Dismiss";
            // 
            // flpFilters
            // 
            this.flpFilters.Controls.Add(this.btnFilterAll);
            this.flpFilters.Controls.Add(this.btnFilterUnread);
            this.flpFilters.Controls.Add(this.btnFilterAssigned);
            this.flpFilters.Controls.Add(this.btnFilterCompleted);
            this.flpFilters.Controls.Add(this.btnFilterDeadlines);
            this.flpFilters.Controls.Add(this.btnFilterProjects);
            this.flpFilters.Location = new System.Drawing.Point(30, 90);
            this.flpFilters.Name = "flpFilters";
            this.flpFilters.Size = new System.Drawing.Size(700, 38);
            this.flpFilters.TabIndex = 1;
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFilterAll.FlatAppearance.BorderSize = 0;
            this.btnFilterAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterAll.ForeColor = System.Drawing.Color.White;
            this.btnFilterAll.Location = new System.Drawing.Point(0, 0);
            this.btnFilterAll.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(60, 28);
            this.btnFilterAll.TabIndex = 0;
            this.btnFilterAll.Text = "All";
            this.btnFilterAll.UseVisualStyleBackColor = false;
            // 
            // btnFilterUnread
            // 
            this.btnFilterUnread.BackColor = System.Drawing.Color.White;
            this.btnFilterUnread.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnFilterUnread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterUnread.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterUnread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnFilterUnread.Location = new System.Drawing.Point(68, 0);
            this.btnFilterUnread.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnFilterUnread.Name = "btnFilterUnread";
            this.btnFilterUnread.Size = new System.Drawing.Size(75, 28);
            this.btnFilterUnread.TabIndex = 1;
            this.btnFilterUnread.Text = "Unread";
            this.btnFilterUnread.UseVisualStyleBackColor = false;
            // 
            // btnFilterAssigned
            // 
            this.btnFilterAssigned.BackColor = System.Drawing.Color.White;
            this.btnFilterAssigned.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnFilterAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAssigned.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnFilterAssigned.Location = new System.Drawing.Point(151, 0);
            this.btnFilterAssigned.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnFilterAssigned.Name = "btnFilterAssigned";
            this.btnFilterAssigned.Size = new System.Drawing.Size(80, 28);
            this.btnFilterAssigned.TabIndex = 2;
            this.btnFilterAssigned.Text = "Assigned";
            this.btnFilterAssigned.UseVisualStyleBackColor = false;
            // 
            // btnFilterCompleted
            // 
            this.btnFilterCompleted.BackColor = System.Drawing.Color.White;
            this.btnFilterCompleted.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnFilterCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnFilterCompleted.Location = new System.Drawing.Point(239, 0);
            this.btnFilterCompleted.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnFilterCompleted.Name = "btnFilterCompleted";
            this.btnFilterCompleted.Size = new System.Drawing.Size(85, 28);
            this.btnFilterCompleted.TabIndex = 3;
            this.btnFilterCompleted.Text = "Completed";
            this.btnFilterCompleted.UseVisualStyleBackColor = false;
            // 
            // btnFilterDeadlines
            // 
            this.btnFilterDeadlines.BackColor = System.Drawing.Color.White;
            this.btnFilterDeadlines.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnFilterDeadlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDeadlines.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterDeadlines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnFilterDeadlines.Location = new System.Drawing.Point(332, 0);
            this.btnFilterDeadlines.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnFilterDeadlines.Name = "btnFilterDeadlines";
            this.btnFilterDeadlines.Size = new System.Drawing.Size(80, 28);
            this.btnFilterDeadlines.TabIndex = 4;
            this.btnFilterDeadlines.Text = "Deadlines";
            this.btnFilterDeadlines.UseVisualStyleBackColor = false;
            // 
            // btnFilterProjects
            // 
            this.btnFilterProjects.BackColor = System.Drawing.Color.White;
            this.btnFilterProjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnFilterProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterProjects.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnFilterProjects.Location = new System.Drawing.Point(420, 0);
            this.btnFilterProjects.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnFilterProjects.Name = "btnFilterProjects";
            this.btnFilterProjects.Size = new System.Drawing.Size(75, 28);
            this.btnFilterProjects.TabIndex = 5;
            this.btnFilterProjects.Text = "Projects";
            this.btnFilterProjects.UseVisualStyleBackColor = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.White;
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnClearAll.Location = new System.Drawing.Point(860, 30);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(85, 34);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnMarkAllRead
            // 
            this.btnMarkAllRead.BackColor = System.Drawing.Color.White;
            this.btnMarkAllRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnMarkAllRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAllRead.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkAllRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnMarkAllRead.Location = new System.Drawing.Point(735, 30);
            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Size = new System.Drawing.Size(115, 34);
            this.btnMarkAllRead.TabIndex = 3;
            this.btnMarkAllRead.Text = "Mark all as read";
            this.btnMarkAllRead.UseVisualStyleBackColor = false;
            // 
            // lblUnreadCount
            // 
            this.lblUnreadCount.AutoSize = true;
            this.lblUnreadCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUnreadCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUnreadCount.Location = new System.Drawing.Point(33, 60);
            this.lblUnreadCount.Name = "lblUnreadCount";
            this.lblUnreadCount.Size = new System.Drawing.Size(60, 17);
            this.lblUnreadCount.TabIndex = 4;
            this.lblUnreadCount.Text = "3 unread";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPageTitle.Location = new System.Drawing.Point(30, 25);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(162, 32);
            this.lblPageTitle.TabIndex = 5;
            this.lblPageTitle.Text = "Notifications";
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Notifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager - Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.flpNotifications.ResumeLayout(false);
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            this.card5.ResumeLayout(false);
            this.card5.PerformLayout();
            this.card6.ResumeLayout(false);
            this.card6.PerformLayout();
            this.flpFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}