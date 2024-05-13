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
        Task Add(DeliveryQueueFullRequestInformation record);
        Task<DeliveryQueueFullRequestInformation> GetRequestInformation(int queueRecordId);
        Task<IEnumerable<DeliveryQueueRecord>> GetAll(bool onlyNotCompleted = false);
        Task<int> GetAverageNumOfVictims();
    }

    public class DeliveryQueueRepository : IDeliveryQueueRepository
    {
        private readonly string _connectionString = "Data Source=DESKTOP-MUGRJ5P;Initial Catalog=DeliverySystem;Integrated Security=True;Encrypt=False";

        public async Task Add(DeliveryQueueFullRequestInformation record)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@CustomerName", record.CustomerName },
                    {  "@CustomerSurname", record.CustomerSurname },
                    {  "@Email", record.Email },
                    {  "@PhoneNum", record.PhoneNum },
                    {  "@LocalityName", record.LocalityName },
                    {  "@Latitude", record.Latitude },
                    {  "@Longitude", record.Longtitude },
                    {  "@NumOfVictims", record.NumOfVictims },
                    {  "@NumOfSeveralyVictims", record.NumOfSeveralyVictims },
                    {  "@ConditionType", record.ConditionType },
                    {  "@AgeGroup", record.AgeGroup },
                    {  "@NeededSpecialist", record.NeededSpecialist },
                    {  "@SituationDescription", record.SituationDescription },
                    {  "@Importance", record.Importance },
                    {  "@ImportanceRate", record.ImportanceRate },
                };
                var parameters = new DynamicParameters(dictionary);

                await connection.QueryAsync<DeliveryQueueFullRequestInformation>("p_UpdateDeliveryQueueRecord", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        //GetAll: Якщо onlyNotCompleted = false виводить всі заявки, якщо onlyNotCompleted = true тільки ті, які невиконані
        public async Task<IEnumerable<DeliveryQueueRecord>> GetAll(bool onlyNotCompleted = false) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@OnlyNotCompleted", onlyNotCompleted }
                };
                var parameters = new DynamicParameters(dictionary);
                var records = await connection.QueryAsync<DeliveryQueueRecord>("p_GetDeliveryQueueRecords", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

                return records;
            }
        }

        public async Task<DeliveryQueueFullRequestInformation> GetRequestInformation(int queueRecordId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var dictionary = new Dictionary<string, object>()
                {
                    {  "@DeliveryQueueId", queueRecordId }
                };
                var parameters = new DynamicParameters(dictionary);

                var record = await connection.QueryFirstOrDefaultAsync<DeliveryQueueFullRequestInformation>("p_GetDeliveryQueueFullRequestInformation", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

                return record;
            }
        }

        public async Task<int> GetAverageNumOfVictims()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryFirstOrDefaultAsync<int>("p_GetAverageNumOfVictims", commandType: System.Data.CommandType.StoredProcedure);

                return result;
            }
        }
    }
}