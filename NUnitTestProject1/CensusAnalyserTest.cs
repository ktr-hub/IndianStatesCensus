using NUnit.Framework;
using IndianStatesCensus.DTO;
using IndianStatesCensus.POCO;
using static IndianStatesCensus.CensusAnalyzer;
using System.Collections.Generic;
using IndianStatesCensus;

namespace NUnitTestProject1
{
    public class CensusAnalyserTest
    {
        static string indianStateCensusHeaders = @"State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = @"SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\WrongIndiaStateCensusData.csv";
        static string delimeterIndianCensusFilePath = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\DelimiterIndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\WrongIndiaStateCensusData.csv";
        static string wrongIndianCensusFileType = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\IndiaStateCensusData.txt";
        static string indianStateCodeFilePath = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\IndiaStateCode.csv";
        static string wrongIndianStateCodeFileType = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\IndiaStateCode.txt";
        static string delimeterIndianStateCodeFilePath = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\DelimiterIndiaStateCode.csv";
        static string wrongHeaderStateCodeFilePath = @"C:\Users\Tirupathi Rao\source\repos\IndianStatesCensus\IndianStatesCensus\CSVFiles\WrongIndiaStateCode.csv";

        IndianStatesCensus.CensusAnalyzer censusAnalyzer;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyzer = new CensusAnalyzer();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        //UC-1
        //HAPPY Test Case
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29,totalRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(37, totalRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenIndianCensusDataFileTypeWrong_WhenReaded_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongIndianCensusFileType, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenIndianCensusDataFileDelimeterWrong_WhenReaded_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, delimeterIndianCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenIndianCensusDataFileCsvHeaderWrong_WhenReaded_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongHeaderIndianCensusFilePath, wrongHeaderIndianCensusFilePath);
            Assert.AreEqual(29, totalRecord.Count);
        }

        //UC-2
        //HAPPY Test Case
        [Test]
        public void GivenStateCode_WhenReaded_ShouldReturnCensusDataCount()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(37, stateRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenStateCode_WhenReaded_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(29, stateRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenStateCodeFileTypeWrong_WhenReaded_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongIndianStateCodeFileType, indianStateCodeHeaders);
            Assert.AreEqual(37, stateRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenStateCodeFileDelimeterWrong_WhenReaded_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, delimeterIndianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(37, stateRecord.Count);
        }

        //SAD Test Case
        [Test]
        public void GivenStateCodeFileCsvHeaderWrong_WhenReaded_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongHeaderStateCodeFilePath, wrongHeaderStateCodeFilePath);
            Assert.AreEqual(37, stateRecord.Count);
        }


    }
}