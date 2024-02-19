﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ProyectoFinal.Models.Unsplash;
//
//    var searchImagesResponse = SearchImagesResponse.FromJson(jsonString);

namespace ProyectoFinal.Models.Unsplash
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SearchImagesResponse
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("promoted_at")]
        public DateTimeOffset? PromotedAt { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("blur_hash")]
        public string BlurHash { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alt_description")]
        public string AltDescription { get; set; }

        [JsonProperty("breadcrumbs")]
        public List<Breadcrumb> Breadcrumbs { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        [JsonProperty("links")]
        public ResultLinks Links { get; set; }

        [JsonProperty("likes")]
        public long Likes { get; set; }

        [JsonProperty("liked_by_user")]
        public bool LikedByUser { get; set; }

        [JsonProperty("current_user_collections")]
        public List<object> CurrentUserCollections { get; set; }

        [JsonProperty("sponsorship")]
        public Sponsorship Sponsorship { get; set; }

        [JsonProperty("topic_submissions")]
        public ResultTopicSubmissions TopicSubmissions { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }
    }

    public partial class Breadcrumb
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("index")]
        public long Index { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }

    public partial class ResultLinks
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("html")]
        public Uri Html { get; set; }

        [JsonProperty("download")]
        public Uri Download { get; set; }

        [JsonProperty("download_location")]
        public Uri DownloadLocation { get; set; }
    }

    public partial class Sponsorship
    {
        [JsonProperty("impression_urls")]
        public List<object> ImpressionUrls { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("tagline_url")]
        public Uri TaglineUrl { get; set; }

        [JsonProperty("sponsor")]
        public User Sponsor { get; set; }
    }

    public partial class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public Uri PortfolioUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("links")]
        public UserLinks Links { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage ProfileImage { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUsername { get; set; }

        [JsonProperty("total_collections")]
        public long TotalCollections { get; set; }

        [JsonProperty("total_likes")]
        public long TotalLikes { get; set; }

        [JsonProperty("total_photos")]
        public long TotalPhotos { get; set; }

        [JsonProperty("total_promoted_photos")]
        public long TotalPromotedPhotos { get; set; }

        [JsonProperty("accepted_tos")]
        public bool AcceptedTos { get; set; }

        [JsonProperty("for_hire")]
        public bool ForHire { get; set; }

        [JsonProperty("social")]
        public Social Social { get; set; }
    }

    public partial class UserLinks
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("html")]
        public Uri Html { get; set; }

        [JsonProperty("photos")]
        public Uri Photos { get; set; }

        [JsonProperty("likes")]
        public Uri Likes { get; set; }

        [JsonProperty("portfolio")]
        public Uri Portfolio { get; set; }

        [JsonProperty("following")]
        public Uri Following { get; set; }

        [JsonProperty("followers")]
        public Uri Followers { get; set; }
    }

    public partial class ProfileImage
    {
        [JsonProperty("small")]
        public Uri Small { get; set; }

        [JsonProperty("medium")]
        public Uri Medium { get; set; }

        [JsonProperty("large")]
        public Uri Large { get; set; }
    }

    public partial class Social
    {
        [JsonProperty("instagram_username")]
        public string InstagramUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public Uri PortfolioUrl { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("paypal_email")]
        public object PaypalEmail { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source Source { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("ancestry")]
        public Ancestry Ancestry { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("cover_photo")]
        public CoverPhoto CoverPhoto { get; set; }
    }

    public partial class Ancestry
    {
        [JsonProperty("type")]
        public Category Type { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public Category Category { get; set; }

        [JsonProperty("subcategory", NullValueHandling = NullValueHandling.Ignore)]
        public Category Subcategory { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }

    public partial class CoverPhoto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("promoted_at")]
        public DateTimeOffset? PromotedAt { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("blur_hash")]
        public string BlurHash { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alt_description")]
        public string AltDescription { get; set; }

        [JsonProperty("breadcrumbs")]
        public List<Breadcrumb> Breadcrumbs { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        [JsonProperty("links")]
        public ResultLinks Links { get; set; }

        [JsonProperty("likes")]
        public long Likes { get; set; }

        [JsonProperty("liked_by_user")]
        public bool LikedByUser { get; set; }

        [JsonProperty("current_user_collections")]
        public List<object> CurrentUserCollections { get; set; }

        [JsonProperty("sponsorship")]
        public object Sponsorship { get; set; }

        [JsonProperty("topic_submissions")]
        public CoverPhotoTopicSubmissions TopicSubmissions { get; set; }

        [JsonProperty("premium", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Premium { get; set; }

        [JsonProperty("plus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Plus { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public partial class CoverPhotoTopicSubmissions
    {
        [JsonProperty("health", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink Health { get; set; }

        [JsonProperty("nature", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink Nature { get; set; }

        [JsonProperty("wallpapers", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink Wallpapers { get; set; }

        [JsonProperty("food-drink", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink FoodDrink { get; set; }

        [JsonProperty("color-of-water", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink ColorOfWater { get; set; }

        [JsonProperty("textures-patterns", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink TexturesPatterns { get; set; }
    }

    public partial class FoodDrink
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("approved_on")]
        public DateTimeOffset ApprovedOn { get; set; }
    }

    public partial class Urls
    {
        [JsonProperty("raw")]
        public Uri Raw { get; set; }

        [JsonProperty("full")]
        public Uri Full { get; set; }

        [JsonProperty("regular")]
        public Uri Regular { get; set; }

        [JsonProperty("small")]
        public Uri Small { get; set; }

        [JsonProperty("thumb")]
        public Uri Thumb { get; set; }

        [JsonProperty("small_s3")]
        public Uri SmallS3 { get; set; }
    }

    public partial class ResultTopicSubmissions
    {
        [JsonProperty("food-drink", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink FoodDrink { get; set; }

        [JsonProperty("health", NullValueHandling = NullValueHandling.Ignore)]
        public FoodDrink Health { get; set; }
    }

    public enum TypeEnum { LandingPage, Search };

    public enum Status { Approved };

    public partial class SearchImagesResponse
    {
        public static SearchImagesResponse FromJson(string json) => JsonConvert.DeserializeObject<SearchImagesResponse>(json, ProyectoFinal.Models.Unsplash.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SearchImagesResponse self) => JsonConvert.SerializeObject(self, ProyectoFinal.Models.Unsplash.Converter.Settings);
    }
    public partial class Result
    {
        public static Result FromJson(string json) => JsonConvert.DeserializeObject<Result>(json, ProyectoFinal.Models.Unsplash.Converter.Settings);
    }

    public static class SerializeR
    {
        public static string ToJson(this Result self) => JsonConvert.SerializeObject(self, ProyectoFinal.Models.Unsplash.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "landing_page":
                    return TypeEnum.LandingPage;
                case "search":
                    return TypeEnum.Search;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.LandingPage:
                    serializer.Serialize(writer, "landing_page");
                    return;
                case TypeEnum.Search:
                    serializer.Serialize(writer, "search");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "approved")
            {
                return Status.Approved;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Approved)
            {
                serializer.Serialize(writer, "approved");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}