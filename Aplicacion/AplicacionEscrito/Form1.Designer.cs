namespace AplicacionEscrito
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvElectrodomesticos;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtIdElectrodomestico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.TextBox txtIdElectrodomesticoVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Button btnAgregarElectrodomestico;
        private System.Windows.Forms.Button btnModificarElectrodomestico;
        private System.Windows.Forms.Button btnEliminarElectrodomestico;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnImprimirBoleta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvElectrodomesticos = new DataGridView();
            dgvVentas = new DataGridView();
            txtIdElectrodomestico = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtMarca = new TextBox();
            txtIdVenta = new TextBox();
            txtIdElectrodomesticoVenta = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCantidad = new TextBox();
            txtIVA = new TextBox();
            txtPrecioTotal = new TextBox();
            btnAgregarElectrodomestico = new Button();
            btnModificarElectrodomestico = new Button();
            btnEliminarElectrodomestico = new Button();
            btnAgregarVenta = new Button();
            btnModificarVenta = new Button();
            btnEliminarVenta = new Button();
            btnImprimirBoleta = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvElectrodomesticos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvElectrodomesticos
            // 
            dgvElectrodomesticos.BackgroundColor = Color.White;
            dgvElectrodomesticos.Location = new Point(422, 6);
            dgvElectrodomesticos.Name = "dgvElectrodomesticos";
            dgvElectrodomesticos.Size = new Size(400, 285);
            dgvElectrodomesticos.TabIndex = 0;
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.Location = new Point(423, 6);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(400, 285);
            dgvVentas.TabIndex = 1;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // txtIdElectrodomestico
            // 
            txtIdElectrodomestico.Location = new Point(207, 74);
            txtIdElectrodomestico.Name = "txtIdElectrodomestico";
            txtIdElectrodomestico.Size = new Size(200, 23);
            txtIdElectrodomestico.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(207, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(207, 160);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(207, 204);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(200, 23);
            txtMarca.TabIndex = 5;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(208, 34);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(200, 23);
            txtIdVenta.TabIndex = 6;
            // 
            // txtIdElectrodomesticoVenta
            // 
            txtIdElectrodomesticoVenta.Location = new Point(208, 76);
            txtIdElectrodomesticoVenta.Name = "txtIdElectrodomesticoVenta";
            txtIdElectrodomesticoVenta.Size = new Size(200, 23);
            txtIdElectrodomesticoVenta.TabIndex = 7;
            txtIdElectrodomesticoVenta.TextChanged += txtIdElectrodomesticoVenta_TextChanged;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(208, 122);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(200, 23);
            txtPrecioVenta.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(208, 166);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 23);
            txtCantidad.TabIndex = 9;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(208, 209);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(200, 23);
            txtIVA.TabIndex = 10;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Location = new Point(208, 250);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(200, 23);
            txtPrecioTotal.TabIndex = 11;
            // 
            // btnAgregarElectrodomestico
            // 
            btnAgregarElectrodomestico.BackColor = Color.White;
            btnAgregarElectrodomestico.Location = new Point(29, 90);
            btnAgregarElectrodomestico.Name = "btnAgregarElectrodomestico";
            btnAgregarElectrodomestico.Size = new Size(150, 30);
            btnAgregarElectrodomestico.TabIndex = 12;
            btnAgregarElectrodomestico.Text = "Agregar Electrodoméstico";
            btnAgregarElectrodomestico.UseVisualStyleBackColor = false;
            btnAgregarElectrodomestico.Click += btnAgregarElectrodomestico_Click;
            // 
            // btnModificarElectrodomestico
            // 
            btnModificarElectrodomestico.BackColor = Color.White;
            btnModificarElectrodomestico.Location = new Point(29, 130);
            btnModificarElectrodomestico.Name = "btnModificarElectrodomestico";
            btnModificarElectrodomestico.Size = new Size(150, 30);
            btnModificarElectrodomestico.TabIndex = 13;
            btnModificarElectrodomestico.Text = "Modificar Electrodoméstico";
            btnModificarElectrodomestico.UseVisualStyleBackColor = false;
            btnModificarElectrodomestico.Click += btnModificarElectrodomestico_Click;
            // 
            // btnEliminarElectrodomestico
            // 
            btnEliminarElectrodomestico.BackColor = Color.White;
            btnEliminarElectrodomestico.Location = new Point(29, 170);
            btnEliminarElectrodomestico.Name = "btnEliminarElectrodomestico";
            btnEliminarElectrodomestico.Size = new Size(150, 30);
            btnEliminarElectrodomestico.TabIndex = 14;
            btnEliminarElectrodomestico.Text = "Eliminar Electrodoméstico";
            btnEliminarElectrodomestico.UseVisualStyleBackColor = false;
            btnEliminarElectrodomestico.Click += btnEliminarElectrodomestico_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = Color.White;
            btnAgregarVenta.Location = new Point(30, 76);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(150, 30);
            btnAgregarVenta.TabIndex = 15;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.BackColor = Color.White;
            btnModificarVenta.Location = new Point(30, 116);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(150, 30);
            btnModificarVenta.TabIndex = 16;
            btnModificarVenta.Text = "Modificar";
            btnModificarVenta.UseVisualStyleBackColor = false;
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.BackColor = Color.White;
            btnEliminarVenta.Location = new Point(30, 156);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(150, 30);
            btnEliminarVenta.TabIndex = 17;
            btnEliminarVenta.Text = "Eliminar";
            btnEliminarVenta.UseVisualStyleBackColor = false;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnImprimirBoleta
            // 
            btnImprimirBoleta.BackColor = Color.White;
            btnImprimirBoleta.Location = new Point(30, 196);
            btnImprimirBoleta.Name = "btnImprimirBoleta";
            btnImprimirBoleta.Size = new Size(150, 30);
            btnImprimirBoleta.TabIndex = 18;
            btnImprimirBoleta.Text = "Imprimir Factura";
            btnImprimirBoleta.UseVisualStyleBackColor = false;
            btnImprimirBoleta.Click += btnImprimirBoleta_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(837, 327);
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvElectrodomesticos);
            tabPage1.Controls.Add(btnEliminarElectrodomestico);
            tabPage1.Controls.Add(btnModificarElectrodomestico);
            tabPage1.Controls.Add(txtIdElectrodomestico);
            tabPage1.Controls.Add(btnAgregarElectrodomestico);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(txtMarca);
            tabPage1.Controls.Add(txtPrecio);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(829, 299);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Electrodomestico";
            tabPage1.Click += tabPage1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 186);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 18;
            label4.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 142);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 17;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 98);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 56);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 15;
            label1.Text = "ID Electrodoméstico";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dgvVentas);
            tabPage2.Controls.Add(btnImprimirBoleta);
            tabPage2.Controls.Add(txtIdVenta);
            tabPage2.Controls.Add(btnEliminarVenta);
            tabPage2.Controls.Add(txtIdElectrodomesticoVenta);
            tabPage2.Controls.Add(btnModificarVenta);
            tabPage2.Controls.Add(txtPrecioVenta);
            tabPage2.Controls.Add(btnAgregarVenta);
            tabPage2.Controls.Add(txtCantidad);
            tabPage2.Controls.Add(txtPrecioTotal);
            tabPage2.Controls.Add(txtIVA);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(829, 299);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Venta";
            tabPage2.Click += tabPage2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 235);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 24;
            label10.Text = "Precio Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(208, 191);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 23;
            label9.Text = "IVA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 148);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 22;
            label8.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 102);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 21;
            label7.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 58);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 20;
            label6.Text = "ID Electrodoméstico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 16);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 19;
            label5.Text = "ID Venta";
            // 
            // Form1
            // 
            ClientSize = new Size(839, 327);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestión de Electrodomésticos y Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvElectrodomesticos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}
