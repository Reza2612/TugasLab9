using System;
using System.Collections.Generic;
using System.Text;
using TugasLab8.ClassInduk;


namespace TugasLab8.ClassAnak
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        
		public double Komisi { get; set; }
        
		public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}