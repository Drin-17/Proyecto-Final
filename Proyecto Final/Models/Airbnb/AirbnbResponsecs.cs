﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Proyecto_Final.Models.Airbnb;
//
//    var airbnbResponse = AirbnbResponse.FromJson(jsonString);

namespace Proyecto_Final.Models.Airbnb
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AirbnbResponse
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("headers")]
        public Headers Headers { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public partial class Headers
    {
        [JsonProperty("response_time")]
        public long ResponseTime { get; set; }

        [JsonProperty("response_timestamp")]
        public DateTimeOffset ResponseTimestamp { get; set; }

        [JsonProperty("response_id")]
        public long ResponseId { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("deeplink")]
        public Uri Deeplink { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bathrooms")]
        public double Bathrooms { get; set; }

        [JsonProperty("bedrooms")]
        public long Bedrooms { get; set; }

        [JsonProperty("beds")]
        public long Beds { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("images")]
        public List<Uri> Images { get; set; }

        [JsonProperty("hostThumbnail")]
        public Uri HostThumbnail { get; set; }

        [JsonProperty("isSuperhost")]
        public bool IsSuperhost { get; set; }

        [JsonProperty("rareFind")]
        public bool RareFind { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("persons")]
        public long Persons { get; set; }

        [JsonProperty("reviewsCount")]
        public long ReviewsCount { get; set; }

        [JsonProperty("rating", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rating { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("amenityIds")]
        public List<long> AmenityIds { get; set; }

        [JsonProperty("previewAmenities")]
        public List<object> PreviewAmenities { get; set; }

        [JsonProperty("cancelPolicy")]
        public CancelPolicy CancelPolicy { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("rate")]
        public long Rate { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("priceItems")]
        public List<PriceItem> PriceItems { get; set; }
    }

    public partial class PriceItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }
    }

    public enum CancelPolicy { CancelBetterStrictWithGracePeriod, CancelFlexible, CancelModerate, CancelStrict14_WithGracePeriod };

    public enum Currency { Usd };

    public partial class AirbnbResponse
    {
        public static AirbnbResponse FromJson(string json) => JsonConvert.DeserializeObject<AirbnbResponse>(json, Proyecto_Final.Models.Airbnb.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AirbnbResponse self) => JsonConvert.SerializeObject(self, Proyecto_Final.Models.Airbnb.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CancelPolicyConverter.Singleton,
                CurrencyConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CancelPolicyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CancelPolicy) || t == typeof(CancelPolicy?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CANCEL_BETTER_STRICT_WITH_GRACE_PERIOD":
                    return CancelPolicy.CancelBetterStrictWithGracePeriod;
                case "CANCEL_FLEXIBLE":
                    return CancelPolicy.CancelFlexible;
                case "CANCEL_MODERATE":
                    return CancelPolicy.CancelModerate;
                case "CANCEL_STRICT_14_WITH_GRACE_PERIOD":
                    return CancelPolicy.CancelStrict14_WithGracePeriod;
            }
            throw new Exception("Cannot unmarshal type CancelPolicy");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CancelPolicy)untypedValue;
            switch (value)
            {
                case CancelPolicy.CancelBetterStrictWithGracePeriod:
                    serializer.Serialize(writer, "CANCEL_BETTER_STRICT_WITH_GRACE_PERIOD");
                    return;
                case CancelPolicy.CancelFlexible:
                    serializer.Serialize(writer, "CANCEL_FLEXIBLE");
                    return;
                case CancelPolicy.CancelModerate:
                    serializer.Serialize(writer, "CANCEL_MODERATE");
                    return;
                case CancelPolicy.CancelStrict14_WithGracePeriod:
                    serializer.Serialize(writer, "CANCEL_STRICT_14_WITH_GRACE_PERIOD");
                    return;
            }
            throw new Exception("Cannot marshal type CancelPolicy");
        }

        public static readonly CancelPolicyConverter Singleton = new CancelPolicyConverter();
    }

    internal class CurrencyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Currency) || t == typeof(Currency?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "USD")
            {
                return Currency.Usd;
            }
            throw new Exception("Cannot unmarshal type Currency");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Currency)untypedValue;
            if (value == Currency.Usd)
            {
                serializer.Serialize(writer, "USD");
                return;
            }
            throw new Exception("Cannot marshal type Currency");
        }

        public static readonly CurrencyConverter Singleton = new CurrencyConverter();
    }
}