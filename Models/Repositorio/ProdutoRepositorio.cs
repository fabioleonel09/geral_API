using geralAPI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace geralAPI.Models.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto { Nome = "Guaraná Antartica", Categoria = "Refrigerantes", Preco = 4.59M });
            Add(new Produto { Nome = "Suco de Laranja Prats", Categoria = "Sucos", Preco = 5.75M });
            Add(new Produto { Nome = "Mostarda Hammer", Categoria = "Condimentos", Preco = 3.90M });
            Add(new Produto { Nome = "Molho de Tomate Cepera", Categoria = "Condimentos", Preco = 2.99M });
            Add(new Produto { Nome = "Suco de Uva Aurora", Categoria = "Sucos", Preco = 6.50M });
            Add(new Produto { Nome = "Pepsi-Cola", Categoria = "Refrigerantes", Preco = 4.25M });
        }

        public Produto Add(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = produtos.FindIndex(p => p.Id == item.Id);

            if (index == -1)
            {
                return false;
            }
            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}