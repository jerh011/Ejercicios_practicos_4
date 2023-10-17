//Considere un arreglo entero t de dos por tres.
//a) Escriba una instrucción que declare y cree a t.
using Ejercicios_practicos_4;

Metodos metodos= new Metodos();
int[,] t = new int[2,3];
t = metodos.IncisoA();
//b) ¿Cuántas filas tiene t?
  metodos.IncisoB(t);
//c) ¿Cuántas columnas tiene t?
metodos.IncisoC(t);
//d) ¿Cuántos elementos tiene t?
metodos.IncisoD(t);
//e) Escriba expresiones de acceso para todos los elementos en la fila 1 de t.
metodos.IncisoE(t);
//f ) Escriba expresiones de acceso para todos los elementos en la columna 2 de t.
metodos.IncisoF(t);
//g) Escriba una sola instrucción que asigne cero al elemento de t en la fila 0 y la columna 1.
metodos.IncisoG(t);
//h) Escriba una serie de instrucciones que inicialice cada elemento de t con cero. No utilice una instrucción de repetición.
metodos.IncisoH(t);
//i) Escriba una instrucción for anidada que inicialice cada elemento de t con cero.
metodos.IncisoI(t);
//j) Escriba una instrucción for anidada que reciba como entrada del usuario los valores de los elementos de t.
t=metodos.IncisoJ(t);
//k) Escriba una serie de instrucciones que determine e imprima el valor más pequeño en t.
Console.WriteLine("K");
metodos.IncisoK(t);
//l) Escriba una instrucción Console.WriteLine que muestre los elementos de la primera fila de t. No utilice repetición.
metodos.IncisoL(t);
//m) Escriba una instrucción que totalice los elementos de la tercera columna de t. No utilice repetición.
metodos.IncisoM(t);
//n) Escriba una serie de instrucciones para imprimir el contenido de t en formato tabular. Enliste los índices de columna como encabezados a lo largo de la parte superior, y enliste los índices de fila a la izquierda de cada fila.

