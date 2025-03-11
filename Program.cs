int Rate = 25000;
int VND;
int USD;
Console.WriteLine("So tien USD can quy doi : ");
USD = int.Parse(Console.ReadLine());
VND = USD * Rate;
Console.WriteLine("So tien VND tuong ung : " + VND + " dong ");