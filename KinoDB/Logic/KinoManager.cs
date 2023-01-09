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
            return this;
        }

        public KinoManager UpdateKino(KinoModel kinoModel)
        {
            return this;
        }

        public KinoManager ChangeKino(int id, string newTitle)
        {
            return this;
        }

        public KinoManager GetKino(int id)
        {
            return null;
        }

        public List<KinoModel> GetKinos()
        {
            return null;
        }
    }
}
