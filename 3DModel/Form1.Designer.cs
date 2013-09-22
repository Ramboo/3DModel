namespace _3DModel
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.numUDzz = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxAxis = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numUDdz = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numUDzy = new System.Windows.Forms.NumericUpDown();
            this.btnZoom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numUDzx = new System.Windows.Forms.NumericUpDown();
            this.btnRotate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numUDdangle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDdy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDdx = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDzz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDzx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdx)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numUDzz);
            this.panel1.Controls.Add(this.cmbBoxAxis);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numUDdz);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numUDzy);
            this.panel1.Controls.Add(this.btnZoom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numUDzx);
            this.panel1.Controls.Add(this.btnRotate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numUDdangle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnMove);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numUDdy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numUDdx);
            this.panel1.Location = new System.Drawing.Point(620, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 600);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "zZ";
            // 
            // numUDzz
            // 
            this.numUDzz.DecimalPlaces = 1;
            this.numUDzz.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDzz.Location = new System.Drawing.Point(42, 211);
            this.numUDzz.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDzz.Name = "numUDzz";
            this.numUDzz.Size = new System.Drawing.Size(212, 20);
            this.numUDzz.TabIndex = 20;
            this.numUDzz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbBoxAxis
            // 
            this.cmbBoxAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAxis.FormattingEnabled = true;
            this.cmbBoxAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbBoxAxis.Location = new System.Drawing.Point(187, 113);
            this.cmbBoxAxis.Name = "cmbBoxAxis";
            this.cmbBoxAxis.Size = new System.Drawing.Size(67, 21);
            this.cmbBoxAxis.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Z";
            // 
            // numUDdz
            // 
            this.numUDdz.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDdz.Location = new System.Drawing.Point(42, 88);
            this.numUDdz.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDdz.Name = "numUDdz";
            this.numUDdz.Size = new System.Drawing.Size(212, 20);
            this.numUDdz.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "zY";
            // 
            // numUDzy
            // 
            this.numUDzy.DecimalPlaces = 1;
            this.numUDzy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDzy.Location = new System.Drawing.Point(42, 185);
            this.numUDzy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDzy.Name = "numUDzy";
            this.numUDzy.Size = new System.Drawing.Size(212, 20);
            this.numUDzy.TabIndex = 13;
            this.numUDzy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(260, 159);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(58, 72);
            this.btnZoom.TabIndex = 12;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "zX";
            // 
            // numUDzx
            // 
            this.numUDzx.DecimalPlaces = 1;
            this.numUDzx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDzx.Location = new System.Drawing.Point(42, 159);
            this.numUDzx.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDzx.Name = "numUDzx";
            this.numUDzx.Size = new System.Drawing.Size(212, 20);
            this.numUDzx.TabIndex = 10;
            this.numUDzx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(260, 114);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(58, 20);
            this.btnRotate.TabIndex = 9;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "α";
            // 
            // numUDdangle
            // 
            this.numUDdangle.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUDdangle.Location = new System.Drawing.Point(42, 114);
            this.numUDdangle.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDdangle.Name = "numUDdangle";
            this.numUDdangle.Size = new System.Drawing.Size(139, 20);
            this.numUDdangle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(260, 36);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(58, 72);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // numUDdy
            // 
            this.numUDdy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDdy.Location = new System.Drawing.Point(42, 62);
            this.numUDdy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDdy.Name = "numUDdy";
            this.numUDdy.Size = new System.Drawing.Size(212, 20);
            this.numUDdy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // numUDdx
            // 
            this.numUDdx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDdx.Location = new System.Drawing.Point(42, 36);
            this.numUDdx.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDdx.Name = "numUDdx";
            this.numUDdx.Size = new System.Drawing.Size(212, 20);
            this.numUDdx.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDzz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDzx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDdx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDdy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDdx;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUDdangle;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUDzx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numUDzy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBoxAxis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numUDdz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numUDzz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

