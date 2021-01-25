using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyManager companyManager = new CompanyManager();
            companyManager.Add(new PersonManager());
            companyManager.Delete(new PersonManager());
            companyManager.Update(new PersonManager());


        }
    }
}
