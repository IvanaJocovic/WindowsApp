using DataLayer.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VrstaBusiness
    {
        readonly VrstaRepository vrstaRepository = new VrstaRepository();
        public List<Vrste> GetAllVrste()
        {

            return vrstaRepository.GetAllVrste();

        }
    }
}
