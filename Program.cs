using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{ 
    public class Ordenar
    {
       public void heapsort(int[] vet, int N)
        {
            int i, aux;

            //aqui ele divide o vetor em duas parte e cria a heap 
            for (i = (N - 1) / 2; i >= 0; i--)
            {
                criaHeap(vet, i, N - 1);
            }
            //pegar o maior elemento da heap e coloca na posição correspondente a i; sendo i a ultima possição do vetor e assim por diante.
            for (i = N - 1; i >= 1; i--)
            {
                aux = vet[0];
                vet[0] = vet[i];
                vet[i] = aux;
                //reestrutura a heap,isto é após ordenar a posição do maior valor ele volta a organizar a arvore até ordenar todo o vetor.
                criaHeap(vet, 0, i - 1);
            }
        }

       public void criaHeap(int[] vet, int i, int f) //i= inicio do vetor && f= fim do vetor
        {
            int aux = vet[i];//esse é o pai da arvore
            int j = i * 2 + 1;//esses são os filhos

            while (j <= f)//se o filho for menor que o final do vetor.
            {
                if (j < f)
                {
                    if (vet[j] > vet[j + 1])//verifica quem dos dois filhos é o maior.
                    {
                        j = j + 1;
                    }
                }
                if (aux > vet[j])//verifica se o nodo filho é maior que o pai.
                {
                    vet[i] = vet[j];
                    i = j;
                    j = 2 * i + 1;
                }
                else
                {
                    j = f + 1;//se o filho n for maior que pai e nem maior que seu outro filho. j= fim do vetor;
                }
            }
            vet[i] = aux; //devolve o ultimo filho copiado para o lugar.
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Ordenar vetor = new Ordenar();
            int[] vet = { 10, 64, 7, 99, 32, 18 };
            int n = vet.Length;

            
            vetor.heapsort(vet, n);
            

            Console.ReadKey();
        }

        


    }
}
