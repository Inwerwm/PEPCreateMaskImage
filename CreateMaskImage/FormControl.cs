﻿using PEPExtensions;
using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CreateMaskImage
{
    public partial class FormControl : Form
    {
        IPERunArgs Args { get; }
        IPXPmx Pmx { get; set; }

        MaskMaker MaskMaker { get; }

        public FormControl(IPERunArgs args)
        {
            Args = args;
            MaskMaker = new MaskMaker();

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
