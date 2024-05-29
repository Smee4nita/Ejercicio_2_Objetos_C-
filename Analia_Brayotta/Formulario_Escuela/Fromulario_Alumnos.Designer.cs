namespace Formulario_Escuela
{
    partial class Fromulario_Alumnos
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
            txt_nombre = new TextBox();
            txt_Nota_Segundo_Parcial = new TextBox();
            txt_nota_primer_parcial = new TextBox();
            txt_Legajo = new TextBox();
            txt_Apellido = new TextBox();
            listBox1 = new ListBox();
            btn_enviar = new Button();
            btn_mostrar = new Button();
            btn_limpiar = new Button();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_legajo = new Label();
            lbl_nota_primer_parcial = new Label();
            lbl_nota_Segundo_Parcial = new Label();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(36, 29);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(116, 23);
            txt_nombre.TabIndex = 0;
            txt_nombre.TextChanged += textBox1_TextChanged;
            // 
            // txt_Nota_Segundo_Parcial
            // 
            txt_Nota_Segundo_Parcial.Location = new Point(36, 223);
            txt_Nota_Segundo_Parcial.Name = "txt_Nota_Segundo_Parcial";
            txt_Nota_Segundo_Parcial.Size = new Size(116, 23);
            txt_Nota_Segundo_Parcial.TabIndex = 1;
            // 
            // txt_nota_primer_parcial
            // 
            txt_nota_primer_parcial.Location = new Point(36, 176);
            txt_nota_primer_parcial.Name = "txt_nota_primer_parcial";
            txt_nota_primer_parcial.Size = new Size(116, 23);
            txt_nota_primer_parcial.TabIndex = 2;
            txt_nota_primer_parcial.TextChanged += textBox3_TextChanged;
            // 
            // txt_Legajo
            // 
            txt_Legajo.Location = new Point(36, 124);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(116, 23);
            txt_Legajo.TabIndex = 3;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(36, 79);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(116, 23);
            txt_Apellido.TabIndex = 4;
            txt_Apellido.TextChanged += textBox5_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(362, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 244);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(67, 293);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 6;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(362, 293);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 7;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(562, 293);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 8;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += button3_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(36, 11);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 9;
            lbl_nombre.Text = "Nombre";
            lbl_nombre.Click += label1_Click;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(36, 61);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 10;
            lbl_apellido.Text = "Apellido";
            lbl_apellido.Click += label2_Click;
            // 
            // lbl_legajo
            // 
            lbl_legajo.AutoSize = true;
            lbl_legajo.Location = new Point(36, 106);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(42, 15);
            lbl_legajo.TabIndex = 11;
            lbl_legajo.Text = "Legajo";
            lbl_legajo.Click += label3_Click;
            // 
            // lbl_nota_primer_parcial
            // 
            lbl_nota_primer_parcial.AutoSize = true;
            lbl_nota_primer_parcial.Location = new Point(36, 158);
            lbl_nota_primer_parcial.Name = "lbl_nota_primer_parcial";
            lbl_nota_primer_parcial.Size = new Size(109, 15);
            lbl_nota_primer_parcial.TabIndex = 12;
            lbl_nota_primer_parcial.Text = "Nota Primer Parcial";
            // 
            // lbl_nota_Segundo_Parcial
            // 
            lbl_nota_Segundo_Parcial.AutoSize = true;
            lbl_nota_Segundo_Parcial.Location = new Point(36, 205);
            lbl_nota_Segundo_Parcial.Name = "lbl_nota_Segundo_Parcial";
            lbl_nota_Segundo_Parcial.Size = new Size(121, 15);
            lbl_nota_Segundo_Parcial.TabIndex = 13;
            lbl_nota_Segundo_Parcial.Text = "Nota Segundo Parcial";
            lbl_nota_Segundo_Parcial.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_nota_Segundo_Parcial);
            Controls.Add(lbl_nota_primer_parcial);
            Controls.Add(lbl_legajo);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_enviar);
            Controls.Add(listBox1);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Legajo);
            Controls.Add(txt_nota_primer_parcial);
            Controls.Add(txt_Nota_Segundo_Parcial);
            Controls.Add(txt_nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nombre;
        private TextBox txt_Nota_Segundo_Parcial;
        private TextBox txt_nota_primer_parcial;
        private TextBox txt_Legajo;
        private TextBox txt_Apellido;
        private ListBox listBox1;
        private Button btn_enviar;
        private Button btn_mostrar;
        private Button btn_limpiar;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_legajo;
        private Label lbl_nota_primer_parcial;
        private Label lbl_nota_Segundo_Parcial;
    }
}
