using MostarGuide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public interface IPreporukaService
    {
        List<Sekcije> GetPreporuka(int id);

    }
}
