namespace Premier
{
    partial class OntarioPremier
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
            lstPremiers = new ListBox();
            picPremier = new PictureBox();
            lbName = new Label();
            lbLife = new Label();
            lbTerm = new Label();
            ((System.ComponentModel.ISupportInitialize)picPremier).BeginInit();
            SuspendLayout();
            // 
            // lstPremiers
            // 
            lstPremiers.FormattingEnabled = true;
            lstPremiers.Location = new Point(886, 12);
            lstPremiers.Name = "lstPremiers";
            lstPremiers.ScrollAlwaysVisible = true;
            lstPremiers.Size = new Size(360, 740);
            lstPremiers.TabIndex = 0;
            // 
            // picPremier
            // 
            picPremier.Location = new Point(117, 119);
            picPremier.Name = "picPremier";
            picPremier.Size = new Size(320, 397);
            picPremier.TabIndex = 1;
            picPremier.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(117, 52);
            lbName.Name = "lbName";
            lbName.Size = new Size(78, 32);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // lbLife
            // 
            lbLife.AutoSize = true;
            lbLife.Location = new Point(112, 547);
            lbLife.Name = "lbLife";
            lbLife.Size = new Size(52, 32);
            lbLife.TabIndex = 3;
            lbLife.Text = "Life";
            // 
            // lbTerm
            // 
            lbTerm.AutoSize = true;
            lbTerm.Location = new Point(116, 613);
            lbTerm.Name = "lbTerm";
            lbTerm.Size = new Size(67, 32);
            lbTerm.TabIndex = 4;
            lbTerm.Text = "Term";
            // 
            // OntarioPremier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1258, 772);
            Controls.Add(lbTerm);
            Controls.Add(lbLife);
            Controls.Add(lbName);
            Controls.Add(picPremier);
            Controls.Add(lstPremiers);
            Name = "OntarioPremier";
            Text = "Ontario's Premier";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPremier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPremiers;
        private PictureBox picPremier;
        private Label lbName;
        private Label lbLife;
        private Label lbTerm;
    }
}
