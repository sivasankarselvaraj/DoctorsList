﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class DoctorsRepository: IDoctors
    {
        private readonly DbConnect connect;
        public DoctorsRepository(DbConnect dbset)
        {
            connect=dbset;
        }
       public void Insert(Doctor details)
        {
            try
            {
                connect.Database.ExecuteSqlRaw("");
            }
            catch(Exception)
            {

            }
        }
        public void Update(Doctor replace,long id)
        {
            try
            {
                connect.Database.ExecuteSqlRaw("");
            }
            catch (Exception)
            {

            }

        }
        public void Delete(long id)
        {
            try
            {
                connect.Database.ExecuteSqlRaw("");
            }
            catch (Exception)
            {

            }
        }
         public List<Doctor> Getall()
        {
            try
            {
                var GetDetails = connect.DoctorTableList.FromSqlRaw<Doctor>("Select * from DoctorTableList").ToList();
                return GetDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Doctor GetById(long id)
        {
            try
            {
                var GetidDetails = connect.DoctorTableList.FromSqlRaw<Doctor>("Select * from DoctorTableList").FirstOrDefault();
                return GetidDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
