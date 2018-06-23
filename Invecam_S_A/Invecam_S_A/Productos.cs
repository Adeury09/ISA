using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invecam_S_A
{
    public partial class Productos : MetroFramework.Forms.MetroForm
    {
        Almacenes_DB2Entities entidad = new Almacenes_DB2Entities();
        Boolean editando;

        //Metodo para borrar campos
        public void limpiar()
        {
            txtProducto.Clear();
            txtPresentacion.Clear();
            txtPrecioCosto.Clear();
            txtPrecioVenta.Clear();
            txtCatidad.Clear();
            txtCantdadPMenor.Clear();
            txtCantidadPMayor.Clear();
            txtPMenor.Clear();
            txtPMayor.Clear();
        }

        public void queryDefault()
        {
            dataGridView1.DataSource = dataGridView2.DataSource = (from p in entidad.Products1
                                                                   where p.stateID == 1
                                        orderby p.productName
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_X_Mayor = p.wholeQuantity,
                                            Precio_al_X_Mayor = p.wholeSalePrice,
                                            Cantidad_X_Menor = p.retailQuantity,
                                            Precio_al_X_Menor = p.retailSalePrice
                                        }).ToList();
        }

        public Productos()
        {
            InitializeComponent();
        }
        
        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'almacenes_DB2DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.almacenes_DB2DataSet.Products);
            panel1.Enabled = false;
            editando = false;
            this.queryDefault();
            //dataGridView1.DataSource = dataGridView2.DataSource;

            /*
            productsBindingSource.DataSource = entidad.Products.ToList();
            dataGridView2.DataSource = dataGridView1.DataSource = (from p in entidad.Products
                                       orderby p.productName
                                        select p).ToList();
            */
        } 

        private void tabListadoP_Click(object sender, EventArgs e)
        {
            this.queryDefault();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                txtProducto.Focus();
                this.limpiar();
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //productsBindingSource.EndEdit();
                panel1.Enabled = false;
                Products product;

                if (editando)
                {
                    String celda = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString();

                    var query = (from p in entidad.Products1
                                 where p.productName == celda
                                 select p).FirstOrDefault();
                    //buscar exprecion lanta para que en casos de se null
                    query.stateID = 2;
                    product = new Products
                    {
                        productName = (txtProducto.Text == "") ? query.productName : txtProducto.Text,
                        productPresentation = (txtPresentacion.Text == "") ? query.productPresentation : txtPresentacion.Text,
                        salePrice = (txtPrecioVenta.Text == "") ? query.salePrice : float.Parse(txtPrecioVenta.Text),
                        costPrice = (txtPrecioCosto.Text == "") ? query.costPrice : float.Parse(txtPrecioCosto.Text),
                        unitInStop = (txtCatidad.Text == "") ? query.unitInStop : int.Parse(txtCatidad.Text),
                        wholeSalePrice = (txtPMayor.Text == "") ? query.wholeSalePrice : float.Parse(txtPMayor.Text),
                        wholeQuantity = (txtCantidadPMayor.Text == "") ? query.wholeQuantity : int.Parse(txtCantidadPMayor.Text),
                        retailSalePrice = (txtPMenor.Text == "") ? query.retailSalePrice : float.Parse(txtPMenor.Text),
                        retailQuantity = (txtCantdadPMenor.Text == "") ? query.retailQuantity : int.Parse(txtCantdadPMenor.Text),
                        stateID = 1
                        
                    };

                 

                    editando = false;
                }
                else
                {
                    product = new Products
                    { //poner en caso de se "" null
                        productName = (txtProducto.Text != "")? txtProducto.Text : null,
                        productPresentation = (txtPresentacion.Text != "")? txtPresentacion.Text:null,
                        salePrice = (txtPrecioVenta.Text != "") ? float.Parse(txtPrecioVenta.Text) : 0.0,
                        costPrice = (txtPrecioCosto.Text != "") ?float.Parse(txtPrecioCosto.Text) :0.0,
                        unitInStop = (txtCatidad.Text != "")? int.Parse(txtCatidad.Text):0,
                        wholeSalePrice = (txtPMayor.Text != "")? float.Parse(txtPMayor.Text):0.0,
                        wholeQuantity = (txtCantidadPMayor.Text != "") ? int.Parse(txtCantidadPMayor.Text) : 0,
                        retailSalePrice = (txtPMenor.Text != "")? float.Parse(txtPMenor.Text):0.0,
                        retailQuantity = (txtCantdadPMenor.Text != "")? int.Parse(txtCantdadPMenor.Text):0,
                        stateID = 1
                    };

                    
                    
                }
                entidad.Products1.Add(product);
                entidad.SaveChanges();
                this.limpiar();
                this.queryDefault();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editando = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.queryDefault();
            

           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string celda = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString();

            if (MessageBox.Show("¿Estas seguro que quieres eliminar el producto "+celda+"?", "Mensaje de confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                

                var query = (from p in entidad.Products1
                             where p.productName.Contains(celda)
                             select p).FirstOrDefault();
                entidad.Products1.Remove(query);
                entidad.SaveChanges();

                this.queryDefault();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            this.limpiar();
            txtProducto.Focus();
            editando = true;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            productsBindingSource.ResetBindings(false);

            foreach(DbEntityEntry entry in entidad.ChangeTracker.Entries())
            {
                switch (entry.State) {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;

                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;

                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }

            }
            this.limpiar();
            this.queryDefault();
        }

        private void btnReload1_Click(object sender, EventArgs e)
        {
            this.queryDefault();
        }

        private void tabIngresarP_Click(object sender, EventArgs e)
        {
            this.queryDefault();
        }

        private void textBuscar2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBuscar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBuscar2.Text))
                {
                    MessageBox.Show("No se ingreso ningun registro", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.queryDefault();
                }
                else
                {
                    dataGridView2.DataSource = (from p in entidad.Products1
                                                where  p.stateID==1 && p.productName.Contains(textBuscar2.Text) || p.productPresentation.Contains(textBuscar2.Text) 
                                                orderby p.productName
                                                select new
                                                {
                                                    Productos = p.productName,
                                                    Presentacion = p.productPresentation,
                                                    Precio_de_costo = p.costPrice,
                                                    Precio_de_venta = p.salePrice,
                                                    Cantidad = p.unitInStop,
                                                    Cantidad_Por_Mayor = p.wholeQuantity,
                                                    Precio_al_por_Mayor = p.wholeSalePrice,
                                                    Cantidad_por_Menor = p.retailQuantity,
                                                    Precio_al_por_Menor = p.retailSalePrice
                                                }).ToList();
                }
            }
        }

        private void textBuscar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscar2.Text))
            {
                MessageBox.Show("No se ingreso ningun registro", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.queryDefault();
            }
            else
            {
                dataGridView2.DataSource = (from p in entidad.Products1
                                            where p.stateID == 1 && p.productName.Contains(textBuscar2.Text) || p.productPresentation.Contains(textBuscar2.Text)
                                            orderby p.productName
                                            select new
                                            {
                                                Productos = p.productName,
                                                Presentacion = p.productPresentation,
                                                Precio_de_costo = p.costPrice,
                                                Precio_de_venta = p.salePrice,
                                                Cantidad = p.unitInStop,
                                                Cantidad_Por_Mayor = p.wholeQuantity,
                                                Precio_al_por_Mayor = p.wholeSalePrice,
                                                Cantidad_por_Menor = p.retailQuantity,
                                                Precio_al_por_Menor = p.retailSalePrice
                                            }).ToList();
            }
        }

        private void textBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBuscar1.Text))
                {
                    MessageBox.Show("No se ingreso ningun registro", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.queryDefault();
                }
                else
                {
                    dataGridView2.DataSource = (from p in entidad.Products1
                                                where p.stateID == 1 && p.productName.Contains(textBuscar1.Text.Trim()) || p.productPresentation.Contains(textBuscar1.Text.Trim())
                                                orderby p.productName
                                                select new
                                                {
                                                    Productos = p.productName,
                                                    Presentacion = p.productPresentation,
                                                    Precio_de_costo = p.costPrice,
                                                    Precio_de_venta = p.salePrice,
                                                    Cantidad = p.unitInStop,
                                                    Cantidad_Por_Mayor = p.wholeQuantity,
                                                    Precio_al_por_Mayor = p.wholeSalePrice,
                                                    Cantidad_por_Menor = p.retailQuantity,
                                                    Precio_al_por_Menor = p.retailSalePrice
                                                }).ToList();
                }
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscar1.Text))
            {
                MessageBox.Show("No se ingreso ningun registro", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.queryDefault();

            }
            else
            {
                dataGridView2.DataSource = (from p in entidad.Products1
                                            where p.stateID == 1 && p.productName.Contains(textBuscar1.Text.Trim()) || p.productPresentation.Contains(textBuscar1.Text.Trim())
                                            orderby p.productName
                                            select new
                                            {
                                                Productos = p.productName,
                                                Presentacion = p.productPresentation,
                                                Precio_de_costo = p.costPrice,
                                                Precio_de_venta = p.salePrice,
                                                Cantidad = p.unitInStop,
                                                Cantidad_Por_Mayor = p.wholeQuantity,
                                                Precio_al_por_Mayor = p.wholeSalePrice,
                                                Cantidad_por_Menor = p.retailQuantity,
                                                Precio_al_por_Menor = p.retailSalePrice
                                            }).ToList();
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdIngreso_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.productID
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdNombre_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.productID
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdPresentacion_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.productPresentation
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdPCosto_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.costPrice
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdPVenta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.salePrice
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdCantidad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.unitInStop
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdPMayor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.wholeSalePrice
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdPMenor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.retailSalePrice
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdCMayor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.wholeQuantity
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }

        private void btnOrdCMenor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in entidad.Products1
                                        where p.stateID == 1
                                        orderby p.retailQuantity
                                        select new
                                        {
                                            Productos = p.productName,
                                            Presentacion = p.productPresentation,
                                            Precio_de_costo = p.costPrice,
                                            Precio_de_venta = p.salePrice,
                                            Cantidad = p.unitInStop,
                                            Cantidad_Por_Mayor = p.wholeQuantity,
                                            Precio_al_por_Mayor = p.wholeSalePrice,
                                            Cantidad_por_Menor = p.retailQuantity,
                                            Precio_al_por_Menor = p.retailSalePrice
                                        }).ToList();
        }
    }
}
