namespace BTLap5._2Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo mảng
            int[,] twoDimArray = new int[4, 4] {
                {1,2,3, 4},
                {5,6,7, 8},
                {9,10,11,12},
                {13,14,15,16},
            };
            // In mảng theo cột
            Console.WriteLine("Mang theo cột:");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(twoDimArray[j,i]+"\t");
                }
                Console.WriteLine();
            }
            // tính tổng các phần tử có chỉ số hàng bằng chỉ số cột
            int s = 0;
            for (int i = 0;i < 4; i++)
            {
                s += twoDimArray[i, i];
            }
            Console.WriteLine("Tổng các phần tử có chỉ số hàng bằng chỉ số cột:"+s);


            // In ra phần tử nhỏ nhất trên cột
            Console.WriteLine("Phần tử nhỏ nhất trên mỗi cột");
            for(int i = 0;i<4 ; i++)
            {
                int min = twoDimArray[0,i];
                for (int j = 1; j < 4; j++)
                {
                    if (twoDimArray[j,i]<min)
                    {
                        min = twoDimArray[j, i];
                    }
                   
                }
                Console.WriteLine("Cột"+i+":"+min);
            }
            // Liệt kê các phần tử chia hết cho 7
            Console.WriteLine("Liệt kê các phần tử chia hết cho 7:");
            for (int i = 0; i < 4; i++)
            {   
               
                for (int j = 0; j < 4; j++)
                {
                    
                    if (twoDimArray[i,j]%7==0)
                    {
                        Console.WriteLine("Dòng:" +i +"Cột"+j+":"+twoDimArray[i,j]);
                    }
                }
                
            }
            // Tìm tổng các phần tử nằm trên đường viền của mảng
            int sum = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (row == 0 || row == 3 || col == 0 || col == 3)
                    {
                        sum += twoDimArray[row, col];
                    }
                }
            }

            Console.WriteLine("Tổng các phần tử nằm trên đường viền: " + sum);

            // Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần
            int totalElements = 4 * 4; // Tổng số phần tử trong mảng 2 chiều
            int[] oneDimArray = new int[totalElements];

            // Chuyển mảng 2 chiều thành mảng 1 chiều
            int index = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    oneDimArray[index] = twoDimArray[row, col];
                    index++;
                }
            }

            // Sắp xếp mảng 1 chiều tăng dần
            Array.Sort(oneDimArray);

            Console.WriteLine("Mảng 1 chiều sau khi sắp xếp tăng dần:");
            foreach (int num in oneDimArray)
            {
                Console.Write(num + " ");
            }
        }

    
    }
}