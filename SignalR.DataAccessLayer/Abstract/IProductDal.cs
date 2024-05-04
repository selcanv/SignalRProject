using SignalR.EntityLayer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        //ürünleri kategori adlarıyla beraber getirmek için entitye özgü metot yazıcam
        List<Product> GetProductsWithCategories();
    }
}
