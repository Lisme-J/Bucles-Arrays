namespace _01_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCalcular = new Button();
            lblAfp = new Label();
            lblSFS = new Label();
            IbllSR = new Label();
            lblDescuento = new Label();
            lblOtros = new Label();
            lblSueldoAnual = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblSueldoNeto = new Label();
            lblCargoResultado = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCargo = new Label();
            txtCargo = new TextBox();
            txtSueldoBruto = new TextBox();
            lblSueldo = new Label();
            lblHijos = new Label();
            txtHijos = new TextBox();
            txtResultadoAfp = new TextBox();
            txtResultadoSfs = new TextBox();
            txtResultadoISr = new TextBox();
            txtOtrosDescuentos = new TextBox();
            txtDescuentototal = new TextBox();
            lblIncentivos = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblIngresar = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtNeto = new TextBox();
            txtResultadoCargo = new TextBox();
            txtIncentivoHIjos = new TextBox();
            txtAnual = new TextBox();
            txtNombreInfo = new TextBox();
            panel4 = new Panel();
            lblNombreResultado = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(64, 64, 64);
            btnCalcular.FlatAppearance.BorderSize = 2;
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 59, 173);
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(113, 59, 173);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.MintCream;
            btnCalcular.Location = new Point(415, 299);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(229, 43);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblAfp
            // 
            lblAfp.AutoSize = true;
            lblAfp.BackColor = Color.Transparent;
            lblAfp.Font = new Font("Arial Narrow", 12F);
            lblAfp.ForeColor = SystemColors.Control;
            lblAfp.Location = new Point(125, 63);
            lblAfp.Name = "lblAfp";
            lblAfp.Size = new Size(52, 24);
            lblAfp.TabIndex = 3;
            lblAfp.Text = "AFP: ";
            // 
            // lblSFS
            // 
            lblSFS.AutoSize = true;
            lblSFS.BackColor = Color.Transparent;
            lblSFS.Font = new Font("Arial Narrow", 12F);
            lblSFS.ForeColor = SystemColors.Control;
            lblSFS.Location = new Point(125, 133);
            lblSFS.Name = "lblSFS";
            lblSFS.Size = new Size(52, 24);
            lblSFS.TabIndex = 4;
            lblSFS.Text = "SFS: ";
            // 
            // IbllSR
            // 
            IbllSR.AutoSize = true;
            IbllSR.BackColor = Color.Transparent;
            IbllSR.Font = new Font("Arial Narrow", 12F);
            IbllSR.ForeColor = SystemColors.Control;
            IbllSR.Location = new Point(467, 63);
            IbllSR.Name = "IbllSR";
            IbllSR.Size = new Size(48, 24);
            IbllSR.TabIndex = 5;
            IbllSR.Text = "ISR: ";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.Font = new Font("Arial Narrow", 12F);
            lblDescuento.ForeColor = SystemColors.Control;
            lblDescuento.Location = new Point(752, 63);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(139, 24);
            lblDescuento.TabIndex = 19;
            lblDescuento.Text = "Descuento total:  ";
            // 
            // lblOtros
            // 
            lblOtros.AutoSize = true;
            lblOtros.BackColor = Color.Transparent;
            lblOtros.Font = new Font("Arial Narrow", 12F);
            lblOtros.ForeColor = SystemColors.Control;
            lblOtros.Location = new Point(467, 133);
            lblOtros.Name = "lblOtros";
            lblOtros.Size = new Size(60, 24);
            lblOtros.TabIndex = 22;
            lblOtros.Text = "Otros: ";
            // 
            // lblSueldoAnual
            // 
            lblSueldoAnual.AutoSize = true;
            lblSueldoAnual.BackColor = Color.Transparent;
            lblSueldoAnual.Font = new Font("Arial Narrow", 13F);
            lblSueldoAnual.ForeColor = Color.White;
            lblSueldoAnual.Location = new Point(563, 181);
            lblSueldoAnual.Name = "lblSueldoAnual";
            lblSueldoAnual.Size = new Size(128, 26);
            lblSueldoAnual.TabIndex = 24;
            lblSueldoAnual.Text = "Sueldo Anual: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Transparent;
            btnLimpiar.Location = new Point(993, 215);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(48, 55);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Transparent;
            btnSalir.Location = new Point(-1, -1);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(71, 41);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.BackColor = Color.Transparent;
            lblSueldoNeto.Font = new Font("Arial Narrow", 13F);
            lblSueldoNeto.ForeColor = Color.White;
            lblSueldoNeto.Location = new Point(139, 181);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(121, 26);
            lblSueldoNeto.TabIndex = 27;
            lblSueldoNeto.Text = "Sueldo Neto: ";
            // 
            // lblCargoResultado
            // 
            lblCargoResultado.AutoSize = true;
            lblCargoResultado.BackColor = Color.Transparent;
            lblCargoResultado.Font = new Font("Arial Narrow", 13F);
            lblCargoResultado.ForeColor = Color.White;
            lblCargoResultado.Location = new Point(414, 92);
            lblCargoResultado.Name = "lblCargoResultado";
            lblCargoResultado.Size = new Size(71, 26);
            lblCargoResultado.TabIndex = 29;
            lblCargoResultado.Text = "Cargo: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblNombre.ForeColor = SystemColors.ControlDarkDark;
            lblNombre.Location = new Point(198, 116);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(92, 30);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(198, 152);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 31;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.BackColor = Color.Transparent;
            lblCargo.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblCargo.ForeColor = SystemColors.ControlDarkDark;
            lblCargo.Location = new Point(649, 116);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(80, 30);
            lblCargo.TabIndex = 32;
            lblCargo.Text = "Cargo ";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCargo.ForeColor = SystemColors.WindowFrame;
            txtCargo.Location = new Point(649, 152);
            txtCargo.Margin = new Padding(3, 4, 3, 4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(228, 27);
            txtCargo.TabIndex = 33;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSueldoBruto.ForeColor = SystemColors.WindowFrame;
            txtSueldoBruto.Location = new Point(197, 236);
            txtSueldoBruto.Margin = new Padding(3, 4, 3, 4);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.Size = new Size(228, 27);
            txtSueldoBruto.TabIndex = 34;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.Transparent;
            lblSueldo.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblSueldo.ForeColor = SystemColors.ControlDarkDark;
            lblSueldo.Location = new Point(198, 200);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(84, 30);
            lblSueldo.TabIndex = 35;
            lblSueldo.Text = "Sueldo";
            // 
            // lblHijos
            // 
            lblHijos.AutoSize = true;
            lblHijos.BackColor = Color.Transparent;
            lblHijos.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblHijos.ForeColor = SystemColors.ControlDarkDark;
            lblHijos.Location = new Point(649, 200);
            lblHijos.Name = "lblHijos";
            lblHijos.Size = new Size(65, 30);
            lblHijos.TabIndex = 36;
            lblHijos.Text = "Hijos";
            // 
            // txtHijos
            // 
            txtHijos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHijos.ForeColor = SystemColors.WindowFrame;
            txtHijos.Location = new Point(649, 236);
            txtHijos.Margin = new Padding(3, 4, 3, 4);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(228, 27);
            txtHijos.TabIndex = 37;
            // 
            // txtResultadoAfp
            // 
            txtResultadoAfp.BorderStyle = BorderStyle.None;
            txtResultadoAfp.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoAfp.Location = new Point(125, 95);
            txtResultadoAfp.Margin = new Padding(3, 4, 3, 4);
            txtResultadoAfp.Name = "txtResultadoAfp";
            txtResultadoAfp.Size = new Size(150, 18);
            txtResultadoAfp.TabIndex = 40;
            // 
            // txtResultadoSfs
            // 
            txtResultadoSfs.BorderStyle = BorderStyle.None;
            txtResultadoSfs.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoSfs.Location = new Point(125, 165);
            txtResultadoSfs.Margin = new Padding(3, 4, 3, 4);
            txtResultadoSfs.Name = "txtResultadoSfs";
            txtResultadoSfs.Size = new Size(150, 18);
            txtResultadoSfs.TabIndex = 41;
            // 
            // txtResultadoISr
            // 
            txtResultadoISr.BorderStyle = BorderStyle.None;
            txtResultadoISr.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoISr.Location = new Point(467, 95);
            txtResultadoISr.Margin = new Padding(3, 4, 3, 4);
            txtResultadoISr.Name = "txtResultadoISr";
            txtResultadoISr.Size = new Size(150, 18);
            txtResultadoISr.TabIndex = 42;
            // 
            // txtOtrosDescuentos
            // 
            txtOtrosDescuentos.BorderStyle = BorderStyle.None;
            txtOtrosDescuentos.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOtrosDescuentos.Location = new Point(467, 165);
            txtOtrosDescuentos.Margin = new Padding(3, 4, 3, 4);
            txtOtrosDescuentos.Name = "txtOtrosDescuentos";
            txtOtrosDescuentos.Size = new Size(150, 18);
            txtOtrosDescuentos.TabIndex = 43;
            // 
            // txtDescuentototal
            // 
            txtDescuentototal.BorderStyle = BorderStyle.None;
            txtDescuentototal.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescuentototal.Location = new Point(752, 95);
            txtDescuentototal.Margin = new Padding(3, 4, 3, 4);
            txtDescuentototal.Name = "txtDescuentototal";
            txtDescuentototal.Size = new Size(150, 18);
            txtDescuentototal.TabIndex = 44;
            // 
            // lblIncentivos
            // 
            lblIncentivos.AutoSize = true;
            lblIncentivos.BackColor = Color.Transparent;
            lblIncentivos.Font = new Font("Arial Narrow", 13F);
            lblIncentivos.ForeColor = Color.White;
            lblIncentivos.Location = new Point(688, 92);
            lblIncentivos.Name = "lblIncentivos";
            lblIncentivos.Size = new Size(128, 26);
            lblIncentivos.TabIndex = 49;
            lblIncentivos.Text = "Incentivo Hijos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 228, 244);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtHijos);
            panel1.Controls.Add(lblHijos);
            panel1.Controls.Add(lblSueldo);
            panel1.Controls.Add(txtSueldoBruto);
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(lblCargo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(btnCalcular);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 365);
            panel1.TabIndex = 51;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(lblIngresar);
            panel2.Controls.Add(btnSalir);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1058, 92);
            panel2.TabIndex = 38;
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.BackColor = Color.Transparent;
            lblIngresar.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresar.ForeColor = SystemColors.Control;
            lblIngresar.Location = new Point(414, 27);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(253, 35);
            lblIngresar.TabIndex = 39;
            lblIngresar.Text = "Ingrese los Datos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtOtrosDescuentos);
            panel3.Controls.Add(lblAfp);
            panel3.Controls.Add(lblSFS);
            panel3.Controls.Add(IbllSR);
            panel3.Controls.Add(lblDescuento);
            panel3.Controls.Add(lblOtros);
            panel3.Controls.Add(txtResultadoAfp);
            panel3.Controls.Add(txtDescuentototal);
            panel3.Controls.Add(txtResultadoSfs);
            panel3.Controls.Add(txtResultadoISr);
            panel3.Location = new Point(3, 375);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1058, 215);
            panel3.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(457, 9);
            label3.Name = "label3";
            label3.Size = new Size(172, 35);
            label3.TabIndex = 53;
            label3.Text = "Descuentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(434, 17);
            label2.Name = "label2";
            label2.Size = new Size(214, 35);
            label2.TabIndex = 41;
            label2.Text = "Informaciones";
            label2.Click += label2_Click_1;
            // 
            // txtNeto
            // 
            txtNeto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNeto.ForeColor = SystemColors.WindowFrame;
            txtNeto.Location = new Point(139, 215);
            txtNeto.Margin = new Padding(3, 4, 3, 4);
            txtNeto.Name = "txtNeto";
            txtNeto.Size = new Size(369, 27);
            txtNeto.TabIndex = 39;
            // 
            // txtResultadoCargo
            // 
            txtResultadoCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoCargo.ForeColor = SystemColors.WindowFrame;
            txtResultadoCargo.Location = new Point(414, 125);
            txtResultadoCargo.Margin = new Padding(3, 4, 3, 4);
            txtResultadoCargo.Name = "txtResultadoCargo";
            txtResultadoCargo.Size = new Size(228, 27);
            txtResultadoCargo.TabIndex = 54;
            // 
            // txtIncentivoHIjos
            // 
            txtIncentivoHIjos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIncentivoHIjos.ForeColor = SystemColors.WindowFrame;
            txtIncentivoHIjos.Location = new Point(688, 125);
            txtIncentivoHIjos.Margin = new Padding(3, 4, 3, 4);
            txtIncentivoHIjos.Name = "txtIncentivoHIjos";
            txtIncentivoHIjos.Size = new Size(228, 27);
            txtIncentivoHIjos.TabIndex = 55;
            // 
            // txtAnual
            // 
            txtAnual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAnual.ForeColor = SystemColors.WindowFrame;
            txtAnual.Location = new Point(563, 215);
            txtAnual.Margin = new Padding(3, 4, 3, 4);
            txtAnual.Name = "txtAnual";
            txtAnual.Size = new Size(353, 27);
            txtAnual.TabIndex = 56;
            // 
            // txtNombreInfo
            // 
            txtNombreInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreInfo.ForeColor = SystemColors.WindowFrame;
            txtNombreInfo.Location = new Point(139, 125);
            txtNombreInfo.Margin = new Padding(3, 4, 3, 4);
            txtNombreInfo.Name = "txtNombreInfo";
            txtNombreInfo.Size = new Size(228, 27);
            txtNombreInfo.TabIndex = 57;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtNombreInfo);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnLimpiar);
            panel4.Controls.Add(txtAnual);
            panel4.Controls.Add(lblNombreResultado);
            panel4.Controls.Add(txtIncentivoHIjos);
            panel4.Controls.Add(lblSueldoAnual);
            panel4.Controls.Add(txtResultadoCargo);
            panel4.Controls.Add(lblSueldoNeto);
            panel4.Controls.Add(txtNeto);
            panel4.Controls.Add(lblCargoResultado);
            panel4.Controls.Add(lblIncentivos);
            panel4.Location = new Point(3, 598);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1058, 294);
            panel4.TabIndex = 54;
            // 
            // lblNombreResultado
            // 
            lblNombreResultado.AutoSize = true;
            lblNombreResultado.BackColor = Color.Transparent;
            lblNombreResultado.Font = new Font("Arial Narrow", 13F);
            lblNombreResultado.ForeColor = Color.White;
            lblNombreResultado.Location = new Point(139, 92);
            lblNombreResultado.Name = "lblNombreResultado";
            lblNombreResultado.Size = new Size(86, 26);
            lblNombreResultado.TabIndex = 28;
            lblNombreResultado.Text = "Nombre: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1062, 881);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCalcular;
        private Label lblAfp;
        private Label lblSFS;
        private Label IbllSR;
        private Label lblDescuento;
        private Label lblOtros;
        private Label lblSueldoAnual;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblSueldoNeto;
        private Label lblCargoResultado;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCargo;
        private TextBox txtCargo;
        private TextBox txtSueldoBruto;
        private Label lblSueldo;
        private Label lblHijos;
        private TextBox txtHijos;
        private TextBox txtResultadoAfp;
        private TextBox txtResultadoSfs;
        private TextBox txtResultadoISr;
        private TextBox txtOtrosDescuentos;
        private TextBox txtDescuentototal;
        private TextBox txtResultadoNombre;
        private TextBox txtResultadoCargo;
        private TextBox txtIncentivoHIjos;
        private TextBox txtAnual;
        private Label lblIncentivos;
        private Panel panel1;
        private Label lblIngresar;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private TextBox txtNeto;
        private TextBox txtNombreInfo;
        private Panel panel4;
        private Label lblNombreResultado;
    }
}
