using System;
using System.Collections.Generic;
using System.Linq;


namespace Sarkicilar
{
    public  class Sarkicilar
    {

        
            public string AdSoyad { get; set; }
            public string MuzikTuru { get; set; }
            public int CikisYili { get; set; }
            public int AlbumSatislari { get; set; } // Milyon olarak tutalım

            public Sarkici(string adSoyad, string muzikTuru, int cikisYili, int albumSatislari)
            {
                AdSoyad = adSoyad;
                MuzikTuru = muzikTuru;
                CikisYili = cikisYili;
                AlbumSatislari = albumSatislari;
            }
        


    }
}
