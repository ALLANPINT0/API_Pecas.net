using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API_PECAS.Adapters.MongoDB.DTO
{
    public class Pecas
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Ref")]
        public double Ref { get; set; }
        [BsonElement("Price")]
        public float Price { get; set; }
        [BsonElement("Marca")]
        public string Marca { get; set; }
    
    }
}
