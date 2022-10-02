using PEPExtensions;
using PEPlugin;
using PEPlugin.Pmx;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Color = System.Drawing.Color;

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

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "PNGファイル(*.png)|*.png",
            };

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using(var mask = MaskMaker.DrawMask(
                    listBoxMaterials.SelectedItem as IPXMaterial,
                    (float)numericGradientStartPosition.Value,
                    (float)numericGradientEndPosition.Value,
                    Convert(panelBaseColor.BackColor),
                    Convert(panelMaskColor.BackColor)))
                {
                    mask.SaveAsPng(sfd.FileName);
                }
            }
        }

        private void SelectPanelColor(object sender, EventArgs e)
        {
            var panel = (sender as Panel);
            if(panel is null) { return; }

            var cd = new ColorDialog()
            {
                Color = panel.BackColor
            };

            if(cd.ShowDialog() == DialogResult.OK)
            {
                panel.BackColor = cd.Color;
            }
        }

        private Rgba32 Convert(Color color) => new Rgba32(color.R, color.G, color.B);
    }
}
