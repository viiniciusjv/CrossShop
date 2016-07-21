using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public class ProdutosEstatisticas : ModelDBMaster
    {
        int _TempoMedioVendaUnitaria;
        public int TempoMedioVendaUnitaria
        {
            get
            {
                return _TempoMedioVendaUnitaria;
            }
            set
            {
                _TempoMedioVendaUnitaria = value;
                OnPropertyChanged();
            }
        }
        double _PrecoMedio;
        public double PrecoMedio
        {
            get
            {
                return _PrecoMedio;
            }
            set
            {
                _PrecoMedio = value;
                OnPropertyChanged();
            }
        }

    }
}
