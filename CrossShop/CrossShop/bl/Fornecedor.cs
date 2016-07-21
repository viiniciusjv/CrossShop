using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossShop.bl
{
    public class Fornecedor : ModelDBMaster
    {
        string _NomeFantasia;
        public string NomeFantasia
        {
            get
            {
                return _NomeFantasia;
            }
            set
            {
                _NomeFantasia = value;
                OnPropertyChanged();
            }
        }

        public List<Endereco> Enderecos
        {
            get; set;
        }

        Endereco _EndPrincipal;
        public Endereco EndPrincipal
        {
            get
            {
                return _EndPrincipal;
            }
            set
            {
                _EndPrincipal = value;
                OnPropertyChanged();
            }
        }

        byte[] _ImagemFornec;
        public byte[] ImagemFornec
        {
            get
            {
                return _ImagemFornec;
            }
            set
            {
                _ImagemFornec = value;
                OnPropertyChanged();
            }
        }
    }
}
