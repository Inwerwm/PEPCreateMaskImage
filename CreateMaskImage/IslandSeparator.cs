using PEPExtensions;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateMaskImage
{
    internal static class IslandSeparator
    {/*
        public static IEnumerable<IEnumerable<IPXFace>> Separate(IEnumerable<IPXFace> faces)
        {
            
        }

        private IEnumerable<IPXFace> FindIsland(IPXFace face, IEnumerable<IPXFace> faces)
        {
            var current = new FaceInfo(face);
            current.Token = IslandToken.Publish();

        }

        private class FaceInfo
        {
            public IPXFace Face { get; }
            public IslandToken Token { get; set; }

            public FaceInfo(IPXFace face)
            {
                Face = face;
            }

            public bool IsSameIsland(IPXFace other) => Face.ToVertices().Any(vtx => other.ToVertices().Contains(vtx));
        }

        private struct IslandToken
        {
            private static uint _count = 0;
            public static IslandToken Zero => new IslandToken(0);
            public static IslandToken Publish() => new IslandToken(++_count);


            public uint ID { get; }

            private IslandToken(uint id)
            {
                ID = id;
            }

        }*/
    }
}
