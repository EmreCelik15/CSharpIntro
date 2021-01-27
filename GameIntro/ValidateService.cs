using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public class ValidateService : IValidateService
    {
        public bool Validate(IPerson person)
        {
            if (Convert.ToString(person.Id).Length==11 && person.Name.Length>1 && person.Surname.Length>1)
            {
                Console.WriteLine(person.Name+ " " +person.Surname+" "+"isimli kişi Mernis'e kayıtlıdır");
                return true;
            }
            else
            {
                Console.WriteLine(person.Name + " " + person.Surname + " " + "isimli kişi Mernis'e kayıtlı değildir");
                return false;
            }


        }
    }
}
