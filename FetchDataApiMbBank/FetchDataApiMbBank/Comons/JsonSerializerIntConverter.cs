using System.Text.Json;
using System.Text.Json.Serialization;

namespace DigitalFUHubApi.Comons
{
	public class JsonSerializerIntConverter : JsonConverter<int>
	{
		public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return int.Parse(reader.GetString() ?? string.Empty);
		}

		public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}
}
