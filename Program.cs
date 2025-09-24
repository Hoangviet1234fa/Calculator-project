class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        {
            // Hàm Lựa chọn của người dùng
            Console.WriteLine("Hãy chọn phép tính:");
            Console.WriteLine("1. Phương trình bậc hai");
            Console.WriteLine("2. Tính giai thừa");
            Console.WriteLine("3. Thoát");
            Console.WriteLine("Xin hãy nhập lựa chọn (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("xin hãy nhập lại!");
                return;
            }

            // hàm giải phương trình bậc hai
            while (choice == 1)
            {
                Console.WriteLine("Số của a là: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Số của b là: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Số của c là: ");
                double c = double.Parse(Console.ReadLine());
                double x = 0;
                double delta = b * b - 4 * a * c;

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Vô Số Nghiệm");
                        }
                        else
                        {
                            Console.WriteLine("Vô Nghiệm");
                        }
                    }
                    else
                    {
                        Console.WriteLine(x = -c / b);
                    }
                }
                else

                    Console.WriteLine(delta = b * b - 4 * a * c);

                if (delta > 0)
                {
                    double x11 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x12 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Nghiệm của x1 là: " + x11);
                    Console.WriteLine("Nghiệm của x2 là: " + x12);
                }
                else if (delta == 0)
                    Console.WriteLine("Có Nghiệm kép x1 = x2 = " + -b / (2 * a));
                else
                    Console.WriteLine("Vô Nghiệm");
                break;
            }  
               


            // Hàm tính giai thừa
            while (choice == 2)
            {


                Console.WriteLine("Nhập n: ");
                double n = Convert.ToDouble(Console.ReadLine());
                double S = 1;
                double i = 1;


                while (i <= Convert.ToDouble(n))

                {
                    S = S * i;
                    i = i + 1;
                }
                Console.WriteLine($"Giai thừa của {n} là: {S}");
                break;
            }




            while (choice == 3)
            {
                Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình");
                break;
            }


        }

    }
}


