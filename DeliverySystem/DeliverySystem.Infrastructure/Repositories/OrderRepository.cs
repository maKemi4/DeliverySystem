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
        Task<int> CreateOrder(IEnumerable<int> deliveryQueueRecordIds, int orderExecutorId);
        Task<IEnumerable<OrderRecord>> GetOrderItems(int orderId);
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly string _connectionString = "Data Source=DESKTOP-MUGRJ5P;Initial Catalog=DeliverySystem;Integrated Security=True;Encrypt=False";

        public async Task<int> CreateOrder(IEnumerable<int> deliveryQueueRecordIds, int orderExecutorId)
        {
            if (!deliveryQueueRecordIds.Any()) return -1;
            var ids = string.Join(",", deliveryQueueRecordIds);

            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    { "@DeliveryQueueItemIds", ids },
                    { "@OrderExecutorId", orderExecutorId },
                };

                var parameters = new DynamicParameters(dictionary);

                var orderId = await connection.QueryFirstOrDefaultAsync<int>("p_CreateOrderList", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

                return orderId;
            } 
        }

        public async Task<IEnumerable<OrderRecord>> GetOrderItems(int orderId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@OrderId", orderId }
                };

                var parameters = new DynamicParameters(dictionary);
                var records = await connection.QueryAsync<OrderRecord>("p_GetOrderItems", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

                return records;
            }
        }
    }
}
