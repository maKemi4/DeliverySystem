using Dapper;
using DeliverySystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Repositories
{
    public interface IDeliveryQueueRepository
    {
        Task Add(DeliveryQueueRecord record);
        Task<IEnumerable<DeliveryQueueRecord>> GetAll(bool onlyNotCompleted = false);
    }

    public class DeliveryQueueRepository : IDeliveryQueueRepository
    {
        private readonly string _connectionString = "Data Source=DESKTOP-MUGRJ5P;Initial Catalog=DeliverySystem;Integrated Security=True;Encrypt=False";

        public async Task Add(DeliveryQueueRecord record)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = ParametersHelper.ToDictionary(record);
                var parmDictionary = dictionary.Select(d => new { Key = $"@{d.Key}", d.Value }).ToDictionary(d => d.Key, d => d.Value);
                var parameters = new DynamicParameters(dictionary);

                await connection.QueryAsync<DeliveryQueueRecord>("p_UpdateDeliveryQueueRecord", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<DeliveryQueueRecord>> GetAll(bool onlyNotCompleted = false)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@OnlyNotCompleted", onlyNotCompleted }
                };
                var parameters = new DynamicParameters(dictionary);
                var records = await connection.QueryAsync<DeliveryQueueRecord>("p_GetDeliveryQueueRecord", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

                return records;
            }
        }
    }
}