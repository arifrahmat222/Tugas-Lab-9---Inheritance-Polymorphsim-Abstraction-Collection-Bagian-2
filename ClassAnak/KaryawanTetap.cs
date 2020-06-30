using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_9.ClassAnak
{
    public class KaryawanTetap : ClassInduk.Karyawan
    {
        public double gajibulanan { get; set; }
        public override double GAJI()
        {
            return gajibulanan;
        }
    }
}

