using PEPExtensions;
using PEPlugin.Pmx;
using System;
using System.Drawing;
using System.Linq;

namespace CreateMaskImage
{
    internal class MaskMaker
    {
        public Size MaskImageSize
        {
            get;
            set;
        }

        private PixelDrawer.PixelDrawer Drawer { get; }

        public MaskMaker(Size maskImageSize)
        {
            MaskImageSize = maskImageSize;
            Drawer = new PixelDrawer.PixelDrawer(MaskImageSize.Width - 1, MaskImageSize.Height - 1);
        }

        public MaskMaker(int width, int height) : this(new Size(width, height)) { }
        public MaskMaker() : this(new Size(1024, 1024)) { }

        public Bitmap DrawMask(IPXMaterial material, float startPosition, float endPosition, Color baseColor, Color maskColor)
        {
            var upper = Math.Max(startPosition, endPosition);
            var lower = Math.Min(startPosition, endPosition);

            var upperColor = startPosition < endPosition ? maskColor : baseColor;
            var lowerColor = startPosition < endPosition ? baseColor : maskColor;

            var getColor = startPosition == endPosition ? (Func<IPXVertex, Color>)binaryColor : gradientColor;

            foreach (var face in material.Faces)
            {
                Drawer.FillPolygon(
                    face.ToVertices().Select(vtx => getColor(vtx)).ToArray(),
                    face.ToVertices().Select(vtx => vtx.UV).ToArray()
                );
            }

            return Drawer.Canvas;

            Color binaryColor(IPXVertex vertex) => GetPosition(vertex) < startPosition ? lowerColor : upperColor;
            Color gradientColor(IPXVertex vertex)
            {
                var step = Saturate((GetPosition(vertex) - lower) / (upper - lower));

                return Color.FromArgb(
                    ByteNum(Lerp(lowerColor.R, upperColor.R, step)),
                    ByteNum(Lerp(lowerColor.G, upperColor.G, step)),
                    ByteNum(Lerp(lowerColor.B, upperColor.B, step)));
            }
        }

        // 座標軸を増やすときはここを改修する
        private float GetPosition(IPXVertex vertex) => vertex.Position.Y;

        private float Lerp(float a, float b, float t) => a + (b - a) * t;
        private float Saturate(float value) => Math.Min(Math.Max(0, value), 1);
        private int ByteNum(float ratio) => (int)Math.Round(255 * ratio, MidpointRounding.AwayFromZero);
    }
}
