> Open Closed Principle
> ```
>     Di Source Code ini terdapat 2 program, yaitu CouponWithOCP dan CouponWithoutOCP.
>     Pada bagian Coupon With OCP, karena menggunakan Abstraction kita dapat mengubah object menjadi object lain tanpa harus meninggalkan fungsi sesungguhnya.
>     Sedangkan pada bagian CouponWithoutOCP, jika mengubah salah satu fungsi maka akan memengaruhi fungsi lain.
>     Program ini berjalan pada console, sehingga jalankan dengan Run Without Debug.
> ```
> 
> Coupon Without OCP
> 
> dari awal diberikan kode sebagai berikut :
> 
>     Class Coupon
> 
> ```class Coupon
>     {
>         public double discNominal = 0;
>         public double priceNett(double originPrice)
>         {
>             double net = 0;
>             net = (100 - discPercentage) * originPrice / 100;
>             return net;
>         }
>     }
> ```
>     Class Program
> 
> ```class Program
>   {
>       static void Main(string[] args)
>       {
> 
> 
>           Coupon coupon1 = new Coupon();
>           coupon1.discNominal = 2000;
>           Console.WriteLine(coupon1.priceNett(10000));
>       }
>   }
> ```
> Coupon With OCP
> 
>    ```class Coupon.cs
> 
> public abstract class Coupon
>   {
>       public abstract double calculate(double originPrice);
>   }
> ```
>    ```class CouponWithNominal.cs
> 
> class CouponWithNominal : Coupon
>     {
>         public double discNominal;
> 
>         public CouponWithNominal(double discNominal)
>         {
>             this.discNominal = discNominal;
>         }
> 
>         public override double calculate(double originPrice)
>         {
>             return originPrice - discNominal;
>         }
>     }
> ```
>  class Program.cs
> 
> ```class Program
>     {
>         static void Main(string[] args)
>         {
>             Console.WriteLine("Hello World!");
>             Coupon coupon1 = new CouponWithNominal(2000);
>             Console.WriteLine(coupon1.calculate(10000));
>         }
>     }
> ```