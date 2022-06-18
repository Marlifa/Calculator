namespace Calculator
{
    partial class Calculator
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
            this.b_Dot = new System.Windows.Forms.Button();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.b_MS = new System.Windows.Forms.Button();
            this.b_MMunis = new System.Windows.Forms.Button();
            this.b_MPlus = new System.Windows.Forms.Button();
            this.b_MC = new System.Windows.Forms.Button();
            this.b_MR = new System.Windows.Forms.Button();
            this.b_backspace = new System.Windows.Forms.Button();
            this.b_SQRT = new System.Windows.Forms.Button();
            this.b__changeSign = new System.Windows.Forms.Button();
            this.b_C = new System.Windows.Forms.Button();
            this.b_CE = new System.Windows.Forms.Button();
            this.b_Num1 = new System.Windows.Forms.Button();
            this.b_Ost = new System.Windows.Forms.Button();
            this.b_DIvide = new System.Windows.Forms.Button();
            this.b_Num3 = new System.Windows.Forms.Button();
            this.b_Num2 = new System.Windows.Forms.Button();
            this.b_Num4 = new System.Windows.Forms.Button();
            this.b_OneDivision = new System.Windows.Forms.Button();
            this.b_Mult = new System.Windows.Forms.Button();
            this.b_Num6 = new System.Windows.Forms.Button();
            this.b_Num5 = new System.Windows.Forms.Button();
            this.b_Num7 = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_Num9 = new System.Windows.Forms.Button();
            this.b_Num8 = new System.Windows.Forms.Button();
            this.b_Num0 = new System.Windows.Forms.Button();
            this.b_res = new System.Windows.Forms.Button();
            this.b_PLUS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Dot
            // 
            this.b_Dot.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Dot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Dot.Location = new System.Drawing.Point(163, 414);
            this.b_Dot.Name = "b_Dot";
            this.b_Dot.Size = new System.Drawing.Size(54, 42);
            this.b_Dot.TabIndex = 32;
            this.b_Dot.Text = ".";
            this.b_Dot.UseVisualStyleBackColor = false;
            this.b_Dot.Click += new System.EventHandler(this.b_Dot_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Result.Location = new System.Drawing.Point(7, 41);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(353, 49);
            this.tb_Result.TabIndex = 3;
            this.tb_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_MS
            // 
            this.b_MS.BackColor = System.Drawing.Color.AliceBlue;
            this.b_MS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_MS.Location = new System.Drawing.Point(8, 111);
            this.b_MS.Name = "b_MS";
            this.b_MS.Size = new System.Drawing.Size(54, 42);
            this.b_MS.TabIndex = 4;
            this.b_MS.Text = "MS";
            this.b_MS.UseVisualStyleBackColor = false;
            this.b_MS.Click += new System.EventHandler(this.b_MS_Click);
            // 
            // b_MMunis
            // 
            this.b_MMunis.BackColor = System.Drawing.Color.AliceBlue;
            this.b_MMunis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_MMunis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MMunis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_MMunis.Location = new System.Drawing.Point(306, 111);
            this.b_MMunis.Name = "b_MMunis";
            this.b_MMunis.Size = new System.Drawing.Size(54, 42);
            this.b_MMunis.TabIndex = 5;
            this.b_MMunis.Text = "M-";
            this.b_MMunis.UseVisualStyleBackColor = false;
            this.b_MMunis.Click += new System.EventHandler(this.b_MMunis_Click);
            // 
            // b_MPlus
            // 
            this.b_MPlus.BackColor = System.Drawing.Color.AliceBlue;
            this.b_MPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_MPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MPlus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_MPlus.Location = new System.Drawing.Point(233, 111);
            this.b_MPlus.Name = "b_MPlus";
            this.b_MPlus.Size = new System.Drawing.Size(54, 42);
            this.b_MPlus.TabIndex = 6;
            this.b_MPlus.Text = "M+";
            this.b_MPlus.UseVisualStyleBackColor = false;
            this.b_MPlus.Click += new System.EventHandler(this.b_MPlus_Click);
            // 
            // b_MC
            // 
            this.b_MC.BackColor = System.Drawing.Color.AliceBlue;
            this.b_MC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_MC.Location = new System.Drawing.Point(163, 111);
            this.b_MC.Name = "b_MC";
            this.b_MC.Size = new System.Drawing.Size(54, 42);
            this.b_MC.TabIndex = 7;
            this.b_MC.Text = "MC";
            this.b_MC.UseVisualStyleBackColor = false;
            this.b_MC.Click += new System.EventHandler(this.b_MC_Click);
            // 
            // b_MR
            // 
            this.b_MR.BackColor = System.Drawing.Color.AliceBlue;
            this.b_MR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_MR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_MR.Location = new System.Drawing.Point(86, 111);
            this.b_MR.Name = "b_MR";
            this.b_MR.Size = new System.Drawing.Size(54, 42);
            this.b_MR.TabIndex = 8;
            this.b_MR.Text = "MR";
            this.b_MR.UseVisualStyleBackColor = false;
            this.b_MR.Click += new System.EventHandler(this.b_MR_Click);
            // 
            // b_backspace
            // 
            this.b_backspace.BackColor = System.Drawing.Color.AliceBlue;
            this.b_backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_backspace.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_backspace.Location = new System.Drawing.Point(8, 173);
            this.b_backspace.Name = "b_backspace";
            this.b_backspace.Size = new System.Drawing.Size(54, 42);
            this.b_backspace.TabIndex = 9;
            this.b_backspace.Text = "<--";
            this.b_backspace.UseVisualStyleBackColor = false;
            this.b_backspace.Click += new System.EventHandler(this.b_backspace_Click);
            // 
            // b_SQRT
            // 
            this.b_SQRT.BackColor = System.Drawing.Color.AliceBlue;
            this.b_SQRT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_SQRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_SQRT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_SQRT.Location = new System.Drawing.Point(306, 173);
            this.b_SQRT.Name = "b_SQRT";
            this.b_SQRT.Size = new System.Drawing.Size(54, 42);
            this.b_SQRT.TabIndex = 10;
            this.b_SQRT.Text = "sqrt";
            this.b_SQRT.UseVisualStyleBackColor = false;
            this.b_SQRT.Click += new System.EventHandler(this.b_SQRT_Click);
            // 
            // b__changeSign
            // 
            this.b__changeSign.BackColor = System.Drawing.Color.AliceBlue;
            this.b__changeSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b__changeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b__changeSign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b__changeSign.Location = new System.Drawing.Point(233, 173);
            this.b__changeSign.Name = "b__changeSign";
            this.b__changeSign.Size = new System.Drawing.Size(54, 42);
            this.b__changeSign.TabIndex = 11;
            this.b__changeSign.Text = "+-";
            this.b__changeSign.UseVisualStyleBackColor = false;
            this.b__changeSign.Click += new System.EventHandler(this.b__changeSign_Click);
            // 
            // b_C
            // 
            this.b_C.BackColor = System.Drawing.Color.AliceBlue;
            this.b_C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_C.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_C.Location = new System.Drawing.Point(163, 173);
            this.b_C.Name = "b_C";
            this.b_C.Size = new System.Drawing.Size(54, 42);
            this.b_C.TabIndex = 12;
            this.b_C.Text = "C";
            this.b_C.UseVisualStyleBackColor = false;
            this.b_C.Click += new System.EventHandler(this.b_C_Click);
            // 
            // b_CE
            // 
            this.b_CE.BackColor = System.Drawing.Color.AliceBlue;
            this.b_CE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_CE.Location = new System.Drawing.Point(86, 173);
            this.b_CE.Name = "b_CE";
            this.b_CE.Size = new System.Drawing.Size(54, 42);
            this.b_CE.TabIndex = 13;
            this.b_CE.Text = "CE";
            this.b_CE.UseVisualStyleBackColor = false;
            this.b_CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // b_Num1
            // 
            this.b_Num1.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num1.Location = new System.Drawing.Point(8, 233);
            this.b_Num1.Name = "b_Num1";
            this.b_Num1.Size = new System.Drawing.Size(54, 42);
            this.b_Num1.TabIndex = 14;
            this.b_Num1.Text = "1";
            this.b_Num1.UseVisualStyleBackColor = false;
            this.b_Num1.Click += new System.EventHandler(this.b_Num1_Click);
            // 
            // b_Ost
            // 
            this.b_Ost.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Ost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Ost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Ost.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Ost.Location = new System.Drawing.Point(306, 233);
            this.b_Ost.Name = "b_Ost";
            this.b_Ost.Size = new System.Drawing.Size(54, 42);
            this.b_Ost.TabIndex = 15;
            this.b_Ost.Text = "%";
            this.b_Ost.UseVisualStyleBackColor = false;
            this.b_Ost.Click += new System.EventHandler(this.b_Ost_Click);
            // 
            // b_DIvide
            // 
            this.b_DIvide.BackColor = System.Drawing.Color.AliceBlue;
            this.b_DIvide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_DIvide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_DIvide.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_DIvide.Location = new System.Drawing.Point(233, 233);
            this.b_DIvide.Name = "b_DIvide";
            this.b_DIvide.Size = new System.Drawing.Size(54, 42);
            this.b_DIvide.TabIndex = 16;
            this.b_DIvide.Text = "/";
            this.b_DIvide.UseVisualStyleBackColor = false;
            this.b_DIvide.Click += new System.EventHandler(this.b_DIvide_Click);
            // 
            // b_Num3
            // 
            this.b_Num3.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num3.Location = new System.Drawing.Point(163, 233);
            this.b_Num3.Name = "b_Num3";
            this.b_Num3.Size = new System.Drawing.Size(54, 42);
            this.b_Num3.TabIndex = 17;
            this.b_Num3.Text = "3";
            this.b_Num3.UseVisualStyleBackColor = false;
            this.b_Num3.Click += new System.EventHandler(this.b_Num3_Click);
            // 
            // b_Num2
            // 
            this.b_Num2.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num2.Location = new System.Drawing.Point(86, 233);
            this.b_Num2.Name = "b_Num2";
            this.b_Num2.Size = new System.Drawing.Size(54, 42);
            this.b_Num2.TabIndex = 18;
            this.b_Num2.Text = "2";
            this.b_Num2.UseVisualStyleBackColor = false;
            this.b_Num2.Click += new System.EventHandler(this.b_Num2_Click);
            // 
            // b_Num4
            // 
            this.b_Num4.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num4.Location = new System.Drawing.Point(8, 291);
            this.b_Num4.Name = "b_Num4";
            this.b_Num4.Size = new System.Drawing.Size(54, 42);
            this.b_Num4.TabIndex = 19;
            this.b_Num4.Text = "4";
            this.b_Num4.UseVisualStyleBackColor = false;
            this.b_Num4.Click += new System.EventHandler(this.b_Num4_Click);
            // 
            // b_OneDivision
            // 
            this.b_OneDivision.BackColor = System.Drawing.Color.AliceBlue;
            this.b_OneDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_OneDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_OneDivision.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_OneDivision.Location = new System.Drawing.Point(306, 291);
            this.b_OneDivision.Name = "b_OneDivision";
            this.b_OneDivision.Size = new System.Drawing.Size(54, 42);
            this.b_OneDivision.TabIndex = 20;
            this.b_OneDivision.Text = "1/x";
            this.b_OneDivision.UseVisualStyleBackColor = false;
            this.b_OneDivision.Click += new System.EventHandler(this.b_OneDivision_Click);
            // 
            // b_Mult
            // 
            this.b_Mult.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Mult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Mult.Location = new System.Drawing.Point(233, 291);
            this.b_Mult.Name = "b_Mult";
            this.b_Mult.Size = new System.Drawing.Size(54, 42);
            this.b_Mult.TabIndex = 21;
            this.b_Mult.Text = "*";
            this.b_Mult.UseVisualStyleBackColor = false;
            this.b_Mult.Click += new System.EventHandler(this.b_Mult_Click);
            // 
            // b_Num6
            // 
            this.b_Num6.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num6.Location = new System.Drawing.Point(163, 291);
            this.b_Num6.Name = "b_Num6";
            this.b_Num6.Size = new System.Drawing.Size(54, 42);
            this.b_Num6.TabIndex = 22;
            this.b_Num6.Text = "6";
            this.b_Num6.UseVisualStyleBackColor = false;
            this.b_Num6.Click += new System.EventHandler(this.b_Num6_Click);
            // 
            // b_Num5
            // 
            this.b_Num5.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num5.Location = new System.Drawing.Point(86, 291);
            this.b_Num5.Name = "b_Num5";
            this.b_Num5.Size = new System.Drawing.Size(54, 42);
            this.b_Num5.TabIndex = 23;
            this.b_Num5.Text = "5";
            this.b_Num5.UseVisualStyleBackColor = false;
            this.b_Num5.Click += new System.EventHandler(this.b_Num5_Click);
            // 
            // b_Num7
            // 
            this.b_Num7.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num7.Location = new System.Drawing.Point(8, 353);
            this.b_Num7.Name = "b_Num7";
            this.b_Num7.Size = new System.Drawing.Size(54, 42);
            this.b_Num7.TabIndex = 24;
            this.b_Num7.Text = "7";
            this.b_Num7.UseVisualStyleBackColor = false;
            this.b_Num7.Click += new System.EventHandler(this.b_Num7_Click);
            // 
            // b_minus
            // 
            this.b_minus.BackColor = System.Drawing.Color.AliceBlue;
            this.b_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_minus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_minus.Location = new System.Drawing.Point(233, 353);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(54, 42);
            this.b_minus.TabIndex = 26;
            this.b_minus.Text = "-";
            this.b_minus.UseVisualStyleBackColor = false;
            this.b_minus.Click += new System.EventHandler(this.b_minus_Click);
            // 
            // b_Num9
            // 
            this.b_Num9.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num9.Location = new System.Drawing.Point(163, 353);
            this.b_Num9.Name = "b_Num9";
            this.b_Num9.Size = new System.Drawing.Size(54, 42);
            this.b_Num9.TabIndex = 27;
            this.b_Num9.Text = "9";
            this.b_Num9.UseVisualStyleBackColor = false;
            this.b_Num9.Click += new System.EventHandler(this.b_Num9_Click);
            // 
            // b_Num8
            // 
            this.b_Num8.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num8.Location = new System.Drawing.Point(86, 353);
            this.b_Num8.Name = "b_Num8";
            this.b_Num8.Size = new System.Drawing.Size(54, 42);
            this.b_Num8.TabIndex = 28;
            this.b_Num8.Text = "8";
            this.b_Num8.UseVisualStyleBackColor = false;
            this.b_Num8.Click += new System.EventHandler(this.b_Num8_Click);
            // 
            // b_Num0
            // 
            this.b_Num0.BackColor = System.Drawing.Color.AliceBlue;
            this.b_Num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Num0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Num0.Location = new System.Drawing.Point(8, 415);
            this.b_Num0.Name = "b_Num0";
            this.b_Num0.Size = new System.Drawing.Size(132, 42);
            this.b_Num0.TabIndex = 29;
            this.b_Num0.Text = "0";
            this.b_Num0.UseVisualStyleBackColor = false;
            this.b_Num0.Click += new System.EventHandler(this.b_Num0_Click);
            // 
            // b_res
            // 
            this.b_res.BackColor = System.Drawing.Color.AliceBlue;
            this.b_res.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_res.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_res.Location = new System.Drawing.Point(306, 353);
            this.b_res.Name = "b_res";
            this.b_res.Size = new System.Drawing.Size(54, 103);
            this.b_res.TabIndex = 30;
            this.b_res.Text = "=";
            this.b_res.UseVisualStyleBackColor = false;
            this.b_res.Click += new System.EventHandler(this.b_res_Click);
            // 
            // b_PLUS
            // 
            this.b_PLUS.BackColor = System.Drawing.Color.AliceBlue;
            this.b_PLUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_PLUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_PLUS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_PLUS.Location = new System.Drawing.Point(233, 415);
            this.b_PLUS.Name = "b_PLUS";
            this.b_PLUS.Size = new System.Drawing.Size(54, 42);
            this.b_PLUS.TabIndex = 31;
            this.b_PLUS.Text = "+";
            this.b_PLUS.UseVisualStyleBackColor = false;
            this.b_PLUS.Click += new System.EventHandler(this.b_PLUS_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(367, 466);
            this.Controls.Add(this.b_Dot);
            this.Controls.Add(this.b_PLUS);
            this.Controls.Add(this.b_res);
            this.Controls.Add(this.b_Num0);
            this.Controls.Add(this.b_Num8);
            this.Controls.Add(this.b_Num9);
            this.Controls.Add(this.b_minus);
            this.Controls.Add(this.b_Num7);
            this.Controls.Add(this.b_Num5);
            this.Controls.Add(this.b_Num6);
            this.Controls.Add(this.b_Mult);
            this.Controls.Add(this.b_OneDivision);
            this.Controls.Add(this.b_Num4);
            this.Controls.Add(this.b_Num2);
            this.Controls.Add(this.b_Num3);
            this.Controls.Add(this.b_DIvide);
            this.Controls.Add(this.b_Ost);
            this.Controls.Add(this.b_Num1);
            this.Controls.Add(this.b_CE);
            this.Controls.Add(this.b_C);
            this.Controls.Add(this.b__changeSign);
            this.Controls.Add(this.b_SQRT);
            this.Controls.Add(this.b_backspace);
            this.Controls.Add(this.b_MR);
            this.Controls.Add(this.b_MC);
            this.Controls.Add(this.b_MPlus);
            this.Controls.Add(this.b_MMunis);
            this.Controls.Add(this.b_MS);
            this.Controls.Add(this.tb_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Dot;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Button b_MS;
        private System.Windows.Forms.Button b_MMunis;
        private System.Windows.Forms.Button b_MPlus;
        private System.Windows.Forms.Button b_MC;
        private System.Windows.Forms.Button b_MR;
        private System.Windows.Forms.Button b_backspace;
        private System.Windows.Forms.Button b_SQRT;
        private System.Windows.Forms.Button b__changeSign;
        private System.Windows.Forms.Button b_C;
        private System.Windows.Forms.Button b_CE;
        private System.Windows.Forms.Button b_Num1;
        private System.Windows.Forms.Button b_Ost;
        private System.Windows.Forms.Button b_DIvide;
        private System.Windows.Forms.Button b_Num3;
        private System.Windows.Forms.Button b_Num2;
        private System.Windows.Forms.Button b_Num4;
        private System.Windows.Forms.Button b_OneDivision;
        private System.Windows.Forms.Button b_Mult;
        private System.Windows.Forms.Button b_Num6;
        private System.Windows.Forms.Button b_Num5;
        private System.Windows.Forms.Button b_Num7;
        private System.Windows.Forms.Button b_minus;
        private System.Windows.Forms.Button b_Num9;
        private System.Windows.Forms.Button b_Num8;
        private System.Windows.Forms.Button b_Num0;
        private System.Windows.Forms.Button b_res;
        private System.Windows.Forms.Button b_PLUS;
    }
}

