namespace Group_Assignment9
{
    partial class ReportsForm
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
            dvgHighAchivers = new DataGridView();
            dvgByDepartment = new DataGridView();
            dvgFailures = new DataGridView();
            lbHighAchivers = new Label();
            lbByDepartment = new Label();
            lbFailures = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgHighAchivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgByDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgFailures).BeginInit();
            SuspendLayout();
            // 
            // dvgHighAchivers
            // 
            dvgHighAchivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgHighAchivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgHighAchivers.Location = new Point(259, 46);
            dvgHighAchivers.Name = "dvgHighAchivers";
            dvgHighAchivers.RowHeadersWidth = 82;
            dvgHighAchivers.Size = new Size(1268, 227);
            dvgHighAchivers.TabIndex = 0;
            // 
            // dvgByDepartment
            // 
            dvgByDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgByDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgByDepartment.Location = new Point(259, 329);
            dvgByDepartment.Name = "dvgByDepartment";
            dvgByDepartment.RowHeadersWidth = 82;
            dvgByDepartment.Size = new Size(709, 253);
            dvgByDepartment.TabIndex = 1;
            // 
            // dvgFailures
            // 
            dvgFailures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgFailures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgFailures.Location = new Point(259, 640);
            dvgFailures.Name = "dvgFailures";
            dvgFailures.RowHeadersWidth = 82;
            dvgFailures.Size = new Size(1268, 235);
            dvgFailures.TabIndex = 2;
            dvgFailures.CellContentClick += dvgFailures_CellContentClick;
            // 
            // lbHighAchivers
            // 
            lbHighAchivers.AutoSize = true;
            lbHighAchivers.Location = new Point(36, 138);
            lbHighAchivers.Name = "lbHighAchivers";
            lbHighAchivers.Size = new Size(161, 32);
            lbHighAchivers.TabIndex = 3;
            lbHighAchivers.Text = "High Achivers";
            // 
            // lbByDepartment
            // 
            lbByDepartment.AutoSize = true;
            lbByDepartment.Location = new Point(36, 408);
            lbByDepartment.Name = "lbByDepartment";
            lbByDepartment.Size = new Size(175, 32);
            lbByDepartment.TabIndex = 4;
            lbByDepartment.Text = "By Department";
            // 
            // lbFailures
            // 
            lbFailures.AutoSize = true;
            lbFailures.Location = new Point(119, 743);
            lbFailures.Name = "lbFailures";
            lbFailures.Size = new Size(94, 32);
            lbFailures.TabIndex = 5;
            lbFailures.Text = "Failures";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 971);
            Controls.Add(lbFailures);
            Controls.Add(lbByDepartment);
            Controls.Add(lbHighAchivers);
            Controls.Add(dvgFailures);
            Controls.Add(dvgByDepartment);
            Controls.Add(dvgHighAchivers);
            Name = "ReportsForm";
            Text = "Reports";
            Load += ReportsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dvgHighAchivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgByDepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgFailures).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgHighAchivers;
        private DataGridView dvgByDepartment;
        private DataGridView dvgFailures;
        private Label lbHighAchivers;
        private Label lbByDepartment;
        private Label lbFailures;
    }
}