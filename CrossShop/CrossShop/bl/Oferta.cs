using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public class Oferta : ModelDBMaster
    {
        Produto _Prod;
        public Produto Prod
        {
            get { return _Prod; }
            set
            {
                _Prod = value;
                OnPropertyChanged();
            }
        }
        int _QuantidadeDisponivel;
        public int QuantidadeDisponivel
        {
            get
            {
                return _QuantidadeDisponivel;
            }
            set
            {
                _QuantidadeDisponivel = value;
                OnPropertyChanged();
            }
        }
        UnidadesDeMedidas _UM;
        public UnidadesDeMedidas UM
        {
            get
            {
                return _UM;
            }
            set
            {
                _UM = value;
                OnPropertyChanged();
            }
        }
        Fornecedor _Fonec;
        public Fornecedor Fonec
        {
            get
            {
                return _Fonec;
            }
            set
            {
                _Fonec = value;
                OnPropertyChanged();
            }
        }
        double _Preco;
        public double Preco
        {
            get
            {
                return _Preco;
            }
            set
            {
                _Preco = value;
                OnPropertyChanged();
            }
        }

        public DateTime DtValidadeIni
        {
            get; set;
        }
        public DateTime DtValidadeFin                                                                                                         
        {
            get; set;
        }
    }
}
