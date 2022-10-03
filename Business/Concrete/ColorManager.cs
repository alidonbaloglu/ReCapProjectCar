using Business.Abstract;
using DataAccess.Abstract;
using Entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            if (color.Name.Length >= 2)
            {
                _colorDal.Add(color);
            }
            else
            {
                Console.WriteLine("Renk ismi En Az iki karakter olmalı");
            }
            
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(p => p.Id == id);
            
        }
    }
}
