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
        public dynamic  FillGrid()
        {
            return Ref_PersonCrud.SelectAll();
        }
    }
}
