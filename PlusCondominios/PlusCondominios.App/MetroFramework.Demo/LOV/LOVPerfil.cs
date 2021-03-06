﻿using MetroFramework.Forms;
using PlusCondominios.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetroFramework.Demo.LOV
{
    public partial class LOVPerfil : MetroForm
    {
        public LOVPerfil()
        {
            InitializeComponent();
        }

        private void LOVPerfil_Load(object sender, EventArgs e)
        {
            PerfilBll Perfil = new PerfilBll();

            var lst = Perfil.ListarTodos();
            GridPerfis.DataSource = null;
            GridPerfis.DataSource = lst;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            PerfilBll Perfil = new PerfilBll();

            var lst = Perfil.ListarPerfilPorNome(txtDescricao.Text);

            GridPerfis.DataSource = null;
            GridPerfis.DataSource = lst;

        }

        private void GridPerfis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tag = GridPerfis.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
