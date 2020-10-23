namespace ComponenteCalculadora
{
    partial class CalculadoraLayout
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBScreen = new System.Windows.Forms.TextBox();
            this.ButDiv = new System.Windows.Forms.Button();
            this.ButFin = new System.Windows.Forms.Button();
            this.But0 = new System.Windows.Forms.Button();
            this.ButAC = new System.Windows.Forms.Button();
            this.ButX = new System.Windows.Forms.Button();
            this.But9 = new System.Windows.Forms.Button();
            this.But8 = new System.Windows.Forms.Button();
            this.But7 = new System.Windows.Forms.Button();
            this.ButRest = new System.Windows.Forms.Button();
            this.But6 = new System.Windows.Forms.Button();
            this.But5 = new System.Windows.Forms.Button();
            this.But4 = new System.Windows.Forms.Button();
            this.ButPlus = new System.Windows.Forms.Button();
            this.But3 = new System.Windows.Forms.Button();
            this.But2 = new System.Windows.Forms.Button();
            this.But1 = new System.Windows.Forms.Button();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Operacion:";
            // 
            // TBScreen
            // 
            this.TBScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TBScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBScreen.ForeColor = System.Drawing.Color.White;
            this.TBScreen.Location = new System.Drawing.Point(3, 40);
            this.TBScreen.Multiline = true;
            this.TBScreen.Name = "TBScreen";
            this.TBScreen.Size = new System.Drawing.Size(310, 42);
            this.TBScreen.TabIndex = 19;
            this.TBScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButDiv
            // 
            this.ButDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButDiv.ForeColor = System.Drawing.Color.White;
            this.ButDiv.Location = new System.Drawing.Point(246, 215);
            this.ButDiv.Name = "ButDiv";
            this.ButDiv.Size = new System.Drawing.Size(66, 23);
            this.ButDiv.TabIndex = 35;
            this.ButDiv.Text = "/";
            this.ButDiv.UseVisualStyleBackColor = false;
            this.ButDiv.Click += new System.EventHandler(this.ButDiv_Click);
            // 
            // ButFin
            // 
            this.ButFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButFin.ForeColor = System.Drawing.Color.White;
            this.ButFin.Location = new System.Drawing.Point(165, 215);
            this.ButFin.Name = "ButFin";
            this.ButFin.Size = new System.Drawing.Size(75, 23);
            this.ButFin.TabIndex = 34;
            this.ButFin.Text = "=";
            this.ButFin.UseVisualStyleBackColor = false;
            this.ButFin.Click += new System.EventHandler(this.ButFin_Click);
            // 
            // But0
            // 
            this.But0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But0.ForeColor = System.Drawing.Color.White;
            this.But0.Location = new System.Drawing.Point(84, 215);
            this.But0.Name = "But0";
            this.But0.Size = new System.Drawing.Size(75, 23);
            this.But0.TabIndex = 33;
            this.But0.Text = "0";
            this.But0.UseVisualStyleBackColor = false;
            this.But0.Click += new System.EventHandler(this.But0_Click);
            // 
            // ButAC
            // 
            this.ButAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButAC.ForeColor = System.Drawing.Color.White;
            this.ButAC.Location = new System.Drawing.Point(3, 215);
            this.ButAC.Name = "ButAC";
            this.ButAC.Size = new System.Drawing.Size(75, 23);
            this.ButAC.TabIndex = 32;
            this.ButAC.Text = "AC";
            this.ButAC.UseVisualStyleBackColor = false;
            this.ButAC.Click += new System.EventHandler(this.ButAC_Click);
            // 
            // ButX
            // 
            this.ButX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButX.ForeColor = System.Drawing.Color.White;
            this.ButX.Location = new System.Drawing.Point(246, 177);
            this.ButX.Name = "ButX";
            this.ButX.Size = new System.Drawing.Size(66, 23);
            this.ButX.TabIndex = 31;
            this.ButX.Text = "*";
            this.ButX.UseVisualStyleBackColor = false;
            this.ButX.Click += new System.EventHandler(this.ButX_Click);
            // 
            // But9
            // 
            this.But9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But9.ForeColor = System.Drawing.Color.White;
            this.But9.Location = new System.Drawing.Point(165, 177);
            this.But9.Name = "But9";
            this.But9.Size = new System.Drawing.Size(75, 23);
            this.But9.TabIndex = 30;
            this.But9.Text = "9";
            this.But9.UseVisualStyleBackColor = false;
            this.But9.Click += new System.EventHandler(this.But9_Click);
            // 
            // But8
            // 
            this.But8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But8.ForeColor = System.Drawing.Color.White;
            this.But8.Location = new System.Drawing.Point(84, 177);
            this.But8.Name = "But8";
            this.But8.Size = new System.Drawing.Size(75, 23);
            this.But8.TabIndex = 29;
            this.But8.Text = "8";
            this.But8.UseVisualStyleBackColor = false;
            this.But8.Click += new System.EventHandler(this.But8_Click);
            // 
            // But7
            // 
            this.But7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But7.ForeColor = System.Drawing.Color.White;
            this.But7.Location = new System.Drawing.Point(3, 177);
            this.But7.Name = "But7";
            this.But7.Size = new System.Drawing.Size(75, 23);
            this.But7.TabIndex = 28;
            this.But7.Text = "7";
            this.But7.UseVisualStyleBackColor = false;
            this.But7.Click += new System.EventHandler(this.But7_Click);
            // 
            // ButRest
            // 
            this.ButRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRest.ForeColor = System.Drawing.Color.White;
            this.ButRest.Location = new System.Drawing.Point(246, 134);
            this.ButRest.Name = "ButRest";
            this.ButRest.Size = new System.Drawing.Size(66, 23);
            this.ButRest.TabIndex = 27;
            this.ButRest.Text = "-";
            this.ButRest.UseVisualStyleBackColor = false;
            this.ButRest.Click += new System.EventHandler(this.ButRest_Click);
            // 
            // But6
            // 
            this.But6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But6.ForeColor = System.Drawing.Color.White;
            this.But6.Location = new System.Drawing.Point(165, 134);
            this.But6.Name = "But6";
            this.But6.Size = new System.Drawing.Size(75, 23);
            this.But6.TabIndex = 26;
            this.But6.Text = "6";
            this.But6.UseVisualStyleBackColor = false;
            this.But6.Click += new System.EventHandler(this.But6_Click);
            // 
            // But5
            // 
            this.But5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But5.ForeColor = System.Drawing.Color.White;
            this.But5.Location = new System.Drawing.Point(84, 134);
            this.But5.Name = "But5";
            this.But5.Size = new System.Drawing.Size(75, 23);
            this.But5.TabIndex = 25;
            this.But5.Text = "5";
            this.But5.UseVisualStyleBackColor = false;
            this.But5.Click += new System.EventHandler(this.But5_Click);
            // 
            // But4
            // 
            this.But4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But4.ForeColor = System.Drawing.Color.White;
            this.But4.Location = new System.Drawing.Point(3, 134);
            this.But4.Name = "But4";
            this.But4.Size = new System.Drawing.Size(75, 23);
            this.But4.TabIndex = 24;
            this.But4.Text = "4";
            this.But4.UseVisualStyleBackColor = false;
            this.But4.Click += new System.EventHandler(this.But4_Click);
            // 
            // ButPlus
            // 
            this.ButPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButPlus.ForeColor = System.Drawing.Color.White;
            this.ButPlus.Location = new System.Drawing.Point(246, 90);
            this.ButPlus.Name = "ButPlus";
            this.ButPlus.Size = new System.Drawing.Size(66, 23);
            this.ButPlus.TabIndex = 23;
            this.ButPlus.Text = "+";
            this.ButPlus.UseVisualStyleBackColor = false;
            this.ButPlus.Click += new System.EventHandler(this.ButPlus_Click);
            // 
            // But3
            // 
            this.But3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But3.ForeColor = System.Drawing.Color.White;
            this.But3.Location = new System.Drawing.Point(165, 90);
            this.But3.Name = "But3";
            this.But3.Size = new System.Drawing.Size(75, 23);
            this.But3.TabIndex = 22;
            this.But3.Text = "3";
            this.But3.UseVisualStyleBackColor = false;
            this.But3.Click += new System.EventHandler(this.But3_Click);
            // 
            // But2
            // 
            this.But2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But2.ForeColor = System.Drawing.Color.White;
            this.But2.Location = new System.Drawing.Point(84, 90);
            this.But2.Name = "But2";
            this.But2.Size = new System.Drawing.Size(75, 23);
            this.But2.TabIndex = 21;
            this.But2.Text = "2";
            this.But2.UseVisualStyleBackColor = false;
            this.But2.Click += new System.EventHandler(this.But2_Click);
            // 
            // But1
            // 
            this.But1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.But1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But1.ForeColor = System.Drawing.Color.White;
            this.But1.Location = new System.Drawing.Point(3, 90);
            this.But1.Name = "But1";
            this.But1.Size = new System.Drawing.Size(75, 23);
            this.But1.TabIndex = 20;
            this.But1.Text = "1";
            this.But1.UseVisualStyleBackColor = false;
            this.But1.Click += new System.EventHandler(this.But1_Click);
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LabelEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEstado.ForeColor = System.Drawing.Color.White;
            this.LabelEstado.Location = new System.Drawing.Point(78, 10);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(0, 17);
            this.LabelEstado.TabIndex = 36;
            // 
            // CalculadoraLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.LabelEstado);
            this.Controls.Add(this.ButDiv);
            this.Controls.Add(this.ButFin);
            this.Controls.Add(this.But0);
            this.Controls.Add(this.ButAC);
            this.Controls.Add(this.ButX);
            this.Controls.Add(this.But9);
            this.Controls.Add(this.But8);
            this.Controls.Add(this.But7);
            this.Controls.Add(this.ButRest);
            this.Controls.Add(this.But6);
            this.Controls.Add(this.But5);
            this.Controls.Add(this.But4);
            this.Controls.Add(this.ButPlus);
            this.Controls.Add(this.But3);
            this.Controls.Add(this.But2);
            this.Controls.Add(this.But1);
            this.Controls.Add(this.TBScreen);
            this.Controls.Add(this.label1);
            this.Name = "CalculadoraLayout";
            this.Size = new System.Drawing.Size(317, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBScreen;
        private System.Windows.Forms.Button ButDiv;
        private System.Windows.Forms.Button ButFin;
        private System.Windows.Forms.Button But0;
        private System.Windows.Forms.Button ButAC;
        private System.Windows.Forms.Button ButX;
        private System.Windows.Forms.Button But9;
        private System.Windows.Forms.Button But8;
        private System.Windows.Forms.Button But7;
        private System.Windows.Forms.Button ButRest;
        private System.Windows.Forms.Button But6;
        private System.Windows.Forms.Button But5;
        private System.Windows.Forms.Button But4;
        private System.Windows.Forms.Button ButPlus;
        private System.Windows.Forms.Button But3;
        private System.Windows.Forms.Button But2;
        private System.Windows.Forms.Button But1;
        private System.Windows.Forms.Label LabelEstado;
    }
}
