﻿using static WebClient.Models.DeserializeModels.CarData;

namespace WebClient.Models.DeserializeModels
{
    public class TenderData
    {

        public List<TenderDataPart> data { get; set; }
        public int status { get; set; }
        public string message { get; set; }
        public object exception { get; set; }

    }
    public class TenderDataPart
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string carId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string tenderTitle { get; set; }
        public string tenderComment { get; set; }
        public int basePrice { get; set; }
        public int startPrice { get; set; }
        public CarDataPart car { get; set; }
    }


}
