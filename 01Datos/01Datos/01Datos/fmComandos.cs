﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Datos
{
    public partial class fmComandos : Form
    {

        DataRowCollection cfilas;
        public fmComandos()
        {
            InitializeComponent();
        }

        private void MostrarPosicion()
        {
            int iTotal = telefonosBindingSource.Count;
            int iPos;

            if(iTotal == 0)
            {
                laPosicion.Text = "0 de 0";
            }
            else
            {
                iPos = telefonosBindingSource.Position + 1;
                laPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
            }
        }

        private void telefonosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefonosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);

        }

        private void fmComandos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_telefonosDataSet.telefonos' Puede moverla o quitarla según sea necesario.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);

        }

        private void btPrimero_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveFirst();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MovePrevious();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveNext();
        }

        private void btUltimo_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveLast();
        }

        private void dgvTelefonos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            la1.Text = Convert.ToString(dgvTelefonos.Rows[e.RowIndex].Cells[1].Value);
            MostrarPosicion();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            DataTable miTabla = bd_telefonosDataSet.telefonos;
            cfilas = miTabla.Rows;
            DataRow Fila;
            Fila = miTabla.Rows[miTabla.Rows.Count - 1];
            int nuevoId = Convert.ToInt32(Fila[0]);
            try
            {
                Fila = miTabla.NewRow();
                Fila[0] = nuevoId;
                cfilas.Add(Fila);
                btUltimo.PerformClick();
                MostrarPosicion();
            } catch(ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
                MessageBox.Show("Origen de datos actualizados");
            }
            catch (Exception errorEncontrado)
            {
                MessageBox.Show("Ha habido un error: ", errorEncontrado.Message);
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DataRowView vistaFilaActual;
            if(MessageBox.Show("¿Desea borrar este registro?", "Buscar" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vistaFilaActual = ((DataRowView)telefonosBindingSource.Current);
                vistaFilaActual.Row.Delete();
                MostrarPosicion();
            }
        }

        private void fmComandos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bd_telefonosDataSet.HasChanges())
                if(MessageBox.Show("¿Desea guardar los cambios realizados?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
                    MessageBox.Show("Origen de datos actualizado");
            }
        }
    }
}
