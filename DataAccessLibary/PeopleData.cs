using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _dataBase;

        public PeopleData(ISqlDataAccess dataBase)
        {
            _dataBase = dataBase;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT FirstName, LastName, EmailAddress FROM dbo.People";

            return _dataBase.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"INSERT INTO dbo.People (FirstName, LastName, EmailAddress) 
                VALUES (@FirstName, @LastName, @EmailAddress)";

            return _dataBase.SaveData(sql, person);
        }
    }        
}
