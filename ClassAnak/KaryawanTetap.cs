using System;
using System.Collections.Generic;
using System.Text;
using TugasLab8.ClassInduk;


namespace TugasLab8.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        
		public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}