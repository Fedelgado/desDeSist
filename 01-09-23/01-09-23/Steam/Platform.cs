using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    internal class Platform
    {
        private string name;
        private List<Aplicacion> aplications;
        private List<User> usuarios;

        public Platform(string name, List<Aplicacion> aplications, List<User> usuarios)
        {
            this.name = name;
            this.aplications = aplications;
            this.usuarios = usuarios;
        }

        public Platform() { }
    }
}
