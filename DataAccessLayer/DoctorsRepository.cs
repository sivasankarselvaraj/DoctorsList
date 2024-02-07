using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DoctorsRepository: IDoctors
    {
        private readonly DbConnect connect;
        public DoctorsRepository(DbConnect dbset)
        {
            connect=dbset;
        }
       /* public void Insert(Doctor details)
        {
            try
            {

            }
            catch(Exception)
            {

            }
        }
        public void Update(Doctor replace,long id)
        {
            try
            {

            }
            catch (Exception)
            {

            }

        }
        public void Delete(long id)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }
        public List<Doctor> Getall()
        {
            try
            {
                
            }
            catch (Exception)
            {

            }
        }
        public Doctor GetById(long id)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }*/
    }
}
