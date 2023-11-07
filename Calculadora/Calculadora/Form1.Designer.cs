namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvezes = new System.Windows.Forms.Button();
            this.btnmais = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.txbnumero1 = new System.Windows.Forms.TextBox();
            this.txbnumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnvezes
            // 
            this.btnvezes.Location = new System.Drawing.Point(225, 369);
            this.btnvezes.Name = "btnvezes";
            this.btnvezes.Size = new System.Drawing.Size(75, 23);
            this.btnvezes.TabIndex = 7;
            this.btnvezes.Text = "X";
            this.btnvezes.UseVisualStyleBackColor = true;
            this.btnvezes.Click += new System.EventHandler(this.btnvezes_Click);
            // 
            // btnmais
            // 
            this.btnmais.Location = new System.Drawing.Point(225, 328);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(75, 23);
            this.btnmais.TabIndex = 8;
            this.btnmais.Text = "+";
            this.btnmais.UseVisualStyleBackColor = true;
            this.btnmais.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(471, 285);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(15, 13);
            this.lbresultado.TabIndex = 9;
            this.lbresultado.Text = "R";
            this.lbresultado.Click += new System.EventHandler(this.lbresultado_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(345, 328);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(75, 23);
            this.btnmenos.TabIndex = 10;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(345, 369);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(75, 23);
            this.btndividir.TabIndex = 11;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // txbnumero1
            // 
            this.txbnumero1.Location = new System.Drawing.Point(225, 278);
            this.txbnumero1.Name = "txbnumero1";
            this.txbnumero1.Size = new System.Drawing.Size(100, 20);
            this.txbnumero1.TabIndex = 12;
            // 
            // txbnumero2
            // 
            this.txbnumero2.Location = new System.Drawing.Point(345, 278);
            this.txbnumero2.Name = "txbnumero2";
            this.txbnumero2.Size = new System.Drawing.Size(100, 20);
            this.txbnumero2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbnumero2);
            this.Controls.Add(this.txbnumero1);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnmais);
            this.Controls.Add(this.btnvezes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvezes;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.TextBox txbnumero1;
        private System.Windows.Forms.TextBox txbnumero2;
    }
}

