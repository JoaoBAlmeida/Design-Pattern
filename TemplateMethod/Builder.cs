using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Builder : BuilderDAO
    {
        private Material matter { get; set; }

        public Builder(Material matter)
        {
            this.matter = matter;
        }
        protected override string ShowMaterial()
        {
            return matter.material;
        }
    }
}
