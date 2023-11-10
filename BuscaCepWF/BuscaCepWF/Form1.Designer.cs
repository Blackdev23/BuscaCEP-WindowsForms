namespace BuscaCepWF
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
            label1 = new Label();
            maskCEP = new MaskedTextBox();
            txtEstado = new TextBox();
            txtBairro = new TextBox();
            txtMunicipio = new TextBox();
            txtComplemento2 = new TextBox();
            txtComplemento = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnPesquisarCep = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 30);
            label1.TabIndex = 0;
            label1.Text = "Busca CEP - EvolutionSenai";
            // 
            // maskCEP
            // 
            maskCEP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maskCEP.Location = new Point(117, 73);
            maskCEP.Mask = "00000-000";
            maskCEP.Name = "maskCEP";
            maskCEP.Size = new Size(100, 29);
            maskCEP.TabIndex = 1;
            maskCEP.KeyPress += maskCEP_KeyPress;
            maskCEP.Leave += maskCEP_Leave;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEstado.Location = new Point(189, 226);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(364, 29);
            txtEstado.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBairro.Location = new Point(189, 276);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(364, 29);
            txtBairro.TabIndex = 3;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMunicipio.Location = new Point(189, 178);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(364, 29);
            txtMunicipio.TabIndex = 4;
            // 
            // txtComplemento2
            // 
            txtComplemento2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtComplemento2.Location = new Point(189, 480);
            txtComplemento2.Name = "txtComplemento2";
            txtComplemento2.Size = new Size(364, 29);
            txtComplemento2.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtComplemento.Location = new Point(189, 377);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(364, 29);
            txtComplemento.TabIndex = 6;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(189, 326);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(364, 29);
            txtLogradouro.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumero.Location = new Point(189, 429);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(364, 29);
            txtNumero.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 181);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 9;
            label2.Text = "Cidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 229);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 10;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 279);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 11;
            label4.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 329);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 12;
            label5.Text = "Logradouro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 380);
            label6.Name = "label6";
            label6.Size = new Size(122, 23);
            label6.TabIndex = 13;
            label6.Text = "Complemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 432);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 14;
            label7.Text = "Número";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 483);
            label8.Name = "label8";
            label8.Size = new Size(137, 23);
            label8.TabIndex = 15;
            label8.Text = "Complemento 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(36, 77);
            label9.Name = "label9";
            label9.Size = new Size(46, 25);
            label9.TabIndex = 16;
            label9.Text = "CEP";
            // 
            // btnPesquisarCep
            // 
            btnPesquisarCep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisarCep.Location = new Point(243, 77);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(75, 23);
            btnPesquisarCep.TabIndex = 17;
            btnPesquisarCep.Text = "Buscar";
            btnPesquisarCep.UseVisualStyleBackColor = true;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Image = Properties.Resources._2931168_bin_delete_remove_trash_garbage_icon;
            btnLimpar.Location = new Point(22, 546);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(147, 56);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 623);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisarCep);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtComplemento);
            Controls.Add(txtComplemento2);
            Controls.Add(txtMunicipio);
            Controls.Add(txtBairro);
            Controls.Add(txtEstado);
            Controls.Add(maskCEP);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskCEP;
        private TextBox txtEstado;
        private TextBox txtBairro;
        private TextBox txtMunicipio;
        private TextBox txtComplemento2;
        private TextBox txtComplemento;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnPesquisarCep;
        private Button btnLimpar;
    }
}