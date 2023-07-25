using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Colors> GetAll();
        Colors GetById(int colorId);
        void Add(Colors color);
        void Update(Colors color);
        void Delete(Colors color);
    }
}
