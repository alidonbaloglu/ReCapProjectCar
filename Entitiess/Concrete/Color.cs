using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Concrete
{
    public class Color : IEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}
