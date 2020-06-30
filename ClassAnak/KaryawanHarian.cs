using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_9.ClassAnak
{
    public class KaryawanHarian : ClassInduk.Karyawan
    {
        public KaryawanHarian()
        {
        }
        public double upahperjam { get; set; }
        public double jumlahjamkerja { get; set; }
        public override double GAJI()
        {
            return jumlahjamkerja * upahperjam;
        }

        
    }
}

