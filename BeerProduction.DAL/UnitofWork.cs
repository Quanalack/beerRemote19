using System;
using BeerProduction.DAL.Models;
using BeerProduction.DAL.Repos;

namespace BeerProduction.DAL
{
    public class UnitofWork
    {
        private readonly Context _dbContext;
        public StateRepo<State> StateRepos { get; set; }
        public StopReasonRepo<StopReason> StopReasonRepos { get; set; }
        public BatchReportRepo<BatchReport> BatchReportRepos { get; set; }
        public TemperatureRepo<Temperature> TemperatureRepos { get; set; }
        public HumidityRepo<Humidity> HumidityRepos { get; set; }
        public MachineSpeedRepo<MachineSpeed> MachineSpeedRepos { get; set; }
        public UnitofWork()
        {
        _dbContext = Context.Create();
        StateRepos = new StateRepo<State>(_dbContext);
        StopReasonRepos = new StopReasonRepo<StopReason>(_dbContext);
        BatchReportRepos = new BatchReportRepo<BatchReport>(_dbContext);
        TemperatureRepos = new TemperatureRepo<Temperature>(_dbContext);
        HumidityRepos = new HumidityRepo<Humidity>(_dbContext);
        MachineSpeedRepos = new MachineSpeedRepo<MachineSpeed>(_dbContext);
        }

        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
            }
        }
    }
    
}