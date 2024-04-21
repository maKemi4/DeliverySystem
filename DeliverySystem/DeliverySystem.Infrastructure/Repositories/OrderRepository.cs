using Dapper;
using DeliverySystem.Infrastructure.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Repositories
{
    public interface IOrderRepository
    {
        Task<int> CreateOrder(IEnumerable<int> deliveryQueueRecordIds);
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly string _connectionString = "Data Source=DESKTOP-MUGRJ5P;Initial Catalog=DeliverySystem;Integrated Security=True;Encrypt=False";

        public async Task<int> CreateOrder(IEnumerable<int> deliveryQueueRecordIds)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@deliveryQueueRecordIds", deliveryQueueRecordIds }
                };

                if (!deliveryQueueRecordIds.Any()) return -1;
                var ids = string.Join(",", deliveryQueueRecordIds);

                var parameters = new DynamicParameters(dictionary);

                var record = await connection.QueryAsync<OrderList>("p_CreateOrderList", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

                return record;
            } 
        }
    }
}
