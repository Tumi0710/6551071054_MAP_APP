namespace HotelManagement.ThongKe
{
    partial class FormThongKe
    {
        private System.ComponentModel.IContainer components = null;

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
            panelHeader = new Panel();
            btnXemThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblTuNgay = new Label();
            panelCards = new TableLayoutPanel();
            pnlCard1 = new Panel();
            lblVal1 = new Label();
            lblTitle1 = new Label();
            picCard1 = new PictureBox();
            pnlCard2 = new Panel();
            lblVal2 = new Label();
            lblTitle2 = new Label();
            picCard2 = new PictureBox();
            pnlCard3 = new Panel();
            lblVal3 = new Label();
            lblTitle3 = new Label();
            picCard3 = new PictureBox();
            panelContent = new TableLayoutPanel();
            panelLeft = new TableLayoutPanel();
            pnlHighlights = new Panel();
            lblTopServiceRevVal = new Label();
            lblTopServiceRevTitle = new Label();
            picTop3 = new PictureBox();
            lblTopRoomCountVal = new Label();
            lblTopRoomCountTitle = new Label();
            picTop2 = new PictureBox();
            lblTopRoomRevVal = new Label();
            lblTopRoomRevTitle = new Label();
            picTop1 = new PictureBox();
            pnlServicesChart = new Panel();
            picServicesPieChart = new PictureBox();
            lblServicesChartTitle = new Label();
            panelRight = new TableLayoutPanel();
            pnlRoomRevChart = new Panel();
            picRoomRevBarChart = new PictureBox();
            lblRoomRevChartTitle = new Label();
            pnlRoomBookingsChart = new Panel();
            picRoomBookingsBarChart = new PictureBox();
            lblRoomBookingsChartTitle = new Label();
            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            pnlCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            pnlCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            pnlCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            panelContent.SuspendLayout();
            panelLeft.SuspendLayout();
            pnlHighlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTop3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTop2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTop1).BeginInit();
            pnlServicesChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picServicesPieChart).BeginInit();
            panelRight.SuspendLayout();
            pnlRoomRevChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRoomRevBarChart).BeginInit();
            pnlRoomBookingsChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRoomBookingsBarChart).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(238, 242, 246);
            panelHeader.Controls.Add(btnXemThongKe);
            panelHeader.Controls.Add(dtpDenNgay);
            panelHeader.Controls.Add(lblDenNgay);
            panelHeader.Controls.Add(dtpTuNgay);
            panelHeader.Controls.Add(lblTuNgay);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 56);
            panelHeader.TabIndex = 0;
            // 
            // btnXemThongKe
            // 
            btnXemThongKe.BackColor = Color.FromArgb(215, 235, 255);
            btnXemThongKe.FlatAppearance.BorderColor = Color.SteelBlue;
            btnXemThongKe.FlatStyle = FlatStyle.Flat;
            btnXemThongKe.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXemThongKe.ForeColor = Color.MidnightBlue;
            btnXemThongKe.Location = new Point(780, 10);
            btnXemThongKe.Margin = new Padding(3, 4, 3, 4);
            btnXemThongKe.Name = "btnXemThongKe";
            btnXemThongKe.Size = new Size(150, 36);
            btnXemThongKe.TabIndex = 4;
            btnXemThongKe.Text = "Xem thống kê";
            btnXemThongKe.UseVisualStyleBackColor = false;
            btnXemThongKe.Click += btnXemThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dddd , d  MMMM  yyyy";
            dtpDenNgay.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(480, 14);
            dtpDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(270, 28);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDenNgay.ForeColor = Color.DarkSlateBlue;
            lblDenNgay.Location = new Point(390, 16);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(89, 24);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dddd , d  MMMM  yyyy";
            dtpTuNgay.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(95, 14);
            dtpTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(270, 28);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTuNgay.ForeColor = Color.DarkSlateBlue;
            lblTuNgay.Location = new Point(15, 16);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(76, 24);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";
            // 
            // panelCards
            // 
            panelCards.ColumnCount = 3;
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            panelCards.Controls.Add(pnlCard1, 0, 0);
            panelCards.Controls.Add(pnlCard2, 1, 0);
            panelCards.Controls.Add(pnlCard3, 2, 0);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(0, 56);
            panelCards.Margin = new Padding(3, 4, 3, 4);
            panelCards.Name = "panelCards";
            panelCards.RowCount = 1;
            panelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCards.Size = new Size(1360, 110);
            panelCards.TabIndex = 1;
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.FromArgb(255, 128, 114);
            pnlCard1.Controls.Add(lblVal1);
            pnlCard1.Controls.Add(lblTitle1);
            pnlCard1.Controls.Add(picCard1);
            pnlCard1.Dock = DockStyle.Fill;
            pnlCard1.Location = new Point(10, 10);
            pnlCard1.Margin = new Padding(10);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(433, 90);
            pnlCard1.TabIndex = 0;
            // 
            // lblVal1
            // 
            lblVal1.AutoSize = true;
            lblVal1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVal1.ForeColor = Color.White;
            lblVal1.Location = new Point(105, 45);
            lblVal1.Name = "lblVal1";
            lblVal1.Size = new Size(95, 31);
            lblVal1.TabIndex = 2;
            lblVal1.Text = "0 VND";
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle1.ForeColor = Color.White;
            lblTitle1.Location = new Point(105, 14);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(224, 26);
            lblTitle1.TabIndex = 1;
            lblTitle1.Text = "Doanh thu thuê phòng";
            // 
            // picCard1
            // 
            picCard1.Image = Properties.Resources.DoanhThuThue;
            picCard1.Location = new Point(15, 15);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(70, 60);
            picCard1.SizeMode = PictureBoxSizeMode.Zoom;
            picCard1.TabIndex = 0;
            picCard1.TabStop = false;
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.FromArgb(202, 172, 85);
            pnlCard2.Controls.Add(lblVal2);
            pnlCard2.Controls.Add(lblTitle2);
            pnlCard2.Controls.Add(picCard2);
            pnlCard2.Dock = DockStyle.Fill;
            pnlCard2.Location = new Point(463, 10);
            pnlCard2.Margin = new Padding(10);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(433, 90);
            pnlCard2.TabIndex = 1;
            // 
            // lblVal2
            // 
            lblVal2.AutoSize = true;
            lblVal2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVal2.ForeColor = Color.White;
            lblVal2.Location = new Point(105, 45);
            lblVal2.Name = "lblVal2";
            lblVal2.Size = new Size(95, 31);
            lblVal2.TabIndex = 2;
            lblVal2.Text = "0 VND";
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle2.ForeColor = Color.White;
            lblTitle2.Location = new Point(105, 14);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(181, 26);
            lblTitle2.TabIndex = 1;
            lblTitle2.Text = "Doanh thu dịch vụ";
            // 
            // picCard2
            // 
            picCard2.Image = Properties.Resources.DichVuChart;
            picCard2.Location = new Point(15, 15);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(70, 60);
            picCard2.SizeMode = PictureBoxSizeMode.Zoom;
            picCard2.TabIndex = 0;
            picCard2.TabStop = false;
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.FromArgb(135, 175, 105);
            pnlCard3.Controls.Add(lblVal3);
            pnlCard3.Controls.Add(lblTitle3);
            pnlCard3.Controls.Add(picCard3);
            pnlCard3.Dock = DockStyle.Fill;
            pnlCard3.Location = new Point(916, 10);
            pnlCard3.Margin = new Padding(10);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(434, 90);
            pnlCard3.TabIndex = 2;
            // 
            // lblVal3
            // 
            lblVal3.AutoSize = true;
            lblVal3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVal3.ForeColor = Color.White;
            lblVal3.Location = new Point(105, 45);
            lblVal3.Name = "lblVal3";
            lblVal3.Size = new Size(30, 31);
            lblVal3.TabIndex = 2;
            lblVal3.Text = "0";
            // 
            // lblTitle3
            // 
            lblTitle3.AutoSize = true;
            lblTitle3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle3.ForeColor = Color.White;
            lblTitle3.Location = new Point(105, 14);
            lblTitle3.Name = "lblTitle3";
            lblTitle3.Size = new Size(140, 26);
            lblTitle3.TabIndex = 1;
            lblTitle3.Text = "Số phòng đặt";
            // 
            // picCard3
            // 
            picCard3.Image = Properties.Resources.SoPhongDat;
            picCard3.Location = new Point(15, 15);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(70, 60);
            picCard3.SizeMode = PictureBoxSizeMode.Zoom;
            picCard3.TabIndex = 0;
            picCard3.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.ColumnCount = 2;
            panelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            panelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
            panelContent.Controls.Add(panelLeft, 0, 0);
            panelContent.Controls.Add(panelRight, 1, 0);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 166);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.RowCount = 1;
            panelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelContent.Size = new Size(1360, 684);
            panelContent.TabIndex = 2;
            // 
            // panelLeft
            // 
            panelLeft.ColumnCount = 1;
            panelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelLeft.Controls.Add(pnlHighlights, 0, 0);
            panelLeft.Controls.Add(pnlServicesChart, 0, 1);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(10, 10);
            panelLeft.Margin = new Padding(10);
            panelLeft.Name = "panelLeft";
            panelLeft.RowCount = 2;
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            panelLeft.Size = new Size(578, 664);
            panelLeft.TabIndex = 0;
            // 
            // pnlHighlights
            // 
            pnlHighlights.BackColor = Color.FromArgb(242, 230, 245);
            pnlHighlights.Controls.Add(lblTopServiceRevVal);
            pnlHighlights.Controls.Add(lblTopServiceRevTitle);
            pnlHighlights.Controls.Add(picTop3);
            pnlHighlights.Controls.Add(lblTopRoomCountVal);
            pnlHighlights.Controls.Add(lblTopRoomCountTitle);
            pnlHighlights.Controls.Add(picTop2);
            pnlHighlights.Controls.Add(lblTopRoomRevVal);
            pnlHighlights.Controls.Add(lblTopRoomRevTitle);
            pnlHighlights.Controls.Add(picTop1);
            pnlHighlights.Dock = DockStyle.Fill;
            pnlHighlights.Location = new Point(0, 0);
            pnlHighlights.Margin = new Padding(0, 0, 0, 10);
            pnlHighlights.Name = "pnlHighlights";
            pnlHighlights.Size = new Size(578, 288);
            pnlHighlights.TabIndex = 0;
            // 
            // lblTopServiceRevVal
            // 
            lblTopServiceRevVal.AutoSize = true;
            lblTopServiceRevVal.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopServiceRevVal.ForeColor = Color.MidnightBlue;
            lblTopServiceRevVal.Location = new Point(80, 230);
            lblTopServiceRevVal.Name = "lblTopServiceRevVal";
            lblTopServiceRevVal.Size = new Size(207, 26);
            lblTopServiceRevVal.TabIndex = 8;
            lblTopServiceRevVal.Text = "Chưa có dữ liệu...";
            // 
            // lblTopServiceRevTitle
            // 
            lblTopServiceRevTitle.AutoSize = true;
            lblTopServiceRevTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTopServiceRevTitle.ForeColor = Color.DarkSlateGray;
            lblTopServiceRevTitle.Location = new Point(80, 200);
            lblTopServiceRevTitle.Name = "lblTopServiceRevTitle";
            lblTopServiceRevTitle.Size = new Size(224, 24);
            lblTopServiceRevTitle.TabIndex = 7;
            lblTopServiceRevTitle.Text = "Dịch vụ doanh thu cao nhất";
            // 
            // picTop3
            // 
            picTop3.Image = Properties.Resources.top1;
            picTop3.Location = new Point(15, 195);
            picTop3.Name = "picTop3";
            picTop3.Size = new Size(55, 55);
            picTop3.SizeMode = PictureBoxSizeMode.Zoom;
            picTop3.TabIndex = 6;
            picTop3.TabStop = false;
            // 
            // lblTopRoomCountVal
            // 
            lblTopRoomCountVal.AutoSize = true;
            lblTopRoomCountVal.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopRoomCountVal.ForeColor = Color.MidnightBlue;
            lblTopRoomCountVal.Location = new Point(80, 140);
            lblTopRoomCountVal.Name = "lblTopRoomCountVal";
            lblTopRoomCountVal.Size = new Size(207, 26);
            lblTopRoomCountVal.TabIndex = 5;
            lblTopRoomCountVal.Text = "Chưa có dữ liệu...";
            // 
            // lblTopRoomCountTitle
            // 
            lblTopRoomCountTitle.AutoSize = true;
            lblTopRoomCountTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTopRoomCountTitle.ForeColor = Color.DarkSlateGray;
            lblTopRoomCountTitle.Location = new Point(80, 110);
            lblTopRoomCountTitle.Name = "lblTopRoomCountTitle";
            lblTopRoomCountTitle.Size = new Size(257, 24);
            lblTopRoomCountTitle.TabIndex = 4;
            lblTopRoomCountTitle.Text = "Loại phòng được đặt nhiều nhất";
            // 
            // picTop2
            // 
            picTop2.Image = Properties.Resources.top1;
            picTop2.Location = new Point(15, 105);
            picTop2.Name = "picTop2";
            picTop2.Size = new Size(55, 55);
            picTop2.SizeMode = PictureBoxSizeMode.Zoom;
            picTop2.TabIndex = 3;
            picTop2.TabStop = false;
            // 
            // lblTopRoomRevVal
            // 
            lblTopRoomRevVal.AutoSize = true;
            lblTopRoomRevVal.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopRoomRevVal.ForeColor = Color.MidnightBlue;
            lblTopRoomRevVal.Location = new Point(80, 50);
            lblTopRoomRevVal.Name = "lblTopRoomRevVal";
            lblTopRoomRevVal.Size = new Size(207, 26);
            lblTopRoomRevVal.TabIndex = 2;
            lblTopRoomRevVal.Text = "Chưa có dữ liệu...";
            // 
            // lblTopRoomRevTitle
            // 
            lblTopRoomRevTitle.AutoSize = true;
            lblTopRoomRevTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTopRoomRevTitle.ForeColor = Color.DarkSlateGray;
            lblTopRoomRevTitle.Location = new Point(80, 20);
            lblTopRoomRevTitle.Name = "lblTopRoomRevTitle";
            lblTopRoomRevTitle.Size = new Size(251, 24);
            lblTopRoomRevTitle.TabIndex = 1;
            lblTopRoomRevTitle.Text = "Loại phòng doanh thu cao nhất";
            // 
            // picTop1
            // 
            picTop1.Image = Properties.Resources.top1;
            picTop1.Location = new Point(15, 15);
            picTop1.Name = "picTop1";
            picTop1.Size = new Size(55, 55);
            picTop1.SizeMode = PictureBoxSizeMode.Zoom;
            picTop1.TabIndex = 0;
            picTop1.TabStop = false;
            // 
            // pnlServicesChart
            // 
            pnlServicesChart.BackColor = Color.FromArgb(242, 230, 245);
            pnlServicesChart.Controls.Add(picServicesPieChart);
            pnlServicesChart.Controls.Add(lblServicesChartTitle);
            pnlServicesChart.Dock = DockStyle.Fill;
            pnlServicesChart.Location = new Point(0, 308);
            pnlServicesChart.Margin = new Padding(0);
            pnlServicesChart.Name = "pnlServicesChart";
            pnlServicesChart.Size = new Size(578, 356);
            pnlServicesChart.TabIndex = 1;
            // 
            // picServicesPieChart
            // 
            picServicesPieChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picServicesPieChart.BackColor = Color.Transparent;
            picServicesPieChart.Location = new Point(10, 45);
            picServicesPieChart.Name = "picServicesPieChart";
            picServicesPieChart.Size = new Size(558, 300);
            picServicesPieChart.TabIndex = 1;
            picServicesPieChart.TabStop = false;
            picServicesPieChart.Paint += picServicesPieChart_Paint;
            // 
            // lblServicesChartTitle
            // 
            lblServicesChartTitle.AutoSize = true;
            lblServicesChartTitle.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServicesChartTitle.ForeColor = Color.DarkCyan;
            lblServicesChartTitle.Location = new Point(15, 12);
            lblServicesChartTitle.Name = "lblServicesChartTitle";
            lblServicesChartTitle.Size = new Size(244, 26);
            lblServicesChartTitle.TabIndex = 0;
            lblServicesChartTitle.Text = "Các dịch vụ được sử dụng";
            // 
            // panelRight
            // 
            panelRight.ColumnCount = 1;
            panelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelRight.Controls.Add(pnlRoomRevChart, 0, 0);
            panelRight.Controls.Add(pnlRoomBookingsChart, 0, 1);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(608, 10);
            panelRight.Margin = new Padding(10);
            panelRight.Name = "panelRight";
            panelRight.RowCount = 2;
            panelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelRight.Size = new Size(742, 664);
            panelRight.TabIndex = 1;
            // 
            // pnlRoomRevChart
            // 
            pnlRoomRevChart.BackColor = Color.FromArgb(242, 230, 245);
            pnlRoomRevChart.Controls.Add(picRoomRevBarChart);
            pnlRoomRevChart.Controls.Add(lblRoomRevChartTitle);
            pnlRoomRevChart.Dock = DockStyle.Fill;
            pnlRoomRevChart.Location = new Point(0, 0);
            pnlRoomRevChart.Margin = new Padding(0, 0, 0, 10);
            pnlRoomRevChart.Name = "pnlRoomRevChart";
            pnlRoomRevChart.Size = new Size(742, 322);
            pnlRoomRevChart.TabIndex = 0;
            // 
            // picRoomRevBarChart
            // 
            picRoomRevBarChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picRoomRevBarChart.BackColor = Color.Transparent;
            picRoomRevBarChart.Location = new Point(10, 45);
            picRoomRevBarChart.Name = "picRoomRevBarChart";
            picRoomRevBarChart.Size = new Size(720, 265);
            picRoomRevBarChart.TabIndex = 1;
            picRoomRevBarChart.TabStop = false;
            picRoomRevBarChart.Paint += picRoomRevBarChart_Paint;
            // 
            // lblRoomRevChartTitle
            // 
            lblRoomRevChartTitle.AutoSize = true;
            lblRoomRevChartTitle.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomRevChartTitle.ForeColor = Color.DarkCyan;
            lblRoomRevChartTitle.Location = new Point(15, 12);
            lblRoomRevChartTitle.Name = "lblRoomRevChartTitle";
            lblRoomRevChartTitle.Size = new Size(224, 26);
            lblRoomRevChartTitle.TabIndex = 0;
            lblRoomRevChartTitle.Text = "Doanh thu thuê phòng";
            // 
            // pnlRoomBookingsChart
            // 
            pnlRoomBookingsChart.BackColor = Color.FromArgb(242, 230, 245);
            pnlRoomBookingsChart.Controls.Add(picRoomBookingsBarChart);
            pnlRoomBookingsChart.Controls.Add(lblRoomBookingsChartTitle);
            pnlRoomBookingsChart.Dock = DockStyle.Fill;
            pnlRoomBookingsChart.Location = new Point(0, 332);
            pnlRoomBookingsChart.Margin = new Padding(0);
            pnlRoomBookingsChart.Name = "pnlRoomBookingsChart";
            pnlRoomBookingsChart.Size = new Size(742, 332);
            pnlRoomBookingsChart.TabIndex = 1;
            // 
            // picRoomBookingsBarChart
            // 
            picRoomBookingsBarChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picRoomBookingsBarChart.BackColor = Color.Transparent;
            picRoomBookingsBarChart.Location = new Point(10, 45);
            picRoomBookingsBarChart.Name = "picRoomBookingsBarChart";
            picRoomBookingsBarChart.Size = new Size(720, 275);
            picRoomBookingsBarChart.TabIndex = 1;
            picRoomBookingsBarChart.TabStop = false;
            picRoomBookingsBarChart.Paint += picRoomBookingsBarChart_Paint;
            // 
            // lblRoomBookingsChartTitle
            // 
            lblRoomBookingsChartTitle.AutoSize = true;
            lblRoomBookingsChartTitle.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomBookingsChartTitle.ForeColor = Color.DarkCyan;
            lblRoomBookingsChartTitle.Location = new Point(15, 12);
            lblRoomBookingsChartTitle.Name = "lblRoomBookingsChartTitle";
            lblRoomBookingsChartTitle.Size = new Size(187, 26);
            lblRoomBookingsChartTitle.TabIndex = 0;
            lblRoomBookingsChartTitle.Text = "Số phòng được đặt";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1360, 850);
            Controls.Add(panelContent);
            Controls.Add(panelCards);
            Controls.Add(panelHeader);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCards.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            panelContent.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            pnlHighlights.ResumeLayout(false);
            pnlHighlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTop3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTop2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTop1).EndInit();
            pnlServicesChart.ResumeLayout(false);
            pnlServicesChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picServicesPieChart).EndInit();
            panelRight.ResumeLayout(false);
            pnlRoomRevChart.ResumeLayout(false);
            pnlRoomRevChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRoomRevBarChart).EndInit();
            pnlRoomBookingsChart.ResumeLayout(false);
            pnlRoomBookingsChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRoomBookingsBarChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnXemThongKe;
        private TableLayoutPanel panelCards;
        private Panel pnlCard1;
        private Label lblVal1;
        private Label lblTitle1;
        private PictureBox picCard1;
        private Panel pnlCard2;
        private Label lblVal2;
        private Label lblTitle2;
        private PictureBox picCard2;
        private Panel pnlCard3;
        private Label lblVal3;
        private Label lblTitle3;
        private PictureBox picCard3;
        private TableLayoutPanel panelContent;
        private TableLayoutPanel panelLeft;
        private Panel pnlHighlights;
        private PictureBox picTop1;
        private Label lblTopRoomRevTitle;
        private Label lblTopRoomRevVal;
        private PictureBox picTop2;
        private Label lblTopRoomCountTitle;
        private Label lblTopRoomCountVal;
        private PictureBox picTop3;
        private Label lblTopServiceRevTitle;
        private Label lblTopServiceRevVal;
        private Panel pnlServicesChart;
        private Label lblServicesChartTitle;
        private PictureBox picServicesPieChart;
        private TableLayoutPanel panelRight;
        private Panel pnlRoomRevChart;
        private Label lblRoomRevChartTitle;
        private PictureBox picRoomRevBarChart;
        private Panel pnlRoomBookingsChart;
        private Label lblRoomBookingsChartTitle;
        private PictureBox picRoomBookingsBarChart;
    }
}
