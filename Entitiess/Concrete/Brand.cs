using Entitiess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Concrete
{
    public class Brand : IEntitiess
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
