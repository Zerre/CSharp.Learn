﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYonetim.Lib
{
    public class Asci : Calisan
    {
        public Asci(string i, DateTime g, Kafe k) : base(i, g, k)
        {

        }

        public void SiparisiHazirla(Siparis siparis)
        {
            Siparisler.Add(siparis);

            foreach (var kalem in siparis.Kalemler)
            {
                kalem.Durum = SiparisDurum.Hazirlaniyor;
            }
        }

        public SiparisDurum SiparisHazir()
        {
            Console.WriteLine("Sipariş Hazırlandı.");
            return SiparisDurum.Hazirlandi;
        }

        public void SiparisHazirlandi(Siparis siparis)
        {
            foreach (var kalem in siparis.Kalemler)
            {
                kalem.Durum = SiparisDurum.Hazirlandi;
            }

            siparis.SiparisiAlanGarson.SiparisiServisEt(siparis);
            siparis.SiparisiHazirlayanAsci = null;
        }
    }
}
