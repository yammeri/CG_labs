namespace CG_3
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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.lRadius = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.lSlices = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbSlices = new System.Windows.Forms.TextBox();
            this.lFigure = new System.Windows.Forms.Label();
            this.lLight = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.lY = new System.Windows.Forms.Label();
            this.lZ = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.btnLight = new System.Windows.Forms.Button();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.pctBoxColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(0, 0);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(696, 547);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Load += new System.EventHandler(this.AnT_Load);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Location = new System.Drawing.Point(702, 48);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(70, 20);
            this.lRadius.TabIndex = 1;
            this.lRadius.Text = "Радиус";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(702, 82);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(72, 20);
            this.lHeight.TabIndex = 2;
            this.lHeight.Text = "Высота";
            // 
            // lSlices
            // 
            this.lSlices.AutoSize = true;
            this.lSlices.Location = new System.Drawing.Point(702, 116);
            this.lSlices.Name = "lSlices";
            this.lSlices.Size = new System.Drawing.Size(62, 20);
            this.lSlices.TabIndex = 3;
            this.lSlices.Text = "Грани";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(778, 45);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(152, 28);
            this.tbRadius.TabIndex = 4;
            this.tbRadius.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(778, 79);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(152, 28);
            this.tbHeight.TabIndex = 5;
            this.tbHeight.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbSlices
            // 
            this.tbSlices.Location = new System.Drawing.Point(778, 113);
            this.tbSlices.Name = "tbSlices";
            this.tbSlices.Size = new System.Drawing.Size(152, 28);
            this.tbSlices.TabIndex = 6;
            this.tbSlices.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lFigure
            // 
            this.lFigure.AutoSize = true;
            this.lFigure.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFigure.Location = new System.Drawing.Point(718, 12);
            this.lFigure.Name = "lFigure";
            this.lFigure.Size = new System.Drawing.Size(201, 20);
            this.lFigure.TabIndex = 7;
            this.lFigure.Text = "Параметры фигуры";
            // 
            // lLight
            // 
            this.lLight.AutoSize = true;
            this.lLight.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLight.Location = new System.Drawing.Point(733, 169);
            this.lLight.Name = "lLight";
            this.lLight.Size = new System.Drawing.Size(178, 20);
            this.lLight.TabIndex = 8;
            this.lLight.Text = "Параметры света";
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Location = new System.Drawing.Point(702, 239);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(21, 20);
            this.lX.TabIndex = 9;
            this.lX.Text = "X";
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(702, 273);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(19, 20);
            this.lY.TabIndex = 10;
            this.lY.Text = "Y";
            // 
            // lZ
            // 
            this.lZ.AutoSize = true;
            this.lZ.Location = new System.Drawing.Point(702, 307);
            this.lZ.Name = "lZ";
            this.lZ.Size = new System.Drawing.Size(21, 20);
            this.lZ.TabIndex = 11;
            this.lZ.Text = "Z";
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(702, 205);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(50, 20);
            this.lColor.TabIndex = 12;
            this.lColor.Text = "Цвет";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(778, 270);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(152, 28);
            this.tbY.TabIndex = 15;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(778, 236);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(152, 28);
            this.tbX.TabIndex = 14;
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(778, 304);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(152, 28);
            this.tbZ.TabIndex = 16;
            // 
            // btnLight
            // 
            this.btnLight.Location = new System.Drawing.Point(749, 338);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(143, 44);
            this.btnLight.TabIndex = 17;
            this.btnLight.Text = "Осветить";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(823, 201);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(107, 28);
            this.btnColor.TabIndex = 18;
            this.btnColor.Text = "Выбрать";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pctBoxColor
            // 
            this.pctBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxColor.Location = new System.Drawing.Point(778, 201);
            this.pctBoxColor.Name = "pctBoxColor";
            this.pctBoxColor.Size = new System.Drawing.Size(39, 29);
            this.pctBoxColor.TabIndex = 19;
            this.pctBoxColor.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 547);
            this.Controls.Add(this.pctBoxColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.lZ);
            this.Controls.Add(this.lY);
            this.Controls.Add(this.lX);
            this.Controls.Add(this.lLight);
            this.Controls.Add(this.lFigure);
            this.Controls.Add(this.tbSlices);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.lSlices);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.lRadius);
            this.Controls.Add(this.AnT);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Computer Graphics – lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lSlices;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbSlices;
        private System.Windows.Forms.Label lFigure;
        private System.Windows.Forms.Label lLight;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lZ;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox pctBoxColor;
    }
}

