using appHeroeMVC.AccesoDatos;
using appHeroeMVC.Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHeroeMVC.LogicaNegocio
{
    public class HeroeBO
    {
        public List<Heroe> getListaHeroes()
        {

            HeroeDAO oHeroeDAO = new HeroeDAO();
            return oHeroeDAO.getListaHeroes();
        }
    }
}
