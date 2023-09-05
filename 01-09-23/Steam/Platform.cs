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
        private List<Application> applications;
        private List<User> usuarios;

        public Platform(string name, List<Application> applications, List<User> usuarios)
        {
            this.name = name;
            this.applications = applications;
            this.usuarios = usuarios;
        }

        public Platform() { }
    }
}
