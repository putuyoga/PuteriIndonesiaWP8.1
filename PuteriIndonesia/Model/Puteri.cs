using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuteriIndonesia.Model
{
    public class Puteri
    {
        /// <summary>
        /// Identifier untuk gambar
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Berisi nama lengkap
        /// </summary>
        public string Nama { get; set; }

        /// <summary>
        /// Tahun kapan menjadi puteri Indonesia
        /// </summary>
        public int Tahun { get; set; }

        /// <summary>
        /// Asal daerah provinsi puteri Indonesia
        /// </summary>
        public string Asal { get; set; }

        /// <summary>
        /// Biografi singkat sang puteri Indonesia
        /// </summary>
        public string Biografi { get; set; }

        /// <summary>
        /// Lokasi foto
        /// </summary>
        public string Foto
        {
            get { return "/Assets/Foto/" + Id + ".jpg"; }
        }
    }
}
