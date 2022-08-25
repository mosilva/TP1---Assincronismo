namespace TP1Assincronismo
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMesagem = new System.Windows.Forms.Label();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMesagem
            // 
            this.lblMesagem.AutoSize = true;
            this.lblMesagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMesagem.Location = new System.Drawing.Point(12, 200);
            this.lblMesagem.Name = "lblMesagem";
            this.lblMesagem.Size = new System.Drawing.Size(64, 15);
            this.lblMesagem.TabIndex = 2;
            this.lblMesagem.Text = "Resultados";
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 15;
            this.listBoxResultado.Items.AddRange(new object[] {
            "Descubra sua ",
            "folha de pagamento,",
            "Imposto, ",
            "Despesa e ",
            "Receita aqui..."});
            this.listBoxResultado.Location = new System.Drawing.Point(12, 12);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(193, 124);
            this.listBoxResultado.TabIndex = 3;
            this.listBoxResultado.SelectedIndexChanged += new System.EventHandler(this.listBoxResultado_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 224);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.lblMesagem);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Calcular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnCalcular;
        private Label lblMesagem;
        private ListBox listBoxResultado;
    }
}