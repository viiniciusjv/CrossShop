using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public class Endereco : ModelDBMaster
    {
        int _IdPessoa;
        public int IdPessoa
        {
            get
            {
                return _IdPessoa;
            }

            set
            {
                _IdPessoa = value;
                OnPropertyChanged();
            }
        }
        string _Logradouro;
        public string Logradouro
        {
            get
            {
                return _Logradouro;
            }
            set
            {
                _Logradouro = value;
                OnPropertyChanged();
            }
        }
        string _Numero;
        public string Numero
        {
            get
            {
                return _Numero;
            }
            set
            {
                _Numero = value;
                OnPropertyChanged();
            }
        }
        string _Complemento;
        public string Complemento
        {
            get
            {
                return _Complemento;
            }
            set
            {
                _Complemento = value;
                OnPropertyChanged();
            }
        }

        decimal _Latitude;
        public decimal Latitude
        {
            get
            {
                return _Latitude;
            }
            set
            {
                _Latitude = value;
                OnPropertyChanged();
            }
        }
        decimal _Longitude;
        public decimal Longitude
        {
            get
            {
                return _Longitude;
            }
            set
            {
                _Longitude = value;
                OnPropertyChanged();
            }
        }
    }
}
