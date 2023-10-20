namespace SRM_Hang
{
    partial class SRM_Hang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_tim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng:";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(162, 68);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(221, 22);
            this.txt_ma.TabIndex = 2;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(162, 127);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(221, 22);
            this.txt_ten.TabIndex = 3;
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(39, 187);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 23);
            this.button_them.TabIndex = 4;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(162, 187);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 23);
            this.button_xoa.TabIndex = 5;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(284, 187);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 23);
            this.button_sua.TabIndex = 6;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(421, 187);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 7;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            // 
            // button_tim
            // 
            this.button_tim.Location = new System.Drawing.Point(73, 235);
            this.button_tim.Name = "button_tim";
            this.button_tim.Size = new System.Drawing.Size(75, 23);
            this.button_tim.TabIndex = 8;
            this.button_tim.Text = "Tìm kiếm";
            this.button_tim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_tim);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_tim;
    }
}

