/*
Desafio
O rodízio de veículos de Bravoos é uma restrição à circulação de veículos na cidade. Com o propósito de melhorar as condições ambientais reduzindo a carga de poluentes na atmosfera,incluindo na região de Westeros, se consolidou como um instrumento para reduzir congestionamentos nas principais vias da cidade, nos horários de maior movimento. Nas ruas delimitadoras não é permitido o tráfego de cavalos e carruagens que estejam dentro da restrição. Há uma escala que determina em quais dias da semana quais veículos não podem circular. Essa escala é regida pelo último dígito da placa do animal, sendo:

Segunda-feira, digito final da placa 1 e 2
Terça-feira, digito final da placa 3 e 4
Quarta-feira, digito final da placa 5 e 6
Quinta-feira, digito final da placa 7 e 8
Sexta-feira, digito final da placa 9 e 0
Os motoristas que são flagrados violando a restrição de circulação são autuados com multa de 4 galinhas e condenados a passar 1 semana na Muralha.

Entrada
A primeira linha de entrada representa a quantidade de testes N (0 <= N < 1000) que deverão ser considerados. As demais entradas são cadeia de caracteres com tamanho máximo S (1 <= S <= 100) que representam cada placa que deverá ser analisada, de tal forma que, cada placa fique em uma única linha de entrada. O formato esperado para uma placa veicular válida em Bravoos é "AAA-9999", tal que A é um caracter válido em [A-Z], e 9 um dígito numérico válido em [0-9].

Saída
O conjunto de valores válidos como saída são: SEGUNDA, TERCA, QUARTA, QUINTA e SEXTA, de acordo com a tabela de restrições predefinida, e FALHA caso a placa não apresente o padrão definido.

 
Exemplos de Entrada 
3
ABC-1234
XYZ-1010
AAA3333
Exemplos de Saída
TERCA
FRIDAY
FALHA

Exemplos de Entrada
4
abc-1234
a-1010
ABCD-1234
AIQ-2001
Exemplos de Saída
FALHA
FALHA
FALHA
SEGUNDA
*/




using System;

class Desafio{

 public static void Main (string[] args){
   int N = int.Parse(Console.ReadLine());
   for (int i=0; i<N; i++){
     
     string placa = Console.ReadLine();
     if (estaNoPadrao(placa)){
       Console.WriteLine(rodizio(placa));
     }
     else {
       Console.WriteLine("FALHA");
     }
   }
 }

 public static bool estaNoPadrao(string placa){

  // Se true, então a placa nao tem erros
  bool verificaPlaca = false;

  if (placa.Length == 8){
   verificaPlaca =  
         // 3 precisa ser um digito
         (placa[3] == '-') &&
         // 4,5,6 e 6 sao nros
         ( Char.IsDigit(placa[4]) ) &&
         ( Char.IsDigit(placa[5]) ) &&
         ( Char.IsDigit(placa[6]) ) &&
         ( Char.IsDigit(placa[7]) ) &&
         
         // 0,1 e 2 sao letras
         ( Char.IsLetter(placa[0]) ) &&
         ( Char.IsLetter(placa[1]) ) &&
         ( Char.IsLetter(placa[2]) ) &&
         
         // E as letras sao maiuscular
         ( Char.IsUpper(placa[0]) ) &&
         ( Char.IsUpper(placa[1]) ) &&
         ( Char.IsUpper(placa[2]) );
  }
  return verificaPlaca;
 }
 
 public static string rodizio(string placa){
   
   string aux = "";
   char ultimoNro = placa[placa.Length - 1];
   
   switch ( ultimoNro ){
   case '1': aux = "SEGUNDA"; break;
   case '2': aux = "SEGUNDA"; break;
   case '3': aux = "TERCA"; break;
   case '4': aux = "TERCA"; break;
   case '5': aux = "QUARTA"; break;
   case '6': aux = "QUARTA"; break;
   case '7': aux = "QUINTA"; break;
   case '8': aux = "QUINTA"; break;
   case '9': aux = "SEXTA"; break;
   case '0': aux = "SEXTA"; break;
   default: aux = "FALHA"; break;
   }
  return aux;
 }
}