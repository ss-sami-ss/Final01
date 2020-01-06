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
            using (var context = new Model.DomainModel.DTO.EF.ContactEntities1())
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

        #region [- Inser(string fName, string lName, string identityCode, string telNumber, string phoneNumber) -]
        public void Inser(string fName, string lName, string identityCode, string telNumber, string phoneNumber)
        {
            using (var context = new Model.DomainModel.DTO.EF.ContactEntities1())
            {
                try
                {
                    var person = new DTO.EF.Person();
                    person.FirstName = fName;
                    person.LastName = lName;
                    person.IdentityCode = identityCode;
                    person.TelephoneNumber = telNumber;
                    person.PhoneNumber = phoneNumber;
                    context.Person.Add(person);
                    context.SaveChanges();

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

        #region  [- Edit(DTO.EF.Person person) -]
        public void Edit(DTO.EF.Person person)
        {
            using (var context = new Model.DomainModel.DTO.EF.ContactEntities1())
            {
                try
                {
                    context.Person.Attach(person);
                    context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
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

        #region  [- Delete(DTO.EF.Person person) -]
        public void Delete(DTO.EF.Person person)
        {
            using (var context = new Model.DomainModel.DTO.EF.ContactEntities1())
            {
                try
                {
                    context.Entry(person).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
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

        #endregion
    }
}
