namespace HanoiTower
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.cbBxCountDisk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnGiveIn = new System.Windows.Forms.Button();
            this.st1 = new System.Windows.Forms.PictureBox();
            this.st2 = new System.Windows.Forms.PictureBox();
            this.st3 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblTime.Location = new System.Drawing.Point(13, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(157, 22);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Время: 00:00:00";
            this.lblTime.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblCount.Location = new System.Drawing.Point(13, 36);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(201, 22);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Количество шагов: 0";
            this.lblCount.Visible = false;
            // 
            // cbBxCountDisk
            // 
            this.cbBxCountDisk.DisplayMember = "4";
            this.cbBxCountDisk.FormattingEnabled = true;
            this.cbBxCountDisk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbBxCountDisk.Location = new System.Drawing.Point(428, 173);
            this.cbBxCountDisk.Name = "cbBxCountDisk";
            this.cbBxCountDisk.Size = new System.Drawing.Size(121, 24);
            this.cbBxCountDisk.TabIndex = 5;
            this.cbBxCountDisk.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(343, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите количество дисков:";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(449, 205);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(79, 28);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Начать";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnGiveIn
            // 
            this.btnGiveIn.Enabled = false;
            this.btnGiveIn.Location = new System.Drawing.Point(433, 205);
            this.btnGiveIn.Name = "btnGiveIn";
            this.btnGiveIn.Size = new System.Drawing.Size(110, 28);
            this.btnGiveIn.TabIndex = 8;
            this.btnGiveIn.Text = "Рестарт";
            this.btnGiveIn.UseVisualStyleBackColor = true;
            this.btnGiveIn.Visible = false;
            this.btnGiveIn.Click += new System.EventHandler(this.btnGiveIn_Click);
            // 
            // st1
            // 
            this.st1.Image = ((System.Drawing.Image)(resources.GetObject("st1.Image")));
            this.st1.Location = new System.Drawing.Point(128, 275);
            this.st1.Name = "st1";
            this.st1.Size = new System.Drawing.Size(236, 242);
            this.st1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.st1.TabIndex = 11;
            this.st1.TabStop = false;
            this.st1.Click += new System.EventHandler(this.st1_Click);
            // 
            // st2
            // 
            this.st2.Image = ((System.Drawing.Image)(resources.GetObject("st2.Image")));
            this.st2.Location = new System.Drawing.Point(386, 275);
            this.st2.Name = "st2";
            this.st2.Size = new System.Drawing.Size(236, 242);
            this.st2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.st2.TabIndex = 12;
            this.st2.TabStop = false;
            this.st2.Click += new System.EventHandler(this.st1_Click);
            // 
            // st3
            // 
            this.st3.Image = ((System.Drawing.Image)(resources.GetObject("st3.Image")));
            this.st3.Location = new System.Drawing.Point(645, 275);
            this.st3.Name = "st3";
            this.st3.Size = new System.Drawing.Size(236, 242);
            this.st3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.st3.TabIndex = 13;
            this.st3.TabStop = false;
            this.st3.Click += new System.EventHandler(this.st1_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::HanoiTower.Properties.Resources._8;
            this.pb8.Location = new System.Drawing.Point(140, 473);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(217, 20);
            this.pb8.TabIndex = 14;
            this.pb8.TabStop = false;
            this.pb8.Tag = "8";
            this.pb8.Visible = false;
            this.pb8.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::HanoiTower.Properties.Resources._7;
            this.pb7.Location = new System.Drawing.Point(150, 453);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(197, 20);
            this.pb7.TabIndex = 15;
            this.pb7.TabStop = false;
            this.pb7.Tag = "7";
            this.pb7.Visible = false;
            this.pb7.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::HanoiTower.Properties.Resources._6;
            this.pb6.Location = new System.Drawing.Point(160, 433);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(177, 20);
            this.pb6.TabIndex = 16;
            this.pb6.TabStop = false;
            this.pb6.Tag = "6";
            this.pb6.Visible = false;
            this.pb6.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::HanoiTower.Properties.Resources._5;
            this.pb5.Location = new System.Drawing.Point(170, 413);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(157, 20);
            this.pb5.TabIndex = 17;
            this.pb5.TabStop = false;
            this.pb5.Tag = "5";
            this.pb5.Visible = false;
            this.pb5.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::HanoiTower.Properties.Resources._1;
            this.pb1.Location = new System.Drawing.Point(210, 333);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(77, 20);
            this.pb1.TabIndex = 21;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            this.pb1.Visible = false;
            this.pb1.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::HanoiTower.Properties.Resources._2;
            this.pb2.Location = new System.Drawing.Point(200, 353);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(97, 20);
            this.pb2.TabIndex = 20;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            this.pb2.Visible = false;
            this.pb2.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::HanoiTower.Properties.Resources._3;
            this.pb3.Location = new System.Drawing.Point(190, 373);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(117, 20);
            this.pb3.TabIndex = 19;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            this.pb3.Visible = false;
            this.pb3.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::HanoiTower.Properties.Resources._4;
            this.pb4.Location = new System.Drawing.Point(180, 393);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(137, 20);
            this.pb4.TabIndex = 18;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            this.pb4.Visible = false;
            this.pb4.Click += new System.EventHandler(this.pb8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(333, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Переместите кольца с 1 стержня на 3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.st3);
            this.Controls.Add(this.st2);
            this.Controls.Add(this.st1);
            this.Controls.Add(this.btnGiveIn);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBxCountDisk);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.st1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox cbBxCountDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnGiveIn;
        private System.Windows.Forms.PictureBox st1;
        private System.Windows.Forms.PictureBox st2;
        private System.Windows.Forms.PictureBox st3;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Label label2;
    }
}

