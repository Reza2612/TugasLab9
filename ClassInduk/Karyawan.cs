using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TugasLab8.ClassInduk
{
    abstract class Karyawan
    {
        public string Nama { get; set; }
        
		public string NIK { get; set; }
        
		public abstract double Gaji();
    }
}
