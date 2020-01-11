using Model.DomainModel.DTO.EF;
using Model.DomainModel.POCO;

namespace ViewModel
{
    public class PersonViewModel
    {
        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new PersonCrud();
            Person = new Person();
        }
        #endregion

        #region [- props -]
        public PersonCrud Ref_PersonCrud { get; set; }
        public Person   Person { get;private set; }
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
            Person = new Person
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
            Person = new Person
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
