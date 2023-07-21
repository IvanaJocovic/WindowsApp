using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class KlijentBusiness
    {
        readonly KlijentRepository klijentRepository = new KlijentRepository();
        public List<Klijenti> GetAllKlijenti()
        {

            return klijentRepository.GetAllKlijenti();

        }
        public bool InsertKlijent(Klijenti k)
        {
            return klijentRepository.InsertKlijent(k) != 0;
        }
    }
}
