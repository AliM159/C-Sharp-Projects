namespace GenericsStack
{
    partial class StackImplementationApp
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
            lbInput = new Label();
            textBox1 = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            lbType = new Label();
            btnClear = new Button();
            lbStatus = new Label();
            comboBox1 = new ComboBox();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(195, 113);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(132, 32);
            lbInput.TabIndex = 0;
            lbInput.Text = "Stack Input";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 39);
            textBox1.TabIndex = 1;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(281, 283);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(268, 100);
            btnPush.TabIndex = 2;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(601, 283);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(268, 100);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(1089, 273);
            lbType.Name = "lbType";
            lbType.Size = new Size(128, 32);
            lbType.TabIndex = 4;
            lbType.Text = "Input Type";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1012, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(268, 100);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Stack";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(630, 675);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(78, 32);
            lbStatus.TabIndex = 6;
            lbStatus.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1038, 343);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Select";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(281, 444);
            listBox.Name = "listBox";
            listBox.Size = new Size(371, 196);
            listBox.TabIndex = 8;
            // 
            // StackImplementationApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 776);
            Controls.Add(listBox);
            Controls.Add(comboBox1);
            Controls.Add(lbStatus);
            Controls.Add(btnClear);
            Controls.Add(lbType);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(textBox1);
            Controls.Add(lbInput);
            Name = "StackImplementationApp";
            Text = "Stack Implementation App";
            Load += StackImplementationApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInput;
        private TextBox textBox1;
        private Button btnPush;
        private Button btnPop;
        private Label lbType;
        private Button btnClear;
        private Label lbStatus;
        private ComboBox comboBox1;
        private ListBox listBox;
    }
}
