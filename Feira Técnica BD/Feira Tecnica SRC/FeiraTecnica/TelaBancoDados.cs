﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeiraTecnica
{
    public partial class TelaBancoDados : Form
    {
        public TelaBancoDados(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            Conexao.BuscarRegistrosAtivos("Pessoas", dataGridView1);
        }
    }
}
