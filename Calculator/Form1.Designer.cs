namespace Calculator
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DivBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Log10Btn = new System.Windows.Forms.Button();
            this.TanBtn = new System.Windows.Forms.Button();
            this.AbsBtn = new System.Windows.Forms.Button();
            this.LogBtn = new System.Windows.Forms.Button();
            this.CosBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.SqrtBtn = new System.Windows.Forms.Button();
            this.SinBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.PowBtn = new System.Windows.Forms.Button();
            this.ExpBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(197, 117);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(115, 26);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(197, 165);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(115, 26);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox2_KeyPress);
            // 
            // txtBox3
            // 
            this.txtBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox3.Location = new System.Drawing.Point(197, 221);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.ReadOnly = true;
            this.txtBox3.Size = new System.Drawing.Size(115, 26);
            this.txtBox3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DivBtn);
            this.groupBox1.Controls.Add(this.MultBtn);
            this.groupBox1.Controls.Add(this.SubBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.Log10Btn);
            this.groupBox1.Controls.Add(this.TanBtn);
            this.groupBox1.Controls.Add(this.AbsBtn);
            this.groupBox1.Controls.Add(this.LogBtn);
            this.groupBox1.Controls.Add(this.CosBtn);
            this.groupBox1.Controls.Add(this.MaxBtn);
            this.groupBox1.Controls.Add(this.SqrtBtn);
            this.groupBox1.Controls.Add(this.SinBtn);
            this.groupBox1.Controls.Add(this.MinBtn);
            this.groupBox1.Controls.Add(this.PowBtn);
            this.groupBox1.Controls.Add(this.ExpBtn);
            this.groupBox1.Controls.Add(this.CBtn);
            this.groupBox1.Location = new System.Drawing.Point(346, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 261);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DivBtn
            // 
            this.DivBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivBtn.Location = new System.Drawing.Point(298, 196);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(70, 42);
            this.DivBtn.TabIndex = 15;
            this.DivBtn.Text = "/";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.DivBtn_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultBtn.Location = new System.Drawing.Point(209, 196);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(70, 42);
            this.MultBtn.TabIndex = 14;
            this.MultBtn.Text = "x";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // SubBtn
            // 
            this.SubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtn.Location = new System.Drawing.Point(115, 196);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(70, 42);
            this.SubBtn.TabIndex = 13;
            this.SubBtn.Text = "-";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(20, 196);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(70, 42);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Log10Btn
            // 
            this.Log10Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log10Btn.Location = new System.Drawing.Point(298, 137);
            this.Log10Btn.Name = "Log10Btn";
            this.Log10Btn.Size = new System.Drawing.Size(70, 42);
            this.Log10Btn.TabIndex = 11;
            this.Log10Btn.Text = "Log10";
            this.Log10Btn.UseVisualStyleBackColor = true;
            this.Log10Btn.Click += new System.EventHandler(this.Log10Btn_Click);
            // 
            // TanBtn
            // 
            this.TanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanBtn.Location = new System.Drawing.Point(298, 81);
            this.TanBtn.Name = "TanBtn";
            this.TanBtn.Size = new System.Drawing.Size(70, 42);
            this.TanBtn.TabIndex = 7;
            this.TanBtn.Text = "Tan";
            this.TanBtn.UseVisualStyleBackColor = true;
            this.TanBtn.Click += new System.EventHandler(this.TanBtn_Click);
            // 
            // AbsBtn
            // 
            this.AbsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsBtn.Location = new System.Drawing.Point(298, 27);
            this.AbsBtn.Name = "AbsBtn";
            this.AbsBtn.Size = new System.Drawing.Size(70, 42);
            this.AbsBtn.TabIndex = 3;
            this.AbsBtn.Text = "Abs";
            this.AbsBtn.UseVisualStyleBackColor = true;
            this.AbsBtn.Click += new System.EventHandler(this.AbsBtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.Location = new System.Drawing.Point(209, 137);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(70, 42);
            this.LogBtn.TabIndex = 10;
            this.LogBtn.Text = "Log";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // CosBtn
            // 
            this.CosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosBtn.Location = new System.Drawing.Point(209, 81);
            this.CosBtn.Name = "CosBtn";
            this.CosBtn.Size = new System.Drawing.Size(70, 42);
            this.CosBtn.TabIndex = 6;
            this.CosBtn.Text = "Cos";
            this.CosBtn.UseVisualStyleBackColor = true;
            this.CosBtn.Click += new System.EventHandler(this.CosBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.Location = new System.Drawing.Point(209, 27);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(70, 42);
            this.MaxBtn.TabIndex = 2;
            this.MaxBtn.Text = "Max";
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // SqrtBtn
            // 
            this.SqrtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqrtBtn.Location = new System.Drawing.Point(115, 137);
            this.SqrtBtn.Name = "SqrtBtn";
            this.SqrtBtn.Size = new System.Drawing.Size(70, 42);
            this.SqrtBtn.TabIndex = 9;
            this.SqrtBtn.Text = "Sqrt";
            this.SqrtBtn.UseVisualStyleBackColor = true;
            this.SqrtBtn.Click += new System.EventHandler(this.SqrtBtn_Click);
            // 
            // SinBtn
            // 
            this.SinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinBtn.Location = new System.Drawing.Point(115, 81);
            this.SinBtn.Name = "SinBtn";
            this.SinBtn.Size = new System.Drawing.Size(70, 42);
            this.SinBtn.TabIndex = 5;
            this.SinBtn.Text = "Sin";
            this.SinBtn.UseVisualStyleBackColor = true;
            this.SinBtn.Click += new System.EventHandler(this.SinBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.Location = new System.Drawing.Point(115, 27);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(70, 42);
            this.MinBtn.TabIndex = 1;
            this.MinBtn.Text = "Min";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // PowBtn
            // 
            this.PowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowBtn.Location = new System.Drawing.Point(20, 137);
            this.PowBtn.Name = "PowBtn";
            this.PowBtn.Size = new System.Drawing.Size(70, 42);
            this.PowBtn.TabIndex = 8;
            this.PowBtn.Text = "Pow";
            this.PowBtn.UseVisualStyleBackColor = true;
            this.PowBtn.Click += new System.EventHandler(this.PowBtn_Click);
            // 
            // ExpBtn
            // 
            this.ExpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpBtn.Location = new System.Drawing.Point(20, 81);
            this.ExpBtn.Name = "ExpBtn";
            this.ExpBtn.Size = new System.Drawing.Size(70, 42);
            this.ExpBtn.TabIndex = 4;
            this.ExpBtn.Text = "Exp";
            this.ExpBtn.UseVisualStyleBackColor = true;
            this.ExpBtn.Click += new System.EventHandler(this.ExpBtn_Click);
            // 
            // CBtn
            // 
            this.CBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtn.Location = new System.Drawing.Point(20, 27);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(70, 42);
            this.CBtn.TabIndex = 0;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = true;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button Log10Btn;
        private System.Windows.Forms.Button TanBtn;
        private System.Windows.Forms.Button AbsBtn;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Button CosBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button SqrtBtn;
        private System.Windows.Forms.Button SinBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button PowBtn;
        private System.Windows.Forms.Button ExpBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button1;
    }
}

