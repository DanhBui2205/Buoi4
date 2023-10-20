namespace Quanlikho
{
    partial class SRM_kho
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
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_diachi = new System.Windows.Forms.TextBox();
            this.text_tenkho = new System.Windows.Forms.TextBox();
            this.button_them = new System.Windows.Forms.Button();
            this.text_makho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_xem = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(331, 235);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(101, 42);
            this.button_sua.TabIndex = 6;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(197, 235);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(101, 42);
            this.button_xoa.TabIndex = 5;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Địa chỉ:";
            // 
            // text_diachi
            // 
            this.text_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_diachi.Location = new System.Drawing.Point(264, 172);
            this.text_diachi.Name = "text_diachi";
            this.text_diachi.Size = new System.Drawing.Size(281, 30);
            this.text_diachi.TabIndex = 3;
            // 
            // text_tenkho
            // 
            this.text_tenkho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tenkho.Location = new System.Drawing.Point(264, 127);
            this.text_tenkho.Name = "text_tenkho";
            this.text_tenkho.Size = new System.Drawing.Size(281, 30);
            this.text_tenkho.TabIndex = 2;
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(65, 235);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(101, 42);
            this.button_them.TabIndex = 4;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // text_makho
            // 
            this.text_makho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_makho.Location = new System.Drawing.Point(264, 84);
            this.text_makho.Name = "text_makho";
            this.text_makho.Size = new System.Drawing.Size(281, 30);
            this.text_makho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên kho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã kho:";
            // 
            // lst_xem
            // 
            this.lst_xem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.lst_xem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_xem.HideSelection = false;
            this.lst_xem.Location = new System.Drawing.Point(79, 360);
            this.lst_xem.Name = "lst_xem";
            this.lst_xem.Size = new System.Drawing.Size(607, 227);
            this.lst_xem.TabIndex = 20;
            this.lst_xem.UseCompatibleStateImageBehavior = false;
            this.lst_xem.View = System.Windows.Forms.View.Details;
            this.lst_xem.SelectedIndexChanged += new System.EventHandler(this.lst_xem_SelectedIndexChanged);
            this.lst_xem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lst_xem_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã kho";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên kho";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Địa chỉ";
            this.columnHeader7.Width = 223;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quản lí kho";
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(622, 235);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(101, 42);
            this.button_load.TabIndex = 23;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timkiem.Location = new System.Drawing.Point(463, 235);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(120, 42);
            this.button_timkiem.TabIndex = 24;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // SRM_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 658);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_xem);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_diachi);
            this.Controls.Add(this.text_tenkho);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.text_makho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SRM_kho";
            this.Text = "SRM_kho";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_diachi;
        private System.Windows.Forms.TextBox text_tenkho;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.TextBox text_makho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_xem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_timkiem;
    }
}

