namespace CYOA_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            this.locationImage = new System.Windows.Forms.PictureBox();
            this.sideImageL = new System.Windows.Forms.PictureBox();
            this.sideImageR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideImageL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideImageR)).BeginInit();
            this.SuspendLayout();
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Location = new System.Drawing.Point(46, 312);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.MinimumSize = new System.Drawing.Size(257, 23);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(257, 23);
            this.blueLabel.TabIndex = 0;
            this.blueLabel.Text = "label1";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(46, 348);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.MinimumSize = new System.Drawing.Size(257, 23);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(257, 23);
            this.redLabel.TabIndex = 1;
            this.redLabel.Text = "label1";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(25, 25);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(339, 257);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "label1";
            // 
            // blueImage
            // 
            this.blueImage.Image = global::CYOA_game.Properties.Resources.blue_50x50;
            this.blueImage.Location = new System.Drawing.Point(3, 302);
            this.blueImage.Margin = new System.Windows.Forms.Padding(2);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(39, 32);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 3;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.Image = global::CYOA_game.Properties.Resources.red_50x50;
            this.redImage.Location = new System.Drawing.Point(3, 338);
            this.redImage.Margin = new System.Windows.Forms.Padding(2);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(39, 32);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 2;
            this.redImage.TabStop = false;
            // 
            // locationImage
            // 
            this.locationImage.Location = new System.Drawing.Point(136, 171);
            this.locationImage.Name = "locationImage";
            this.locationImage.Size = new System.Drawing.Size(250, 250);
            this.locationImage.TabIndex = 7;
            this.locationImage.TabStop = false;
            // 
            // sideImageL
            // 
            this.sideImageL.Location = new System.Drawing.Point(12, 171);
            this.sideImageL.Name = "sideImageL";
            this.sideImageL.Size = new System.Drawing.Size(125, 125);
            this.sideImageL.TabIndex = 9;
            this.sideImageL.TabStop = false;
            // 
            // sideImageR
            // 
            this.sideImageR.Location = new System.Drawing.Point(249, 171);
            this.sideImageR.Name = "sideImageR";
            this.sideImageR.Size = new System.Drawing.Size(125, 125);
            this.sideImageR.TabIndex = 10;
            this.sideImageR.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(386, 422);
            this.Controls.Add(this.sideImageR);
            this.Controls.Add(this.sideImageL);
            this.Controls.Add(this.locationImage);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Buyer 3000";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideImageL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideImageR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox locationImage;
        private System.Windows.Forms.PictureBox sideImageL;
        private System.Windows.Forms.PictureBox sideImageR;
    }
}

