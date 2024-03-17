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
        Task<IEnumerable<DeliveryQueueRecord>> GetAll();
    }

    public class DeliveryQueueRepository : IDeliveryQueueRepository
    {
        private readonly string _connectionString = "Data Source=DESKTOP-MUGRJ5P;Initial Catalog=DeliverySystem;Integrated Security=True;Encrypt=False";

        public Task Add(DeliveryQueueRecord record)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DeliveryQueueRecord>> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var records = await connection.QueryAsync<DeliveryQueueRecord>("p_GetDeliveryQueueRecords", 
                    commandType: System.Data.CommandType.StoredProcedure);

                return records;
            }
        }
    }
}