using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public class Categoria : ModelMaster
    {
        string _Descricao;
        public string Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                _Descricao = value;
                OnPropertyChanged();
            }
        }
    }
}
