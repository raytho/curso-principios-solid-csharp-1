using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion.Models
{
    public interface ILogbook
    {
        void Add(string description);
    }
}