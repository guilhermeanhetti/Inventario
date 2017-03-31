using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Itens
{
    public string name;
    public Itens next = null;

    public Itens(string name)
    {
        this.name = name;
    }
}


namespace Inventário


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga o item que deseja usar...");
            string a = Console.ReadLine();
            Itens Itens1 = new Itens("espada");
            Itens Itens2 = new Itens("machado");
            Itens Itens3 = new Itens("faca");
            Itens Itens4 = new Itens("arco");
            Itens Itens5 = new Itens("bastao");
            Itens Itens6 = new Itens("facao");
            Itens Itens7 = new Itens("katana");
            Itens Itens8 = new Itens("machadinha");
            Itens Itens9 = new Itens("sabre");
            Itens Itens10 = new Itens("martelo");

            Itens1.next = Itens2;
            Itens2.next = Itens3;
            Itens3.next = Itens4;
            Itens4.next = Itens5;
            Itens5.next = Itens6;
            Itens6.next = Itens7;
            Itens7.next = Itens8;
            Itens8.next = Itens9;
            Itens9.next = Itens10;



            Itens currentElement = Itens1;
            int pos = 1;
            while (currentElement != null)
            {

                if (a == currentElement.name)
                {
                    Console.WriteLine("Voce escolheu o item " + a + ", que esta na posiçao " + pos + " do inventario");
                    return;
                }

                currentElement = currentElement.next;
                pos++;
            }

            Console.WriteLine("Voce nao possui este item...");
        }


    }
}
