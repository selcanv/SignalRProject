using SignalR.EntityLayer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    //1) IABoutDal isimli interface ekledim
    //2) public olarak etiketledim
    //3) : sen dicem IGenericDal'dan miras al <Kim için miras alacağını verdim>
    //Böylece artık özellikle About'a özgü bir durum oluşursa; gelip onu buranın içerisinde tanımlayabilirim
    //entitye özgü metot içeriği olarak kullanılacak, ama başka yerlerde de kullanılacak
    public interface IAboutDal:IGenericDal<About>
    {
    }
}
