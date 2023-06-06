namespace CG_1
{
    partial class Form
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
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.lbBorderColor = new System.Windows.Forms.Label();
            this.lbFillColor = new System.Windows.Forms.Label();
            this.pctBoxBorderColor = new System.Windows.Forms.PictureBox();
            this.pctBoxFillColor = new System.Windows.Forms.PictureBox();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFillColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox
            // 
            this.pctBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBox.Location = new System.Drawing.Point(12, 12);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(571, 439);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseDown);
            this.pctBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseMove);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(598, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить поле";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Location = new System.Drawing.Point(598, 12);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(164, 35);
            this.btnBorderColor.TabIndex = 2;
            this.btnBorderColor.Text = "Цвет границы";
            this.btnBorderColor.UseVisualStyleBackColor = true;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(598, 53);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(164, 35);
            this.btnFillColor.TabIndex = 3;
            this.btnFillColor.Text = "Цвет заливки";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // lbBorderColor
            // 
            this.lbBorderColor.AutoSize = true;
            this.lbBorderColor.Location = new System.Drawing.Point(594, 156);
            this.lbBorderColor.Name = "lbBorderColor";
            this.lbBorderColor.Size = new System.Drawing.Size(141, 20);
            this.lbBorderColor.TabIndex = 4;
            this.lbBorderColor.Text = "Цвет границы:";
            // 
            // lbFillColor
            // 
            this.lbFillColor.AutoSize = true;
            this.lbFillColor.Location = new System.Drawing.Point(594, 218);
            this.lbFillColor.Name = "lbFillColor";
            this.lbFillColor.Size = new System.Drawing.Size(135, 20);
            this.lbFillColor.TabIndex = 5;
            this.lbFillColor.Text = "Цвет заливки:";
            // 
            // pctBoxBorderColor
            // 
            this.pctBoxBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxBorderColor.Location = new System.Drawing.Point(598, 179);
            this.pctBoxBorderColor.Name = "pctBoxBorderColor";
            this.pctBoxBorderColor.Size = new System.Drawing.Size(164, 36);
            this.pctBoxBorderColor.TabIndex = 6;
            this.pctBoxBorderColor.TabStop = false;
            // 
            // pctBoxFillColor
            // 
            this.pctBoxFillColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxFillColor.Location = new System.Drawing.Point(598, 241);
            this.pctBoxFillColor.Name = "pctBoxFillColor";
            this.pctBoxFillColor.Size = new System.Drawing.Size(164, 36);
            this.pctBoxFillColor.TabIndex = 7;
            this.pctBoxFillColor.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 463);
            this.Controls.Add(this.pctBoxFillColor);
            this.Controls.Add(this.pctBoxBorderColor);
            this.Controls.Add(this.lbFillColor);
            this.Controls.Add(this.lbBorderColor);
            this.Controls.Add(this.btnFillColor);
            this.Controls.Add(this.btnBorderColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pctBox);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Computer Graphics – Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFillColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label lbBorderColor;
        private System.Windows.Forms.Label lbFillColor;
        private System.Windows.Forms.PictureBox pctBoxBorderColor;
        private System.Windows.Forms.PictureBox pctBoxFillColor;
        private System.Windows.Forms.ColorDialog colorDlg;
    }
}

