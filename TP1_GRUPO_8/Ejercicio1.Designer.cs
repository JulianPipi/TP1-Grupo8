namespace TP1_GRUPO_8
{
    partial class Ejercicio1
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
            this.lblIngresarNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombres1 = new System.Windows.Forms.ListBox();
            this.lbNombres2 = new System.Windows.Forms.ListBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAll_Left = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngresarNombre
            // 
            this.lblIngresarNombre.AutoSize = true;
            this.lblIngresarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombre.Location = new System.Drawing.Point(34, 71);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(165, 20);
            this.lblIngresarNombre.TabIndex = 0;
            this.lblIngresarNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(387, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(605, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 21);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombres1
            // 
            this.lbNombres1.FormattingEnabled = true;
            this.lbNombres1.Location = new System.Drawing.Point(16, 110);
            this.lbNombres1.Name = "lbNombres1";
            this.lbNombres1.Size = new System.Drawing.Size(183, 329);
            this.lbNombres1.TabIndex = 3;
            this.lbNombres1.SelectedIndexChanged += new System.EventHandler(this.lbNombres1_SelectedIndexChanged);
            // 
            // lbNombres2
            // 
            this.lbNombres2.FormattingEnabled = true;
            this.lbNombres2.Location = new System.Drawing.Point(605, 110);
            this.lbNombres2.Name = "lbNombres2";
            this.lbNombres2.Size = new System.Drawing.Size(183, 329);
            this.lbNombres2.TabIndex = 4;
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(366, 153);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 23);
            this.btnUno.TabIndex = 5;
            this.btnUno.Text = ">";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(366, 222);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 6;
            this.btnTodos.Text = "> >";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(366, 287);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.buttonLeft);
            // 
            // btnAll_Left
            // 
            this.btnAll_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll_Left.Location = new System.Drawing.Point(366, 352);
            this.btnAll_Left.Name = "btnAll_Left";
            this.btnAll_Left.Size = new System.Drawing.Size(75, 23);
            this.btnAll_Left.TabIndex = 8;
            this.btnAll_Left.Text = "<<";
            this.btnAll_Left.UseVisualStyleBackColor = true;
            this.btnAll_Left.Click += new System.EventHandler(this.btnAll_Left_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAll_Left);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.lbNombres2);
            this.Controls.Add(this.lbNombres1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngresarNombre);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombres1;
        private System.Windows.Forms.ListBox lbNombres2;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAll_Left;
    }
}