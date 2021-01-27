using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    class PersonManager : IPersonManager
    {
        public void Add(IPerson person)
        {
            ValidateService validateService = new ValidateService();
            if (validateService.Validate(person)==true)
            {
                Console.WriteLine(person.Name+" "+"isimli kişi eklenmiştir.");
            }
            else
            {
                Console.WriteLine(person.Name+" "+"isimli kişi eklenemez.");
            }
        }

        public void Delete(IPerson person)
        {
            Console.WriteLine(person.Name+" "+"isimli kişi silinmiştir.");
        }

        public void Update(IPerson person)
        {
            throw new NotImplementedException(person.Name+" "+"isimli kişinin bilgileri güncellenmiştir.");
        }
    }
}
