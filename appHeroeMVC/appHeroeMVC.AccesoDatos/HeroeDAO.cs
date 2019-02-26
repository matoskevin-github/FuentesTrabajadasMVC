using appHeroeMVC.Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHeroeMVC.AccesoDatos
{
    public class HeroeDAO
    {

        public List<Heroe> getListaHeroes()
        {

            Heroe_JEBEntities oHeroe_JEBEntities = new Heroe_JEBEntities();
            return oHeroe_JEBEntities.Heroe.ToList();
        }
    }
}
