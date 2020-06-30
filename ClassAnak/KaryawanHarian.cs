using System;
using System.Collections.Generic;
using System.Text;
using TugasLab8.ClassInduk;


namespace TugasLab8.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double JumlahJamKerja { get; set; }
        
		ublic double UpahPerJam { get; set; }
        
		public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}	