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
    public interface IOrderExecutorRepository
    {
        Task<int> AddOrderExecutor(OrderExecutor orderExecutor);
        Task<OrderExecutor> GetOrderExecutor(int orderExecutorId);
    }

    public class OrderExecutorRepository : IOrderExecutorRepository
    {
        private readonly string _connectionString = "Data Source=DESKTOP-MUGRJ5P;Initial Catalog=DeliverySystem;Integrated Security=True;Encrypt=False";

        public async Task<int> AddOrderExecutor(OrderExecutor orderExecutor)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@ExecutorName", orderExecutor.ExecutorName },
                    {  "@ExecutorSurname", orderExecutor.ExecutorSurname },
                    {  "@OrganizationName", orderExecutor.OrganizationName },
                };

                var parameters = new DynamicParameters(dictionary);

                var orderExecutorId = await connection.QueryFirstOrDefaultAsync<int>("p_UpdateOrderExecutor", parameters,
                   commandType: System.Data.CommandType.StoredProcedure);

                return orderExecutorId;
            }
        }

        public async Task<OrderExecutor> GetOrderExecutor(int orderExecutorId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@OrderExecutorId", orderExecutorId }
                };

                var parameters = new DynamicParameters(dictionary);

                var record = await connection.QueryFirstOrDefaultAsync<OrderExecutor>("p_GetOrderExecutor", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

                return record;
            }
        }
    }
}

