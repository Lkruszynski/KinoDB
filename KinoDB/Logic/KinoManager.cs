using KinoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoDB.Logic
{
    public class KinoManager
    {
        public KinoManager AddKino(KinoModel kinoModel)
        {
           
            using(var context = new KinoContext())
            {
                context.Kinos.Add(kinoModel);
                try
                {
                    context.SaveChanges();
                }
                catch (System.Exception)
                {
                    kinoModel.ID = 0;
                    context.Kinos.Add(kinoModel);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public KinoManager RemoveKino(int id)
        {
            using (var context = new KinoContext())
            {
                var kinoToDelete = context.Kinos.SingleOrDefault(x => x.ID == id);
                context.Kinos.Remove(kinoToDelete);
                context.SaveChanges();
            }
                
            return this;
        }

        public KinoManager UpdateKino(KinoModel kinoModel)
        {
            using (var context = new KinoContext())
            {
                context.Kinos.Update(kinoModel);
                context.SaveChanges();
            }
            return this;
        }

        

        public KinoModel GetKino(int id)
        {
            using (var context = new KinoContext())
            {               
                return context.Kinos.Single(x => x.ID == id);                              
            }
        }

        public List<KinoModel> GetKinos()
        {
            using (var context = new KinoContext())
            {
                var kinoList = context.Kinos.ToList();
                return kinoList;
            }           
        }
        public virtual List<KinoModel> GetKinosBy(string miejscowosc)
        {
            using (var context = new KinoContext())
            {

                return context.Kinos.Where(x => x.Name.Contains(miejscowosc)).ToList();
            }
        }
    }
}
