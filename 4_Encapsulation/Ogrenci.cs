using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Encapsulation
{
    // bir sınıf sadece internal veya public tanımlanabilir.. (NOT : bundan sonra bütün sınıflarımızı public olarak kullanacaz).
    // Sınıfların default erişim seviyeleri internaldır.
    // üyelerin default erişim seviyeleride privatedir..
   internal class Ogrenci
    {
        // private üyeler sınıf scope'ları dışından erişilemez...
        internal string ad;
        // kapsüllenecek üye sınıf dışına kapatılır. bir üyenin sınıf dışına kapatılması için erişim seviyesi private olmalıdır..
        private int yas;
        // eğer kapsüllenen alana değer dışarıdan atanacaksa setter metot yazılır...Setter metotlar üyelere değer atamak için kullanılır. Kapsüllenen üyenin değeri Getteer metot ile dışarıya açılır...
        internal void SetYas(int _yas)
        {
            if (_yas >= 18)
            {
                yas = _yas;
            }
            else
            {
                yas = 18;
            }
        }

        internal int GetYas()
        {
            return yas;
        }
        // not: üyelerin default erişim seviyesi private'dir..
        string adres;
    }

    /*
            access modifiers (erişim belirticiler) => proje içierisindeki objelerimizin erişim seviyesini belirlemek için kullanılır. 
            private     => (class üyeleri için kullanılır..sadece class scoperleriı içieriisnden erişilebilir)
            protected   => (class üyeleri için kullanılır. sadece class ve classtan türeyecen üyeler için kullanılır (inheritance konusunda değinilecek..))
            internal    =>  her için için kullanılır. Sadece proje içerisinden erişilebilir..
            protected internal => protected ve internal karışımıdır..
            public      => heryerden erişmek için kullanılır...
        
     */
}