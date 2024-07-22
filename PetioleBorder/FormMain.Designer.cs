namespace PetioleBorder
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.graphY = new ZedGraph.ZedGraphControl();
            this.graphPetioleX = new ZedGraph.ZedGraphControl();
            this.panelX = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.graphProximalX = new ZedGraph.ZedGraphControl();
            this.graphX = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.picResults = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.picDistal = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picProximal = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picPetiole = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picLamina = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusLabelXY = new System.Windows.Forms.Label();
            this.btnSegmentation = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelPicSource = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picOriginalLeaf = new System.Windows.Forms.PictureBox();
            this.labLeafName = new System.Windows.Forms.Label();
            this.panelX.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProximal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPetiole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelPicSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalLeaf)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "All files|*.*|Bitmap files|*.bmp|TIFF files|*.tif";
            // 
            // graphY
            // 
            this.graphY.Location = new System.Drawing.Point(40, 32);
            this.graphY.Name = "graphY";
            this.graphY.ScrollGrace = 0D;
            this.graphY.ScrollMaxX = 0D;
            this.graphY.ScrollMaxY = 0D;
            this.graphY.ScrollMaxY2 = 0D;
            this.graphY.ScrollMinX = 0D;
            this.graphY.ScrollMinY = 0D;
            this.graphY.ScrollMinY2 = 0D;
            this.graphY.Size = new System.Drawing.Size(516, 220);
            this.graphY.TabIndex = 103;
            this.graphY.UseExtendedPrintDialog = true;
            this.graphY.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphY_MouseDoubleClick);
            // 
            // graphPetioleX
            // 
            this.graphPetioleX.BackColor = System.Drawing.Color.White;
            this.graphPetioleX.Location = new System.Drawing.Point(562, 32);
            this.graphPetioleX.Name = "graphPetioleX";
            this.graphPetioleX.ScrollGrace = 0D;
            this.graphPetioleX.ScrollMaxX = 0D;
            this.graphPetioleX.ScrollMaxY = 0D;
            this.graphPetioleX.ScrollMaxY2 = 0D;
            this.graphPetioleX.ScrollMinX = 0D;
            this.graphPetioleX.ScrollMinY = 0D;
            this.graphPetioleX.ScrollMinY2 = 0D;
            this.graphPetioleX.Size = new System.Drawing.Size(516, 220);
            this.graphPetioleX.TabIndex = 105;
            this.graphPetioleX.UseExtendedPrintDialog = true;
            this.graphPetioleX.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphPetioleX_MouseDoubleClick);
            // 
            // panelX
            // 
            this.panelX.BackColor = System.Drawing.Color.DarkGray;
            this.panelX.Controls.Add(this.label11);
            this.panelX.Controls.Add(this.label4);
            this.panelX.Controls.Add(this.graphProximalX);
            this.panelX.Controls.Add(this.graphX);
            this.panelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelX.Location = new System.Drawing.Point(0, 0);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(1110, 265);
            this.panelX.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(733, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 109;
            this.label11.Text = "Cropped leaf: proximal image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(241, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Original leaf image";
            // 
            // graphProximalX
            // 
            this.graphProximalX.BackColor = System.Drawing.Color.White;
            this.graphProximalX.Location = new System.Drawing.Point(562, 31);
            this.graphProximalX.Name = "graphProximalX";
            this.graphProximalX.ScrollGrace = 0D;
            this.graphProximalX.ScrollMaxX = 0D;
            this.graphProximalX.ScrollMaxY = 0D;
            this.graphProximalX.ScrollMaxY2 = 0D;
            this.graphProximalX.ScrollMinX = 0D;
            this.graphProximalX.ScrollMinY = 0D;
            this.graphProximalX.ScrollMinY2 = 0D;
            this.graphProximalX.Size = new System.Drawing.Size(516, 220);
            this.graphProximalX.TabIndex = 106;
            this.graphProximalX.UseExtendedPrintDialog = true;
            this.graphProximalX.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphProximalX_MouseDoubleClick);
            // 
            // graphX
            // 
            this.graphX.Location = new System.Drawing.Point(40, 31);
            this.graphX.Name = "graphX";
            this.graphX.ScrollGrace = 0D;
            this.graphX.ScrollMaxX = 0D;
            this.graphX.ScrollMaxY = 0D;
            this.graphX.ScrollMaxY2 = 0D;
            this.graphX.ScrollMinX = 0D;
            this.graphX.ScrollMinY = 0D;
            this.graphX.ScrollMinY2 = 0D;
            this.graphX.Size = new System.Drawing.Size(516, 220);
            this.graphX.TabIndex = 105;
            this.graphX.UseExtendedPrintDialog = true;
            this.graphX.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphX_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.graphPetioleX);
            this.panel1.Controls.Add(this.graphY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 265);
            this.panel1.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(733, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Cropped leaf: petiole image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(241, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "Original leaf image";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.linkGitHub);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.picResults);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.picDistal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.picProximal);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.picPetiole);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.picLamina);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 235);
            this.panel2.TabIndex = 108;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGitHub.LinkColor = System.Drawing.Color.SlateBlue;
            this.linkGitHub.Location = new System.Drawing.Point(1293, 206);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(159, 18);
            this.linkGitHub.TabIndex = 127;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "Go to my GitHub page!";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(771, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(695, 189);
            this.richTextBox1.TabIndex = 126;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // picResults
            // 
            this.picResults.BackColor = System.Drawing.Color.DimGray;
            this.picResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResults.Location = new System.Drawing.Point(624, 28);
            this.picResults.Name = "picResults";
            this.picResults.Size = new System.Drawing.Size(130, 170);
            this.picResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResults.TabIndex = 119;
            this.picResults.TabStop = false;
            this.picResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picResults_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(625, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 120;
            this.label10.Text = "Result";
            // 
            // picDistal
            // 
            this.picDistal.BackColor = System.Drawing.Color.DimGray;
            this.picDistal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDistal.Location = new System.Drawing.Point(469, 28);
            this.picDistal.Name = "picDistal";
            this.picDistal.Size = new System.Drawing.Size(130, 170);
            this.picDistal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDistal.TabIndex = 117;
            this.picDistal.TabStop = false;
            this.picDistal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picDistal_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(470, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 118;
            this.label9.Text = "Distal";
            // 
            // picProximal
            // 
            this.picProximal.BackColor = System.Drawing.Color.DimGray;
            this.picProximal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProximal.Location = new System.Drawing.Point(319, 28);
            this.picProximal.Name = "picProximal";
            this.picProximal.Size = new System.Drawing.Size(130, 170);
            this.picProximal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProximal.TabIndex = 115;
            this.picProximal.TabStop = false;
            this.picProximal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picProximal_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(320, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 116;
            this.label8.Text = "Proximal";
            // 
            // picPetiole
            // 
            this.picPetiole.BackColor = System.Drawing.Color.DimGray;
            this.picPetiole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPetiole.Location = new System.Drawing.Point(167, 28);
            this.picPetiole.Name = "picPetiole";
            this.picPetiole.Size = new System.Drawing.Size(130, 170);
            this.picPetiole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPetiole.TabIndex = 113;
            this.picPetiole.TabStop = false;
            this.picPetiole.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picPetiole_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(168, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 114;
            this.label7.Text = "Petiole";
            // 
            // picLamina
            // 
            this.picLamina.BackColor = System.Drawing.Color.DimGray;
            this.picLamina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamina.Location = new System.Drawing.Point(16, 28);
            this.picLamina.Name = "picLamina";
            this.picLamina.Size = new System.Drawing.Size(130, 170);
            this.picLamina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLamina.TabIndex = 111;
            this.picLamina.TabStop = false;
            this.picLamina.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picLamina_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(17, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Lamina (Leaf blade)";
            // 
            // statusLabelXY
            // 
            this.statusLabelXY.AutoSize = true;
            this.statusLabelXY.Location = new System.Drawing.Point(270, 24);
            this.statusLabelXY.Name = "statusLabelXY";
            this.statusLabelXY.Size = new System.Drawing.Size(51, 13);
            this.statusLabelXY.TabIndex = 123;
            this.statusLabelXY.Text = "X: 0, Y: 0";
            // 
            // btnSegmentation
            // 
            this.btnSegmentation.Enabled = false;
            this.btnSegmentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSegmentation.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSegmentation.Location = new System.Drawing.Point(129, 477);
            this.btnSegmentation.Name = "btnSegmentation";
            this.btnSegmentation.Size = new System.Drawing.Size(115, 36);
            this.btnSegmentation.TabIndex = 1;
            this.btnSegmentation.Text = "Segmentation";
            this.btnSegmentation.UseVisualStyleBackColor = true;
            this.btnSegmentation.Click += new System.EventHandler(this.btnSegmentation_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(15, 15);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelPicSource);
            this.splitContainer1.Panel1MinSize = 370;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelX);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1484, 530);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 109;
            // 
            // panelPicSource
            // 
            this.panelPicSource.BackColor = System.Drawing.Color.DarkGray;
            this.panelPicSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicSource.Controls.Add(this.labLeafName);
            this.panelPicSource.Controls.Add(this.btnAbout);
            this.panelPicSource.Controls.Add(this.btnLoadImage);
            this.panelPicSource.Controls.Add(this.statusLabelXY);
            this.panelPicSource.Controls.Add(this.label1);
            this.panelPicSource.Controls.Add(this.btnSegmentation);
            this.panelPicSource.Controls.Add(this.picOriginalLeaf);
            this.panelPicSource.Location = new System.Drawing.Point(3, 3);
            this.panelPicSource.Name = "panelPicSource";
            this.panelPicSource.Size = new System.Drawing.Size(350, 524);
            this.panelPicSource.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbout.Location = new System.Drawing.Point(250, 477);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(85, 36);
            this.btnAbout.TabIndex = 124;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoadImage.Location = new System.Drawing.Point(15, 477);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(108, 36);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Leaf Image";
            // 
            // picOriginalLeaf
            // 
            this.picOriginalLeaf.BackColor = System.Drawing.Color.DimGray;
            this.picOriginalLeaf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginalLeaf.Location = new System.Drawing.Point(15, 50);
            this.picOriginalLeaf.Name = "picOriginalLeaf";
            this.picOriginalLeaf.Size = new System.Drawing.Size(320, 391);
            this.picOriginalLeaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriginalLeaf.TabIndex = 0;
            this.picOriginalLeaf.TabStop = false;
            this.picOriginalLeaf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picLeafSource_MouseDoubleClick);
            this.picOriginalLeaf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picLeafSource_MouseMove);
            // 
            // labLeafName
            // 
            this.labLeafName.AutoSize = true;
            this.labLeafName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labLeafName.Location = new System.Drawing.Point(16, 448);
            this.labLeafName.Name = "labLeafName";
            this.labLeafName.Size = new System.Drawing.Size(170, 18);
            this.labLeafName.TabIndex = 125;
            this.labLeafName.Text = "Waiting for a leaf image..";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1514, 810);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petiole Border Detector";
            this.panelX.ResumeLayout(false);
            this.panelX.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProximal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPetiole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamina)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelPicSource.ResumeLayout(false);
            this.panelPicSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalLeaf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ZedGraph.ZedGraphControl graphY;
        private ZedGraph.ZedGraphControl graphPetioleX;
        private System.Windows.Forms.Panel panelX;
        private ZedGraph.ZedGraphControl graphProximalX;
        private ZedGraph.ZedGraphControl graphX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLamina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picPetiole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picProximal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picDistal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picResults;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSegmentation;
        private System.Windows.Forms.Label statusLabelXY;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelPicSource;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picOriginalLeaf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.Label labLeafName;
    }
}

