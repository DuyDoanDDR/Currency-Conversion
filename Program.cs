int Rate = 25000;
float VND;
float USD;
Console.WriteLine("So tien USD can quy doi : ");
USD = float.Parse(Console.ReadLine());
VND = USD * Rate;
Console.WriteLine("So tien VND tuong ung : " + VND + " dong ");