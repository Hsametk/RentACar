using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
         IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Colors color)
        {
            if (color.Name.Length <= 2)
                Console.WriteLine("Boyle bir renk yok");
            else 
                _colorDal.Add(color);
        }

        public void Delete(Colors color)
        {
            _colorDal.Delete(color);
        }

        public List<Colors> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Colors GetById(int colorId)
        {
            return _colorDal.Get(c => c.Id == colorId);
        }

        public void Update(Colors color)
        {
           _colorDal.Update(color);
        }
    }
}
