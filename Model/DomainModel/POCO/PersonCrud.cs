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



        #endregion
    }
}
