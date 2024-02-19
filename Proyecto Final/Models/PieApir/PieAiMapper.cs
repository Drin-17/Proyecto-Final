
using DijitalSftwafeModelPieApi;

//class Program
//{
//    static void Main()
//    {
//        // Configurar AutoMapper
//        Mapper.Initialize(cfg => {
//            cfg.CreateMap<JsonEntity, Entity>();
//            cfg.CreateMap<JsonCategory, Category>();
//            // Agrega más mapeos según sea necesario
//        });

//        // Tu JSON string
//        string jsonString = ObtenerJsonString();  // Reemplaza esto con tu método para obtener el JSON

//        // Deserializar JSON a clase JSON
//        var jsonModel = JsonConvert.DeserializeObject<JsonPieApiTrackResponce>(jsonString);

//        // Mapear de la clase JSON a la clase de destino
//        var pieApiTrackResponse = Mapper.Map<PieApiTrackResponce>(jsonModel);

//        // Ahora puedes trabajar con pieApiTrackResponse que tiene las clases mapeadas
//    }

//    // Clase para el JSON
//    public class JsonPieApiTrackResponce
//    {
//        public List<JsonResult> Results { get; set; }
//    }

//    public class JsonResult
//    {
//        public JsonEntity Entity { get; set; }
//        public double Score { get; set; }
//        public string Type { get; set; }
//    }

//    public class JsonEntity
//    {
//        public JsonCategory Category { get; set; }
//        public JsonCountry Country { get; set; }
//        // Agrega más propiedades según sea necesario
//    }

//    public class JsonCategory
//    {
//        public string Flag { get; set; }
//        // Agrega más propiedades según sea necesario
//    }

//    public class JsonCountry
//    {
//        public string Alpha2 { get; set; }
//        // Agrega más propiedades según sea necesario
//    }

//    // Agrega más clases según sea necesario
//} 