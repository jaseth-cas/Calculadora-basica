namespace Calculadora_basica
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
            Lbl_Tit = new Label();
            Panel1 = new Panel();
            Btn_Limp = new Button();
            TxtBx_res = new TextBox();
            Btn_borr = new Button();
            Btn_div = new Button();
            Btn_Multi = new Button();
            Btn_menos = new Button();
            Btn_mas = new Button();
            Btn_Res = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            Btn_punto = new Button();
            Btn0 = new Button();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Tit
            // 
            Lbl_Tit.AutoSize = true;
            Lbl_Tit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Tit.ForeColor = Color.DarkBlue;
            Lbl_Tit.Location = new Point(38, 15);
            Lbl_Tit.Name = "Lbl_Tit";
            Lbl_Tit.Size = new Size(206, 30);
            Lbl_Tit.TabIndex = 0;
            Lbl_Tit.Text = "Calculadora Basica";
            Lbl_Tit.Click += label1_Click;
            // 
            // Panel1
            // 
            Panel1.BackColor = SystemColors.ControlLight;
            Panel1.Controls.Add(Btn_Limp);
            Panel1.Controls.Add(TxtBx_res);
            Panel1.Controls.Add(Btn_borr);
            Panel1.Controls.Add(Btn_div);
            Panel1.Controls.Add(Btn_Multi);
            Panel1.Controls.Add(Btn_menos);
            Panel1.Controls.Add(Btn_mas);
            Panel1.Controls.Add(Btn_Res);
            Panel1.Controls.Add(Btn9);
            Panel1.Controls.Add(Btn8);
            Panel1.Controls.Add(Btn7);
            Panel1.Controls.Add(Btn6);
            Panel1.Controls.Add(Btn5);
            Panel1.Controls.Add(Btn4);
            Panel1.Controls.Add(Btn3);
            Panel1.Controls.Add(Btn2);
            Panel1.Controls.Add(Btn1);
            Panel1.Controls.Add(Btn_punto);
            Panel1.Controls.Add(Btn0);
            Panel1.Controls.Add(Lbl_Tit);
            Panel1.Location = new Point(3, 1);
            Panel1.Margin = new Padding(3, 2, 3, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(294, 385);
            Panel1.TabIndex = 2;
            // 
            // Btn_Limp
            // 
            Btn_Limp.Location = new Point(78, 110);
            Btn_Limp.Margin = new Padding(3, 2, 3, 2);
            Btn_Limp.Name = "Btn_Limp";
            Btn_Limp.Size = new Size(65, 50);
            Btn_Limp.TabIndex = 21;
            Btn_Limp.Text = "C";
            Btn_Limp.UseVisualStyleBackColor = true;
            Btn_Limp.Click += Btn_Limp_Click;
            // 
            // TxtBx_res
            // 
            TxtBx_res.Enabled = false;
            TxtBx_res.Location = new Point(8, 76);
            TxtBx_res.Margin = new Padding(3, 2, 3, 2);
            TxtBx_res.Name = "TxtBx_res";
            TxtBx_res.Size = new Size(275, 23);
            TxtBx_res.TabIndex = 20;
            TxtBx_res.Text = "0";
            // 
            // Btn_borr
            // 
            Btn_borr.Location = new Point(8, 110);
            Btn_borr.Margin = new Padding(3, 2, 3, 2);
            Btn_borr.Name = "Btn_borr";
            Btn_borr.Size = new Size(65, 50);
            Btn_borr.TabIndex = 19;
            Btn_borr.Text = "<-";
            Btn_borr.UseVisualStyleBackColor = true;
            Btn_borr.Click += Btn_borr_Click;
            // 
            // Btn_div
            // 
            Btn_div.Location = new Point(148, 110);
            Btn_div.Margin = new Padding(3, 2, 3, 2);
            Btn_div.Name = "Btn_div";
            Btn_div.Size = new Size(65, 50);
            Btn_div.TabIndex = 18;
            Btn_div.Text = "÷";
            Btn_div.UseVisualStyleBackColor = true;
            Btn_div.Click += btnOperador_Click;
            // 
            // Btn_Multi
            // 
            Btn_Multi.Location = new Point(218, 110);
            Btn_Multi.Margin = new Padding(3, 2, 3, 2);
            Btn_Multi.Name = "Btn_Multi";
            Btn_Multi.Size = new Size(65, 50);
            Btn_Multi.TabIndex = 17;
            Btn_Multi.Text = "*";
            Btn_Multi.UseVisualStyleBackColor = true;
            Btn_Multi.Click += btnOperador_Click;
            // 
            // Btn_menos
            // 
            Btn_menos.Location = new Point(218, 164);
            Btn_menos.Margin = new Padding(3, 2, 3, 2);
            Btn_menos.Name = "Btn_menos";
            Btn_menos.Size = new Size(65, 50);
            Btn_menos.TabIndex = 16;
            Btn_menos.Text = "-";
            Btn_menos.UseVisualStyleBackColor = true;
            Btn_menos.Click += Btn_menos_Click;
            // 
            // Btn_mas
            // 
            Btn_mas.Location = new Point(218, 218);
            Btn_mas.Margin = new Padding(3, 2, 3, 2);
            Btn_mas.Name = "Btn_mas";
            Btn_mas.Size = new Size(65, 50);
            Btn_mas.TabIndex = 15;
            Btn_mas.Text = "+";
            Btn_mas.UseVisualStyleBackColor = true;
            Btn_mas.Click += Btn_mas_Click;
            // 
            // Btn_Res
            // 
            Btn_Res.Location = new Point(218, 272);
            Btn_Res.Margin = new Padding(3, 2, 3, 2);
            Btn_Res.Name = "Btn_Res";
            Btn_Res.Size = new Size(65, 104);
            Btn_Res.TabIndex = 14;
            Btn_Res.Text = "=";
            Btn_Res.UseVisualStyleBackColor = true;
            Btn_Res.Click += btnIgual_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(148, 164);
            Btn9.Margin = new Padding(3, 2, 3, 2);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(65, 50);
            Btn9.TabIndex = 13;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += btnNumero_Click;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(78, 164);
            Btn8.Margin = new Padding(3, 2, 3, 2);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(65, 50);
            Btn8.TabIndex = 12;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += btnNumero_Click;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(8, 164);
            Btn7.Margin = new Padding(3, 2, 3, 2);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(65, 50);
            Btn7.TabIndex = 11;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += btnNumero_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(148, 218);
            Btn6.Margin = new Padding(3, 2, 3, 2);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(65, 50);
            Btn6.TabIndex = 10;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += btnNumero_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(78, 218);
            Btn5.Margin = new Padding(3, 2, 3, 2);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(65, 50);
            Btn5.TabIndex = 9;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += btnNumero_Click;
            // 
            // Btn4
            // 
            Btn4.Location = new Point(8, 218);
            Btn4.Margin = new Padding(3, 2, 3, 2);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(65, 50);
            Btn4.TabIndex = 8;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += btnNumero_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(148, 272);
            Btn3.Margin = new Padding(3, 2, 3, 2);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(65, 50);
            Btn3.TabIndex = 7;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += btnNumero_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(78, 272);
            Btn2.Margin = new Padding(3, 2, 3, 2);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(65, 50);
            Btn2.TabIndex = 6;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += btnNumero_Click;
            // 
            // Btn1
            // 
            Btn1.Location = new Point(8, 272);
            Btn1.Margin = new Padding(3, 2, 3, 2);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(65, 50);
            Btn1.TabIndex = 5;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += btnNumero_Click;
            // 
            // Btn_punto
            // 
            Btn_punto.Location = new Point(148, 326);
            Btn_punto.Margin = new Padding(3, 2, 3, 2);
            Btn_punto.Name = "Btn_punto";
            Btn_punto.Size = new Size(65, 50);
            Btn_punto.TabIndex = 4;
            Btn_punto.Text = ".";
            Btn_punto.UseVisualStyleBackColor = true;
            Btn_punto.Click += Btn_punto_Click;
            // 
            // Btn0
            // 
            Btn0.Location = new Point(8, 326);
            Btn0.Margin = new Padding(3, 2, 3, 2);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(135, 50);
            Btn0.TabIndex = 2;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += btnNumero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 386);
            Controls.Add(Panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Cal_Basic";
            Load += Form1_Load;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Lbl_Tit;
        private Panel Panel1;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button Btn_punto;
        private Button Btn0;
        private Button Btn7;
        private Button Btn_menos;
        private Button Btn_mas;
        private Button Btn_Res;
        private Button Btn9;
        private Button Btn8;
        private Button Btn_borr;
        private Button Btn_div;
        private Button Btn_Multi;
        private TextBox TxtBx_res;
        private Button Btn_Limp;
    }
}
