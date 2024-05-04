using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    //1) public olarak etiketlememi yaptım
    //2) sen GenericRepository den miras al. Kim için alacaksın About sınıfı için alacaksın
    //3) ,
    //4) bir de aynı zamanda IAboutDal dan da miras al. Sebebi şu: yarın öbür gün abouta özgü entityler gelebilir, o zaman devreye girecek 
    //ctrl + . -> generate constructor
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(SignalRContext context) : base(context)
        {
        }
    }
}
