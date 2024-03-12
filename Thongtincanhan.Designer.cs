using System.Drawing;
using System.Windows.Forms;

namespace btl_cafe
{
    partial class Thongtincanhan
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
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            txbDisplayName = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            txbPassWord = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            textBox2 = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            textBox3 = new TextBox();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 68);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(193, 29);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 24);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(461, 31);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbDisplayName);
            panel1.Location = new Point(12, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 68);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 24);
            label2.Name = "label2";
            label2.Size = new Size(157, 29);
            label2.TabIndex = 2;
            label2.Text = "Tên hiển thị:";
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(253, 24);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(461, 31);
            txbDisplayName.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txbPassWord);
            panel3.Location = new Point(12, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(736, 68);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 24);
            label3.Name = "label3";
            label3.Size = new Size(125, 29);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(253, 24);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(461, 31);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(12, 269);
            panel4.Name = "panel4";
            panel4.Size = new Size(736, 68);
            panel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 24);
            label4.Name = "label4";
            label4.Size = new Size(177, 29);
            label4.TabIndex = 2;
            label4.Text = "Mật khẩu mới:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(461, 31);
            textBox2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox3);
            panel5.Location = new Point(12, 356);
            panel5.Name = "panel5";
            panel5.Size = new Size(736, 68);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 24);
            label5.Name = "label5";
            label5.Size = new Size(114, 29);
            label5.TabIndex = 2;
            label5.Text = "Nhập lại:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(253, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(461, 31);
            textBox3.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.Location = new Point(451, 442);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 50);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveBorder;
            btnExit.Location = new Point(623, 442);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 50);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // fAcountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(768, 504);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAcountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAcountProfile";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private TextBox txbDisplayName;
        private Panel panel3;
        private Label label3;
        private TextBox txbPassWord;
        private Panel panel4;
        private Label label4;
        private TextBox textBox2;
        private Panel panel5;
        private Label label5;
        private TextBox textBox3;
        private Button btnUpdate;
        private Button btnExit;


    }
}