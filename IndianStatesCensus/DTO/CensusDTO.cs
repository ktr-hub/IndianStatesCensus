﻿using IndianStatesCensus.POCO;

namespace IndianStatesCensus.DTO
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;


        public CensusDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.stateCode = stateCodeDao.stateCode;
        }

        public CensusDTO(CensusDataDAO censusDataDao)
        {
            this.state = censusDataDao.state;
            this.population = censusDataDao.population;
            this.area = censusDataDao.area;
            this.density = censusDataDao.density;
        }

        //public CensusDTO(USCensusDAO usCensusDAO)
        //{
        //    this.stateCode = usCensusDAO.stateId;
        //    this.stateName = usCensusDAO.stateName;
        //    this.population = usCensusDAO.population;
        //    this.housingUnits = usCensusDAO.housingUnits;
        //    this.totalArea = usCensusDAO.totalArea;
        //    this.waterArea = usCensusDAO.waterArea;
        //    this.landArea = usCensusDAO.landArea;
        //    this.populationDensity = usCensusDAO.populationDensity;
        //    this.housingDensity = usCensusDAO.housingDensity;
        //}



    }
}
