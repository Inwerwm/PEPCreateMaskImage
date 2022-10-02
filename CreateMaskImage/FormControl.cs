﻿using PEPExtensions;
using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateMaskImage
{
    public partial class FormControl : Form
    {
        IPERunArgs Args { get; }
        IPXPmx Pmx { get; set; }

        public FormControl(IPERunArgs args)
        {
            Args = args;

            InitializeComponent();
            Reload();
        }

        internal void Reload()
        {
            Pmx = Args.Host.Connector.Pmx.GetCurrentState();

            listBoxMaterials.Items.Clear();
            listBoxMaterials.Items.AddRange(Pmx.Material.ToArray());
        }

        private void FormControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
