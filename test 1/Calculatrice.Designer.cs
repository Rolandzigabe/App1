namespace test_1
{
    partial class Calculatrice
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btnClear = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btnMin = new Button();
            btnPlus = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.WindowFrame;
            txtDisplay.Font = new Font("Yu Gothic UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.Black;
            txtDisplay.Location = new Point(28, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(365, 87);
            txtDisplay.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(33, 119);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 34);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(105, 119);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 34);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.Gray;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.Black;
            btn.Location = new Point(177, 119);
            btn.Name = "btn";
            btn.Size = new Size(66, 34);
            btn.TabIndex = 3;
            btn.Text = "3";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gray;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(249, 119);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 34);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gray;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(332, 119);
            btn5.Name = "btn5";
            btn5.Size = new Size(66, 34);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gray;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(332, 190);
            btn0.Name = "btn0";
            btn0.Size = new Size(66, 34);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(249, 190);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 34);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(177, 190);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 34);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(105, 190);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 34);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gray;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(33, 190);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 34);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += button10_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(332, 258);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Gray;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btnDiv.ForeColor = Color.Black;
            btnDiv.Location = new Point(249, 258);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(66, 34);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.Gray;
            btnMult.FlatAppearance.BorderSize = 0;
            btnMult.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btnMult.ForeColor = Color.Black;
            btnMult.Location = new Point(177, 258);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(66, 34);
            btnMult.TabIndex = 13;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Gray;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btnMin.ForeColor = Color.Black;
            btnMin.Location = new Point(105, 258);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(66, 34);
            btnMin.TabIndex = 12;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Gray;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btnPlus.ForeColor = Color.Black;
            btnPlus.Location = new Point(33, 258);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(66, 34);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEql
            // 
            btnEql.BackColor = Color.Gray;
            btnEql.FlatAppearance.BorderSize = 0;
            btnEql.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold);
            btnEql.ForeColor = Color.Black;
            btnEql.Location = new Point(35, 317);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(360, 34);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = false;
            btnEql.Click += btnEql_Click;
            // 
            // Calculatrice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(btnEql);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Calculatrice";
            Size = new Size(431, 369);
            Load += Calculatrice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn;
        private Button btn4;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btnClear;
        private Button btnDiv;
        private Button btnMult;
        private Button btnMin;
        private Button btnPlus;
        private Button btnEql;
    }
}
