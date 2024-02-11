
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // interfaceleri kullanacagimiz zaman ilk başta field dediğimiz interface türünde değişken tanımlarız
    // bunuda global alanda ulaşabilelim diye yapıyoruz
    // --buraya dikkat-- constructorlar newlendiğinde çaılışır o yüzden set ederiz ve interfaceler referans türlüdür.
    // sonra istediğimiz method ya da classta kullanırız mesela 18. satirda 
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) // Constructor new yapildiginda yapilir
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person) ) {
                Console.WriteLine( person.FirstName + "Maske verildi" );
            }
            else
            {
                Console.WriteLine(person.FirstName+" İçin maske VERİLEMEZ! ");
            }
        }
    }
}
