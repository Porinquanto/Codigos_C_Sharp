/*
Desafio
Augusto adora se exercitar, por isso levanta todos os dias 6h da manhã, em qualquer tempo ou estação do ano. Ele corre em volta de uma lagoa. Ao longo da pista de corrida existem N placas igualmente espaçadas. Augusto conta o número de placas pelas quais ele já passou e verifica se ele já correu pelo menos 10%, 20%, 90% do percurso.

Vamos ajudar o Augusto, calculando para ele o número de placas que ele precisa contar para ter completado pelo menos 10%, 20%, 90% da corrida, de acordo com o número de voltas que ele quer correr e o número total de placas ao longo da pista.

Se Augusto quiser dar 3 voltas e o número de placas for 17, para garantir ter corrido pelo menos 30% do percurso, ele precisa contar 16 placas. Para garantir pelo menos 60%, ele precisa contar 31 placas.

Entrada
A entrada consiste de uma única linha que contém dois inteiros, A e N (1 ≤ A;N ≤ 104), onde A é o número pretendido de voltas e N é o número de placas na pista.

Saída
Seu programa deve produzir uma única linha com nove inteiros representando os números de placas que devem ser contadas para garantir o cumprimento, respectivamente, de 10%, 20% e 90% da meta.

 
Exemplos de Entrada Exemplos de Saída
3 17
Exemplos de Saída
6 11 16 21 26 31 36 41 46

Exemplos de Entrada
3 11
Exemplos de Saída
4 7 10 14 17 20 24 27 30
*/




using System;

class Desafio {
    static void Main() {
      string[] line = Console.ReadLine().Split(" ");
      int voltas =Convert.ToInt32(line[0]);
      int placas =Convert.ToInt32(line[1]);
      double placasTotal = voltas*placas;
      double dezPorCento = placasTotal/10;
      double[] PlacasPorCento = new double[9];
      
      for(int i=0; i<9; i++){
        
        PlacasPorCento[i] = Math.Ceiling(dezPorCento*(i+1));
      }
      
      Console.WriteLine(string.Join(" ", PlacasPorCento));
    }
}