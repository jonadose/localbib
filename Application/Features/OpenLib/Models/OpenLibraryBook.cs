using System.Text.Json.Serialization;

namespace Application.Features.OpenLib.Models
{
    public class OpenLibraryBook
    {
        public Identifiers Identifiers { get; set; } = new();
        public string Title { get; set; } = string.Empty;
        public List<Author> Authors { get; set; } = new();
        [JsonPropertyName("publish_date")]
        public string PublishDate { get; set; } = string.Empty;
        public List<string> Publishers { get; set; } = new();
        public List<int> Covers { get; set; } = new();
        public List<string> Contributions { get; set; } = new();
        public List<Language> Languages { get; set; } = new();
        [JsonPropertyName("source_records")]
        public List<string> SourceRecords { get; set; } = new();
        [JsonPropertyName("local_id")]
        public List<string> LocalId { get; set; } = new();
        public Type Type { get; set; } = new();
        [JsonPropertyName("first_sentence")]
        public FirstSentence FirstSentence { get; set; } = new();
        public string Key { get; set; } = string.Empty;
        [JsonPropertyName("number_of_pages")]
        public int NumberOfPages { get; set; } = new();
        public List<Work> Works { get; set; } = new();
        public Dictionary<string, object> Classifications { get; set; } = new();
        public string Ocaid { get; set; } = string.Empty;
        [JsonPropertyName("isbn_10")]
        public List<string> Isbn10 { get; set; } = new();
        [JsonPropertyName("isbn_13")]
        public List<string> Isbn13 { get; set; } = new();
        [JsonPropertyName("latest_revision")]
        public int LatestRevision { get; set; } = new();
        public int Revision { get; set; } = new();
        public Created Created { get; set; } = new();
        [JsonPropertyName("last_modified")]
        public LastModified LastModified { get; set; } = new();
    }

    public class Identifiers
    {
        public Dictionary<string, List<string>> IdentifiersList { get; set; } = new();
    }

    public class Author
    {
        public string Key { get; set; } = string.Empty;
    }

    public class Language
    {
        public string Key { get; set; } = string.Empty;
    }

    public class Type
    {
        public string Key { get; set; } = string.Empty;
    }

    public class FirstSentence
    {
        public string Type { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }

    public class Work
    {
        public string Key { get; set; } = string.Empty;
    }

    public class Created
    {
        public string Type { get; set; } = string.Empty;
        public DateTimeOffset Value { get; set; } = new();
    }

    public class LastModified
    {
        public string Type { get; set; } = string.Empty;
        public DateTimeOffset Value { get; set; } = new();
    }
}
