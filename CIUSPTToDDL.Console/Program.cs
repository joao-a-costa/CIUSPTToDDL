using Newtonsoft.Json;
/// <summary>
/// Parses the given XML file containing a CIUSPT invoice and maps it to an ItemTransaction object.
/// </summary>
/// <param name="fileToParse">The XML file content to parse.</param>
/// <returns>An ItemTransaction object representing the parsed invoice.</returns>
var itemTransaction = CIUSPTToDDL.CIUSPTToDDL.Parse(CIUSPTToDDL.Console.Properties.Resources.ciusptSampleFile);

/// <summary>
/// JSON serialization options.
/// </summary>
var serializeOptions = new JsonSerializerSettings
{
    NullValueHandling = NullValueHandling.Ignore,
};

/// <summary>
/// Serialize the item transaction object to JSON format.
/// </summary>
var serializeJson = JsonConvert.SerializeObject(itemTransaction, Formatting.Indented, serializeOptions);

Console.WriteLine(serializeJson);