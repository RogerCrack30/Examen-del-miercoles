
namespace prac
{
    partial class from1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtCodigoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAgre = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.txtCodigoProduct = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoPedi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.txtExistentes = new System.Windows.Forms.TextBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtDescripProduc = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtCodiProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConsultas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(59, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 402);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.dgvClientes);
            this.tabPage1.Controls.Add(this.txtApellidoCliente);
            this.tabPage1.Controls.Add(this.txtNomCliente);
            this.tabPage1.Controls.Add(this.txtEmpresa);
            this.tabPage1.Controls.Add(this.txtCodigoC);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(381, 131);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(23, 170);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(491, 186);
            this.dgvClientes.TabIndex = 8;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(141, 114);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCliente.TabIndex = 7;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(141, 79);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomCliente.TabIndex = 6;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(141, 50);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 5;
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.Location = new System.Drawing.Point(141, 22);
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtNumPedido);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.btnAgre);
            this.tabPage2.Controls.Add(this.dgvPedido);
            this.tabPage2.Controls.Add(this.txtCodigoProduct);
            this.tabPage2.Controls.Add(this.txtCodigoCliente);
            this.tabPage2.Controls.Add(this.txtCodigoPedi);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Fechas de pedido:";
            // 
            // btnAgre
            // 
            this.btnAgre.Location = new System.Drawing.Point(405, 145);
            this.btnAgre.Name = "btnAgre";
            this.btnAgre.Size = new System.Drawing.Size(113, 23);
            this.btnAgre.TabIndex = 9;
            this.btnAgre.Text = "Agregar";
            this.btnAgre.UseVisualStyleBackColor = true;
            this.btnAgre.Click += new System.EventHandler(this.btnAgre_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(26, 174);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(492, 187);
            this.dgvPedido.TabIndex = 8;
            // 
            // txtCodigoProduct
            // 
            this.txtCodigoProduct.Location = new System.Drawing.Point(130, 119);
            this.txtCodigoProduct.Name = "txtCodigoProduct";
            this.txtCodigoProduct.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProduct.TabIndex = 7;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(130, 88);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 6;
            // 
            // txtCodigoPedi
            // 
            this.txtCodigoPedi.Location = new System.Drawing.Point(130, 30);
            this.txtCodigoPedi.Name = "txtCodigoPedi";
            this.txtCodigoPedi.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPedi.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Codigo Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Codigo cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Numero de Pedido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo Pedido:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.dgvProducto);
            this.tabPage3.Controls.Add(this.txtExistentes);
            this.tabPage3.Controls.Add(this.txtPrecioUnidad);
            this.tabPage3.Controls.Add(this.txtDescripProduc);
            this.tabPage3.Controls.Add(this.txtNombreProd);
            this.tabPage3.Controls.Add(this.txtCodiProducto);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(534, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Producto ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(425, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(20, 173);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(496, 189);
            this.dgvProducto.TabIndex = 10;
            // 
            // txtExistentes
            // 
            this.txtExistentes.Location = new System.Drawing.Point(155, 144);
            this.txtExistentes.Name = "txtExistentes";
            this.txtExistentes.Size = new System.Drawing.Size(144, 20);
            this.txtExistentes.TabIndex = 9;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(155, 118);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(144, 20);
            this.txtPrecioUnidad.TabIndex = 8;
            // 
            // txtDescripProduc
            // 
            this.txtDescripProduc.Location = new System.Drawing.Point(155, 69);
            this.txtDescripProduc.Multiline = true;
            this.txtDescripProduc.Name = "txtDescripProduc";
            this.txtDescripProduc.Size = new System.Drawing.Size(144, 43);
            this.txtDescripProduc.TabIndex = 7;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(155, 43);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(144, 20);
            this.txtNombreProd.TabIndex = 6;
            // 
            // txtCodiProducto
            // 
            this.txtCodiProducto.Location = new System.Drawing.Point(155, 17);
            this.txtCodiProducto.Name = "txtCodiProducto";
            this.txtCodiProducto.Size = new System.Drawing.Size(144, 20);
            this.txtCodiProducto.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Unidad Existente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Precio Unidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Descripcion del producto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nombre del producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Codigo Producto:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txtConsultas);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(534, 376);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consulta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(109, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(329, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "--AQUI SE MUESTRAN LOS RESULTADOS--";
            // 
            // txtConsultas
            // 
            this.txtConsultas.Location = new System.Drawing.Point(6, 188);
            this.txtConsultas.Multiline = true;
            this.txtConsultas.Name = "txtConsultas";
            this.txtConsultas.Size = new System.Drawing.Size(522, 170);
            this.txtConsultas.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTAS";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(387, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Clientes Ordenados";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(274, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Productos";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(146, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pedidos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Clientes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(130, 62);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(100, 20);
            this.txtNumPedido.TabIndex = 12;
            // 
            // from1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 508);
            this.Controls.Add(this.tabControl1);
            this.Name = "from1";
            this.Text = "Registro de Venta";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtCodigoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAgre;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtCodigoProduct;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoPedi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TextBox txtExistentes;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.TextBox txtDescripProduc;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtCodiProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConsultas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtNumPedido;
    }
}

