using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModel.POCO
{
   public  class PersonCrud
    {
        #region  [- ctor -]
        public PersonCrud()
        {

        }
        #endregion
        #region [- Tasks -]
        #region [- SelectAll() -]
        public List<Model.DomainModel.DTO.EF.Person> SelectAll()
        {
            using (var context = new Model.DomainModel.DTO.EF.ContactEntities())
            {
                try
                {
                    var q = context.Person.ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    context.Dispose();
                }

            }
        }
        #endregion 
        public void Inser(string fName,string lName,string identityCode,string  telNumber,string phoneNumber)
        {
            using (var contect=new Model.DomainModel.DTO.EF.ContactEntities())
            {
                try
                {
                    var person = new DTO.EF.Person();
                    person.FirstName = fName;
                    person.LastName = lName;
                    person.IdentityCode = identityCode;
                    person.TelephoneNumber = telNumber;
                    person.PhoneNumber = phoneNumber;
                    contect.Person.Add(person);
                    contect.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    contect.Dispose();
                }

            }
        }


        #endregion
    }
}
