namespace Hotel
{
    partial class HomePage
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
            this.tab_room = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_client = new System.Windows.Forms.TabPage();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_add_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_add_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_add_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_home = new System.Windows.Forms.TabControl();
            this.txt_search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            this.tab_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_room
            // 
            this.tab_room.BackColor = System.Drawing.Color.White;
            this.tab_room.Location = new System.Drawing.Point(4, 29);
            this.tab_room.Name = "tab_room";
            this.tab_room.Size = new System.Drawing.Size(991, 565);
            this.tab_room.TabIndex = 2;
            this.tab_room.Text = "Room State";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataSearch);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.txt_search);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Reservation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab_client
            // 
            this.tab_client.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tab_client.Controls.Add(this.dataGridUser);
            this.tab_client.Controls.Add(this.groupBox3);
            this.tab_client.Controls.Add(this.groupBox1);
            this.tab_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_client.Location = new System.Drawing.Point(4, 29);
            this.tab_client.Name = "tab_client";
            this.tab_client.Padding = new System.Windows.Forms.Padding(3);
            this.tab_client.Size = new System.Drawing.Size(991, 565);
            this.tab_client.TabIndex = 0;
            this.tab_client.Text = "Manage Client";
            // 
            // dataGridUser
            // 
            this.dataGridUser.AllowDrop = true;
            this.dataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(322, 383);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.Size = new System.Drawing.Size(607, 150);
            this.dataGridUser.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(669, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 264);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Client";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SeaShell;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Location = new System.Drawing.Point(129, 201);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 33);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(129, 42);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 24);
            this.txt_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_add_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.txt_add_surname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_add_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(9, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Client";
            // 
            // txt_add_id
            // 
            this.txt_add_id.Location = new System.Drawing.Point(129, 54);
            this.txt_add_id.Name = "txt_add_id";
            this.txt_add_id.Size = new System.Drawing.Size(100, 24);
            this.txt_add_id.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Id";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SeaShell;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(313, 143);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 33);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SeaShell;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(313, 57);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 33);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_add_surname
            // 
            this.txt_add_surname.Location = new System.Drawing.Point(129, 147);
            this.txt_add_surname.Name = "txt_add_surname";
            this.txt_add_surname.Size = new System.Drawing.Size(100, 24);
            this.txt_add_surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname :";
            // 
            // txt_add_name
            // 
            this.txt_add_name.Location = new System.Drawing.Point(129, 93);
            this.txt_add_name.Name = "txt_add_name";
            this.txt_add_name.Size = new System.Drawing.Size(100, 24);
            this.txt_add_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // tabControl_home
            // 
            this.tabControl_home.Controls.Add(this.tab_client);
            this.tabControl_home.Controls.Add(this.tabPage2);
            this.tabControl_home.Controls.Add(this.tab_room);
            this.tabControl_home.Font = new System.Drawing.Font("Microsoft MHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_home.Location = new System.Drawing.Point(-1, 1);
            this.tabControl_home.Name = "tabControl_home";
            this.tabControl_home.SelectedIndex = 0;
            this.tabControl_home.Size = new System.Drawing.Size(999, 598);
            this.tabControl_home.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.AutoSize = true;
            this.txt_search.Location = new System.Drawing.Point(41, 42);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(55, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataSearch
            // 
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(45, 120);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.Size = new System.Drawing.Size(686, 320);
            this.dataSearch.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 591);
            this.Controls.Add(this.tabControl_home);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tab_client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_room;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tab_client;
        private System.Windows.Forms.TabControl tabControl_home;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_add_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_add_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_add_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_search;
    }
}