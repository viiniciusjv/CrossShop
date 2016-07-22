using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public class OfertasControl
    {
        public List<Oferta> Get()
        {
            List<Oferta> lst = new List<Oferta>();

            Endereco end = new Endereco() { Complemento = "Comp", IdPessoa = 1, Numero = "14", Logradouro = "Rua 123", Latitude = 100, Longitude = 200 };
            Endereco end2 = new Endereco() { Complemento = "Comp2", IdPessoa = 1, Numero = "15", Logradouro = "Rua 456", Latitude = 100, Longitude = 200 };
            Endereco end3 = new Endereco() { Complemento = "Comp3", IdPessoa = 1, Numero = "16", Logradouro = "Rua 678", Latitude = 100, Longitude = 200 };
            Endereco end4 = new Endereco() { Complemento = "Comp4", IdPessoa = 1, Numero = "17", Logradouro = "Rua 890", Latitude = 100, Longitude = 200 };

            Fornecedor Fornec = new Fornecedor() { Enderecos = new List<Endereco>(), EndPrincipal = end, NomeFantasia = "Savegnago" };
            Fornec.Enderecos.Add(end);
            Fornecedor Fornec2 = new Fornecedor() { Enderecos = new List<Endereco>(), EndPrincipal = end2, NomeFantasia = "Mialich" };
            Fornec.Enderecos.Add(end2);
            Fornecedor Fornec3 = new Fornecedor() { Enderecos = new List<Endereco>(), EndPrincipal = end3, NomeFantasia = "Wallmart" };
            Fornec.Enderecos.Add(end3);
            Fornecedor Fornec4 = new Fornecedor() { Enderecos = new List<Endereco>(), EndPrincipal = end4, NomeFantasia = "Carrefour" };
            Fornec.Enderecos.Add(end4);

            Categoria cat = new Categoria() { Descricao = "Bolachas" };
            Categoria cat2 = new Categoria() { Descricao = "Grãos" };
            Categoria cat3 = new Categoria() { Descricao = "Saudável" };
            Categoria cat4 = new Categoria() { Descricao = "Básicos" };

            Produto prod = new Produto() { Cat = cat, Descricao = "Bono", PrecoNominal = 3 };
            Produto prod1 = new Produto() { Cat = cat2, Descricao = "Feijão", PrecoNominal = 15 };
            Produto prod2 = new Produto() { Cat = cat3, Descricao = "Nesfit", PrecoNominal = 4 };
            Produto prod3 = new Produto() { Cat = cat4, Descricao = "Arroz", PrecoNominal = 5 };

            UnidadesDeMedidas um = new UnidadesDeMedidas() { Descricao = "Pacote" };

            lst.Add(new Oferta() { DtValidadeFin = DateTime.Now.AddDays(5), DtValidadeIni = DateTime.Now.AddDays(3), Fonec = Fornec, Preco = 1, Prod = prod, QuantidadeDisponivel = 100, UM = um });
            lst.Add(new Oferta() { DtValidadeFin = DateTime.Now.AddDays(6), DtValidadeIni = DateTime.Now.AddDays(4), Fonec = Fornec4, Preco = 5, Prod = prod1, QuantidadeDisponivel = 30, UM = um });
            lst.Add(new Oferta() { DtValidadeFin = DateTime.Now.AddDays(12), DtValidadeIni = DateTime.Now.AddDays(2), Fonec = Fornec2, Preco = 1.5, Prod = prod2, QuantidadeDisponivel = 25, UM = um });
            lst.Add(new Oferta() { DtValidadeFin = DateTime.Now.AddDays(7), DtValidadeIni = DateTime.Now.AddDays(5), Fonec = Fornec3, Preco = 4, Prod = prod3, QuantidadeDisponivel = 50, UM = um });

            return lst;
        }
    }
}
