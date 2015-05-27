using Microsoft.Framework.OptionsModel;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using SecMaster.Models;
using System.Collections.Generic;

namespace SecMaster
{
    public interface ISecurityRespository
    {
        IEnumerable<Security> AllSecurities();

        Security GetById(ObjectId id);

        void Add(Security security);

        void Update(Security security);

        bool Remove(ObjectId id);
    }
    public class SecurityRepository : ISecurityRespository
    {
        private readonly Settings _settings;
        private readonly MongoDatabase _database;

        public SecurityRepository(IOptions<Settings> settings)
        {
            _settings = settings.Options;
            _database = Connect();
        }

        public void Add(Security security)
        {
            _database.GetCollection<Security>("securities").Save(security);
        }

        public IEnumerable<Security> AllSecurities()
        {
            var securities = _database.GetCollection<Security>("securities").FindAll();
            return securities;
        }

        public Security GetById(ObjectId id)
        {
            var query = Query<Security>.EQ(e => e.Id, id);
            var security = _database.GetCollection<Security>("securities").FindOne(query);

            return security;
        }

        public bool Remove(ObjectId id)
        {
            var query = Query<Security>.EQ(e => e.Id, id);
            var result = _database.GetCollection<Security>("securities").Remove(query);

            return GetById(id) == null;
        }

        public void Update(Security security)
        {
            var query = Query<Security>.EQ(e => e.Id, security.Id);
            var update = Update<Security>.Replace(security); // update modifiers
            _database.GetCollection<Security>("securities").Update(query, update);
        }

        private MongoDatabase Connect()
        {
            var client = new MongoClient(_settings.MongoConnection);
            var server = client.GetServer();
            var database = server.GetDatabase(_settings.Database);

            return database;
        }
    }
}
