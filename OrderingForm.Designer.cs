namespace T2_FP_02
{
    partial class OrderingForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.G2_Number_Txt = new System.Windows.Forms.TextBox();
            this.G2_Add_Btn = new System.Windows.Forms.Button();
            this.G2_Search_Btn = new System.Windows.Forms.Button();
            this.G2_Delete_Btn = new System.Windows.Forms.Button();
            this.G2_Asc_Sort_Btn = new System.Windows.Forms.Button();
            this.G2_Desc_Sort_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDENAMIENTO";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(257, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 290);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número";
            // 
            // G2_Number_Txt
            // 
            this.G2_Number_Txt.Location = new System.Drawing.Point(33, 55);
            this.G2_Number_Txt.Name = "G2_Number_Txt";
            this.G2_Number_Txt.Size = new System.Drawing.Size(445, 20);
            this.G2_Number_Txt.TabIndex = 3;
            // 
            // G2_Add_Btn
            // 
            this.G2_Add_Btn.Location = new System.Drawing.Point(33, 91);
            this.G2_Add_Btn.Name = "G2_Add_Btn";
            this.G2_Add_Btn.Size = new System.Drawing.Size(80, 30);
            this.G2_Add_Btn.TabIndex = 4;
            this.G2_Add_Btn.Text = "Agregar";
            this.G2_Add_Btn.UseVisualStyleBackColor = true;
            // 
            // G2_Search_Btn
            // 
            this.G2_Search_Btn.Location = new System.Drawing.Point(220, 91);
            this.G2_Search_Btn.Name = "G2_Search_Btn";
            this.G2_Search_Btn.Size = new System.Drawing.Size(80, 30);
            this.G2_Search_Btn.TabIndex = 5;
            this.G2_Search_Btn.Text = "Buscar";
            this.G2_Search_Btn.UseVisualStyleBackColor = true;
            // 
            // G2_Delete_Btn
            // 
            this.G2_Delete_Btn.Location = new System.Drawing.Point(398, 91);
            this.G2_Delete_Btn.Name = "G2_Delete_Btn";
            this.G2_Delete_Btn.Size = new System.Drawing.Size(80, 30);
            this.G2_Delete_Btn.TabIndex = 6;
            this.G2_Delete_Btn.Text = "Eliminar";
            this.G2_Delete_Btn.UseVisualStyleBackColor = true;
            // 
            // G2_Asc_Sort_Btn
            // 
            this.G2_Asc_Sort_Btn.Location = new System.Drawing.Point(61, 191);
            this.G2_Asc_Sort_Btn.Name = "G2_Asc_Sort_Btn";
            this.G2_Asc_Sort_Btn.Size = new System.Drawing.Size(131, 44);
            this.G2_Asc_Sort_Btn.TabIndex = 7;
            this.G2_Asc_Sort_Btn.Text = "Ordenar de forma Ascendente";
            this.G2_Asc_Sort_Btn.UseVisualStyleBackColor = true;
            // 
            // G2_Desc_Sort_Btn
            // 
            this.G2_Desc_Sort_Btn.Location = new System.Drawing.Point(61, 281);
            this.G2_Desc_Sort_Btn.Name = "G2_Desc_Sort_Btn";
            this.G2_Desc_Sort_Btn.Size = new System.Drawing.Size(131, 44);
            this.G2_Desc_Sort_Btn.TabIndex = 8;
            this.G2_Desc_Sort_Btn.Text = "Ordenar de forma Descendente";
            this.G2_Desc_Sort_Btn.UseVisualStyleBackColor = true;
            // 
            // OrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.G2_Desc_Sort_Btn);
            this.Controls.Add(this.G2_Asc_Sort_Btn);
            this.Controls.Add(this.G2_Delete_Btn);
            this.Controls.Add(this.G2_Search_Btn);
            this.Controls.Add(this.G2_Add_Btn);
            this.Controls.Add(this.G2_Number_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "OrderingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox G2_Number_Txt;
        private System.Windows.Forms.Button G2_Add_Btn;
        private System.Windows.Forms.Button G2_Search_Btn;
        private System.Windows.Forms.Button G2_Delete_Btn;
        private System.Windows.Forms.Button G2_Asc_Sort_Btn;
        private System.Windows.Forms.Button G2_Desc_Sort_Btn;
    }
}

