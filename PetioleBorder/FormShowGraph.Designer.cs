namespace PetioleBorder
{
    partial class FormShowGraph
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
            this.graphX = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // graphX
            // 
            this.graphX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphX.Location = new System.Drawing.Point(0, 0);
            this.graphX.Name = "graphX";
            this.graphX.ScrollGrace = 0D;
            this.graphX.ScrollMaxX = 0D;
            this.graphX.ScrollMaxY = 0D;
            this.graphX.ScrollMaxY2 = 0D;
            this.graphX.ScrollMinX = 0D;
            this.graphX.ScrollMinY = 0D;
            this.graphX.ScrollMinY2 = 0D;
            this.graphX.Size = new System.Drawing.Size(884, 511);
            this.graphX.TabIndex = 106;
            this.graphX.UseExtendedPrintDialog = true;
            // 
            // FormShowGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.graphX);
            this.Name = "FormShowGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowGraph";
            this.Shown += new System.EventHandler(this.FormShowGraph_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl graphX;
    }
}