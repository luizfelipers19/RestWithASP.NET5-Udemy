using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    { 
        PersonVO Create(PersonVO person);

        PersonVO FindById(long id);

        List<PersonVO> FindPersonByName(string firstName, string lastName);

        List<PersonVO> FindAll();

        PagedSearchVO<PersonVO> FindWithPagedSearch(
            string name, string sortDirection, int pageSize, int page);

        PersonVO Update(PersonVO person);

        PersonVO Disable(long id);

        void Delete(long id);



       


    }
}
