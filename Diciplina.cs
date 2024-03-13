using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13032024
{
    internal class Diciplina
    {
        private string nome { get ; set; }
        private int id { get; }
        private Professor professor { get; set; }
        private List<int> prerequisitos { get; set; }
        public Diciplina(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
            this.prerequisitos = new List<int>();
        }

        public void addPreRequisito(Diciplina d)
        {
            this.prerequisitos.Add(d.id);
        } 
    }
}
