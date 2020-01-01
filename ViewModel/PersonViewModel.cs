using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PersonViewModel
    {
        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.PersonCrud();
        }
        #endregion

        #region [- props -]
        public Model.DomainModel.POCO.PersonCrud Ref_PersonCrud { get; set; }
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

    }
}
