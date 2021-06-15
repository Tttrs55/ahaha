using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFdemo
{
    public class DB
    {
        public static hopheyEntities db =new hopheyEntities();

        static public List<Service> GetServices()
        {
            db.Service.Load();
            var serviceload = db.Service.ToList();
            return serviceload.ToList();
        }
        static public List<Client> GetClient()
        {
            db.Client.Load();
            var serviceload = db.Client.ToList();
            return serviceload.ToList();
        }
        static public List<Gender> GetGender()
        {
            db.Gender.Load();
            var serviceload = db.Gender.ToList();
            return serviceload.ToList();
        }
        static public void AddClient (Client client)
        {
            db.Client.Add(client);
            db.SaveChanges();
        }
    }
}
