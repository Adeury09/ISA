namespace Invecam_S_A
{
    partial class Productos
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
            this.tabListadoProductos = new System.Windows.Forms.TabControl();
            this.tabListadoP = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBuscar1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabIngresarP = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBuscar2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabListadoProductos.SuspendLayout();
            this.tabListadoP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabIngresarP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabListadoProductos
            // 
            this.tabListadoProductos.Controls.Add(this.tabListadoP);
            this.tabListadoProductos.Controls.Add(this.tabIngresarP);
            this.tabListadoProductos.Location = new System.Drawing.Point(24, 92);
            this.tabListadoProductos.Name = "tabListadoProductos";
            this.tabListadoProductos.SelectedIndex = 0;
            this.tabListadoProductos.Size = new System.Drawing.Size(1823, 897);
            this.tabListadoProductos.TabIndex = 0;
            // 
            // tabListadoP
            // 
            this.tabListadoP.Controls.Add(this.btnSearch1);
            this.tabListadoP.Controls.Add(this.label6);
            this.tabListadoP.Controls.Add(this.textBuscar1);
            this.tabListadoP.Controls.Add(this.dataGridView1);
            this.tabListadoP.Location = new System.Drawing.Point(8, 39);
            this.tabListadoP.Name = "tabListadoP";
            this.tabListadoP.Padding = new System.Windows.Forms.Padding(3);
            this.tabListadoP.Size = new System.Drawing.Size(1807, 850);
            this.tabListadoP.TabIndex = 0;
            this.tabListadoP.Text = "Listado de productos";
            this.tabListadoP.UseVisualStyleBackColor = true;
            this.tabListadoP.Click += new System.EventHandler(this.tabListadoP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 39);
            this.label6.TabIndex = 18;
            this.label6.Text = "Buscar";
            // 
            // textBuscar1
            // 
            this.textBuscar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar1.Location = new System.Drawing.Point(178, 50);
            this.textBuscar1.Name = "textBuscar1";
            this.textBuscar1.Size = new System.Drawing.Size(1469, 47);
            this.textBuscar1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1725, 676);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabIngresarP
            // 
            this.tabIngresarP.Controls.Add(this.btnUpdate);
            this.tabIngresarP.Controls.Add(this.btnNew);
            this.tabIngresarP.Controls.Add(this.btnSearch2);
            this.tabIngresarP.Controls.Add(this.btnDelete);
            this.tabIngresarP.Controls.Add(this.btnCancel);
            this.tabIngresarP.Controls.Add(this.btnEdit);
            this.tabIngresarP.Controls.Add(this.btnSave);
            this.tabIngresarP.Controls.Add(this.label5);
            this.tabIngresarP.Controls.Add(this.textBuscar2);
            this.tabIngresarP.Controls.Add(this.label1);
            this.tabIngresarP.Controls.Add(this.txtPrecioVenta);
            this.tabIngresarP.Controls.Add(this.label4);
            this.tabIngresarP.Controls.Add(this.txtPrecioCosto);
            this.tabIngresarP.Controls.Add(this.label3);
            this.tabIngresarP.Controls.Add(this.txtPresentacion);
            this.tabIngresarP.Controls.Add(this.label2);
            this.tabIngresarP.Controls.Add(this.txtProducto);
            this.tabIngresarP.Controls.Add(this.dataGridView2);
            this.tabIngresarP.Controls.Add(this.panel1);
            this.tabIngresarP.Location = new System.Drawing.Point(8, 39);
            this.tabIngresarP.Name = "tabIngresarP";
            this.tabIngresarP.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngresarP.Size = new System.Drawing.Size(1807, 850);
            this.tabIngresarP.TabIndex = 1;
            this.tabIngresarP.Text = "Ingresar productos";
            this.tabIngresarP.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Buscar";
            // 
            // textBuscar2
            // 
            this.textBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar2.Location = new System.Drawing.Point(202, 298);
            this.textBuscar2.Name = "textBuscar2";
            this.textBuscar2.Size = new System.Drawing.Size(1421, 47);
            this.textBuscar2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Producto";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(1213, 212);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(532, 47);
            this.txtPrecioVenta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(911, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio de Venta";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCosto.Location = new System.Drawing.Point(327, 204);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(521, 47);
            this.txtPrecioCosto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio de Costo";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.Location = new System.Drawing.Point(1173, 103);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(576, 47);
            this.txtPresentacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(911, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Presentación";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(232, 95);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(616, 47);
            this.txtProducto.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(47, 383);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1702, 444);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1732, 192);
            this.panel1.TabIndex = 17;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Image = global::Invecam_S_A.Properties.Resources.ic_search_black_30dp;
            this.btnSearch1.Location = new System.Drawing.Point(1699, 39);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(67, 65);
            this.btnSearch1.TabIndex = 19;
            this.btnSearch1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Invecam_S_A.Properties.Resources.ic_update_black_48dp;
            this.btnUpdate.Location = new System.Drawing.Point(123, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 61);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Invecam_S_A.Properties.Resources.ic_fiber_new_black_30dp;
            this.btnNew.Location = new System.Drawing.Point(26, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(73, 61);
            this.btnNew.TabIndex = 18;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Image = global::Invecam_S_A.Properties.Resources.ic_search_black_30dp;
            this.btnSearch2.Location = new System.Drawing.Point(1678, 290);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(67, 65);
            this.btnSearch2.TabIndex = 16;
            this.btnSearch2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Invecam_S_A.Properties.Resources.ic_delete_android30;
            this.btnDelete.Location = new System.Drawing.Point(1690, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 61);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Invecam_S_A.Properties.Resources.ic_cancel_black_30dp;
            this.btnCancel.Location = new System.Drawing.Point(1598, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 61);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Invecam_S_A.Properties.Resources.ic_edit_black_30dp;
            this.btnEdit.Location = new System.Drawing.Point(1511, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 61);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Invecam_S_A.Properties.Resources.ic_save_black_30dp;
            this.btnSave.Location = new System.Drawing.Point(1418, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 61);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 1012);
            this.Controls.Add(this.tabListadoProductos);
            this.MaximumSize = new System.Drawing.Size(1870, 1012);
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tabListadoProductos.ResumeLayout(false);
            this.tabListadoP.ResumeLayout(false);
            this.tabListadoP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabIngresarP.ResumeLayout(false);
            this.tabIngresarP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabListadoProductos;
        private System.Windows.Forms.TabPage tabListadoP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabIngresarP;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBuscar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBuscar1;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
    }
}