using IndianStatesCensus.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace IndianStatesCensus
{
    public class CensusAnalyzer
    {
        public enum Country
        {
            INDIA,US,BRAZIL
        }

        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string,CensusDTO> LoadCensusData(Country country,string csvFilePath,string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }

        //public object GetSortedStateCodeDataInJsonFormat(Country country,string csvFilePath,string dataheaders,string sortField, SortOrder.S)
        //{
        //    var censusData = LoadCensusData(country, csvFilePath, dataheaders);
        //    List<CensusDTO> lines = censusData.Values.ToList();
        //    List<CensusDTO> lists = GetSortedData(sortField, lines);
        //    if (sortBy.Equals(SortOrder.SortBy.DESC))
        //    {
        //        lists.Reverse();
        //    }
        //    return JsonConvert.SerializeObject(lists);
        //}

        //public List<CensusDTO> GetSortedData(string sortField,List<CensusDTO> lines)
        //{
        //    switch (sortField)
        //    {
        //        case "stateName": return lines.OrderBy(x => x.stateName).ToList();
        //        case "stateCode": return lines.OrderBy(x => x.stateCode).ToList();
        //        case "state": return lines.OrderBy(x => x.state).ToList();
        //        case "area": return lines.OrderBy(x => x.area).ToList();
        //        case "usArea": return lines.OrderBy(x => x.totalArea).ToList();
        //        case "populationDensity": return lines.OrderBy(x => x.populationDensity).ToList();
        //        case "density": return lines.OrderBy(x => x.density).ToList();
        //        case "population": return lines.OrderBy(x=>x.population).ToList();
        //        default: return lines.OrderBy(x => x.tin).ToList();
        //    }
        //}

    }
}
