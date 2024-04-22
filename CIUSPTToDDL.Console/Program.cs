using Newtonsoft.Json;

var cIUSPTToDDL = new CIUSPTToDDL.Lib.CIUSPTToDDL();
var itemTransaction = cIUSPTToDDL.Parse(CIUSPTToDDL.Console.Properties.Resources.ciusptSampleFile3);
var itemtransactionUBL = cIUSPTToDDL.ItemTransactionUBL;


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
//var serializeJson = JsonConvert.SerializeObject(itemTransaction, Formatting.Indented);

Console.WriteLine(serializeJson);