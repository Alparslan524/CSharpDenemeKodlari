using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer customer1 = new CorporateCustomer();
            customer1.Id = 123456;//Kalıtım
            customer1.MusteriNo = "1231111";
            customer1.CompanyName = "Github";
            customer1.TaxNo = "11111111";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 789;//Kalıtım sayesinde
            customer2.MusteriNo = "123456";
            customer2.Name = "Alparslan";
            customer2.LastName = "Aydoğan";
            customer2.TcNo = "6666666";

            Customer customer3 = new CorporateCustomer();//Base Sınıf referans olduğu için 
            Customer customer4 = new IndividualCustomer();//çocuklarından bu şekilde tanımlayabildik
        }
    }
}
