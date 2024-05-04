using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        //1)implement interface dersem  IGenericDal'daki hata gider
        //2) bizim bir tane contextimi vardı SignalRContext
        //_context adında bir nesne örneği oluşturdum
        //classta generate contractır diyerek yapıcı metodumu geçtim
        //yapıcı metot geçmek bana neyin kolaylık sağlar? Dependency injection kolaylıkla uygulamamı sağlar
        //Dependency injection neyi sağlayacak? bağımlılıklarımı azaltmamı sağlayacak
        //bu bağımşlılık şöyle; şuanda bu proje entity frameworkte geliştiriyoruz ve
        //crud işlemlerindeki interfaceler üzerinde sadece metotlarımızı yazdık
        //yarın deppera ya da farklı bir orm aracına geçtiğimizde geçişler kolay olacak
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();

        }
    }
}
