using System;
namespace lab
{
 class Program
 {
 static void Main()
 {
 byte[] A = { 0, 0, 1, 1, 0, 0, 1, 0, 0 }; byte priceA = 1;
 byte[] B = { 0, 1, 1, 0, 1, 0, 0, 0, 1 }; byte priceB = 2;
 byte[] C = { 0, 0, 0, 0, 1, 1, 0, 1, 0 }; byte priceC = 2;
 byte[] D = { 1, 0, 0, 1, 1, 0, 0, 0, 1 }; byte priceD = 3;
 byte[] E = { 0, 0, 0, 0, 0, 0, 1, 1, 1 }; byte priceE = 1;
 byte[] F = { 1, 1, 0, 0, 0, 1, 0, 0, 0 }; byte priceF = 1;
 byte[] G = { 0, 1, 1, 0, 0, 1, 1, 1, 0 }; byte priceG = 3;
 byte[][] AllArray1 = {A, B, C, D, E, F, G};
 for (byte i = 0; i < 7; i++)
 {
 for (byte j = 0; j < 7; j++)
 {
 foreach (byte el in SumaArray2(AllArray1[i], AllArray1[j]))
 {
 if (i >= j) { continue; }
 Console.Write(el + " ");
 }
if (i == 3 && j == 6)
{
 Console.Write("DG - Покритя без надлишку, коштує 6 ");
 }
 Console.WriteLine();
 }
 Console.WriteLine();
 }
 int[] AB = SumaArray2(A, B);
 int[] AC = SumaArray2(A, C);
 int[] AD = SumaArray2(A, D);
 int[] AE = SumaArray2(A, E);
 int[] AF = SumaArray2(A, F);
 int[] AG = SumaArray2(A, G);
 int[] BC = SumaArray2(B, C);
 int[] BD = SumaArray2(B, D);
 int[] BE = SumaArray2(B, E);
 int[] BF = SumaArray2(B, F);
 int[] BG = SumaArray2(B, G);
 int[] CD = SumaArray2(C, D);
 int[] CE = SumaArray2(C, E);
 int[] CF = SumaArray2(C, F);
 int[] CG = SumaArray2(C, G);
 int[] DE = SumaArray2(D, E);
 int[] DF = SumaArray2(D, F);
 int[] DG = SumaArray2(D, G);
 int[] EF = SumaArray2(E, F);
 int[] EG = SumaArray2(E, G);
 int[] FG = SumaArray2(F, G);
 int[][] AllArray2 = { AB, AC, AD, AE, AF, AG, BC, BD, BE, BF, BG, CD, 
CE, CF, CG, DE, DF, DG, EF, EG, FG };
 for (byte i = 0; i < AllArray2.Length; i++)
 {
 for (byte j = 0; j < AllArray1.Length; j++)
 {
 foreach (int el in SumaArray2(AllArray2[i], AllArray1[j]))
 {
 if (i == 0)
{
 if (j < 2)
 continue;
 }
 if (i == 1)
 {
 if (j < 3)
 continue;
 }
if (i == 2)
{
 if (j < 4)
 continue;
 }
if (i == 3)
{
 if (j < 5)
 continue;
 }
if (i == 4)
{
 if (j < 6)
 continue;
 }
if (i == 5)
 continue;
 if (i == 6)
 {
 if (j < 3)
 continue;
 }
if (i == 7)
{
 if (j < 4)
 continue;
 }
if (i == 8)
{
 if (j < 5)
 continue;
 }
 if (i == 9)
 {
 if (j < 6)
 continue;
 }
if (i == 10)
 continue;
 if (i == 11)
{
 if (j < 4)
 continue;
 }
if (i == 12)
{
 if (j < 5)
 continue;
 }
if (i == 13)
 {
 if (j < 6)
 continue;
 }
if (i == 14)
 continue;
 if (i == 15)
{
 if (j < 5)
 continue;
 }
if (i == 16)
 {
 if (j < 6)
 continue;
 }
if (i == 17)
 continue;
 if (i == 18)
{
 if (j < 6)
 continue;
 }
if (i == 19)
 continue;
 if (i == 20)
 continue;
 
 Console.Write(el + " ");
 }
Console.WriteLine();
if (i == 0 && j == 0)
{
 Console.Write("");
 }
if (i == 2 && j == 6)
{
 Console.Write("ADG - Покритя з надлишком, коштує 7 ");
 }
 if (i == 7 && j == 6)
{
 Console.Write("BDG - Покритя з надлишком, коштує 8 ");
 }
if (i == 11 && j == 6)
{
 Console.Write("CDG - Покритя з надлишком, коштує 8 ");
 }
if (i == 15 && j == 6)
{
 Console.Write("DEG - Покритя з надлишком, коштує 7 ");
 }
 if (i == 16 && j == 6)
{
 Console.Write("DFG - Покритя з надлишком, коштує 7 ");
 }
 }
 Console.WriteLine();
 }
 Console.WriteLine();
 Console.WriteLine();
 Console.WriteLine("Покритя без надлишку: DG коштує 6");
 Console.WriteLine("Покриття з надлишком: ADG коштує 7; BDG коштує 8;CDG коштує 8; DEG коштує 7; DFG коштує 7");
 Console.ReadLine();
 }
 static int[] SumaArray2(byte[] a, byte[] b)
 {
 int[] suma = { a[0] + b[0], a[1] + b[1], a[2] + b[2], a[3] + b[3], a[4] 
+ b[4], a[5] + b[5], a[6] + b[6], a[7] + b[7], a[8] + b[8] };
 return suma;
 }
 static int[] SumaArray2(int[] a, byte[] b)
 {
 int[] suma = { a[0] + b[0], a[1] + b[1], a[2] + b[2], a[3] + b[3], a[4] 
+ b[4], a[5] + b[5], a[6] + b[6], a[7] + b[7], a[8] + b[8] };
 return suma;
 }
 }
}