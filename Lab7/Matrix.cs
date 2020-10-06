using System;


namespace Lab7
{
    class Matrix
    {
        int row, col;
        int[,] mat;
        public Matrix()
        {
            row = 0;
            col = 0;
            mat = new int[row,col];
        }
        public Matrix(int r,int c)
        {
            //Using Parametrized CTR to input The row  and column values and initializing it to The Size of The Matrix !
            row = r;
            col = c;
            mat = new int[row, col];
        }
        public void setMatrix()
        {
            Console.WriteLine($"Enter The Numbers in {row} X {col} Format !");
            for (int i=0;i<row;i++)
            {
                //Inputting The Matrices 
                for (int j=0;j<col;j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        //Transpose of A Matrix is done where the rows become the columns
        //So We need to calculate the rows and columns!
        public static Matrix operator ~(Matrix m)
        {
            Matrix newMatrix= new Matrix(m.col,m.row);
            for (int i=0;i<m.col;i++)
            {
                for (int j=0;j<m.row;j++)
                {
                    newMatrix.mat[i, j] =m.mat[j,i];
                }
            }
            return newMatrix;
        }
        public void getMatrix()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    /*1 2 3
                     *4 5 6
                     *7 8 9
                     The Above is The Output Format !
                     */
                    Console.Write(mat[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void Test()
        {
            Matrix m1 = new Matrix(3,3);
            m1.setMatrix();
            Matrix m2 = new Matrix();
            //Creating a new Matrix Object and Assigning the Transpose of Matrix one to it !
            m2 = ~m1;
            m1.getMatrix();
            //Print Out Both of Them !
            m2.getMatrix();
            
            
        }
    }
}
