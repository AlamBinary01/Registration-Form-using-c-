namespace WinFormsApp1
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.Label();
            this.classs = new System.Windows.Forms.Label();
            this.section = new System.Windows.Forms.Label();
            this.roll_no = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.cnic_Box = new System.Windows.Forms.TextBox();
            this.class_Box = new System.Windows.Forms.TextBox();
            this.Section_Box = new System.Windows.Forms.TextBox();
            this.Roll_Box = new System.Windows.Forms.TextBox();
            this.dob_Box = new System.Windows.Forms.TextBox();
            this.std_ = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.update_record = new System.Windows.Forms.Button();
            this.submit_record = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.search_part = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(72, 262);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(187, 262);
            this.name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(211, 23);
            this.name_Box.TabIndex = 1;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(72, 308);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(63, 20);
            this.address.TabIndex = 2;
            this.address.Text = "Address";
            // 
            // cnic
            // 
            this.cnic.AutoSize = true;
            this.cnic.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cnic.Location = new System.Drawing.Point(72, 350);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(45, 20);
            this.cnic.TabIndex = 3;
            this.cnic.Text = "CNIC";
            // 
            // classs
            // 
            this.classs.AutoSize = true;
            this.classs.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.classs.Location = new System.Drawing.Point(72, 392);
            this.classs.Name = "classs";
            this.classs.Size = new System.Drawing.Size(44, 20);
            this.classs.TabIndex = 4;
            this.classs.Text = "Class";
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.section.Location = new System.Drawing.Point(72, 433);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(58, 20);
            this.section.TabIndex = 5;
            this.section.Text = "Section";
            // 
            // roll_no
            // 
            this.roll_no.AutoSize = true;
            this.roll_no.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.roll_no.Location = new System.Drawing.Point(72, 470);
            this.roll_no.Name = "roll_no";
            this.roll_no.Size = new System.Drawing.Size(62, 20);
            this.roll_no.TabIndex = 6;
            this.roll_no.Text = "Roll No.";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dob.Location = new System.Drawing.Point(72, 502);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(48, 20);
            this.dob.TabIndex = 7;
            this.dob.Text = "D.O.B";
            this.dob.Click += new System.EventHandler(this.label1_Click);
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(187, 310);
            this.address_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(211, 23);
            this.address_box.TabIndex = 8;
            // 
            // cnic_Box
            // 
            this.cnic_Box.Location = new System.Drawing.Point(187, 350);
            this.cnic_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnic_Box.Name = "cnic_Box";
            this.cnic_Box.Size = new System.Drawing.Size(211, 23);
            this.cnic_Box.TabIndex = 9;
            // 
            // class_Box
            // 
            this.class_Box.Location = new System.Drawing.Point(187, 392);
            this.class_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.class_Box.Name = "class_Box";
            this.class_Box.Size = new System.Drawing.Size(211, 23);
            this.class_Box.TabIndex = 10;
            // 
            // Section_Box
            // 
            this.Section_Box.Location = new System.Drawing.Point(187, 433);
            this.Section_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Section_Box.Name = "Section_Box";
            this.Section_Box.Size = new System.Drawing.Size(211, 23);
            this.Section_Box.TabIndex = 11;
            this.Section_Box.TextChanged += new System.EventHandler(this.Section_Box_TextChanged);
            // 
            // Roll_Box
            // 
            this.Roll_Box.Location = new System.Drawing.Point(187, 470);
            this.Roll_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Roll_Box.Name = "Roll_Box";
            this.Roll_Box.Size = new System.Drawing.Size(211, 23);
            this.Roll_Box.TabIndex = 12;
            // 
            // dob_Box
            // 
            this.dob_Box.Location = new System.Drawing.Point(187, 505);
            this.dob_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dob_Box.Name = "dob_Box";
            this.dob_Box.Size = new System.Drawing.Size(211, 23);
            this.dob_Box.TabIndex = 13;
            // 
            // std_
            // 
            this.std_.AutoSize = true;
            this.std_.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.std_.Location = new System.Drawing.Point(422, 89);
            this.std_.Name = "std_";
            this.std_.Size = new System.Drawing.Size(409, 33);
            this.std_.TabIndex = 14;
            this.std_.Text = "Student Registration Form";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(44, 589);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(108, 45);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Search By CNIC";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // update_record
            // 
            this.update_record.Location = new System.Drawing.Point(335, 589);
            this.update_record.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_record.Name = "update_record";
            this.update_record.Size = new System.Drawing.Size(108, 45);
            this.update_record.TabIndex = 16;
            this.update_record.Text = "Update Record";
            this.update_record.UseVisualStyleBackColor = true;
            this.update_record.Click += new System.EventHandler(this.update_record_Click);
            // 
            // submit_record
            // 
            this.submit_record.Location = new System.Drawing.Point(191, 589);
            this.submit_record.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_record.Name = "submit_record";
            this.submit_record.Size = new System.Drawing.Size(108, 45);
            this.submit_record.TabIndex = 17;
            this.submit_record.Text = "Submit Record";
            this.submit_record.UseVisualStyleBackColor = true;
            this.submit_record.Click += new System.EventHandler(this.submit_record_Click);
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(520, 195);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 25;
            this.DGV.Size = new System.Drawing.Size(840, 390);
            this.DGV.TabIndex = 18;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // search_part
            // 
            this.search_part.AutoSize = true;
            this.search_part.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_part.Location = new System.Drawing.Point(520, 164);
            this.search_part.Name = "search_part";
            this.search_part.Size = new System.Drawing.Size(87, 20);
            this.search_part.TabIndex = 19;
            this.search_part.Text = "Search Part";
            this.search_part.Click += new System.EventHandler(this.search_part_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1372, 712);
            this.Controls.Add(this.search_part);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.submit_record);
            this.Controls.Add(this.update_record);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.std_);
            this.Controls.Add(this.dob_Box);
            this.Controls.Add(this.Roll_Box);
            this.Controls.Add(this.Section_Box);
            this.Controls.Add(this.class_Box);
            this.Controls.Add(this.cnic_Box);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.roll_no);
            this.Controls.Add(this.section);
            this.Controls.Add(this.classs);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label name;
        private TextBox name_Box;
        private Label address;
        private Label cnic;
        private Label classs;
        private Label section;
        private Label roll_no;
        private Label dob;
        private TextBox address_box;
        private TextBox cnic_Box;
        private TextBox class_Box;
        private TextBox Section_Box;
        private TextBox Roll_Box;
        private TextBox dob_Box;
        private Label std_;
        private Button search_btn;
        private Button update_record;
        private Button submit_record;
        private DataGridView DGV;
        private Label search_part;
      
    }
}