using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using TRD_Analytics.Application.Map;
using TRD_Analytics.Domain.Entities;

namespace TRD_Analytics.Infrastructure.Database;

public class ParseData
{
    public static List<MatchEntity> ParseMatchEntities(string csvFile)
    {

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
        };

        using var reader = new StreamReader(csvFile);
        using var csv = new CsvReader(reader, config);
        
        csv.Context.RegisterClassMap<MatchEntityMap>();
        var records = csv.GetRecords<MatchEntity>();
        return records.ToList();
    }
}