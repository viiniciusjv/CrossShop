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
                OnPropertyChanged("DescricaoProduto");
                OnPropertyChanged("Desconto");
                OnPropertyChanged("PrecoReferencia");
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
                OnPropertyChanged("Desconto");
            }
        }

        DateTime _DtValidadeIni;
        public DateTime DtValidadeIni
        {
            get
            {
                return _DtValidadeIni;
            }
            set
            {
                _DtValidadeIni = value;
                OnPropertyChanged();
            }
        }
        DateTime _DtValidadeFin;
        public DateTime DtValidadeFin
        {
            get
            {
                return _DtValidadeFin;
            }
            set
            {
                _DtValidadeFin = value;
                OnPropertyChanged();
            }
        }


        public string DescricaoProduto
        {
            get
            {
                return _Prod != null ? _Prod.Descricao : string.Empty;
            }
        }
        public double PrecoReferencia
        {
            get
            {
                return _Prod != null ? _Prod.PrecoNominal : 0;
            }
        }

        public double Desconto
        {
            get { return ((PrecoReferencia - Preco) / PrecoReferencia) * 100; }
        }
        public string DescontoExib
        {
            get
            {
                return " (-" + ((int)Math.Ceiling(Desconto)).ToString() + "%)";
            }
        }

        public bool ExibirRestam
        {
            get
            {
                return QuantidadeDisponivel < 10;
            }
        }

        public string IntervalorValidadeExib
        {
            get
            {
                if (DtValidadeIni != DtValidadeFin)
                    return "Validade: " + ((int)Math.Floor(DtValidadeIni.Subtract(DateTime.Now).TotalDays)).ToString() + " a " + ((int)Math.Floor(DtValidadeFin.Subtract(DateTime.Now).TotalDays)).ToString() + " dias";
                else if (Math.Floor(DtValidadeIni.Subtract(DateTime.Now).TotalDays) > 1)
                    return "Validade: " + ((int)Math.Floor(DtValidadeIni.Subtract(DateTime.Now).TotalDays)).ToString() + " dias ";
                else
                    return "Validade: " + ((int)Math.Floor(DtValidadeIni.Subtract(DateTime.Now).TotalDays)).ToString() + " dia ";
            }
        }
    }
}
