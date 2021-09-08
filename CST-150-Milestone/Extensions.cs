using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace CST_150_Milestone
{
    public static class Extensions
    {
        private static readonly Encoding Encoding = Encoding.UTF8;

        public static bool IsEmpty(this string s) => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);

        public static bool PropertyExists(this Type t, string path)
        {
            if (string.IsNullOrEmpty(path))
                return false;

            string[] pp = path.Split('.');

            foreach (var prop in pp)
            {
                if (int.TryParse(prop, out int result))
                {
                    /* skip array accessors */
                    continue;
                }

                PropertyInfo? propInfo = t.GetMember(prop)
                                          .Where(p => p is PropertyInfo)
                                          .Cast<PropertyInfo>()
                                          .FirstOrDefault();

                if (propInfo != null)
                {
                    t = propInfo.PropertyType;

                    if (t.GetInterfaces().Contains(typeof(IEnumerable)) && t != typeof(string))
                    {
                        t = (t.IsGenericType
                            ? t.GetGenericArguments()[0]
                            : t.GetElementType())!;

                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static string ToHexString(this byte[] b) => BitConverter.ToString(b).Replace("-", "").ToLower();


        public static Dictionary<string, object> ToDictionary(this Student student) => new()
        {
            {"name", $"\"{student.Name}\""},
            {"birthdate", student.BirthDate.ToBinary()},
            { "emailaddress", $"\'{student.EmailAddress}\'" },
            {"studentid", student.StudentId.Id},
            { "birthplace", $"\'{student.BirthPlace}\'" },
            {"gradepointaverage", student.GradePointAverage},
            { "profilepicture", $"\'{Convert.ToBase64String(student.ProfilePicture)}\'" },
            { "notes", $"\'{student.Notes}\'" }
        };

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
