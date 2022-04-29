using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnketHazirlamaPortali.ViewModel
{
    public class CevapModel
    {
        public int CevapId { get; set; }
        public Nullable<int> KullaniciCevapId { get; set; }
        public Nullable<int> SecilenCevapId { get; set; }

    }
}