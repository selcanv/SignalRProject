using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    //1) publi işaretle
    //2) t değeri alsın ve bu t değeri mutlaka bir class olsun.
    //Böylece dışarıdan buna metot,nesne,değişken vs girmiş olamıcak.
    public interface IGenericDal<T> where T : class
    {
        //ekleme, silme, güncelleme,Listeleme ve id ye göre getirme işlemlerini hazırlıyorum
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);  

        //t türünde olan ismi getbyid olan (id ye göre getir) ve int id ile parametre geçtiğim  metot tanımı
        T GetById(int id);
        //son olarak bir liste tanımlıyorum,
        //bu liste içerisine bir T alacak ismi GetListAll yani bütün hepsini getir metodu tanımladım,
        List<T> GetListAll();   

        //ÖNEMLİ ! 
        //entitye özgü metot olacağını varsayarak, bütün interfacelerim için IGenericDal'dan miras aldırmam gerekiyor
    }
}
