using PEPExtensions;
using PEPlugin.Pmx;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
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


        public MaskMaker(Size maskImageSize)
        {
            MaskImageSize = maskImageSize;
        }

        public MaskMaker(int width, int height) : this(new Size(width, height)) { }
        public MaskMaker() : this(new Size(1024, 1024)) { }

        public Image<Rgba32> DrawMask(IPXMaterial material, float startPosition, float endPosition, Rgba32 baseColor, Rgba32 maskColor)
        {
            var upper = Math.Max(startPosition, endPosition);
            var lower = Math.Min(startPosition, endPosition);

            var upperColor = startPosition < endPosition ? maskColor : baseColor;
            var lowerColor = startPosition < endPosition ? baseColor : maskColor;

            var getColor = startPosition == endPosition ? (Func<float, Rgba32>)binaryColor : gradientColor;

            var image = new Image<Rgba32>(MaskImageSize.Width, MaskImageSize.Height, baseColor);

            foreach (var face in material.Faces)
            {
                var vertices = face.ToVertices();

                var xMin = vertices.Select(vtx => vtx.UV.X).Min();
                var xMax = vertices.Select(vtx => vtx.UV.X).Max();
                var xCenter = (xMin + xMax) / 2;

                var yMin = vertices.Select(vtx => vtx.UV.Y).Min();
                var yMax = vertices.Select(vtx => vtx.UV.Y).Max();

                var yMaxTexPos = yMax * (MaskImageSize.Height - 1);
                var yMinTexPos = yMin * (MaskImageSize.Height - 1);

                var maxPos = vertices.Select(vtx => vtx.Position.Y).Max();
                var minPos = vertices.Select(vtx => vtx.Position.Y).Min();

                var brush = new LinearGradientBrush(
                    new PointF(xCenter, yMaxTexPos),
                    new PointF(xCenter, yMinTexPos),
                    GradientRepetitionMode.None,
                    new ColorStop(1, getColor(minPos)),
                    new ColorStop(0, getColor(maxPos))
                );

                image.Mutate(context => context.FillPolygon(brush, vertices.Select(GetTexPos).ToArray()));
            }

            return image;

            Rgba32 binaryColor(float pos) => pos < startPosition ? lowerColor : upperColor;
            Rgba32 gradientColor(float pos)
            {
                var step = Saturate((pos - lower) / (upper - lower));

                return new Rgba32(
                    ByteNum(Lerp(lowerColor.R, upperColor.R, step)),
                    ByteNum(Lerp(lowerColor.G, upperColor.G, step)),
                    ByteNum(Lerp(lowerColor.B, upperColor.B, step)));
            }
        }

        private float Lerp(float a, float b, float t) => a + (b - a) * t;
        private float Saturate(float value) => Math.Min(Math.Max(0, value), 1);
        private int ByteNum(float ratio) => (int)Math.Round(255 * ratio, MidpointRounding.AwayFromZero);
        private PointF GetTexPos(IPXVertex vertex) => new PointF(vertex.UV.X * (MaskImageSize.Width - 1), vertex.UV.Y * (MaskImageSize.Height - 1));
    }
}
