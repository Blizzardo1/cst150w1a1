using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Milestone
{
    public static class Extensions
    {
        /// <summary>
        /// Converts
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this Image image)
        {
            MemoryStream ms = new();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        /// <summary>
        /// Converts a sequence of bytes to an image
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static Image FromBytes (this byte[] bytes)
        {
            MemoryStream ms = new(bytes);
            return Image.FromStream(ms);
        }
    }
}
