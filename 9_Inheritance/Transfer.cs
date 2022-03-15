using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Inheritance
{
    // SOLİD Prensibleri;
    // todo : S => Single Responsibility prensibi araştırınız.. githuba örnek proje ile ekleyiniz..
    // todo : Poliymorphisim (Çok biçimlilik), Soyutlama (Abstract)
    public class Transfer
    {
        public void ParaGonder(OdemeIslemi transfer)
        {
            if (transfer is EftIslemi) // transger'in tii EftIslemi mi???
            {
                EftIslemi eft = (EftIslemi)transfer;
                //EftIslemi eft = transfer as EftIslemi; // transferi (referansı) EftIslemi olarak döndür...
                eft.IslemYap();
            }
            else if (transfer is HavaleIslemi) // transfer Havalemi?
            {
                HavaleIslemi hvl = (HavaleIslemi)transfer;
                hvl.IslemYap();
            }
        }
    }
}
