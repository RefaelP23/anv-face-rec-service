﻿using Dapper;
using FaceRec.API.Entities;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FaceRec.API.DAL
{
    public class PersonRepository : IPersonRepository
    {
        private readonly string _connectionString;

        public PersonRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("PgSqlConnection");
        }

        public async Task<int> AddAsync(Person entity)
        {
            var sql = "Insert into persons (name,features) VALUES (@Name,@Features)";
            using var connection = CreateConnection();
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM persons WHERE id = @Id";
            using var connection = CreateConnection();
            connection.Open();
            var result = await connection.ExecuteAsync(sql, new { Id = id });
            return result;
        }

        public async Task<IReadOnlyList<Person>> GetAllAsync()
        {
            var sql = "SELECT * FROM persons";
            using var connection = CreateConnection();
            connection.Open();
            var result = await connection.QueryAsync<Person>(sql);
            return result.ToList();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM persons WHERE id = @Id";
            using var connection = CreateConnection();
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<Person>(sql, new { Id = id });
            return result;
        }

        public async Task<int> UpdateAsync(Person entity)
        {
            var sql = "UPDATE Products SET name = @Name, features = @Features  WHERE id = @Id";
            using var connection = CreateConnection();
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }

        private IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}