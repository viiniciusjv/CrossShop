using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public class Produto : ModelDBMaster
    {
        string _Descricao;
        public string Descricao
        {
            get; set;
        }

        Categoria _Cat;
        public Categoria Cat
        {
            get
            {
                return _Cat;
            }
            set
            {
                _Cat = value;
                OnPropertyChanged();
            }
        }

        double _PrecoNominal;
        public double PrecoNominal
        {
            get
            {
                return _PrecoNominal;
            }
            set
            {
                _PrecoNominal = value;
                OnPropertyChanged();
            }
        }
    }
}
