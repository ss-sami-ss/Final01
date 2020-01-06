using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModel.DTO.EF;

namespace ViewModel
{
    public class PersonViewModel
    {
        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.PersonCrud();
            Person = new Person();
        }
        #endregion

        #region [- props -]
        public Model.DomainModel.POCO.PersonCrud Ref_PersonCrud { get; set; }
        public Model.DomainModel.DTO.EF.Person   Person { get;private set; }
        #endregion

        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_PersonCrud.SelectAll();
        }
        #endregion

        #region [- Save(string fName, string lName, string identityCode, string telNumber, string phoneNumber)-]
        public void Save(string fName, string lName, string identityCode, string telNumber, string phoneNumber)
        {
            Ref_PersonCrud.Inser(fName, lName, identityCode, telNumber, phoneNumber);
        }
        #endregion

        #region [- Edit(int id, string firstName, string lastName, string identityCode, string telNumber, string phoneNumber)-]
        public void Edit(int id ,string firstName,string lastName,string identityCode,string telNumber,string phoneNumber)
        {
            Person = new Model.DomainModel.DTO.EF.Person
            {
                Id = id,FirstName=firstName,LastName=lastName,IdentityCode=identityCode,TelephoneNumber= telNumber
                ,
                PhoneNumber= phoneNumber

            };
            Ref_PersonCrud.Edit(Person);
        }
        #endregion

        #region [- Delete(int id, string firstName, string lastName, string identityCode, string telNumber, string phoneNumber)-]
        public void Delete(int id, string firstName, string lastName, string identityCode, string telNumber, string phoneNumber)
        {
            Person = new Model.DomainModel.DTO.EF.Person
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                IdentityCode = identityCode,
                TelephoneNumber = telNumber
    ,
                PhoneNumber = phoneNumber

            };
            Ref_PersonCrud.Delete(Person);
        } 
        #endregion





    }
}
