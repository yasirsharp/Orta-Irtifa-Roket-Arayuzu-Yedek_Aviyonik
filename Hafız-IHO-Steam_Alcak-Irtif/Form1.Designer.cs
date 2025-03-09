
namespace Hafız_IHO_Steam_Alcak_Irtif
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComPortCloseButton = new System.Windows.Forms.Button();
            this.ComPortBox = new System.Windows.Forms.ComboBox();
            this.ComPortStatus = new System.Windows.Forms.ProgressBar();
            this.ComPortOpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGZ = new System.Windows.Forms.Label();
            this.lblGY = new System.Windows.Forms.Label();
            this.lblGX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ndKurtarma = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.stKurtarma = new System.Windows.Forms.Button();
            this.btnGpsErr = new System.Windows.Forms.Button();
            this.lblKonum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seriP1 = new System.IO.Ports.SerialPort(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblenlem = new System.Windows.Forms.Label();
            this.lblboylam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(631, 613);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(16, 15);
            this.map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(604, 583);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.ComPortCloseButton);
            this.groupBox1.Controls.Add(this.ComPortBox);
            this.groupBox1.Controls.Add(this.ComPortStatus);
            this.groupBox1.Controls.Add(this.ComPortOpenButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(751, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(181, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Ayarları";
            // 
            // ComPortCloseButton
            // 
            this.ComPortCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortCloseButton.Location = new System.Drawing.Point(11, 123);
            this.ComPortCloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComPortCloseButton.Name = "ComPortCloseButton";
            this.ComPortCloseButton.Size = new System.Drawing.Size(160, 47);
            this.ComPortCloseButton.TabIndex = 7;
            this.ComPortCloseButton.Text = "Bağlantıyı Kes";
            this.ComPortCloseButton.UseVisualStyleBackColor = true;
            this.ComPortCloseButton.Click += new System.EventHandler(this.ComPortCloseButton_Click);
            // 
            // ComPortBox
            // 
            this.ComPortBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortBox.FormattingEnabled = true;
            this.ComPortBox.Location = new System.Drawing.Point(11, 38);
            this.ComPortBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComPortBox.Name = "ComPortBox";
            this.ComPortBox.Size = new System.Drawing.Size(159, 24);
            this.ComPortBox.TabIndex = 6;
            // 
            // ComPortStatus
            // 
            this.ComPortStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortStatus.Location = new System.Drawing.Point(11, 177);
            this.ComPortStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComPortStatus.Name = "ComPortStatus";
            this.ComPortStatus.Size = new System.Drawing.Size(160, 34);
            this.ComPortStatus.TabIndex = 5;
            this.ComPortStatus.Tag = "";
            // 
            // ComPortOpenButton
            // 
            this.ComPortOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortOpenButton.Location = new System.Drawing.Point(11, 71);
            this.ComPortOpenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComPortOpenButton.Name = "ComPortOpenButton";
            this.ComPortOpenButton.Size = new System.Drawing.Size(160, 44);
            this.ComPortOpenButton.TabIndex = 4;
            this.ComPortOpenButton.Text = "Bağlan ";
            this.ComPortOpenButton.UseVisualStyleBackColor = true;
            this.ComPortOpenButton.Click += new System.EventHandler(this.ComPortOpenButton_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lblGZ);
            this.groupBox2.Controls.Add(this.lblGY);
            this.groupBox2.Controls.Add(this.lblGX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ndKurtarma);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.stKurtarma);
            this.groupBox2.Controls.Add(this.btnGpsErr);
            this.groupBox2.Controls.Add(this.lblKonum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(636, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(704, 370);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelen Veri";
            // 
            // lblGZ
            // 
            this.lblGZ.AutoSize = true;
            this.lblGZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGZ.Location = new System.Drawing.Point(64, 268);
            this.lblGZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGZ.Name = "lblGZ";
            this.lblGZ.Size = new System.Drawing.Size(64, 39);
            this.lblGZ.TabIndex = 51;
            this.lblGZ.Text = "0,0";
            // 
            // lblGY
            // 
            this.lblGY.AutoSize = true;
            this.lblGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGY.Location = new System.Drawing.Point(64, 219);
            this.lblGY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGY.Name = "lblGY";
            this.lblGY.Size = new System.Drawing.Size(64, 39);
            this.lblGY.TabIndex = 50;
            this.lblGY.Text = "0,0";
            // 
            // lblGX
            // 
            this.lblGX.AutoSize = true;
            this.lblGX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGX.Location = new System.Drawing.Point(64, 166);
            this.lblGX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGX.Name = "lblGX";
            this.lblGX.Size = new System.Drawing.Size(64, 39);
            this.lblGX.TabIndex = 49;
            this.lblGX.Text = "0,0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 39);
            this.label6.TabIndex = 48;
            this.label6.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(13, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 39);
            this.label9.TabIndex = 47;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 39);
            this.label8.TabIndex = 46;
            this.label8.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 39);
            this.label7.TabIndex = 45;
            this.label7.Text = "Gyro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(495, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 39);
            this.label10.TabIndex = 44;
            this.label10.Text = "2. kurtarma";
            // 
            // ndKurtarma
            // 
            this.ndKurtarma.Location = new System.Drawing.Point(495, 279);
            this.ndKurtarma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ndKurtarma.Name = "ndKurtarma";
            this.ndKurtarma.Size = new System.Drawing.Size(193, 34);
            this.ndKurtarma.TabIndex = 43;
            this.ndKurtarma.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(495, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 39);
            this.label11.TabIndex = 42;
            this.label11.Text = "1. kurtarma";
            // 
            // stKurtarma
            // 
            this.stKurtarma.BackColor = System.Drawing.Color.LightYellow;
            this.stKurtarma.Location = new System.Drawing.Point(495, 199);
            this.stKurtarma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stKurtarma.Name = "stKurtarma";
            this.stKurtarma.Size = new System.Drawing.Size(193, 34);
            this.stKurtarma.TabIndex = 41;
            this.stKurtarma.UseVisualStyleBackColor = false;
            // 
            // btnGpsErr
            // 
            this.btnGpsErr.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGpsErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGpsErr.Location = new System.Drawing.Point(16, 63);
            this.btnGpsErr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGpsErr.Name = "btnGpsErr";
            this.btnGpsErr.Size = new System.Drawing.Size(203, 36);
            this.btnGpsErr.TabIndex = 33;
            this.btnGpsErr.UseVisualStyleBackColor = false;
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonum.Location = new System.Drawing.Point(9, 21);
            this.lblKonum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(143, 39);
            this.lblKonum.TabIndex = 8;
            this.lblKonum.Text = "Konum: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1095, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(245, 222);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(880, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // seriP1
            // 
            this.seriP1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.seriP1_DataReceived);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // lblenlem
            // 
            this.lblenlem.AutoSize = true;
            this.lblenlem.Location = new System.Drawing.Point(44, 16);
            this.lblenlem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblenlem.Name = "lblenlem";
            this.lblenlem.Size = new System.Drawing.Size(45, 16);
            this.lblenlem.TabIndex = 8;
            this.lblenlem.Text = "Enlem";
            // 
            // lblboylam
            // 
            this.lblboylam.AutoSize = true;
            this.lblboylam.Location = new System.Drawing.Point(44, 34);
            this.lblboylam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblboylam.Name = "lblboylam";
            this.lblboylam.Size = new System.Drawing.Size(53, 16);
            this.lblboylam.TabIndex = 19;
            this.lblboylam.Text = "Boylam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "E";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 580);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "map.position";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1348, 613);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblboylam);
            this.Controls.Add(this.lblenlem);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hafız İHO Steam Orta İrtifa - Asel 10000 - Yedek Aviyonik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ComPortStatus;
        private System.Windows.Forms.Button ComPortOpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort seriP1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox ComPortBox;
        private System.Windows.Forms.Button ComPortCloseButton;
        private System.Windows.Forms.Label lblenlem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblboylam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGpsErr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGZ;
        private System.Windows.Forms.Label lblGY;
        private System.Windows.Forms.Label lblGX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ndKurtarma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button stKurtarma;
    }
}

