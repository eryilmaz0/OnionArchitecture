using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Domain.Common
{
    public class EntityBase<TId> 
    {
        public TId Id { get; set; }
        public DateTime Created { get; set; }
        public bool IsActıve { get; set; }


        public EntityBase()
        {
            this.Created = DateTime.Now;
            this.IsActıve = true;
        }
    }
}
