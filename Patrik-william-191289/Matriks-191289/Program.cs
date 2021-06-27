/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 10/06/2021
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace patrik_william_191289
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n;
            int[,] matriks = new int[100,100];
            int[,] transpose = new int[100,100];

            Console.Write("baris matriks: ");
            m = Convert.ToInt16(Console.ReadLine());
            Console.Write("kolom matriks: ");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("matriks: ");
            for(i = 0; i < m; i++){
                for(j = 0; j < n; j++){
          			Console.Write("[{0}][{1}] : ",i,j);
                   	matriks[i,j] = Convert.ToInt16(Console.ReadLine());
                }
            }

	      	Console.WriteLine("\nMatriks: ");
	      	for(i = 0; i < m; i++){
	        	for(j = 0; j < n; j++){
	          		Console.Write(matriks[i,j]+"\t");
	        	}
	        	Console.WriteLine();
	      	}
	      	
			for (i = 0; i < m; i ++){
	        	for(j = 0; j < n; j++){
	          		transpose[j,i] = matriks[i,j];
	       	 	}
	        }

	      	Console.WriteLine("\nHasil Transpose Matriks: ");
	      	for(i = 0; i < n; i++){
	        	for(j = 0; j < m; j++){
	          		Console.Write(transpose[i,j]+"\t");
	        	}
	        	Console.WriteLine();
	      	}
      
      	Console.ReadKey(true);
    }
  }
}



