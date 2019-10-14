namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.but_equal = new System.Windows.Forms.Button();
            this.but_point = new System.Windows.Forms.Button();
            this.but_0 = new System.Windows.Forms.Button();
            this.but_neg = new System.Windows.Forms.Button();
            this.but_addend = new System.Windows.Forms.Button();
            this.but_3 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.but_1 = new System.Windows.Forms.Button();
            this.but_subtrahend = new System.Windows.Forms.Button();
            this.but_6 = new System.Windows.Forms.Button();
            this.but_5 = new System.Windows.Forms.Button();
            this.but_4 = new System.Windows.Forms.Button();
            this.but_multiplier = new System.Windows.Forms.Button();
            this.but_9 = new System.Windows.Forms.Button();
            this.but_8 = new System.Windows.Forms.Button();
            this.but_7 = new System.Windows.Forms.Button();
            this.but_divisor = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_C = new System.Windows.Forms.Button();
            this.but_ce = new System.Windows.Forms.Button();
            this.but_dividend = new System.Windows.Forms.Button();
            this.but_pow = new System.Windows.Forms.Button();
            this.but_radicalsign = new System.Windows.Forms.Button();
            this.but_percent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_equal
            // 
            this.but_equal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_equal.Location = new System.Drawing.Point(244, 382);
            this.but_equal.Name = "but_equal";
            this.but_equal.Size = new System.Drawing.Size(72, 51);
            this.but_equal.TabIndex = 51;
            this.but_equal.Text = "=";
            this.but_equal.UseVisualStyleBackColor = true;
            this.but_equal.Click += new System.EventHandler(this.but_equal_Click);
            // 
            // but_point
            // 
            this.but_point.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_point.Location = new System.Drawing.Point(166, 382);
            this.but_point.Name = "but_point";
            this.but_point.Size = new System.Drawing.Size(72, 51);
            this.but_point.TabIndex = 50;
            this.but_point.Text = ".";
            this.but_point.UseVisualStyleBackColor = true;
            this.but_point.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_0
            // 
            this.but_0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_0.Location = new System.Drawing.Point(88, 382);
            this.but_0.Name = "but_0";
            this.but_0.Size = new System.Drawing.Size(72, 51);
            this.but_0.TabIndex = 49;
            this.but_0.Text = "0";
            this.but_0.UseVisualStyleBackColor = true;
            this.but_0.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_neg
            // 
            this.but_neg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_neg.Location = new System.Drawing.Point(9, 382);
            this.but_neg.Name = "but_neg";
            this.but_neg.Size = new System.Drawing.Size(72, 51);
            this.but_neg.TabIndex = 48;
            this.but_neg.Text = "±";
            this.but_neg.UseVisualStyleBackColor = true;
            this.but_neg.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_addend
            // 
            this.but_addend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_addend.Location = new System.Drawing.Point(244, 325);
            this.but_addend.Name = "but_addend";
            this.but_addend.Size = new System.Drawing.Size(72, 51);
            this.but_addend.TabIndex = 47;
            this.but_addend.Text = "＋";
            this.but_addend.UseVisualStyleBackColor = true;
            this.but_addend.Click += new System.EventHandler(this.OperatorClick);
            // 
            // but_3
            // 
            this.but_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_3.Location = new System.Drawing.Point(166, 325);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(72, 51);
            this.but_3.TabIndex = 46;
            this.but_3.Text = "3";
            this.but_3.UseVisualStyleBackColor = true;
            this.but_3.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_2
            // 
            this.but_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_2.Location = new System.Drawing.Point(88, 325);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(72, 51);
            this.but_2.TabIndex = 45;
            this.but_2.Text = "2";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_1
            // 
            this.but_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_1.Location = new System.Drawing.Point(10, 325);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(72, 51);
            this.but_1.TabIndex = 44;
            this.but_1.Text = "1";
            this.but_1.UseVisualStyleBackColor = true;
            this.but_1.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_subtrahend
            // 
            this.but_subtrahend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_subtrahend.Location = new System.Drawing.Point(244, 268);
            this.but_subtrahend.Name = "but_subtrahend";
            this.but_subtrahend.Size = new System.Drawing.Size(72, 51);
            this.but_subtrahend.TabIndex = 43;
            this.but_subtrahend.Text = "－";
            this.but_subtrahend.UseVisualStyleBackColor = true;
            this.but_subtrahend.Click += new System.EventHandler(this.OperatorClick);
            // 
            // but_6
            // 
            this.but_6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_6.Location = new System.Drawing.Point(166, 268);
            this.but_6.Name = "but_6";
            this.but_6.Size = new System.Drawing.Size(72, 51);
            this.but_6.TabIndex = 42;
            this.but_6.Text = "6";
            this.but_6.UseVisualStyleBackColor = true;
            this.but_6.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_5
            // 
            this.but_5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_5.Location = new System.Drawing.Point(88, 268);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(72, 51);
            this.but_5.TabIndex = 41;
            this.but_5.Text = "5";
            this.but_5.UseVisualStyleBackColor = true;
            this.but_5.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_4
            // 
            this.but_4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_4.Location = new System.Drawing.Point(10, 268);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(72, 51);
            this.but_4.TabIndex = 40;
            this.but_4.Text = "4";
            this.but_4.UseVisualStyleBackColor = true;
            this.but_4.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_multiplier
            // 
            this.but_multiplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_multiplier.Location = new System.Drawing.Point(244, 211);
            this.but_multiplier.Name = "but_multiplier";
            this.but_multiplier.Size = new System.Drawing.Size(72, 51);
            this.but_multiplier.TabIndex = 39;
            this.but_multiplier.Text = "×";
            this.but_multiplier.UseVisualStyleBackColor = true;
            this.but_multiplier.Click += new System.EventHandler(this.OperatorClick);
            // 
            // but_9
            // 
            this.but_9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_9.Location = new System.Drawing.Point(166, 211);
            this.but_9.Name = "but_9";
            this.but_9.Size = new System.Drawing.Size(72, 51);
            this.but_9.TabIndex = 38;
            this.but_9.Text = "9";
            this.but_9.UseVisualStyleBackColor = true;
            this.but_9.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_8
            // 
            this.but_8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_8.Location = new System.Drawing.Point(88, 211);
            this.but_8.Name = "but_8";
            this.but_8.Size = new System.Drawing.Size(72, 51);
            this.but_8.TabIndex = 37;
            this.but_8.Text = "8";
            this.but_8.UseVisualStyleBackColor = true;
            this.but_8.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_7
            // 
            this.but_7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_7.Location = new System.Drawing.Point(10, 211);
            this.but_7.Name = "but_7";
            this.but_7.Size = new System.Drawing.Size(72, 51);
            this.but_7.TabIndex = 36;
            this.but_7.Text = "7";
            this.but_7.UseVisualStyleBackColor = true;
            this.but_7.Click += new System.EventHandler(this.NumberClick);
            // 
            // but_divisor
            // 
            this.but_divisor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_divisor.Location = new System.Drawing.Point(244, 154);
            this.but_divisor.Name = "but_divisor";
            this.but_divisor.Size = new System.Drawing.Size(72, 51);
            this.but_divisor.TabIndex = 35;
            this.but_divisor.Text = "÷";
            this.but_divisor.UseVisualStyleBackColor = true;
            this.but_divisor.Click += new System.EventHandler(this.OperatorClick);
            // 
            // but_del
            // 
            this.but_del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_del.Location = new System.Drawing.Point(166, 154);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(72, 51);
            this.but_del.TabIndex = 34;
            this.but_del.Text = "＜";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_C
            // 
            this.but_C.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_C.Location = new System.Drawing.Point(88, 154);
            this.but_C.Name = "but_C";
            this.but_C.Size = new System.Drawing.Size(72, 51);
            this.but_C.TabIndex = 33;
            this.but_C.Text = "C";
            this.but_C.UseVisualStyleBackColor = true;
            this.but_C.Click += new System.EventHandler(this.but_C_Click);
            // 
            // but_ce
            // 
            this.but_ce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_ce.Location = new System.Drawing.Point(10, 154);
            this.but_ce.Name = "but_ce";
            this.but_ce.Size = new System.Drawing.Size(72, 51);
            this.but_ce.TabIndex = 32;
            this.but_ce.Text = "CE";
            this.but_ce.UseVisualStyleBackColor = true;
            this.but_ce.Click += new System.EventHandler(this.but_ce_Click);
            // 
            // but_dividend
            // 
            this.but_dividend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_dividend.Location = new System.Drawing.Point(244, 97);
            this.but_dividend.Name = "but_dividend";
            this.but_dividend.Size = new System.Drawing.Size(72, 51);
            this.but_dividend.TabIndex = 31;
            this.but_dividend.Text = "1/x";
            this.but_dividend.UseVisualStyleBackColor = true;
            this.but_dividend.Click += new System.EventHandler(this.but_dividend_Click);
            // 
            // but_pow
            // 
            this.but_pow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_pow.Location = new System.Drawing.Point(166, 97);
            this.but_pow.Name = "but_pow";
            this.but_pow.Size = new System.Drawing.Size(72, 51);
            this.but_pow.TabIndex = 30;
            this.but_pow.Text = "x²";
            this.but_pow.UseVisualStyleBackColor = true;
            this.but_pow.Click += new System.EventHandler(this.but_pow_Click);
            // 
            // but_radicalsign
            // 
            this.but_radicalsign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_radicalsign.Location = new System.Drawing.Point(88, 97);
            this.but_radicalsign.Name = "but_radicalsign";
            this.but_radicalsign.Size = new System.Drawing.Size(72, 51);
            this.but_radicalsign.TabIndex = 29;
            this.but_radicalsign.Text = "√";
            this.but_radicalsign.UseVisualStyleBackColor = true;
            this.but_radicalsign.Click += new System.EventHandler(this.but_Sqrt_Click);
            // 
            // but_percent
            // 
            this.but_percent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_percent.Location = new System.Drawing.Point(10, 97);
            this.but_percent.Name = "but_percent";
            this.but_percent.Size = new System.Drawing.Size(72, 51);
            this.but_percent.TabIndex = 28;
            this.but_percent.Text = "%";
            this.but_percent.UseVisualStyleBackColor = true;
            this.but_percent.Click += new System.EventHandler(this.but_percent_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("黑体", 25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 44);
            this.label2.TabIndex = 27;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("黑体", 16.2F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 26);
            this.label1.TabIndex = 26;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 438);
            this.Controls.Add(this.but_equal);
            this.Controls.Add(this.but_point);
            this.Controls.Add(this.but_0);
            this.Controls.Add(this.but_neg);
            this.Controls.Add(this.but_addend);
            this.Controls.Add(this.but_3);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_1);
            this.Controls.Add(this.but_subtrahend);
            this.Controls.Add(this.but_6);
            this.Controls.Add(this.but_5);
            this.Controls.Add(this.but_4);
            this.Controls.Add(this.but_multiplier);
            this.Controls.Add(this.but_9);
            this.Controls.Add(this.but_8);
            this.Controls.Add(this.but_7);
            this.Controls.Add(this.but_divisor);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_C);
            this.Controls.Add(this.but_ce);
            this.Controls.Add(this.but_dividend);
            this.Controls.Add(this.but_pow);
            this.Controls.Add(this.but_radicalsign);
            this.Controls.Add(this.but_percent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_equal;
        private System.Windows.Forms.Button but_point;
        private System.Windows.Forms.Button but_0;
        private System.Windows.Forms.Button but_neg;
        private System.Windows.Forms.Button but_addend;
        private System.Windows.Forms.Button but_3;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button but_subtrahend;
        private System.Windows.Forms.Button but_6;
        private System.Windows.Forms.Button but_5;
        private System.Windows.Forms.Button but_4;
        private System.Windows.Forms.Button but_multiplier;
        private System.Windows.Forms.Button but_9;
        private System.Windows.Forms.Button but_8;
        private System.Windows.Forms.Button but_7;
        private System.Windows.Forms.Button but_divisor;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_C;
        private System.Windows.Forms.Button but_ce;
        private System.Windows.Forms.Button but_dividend;
        private System.Windows.Forms.Button but_pow;
        private System.Windows.Forms.Button but_radicalsign;
        private System.Windows.Forms.Button but_percent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

