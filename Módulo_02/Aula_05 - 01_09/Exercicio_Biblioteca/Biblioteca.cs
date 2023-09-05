using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca
{
    public class Biblioteca
    {
        private List<IPodeSerEmprestado> itememprestado = new();

        public void AdicionarItem(ItemBiblioteca item)
        {
            if (item is IPodeSerEmprestado emprestimo)
            {
                itememprestado.Add(emprestimo);
                Console.WriteLine($"O item '{item.Titulo}' foi adicionado à biblioteca.");
            }
            else
            {
                Console.WriteLine($"O item '{item.Titulo}' não pode ser emprestado e não foi adicionado à biblioteca.");
            }
        }

        public void EmprestarItem(string titulo)
        {
            var item = itememprestado.Find(obj => obj is ItemBiblioteca && ((ItemBiblioteca)obj).Titulo == titulo);

            if (item != null)
            {
                item.Emprestar();
                itememprestado.Remove(item);
            }
            else
            {
                Console.WriteLine($"O item '{titulo}' não pode ser emprestado.");
            }
        }

        public void DevolverItem(string titulo)
        {
            var item = itememprestado.Find(obj => obj is ItemBiblioteca && ((ItemBiblioteca)obj).Titulo == titulo);

            if (item != null)
            {
                item.Devolver();
                itememprestado.Add(item);
            }
            else
            {
                Console.WriteLine($"O item '{titulo}' não pode ser devolvido. Procure a secretaria.");
            }
        }

    }
}
