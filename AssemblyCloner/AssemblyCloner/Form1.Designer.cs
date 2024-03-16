namespace AssemblyCloner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.iconSelect = new System.Windows.Forms.Button();
            this.iconInput = new System.Windows.Forms.PictureBox();
            this.iconCheck = new System.Windows.Forms.Label();
            this.twoFile_Open = new System.Windows.Forms.Button();
            this.oneFile_Open = new System.Windows.Forms.Button();
            this.twoFile_box = new System.Windows.Forms.TextBox();
            this.build_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oneFile_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.file1Open_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.file2Open_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.minimazeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.iconFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assembly Cloner";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aboutBtn);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.iconSelect);
            this.groupBox1.Controls.Add(this.iconInput);
            this.groupBox1.Controls.Add(this.iconCheck);
            this.groupBox1.Controls.Add(this.twoFile_Open);
            this.groupBox1.Controls.Add(this.oneFile_Open);
            this.groupBox1.Controls.Add(this.twoFile_box);
            this.groupBox1.Controls.Add(this.build_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.oneFile_box);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.Black;
            this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.aboutBtn.Location = new System.Drawing.Point(360, 180);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(82, 50);
            this.aboutBtn.TabIndex = 15;
            this.aboutBtn.Text = "ABOUT";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Black;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.resetBtn.Location = new System.Drawing.Point(10, 180);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(82, 50);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // iconSelect
            // 
            this.iconSelect.BackColor = System.Drawing.Color.Black;
            this.iconSelect.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.iconSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSelect.Font = new System.Drawing.Font("Consolas", 5.25F, System.Drawing.FontStyle.Bold);
            this.iconSelect.Location = new System.Drawing.Point(6, 50);
            this.iconSelect.Name = "iconSelect";
            this.iconSelect.Size = new System.Drawing.Size(49, 32);
            this.iconSelect.TabIndex = 13;
            this.iconSelect.Text = "...";
            this.iconSelect.UseVisualStyleBackColor = false;
            this.iconSelect.Click += new System.EventHandler(this.iconSelect_Click);
            // 
            // iconInput
            // 
            this.iconInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconInput.Location = new System.Drawing.Point(61, 29);
            this.iconInput.Name = "iconInput";
            this.iconInput.Size = new System.Drawing.Size(62, 54);
            this.iconInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconInput.TabIndex = 12;
            this.iconInput.TabStop = false;
            // 
            // iconCheck
            // 
            this.iconCheck.AutoSize = true;
            this.iconCheck.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.iconCheck.ForeColor = System.Drawing.Color.White;
            this.iconCheck.Location = new System.Drawing.Point(7, 29);
            this.iconCheck.Name = "iconCheck";
            this.iconCheck.Size = new System.Drawing.Size(48, 18);
            this.iconCheck.TabIndex = 11;
            this.iconCheck.Text = "ICON:";
            // 
            // twoFile_Open
            // 
            this.twoFile_Open.BackColor = System.Drawing.Color.Black;
            this.twoFile_Open.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.twoFile_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.twoFile_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoFile_Open.Font = new System.Drawing.Font("Consolas", 5.25F, System.Drawing.FontStyle.Bold);
            this.twoFile_Open.Location = new System.Drawing.Point(413, 133);
            this.twoFile_Open.Name = "twoFile_Open";
            this.twoFile_Open.Size = new System.Drawing.Size(29, 24);
            this.twoFile_Open.TabIndex = 10;
            this.twoFile_Open.Text = "...";
            this.twoFile_Open.UseVisualStyleBackColor = false;
            this.twoFile_Open.Click += new System.EventHandler(this.twoFile_Open_Click);
            // 
            // oneFile_Open
            // 
            this.oneFile_Open.BackColor = System.Drawing.Color.Black;
            this.oneFile_Open.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.oneFile_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.oneFile_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneFile_Open.Font = new System.Drawing.Font("Consolas", 5.25F, System.Drawing.FontStyle.Bold);
            this.oneFile_Open.Location = new System.Drawing.Point(413, 94);
            this.oneFile_Open.Name = "oneFile_Open";
            this.oneFile_Open.Size = new System.Drawing.Size(29, 24);
            this.oneFile_Open.TabIndex = 9;
            this.oneFile_Open.Text = "...";
            this.oneFile_Open.UseVisualStyleBackColor = false;
            this.oneFile_Open.Click += new System.EventHandler(this.oneFile_Open_Click);
            // 
            // twoFile_box
            // 
            this.twoFile_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.twoFile_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoFile_box.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.twoFile_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.twoFile_box.Location = new System.Drawing.Point(68, 137);
            this.twoFile_box.Multiline = true;
            this.twoFile_box.Name = "twoFile_box";
            this.twoFile_box.Size = new System.Drawing.Size(339, 20);
            this.twoFile_box.TabIndex = 8;
            // 
            // build_btn
            // 
            this.build_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.build_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.build_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.build_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build_btn.Image = global::AssemblyCloner.Properties.Resources.Settings;
            this.build_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.build_btn.Location = new System.Drawing.Point(98, 180);
            this.build_btn.Name = "build_btn";
            this.build_btn.Size = new System.Drawing.Size(256, 50);
            this.build_btn.TabIndex = 7;
            this.build_btn.Text = "BUILD FILE";
            this.build_btn.UseVisualStyleBackColor = false;
            this.build_btn.Click += new System.EventHandler(this.build_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "2-FILE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "1-FILE";
            // 
            // oneFile_box
            // 
            this.oneFile_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.oneFile_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneFile_box.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.oneFile_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.oneFile_box.Location = new System.Drawing.Point(68, 98);
            this.oneFile_box.Multiline = true;
            this.oneFile_box.Name = "oneFile_box";
            this.oneFile_box.Size = new System.Drawing.Size(339, 20);
            this.oneFile_box.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "BY K3RNEL-DEV";
            // 
            // minimazeBtn
            // 
            this.minimazeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimazeBtn.Image = global::AssemblyCloner.Properties.Resources.Minimize_Window;
            this.minimazeBtn.Location = new System.Drawing.Point(402, 6);
            this.minimazeBtn.Name = "minimazeBtn";
            this.minimazeBtn.Size = new System.Drawing.Size(28, 28);
            this.minimazeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimazeBtn.TabIndex = 3;
            this.minimazeBtn.TabStop = false;
            this.minimazeBtn.Click += new System.EventHandler(this.minimazeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::AssemblyCloner.Properties.Resources.Close;
            this.closeBtn.Location = new System.Drawing.Point(437, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 28);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // iconBox
            // 
            this.iconBox.Image = global::AssemblyCloner.Properties.Resources.Witcher;
            this.iconBox.Location = new System.Drawing.Point(7, 4);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(70, 65);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(473, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minimazeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ Assembly Cloner ] - [ by K3rnel-Dev ]";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minimazeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox oneFile_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button build_btn;
        private System.Windows.Forms.TextBox twoFile_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button twoFile_Open;
        private System.Windows.Forms.Button oneFile_Open;
        private System.Windows.Forms.OpenFileDialog file1Open_Dialog;
        private System.Windows.Forms.OpenFileDialog file2Open_Dialog;
        private System.Windows.Forms.Button iconSelect;
        private System.Windows.Forms.PictureBox iconInput;
        private System.Windows.Forms.Label iconCheck;
        private System.Windows.Forms.OpenFileDialog iconFileDialog;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

