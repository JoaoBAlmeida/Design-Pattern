using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class BuilderDAO
    {
        private void BuildFoundation()
        {
            var material = ShowMaterial();
            Console.WriteLine("Construindo fundação de " + material);
            return;
        }

        private void BuildPillars()
        {
            var material = ShowMaterial();
            Console.WriteLine("Construindo pilares de " + material);
            return;
        }

        private void BuildWalls()
        {
            var material = ShowMaterial();
            Console.WriteLine("Construindo paredes de " + material);
            return;
        }

        private void BuildRoof()
        {
            var material = ShowMaterial();
            Console.WriteLine("Construindo telhados de " + material);
            return;
        }

        public void Construct()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildRoof();
        }

        protected abstract string ShowMaterial();
    }
}
