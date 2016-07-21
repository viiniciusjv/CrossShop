using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public class UnidadesDeMedidas : ModelMaster
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
