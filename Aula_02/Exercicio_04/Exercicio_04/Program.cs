﻿/* 4- Escrever um programa que preencha um vetor de 100 elementos com valores inteiros aleatórios, e 
identifique o maior e o menor número gerados, e respectivas posições. */

int[] vetornum = new int[100];
Random aleatorio = new Random();

//Console.WriteLine(vetornum);

for (int i = 0; i < vetornum.Length; i++)
{
    vetornum[i] = aleatorio.Next(1, 99);
}

int maiornum = vetornum.Max();
int menornum = vetornum.Min();

Console.WriteLine($"O maior número é {maiornum} na posição {Array.IndexOf(vetornum, maiornum)}.");
Console.WriteLine($"O menor número é {menornum} na posição {Array.IndexOf(vetornum, menornum)}.");

// QUERO SABER COMO FAZ PRA IMPRIMIR OS NÚMEROS GERADOS.